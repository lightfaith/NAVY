using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	public class Brain
	{
		List<Layer> layers;
		List<List<double>> weights;


		public void UpdateLayers(List<Layer> layers)
		{
			this.layers = layers;
		}

		public void UpdateWeights(List<List<double>> weights)
		{
			this.weights = weights;
		}

		public string Think(List<double> _inputs, int epochnum)
		{
			List<double> inputs = new List<double>();
			for (int i = 0; i < epochnum; i++)
			{
				inputs = _inputs;
				foreach (Layer layer in layers)
				{
					layer.UpdateWeights();
					inputs = layer.Think(inputs);
				}
				// TODO back propagation here?
			}

			//return final results
			StringBuilder sb = new StringBuilder();
			bool first = true;
			foreach (double d in inputs)
				if (first)
				{
					sb.Append(d.ToString());
					first = false;
				}
				else
					sb.Append(String.Format(";%f", d.ToString()));
			sb.Append("\r\n");
			return sb.ToString();
		}
	}
}
