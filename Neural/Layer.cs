using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	public class Layer
	{
		List<Neuron> neurons;

		public Layer(int neuroncount, Function f)
		{
			neurons = new List<Neuron>();
			for (int i = 0; i < neuroncount; i++)
				neurons.Add(new Neuron(f));
		}

		public void UpdateWeights(List<double> weights)
		{

		}

		public List<double> Think(List<double> inputs)
		{
			List<double> results = new List<double>();
			foreach (Neuron n in neurons)
				results.Add(n.Think(inputs));
			return results;
		}
	}
}
