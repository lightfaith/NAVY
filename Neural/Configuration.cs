using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	public class Configuration
	{
		// describes neural network configuration

		Brain model;
		public List<Tuple<double, double, double>> SIs { get; set; }
		public List<double> Weights { get; set; }

		private double? ge = null;
		public double GE
		{
			get
			{
				if (ge == null)
				{
					Brain b = new Brain(model);
					b.UpdateConfiguration(this);
					b.Think();
					ge = b.GetGlobalError();
				}
				return (double)ge;
			}
			private set { ge = value; }
		}

		public Configuration(Configuration template)
		{
			model = template.model;
			SIs = new List<Tuple<double, double, double>>();
			SIs.AddRange(template.SIs);
			Weights = new List<double>();
			Weights.AddRange(template.Weights);
		}
		public Configuration(Brain model, bool randomize = false)
		{
			this.model = model;
			SIs = new List<Tuple<double, double, double>>();
			Weights = new List<double>();

			//assemble list of all neurons and then all synapses
			foreach (List<Neuron> nlist in this.model.Neurons.Values)
				foreach (Neuron n in nlist)
					if (randomize)
						SIs.Add(new Tuple<double, double, double>(Neuron.GetRandomSlope(), Neuron.GetRandomIntercept(), Neuron.GetRandomAugment()));
					else
						SIs.Add(new Tuple<double, double, double>(n.Slope, n.Intercept, n.Augment));

			foreach (List<Synapse> slist in this.model.Synapses.Values)
				foreach (Synapse s in slist)
					if (randomize)
						Weights.Add(Synapse.GetRandomWeight());
					else
						Weights.Add(s.Weight); 



		}

		public Configuration GetDifference(Configuration c)
		{
			Configuration result = new Configuration(this);
			for (int i = 0; i < this.SIs.Count; i++)
				result.SIs[i] = new Tuple<double, double, double>
					(result.SIs[i].Item1 - c.SIs[i].Item1, result.SIs[i].Item2 - c.SIs[i].Item2, result.SIs[i].Item3 - c.SIs[i].Item3);

			for (int i = 0; i < this.Weights.Count; i++)
				result.Weights[i] -= c.Weights[i];

			return result;
		}

		public void AddVector(Configuration leaderdiff, int step, double stepsize, List<int> prt)
		{
			int prtcount = 0;
			for (int i = 0; i < SIs.Count; i++)
			{
				SIs[i] = new Tuple<double, double, double>
					(
						SIs[i].Item1 + leaderdiff.SIs[i].Item1 * step * stepsize * prt[prtcount],
						SIs[i].Item2 + leaderdiff.SIs[i].Item2 * step * stepsize * prt[prtcount + 1],
						SIs[i].Item3 + leaderdiff.SIs[i].Item3 * step * stepsize * prt[prtcount + 2]
					);

				prtcount += 3;
			}

			for (int i = 0; i < Weights.Count; i++)
			{
				Weights[i] += leaderdiff.Weights[i] * step * stepsize * prt[prtcount];
				prtcount++;
			}
		}
	}
}
