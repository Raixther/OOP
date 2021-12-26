using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{ 
	public class DeleteDirectoryOperation : IOperation
	{
		DirectoryInfo _target;
     	public DeleteDirectoryOperation(string targetPath)
		{
			_target = new DirectoryInfo(targetPath);
		}

		public void Execute(){

			foreach (var item in _target.GetFiles())
			{
				item.Delete();
			}
			foreach (var item in _target.GetDirectories())
			{
				item.Delete();
			}
		    _target.Delete();
		}
		
	}
}
