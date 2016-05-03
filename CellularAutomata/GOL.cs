using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CellularAutomata
{
	[Serializable]
	public class GOL
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public byte[,] World { get; set; }
		public int[] SurvivePattern;
		public int[] BirthPattern;
		private int pixelsize;

		public GOL(int width, int height, int pixelsize)
		{
			Width = width / pixelsize;
			Height = height / pixelsize;
			World = new byte[Width, Height];
			this.pixelsize = pixelsize;

		}

		private Boolean OutOfBounds(int x, int y)
		{
			if (x < 0 || y < 0 || x >= Width || y >= Height)
				return true;
			return false;
		}

		public void InvertCell(int x, int y)
		{
			x /= pixelsize;
			y /= pixelsize;
			if (!OutOfBounds(x, y))
				World[x, y] = (World[x, y] == (byte)0) ? (byte)1 : (byte)0;
		}

		public Bitmap GetBitmap()
		{
			Bitmap b = new Bitmap(Width * pixelsize, Height * pixelsize);
			for (int y = 0; y < Height; y++)
				for (int x = 0; x < Width; x++)
					using (Graphics g = Graphics.FromImage(b))
						g.FillRectangle(new SolidBrush((World[x, y] > 0) ? Color.White : Color.Black), x * pixelsize, y * pixelsize, pixelsize, pixelsize);
			return b;
		}

		public void Clear()
		{
			for (int y = 0; y < Height; y++)
				for (int x = 0; x < Width; x++)
					World[x, y] = (byte)0;
		}
		public void Random()
		{
			Random r = new Random();
			for (int y = 0; y < Height; y++)
				for (int x = 0; x < Width; x++)
					World[x, y] = (r.Next()%2==0)?(byte)1:(byte)0;
		}

		public void Iterate()
		{
			if (BirthPattern == null)
				BirthPattern = new int[] { 3 };
			if (SurvivePattern == null)
				SurvivePattern = new int[] { 2, 3 };
			byte[,] newworld = new byte[Width, Height];
			
			for (int y = 0; y < Height; y++)
			{
				for (int x = 0; x < Width; x++)
				{
					int count = 0;
					for (int i = -1; i < 2; i++)
						for (int j = -1; j < 2; j++)
							if ((i != 0 || j != 0) && !OutOfBounds(x + i, y + j) && World[x + i, y + j] > 0)
								count++;
					if (World[x, y] > 0 && !SurvivePattern.Contains(count)) // lonely and exhausted
						newworld[x, y] = (byte)0;
					else if (World[x, y] == 0 && BirthPattern.Contains(count)) // golden ressurection
						newworld[x, y] = (byte)1;
					else
						newworld[x, y] = World[x, y];
				}
			}
			World = newworld;
		}
	}
}
