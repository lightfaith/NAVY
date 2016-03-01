using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
	public delegate string func(List<double> _inputs, int epochnum);
	public class Element
	{

		List<double> synapses;
		public double GE { get; private set; }

		public Element(int synapsenum)
		{
			synapses = new List<double>();
			for (int i = 0; i < synapsenum; i++)
				synapses.Add(Lib.r.NextDouble()*2-1);
		}

		public double GetGlobalError(List<double> inputs, List<double> expected, func f)
		{
			List<double> outputs = (from x in f(inputs, 1).Split(new char[] { ';' }) select Convert.ToDouble(x)).ToList<double>();
			GE = 0;
			for(int i=0; i<outputs.Count(); i++) 
				GE += Math.Abs(outputs[i]-expected[i]);
			return GE;
		}
	}
}
