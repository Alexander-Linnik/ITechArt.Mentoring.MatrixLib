using ITechArt.Mentoring.MatrixLib.Core;

namespace ITechArt.Mentoring.MatrixLib.WebAPI.Extensions
{
	public static class MatrixExtension
	{
		public static List<double[]> MatrixToList(this Matrix matrix)
		{
			var transposedMatrix = new List<double[]>();
			for (int i = 0; i < matrix.Rows; i++)
			{
				var arrayRow = new double[matrix.Columns];
				for (int j = 0; j < matrix.Columns; j++)
				{
					arrayRow[j] = matrix[i, j];
				}
				transposedMatrix.Add(arrayRow);
			}
			return transposedMatrix;
		}
	}
}
