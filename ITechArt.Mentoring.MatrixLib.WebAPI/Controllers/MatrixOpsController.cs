using Microsoft.AspNetCore.Mvc;
using ITechArt.Mentoring.MatrixLib.WebAPI.Interfaces;
using ITechArt.Mentoring.MatrixLib.Core;
using ITechArt.Mentoring.MatrixLib.WebAPI.Models;
using ITechArt.Mentoring.MatrixLib.WebAPI.Extensions;

namespace ITechArt.Mentoring.MatrixLib.WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class MatrixOpsController : Controller
	{
		private readonly IMatrixOps _matrixOps;

		public MatrixOpsController(IMatrixOps matrixOps)
		{
			_matrixOps = matrixOps;
		}

		[HttpPost("Transpose")]
		public List<double[]> Transpose(MatrixViewModel matrix)
		{
			var transposeResult = _matrixOps.Transpose(new Matrix(matrix.Array, matrix.Rows, matrix.Columns));		
			return transposeResult.MatrixToList();
		}

		[HttpPost("Addiction")]
		public List<double[]> Addiction(MatrixCollectionModel matrices)
		{
			var addictionResult = _matrixOps.Addiction(MatrixViewToMatrix(matrices.FirstMatrix), MatrixViewToMatrix(matrices.SecondMatrix));
			return addictionResult.MatrixToList();
		}

		[HttpPost("Multiply")]
		public List<double[]> Multiply(MatrixCollectionModel matrices)
		{
			var multiplyResult = _matrixOps.Multiply(MatrixViewToMatrix(matrices.FirstMatrix), MatrixViewToMatrix(matrices.SecondMatrix));
			return multiplyResult.MatrixToList();
		}

		private static Matrix MatrixViewToMatrix(MatrixViewModel matrixView) =>
			new Matrix(matrixView.Array, matrixView.Rows, matrixView.Columns);
	}
}
