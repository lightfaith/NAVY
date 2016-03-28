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
		public abstract double Compute(double input, double slope);
		public abstract double ComputeDerivation(double input, double slope);

	}

	[Serializable]
	public class Linear : TransferFunction
	{
		override public double Compute(double input, double slope)
		{
			if (input > 0)
				return slope * input;
			return 0;
		}
		override public double ComputeDerivation(double input, double slope)
		{
			return slope; // TODO ?
		}
		public override string ToString()
		{
			return "Linear";
		}
	}

	[Serializable]
	public class BinaryUnipolar : TransferFunction
	{
		override public double Compute(double input, double slope)
		{
			if (input <= 0)
				return 0;
			return 1;
		}
		override public double ComputeDerivation(double input, double slope)
		{
			return 0; // TODO ?
		}
		public override string ToString()
		{
			return "Binary Unipolar";
		}
	}

	[Serializable]
	public class BinaryBipolar : TransferFunction
	{
		override public double Compute(double input, double slope)
		{
			if (input == 0)
				return 1;
			return Math.Sign(input);
		}
		override public double ComputeDerivation(double input, double slope)
		{
			return 0; //TODO ?
		}
		public override string ToString()
		{
			return "Binary Bipolar";
		}
	}

	[Serializable]
	public class Logistic : TransferFunction
	{
		override public double Compute(double input, double slope)
		{
			double result = 1 / (1 + Math.Pow(Math.E, -slope * input));
			return result;
		}
		override public double ComputeDerivation(double input, double slope)
		{
			return Compute(input, slope) * (1 - Compute(input, slope));
		}
		public override string ToString()
		{
			return "Logistic";
		}
	}

	[Serializable]
	public class HyperbolicTangent : TransferFunction
	{
		override public double Compute(double input, double slope)
		{
			return (Math.Pow(Math.E, slope * input) - Math.Pow(Math.E, -slope * input)) / (Math.Pow(Math.E, slope * input) + Math.Pow(Math.E, -slope * input));
		}
		override public double ComputeDerivation(double input, double slope)
		{
			return (4 * slope * Math.Pow(Math.E, 2 * slope * input)) / Math.Pow(Math.Pow(Math.E, 2 * slope * input) + 1, 2); // TODO ?
		}
		public override string ToString()
		{
			return "Hyperbolic Tangent";
		}
	}
}
