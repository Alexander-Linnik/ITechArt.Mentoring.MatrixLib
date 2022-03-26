using ITechArt.Mentoring.MatrixLib.Core;
namespace ITechArt.Mentoring.MatrixLib.WebAPI.Interfaces
{
	public interface IMatrixOps
	{
		Matrix Transpose(Matrix matrix);
		Matrix Addiction(Matrix firtsMatrix, Matrix secondMatrix);
		Matrix Multiply(Matrix firtsMatrix, Matrix secondMatrix);
	}
}
