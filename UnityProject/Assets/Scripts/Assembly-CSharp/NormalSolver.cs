using UnityEngine;

public static class NormalSolver
{
	private struct VertexKey
	{
		private readonly long _x;

		private readonly long _y;

		private readonly long _z;

		private const int Tolerance = 100000;

		private const long FNV32Init = 2166136261L;

		private const long FNV32Prime = 16777619L;

		public VertexKey(Vector3 position)
		{
			_x = (long) position.x;
			_y = (long) position.y;
			_z = (long) position.z;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private struct VertexEntry
	{
		public int MeshIndex;

		public int TriangleIndex;

		public int VertexIndex;

		public VertexEntry(int meshIndex, int triIndex, int vertIndex)
		{
			MeshIndex = meshIndex;
			TriangleIndex = triIndex;
			VertexIndex = vertIndex;
		}
	}

	public static void RecalculateNormals(this Mesh mesh, float angle)
	{
	}
}
