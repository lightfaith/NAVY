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
			gridNeural.Rows.Add();
		}

		private void gridNeural_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			for (int i = 0; i < e.RowCount; i++)
			{
				gridNeural.Rows[e.RowIndex].Cells["columnLayer"].Value = gridNeural.RowCount;
				gridNeural.Rows[e.RowIndex].Cells["columnNeurons"].Value = 1;
				gridNeural.Rows[e.RowIndex].Cells["columnFunction"].Value = functionlist.Keys.ElementAt(2);
			}

		}

		private void btnNeuralAddLayer_Click(object sender, EventArgs e)
		{
			gridNeural.Rows.Add();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void btnNeuralRun_Click(object sender, EventArgs e)
		{
			txtNeuralOutput.Text = "";
			List<Layer> layers = new List<Layer>();
			foreach (DataGridViewRow row in gridNeural.Rows)
			{
				Layer layer = new Layer(Convert.ToInt32(row.Cells["columnNeurons"].Value), functionlist[(String)row.Cells["columnFunction"].Value]);
				layers.Add(layer);
			}

			
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
				brain.UpdateLayers(layers);
				txtNeuralOutput.Text += brain.Think(inputs, (int)numNeuralEpoch.Value);

			} //end for each initial input line

	}

		private void btnNeuralDeleteLayer_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewCell oneCell in gridNeural.SelectedCells)
			{
				if (oneCell.Selected)
					gridNeural.Rows.RemoveAt(oneCell.RowIndex);
				foreach (DataGridViewRow row in gridNeural.Rows)
				{
					row.Cells["columnLayer"].Value = row.Index + 1;
				}
			}
		}
	}
}
