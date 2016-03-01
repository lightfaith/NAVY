using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	public static class Schema
	{
		public static Bitmap GetSchema(Brain brain)
		{
			int width = 1024;
			int height = 768;
			Font font;
			int layernum = brain.Synapses.Count + 1;
			int neuronsize = (int)((height * 0.8) / layernum / 2);
			neuronsize = (neuronsize > height / 6) ? height / 6 : neuronsize;

			String synapsesstr = brain.GetSynapsesStr();

			// count neurons in each layer
			List<int> neuroncount = new List<int>();
			if (brain.Neurons != null)
			{
				neuroncount.Add(brain.InputCount);

				foreach (List<Neuron> list in brain.Neurons.Values) // first already complete
					neuroncount.Add(list.Count);
			}
			int max = neuroncount.Max();


			// add missing synapses - should be fixed in Update()s ?
			/*for (int i = 0; i < layernum - 1; i++) // for each layer
			{
				//g.DrawLine(Pens.White, 0, ycoords[layernum - i - 1], width, ycoords[layernum - i - 1]);
				for (int j = 0; j < neuroncount[i]; j++) // for each neuron in layer
				{
					for (int k = 0; k < neuroncount[i + 1]; k++)
					{
						brain.layers[i].Neurons[k].AddMissingSynapse(j);
					}
				}
			}*/

			// compute y-coords
			List<int> ycoords = new List<int>();
			for (int i = 0; i < layernum; i++)
				ycoords.Add((int)(height / (layernum) * i + height / (layernum + 3)));


			if ((neuronsize + 2) * 1.5 * max > width) // neurons too big for width
				neuronsize = (int)(width / max / 1.8);

			font = new Font(new FontFamily("Arial"), (neuronsize / 3 > 0) ? neuronsize / 3 : 1, FontStyle.Bold, GraphicsUnit.Pixel);
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
					// draw synapses
					if (i != layernum - 1)
					{
						Pen p;
						foreach (Synapse s in brain.Synapses[i - 1])
						{
							float weight = brain.maxweight == 0 ? 0 : (float)(s.Weight / brain.maxweight * neuronsize / 6);

							if (weight == 0)
								continue;
							if (weight > 0)
								p = new Pen(Brushes.White, weight);
							else
								p = new Pen(Brushes.Red, -weight);
							String key = String.Format("{0}_{1}", i, s.Source == null ? s.InputIndex : s.Source.Index);
							//Console.WriteLine(String.Format("{0} > {1}", key, String.Format("{0}_{1}", i + 1, s.Target.Index)));
							g.DrawLine(p, coords[key], coords[String.Format("{0}_{1}", i + 1, s.Target.Index)]);
						}
					}

					// draw the rest
					for (int j = 0; j < neuroncount[i]; j++) // for each neuron in layer
					{
						string key = String.Format("{0}_{1}", i, j);
						string caption;
						if (i == 0) //input
							caption = string.Format("i{0}", j);
						else
							caption = String.Format("n{0}_{1}", i - 1, j);


						/*// draw synapses
						if (i != layernum - 1)
						{
							Pen p;
							for (int k = 0; k < neuroncount[i + 1]; k++)
							{
								//float weight = brain.maxweight == 0 ? 0 : (float)(brain.Neurons[i].Neurons[k].Synapses[j].Weight / brain.maxweight * neuronsize / 6);
								float weight = 1;
								if (weight == 0)
									continue;
								if (weight > 0)
									p = new Pen(Brushes.White, weight);
								else
									p = new Pen(Brushes.Red, -weight);

								g.DrawLine(p, coords[String.Format("{0}_{1}", i + 1, k)], coords[key]);
							}
						}*/
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
