using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITechArt.Mentoring.MatrixLib.Core;

namespace ITechArt.Mentoring.MatrixLib.ConsoleApp.Extensions
{
	public static class MatrixLibConsoleExtension
	{
		public static void PrintMatrix(this Matrix Matrix)
		{
			for (int i = 0; i < Matrix.Rows; i++)
			{
				for (int j = 0; j < Matrix.Columns; j++)
				{
					Console.Write(string.Format("{0} ", Matrix[i, j]));
				}
				Console.Write(Environment.NewLine + Environment.NewLine);
			}
		}
	}
}
