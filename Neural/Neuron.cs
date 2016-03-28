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
		public TransferFunction f;
		public double Slope { get; set; }
		public double Augment { get; set;}

		public List<double> Inputs { get; set; }
		public double Input { get; private set; }
		public double Output { get; private set; }

		public double? BPPart { get; set; } // neuron-related back propagation value
		public Neuron(int layer, int index, TransferFunction f, double? slope = null, double? augment = null)
		{
			this.Layer = layer;
			this.Index = index;
			this.f = f;
			this.Slope = (slope == null) ? Neuron.GetRandomSlope() : (double)slope;
			this.Augment = (augment == null) ? Neuron.GetRandomAugment() : (double)augment;
			this.Input = 0;
			this.Output = 0;
			this.Inputs = new List<double>();
			this.BPPart = null;
		}
		

		public void StartThinking()
		{
			Input = 0;
			Output = 0;
			BPPart = null; //reset back propagation values
			foreach (double i in Inputs)
				Input += i;
			Inputs.Clear();
			Input += Augment;
		}

		public void FinishThinking()
		{
			Output = f.Compute(Input, Slope);
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
		

		public static double GetDefaultAugment()
		{
			//return 0;
			return 1;
		}
		public static double GetRandomSlope()
		{
			return Lib.r.NextDouble() * 3;
		}
		

		public static double GetRandomAugment()
		{
			return Lib.r.NextDouble() * 2 - 1;
		}
	}
}
