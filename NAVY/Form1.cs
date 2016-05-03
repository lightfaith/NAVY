using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Neural;
using Fractals;
using CellularAutomata;

namespace NAVY
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//GroupBoxRenderer.RenderMatchingApplicationState = false;
			//grpNeuralInterval.ForeColor = Color.Silver;
			picFractalsPicture.MouseWheel += PicFractalsPicture_MouseWheel;

		}


		// = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

		Dictionary<String, TransferFunction> functionlist;
		Brain brain = new Brain();
		Dictionary<int, double> ges = null;

		//
		// -------------------------- HOPFIELD --------------------------------
		//

		Hopfield hop = new Hopfield(5, 7, 30);
		List<double> hopimage = new List<double>();

		//
		// -------------------------- FRACTALS ---------------------------------
		//

		Fractal fractal;
		//
		// -------------------------- FRACTALS ---------------------------------
		//

		GOL gol;
		List<Tuple<int, int>> cellstochange;
		//
		// -------------------------- LOAD -------------------------------------
		//

		private void Form1_Load(object sender, EventArgs e)
		{
			tabControl.SelectedTab = tabControl.TabPages[2];
			tabControlFractals.SelectedTab = tabControlFractals.TabPages[0];

			functionlist = new Dictionary<String, TransferFunction>();
			functionlist.Add("Linear", new Linear());
			functionlist.Add("Binary Unipolar", new BinaryUnipolar());
			functionlist.Add("Binary Bipolar", new BinaryBipolar());
			functionlist.Add("Logistic", new Logistic());
			functionlist.Add("Hyperbolic Tangent", new HyperbolicTangent());
			functionlist.Add("Gaussian", new Gaussian());
			columnFunction.DataSource = functionlist.Keys.ToList<String>();

			//add default row
			AddNewLayer();

			//clear charts
			chartLSP.ChartAreas.Clear();
			chartLSP.Series.Clear();
			chartStatus.Series.Clear();
			chartStatus.ChartAreas.Clear();

			// hopfield stuff
			for (int i = 0; i < hop.Width * hop.Height; i++)
				hopimage.Add(0);

			cmbHopfieldSymbols.DataSource = Hopfield.Symbols.Keys.ToList<char>();
			btnHopfieldClear_Click(sender, e);

			// fractal stuff
			/*cmbFractalExamples.DataSource = Fractal.Examples.Keys.ToList<String>();
			cmbFractalExamples.SelectedIndex = 1;
			*/
			fractal = new Fractal(/*Fractals.Configuration.IFSTree(Fractal.Width, Fractal.Height)*/);
			DrawFractal(picFractalsPicture, fractal);
			UpdateFractalGrid();

			// CA stuff
			gol = new GOL(picCAWorld.Width, picCAWorld.Height, (int)numCAPixel.Value);
			picCAWorld.Image = new Bitmap(picCAWorld.Width, picCAWorld.Height);
			using (Graphics g = Graphics.FromImage(picCAWorld.Image))
				g.Clear(Color.Black);
			cellstochange = new List<Tuple<int, int>>();
		}

		private void gridNeural_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{

		}

		private void btnNeuralAddLayer_Click(object sender, EventArgs e)
		{
			AddNewLayer();
		}

		private void btnNeuralDeleteLayer_Click(object sender, EventArgs e)
		{
			//delete all selected
			foreach (DataGridViewCell oneCell in gridNeuralLayers.SelectedCells)
			{
				if (oneCell.Selected)
					gridNeuralLayers.Rows.RemoveAt(oneCell.RowIndex);
			}
			//re-number layers
			foreach (DataGridViewRow row in gridNeuralLayers.Rows)
			{
				row.Cells["columnLayer"].Value = row.Index + 1;
			}
		}


		private void btnNeuralRun_Click(object sender, EventArgs e)
		{
			ges = new Dictionary<int, double>(); // Global Errors
			barNeuralMatch.Value = 0;
			if (txtNeuralInput.Lines.Count((s) => s.Trim() != "") != txtNeuralExpected.Lines.Count((s) => s.Trim() != ""))
				return;

			// update NN
			Update();

			bool shouldloop = true;

			//do the magic
			for (int i = 0; i < (int)numNeuralEpoch.Value; i++)
			{
				switch (cmbNeuralAlgorithm.Text)
				{
					case "Activate": // basic computation
						{
							brain.Think();
							shouldloop = false; // no reason to repeat
							break;
						}
					case "SOMA": // basic computation
						{
							List<Neural.Configuration> population = new List<Neural.Configuration>();
							for (int j = 0; j < 50; j++)
								population.Add(new Neural.Configuration(brain, true));
							// also use actual configuration
							population.Add(new Neural.Configuration(brain));

							population = new SOMA().Run(population);

							//use the best one
							population.Sort((x, y) => x.GE.CompareTo(y.GE));
							brain.UpdateConfiguration(population[0]);
							brain.Think();
							break;
						}
					case "Fixed Increments":
						{
							brain.Think(NeuralNetworkAlgorithm.FixedIncrement);

							brain.Think(); // check again (no adaptation) to update values
							break;
						}
					case "Back Propagation":
						{
							brain = brain.Think(NeuralNetworkAlgorithm.BackPropagation);
							brain.Think(); // to compute final outputs
							break;
						}
					default:
						{
							txtLog.AppendText(String.Format("'{0}' algorithm is not implemented.\r\n", cmbNeuralAlgorithm.Text));
							shouldloop = false;
							break;
						}
				}

				barNeuralProgress.Value = (i + 1) * 10000 / (int)numNeuralEpoch.Value;

				txtNeuralOutput.Text = brain.GetDataStr(brain.Outputs);
				barNeuralMatch.Value = (int)(brain.ComputeMatch() * 100);

				UpdateNeuronDataGrid();
				txtNeuralSynapses.Text = brain.GetSynapsesStr();

				UpdateChartLSP();
				ges.Add(i + 1, brain.GetGlobalError());
				UpdateChartStatus();
				InvalidateAll();

				if (!shouldloop || brain.ComputeMatch() == 1)
				{
					double ge = brain.GetGlobalError();
					for (int j = i + 1; j < numNeuralEpoch.Value; j++)
						ges.Add(j + 1, ge);
					barNeuralProgress.Value = barNeuralProgress.Maximum;
					UpdateChartStatus();
					break;
				}
				if (i != numNeuralEpoch.Value - 1)
				{
					int sleeptime = (numNeuralEpoch.Value > 10) ? (int)(1000 / numNeuralEpoch.Value) : 200;
					if (sleeptime > 16) Thread.Sleep(sleeptime);
				}
			}
			txtLog.AppendText(String.Format("Finished with Global Error of {0}.\n", brain.GetGlobalError()));
		}

		private new void Update()
		{
			if (txtNeuralSynapses.Text.Length == 0)
				SynapseInit();

			// set layers also!
			Dictionary<int, List<Neuron>> neurons = new Dictionary<int, List<Neuron>>();
			int layercount = 0;
			foreach (DataGridViewRow row in gridNeuralLayers.Rows)
			{
				List<Neuron> layer = new List<Neuron>();
				for (int i = 0; i < Convert.ToInt32(row.Cells["columnNeurons"].Value); i++)
				{
					// neuron configuration already in datagrid? use it!
					var neuronrows = gridNeuralNeurons.Rows
						.Cast<DataGridViewRow>()
						.Where(r => r.Cells["columnNeuron"].Value.ToString().Equals(String.Format("n{0}_{1}", layercount, i)));

					int rowindex = neuronrows.Count() != 0 ? neuronrows.First().Index : -1;
					if (rowindex != -1) // add original
						layer.Add(
						new Neuron(
							layercount,                                                                                                     //layer
							i,                                                                                                              //index
							functionlist[(String)row.Cells["columnFunction"].Value],                                                        //function //imho ok to get this from main gridview  
							Convert.ToDouble(gridNeuralNeurons.Rows[rowindex].Cells["columnSlope"].Value.ToString().Replace(".", ",")),     //slope
							Convert.ToDouble(gridNeuralNeurons.Rows[rowindex].Cells["columnAugment"].Value.ToString().Replace(".", ","))    //augment
							));
					else // add brand new
						layer.Add(
							new Neuron(
								layercount,                                               //layer
								i,                                                        //index
								functionlist[(String)row.Cells["columnFunction"].Value],  //function
								Neuron.GetDefaultSlope(),                                 //slope
								Neuron.GetDefaultAugment()                                //augment
								)
						);
				}
				neurons.Add(layercount, layer);
				layercount++;
			}
			brain.UpdateStructure(neurons, txtNeuralSynapses.Text, txtNeuralInput.Text.Substring(0, txtNeuralInput.Text.IndexOf('\r')).Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Count());


			// prepare inputs and expected results
			List<List<double>> inputs = new List<List<double>>();
			List<List<double>> expected = new List<List<double>>();

			//for every line of input
			for (int i = 0; i < txtNeuralInput.Lines.Count((s) => s.Trim() != ""); i++)
			{
				String inputlinestr = txtNeuralInput.Lines[i];
				String expectedlinestr = txtNeuralExpected.Lines[i];
				List<double> inputline = new List<double>();
				List<double> expectedline = new List<double>();

				if (inputlinestr == "" || expectedlinestr == "")
					continue;

				// get initial input values
				foreach (string value in inputlinestr.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
					inputline.Add(Convert.ToDouble(value.Replace(".", ",")));
				inputs.Add(inputline);
				// get expected values
				foreach (string value in expectedlinestr.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
					expectedline.Add(Convert.ToDouble(value.Replace(".", ",")));
				expected.Add(expectedline);
			} //end for each initial input line


			brain.Inputs = inputs;
			brain.Expected = expected;
		}

		private void btnNeuralInputLoad_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
					txtNeuralInput.Text = sr.ReadToEnd();
		}

		private void btnNeuralExpectedLoad_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
					txtNeuralExpected.Text = sr.ReadToEnd();
		}

		private void btnNeuralSchema_Click(object sender, EventArgs e)
		{
			Update();
			UpdateNeuronDataGrid();
			Bitmap b = Schema.GetSchema(brain);
			txtNeuralSynapses.Text = brain.GetSynapsesStr();
			NeuralSchema schema = new NeuralSchema(b);
			schema.ShowDialog();
		}

		private void btnNeuralOutputSave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.FileName = "output.txt";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
					sw.Write(txtNeuralOutput.Text);
		}



		private void UpdateNeuronDataGrid()
		{
			gridNeuralNeurons.Rows.Clear();
			foreach (List<Neuron> layer in brain.Neurons.Values)
			{
				foreach (Neuron n in layer)
				{
					gridNeuralNeurons.Rows.Add();
					int rowindex = gridNeuralNeurons.Rows.Count - 1;
					gridNeuralNeurons.Rows[rowindex].Cells["columnNeuron"].Value = n.GetName();
					gridNeuralNeurons.Rows[rowindex].Cells["columnSlope"].Value = n.Slope;
					gridNeuralNeurons.Rows[rowindex].Cells["columnAugment"].Value = n.Augment;
				}
			}
		}

		private void btnNeuralSaveConfiguration_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "ANN file|*.ann";
			saveFileDialog1.AddExtension = true;
			Update();

			saveFileDialog1.FileName = "network";
			//saveFileDialog1.DefaultExt = "ann";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				IFormatter formatter = new BinaryFormatter();
				Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
				formatter.Serialize(stream, brain);
				stream.Close();
			}
		}

		private void btnNeuralLoadConfiguration_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "network.ann";
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				IFormatter formatter = new BinaryFormatter();
				Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
				brain = (Brain)formatter.Deserialize(stream);
				stream.Close();

				//show actual data
				txtNeuralInput.Text = brain.GetDataStr(brain.Inputs);
				txtNeuralExpected.Text = brain.GetDataStr(brain.Expected);
				gridNeuralLayers.Rows.Clear();
				for (int i = 0; i < brain.Neurons.Count; i++)
				{
					AddNewLayer(brain.Neurons[i].Count, functionlist.FirstOrDefault(x => x.Value.ToString() == brain.Neurons[i][0].f.ToString()).Key);
				}
				barNeuralMatch.Value = 0;
				UpdateNeuronDataGrid();
				txtNeuralSynapses.Text = brain.GetSynapsesStr();
			}
		}

		public void AddNewLayer(int neuroncount = 1, string function = "Binary Unipolar")
		{
			gridNeuralLayers.Rows.Add();
			int index = gridNeuralLayers.RowCount - 1;
			gridNeuralLayers.Rows[index].Cells["columnLayer"].Value = index + 1;
			gridNeuralLayers.Rows[index].Cells["columnNeurons"].Value = neuroncount;
			gridNeuralLayers.Rows[index].Cells["columnFunction"].Value = function;
		}

		public void SynapseInit(double? value = null)
		{
			String[] inputlines = txtNeuralInput.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			int inputnum = -1;
			foreach (String line in inputlines)
			{
				if (inputnum == -1)
				{
					inputnum = line.Count(c => c == ';') + 1;
					continue;
				}
				if (line.Count(c => c == ';') + 1 != inputnum)
				{
					txtLog.AppendText(String.Format("Inconsistent number of inputs! (line '{0}')\r\n", line));
					return;
				}
			}

			int activelayer = -1;
			StringBuilder sb = new StringBuilder();
			// for every layer, write synapses with random weights
			foreach (DataGridViewRow row in gridNeuralLayers.Rows)
			{
				int outputnum = Convert.ToInt32(row.Cells["columnNeurons"].Value);
				// for each source
				for (int i = 0; i < inputnum; i++)
				{
					// for each destination
					for (int j = 0; j < outputnum; j++)
					{
						double newvalue = (value != null) ? (double)value : Synapse.GetRandomWeight();
						if (activelayer == -1) //inputs
							sb.Append(string.Format("i{0}>n{1}_{2}:   {3:0.000}\r\n", i, activelayer + 1, j, newvalue));
						else
							sb.Append(string.Format("n{0}_{1}>n{2}_{3}: {4:0.000}\r\n", activelayer, i, activelayer + 1, j, newvalue));
					}
				}
				activelayer++;
				inputnum = outputnum;
			}
			txtNeuralSynapses.Text = sb.ToString();
		}

		private void btnNeuralSynapseRandom_Click(object sender, EventArgs e)
		{
			SynapseInit();
		}

		private void btnNeuralSynapsesZero_Click(object sender, EventArgs e)
		{
			SynapseInit(0);
		}

		private void btnNeuralNeuronsRandom_Click(object sender, EventArgs e)
		{
			Update();
			foreach (List<Neuron> layer in brain.Neurons.Values)
				foreach (Neuron n in layer)
				{
					n.Slope = Neuron.GetRandomSlope();
					n.Augment = Neuron.GetRandomAugment();
				}
			UpdateNeuronDataGrid();

		}

		private void btnNeuralNeuronsDefault_Click(object sender, EventArgs e)
		{
			Update();
			foreach (List<Neuron> layer in brain.Neurons.Values)
				foreach (Neuron n in layer)
				{
					n.Slope = Neuron.GetDefaultSlope();
					n.Augment = Neuron.GetDefaultAugment();
				}
			UpdateNeuronDataGrid();
		}

		private void btnNeuralNeuronsNoAugment_Click(object sender, EventArgs e)
		{
			Update();
			foreach (List<Neuron> layer in brain.Neurons.Values)
				foreach (Neuron n in layer)
					n.Augment = 0;

			UpdateNeuronDataGrid();
		}

		public void UpdateChartStatus()
		{
			chartStatus.ChartAreas.Clear();
			chartStatus.Series.Clear();

			ChartArea area = new ChartArea();

			area.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
			area.AxisX.TitleForeColor = System.Drawing.Color.Silver;
			area.AxisX.MajorGrid.LineColor = Color.Silver;
			area.AxisX.MajorGrid.Interval = (double)Math.Ceiling(numNeuralEpoch.Value / 10);
			area.AxisX.LabelStyle.ForeColor = Color.Silver;
			area.AxisX.LabelStyle.Interval = area.AxisX.MajorGrid.Interval * 2;
			area.AxisX.Minimum = 0;
			area.AxisX.Maximum = (double)numNeuralEpoch.Value;
			area.AxisX.LabelStyle.Format = "0";

			area.AxisX2.Enabled = AxisEnabled.False;

			double gemax = ges.Values.Max(); if (gemax == 0) gemax = 1;
			area.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
			area.AxisY.LineColor = System.Drawing.Color.Silver;
			area.AxisY.TitleForeColor = System.Drawing.Color.Silver;
			area.AxisY.MajorGrid.LineColor = Color.Silver;
			area.AxisY.MajorGrid.Interval = gemax / 4;
			area.AxisY.LabelStyle.ForeColor = Color.Silver;
			area.AxisY.LabelStyle.Interval = gemax / 4;
			area.AxisY.Minimum = 0;
			area.AxisY.Maximum = gemax * 1.1;
			area.AxisY.LabelStyle.Format = "0.0000000";

			area.AxisY2.Enabled = AxisEnabled.False;

			area.BackColor = System.Drawing.Color.FromArgb(0x22, 0x22, 0x22);
			area.BorderColor = System.Drawing.Color.White;
			area.BorderWidth = 1;
			area.Name = "Area";
			chartStatus.ChartAreas.Add(area);

			// draw GE
			Series s = new Series();
			s.ChartType = SeriesChartType.Line;
			s.Name = "Global Error";
			s.BorderWidth = 5;
			s.Color = Color.Lime;

			foreach (KeyValuePair<int, double> val in ges)
				s.Points.AddXY(val.Key, val.Value);
			chartStatus.Series.Add(s);
		}


		public void UpdateChartLSP()
		{

			chartLSP.ChartAreas.Clear();
			chartLSP.Series.Clear();

			//not a 2D LSP? don't do anything
			if (brain.Synapses.Count != 1 || brain.Inputs[0].Count != 2)//|| brain.Expected[0].Count != 1)
				return;

			// group inputs by expected result
			double? min = null;
			double? max = null;

			Dictionary<string, Series> seriedict = new Dictionary<string, Series>();
			for (int i = 0; i < brain.Inputs.Count; i++)
			{
				String group = String.Format("{0}", brain.Expected[i].Select(x => x.ToString()).Aggregate((a, b) => a.ToString() + ';' + b.ToString()));
				if (!seriedict.Keys.Contains(group))
					seriedict.Add(group, new Series(group));
				if (min == null || brain.Inputs[i][0] < min)
					min = brain.Inputs[i][0];
				if (max == null || brain.Inputs[i][0] > max)
					max = brain.Inputs[i][0];

				if (min == null || brain.Inputs[i][1] < min)
					min = brain.Inputs[i][1];
				if (max == null || brain.Inputs[i][1] > max)
					max = brain.Inputs[i][1];
				seriedict[group].Points.AddXY(brain.Inputs[i][0], brain.Inputs[i][1]);
			}

			double gridinterval = (double)((max - min) / 4);

			double padding = Math.Abs((double)(max - min) / 3);
			max += padding;
			min -= padding;


			// prepare area
			ChartArea area = new ChartArea();

			area.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
			area.AxisX.TitleForeColor = System.Drawing.Color.Silver;
			area.AxisX.MajorGrid.LineColor = Color.Silver;
			area.AxisX.MajorGrid.Interval = gridinterval;
			area.AxisX.LabelStyle.ForeColor = Color.Silver;
			area.AxisX.LabelStyle.Interval = gridinterval;
			area.AxisX.Minimum = (double)min;
			area.AxisX.Maximum = (double)max;
			area.AxisX.LabelStyle.Format = "0.00";

			area.AxisX2.Enabled = AxisEnabled.False;

			area.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
			area.AxisY.LineColor = System.Drawing.Color.Silver;
			area.AxisY.TitleForeColor = System.Drawing.Color.Silver;
			area.AxisY.MajorGrid.LineColor = Color.Silver;
			area.AxisY.MajorGrid.Interval = gridinterval;
			area.AxisY.LabelStyle.ForeColor = Color.Silver;
			area.AxisY.LabelStyle.Interval = gridinterval;
			area.AxisY.Minimum = (double)min;
			area.AxisY.Maximum = (double)max;
			area.AxisY.LabelStyle.Format = "0.00";

			area.AxisY2.Enabled = AxisEnabled.False;

			area.BackColor = System.Drawing.Color.FromArgb(0x22, 0x22, 0x22);
			area.BorderColor = System.Drawing.Color.White;
			area.BorderWidth = 1;
			area.Name = "Area";
			chartLSP.ChartAreas.Add(area);

			// series for points
			foreach (Series s in seriedict.Values)
			{
				s.ChartType = SeriesChartType.Point;
				s.MarkerSize = 10;
				chartLSP.Series.Add(s);
			}

			// series for separators (for output neurons)
			foreach (Neuron n in brain.Neurons[0])
			{
				Series lineserie = new Series();

				lineserie.Name = n.GetName();
				lineserie.ChartType = SeriesChartType.Line;
				lineserie.BorderWidth = 5;
				List<float> weights = new List<float>();

				foreach (Synapse s in (from x in brain.Synapses[-1] where x.Target == n select x).Distinct().ToList<Synapse>())
					weights.Add((float)s.Weight);
				weights.Add((float)n.Augment);
				foreach (PointF p in GetLineTerminators(weights, (float)min, (float)max))
				{
					double y = p.Y;
					if (p.Y == double.PositiveInfinity)
						y = (double)max;
					if (p.Y == double.NegativeInfinity)
						y = (double)min;

					lineserie.Points.AddXY(p.X, y);
				}
				chartLSP.Series.Add(lineserie);
			}
		}

		public void InvalidateAll()
		{
			txtLog.Update();
			txtNeuralOutput.Update();
			txtNeuralSynapses.Update();
			chartStatus.Update();
			chartLSP.Update();
			barNeuralMatch.Update();
		}


		public List<PointF> GetLineTerminators(List<float> weights, float min, float max)
		{
			List<PointF> result = new List<PointF>();
			result.Add(new PointF(min, (-weights[2] - weights[0] * min) / weights[1]));
			result.Add(new PointF(max, (-weights[2] - weights[0] * max) / weights[1]));
			return result;
		}

		private void btnNeuralActivate_Click(object sender, EventArgs e)
		{
			String oldalgo = cmbNeuralAlgorithm.Text;
			cmbNeuralAlgorithm.Text = "Activate";
			btnNeuralRun_Click(sender, e);
			cmbNeuralAlgorithm.Text = oldalgo;
		}




		private void RedrawHopfieldImage()
		{

			Bitmap b = picHopfieldInput.Image != null ? new Bitmap(picHopfieldInput.Image) : new Bitmap(picHopfieldInput.Width, picHopfieldInput.Height);
			using (Graphics g = Graphics.FromImage(b))
			{
				g.Clear(Color.White);
				// draw squares
				for (int i = 0; i < hop.Height; i++)
					for (int j = 0; j < hop.Width; j++)
					{
						double value = hopimage[i * hop.Width + j];
						Brush color = new SolidBrush(Color.FromArgb(255, (int)(value * 255), (int)(value * 255), (int)(value * 255)));
						g.FillRectangle(color, j * hop.Unit, i * hop.Unit, (j + 1) * hop.Unit, (i + 1) * hop.Unit);
					}

				for (int i = 0; i < hop.Width + 1; i++) // cols
					g.DrawLine(Pens.Gray, i * hop.Unit, 0, i * hop.Unit, b.Height);
				for (int i = 0; i < hop.Height + 1; i++) // rows
					g.DrawLine(Pens.Gray, 0, i * hop.Unit, b.Width, i * hop.Unit);
			}
			picHopfieldInput.Image = b;

		}
		private void btnHopfieldClear_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < hop.Height; i++)
				for (int j = 0; j < hop.Width; j++)
					hopimage[i * hop.Width + j] = 0;
			RedrawHopfieldImage();
		}

		private void btnHopfieldRandom_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			for (int i = 0; i < hop.Height; i++)
				for (int j = 0; j < hop.Width; j++)
				{
					hopimage[i * hop.Width + j] = (r.Next() % 2 == 0) ? 1 : 0;
				}
			RedrawHopfieldImage();
		}

		private void picHopfieldInput_Click(object sender, EventArgs e)
		{
			int x = ((MouseEventArgs)e).X;
			int y = ((MouseEventArgs)e).Y;
			hopimage[(int)(y / hop.Unit) * hop.Width + (int)(x / hop.Unit)] = Convert.ToDouble(cmbHopfieldValue.Text.Replace('.', ','));
			RedrawHopfieldImage();
		}

		private void picHopfieldLearn_Click(object sender, EventArgs e)
		{
			hop.Train(hopimage);

		}

		private void pciHopfieldClassify_Click(object sender, EventArgs e)
		{
			hopimage = (from x in hop.Classify(hopimage) select x).ToList<double>();
			RedrawHopfieldImage();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			hopimage = Hopfield.Symbols[cmbHopfieldSymbols.Text[0]].ToList<double>();
			RedrawHopfieldImage();
		}

		private void btnHopfieldNoise_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			for (int i = 0; i < hop.Height; i++)
				for (int j = 0; j < hop.Width; j++)
				{
					hopimage[i * hop.Width + j] = Math.Pow(r.NextDouble(), 3);
					if (hopimage[i * hop.Width + j] < 0)
						hopimage[i * hop.Width + j] = 0;
				}
			RedrawHopfieldImage();
		}

		private void DrawFractal(PictureBox pic, Fractal f)
		{
			if (pic.Image == null)
				pic.Image = new Bitmap(pic.Width, pic.Height);

			Random r = new Random();

			pic.Image = fractal.Picture;
			pic.Invalidate();
		}

		private void btnFractalsDraw_Click(object sender, EventArgs e)
		{
			UpdateFractalConfiguration();
			if (!fractal.Config.IsOK())
			{
				txtLog.AppendText("[-] Fractal configuration is wrong!\n");
				return;
			}
			for (int i = 0; i < numFractalsIterations.Value / 1000; i++)
			{
				fractal.Iterate(i * 1000, (int)(numFractalsScale.Value), (int)numFractalsXOffset.Value, (int)numFractalsYOffset.Value);
			}
			picFractalsPicture.Invalidate();
			DrawFractal(picFractalsPicture, fractal);
		}


		private void UpdateFractalGrid()
		{
			gridFractalsParameters.Rows.Clear();
			gridFractalsParameters.Columns.Clear();
			foreach (String title in fractal.Config.Values.Keys)
				gridFractalsParameters.Columns.Add(title.Replace(" ", ""), title);
			for (int i = 0; i < fractal.Config.Values["Probability"].Count; i++) // for each row
			{
				gridFractalsParameters.Rows.Add();
				for (int j = 0; j < fractal.Config.Values.Count; j++)
					gridFractalsParameters.Rows[i].Cells[j].Value = fractal.Config.Values[gridFractalsParameters.Columns[j].Name][i];
			}
		}

		private void UpdateFractalConfiguration()
		{
			foreach (DataGridViewColumn col in gridFractalsParameters.Columns)
			{
				fractal.Config.Values[col.Name] = new List<double>();
				for (int i = 0; i < gridFractalsParameters.Rows.Count; i++)
				{
					if (gridFractalsParameters.Rows[i].Cells[col.Name].Value == null)
						gridFractalsParameters.Rows[i].Cells[col.Name].Value = 0;
					fractal.Config.Values[col.Name].Add(Convert.ToDouble(gridFractalsParameters.Rows[i].Cells[col.Name].Value.ToString().Replace(".", ",")));
				}
			}
		}

		private void btnFractalsAttractorAdd_Click(object sender, EventArgs e)
		{
			gridFractalsParameters.Rows.Add();
			foreach (DataGridViewCell cell in gridFractalsParameters.Rows[gridFractalsParameters.Rows.Count - 1].Cells)
				cell.Value = 0;

		}

		private void btnFractalsAttractorDelete_Click(object sender, EventArgs e)
		{
			//delete all selected
			foreach (DataGridViewCell oneCell in gridFractalsParameters.SelectedCells)
			{
				if (oneCell.Selected)
					gridFractalsParameters.Rows.RemoveAt(oneCell.RowIndex);
			}
		}

		private void btnFractalsReset_Click(object sender, EventArgs e)
		{
			fractal.ClearPicture();
			DrawFractal(picFractalsPicture, fractal);
		}

		private void btnFractalsRandomize_Click(object sender, EventArgs e)
		{
			fractal.ClearPicture();
			Random r = new Random();
			// generate random probabilities with sum of 1
			double probpool = 1;
			int rowcount = gridFractalsParameters.Rows.Count;
			List<double> randvalues = new List<double>();
			for (int i = 0; i < rowcount - 1; i++)
			{
				randvalues.Add(Math.Round(r.NextDouble() * (probpool - (rowcount - i) * 0.01) / (rowcount - i), 3));
				probpool -= randvalues.Last<double>();
			}
			randvalues.Add(probpool);

			foreach (DataGridViewRow row in gridFractalsParameters.Rows)
			{
				foreach (DataGridViewColumn column in gridFractalsParameters.Columns)
				{
					DataGridViewCell cell = row.Cells[column.Name];
					if (column.Name == "Probability")
					{
						int probindex = r.Next(0, randvalues.Count);
						cell.Value = randvalues[probindex];
						randvalues.RemoveAt(probindex);
					}
					else
						cell.Value = Math.Round(r.NextDouble() * 3 - 1.5, 3);
				}
			}

		}

		private void btnFractalsSave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "CSV format|*.ifs";
			saveFileDialog1.FileName = "fractal";
			saveFileDialog1.AddExtension = true;

			UpdateFractalConfiguration();

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false))
				{
					StringBuilder sb = new StringBuilder();
					foreach (String column in fractal.Config.Values.Keys)
						sb.AppendFormat("{0};", column);
					sb.Remove(sb.Length - 1, 1);
					sw.WriteLine(sb.ToString());
					sb.Clear();
					for (int row = 0; row < fractal.Config.Values["Probability"].Count; row++)
					{
						foreach (String column in fractal.Config.Values.Keys)
							sb.AppendFormat("{0:0.000};", fractal.Config.Values[column][row]);
						sb.Remove(sb.Length - 1, 1);
						sw.WriteLine(sb.ToString());
						sb.Clear();
					}

				}
			}
		}

		private void btnFractalsLoad_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				fractal.ClearPicture();
				/*
				fractal.Points.Clear();
				fractal.Points.AddRange(fractal.Config.InitPoints);*/

				gridFractalsParameters.Rows.Clear();
				gridFractalsParameters.Columns.Clear();
				String data = "";
				using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
					data = sr.ReadToEnd();

				String[] rows = data.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
				// set columns
				foreach (String colname in rows[0].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
					gridFractalsParameters.Columns.Add(colname.Replace(" ", ""), colname);

				for (int row = 1; row < rows.Length; row++)
				{
					String[] values = rows[row].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
					gridFractalsParameters.Rows.Add();
					for (int value = 0; value < values.Length; value++)
					{
						gridFractalsParameters.Rows[row - 1].Cells[gridFractalsParameters.Columns[value].Name].Value = values[value];
					}
				}
				UpdateFractalConfiguration();
			}
		}

		private void btnFractalsGOCDraw_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			PointF center = new PointF(Fractal.Width / 2, Fractal.Height / 2);
			float distance = 0.85F * new float[] { Fractal.Width / 2, Fractal.Height / 2 }.Min();
			int n = (int)numFractalsGOCCount.Value;
			List<PointF> anchors = new List<PointF>(); // lead points
			for (int i = 0; i < n; i++)
			{
				anchors.Add(new PointF((float)(center.X + distance * Math.Sin(2 * Math.PI * i / n)), (float)(center.Y - distance * (float)Math.Cos(2 * Math.PI * i / n))));
			}

			Bitmap b = new Bitmap(picFractalsPicture.Width, picFractalsPicture.Height);
			double koef = (double)numFractalsGOCKoef.Value;
			using (Graphics g = Graphics.FromImage(b))
			{
				g.Clear(Color.Black);
				//foreach (PointF p in anchors)
				//	g.FillEllipse(Brushes.White, p.X - 10, p.Y - 10, 20, 20);
				double[] newpoint = new double[] { r.NextDouble() * Fractal.Width, r.NextDouble() * Fractal.Height };
				double[] lastpoint = new double[] { 0, 0 };
				for (int i = 0; i < 5000; i++)
				{
					lastpoint = newpoint;
					int toanchor = r.Next() % n;
					newpoint[0] = lastpoint[0] + (anchors[toanchor].X - lastpoint[0]) * koef;
					newpoint[1] = lastpoint[1] + (anchors[toanchor].Y - lastpoint[1]) * koef;
					g.FillRectangle(Brushes.White, (float)newpoint[0], (float)newpoint[1], 1, 1);
				}
			}
			picFractalsPicture.Image = b;
		}

		// - - - - - - - - - - - - - - - - - - - - - -
		// TEA
		// - - - - - - - - - - - - - - - - - - - - - - 

		Mandelbrot mandelbrot = new Mandelbrot(Fractal.Width, Fractal.Height);

		private void btnFractalsTEAReset_Click(object sender, EventArgs e)
		{
			mandelbrot = new Mandelbrot(Fractal.Width, Fractal.Height);
			double? cre = (checkFractalsTEAConstant.Checked) ? (double?)(numFractalsTEACre.Value) : null;
			double? cim = (checkFractalsTEAConstant.Checked) ? (double?)(numFractalsTEACim.Value) : null;
			mandelbrot.Recompute(cmbFractalsTEAColor.Text, cre, cim);
			picFractalsPicture.Image = mandelbrot.Picture;
		}



		private void PicFractalsPicture_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (picFractalsPicture.Image == mandelbrot.Picture)
			{
				if (e.Delta > 0)
					mandelbrot.ZoomIn(e.X, e.Y);
				else
					mandelbrot.ZoomOut(e.X, e.Y);
				double? cre = (checkFractalsTEAConstant.Checked) ? (double?)(numFractalsTEACre.Value) : null;
				double? cim = (checkFractalsTEAConstant.Checked) ? (double?)(numFractalsTEACim.Value) : null;
				mandelbrot.Recompute(cmbFractalsTEAColor.Text, cre, cim);
				picFractalsPicture.Invalidate();
			}
		}

		private void btnFractalsTeaSave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
			saveFileDialog1.FileName = "fractal";
			saveFileDialog1.AddExtension = true;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				String ext = Path.GetExtension(saveFileDialog1.FileName).ToLower();
				switch (ext)
				{
					case ".bmp":
						{
							picFractalsPicture.Image.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
							break;
						}
					case ".png":
						{
							picFractalsPicture.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
							break;
						}
					case ".jpeg":
					case ".jpg":
						{
							picFractalsPicture.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
							break;
						}
					case ".gif":
						{
							picFractalsPicture.Image.Save(saveFileDialog1.FileName, ImageFormat.Gif);
							break;
						}
				}
			}
		}

		private void checkFractalsTEAConstant_CheckedChanged(object sender, EventArgs e)
		{
			numFractalsTEACre.Enabled = checkFractalsTEAConstant.Checked;
			numFractalsTEACim.Enabled = checkFractalsTEAConstant.Checked;
		}

		private void picCAWorld_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				cellstochange.Add(new Tuple<int, int>(e.X, e.Y));
		}

		private void btnCARun_Click(object sender, EventArgs e)
		{	
			if (timerCA.Tag.ToString() == "off")
			{
				gol.SurvivePattern = (from c in txtCASurvive.Text.ToCharArray() select Convert.ToInt32(c)-0x30).ToArray<int>();
				gol.BirthPattern = (from c in txtCABirth.Text.ToCharArray() select Convert.ToInt32(c)-0x30).ToArray<int>();
				timerCA.Interval = Convert.ToInt32(numCADelay.Value);
				timerCA.Tag = "on";
				btnCARun.Text = "Stop";
				timerCA.Start();
			}
			else
			{
				timerCA.Stop();
				timerCA.Tag = "off";
				btnCARun.Text = "Start";
			}
		}

		private void btnCAStop_Click(object sender, EventArgs e)
		{
			timerCA.Stop();
			btnCARun.Text = "Start";
		}

		private void timerCA_Tick(object sender, EventArgs e)
		{
			gol.Iterate();
			picCAWorld.Image = gol.GetBitmap();
			picCAWorld.Invalidate();
		}

		private void numCAPixel_ValueChanged(object sender, EventArgs e)
		{
			gol = new GOL(picCAWorld.Width, picCAWorld.Height, (int)numCAPixel.Value);
		}

		private void btnCAClear_Click(object sender, EventArgs e)
		{
			gol.Clear();
			picCAWorld.Image = gol.GetBitmap();
			picCAWorld.Invalidate();
		
		}

		private void picCAWorld_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				foreach(Tuple<int, int> t in cellstochange)
					gol.InvertCell(t.Item1, t.Item2);
				picCAWorld.Image = gol.GetBitmap();
				cellstochange = new List<Tuple<int, int>>();
			}
		}

		private void btnCASave_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "Cellular Automata|*.ca";
			saveFileDialog1.FileName = "ca";
			saveFileDialog1.AddExtension = true;

			UpdateFractalConfiguration();

			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				IFormatter formatter = new BinaryFormatter();
				Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
				formatter.Serialize(stream, gol);
				stream.Close();
			}
		}

		private void btnCARandom_Click(object sender, EventArgs e)
		{
			gol.Random();
			picCAWorld.Image = gol.GetBitmap();
			picCAWorld.Invalidate();
		}

		private void btnCALoad_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				IFormatter formatter = new BinaryFormatter();
				Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
				gol = (GOL)formatter.Deserialize(stream);
				stream.Close();

				picCAWorld.Image = gol.GetBitmap();
				picCAWorld.Invalidate();
				timerCA.Tag = "on";
				btnCARun_Click(sender, e);
			}
		}
	}
}
