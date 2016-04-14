using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
	public class Configuration
	{
		public Dictionary<String, List<double>> Values;

		public Configuration()
		{
			Values = new Dictionary<string, List<double>>();
		}

		public Boolean IsOK()
		{
			foreach (List<double> l in Values.Values)
				if (l.Count != Values.Values.First().Count)
					return false;
			double probasum = 0;
			foreach (double prob in Values["Probability"])
				probasum += prob;
			if (probasum != 1)
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
		public static Configuration IFSTree()
		{
			Configuration c = new Configuration();
			c.Values.Add("A", (new double[] { 0.86, 0.2, -0.15, 0 }).ToList<double>());
			c.Values.Add("B", (new double[] { 0.03, -0.25, -0.27, 0 }).ToList<double>());
			c.Values.Add("C", (new double[] { -0.03, 0.21, 0.25, 0 }).ToList<double>());
			c.Values.Add("D", (new double[] { 0.86, 0.23, 0.26, 0.17 }).ToList<double>());
			c.Values.Add("E", (new double[] { 0, 0, 0, 0 }).ToList<double>());
			c.Values.Add("F", (new double[] { 1.5, 1.5, 0.45, 0 }).ToList<double>());
			c.Values.Add("Probability", (new double[] { 0.83, 0.08, 0.08, 0.01 }).ToList<double>());
			return c;
		}
	}
}
