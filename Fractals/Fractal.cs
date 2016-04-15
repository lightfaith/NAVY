using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Fractals
{
	public class Fractal
	{
		// http://www.frontiernet.net/~jacobc87/fractalIFS.html

		public static int Width = 366;
		public static int Height = 366;
		public static readonly Dictionary<String, Configuration> Examples = new Dictionary<string, Configuration>
		{
			//{"IFS - Triangles" , Configuration.IFSTriangles },
			{ "IFS - Empty" , Configuration.IFSEmpty(Fractal.Width, Fractal.Height) },
			{ "IFS - Tree" ,  Configuration.IFSTree(Fractal.Width, Fractal.Height)  },
			{ "IFS - Fern" ,  Configuration.IFSFern(Fractal.Width, Fractal.Height)  },
			{ "IFS - Triangle" ,  Configuration.IFSTriangle(Fractal.Width, Fractal.Height)  },
		};

		public List<double[]> Points { get; set; }
		public Configuration Config { get; set; }
		private Random r;

		public Fractal(Configuration config = null)
		{
			r = new Random();
			Config = (config == null || !config.IsOK()) ? Configuration.IFSEmpty(Fractal.Width, Fractal.Height) : config;
			Points = new List<double[]>();
			Points.AddRange(Config.InitPoints);

			//Points.Add(new double[] { 0.8*Fractal.Width, 0.8*Fractal.Height });
			//Points.Add(new double[] { 60, 90 });

		}

		private static bool IsInRange(double[] p)
		{
			if (p[0] >= 0 && p[1] >= 0 && p[0] < Fractal.Width && p[1] < Fractal.Height)
				return true;
			return false;
		}

		public void Iterate()
		{


			if (!Config.IsOK() || Points.Count > Math.Pow(2, 20)) // no need...
				return;

			List<double[]> newpoints = new List<double[]>();
			foreach (double[] p in Points)
			{
				// which transformation to choose?
				double rnd = Math.Round(r.NextDouble(), 3);
				int transformation = 0;
				for (int i = 0; i < Config.Values["Probability"].Count; i++)
				{
					if (Math.Round(rnd, 3) <= Config.Values["Probability"][i])
						break;
					rnd -= Config.Values["Probability"][i];
					transformation++;
				}
				// prepare constants
				double modifier = 1;
				double a = Config.Values["A"][transformation] * modifier;
				double b = Config.Values["B"][transformation] * modifier;
				double c = Config.Values["C"][transformation] * modifier;
				double d = Config.Values["D"][transformation] * modifier;
				double e = Config.Values["E"][transformation] * modifier;
				double f = Config.Values["F"][transformation] * modifier;
				// generate new point
				double[] newpoint = new double[] {(int)( a* (float)p[0] + b * p[1] + e),
										   (int)(c * (float)p[0] + d * p[1] + f)};

				if (IsInRange(newpoint))
					newpoints.Add(newpoint);
			}
			Points.AddRange(newpoints);
		}
	}
}
