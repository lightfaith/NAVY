using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Drawing;

namespace Neural
{
	[Serializable]
	public class Brain
	{
		public Dictionary<int, List<Neuron>> Neurons { get; set; }   // layer, list of neurons
		public Dictionary<int, List<Synapse>> Synapses { get; set; } // layer of target neurons, list of synapses
		public List<List<double>> Inputs { get; set; }
		public List<List<double>> Expected { get; set; }
		public List<List<double>> Outputs { get; private set; }
		public int InputCount { get; private set; }

		Regex synapseregex = new Regex(@"^(i[0-9]+|n[0-9]+_[0-9]+)>n[0-9]+_[0-9]+: +-?[0-9]+[.,]?[0-9]*$");

		public double maxweight = 0;
		public double maxaugment = 0;

		public Brain()
		{
			Neurons = null;
			Synapses = null;
			InputCount = 0;
			Inputs = null;
		}

		public Brain(Brain model)
		{
			Neurons = model.Neurons;
			Synapses = model.Synapses;
			InputCount = model.InputCount;
			Inputs = model.Inputs;
			Expected = model.Expected;
		}

		public void ThinkOnce(int inputindex, NeuralNetworkAlgorithm algo = NeuralNetworkAlgorithm.None)
		{
			if (Outputs == null)
				Outputs = new List<List<double>>();

			List<double> output = new List<double>();
			bool firstlayer = true;
			foreach (int layer in Synapses.Keys)
			{
				//transfer values through synapses
				if (!firstlayer)
				{
					foreach (Synapse s in Synapses[layer])
						s.Transfer();
				}
				else
				{
					List<Neuron> altered = new List<Neuron>();
					//place inputs there
					foreach (Synapse s in Synapses[layer])
					{

						s.Transfer(Inputs[inputindex][s.InputIndex]);
						firstlayer = false;
					}

				}
				//make neurons think
				foreach (Neuron n in Neurons[layer + 1])
				{
					n.StartThinking();
					n.FinishThinking(); // really here? fixed increments agree

					//any learning necessary? (only neuron-related)
					switch (algo)
					{
						case NeuralNetworkAlgorithm.FixedIncrement:
							{
								// http://faculty.iiit.ac.in/~vikram/nn_intro.html
								if (layer + 1 != Neurons.Keys.Count - 1) // not in last layer?
									break;
								int c = 0;
								double difference = (n.Output - Expected[inputindex][n.Index]);
								if (difference > 0) // value is greater, weights should be lowered
									c = -1;
								else if (difference < 0) // expected is greater, weights should be uppered
									c = 1;

								List<Synapse> connected = (from s in Synapses[layer] where s.Target == n select s).ToList<Synapse>();
								foreach (Synapse s in connected)
									s.Weight += c * s.LastInput;
								n.Augment += c;
								break;
							}
					}
					//n.FinishThinking();
				}
			}
			//gather results
			if (Neurons.Count != 0)
				foreach (Neuron n in Neurons[Neurons.Count - 1])
					output.Add(n.Output);

			//store the results
			Outputs.Add(output);
		}

		public Brain Think(NeuralNetworkAlgorithm algo = NeuralNetworkAlgorithm.None)
		{
			if (algo != NeuralNetworkAlgorithm.BackPropagation)
			{
				if (Inputs == null)
					return this;
				Outputs = new List<List<double>>();
				for (int inputcounter = 0; inputcounter < Inputs.Count; inputcounter++) // for every input set
				{
					ThinkOnce(inputcounter, algo);
				}
				return this;
			}
			else // back propagation
			{
				// http://mattmazur.com/2015/03/17/a-step-by-step-backpropagation-example/
				double eta = 0.5;
				Outputs = new List<List<double>>();
				Brain newbrain = new Brain(this);
				for (int inputcounter = 0; inputcounter < Inputs.Count; inputcounter++) // for every input set
				{
					ThinkOnce(inputcounter);
					for (int j = Synapses.Count - 2; j >= -1; j--) // for each synapse layer (start from output)
					{
						List<Neuron> usedneurons = new List<Neuron>(); // list of used neurons (no duplicit bppart updates)
						for (int k = 0; k < Synapses[j].Count; k++) // for each synapse
						{
							Synapse sold = Synapses[j][k];
							Synapse snew = newbrain.Synapses[j][k];
							Neuron n = sold.Target;
							if (!usedneurons.Contains(n))
							{
								if (n.BPPart == null) // uninitialized=output neuron
									n.BPPart = -(Expected[inputcounter][k] - Outputs[inputcounter][k]); // error->output

								double o_i = n.f.ComputeDerivation(n.Output, n.Slope);
								//double o_i = (n.Output * (1 - n.Output));                   // output->input, LOGISTIC ONLY!!!!!

								n.BPPart *= o_i;
								usedneurons.Add(n);
							}
							// BPPart * weight (summarized across all target neurons) will be used as BPPart in source neuron
							if (sold.Source != null)
							{
								if (sold.Source.BPPart == null)
									sold.Source.BPPart = 0;
								sold.Source.BPPart += n.BPPart * sold.Weight;
							}

							//now add input->weight values
							double input = (sold.Source == null) ? sold.LastInput : sold.Source.Output;
							double weidiff = input * (double)n.BPPart;
							snew.Weight -= eta * weidiff;
						}
					}
				}
				return newbrain;
			}
		}


		public string GetDataStr(List<List<double>> values)
		{
			if (values == null)
				return "";

			StringBuilder sb = new StringBuilder();
			foreach (List<double> line in values)
			{
				bool first = true;
				foreach (double d in line)
				{
					if (!first)
						sb.Append(";");
					else
						first = false;
					if (Math.Round(d, 7) % 1 == 0)
						sb.Append(String.Format("{0:0}", Convert.ToInt32(d)));
					else
						sb.Append(String.Format("{0:0.#######}", d));
				}
				sb.Append("\r\n");
			}
			return sb.ToString();
		}

		public double GetGlobalError(bool squared = false)
		{
			if (Outputs == null)
				Think();
			if (Outputs[0].Count != Expected[0].Count) // malformed expected
				return Double.MaxValue;
			double result = 0;
			if (squared)
			{
				for (int i = 0; i < Outputs.Count; i++)
					for (int j = 0; j < Outputs[i].Count; j++)
					{
						double tmp = 0.5 * Math.Pow(Expected[i][j] - Outputs[i][j], 2);
						result += tmp;
					}
			}
			else // normal error
			{
				for (int i = 0; i < Outputs.Count; i++)
					for (int j = 0; j < Outputs[i].Count; j++)
						result += Math.Abs(Expected[i][j] - Outputs[i][j]);
			}
			return result;
		}


		public void UpdateStructure(Dictionary<int, List<Neuron>> neurons, String synapses, int inputcount)
		{
			// entire brain structure will be changed

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
					double weight = Synapse.GetRandomWeight();
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

			foreach (List<Neuron> list in Neurons.Values)
				foreach (Neuron n in list)
					if (Math.Abs(n.Augment) > maxaugment)
						maxaugment = Math.Abs(n.Augment);

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
						double weight = Synapse.GetRandomWeight();
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
		}

		public String GetSynapsesStr()
		{
			StringBuilder sb = new StringBuilder();
			foreach (int layer in Synapses.Keys)
				foreach (Synapse synapse in Synapses[layer])
					if (synapse.Source == null) // input
						sb.Append(String.Format("{0}:   {1:0.#######}\r\n", synapse.GetName(), synapse.Weight));
					else
						sb.Append(String.Format("{0}: {1:0.#######}\r\n", synapse.GetName(), synapse.Weight));
			return sb.ToString();
		}

		public void UpdateConfiguration(Configuration c)
		{
			// only weights and slopes will be altered

			//assemble list of all neurons and then all synapses
			List<Neuron> allneurons = new List<Neuron>();
			List<Synapse> allsynapses = new List<Synapse>();

			foreach (List<Neuron> nlist in Neurons.Values)
				allneurons.AddRange(nlist);
			foreach (List<Synapse> slist in Synapses.Values)
				allsynapses.AddRange(slist);

			// update data
			if (c.SIAs.Count != allneurons.Count || c.Weights.Count != allsynapses.Count)
				return;
			for (int i = 0; i < allneurons.Count; i++)
			{
				allneurons[i].Slope = c.SIAs[i].Item1;
				allneurons[i].Augment = c.SIAs[i].Item2;
			}
			for (int i = 0; i < allsynapses.Count; i++)
			{
				allsynapses[i].Weight = c.Weights[i];
			}

		}

		public double ComputeMatch()
		{
			if (Outputs != null)
			{
				double matchcount = 0;
				double totalcount = 0;
				if (Outputs.Count == Expected.Count)
					for (int i = 0; i < Outputs.Count; i++)
						if (Outputs[i].Count == Expected[i].Count)
							for (int j = 0; j < Outputs[i].Count; j++)
							{
								totalcount++;
								if (Outputs[i][j] == Expected[i][j])
									matchcount++;
							}
				return totalcount > 0 ? matchcount / totalcount : 0;
			}
			return 0;
		}
	}
}
