using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bio
{
	public class SOMA
	{
		Dictionary<string, double> ps; // parameters
		public SOMA()
		{
			ps = new Dictionary<string, double>(); 
			ps.Add("PathLength", 1.4f);
			ps.Add("Step", 0.11f);
			ps.Add("PRT", 0.8f);
			ps.Add("Migrations", 10); //number of generations, per Step
			ps.Add("MinDiv", -1);     //minimal difference between best and worst, <0 => ignored
			ps.Add("Migration", 10);
		}

		private List<int> GetPRTVector(int size, Random r)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < size; i++)
				result.Add((r.NextDouble() < ps["PRT"]) ? 1 : 0);
			return result;
		}

		public List<double> Run(List<Element> elements)
		{
			return null;/*List<double> result = new List<double>();

			if (ps["Migration"] <= 0)
				return eleme;

			Element leader = elements[0];
			Element worst = elements[0];

			foreach (Element e in elements)
			{
				if (e.GetGlobalError() < leader.GetGlobalError())
					leader = e;
				if (e.GE > worst.GetGlobalError())
					worst = e;
			}
			if (worst.GE - leader.GE < ps["MinDiv"])
				return elements;

			Random r = new Random();
			List<Element> result = new List<Element>();
			for (int k = 0; k < population.Count; k++)
			{
				Element e = population[k];
				if (e == leader)
				{
					result.Add(e);
					continue;
				}
				List<Element> jumps = new List<Element>();
				for (int i = 0; i < ps["PathLength"] / ps["Step"]; i++)
				{
					List<int> prtv = GetPRTVector(2, r);
					Element leaderdiff = new Element(leader.X - e.X, leader.Y - e.Y, 0);
					Element onejump = new Element(e.X + leaderdiff.X * i * ps["Step"] * prtv[0], e.Y + leaderdiff.Y * i * ps["Step"] * prtv[1], f);
						jumps.Add(onejump);
				}
				int bestindex = -1;
				for (int j = 0; j < jumps.Count; j++)
				{
					if (jumps[j].Z < e.Z)
						bestindex = j;
				}
				result.Add((bestindex == -1) ? population[k] : jumps[bestindex]);
			}
			ps["Migration"]--;
			return result;*/
		}
	}
}
