using ITechArt.Mentoring.MatrixLib.Core;

namespace ITechArt.Mentoring.MatrixLib.ConsoleApp.Extensions
{
	public static class MatrixLibConsoleExtension
	{
		public static void PrintMatrix(this Matrix matrix)
		{
			for (int i = 0; i < matrix.Rows; i++)
			{
				for (int j = 0; j < matrix.Columns; j++)
				{
					Console.Write(string.Format("{0} ", matrix[i, j]));
				}
				Console.Write(Environment.NewLine + Environment.NewLine);
			}
		}
	}
}
