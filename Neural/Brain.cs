using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;

namespace Neural
{
	public class Brain
	{
		List<Layer> layers;
		double maxweight = 0;
		Regex synapseregex = new Regex(@"^(i[0-9]+|n[0-9]+_[0-9]+)>n[0-9]+_[0-9]+: +-?[0-9]+[.,]?[0-9]*$");

		public bool IsConsistent()
		{
			//todo check synapses
			return true;
		}

		public string Think(List<double> _inputs, int epochnum)
		{
			List<double> inputs = new List<double>();
			for (int i = 0; i < epochnum; i++)
			{
				inputs = _inputs;
				foreach (Layer layer in layers)
				{
					//layer.UpdateWeights();
					inputs = layer.Think(inputs);
				}
				// TODO back propagation here?
			}

			//return final results
			StringBuilder sb = new StringBuilder();
			bool first = true;
			foreach (double d in inputs)
			{
				if (!first)
					sb.Append(";");
				else
					first = false;
				if (d % 1 == 0)
					sb.Append(String.Format("{0:0}", Convert.ToInt32(d)));
				else
					sb.Append(String.Format("{0:0.000}", d));
			}
			sb.Append("\r\n");
			return sb.ToString();
		}

		public void Update(List<Layer> layers, String synapses)
		{
			this.layers = layers;
			// for each layer
			for (int activelayer = 0; activelayer < layers.Count; activelayer++)
			{
				List<Tuple<int, Synapse>> layersynapses = new List<Tuple<int, Synapse>>(); // int is index of neuron in the layer
																						   // for each synapse
				foreach (string line in synapses.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
				{
					if (!synapseregex.Match(line).Success)
						continue; // malformed synapse input
					string[] parts = line.Split(new char[] { '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

					int synlayer = Convert.ToInt32(parts[1].Split(new char[] { 'n', '_' }, StringSplitOptions.RemoveEmptyEntries)[0]);
					int synindex = Convert.ToInt32(parts[1].Split(new char[] { 'n', '_' }, StringSplitOptions.RemoveEmptyEntries)[1]);
					// synapse belongs to active layer?
					if (synlayer == activelayer)
					{
						double weight = Convert.ToDouble(parts[2].Replace('.', ','));
						if (Math.Abs(weight) > maxweight)
							maxweight = Math.Abs(weight);
						layersynapses.Add(new Tuple<int, Synapse>(synindex, new Synapse(parts[0], weight)));
					}
					else // different layer, skip for now
						continue;
				}
				layers[activelayer].UpdateSynapses(layersynapses);
			}
		}

		public String GetSynapsesStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach (Layer l in layers)
				sb.Append(l.GetSynapsesStr());
			return sb.ToString();
		}

		public Bitmap GetSchema()
		{
			int width = 1024;
			int height = 768;
			Font font;
			int layernum = (layers == null) ? 1 : layers.Count + 1;
			int neuronsize = (int)((height * 0.8) / layernum / 2);
			neuronsize = (neuronsize > height / 6) ? height / 6 : neuronsize;

			String synapsesstr = GetSynapsesStr();

			// count neurons in each layer
			List<int> neuroncount = new List<int>();
			//TODO add neuroncount for inputs (peak into layer0 synapses)
			neuroncount.Add(2); //TODO CHANGE NOW!
			if (layers != null)
				foreach (Layer l in layers)
					neuroncount.Add(l.Neurons.Count);
			int max = neuroncount.Max();


			// add missing synapses
			for (int i = 0; i < layernum-1; i++) // for each layer
			{
				//g.DrawLine(Pens.White, 0, ycoords[layernum - i - 1], width, ycoords[layernum - i - 1]);
				for (int j = 0; j < neuroncount[i]; j++) // for each neuron in layer
				{
					for (int k = 0; k < neuroncount[i + 1]; k++)
					{
						layers[i].Neurons[k].AddMissingSynapse(j);
					}
				}
			}

					// compute y-coords
					List<int> ycoords = new List<int>();
			for (int i = 0; i < layernum; i++)
				ycoords.Add((int)(height / (layernum) * i + height / (layernum + 3)));

			
			if ((neuronsize + 2) * 1.5 * max > width) // neurons too big for width
				neuronsize = (int)(width / max / 1.8);

			font = new Font(new FontFamily("Arial"), neuronsize / 3, FontStyle.Bold, GraphicsUnit.Pixel);
			Bitmap b = new Bitmap(width, height);

			// prepare points
			Dictionary<String, Point> coords = new Dictionary<String, Point>();
			for (int i = 0; i < layernum; i++)
				for (int j = 0; j < neuroncount[i]; j++)
					coords.Add(String.Format("{0}_{1}", i, j),
						new Point((int)(j * neuronsize * 1.5 + (width / 2) - ((neuronsize - 1) * 1.5 / 2 * neuroncount[i])),
						ycoords[layernum - 1 - i]));

			// draw
			using (Graphics g = Graphics.FromImage(b))
			{

				g.Clear(Color.Black);
				for (int i = 0; i < layernum; i++) // for each layer
				{
					//g.DrawLine(Pens.White, 0, ycoords[layernum - i - 1], width, ycoords[layernum - i - 1]);
					for (int j = 0; j < neuroncount[i]; j++) // for each neuron in layer
					{
						string key = String.Format("{0}_{1}", i, j);
						string caption;
						if (i == 0) //input
							caption = string.Format("i{0}", j);
						else
							caption = String.Format("n{0}_{1}", i - 1, j);

						// draw synapses
						if (i != layernum - 1)
						{
							Pen p;
							for (int k = 0; k < neuroncount[i + 1]; k++)
							{
								float weight = maxweight == 0 ? 0 : (float)(layers[i].Neurons[k].Synapses[j].Weight/maxweight * neuronsize/6);
								if (weight == 0)
									continue;
								if (weight > 0)
									p = new Pen(Brushes.White, weight);
								else
									p = new Pen(Brushes.Red, -weight);

								g.DrawLine(p, coords[String.Format("{0}_{1}", i + 1, k)], coords[key]);
							}
						}
						// draw circles
						g.FillEllipse(Brushes.Black, coords[key].X - neuronsize / 2, coords[key].Y - neuronsize / 2, neuronsize, neuronsize);
						g.DrawEllipse(Pens.White, coords[key].X - neuronsize / 2, coords[key].Y - neuronsize / 2, neuronsize, neuronsize);

						// draw strings
						SizeF stringsize = g.MeasureString(caption, font);
						g.DrawString(caption, font, Brushes.White, coords[key].X - stringsize.Width / 2, coords[key].Y - stringsize.Height / 2);


					}
				}
			}
			return b;
		}
	}
}
