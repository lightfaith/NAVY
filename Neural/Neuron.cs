using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
    public class Neuron
    {
		public int Layer { get; private set; }
		public int Index { get; private set; }
		private Function f;
		double slope;
		double intercept;
		private List<Synapse> synapses;
		

		public Neuron(int layer, int index, Function f, double slope, double intercept)
		{
			this.Layer = layer;
			this.Index = index;
			this.f = f;
			this.slope = slope;
			this.intercept = intercept;
			this.synapses = new List<Synapse>();
		}

		public void UpdateSynapses(List<Synapse> synapses)
		{
			this.synapses = synapses;
		}

		public double Think(List<double> inputs)
		{
			double result = 0;
			//// will be ensured beforehand
			////generate random weights in (0; 1> if not enough
			//for (int i=weights.Count; i<inputs.Count; i++)
			//{
			//	weights.Add(r.NextDouble());
			//}
			for (int i = 0; i < inputs.Count; i++)
				result += inputs[i] * synapses[i].Weight;

			// use given function to interpret results
			return f.Compute(result, slope, intercept);
		}

		public String GetSynapsesStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach (Synapse s in synapses)
				sb.Append(String.Format("{0}-n{1}_{2}: {3}{4:0.000}\r\n", s.Source, Layer, Index, s.Source.Length<3?"  ":"", s.Weight));
			return sb.ToString();
		}
    }
}
