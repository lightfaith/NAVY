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
		public List<Synapse> Synapses{get; private set;}
		

		public Neuron(int layer, int index, Function f, double slope, double intercept)
		{
			this.Layer = layer;
			this.Index = index;
			this.f = f;
			this.slope = slope;
			this.intercept = intercept;
			this.Synapses = new List<Synapse>();
		}

		public void UpdateSynapses(List<Synapse> synapses)
		{
			this.Synapses = synapses;
		}

		public double Think(List<double> inputs)
		{
			double result = 0;
			for (int i = 0; i < inputs.Count; i++)
			{
				AddMissingSynapse(i);
				result += inputs[i] * Synapses[i].Weight;
			}
			// use given function to interpret results
			return f.Compute(result, slope, intercept);
		}

		public String GetSynapsesStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach (Synapse s in Synapses)
				sb.Append(String.Format("{0}>n{1}_{2}: {3}{4:0.000}\r\n", s.Source, Layer, Index, s.Source.Length<3?"  ":"", s.Weight));
			return sb.ToString();
		}

		public void AddMissingSynapse(int i)
		{
			// missing synapse? add new random
			Random r = new Random();
			if (i >= Synapses.Count)
			{
				String source = String.Format("{0}{1}", ((Layer > 0) ? String.Format("n{0}_", Layer - 1) : "i"), i);
				Synapses.Add(new Synapse(source, r.NextDouble()));
			}

		}
	}
}
