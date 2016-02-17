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

		public Layer(int index, int neuroncount, Function f, double slope, double intercept)
		{
			neurons = new List<Neuron>();
			for (int i = 0; i < neuroncount; i++)
				neurons.Add(new Neuron(index, i, f, slope, intercept));
		}

		public List<double> Think(List<double> inputs)
		{
			List<double> results = new List<double>();
			foreach (Neuron n in neurons)
				results.Add(n.Think(inputs));
			return results;
		}

		public String GetSynapsesStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach (Neuron n in neurons)
				sb.Append(String.Format("{0}", n.GetSynapsesStr()));
			return sb.ToString();
		}

		public void UpdateSynapses(List<Tuple<int, Synapse>> synapses)
		{
			foreach (Neuron n in neurons)
			{
				n.UpdateSynapses((from syntuple in synapses where syntuple.Item1 == n.Index select syntuple.Item2).ToList());
			}
		}
	}
}
