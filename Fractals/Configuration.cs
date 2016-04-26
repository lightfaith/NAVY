using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Fractals
{
	public class Configuration
	{
		public Dictionary<String, List<double>> Values;
		public List<double[]> InitPoints;
		//public Func<double[], double[]> Adjust;

		public Configuration()
		{
			Values = new Dictionary<string, List<double>>();
			InitPoints = new List<double[]>();
		}

		public Boolean IsOK()
		{
			foreach (List<double> l in Values.Values)
				if (l.Count != Values.Values.First().Count)
					return false;
			double probasum = 0;
			foreach (double prob in Values["Probability"])
				probasum += prob;
			if (Math.Round(probasum, 3) != 1)
				return false;
			return true;
		}

		public static Configuration IFSEmpty()
		{
			Configuration c = new Configuration();
			c.Values.Add("A", (new double[] { 0 }).ToList<double>());
			c.Values.Add("B", (new double[] { 0 }).ToList<double>());
			c.Values.Add("C", (new double[] { 0 }).ToList<double>());
			c.Values.Add("D", (new double[] { 0 }).ToList<double>());
			c.Values.Add("E", (new double[] { 0 }).ToList<double>());
			c.Values.Add("F", (new double[] { 0 }).ToList<double>());
			c.Values.Add("Probability", (new double[] { 1 }).ToList<double>());
			
			return c;
		}
	}
}
