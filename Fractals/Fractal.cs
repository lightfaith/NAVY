using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractals
{
	public class Fractal
	{
		// http://www.frontiernet.net/~jacobc87/fractalIFS.html

		public static readonly Dictionary<String, Configuration> Examples = new Dictionary<string, Configuration>
		{
			//{"IFS - Triangles" , Configuration.IFSTriangles },
			{"IFS - Empty" , Configuration.IFSEmpty() },
			{ "IFS - Tree" , Configuration.IFSTree() },
		};
	}
}
