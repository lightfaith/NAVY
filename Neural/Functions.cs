using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	public abstract class Function
	{
		public abstract double Compute(double input);

	}

	public class Linear : Function
	{
		override public double Compute(double input)
		{
			return input;
		}
		public override string ToString()
		{
			return "Linear";
		}
	}

	public class BinaryUnipolar : Function
	{
		override public double Compute(double input)
		{
			if (input < 0)
				return 0;
			return 1;
		}
		public override string ToString()
		{
			return "Binary Unipolar";
		}
	}

	public class BinaryBipolar : Function
	{
		override public double Compute(double input)
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

	public class Logistic : Function
	{
		override public double Compute(double input)
		{
			//TODO implement
			return 0;
		}
		public override string ToString()
		{
			return "Logistic";
		}
	}

	public class HyperbolicTangent : Function
	{
		override public double Compute(double input)
		{
			//TODO implement
			return 0;
		}
		public override string ToString()
		{
			return "Hyperbolic Tangent";
		}
	}
}
