using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITechArt.Mentoring.MatrixLib.Core
{
	public static class MatrixOps
	{
		public static Matrix Transpose(Matrix Matrix)
		{
			var rows = Matrix.Rows;
			var columns = Matrix.Columns;

			var result = new Matrix(columns, rows);

			for (var i = 0; i < columns; i++)
			{
				for (var j = 0; j < rows; j++)
				{
					result[i, j] = Matrix[j, i];
				}
			}
			return result;
		}

		public static Matrix Addiction(Matrix FirstMatrix, Matrix SecondMatrix)
		{
			var rowLength = FirstMatrix.Rows;
			var columnLength = FirstMatrix.Columns;
			if (SecondMatrix.Rows != FirstMatrix.Rows || SecondMatrix.Columns != FirstMatrix.Columns)
			{
				throw new Exception("A matrix can only be added to (or subtracted from) another matrix if the two matrices have the same dimensions.");
			}
			var addictionResult = new Matrix(rowLength, columnLength);

			for (int i = 0; i < rowLength; i++)
			{
				for (int j = 0; j < columnLength; j++)
				{
					addictionResult[i, j] = FirstMatrix[i, j] + SecondMatrix[i, j];
				}
			}
			return addictionResult;
		}

		public static Matrix Multiply(Matrix FirstMatrix, Matrix SecondMatrix)
		{
			if (FirstMatrix.Columns != SecondMatrix.Rows)
			{
				throw new Exception("The number of columns of the 1st matrix must equal the number of rows of the 2nd matrix.");
			}
			else
			{
				Matrix result = new Matrix(FirstMatrix.Rows, SecondMatrix.Columns);
				var temp = 0.0;
				for (int i = 0; i < FirstMatrix.Rows; i++)
				{
					for (int j = 0; j < SecondMatrix.Columns; j++)
					{
						temp = 0;
						for (int k = 0; k < FirstMatrix.Columns; k++)
						{
							temp += FirstMatrix[i, k] * SecondMatrix[k, j];
						}
						result[i, j] = temp;
					}
				}
				return result;
			}
		}

	}
}
