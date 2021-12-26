using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager 
{ 
	public  sealed class GetFileSizeOperation:IOperation///
	{
		private FileInfo _file;
  
		public GetFileSizeOperation(string targetPath){
			_file = new FileInfo(targetPath);
		}
		public void Execute()
		{
			if (_file.Exists)
		      Console.WriteLine( _file.Length);
		}	
	}
}

