using ITechArt.Mentoring.MatrixLib.Core.Interface;

namespace ITechArt.Mentoring.MatrixLib.Core
{
	public class Matrix : IMatrix
	{


		private double[,] _storage;
		public int Rows
		{
			get => this._storage.GetLength(0);
		}
		public int Columns
		{
			get => this._storage.GetLength(1);
		}
		public double this[int i, int j]
		{
			get => _storage[i, j];
			set => _storage[i, j] = value;
		}

		public Matrix(int Rows, int Columns)
		{
			this._storage = new double[Rows, Columns];
		}

		public Matrix(double[,] DoubleMatrix)
		{
			this._storage = DoubleMatrix;
		}
	}
}