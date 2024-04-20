using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

public class FileDirectoryTree : IDirectoryTree<FileInfo>, IDirectoryTree
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

	public DirectoryInfo realDirectory
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

	public IDirectoryTree<FileInfo> parent
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

	public IEnumerable<IDirectoryTree<FileInfo>> children
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

	public IEnumerable<FileInfo> files
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

	public FileDirectoryTree(string path, IDirectoryTree<FileInfo> parent = null)
	{
	}

	public FileDirectoryTree(DirectoryInfo realDirectory, IDirectoryTree<FileInfo> parent = null)
	{
	}

	public void Refresh()
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public IEnumerable<FileInfo> GetFilesRecursive()
	{
		return null;
	}
}
