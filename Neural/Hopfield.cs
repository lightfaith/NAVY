using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural
{
	public class Hopfield
	{
		// https://www.youtube.com/watch?v=gnUI6PaHqCw

		public static int Unit { get; private set; } = 30;
		public static int Height { get; private set; } = 7;
		public static int Width { get; private set; } = 5;
		//public static int Height { get; private set; } = 1;
		//public static int Width { get; private set; } = 4;

		public int Size { get; private set; }
		Dictionary<int, List<double>> synapses = new Dictionary<int, List<double>>();
		public Dictionary<char, List<double>> Symbols = new Dictionary<char, List<double>>();


		public Hopfield()
		{
			Size = Hopfield.Height * Hopfield.Width;
			for (int i = 0; i < Size; i++)
			{
				synapses.Add(i, new List<double>());
				for (int j = 0; j < Size; j++)
					synapses[i].Add(0);
			}


			Symbols.Add(' ', (new double[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }).ToList<double>());
			Symbols.Add('A', (new double[] { 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 }).ToList<double>());
			Symbols.Add('H', (new double[] { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 }).ToList<double>());
			Symbols.Add('O', (new double[] { 0, 1, 1, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 0 }).ToList<double>());
		}

		public void Train(List<double> values)
		{
			if (values.Count != Size)
				return;


			Dictionary<int, List<double>> m2 = new Dictionary<int, List<double>>();
			for (int i = 0; i < Size; i++)
				m2.Add(i, (from x in values select x * 2 - 1).ToList<double>());

			Dictionary<int, List<double>> m3 = new Dictionary<int, List<double>>();
			for (int i = 0; i < Size; i++)
				m3.Add(i, (from x in m2[i] select m2[0][i] * x).ToList<double>());


			/*// perform matrix multiplication
			for (int i = 0; i < Size; i++)
				for (int j = 0; j < Size; j++)
				{
					if (i == j)
						m3[i][j] = 0;
					else
					{
						m3[i][j] = 0;
						for (int k = 0; k < Size; k++)
							m3[i][j] += m3[i][k] + m3[j][k];
					}
				}
*/
			// add m3 to synapses
			for (int i = 0; i < Size; i++)
				for (int j = 0; j < Size; j++)
					synapses[i][j] += m3[i][j];
		}

		public List<double> Classify(List<double> values)
		{
			if (values.Count != Size || synapses == null)
				return values;
			// bipolarize
			for (int i = 0; i < values.Count; i++)
				values[i] = values[i] * 2 - 1;

			List<double> result = new List<double>();
			foreach (int neuron in synapses.Keys)
			{
				double sum = 0;
				for (int i = 0; i < Size; i++)
					sum += values[i] * synapses[neuron][i];
				result.Add(sum > 0 ? 1 : 0);
			}
			return result;
		}
	}
}
