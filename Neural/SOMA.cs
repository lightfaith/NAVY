using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
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
			//ps.Add("Migrations", 10); //number of generations, per Step
			ps.Add("MinDiv", -1);       //minimal difference between best and worst, <0 => ignored
										//ps.Add("Migration", 10);
		}

		private List<int> GetPRTVector(int size)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < size; i++)
				result.Add((Lib.r.NextDouble() < ps["PRT"]) ? 1 : 0);
			return result;
		}

		public List<Configuration> Run(List<Configuration> elements)
		{
			//Runs ONE iteration
			//ps["Migrations"] = migrations;

			// copy default configuration
			List<Configuration> population = new List<Configuration>();
			population.AddRange(elements);

			Configuration leader = population[0];
			Configuration worst = population[0];

			foreach (Configuration c in population)
			{
				if (c.GE < leader.GE)
					leader = c;
				if (c.GE > worst.GE)
					worst = c;
			}
			if (worst.GE - leader.GE < ps["MinDiv"]) //everyone too close
				return population;

			//Random r = new Random();
			List<Configuration> ng = new List<Configuration>();
			for (int k = 0; k < population.Count; k++)
			{
				Configuration c = population[k];
				// Dealing with leader, put him in the candidate list
				if (c == leader)
				{
					ng.Add(c);
					continue;
				}
				List<Configuration> jumps = new List<Configuration>();
				for (int i = 0; i < ps["PathLength"] / ps["Step"]; i++)
				{
					int prtsize = leader.SIs.Count * 3 + leader.Weights.Count;
					List<int> prtv = GetPRTVector(prtsize);
					Configuration leaderdiff = leader.GetDifference(c);
					Configuration onejump = new Configuration(c);
					c.AddVector(leaderdiff, i, ps["Step"], prtv);
					jumps.Add(onejump);
				}
				int bestindex = -1;
				for (int j = 0; j < jumps.Count; j++)
				{
					if (jumps[j].GE < c.GE)
						bestindex = j;
				}
				ng.Add((bestindex == -1) ? population[k] : jumps[bestindex]);
			}

			return population;
		}
	}
}
