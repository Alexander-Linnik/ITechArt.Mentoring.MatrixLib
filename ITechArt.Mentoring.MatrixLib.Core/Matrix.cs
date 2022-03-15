using ITechArt.Mentoring.MatrixLib.Core.Interface;

namespace ITechArt.Mentoring.MatrixLib.Core
{
	public class Matrix : IMatrix
	{
		private readonly double[] _storage;

		public int Rows{get;}
		public int Columns{get;}
		public double this[int i, int j]
		{
			get => _storage[i*this.Columns + j];
			set => _storage[i * this.Columns + j] = value;
		}

		public Matrix(int rows, int columns)
		{
			this._storage = new double[rows * columns];
			this.Rows = rows;
			this.Columns = columns;
		}

		public Matrix(IEnumerable<double> array, int rows, int columns)
		{
			if (rows * columns!=array.Count())
			{
				throw new ArgumentException("");
			}
			this._storage = array.ToArray();
			this.Rows = rows;
			this.Columns = columns;
			
		}
	}
}