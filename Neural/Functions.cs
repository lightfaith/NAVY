using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	[Serializable]
	public abstract class TransferFunction
	{
		public abstract double Compute(double input, double slope/*, double intercept*/);

	}

	[Serializable]
	public class Linear : TransferFunction
	{
		override public double Compute(double input, double slope/*, double intercept*/)
		{
			if(input>0)
				return slope*input/*+intercept*/;
			return 0;
		}

		public override string ToString()
		{
			return "Linear";
		}
	}

	[Serializable]
	public class BinaryUnipolar : TransferFunction
	{
		override public double Compute(double input, double slope/*, double intercept*/)
		{
			if (input <= 0)
				return 0;
			return 1;
		}
		public override string ToString()
		{
			return "Binary Unipolar";
		}
	}

	[Serializable]
	public class BinaryBipolar : TransferFunction
	{
		override public double Compute(double input, double slope/*, double intercept*/)
		{
			if (input == 0)
				return 1;
			return Math.Sign(input);
		}
		public override string ToString()
		{
			return "Binary Bipolar";
		}
	}

	[Serializable]
	public class Logistic : TransferFunction
	{
		override public double Compute(double input, double slope/*, double intercept*/)
		{
			double result = 1 / (1+ Math.Pow(Math.E, -slope*input))/* + intercept*/;
			return result;
		}
		public override string ToString()
		{
			return "Logistic";
		}
	}

	[Serializable]
	public class HyperbolicTangent : TransferFunction
	{
		override public double Compute(double input, double slope/*, double intercept*/)
		{
			return (Math.Pow(Math.E, slope*input)-Math.Pow(Math.E, -slope * input))/(Math.Pow(Math.E, slope * input) + Math.Pow(Math.E, -slope * input))/* + intercept*/;
		}
		public override string ToString()
		{
			return "Hyperbolic Tangent";
		}
	}
}
