using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	public sealed class GetDirectorySizeOperation : IOperation
	{
		private long _size;

		private DirectoryInfo directory;

		public GetDirectorySizeOperation(string targetPath)
		{
			directory = new(targetPath);
		}

		public void Execute()
		{
			FileInfo[] files = directory.GetFiles();

			for (int i = 0; i < files.Length; i++)
			{
				_size += files[i].Length;
			}
			DirectoryInfo[] directories = directory.GetDirectories();

			for (int i = 0; i < directories.Length; i++)
			{
				directory = directories[i];
				Execute();
			}
			Console.WriteLine(_size);
		}
		
	}
}

