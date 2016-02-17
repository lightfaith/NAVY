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

namespace NAVY
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			GroupBoxRenderer.RenderMatchingApplicationState = false;
			grpNeuralInterval.ForeColor = Color.Silver;
		}

		// = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = 

		Dictionary<String, Function> functionlist;
		Brain brain = new Brain();

		private void Form1_Load(object sender, EventArgs e)
		{

			functionlist = new Dictionary<String, Function>();
			functionlist.Add("Linear", new Linear());
			functionlist.Add("Binary Unipolar", new BinaryUnipolar());
			functionlist.Add("Binary Bipolar", new BinaryBipolar());
			functionlist.Add("Logistic", new Logistic());
			functionlist.Add("Hyperbolic Tangent", new HyperbolicTangent());
			columnFunction.DataSource = functionlist.Keys.ToList<String>();

			//add default row
			gridNeural.Rows.Add();
		}

		private void gridNeural_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			// default row settings
			for (int i = 0; i < e.RowCount; i++)
			{
				gridNeural.Rows[e.RowIndex].Cells["columnLayer"].Value = gridNeural.RowCount;
				gridNeural.Rows[e.RowIndex].Cells["columnNeurons"].Value = 1;
				gridNeural.Rows[e.RowIndex].Cells["columnFunction"].Value = functionlist.Keys.ElementAt(2);
				gridNeural.Rows[e.RowIndex].Cells["columnSlope"].Value = 1;
				gridNeural.Rows[e.RowIndex].Cells["columnIntercept"].Value = 0;
			}

		}

		private void btnNeuralAddLayer_Click(object sender, EventArgs e)
		{
			gridNeural.Rows.Add();
		}

		private void btnNeuralDeleteLayer_Click(object sender, EventArgs e)
		{
			//delete all selected
			foreach (DataGridViewCell oneCell in gridNeural.SelectedCells)
			{
				if (oneCell.Selected)
					gridNeural.Rows.RemoveAt(oneCell.RowIndex);
			}
			//re-number layers
			foreach (DataGridViewRow row in gridNeural.Rows)
			{
				row.Cells["columnLayer"].Value = row.Index + 1;
			}
		}


		private void btnNeuralRun_Click(object sender, EventArgs e)
		{
			txtNeuralOutput.Text = "";
			

			//for every line of input
			foreach (String line in txtNeuralInput.Lines)
			{
				if (line == "")
					continue;

				List<double> inputs = new List<double>();
				// get initial input values
				foreach (string value in line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
					inputs.Add(Convert.ToDouble(value));

				//do the magic
				txtNeuralOutput.Text += brain.Think(inputs, (int)numNeuralEpoch.Value);

			} //end for each initial input line

			txtNeuralSynapses.Text = brain.GetSynapsesStr();
		}

		private void btnNeuralSynapsesInit_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			cmbNeuralInitValue.Text = cmbNeuralInitValue.Text.Replace(".", ",");
			// check input correctness, count number of inputs
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
			foreach (DataGridViewRow row in gridNeural.Rows)
			{
				int outputnum = Convert.ToInt32(row.Cells["columnNeurons"].Value);
				// for each source
				for (int i = 0; i < inputnum; i++)
				{
					// for each destination
					for (int j = 0; j < outputnum; j++)
					{
						double value;
						value = (double.TryParse(cmbNeuralInitValue.Text, out value) && value >= 0 && value<=1) ? value : r.NextDouble();
						if (activelayer == -1) //inputs
							sb.Append(string.Format("i{0}-n{1}_{2}:   {3:0.000}\r\n", i, activelayer + 1, j, value));
						else
							sb.Append(string.Format("n{0}_{1}-n{2}_{3}: {4:0.000}\r\n", activelayer, i, activelayer + 1, j, value));
					}
				}
				activelayer++;
				inputnum = outputnum;
			}
			txtNeuralSynapses.Text = sb.ToString();
		}

		private void btnNeuralUpdate_Click(object sender, EventArgs e)
		{
			// set layers also!
			List<Layer> layers = new List<Layer>();
			int layercount = 0;
			foreach (DataGridViewRow row in gridNeural.Rows)
			{
				Layer layer = new Layer(layercount,
					Convert.ToInt32(row.Cells["columnNeurons"].Value),
					functionlist[(String)row.Cells["columnFunction"].Value],
					Convert.ToDouble(row.Cells["columnSlope"].Value.ToString().Replace(".", ",")),
					Convert.ToDouble(row.Cells["columnIntercept"].Value.ToString().Replace(".", ",")));
				layers.Add(layer);
				layercount++;
			}

			//TODO check synapse integrity
			brain.Update(layers, txtNeuralSynapses.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = brain.GetSchema();
		}
	}
}
