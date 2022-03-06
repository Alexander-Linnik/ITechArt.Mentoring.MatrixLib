using Xunit;
using ITechArt.Mentoring.MatrixLib.Core;

namespace ITechArt.Mentoring.MatrixLib.Core.Tests
{
	public class MatrixLibTests
	{
		[Fact]
		public void MatrixTest()
		{
			var multiplyResult = new Matrix(new double[3, 3]
			{
				{30,36,42},
				{66,81,96},
				{102,126,150},
			});
			var addticionResult = new Matrix(new double[3, 3]
			{
				{2,4,6},
				{8,10,12},
				{14,16,18},
			});
			var transposeResult = new Matrix(new double[3, 3]{
				{1,4,7},
				{2,5,8},
				{3,6,9},
			});

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
			var secondMatrix = new Matrix(3, 3)
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


			Assert.Equal(addticionResult, MatrixOps.Addiction(firstMatrix,secondMatrix));

			Assert.Equal(multiplyResult, MatrixOps.Multiply(firstMatrix, secondMatrix));

			Assert.Equal(transposeResult, MatrixOps.Transpose(firstMatrix));
		}
	}
}