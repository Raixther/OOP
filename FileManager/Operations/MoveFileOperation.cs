using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	class MoveFileOperation : IOperation
	{
		private FileInfo file;

		private string _targetPath;
		public MoveFileOperation(string startPath, string targetPath)
		{
			file = new FileInfo(startPath);
			_targetPath = targetPath;

		}

		public void Execute()
		{
			if (file.Exists)
			{
				file.MoveTo(_targetPath);
			}
		}
	}
}
