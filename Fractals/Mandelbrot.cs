using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
	public class Mandelbrot
	{
		private int Width;
		private int Height;
		private double MinRe;
		private double MaxRe;
		private double MinIm;
		private double MaxIm;
		private int MaxIterations = 256;
		private double zoomratio = 0.8;

		public Bitmap Picture;


		public Mandelbrot(int width, int height)
		{
			Width = width;
			Height = height;
			MinRe = -2;
			MaxRe = 1;
			MinIm = -1.5;
			MaxIm = MinIm + (MaxRe - MinRe) * Fractal.Height / Fractal.Width;
			Picture = new Bitmap(Width, Height);
		}

		public void SetBorders(double minre, double maxre, double minim)
		{
			MinRe = minre;
			MaxRe = maxre;
			MinIm = minim;
			MaxIm = MinIm + (MaxRe - MinRe) * Fractal.Height / Fractal.Width;
		}

		private void Zoom(int x, int y, double zoomratio)
		{
			// adjust coords to zoom comfortably
			if (zoomratio > 1)
				x = Width - x;
			else
				y = Height - y;

			// old sizes
			double olddiffx = MaxRe - MinRe;
			double olddiffy = MaxIm - MinIm;
			// new sizes
			double diffx = olddiffx * zoomratio;
			double diffy = olddiffy * zoomratio;
			// old min values
			double oldminre = MinRe;
			double oldminim = MinIm;

			// center of the old
			double oldcenterx = (olddiffx) / 2 + oldminre;
			double oldcentery = (olddiffy) / 2 + oldminim;

			// center of the new
			double centerx = ((diffx * x / Width + MinRe) + oldcenterx) / 2;
			double centery = ((diffy * y / Height + MinIm) + oldcentery) / 2;


			// borders around center
			MinRe = centerx - diffx / 2;
			MaxRe = centerx + diffx / 2;
			MinIm = centery - diffy / 2;

			MaxIm = MinIm + (MaxRe - MinRe) * Height / Width;
		}

		public void ZoomIn(int x, int y)
		{
			Zoom(x, y, zoomratio);
		}

		public void ZoomOut(int x, int y)
		{
			Zoom(x, y, 1 / zoomratio);
		}


		public void Recompute(string colormode, double? cre = null, double? cim = null)
		{
			double Re_factor = (MaxRe - MinRe) / (Fractal.Width - 1);
			double Im_factor = (MaxIm - MinIm) / (Fractal.Height - 1);

			using (Graphics g = Graphics.FromImage(Picture))
			{
				g.Clear(Color.Black);
				for (int y = 0; y < Height; ++y) // for every row
				{

					for (int x = 0; x < Width; ++x) // for every pixel
					{
						double Z_re = MinRe + x * Re_factor;
						double Z_im = MaxIm - y * Im_factor;
						double c_re = (cre != null) ? (double)cre : Z_re;
						double c_im = (cim != null) ? (double)cim : Z_im;

						Color c = Color.FromArgb(0xff, 0, 0, 0);
						for (int n = 0; n < MaxIterations; n++) // for number of iterations
						{
							double Z_re2 = Z_re * Z_re, Z_im2 = Z_im * Z_im;

							if (Z_re2 + Z_im2 > 4) // out? color it
							{
								switch (colormode)
								{
									case "BlackWhite": { c = Color.FromArgb(0xff, n * (256 / MaxIterations), n * (256 / MaxIterations), n * (256 / MaxIterations)); break; }
									case "Ultra Fractal": { c = Colors.UltraFractal[n % Colors.UltraFractal.Length]; break; }
									case "Blue": { c = Color.FromArgb(0xff, 0, 0, n*(256/MaxIterations)); break; }
								}

								g.FillRectangle(new SolidBrush(c), x, y, 1, 1);
								break;
							}

							Z_im = 2 * Z_re * Z_im + c_im;
							Z_re = Z_re2 - Z_im2 + c_re;
						}
					}
				}
			}
		}
	}
}
