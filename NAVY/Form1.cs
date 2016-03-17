using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neural;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms.DataVisualization.Charting;

namespace NAVY
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//GroupBoxRenderer.RenderMatchingApplicationState = false;
			//grpNeuralInterval.ForeColor = Color.Silver;


		}

		// = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

		Dictionary<String, TransferFunction> functionlist;
		Brain brain = new Brain();

		private void Form1_Load(object sender, EventArgs e)
		{

			functionlist = new Dictionary<String, TransferFunction>();
			functionlist.Add("Linear", new Linear());
			functionlist.Add("Binary Unipolar", new BinaryUnipolar());
			functionlist.Add("Binary Bipolar", new BinaryBipolar());
			functionlist.Add("Logistic", new Logistic());
			functionlist.Add("Hyperbolic Tangent", new HyperbolicTangent());
			columnFunction.DataSource = functionlist.Keys.ToList<String>();

			//add default row
			AddNewLayer();

			//clear chart
			chart.ChartAreas.Clear();
			chart.Series.Clear();
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
			barNeuralMatch.Value = 0;
			if (txtNeuralInput.Lines.Count((s) => s.Trim() != "") != txtNeuralExpected.Lines.Count((s) => s.Trim() != ""))
				return;

			txtNeuralOutput.Text = "";

			// update neuron
			Update();

			//do the magic
			switch (cmbNeuralAlgorithm.Text)
			{
				case "Compute": // basic computation
					{
						brain.Think();
						break;
					}
				case "SOMA": // basic computation
					{
						List<Configuration> population = new List<Configuration>();
						for (int i = 0; i < 50; i++)
							population.Add(new Configuration(brain, true));
						// also use actual configuration
						population.Add(new Configuration(brain));

						for (int i = 0; i < (int)numNeuralEpoch.Value; i++)
						{
							population = new SOMA().Run(population);
							barNeuralProgress.Value = (i + 1) * 100 / (int)numNeuralEpoch.Value;
						}

						//use the best one
						population.Sort((x, y) => x.GE.CompareTo(y.GE));
						brain.UpdateConfiguration(population[0]);
						brain.Think();
						break;
					}
				case "Fixed Increments":
					{
						for (int i = 0; i < (int)numNeuralEpoch.Value; i++)
						{
							brain.Think(NeuralNetworkAlgorithm.FixedIncrement);
						}
						break;
					}
				default:
					{
						txtLog.AppendText(String.Format("'{0}' algorithm is not implemeneted.\r\n", cmbNeuralAlgorithm.Text));
						break;
					}
			}


			txtNeuralOutput.Text += brain.GetDataStr(brain.Outputs);
			barNeuralMatch.Value = (int)(brain.ComputeMatch() * 100);

			UpdateNeuronDataGrid();
			txtNeuralSynapses.Text = brain.GetSynapsesStr();

			UpdateChart();

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
							layercount,                                                                         //layer
							i,                                                                                  //index
							functionlist[(String)row.Cells["columnFunction"].Value],                            //function //imho ok to get this from main gridview  
							Convert.ToDouble(gridNeuralNeurons.Rows[rowindex].Cells["columnSlope"].Value),      //slope
							Convert.ToDouble(gridNeuralNeurons.Rows[rowindex].Cells["columnIntercept"].Value),  //intercept
							Convert.ToDouble(gridNeuralNeurons.Rows[rowindex].Cells["columnAugment"].Value)     //augment
							));
					else // add brand new
						layer.Add(
							new Neuron(
								layercount,                                               //layer
								i,                                                        //index
								functionlist[(String)row.Cells["columnFunction"].Value],  //function
								Neuron.GetDefaultSlope(),                                 //slope
								Neuron.GetDefaultIntercept(),                             //intercept
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
					expectedline.Add(Convert.ToDouble(value));
				expected.Add(expectedline);
			} //end for each initial input line


			brain.Inputs = inputs;
			brain.Expected = expected;

		}

		private void button1_Click(object sender, EventArgs e)
		{

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

		private void btnNeuralSynapsesSave_Click(object sender, EventArgs e)
		{
			/*saveFileDialog1.FileName = "synapses.txt";
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
					sw.Write(txtNeuralSynapses.Text);*/
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
					gridNeuralNeurons.Rows[rowindex].Cells["columnIntercept"].Value = n.Intercept;
					gridNeuralNeurons.Rows[rowindex].Cells["columnAugment"].Value = n.Augment;
				}
			}
		}

		private void btnNeuralSaveConfiguration_Click(object sender, EventArgs e)
		{
			Update();

			saveFileDialog1.FileName = "network";
			saveFileDialog1.DefaultExt = "ann";
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
				//txtNeuralOutput.Text = brain.GetDataStr(brain.Outputs);
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
					n.Intercept = Neuron.GetRandomIntercept();
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
					n.Intercept = Neuron.GetDefaultIntercept();
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

		public void UpdateChart()
		{

			chart.ChartAreas.Clear();
			chart.Series.Clear();

			//not a 2D LSP with one expected output? don't do anything
			if (brain.Synapses.Count != 1 || brain.Inputs[0].Count != 2 || brain.Expected[0].Count != 1)
				return;
			
			// group inputs by expected result
			double? min = null;
			double? max = null;

			Dictionary<string, Series> seriedict = new Dictionary<string, Series>();
			for (int i = 0; i < brain.Inputs.Count; i++)
			{
				String group = String.Format("{0}", brain.Expected[i][0]);
				if (!seriedict.Keys.Contains(group))
					seriedict.Add(group, new Series(group));
				if (min == null || brain.Inputs[i][0] < min)
					min = brain.Inputs[i][0];
				if (max == null || brain.Inputs[i][0] > max)
					max = brain.Inputs[i][0];
				seriedict[group].Points.AddXY(brain.Inputs[i][0], brain.Inputs[i][1]);
			}

			double gridinterval = (double)((max-min)/4);
			foreach (Series s in seriedict.Values)
			{
				s.ChartType = SeriesChartType.Point;
				s.MarkerSize = 10;
				chart.Series.Add(s);
			}
			// prepare area

			ChartArea area = new ChartArea();

			area.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
			area.AxisX.TitleForeColor = System.Drawing.Color.Silver;
			area.AxisX.MajorGrid.LineColor = Color.Silver;
			area.AxisX.MajorGrid.Interval = gridinterval;
			area.AxisX.LabelStyle.ForeColor = Color.Silver;
			area.AxisX.LabelStyle.Interval = gridinterval;
			area.AxisX.Minimum = (int)min;
			area.AxisX.Maximum = (int)max;

			area.AxisX2.Enabled = AxisEnabled.False;

			area.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Silver;
			area.AxisY.LineColor = System.Drawing.Color.Silver;
			area.AxisY.TitleForeColor = System.Drawing.Color.Silver;
			area.AxisY.MajorGrid.LineColor = Color.Silver;
			area.AxisY.MajorGrid.Interval = gridinterval;
			area.AxisY.LabelStyle.ForeColor = Color.Silver;
			area.AxisY.LabelStyle.Interval = gridinterval;
			area.AxisY.Minimum = (int)min;
			area.AxisY.Maximum = (int)max;

			area.AxisY2.Enabled = AxisEnabled.False;

			area.BackColor = System.Drawing.Color.FromArgb(0x22, 0x22, 0x22);
			area.BorderColor = System.Drawing.Color.White;
			area.BorderWidth = 1;
			area.Name = "Area";
			chart.ChartAreas.Add(area);
			

			// series for separator (for output neuron)
			foreach (Neuron n in brain.Neurons[0])
			{
				Series lineserie = new Series();

				lineserie.Name = n.GetName();
				lineserie.ChartType = SeriesChartType.Line;
				lineserie.BorderWidth = 5;
				List<float> weights = new List<float>();
				foreach (Synapse s in brain.Synapses[-1])
					weights.Add((float)s.Weight);
				weights.Add((float)brain.Neurons[0][0].Augment);
				foreach (PointF p in GetLineTerminators(weights, (float)min, (float)max))
				{
					lineserie.Points.AddXY(p.X, p.Y);
				}
				chart.Series.Add(lineserie);
			}

		}

		public List<PointF> GetLineTerminators(List<float> weights, float min, float max)
		{
			List<PointF> result = new List<PointF>();
			result.Add(new PointF(min, (-weights[2] - weights[0]*min) / weights[1]));
			result.Add(new PointF(max, (-weights[2] - weights[0] * max) / weights[1]));
			return result;
		}
	}
}
