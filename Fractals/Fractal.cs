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
		// http://cs.lmu.edu/~ray/notes/ifs/
		// 

		public static int Width = 366;
		public static int Height = 366;

		public Bitmap Picture;

		public Configuration Config { get; set; }
		private Random r;

		public Fractal(Configuration config = null)
		{
			r = new Random();
			Config = (config == null || !config.IsOK()) ? Configuration.IFSEmpty() : config;
			Picture = new Bitmap(Width, Height);

		}

		private static bool IsInRange(double[] p)
		{
			if (p[0] >= 0 && p[1] >= 0 && p[0] < Fractal.Width && p[1] < Fractal.Height)
				return true;
			return false;
		}

		public void ClearPicture()
		{
			using (Graphics g = Graphics.FromImage(Picture))
				g.Clear(Color.Black);
		}

		public void Iterate(int n, int scale, int xoffset, int yoffset)
		{
			ClearPicture();
			List<double[]> newpoints = new List<double[]>();

			double[] lastpoint = new double[] { 0, 0 };



			for (int count = 0; count < n; count++)
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
				if (transformation >= Config.Values["Probability"].Count)
					transformation = Config.Values["Probability"].Count - 1;

				{
					// prepare constants
					double modifier = 1;
					double a = Config.Values["A"][transformation] * modifier;
					double b = Config.Values["B"][transformation] * modifier;
					double c = Config.Values["C"][transformation] * modifier;
					double d = Config.Values["D"][transformation] * modifier;
					double e = Config.Values["E"][transformation] * modifier;
					double f = Config.Values["F"][transformation] * modifier;
					// generate new point
					double[] newpoint = new double[] {(a * (double)lastpoint[0] + b * (double)lastpoint[1] + e),
													  (c * (double)lastpoint[0] + d * (double)lastpoint[1] + f)};




					lastpoint[0] = newpoint[0];
					lastpoint[1] = newpoint[1];

					newpoint[0] = newpoint[0] * scale + xoffset;
					newpoint[1] = newpoint[1] * -scale + yoffset;

					if (IsInRange(newpoint))
					{
						using (Graphics g = Graphics.FromImage(Picture))
							g.FillRectangle(Brushes.White, (float)newpoint[0], (float)newpoint[1], 1, 1);
					}


				}
			}
		}
	}
}

