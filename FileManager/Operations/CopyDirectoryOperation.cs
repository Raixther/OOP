using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{ 
	public class CopyDirectoryOperation : IOperation
	{
		
		private DirectoryInfo _directory;

		private string _targetPath;

		public CopyDirectoryOperation(string startPath, string targetPath)
		{
			_directory = new DirectoryInfo(startPath);

			_targetPath = targetPath;	
		}
		public void Execute()
		{

			if (_directory.Exists)
			{

				DirectoryInfo[] dirs = _directory.GetDirectories();

				Directory.CreateDirectory(_targetPath);

				FileInfo[] files = _directory.GetFiles();

				foreach (var item in files){
					string tempPath = Path.Combine(_targetPath, item.Name);
					item.CopyTo(tempPath, false);
				}
				foreach (var item in dirs){
					Execute();
				}
			}
		}
	}
}
