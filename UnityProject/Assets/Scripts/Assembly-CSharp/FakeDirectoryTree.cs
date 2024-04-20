using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class FakeDirectoryTree<T> : IDirectoryTree<T>, IDirectoryTree
{
	public string name
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IEnumerable<IDirectoryTree<T>> children
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IEnumerable<T> files
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IDirectoryTree<T> parent
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public FakeDirectoryTree(string name, IEnumerable<T> files = null, IEnumerable<IDirectoryTree<T>> children = null, IDirectoryTree<T> parent = null)
	{
	}

	public FakeDirectoryTree(string name, List<T> files = null, List<FakeDirectoryTree<T>> children = null, IDirectoryTree<T> parent = null)
	{
	}

	public void Refresh()
	{
	}

	public IEnumerable<T> GetFilesRecursive()
	{
		return null;
	}
}
