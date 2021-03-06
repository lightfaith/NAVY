﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	[Serializable]
	public class Synapse
	{
		public Neuron Source { get; private set; }
		public Neuron Target { get; private set; }
		public int InputIndex { get; private set; } // an input-layer neuron index
		public double LastInput { get; private set; }
		public double LastDiff { get; set; }  // for BP

		public double Weight { get; set; }

		public Synapse(Neuron source, Neuron target, double weight)
		{
			this.Source = source;
			this.Target = target;
			this.Weight = weight;
			this.LastDiff = 0;
			InputIndex = -1;
		}

		public Synapse(int inputindex, Neuron target, double weight)
		{
			this.Source = null;
			this.Target = target;
			this.Weight = weight;
			this.LastDiff = 0; 
			this.InputIndex = inputindex;
		}

		public void Transfer() // for not an input neuron
		{
			Transfer(Source.Output);
		}

		public void Transfer(double value) // for input neuron
		{
			LastInput = value;
			if (Target != null)
				Target.AddInput(value * Weight);
		}

		public String GetName()
		{
			if (Target != null)
				if (Source != null)
					return String.Format("{0}>{1}", Source.GetName(), Target.GetName());
				else
					return String.Format("i{0}>{1}", InputIndex, Target.GetName()); //input 
			else
				return "";
		}

		public static double GetRandomWeight()
		{
			return (Lib.r.NextDouble() * 2 - 1) * 5;
		}
	}
}
;