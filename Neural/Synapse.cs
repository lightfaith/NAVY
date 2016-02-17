using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	public class Synapse
	{
		public String Source { get; private set; }
		public double Weight { get; set; }

		public Synapse(String source, double weight)
		{
			this.Source = source;
			this.Weight = weight;
		}
	}
}
;