using ITechArt.Mentoring.MatrixLib.Core;
using ITechArt.Mentoring.MatrixLib.ConsoleApp.Extensions;

public class Program
{
	static void Main(string[] args)
	{
		var firstMatrix = new Matrix(3, 3)
		{
			[0, 0] = 1,
			[0, 1] = 2,
			[0, 2] = 3,
			[1, 0] = 4,
			[1, 1] = 5,
			[1, 2] = 6,
			[2, 0] = 7,
			[2, 1] = 8,
			[2, 2] = 9,
		};

		var secondMatrix = new Matrix(new double[]{1,2,3,4,5,6,7,8,9},3,3);

		//Console.WriteLine(secondMatrix[1,0]);

		var multiplyResult = MatrixOps.Multiply(firstMatrix, secondMatrix);

		multiplyResult.PrintMatrix();

		var addictionResult = MatrixOps.Addiction(firstMatrix, secondMatrix);

		addictionResult.PrintMatrix();
	}
}




