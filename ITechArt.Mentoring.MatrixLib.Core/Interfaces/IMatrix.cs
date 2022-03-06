using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechArt.Mentoring.MatrixLib.Core.Interface
{
	internal interface IMatrix
	{
		double this[int x, int y]
		{
			get; set;
		}
	}
}
