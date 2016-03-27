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
		public List<Tuple<double, double>> SIAs { get; set; }
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
			SIAs = new List<Tuple<double, double>>();
			SIAs.AddRange(template.SIAs);
			Weights = new List<double>();
			Weights.AddRange(template.Weights);
		}
		public Configuration(Brain model, bool randomize = false)
		{
			this.model = model;
			SIAs = new List<Tuple<double, double>>();
			Weights = new List<double>();

			//assemble list of all neurons and then all synapses
			foreach (List<Neuron> nlist in this.model.Neurons.Values)
				foreach (Neuron n in nlist)
					if (randomize)
						SIAs.Add(new Tuple<double, double>(Neuron.GetRandomSlope(), Neuron.GetRandomAugment()));
					else
						SIAs.Add(new Tuple<double, double>(n.Slope, n.Augment));

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
			for (int i = 0; i < this.SIAs.Count; i++)
				result.SIAs[i] = new Tuple<double, double>
					(result.SIAs[i].Item1 - c.SIAs[i].Item1, result.SIAs[i].Item2 - c.SIAs[i].Item2);

			for (int i = 0; i < this.Weights.Count; i++)
				result.Weights[i] -= c.Weights[i];

			return result;
		}

		public void AddVector(Configuration leaderdiff, int step, double stepsize, List<int> prt)
		{
			int prtcount = 0;
			for (int i = 0; i < SIAs.Count; i++)
			{
				SIAs[i] = new Tuple<double, double>
					(
						SIAs[i].Item1 + leaderdiff.SIAs[i].Item1 * step * stepsize * prt[prtcount],
						SIAs[i].Item2 + leaderdiff.SIAs[i].Item2 * step * stepsize * prt[prtcount + 1]
					);

				prtcount += 2; // must match tuple size!!!
			}

			for (int i = 0; i < Weights.Count; i++)
			{
				Weights[i] += leaderdiff.Weights[i] * step * stepsize * prt[prtcount];
				prtcount++;
			}
		}
	}
}
