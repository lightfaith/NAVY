using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;

namespace Neural
{
	public class Brain
	{
		public Dictionary<int, List<Neuron>> Neurons { get; set; }   // layer, list of neurons
		public Dictionary<int, List<Synapse>> Synapses { get; set; } // layer of target neurons, list of synapses

		public int InputCount { get; private set; }

		Regex synapseregex = new Regex(@"^(i[0-9]+|n[0-9]+_[0-9]+)>n[0-9]+_[0-9]+: +-?[0-9]+[.,]?[0-9]*$");

		public double maxweight = 0;

		public void Think(List<double> inputs, int epochnum)
		{
			for (int i = 0; i < epochnum; i++)
			{
				bool firstlayer = true;
				foreach (int layer in Synapses.Keys)
				{
					if (!firstlayer)
						foreach (Synapse s in Synapses[layer])
							s.DoMagic();
					else
						foreach (Synapse s in Synapses[layer])
						{
							s.DoMagic(inputs[s.InputIndex]);
							firstlayer = false;
						}
				}
				// neurons in last layer did not participate, do that now
				if (Neurons.Count != 0)
					foreach (Neuron n in Neurons[Neurons.Count - 1])
						n.Think();
			}
		}
		public List<double> GatherResults()
		{
			List<double> result = new List<double>();
			if(Neurons.Count!=0)
			foreach (Neuron n in Neurons[Neurons.Count - 1])
			{
				result.Add(n.Value);
			}
			return result;
		}
		public string GatherResultsStr()
		{
			StringBuilder sb = new StringBuilder();
			bool first = true;
			foreach (double d in GatherResults())
			{
				if (!first)
					sb.Append(";");
				else
					first = false;
				if (d % 1 == 0)
					sb.Append(String.Format("{0:0}", Convert.ToInt32(d)));
				else
					sb.Append(String.Format("{0:0.000}", d));
			}
			sb.Append("\r\n");
			return sb.ToString();
		}

		public void Update(Dictionary<int, List<Neuron>> neurons, String synapses, int inputcount)
		{
			InputCount = inputcount;
			// update neuron structure
			this.Neurons = neurons;

			// update synapse structure
			this.Synapses = new Dictionary<int, List<Synapse>>();

			//update input weights
			if (neurons.Count == 0)
				return;
			List<Synapse> synlayer = new List<Synapse>();
			for (int i = 0; i < inputcount; i++)
			{

				foreach (Neuron n in neurons[0])
				{
					// try to get synapse from string, else random
					double weight = Lib.r.NextDouble() * 2 - 1;
					foreach (String line in synapses.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
					{
						if (line.Contains(String.Format("i{0}>n0_{1}: ", i, n.Index))) // weight known, use that
						{
							weight = Convert.ToDouble(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1].Replace(".", ","));
							break;
						}
					}
					if (Math.Abs(weight) > maxweight)
						maxweight = Math.Abs(weight);
					synlayer.Add(new Synapse(i, n, weight));
				}
			}

			this.Synapses.Add(-1, synlayer);

			//update normal layer weights
			for (int i = 0; i < neurons.Count - 1; i++) //for source layer
			{
				synlayer = new List<Synapse>();
				for (int j = 0; j < neurons[i].Count; j++) // for each neuron in source layer
				{
					for (int k = 0; k < neurons[i + 1].Count; k++) // for each neuron in target layer
					{
						// try to get synapse from string, else random
						double weight = Lib.r.NextDouble() * 2 - 1;
						foreach (String line in synapses.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
						{
							if (line.Contains(String.Format("n{0}_{1}>n{2}_{3}: ", i, j, i + 1, k))) // weight known, use that
							{
								weight = Convert.ToDouble(line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1].Replace(".", ","));
								break;
							}
						}
						if (Math.Abs(weight) > maxweight)
							maxweight = Math.Abs(weight);
						synlayer.Add(new Synapse(neurons[i][j], neurons[i + 1][k], weight));
					}
				}
				this.Synapses.Add(i, synlayer);
			}


			/*this.layers = layers;
			// for each layer
			for (int activelayer = 0; activelayer < layers.Count; activelayer++)
			{
				List<Tuple<int, Synapse>> layersynapses = new List<Tuple<int, Synapse>>(); // int is index of neuron in the layer
																						   // for each synapse
				foreach (string line in synapses.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
				{
					if (!synapseregex.Match(line).Success)
						continue; // malformed synapse input
					string[] parts = line.Split(new char[] { '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

					int synlayer = Convert.ToInt32(parts[1].Split(new char[] { 'n', '_' }, StringSplitOptions.RemoveEmptyEntries)[0]);
					int synindex = Convert.ToInt32(parts[1].Split(new char[] { 'n', '_' }, StringSplitOptions.RemoveEmptyEntries)[1]);
					// synapse belongs to active layer?
					if (synlayer == activelayer)
					{
						double weight = Convert.ToDouble(parts[2].Replace('.', ','));
						if (Math.Abs(weight) > maxweight)
							maxweight = Math.Abs(weight);
						layersynapses.Add(new Tuple<int, Synapse>(synindex, new Synapse(parts[0], weight)));
					}
					else // different layer, skip for now
						continue;
				}
				layers[activelayer].UpdateSynapses(layersynapses);
			}*/
		}

		public String GetSynapsesStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach (int layer in Synapses.Keys)
				foreach (Synapse synapse in Synapses[layer])
					if (synapse.Source == null) // input
						sb.Append(String.Format("{0}:   {1:0.000}\r\n", synapse.GetName(), synapse.Weight));
					else
						sb.Append(String.Format("{0}: {1:0.000}\r\n", synapse.GetName(), synapse.Weight));
			return sb.ToString();
		}


	}
}
