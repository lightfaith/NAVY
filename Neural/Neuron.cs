using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	[Serializable]
	public class Neuron
	{
		public int Layer { get; private set; }
		public int Index { get; private set; }
		public Function f;
		public double Slope { get; set; }
		public double Intercept { get; set; }
		public double Augment { get; set;}

		public List<double> Inputs { get; set; }
		public double Value { get; private set; }

		public Neuron(int layer, int index, Function f, double? slope = null, double? intercept = null, double? augment = null)
		{
			this.Layer = layer;
			this.Index = index;
			this.f = f;
			this.Slope = (slope == null) ? Neuron.GetRandomSlope() : (double)slope;
			this.Intercept = (intercept == null) ? Neuron.GetRandomIntercept() : (double)intercept;
			this.Augment = (augment == null) ? Neuron.GetRandomAugment() : (double)augment;
			this.Value = 0;
			this.Inputs = new List<double>();
		}

		public double Think()
		{
			double result = 0;
			foreach (double i in Inputs)
				result += i;
			Inputs.Clear();
			result += Augment;
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

		public static double GetDefaultSlope()
		{
			return 1;
		}

		public static double GetDefaultIntercept()
		{
			return 0;
		}

		public static double GetDefaultAugment()
		{
			return 0;
		}
		public static double GetRandomSlope()
		{
			return Lib.r.NextDouble() * 20;
		}

		public static double GetRandomIntercept()
		{
			return Lib.r.NextDouble() * 20 - 10;
		}

		public static double GetRandomAugment()
		{
			return Lib.r.NextDouble() * 2 - 1;
		}
	}
}
