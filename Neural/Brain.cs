﻿using System;
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

		public void Think()
		{
			if (Inputs == null)
				return;
			Outputs = new List<List<double>>();
			foreach (List<double> input in Inputs) // for every input set
			{
				List<double> output = new List<double>();
				for (int i = 0; i < input.Count; i++) // for every single input in input set
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
								s.DoMagic(input[s.InputIndex]);
								firstlayer = false;
							}
					}
				}
				// neurons in last layer did not participate, do that now
				if (Neurons.Count != 0)
					foreach (Neuron n in Neurons[Neurons.Count - 1])
					{
						n.Think();
						output.Add(n.Value);
					}

				//store the results
				Outputs.Add(output);
			}
		}
		/*public List<double> GatherResults()
		{
			List<double> result = new List<double>();
			if (Neurons.Count != 0)
				foreach (Neuron n in Neurons[Neurons.Count - 1])
				{
					result.Add(n.Value);
				}
			return result;
		}*/
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
					if (d % 1 == 0)
						sb.Append(String.Format("{0:0}", Convert.ToInt32(d)));
					else
						sb.Append(String.Format("{0:0.000}", d));
				}
				sb.Append("\r\n");
			}
			return sb.ToString();
		}

		public double GetGlobalError()
		{
			if (Outputs[0].Count != Expected[0].Count) // malformed expected
				return Double.MaxValue;
			double result = 0;
			for (int i = 0; i < Outputs.Count; i++)
				for (int j = 0; j < Outputs[i].Count; j++)
					result += Math.Abs(Expected[i][j] - Outputs[i][j]);
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
						sb.Append(String.Format("{0}:   {1:0.000}\r\n", synapse.GetName(), synapse.Weight));
					else
						sb.Append(String.Format("{0}: {1:0.000}\r\n", synapse.GetName(), synapse.Weight));
			return sb.ToString();
		}

		public void UpdateConfiguration(Configuration c)
		{
			// only weights, slopes and intercepts will be altered

			//assemble list of all neurons and then all synapses
			List<Neuron> allneurons = new List<Neuron>();
			List<Synapse> allsynapses = new List<Synapse>();

			foreach (List<Neuron> nlist in Neurons.Values)
				allneurons.AddRange(nlist);
			foreach (List<Synapse> slist in Synapses.Values)
				allsynapses.AddRange(slist);

			// update data
			if (c.SIs.Count != allneurons.Count || c.Weights.Count != allsynapses.Count)
				return;
			for (int i = 0; i < allneurons.Count; i++)
			{
				allneurons[i].Slope = c.SIs[i].Item1;
				allneurons[i].Intercept = c.SIs[i].Item2;
				allneurons[i].Augment = c.SIs[i].Item3;
			}
			for (int i = 0; i < allsynapses.Count; i++)
			{
				allsynapses[i].Weight = c.Weights[i];
			}

		}
	}
}
