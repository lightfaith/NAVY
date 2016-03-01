using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	public class Synapse
	{
		public Neuron Source { get; private set; }
		public Neuron Target { get; private set; }
		public int InputIndex { get; private set; } // an input-layer neuron index

		public double Weight { get; set; }
		//public double Value { get; set; }

		public Synapse(Neuron source, Neuron target, double weight)
		{
			this.Source = source;
			this.Target = target;
			this.Weight = weight;
			InputIndex = -1;
		}

		public Synapse(int inputindex, Neuron target, double weight)
		{
			this.Source = null;
			this.Target = target;
			this.Weight = weight;
			this.InputIndex = inputindex;
		}

		public void DoMagic() // for not an input neuron
		{
			DoMagic(Source.Think());
		}

		public void DoMagic(double value) // for input neuron
		{
			//Value = value;
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
	}
}
;