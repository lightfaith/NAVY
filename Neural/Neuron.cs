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
		public double Slope { get; set; }
		public double Intercept { get; set; }

		public List<double> Inputs { get; set; }
		public double Value { get; private set; }

		public Neuron(int layer, int index, Function f, double? slope = null, double? intercept = null)
		{
			this.Layer = layer;
			this.Index = index;
			this.f = f;
			this.Slope = (slope == null) ? Lib.r.NextDouble() * 20 : (double)slope;
			this.Intercept = (intercept == null) ? Lib.r.NextDouble() * 20 - 10 : (double)intercept;
			this.Value = 0;
			this.Inputs = new List<double>();
		}

		/*public void UpdateSynapses(List<Synapse> synapses)
		{
			this.Synapses = synapses;
		}*/

		/*public double Think(List<double> inputs)
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
		*/
		public double Think()
		{
			double result = 0;
			foreach (double i in Inputs)
				result += i;
			Inputs.Clear();
			Value = f.Compute(result, Slope, Intercept);
			return Value;
		}

		public String GetName()
		{
			return String.Format("n{0}_{1}", Layer, Index);
		}

		public void AddInput(double input)
		{
			Inputs.Add(input);
		}
		/*public String GetSynapsesStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach (Synapse s in Synapses)
				sb.Append(String.Format("{0}>n{1}_{2}: {3}{4:0.000}\r\n", s.Source, Layer, Index, s.Source.Length<3?"  ":"", s.Weight));
			return sb.ToString();
		}*/

		/*public void AddMissingSynapse(int i)
		{
			// missing synapse? add new random
			if (i >= Synapses.Count)
			{
				String source = String.Format("{0}{1}", ((Layer > 0) ? String.Format("n{0}_", Layer - 1) : "i"), i);
				Synapses.Add(new Synapse(source, Lib.r.NextDouble() * 2 - 1));
			}

		}*/
	}
}
