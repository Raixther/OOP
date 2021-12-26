using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	class CreateDirectoryOperation:IOperation
	{
		private string _targetPath;

		public CreateDirectoryOperation(string targetPath)
		{
			_targetPath = targetPath;
		}

		public void Execute()
		{
			Directory.CreateDirectory(_targetPath);
		}
	}
}
