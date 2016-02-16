using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
    public class Neuron
    {
		private Function f;
		private List<double> weights;
		static Random r = new Random();

		public Neuron(Function f, List<double> weights)
		{
			this.f = f;
			this.weights = weights;
		}

		public double Think(List<double> inputs)
		{
			double result = 0;
			//// will be ensured beforehand
			////generate random weights in (0; 1> if not enough
			//for (int i=weights.Count; i<inputs.Count; i++)
			//{
			//	weights.Add(r.NextDouble());
			//}
			for (int i = 0; i < inputs.Count; i++)
				result += inputs[i] * weights[i];

			// use given function to interpret results
			return f.Compute(result);
		}
    }
}
