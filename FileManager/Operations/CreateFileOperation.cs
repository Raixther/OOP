using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	public class CreateFileOperation : IOperation
	{
		private string _targetPath;

		public CreateFileOperation(string targetPath)
		{
			_targetPath = targetPath;	
		}

		public void Execute()
		{
			File.Create(_targetPath);
		}
	}
}
