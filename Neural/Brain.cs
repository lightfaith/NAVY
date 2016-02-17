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
		Regex synapseregex = new Regex(@"^(i[0-9]+|n[0-9]+_[0-9]+)-n[0-9]+_[0-9]+: +[0-9]+[.,][0-9]+$");
		
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
					sb.Append(String.Format("{0:0}\r\n", Convert.ToInt32(d)));
				else
					sb.Append(String.Format("{0:0.000}\r\n", d));
			}
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
					string[] parts = line.Split(new char[] { '-', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

					int synlayer = Convert.ToInt32(parts[1].Split(new char[] { 'n', '_' }, StringSplitOptions.RemoveEmptyEntries)[0]);
					int synindex = Convert.ToInt32(parts[1].Split(new char[] { 'n', '_' }, StringSplitOptions.RemoveEmptyEntries)[1]);
					// synapse belongs to active layer?
					if (synlayer == activelayer)
						layersynapses.Add(new Tuple<int, Synapse>(synindex, new Synapse(parts[0], Convert.ToDouble(parts[2]))));
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
			Bitmap b = new Bitmap(60, 70);
			using (Graphics g = Graphics.FromImage(b))
			{
				g.Clear(Color.Red);
			}
			return b;
		}
	}
}
