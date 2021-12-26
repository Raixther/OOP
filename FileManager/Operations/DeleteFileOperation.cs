
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	public sealed class DeleteFileOperation : IOperation
	{
		private FileInfo _target;

		public DeleteFileOperation(string targetPath)
		{
			_target = new FileInfo(targetPath);

		}
		public void Execute()
		{
			if (_target is null||_target.Exists==false) return;

			File.Delete(_target.FullName) ;				
		}
	}
}
