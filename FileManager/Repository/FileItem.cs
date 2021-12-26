using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	public class FileItem
	{
		public FileInfo fileInfo { get; set; }	
     	public string Name { get { return fileInfo.Name; } set { } }
		public string Description { get; set; }		
		public string  Extension { get { return fileInfo.Extension; } set { } }

		public string FullName => fileInfo.FullName;
		public bool IsExist => fileInfo.Exists;
	}
}
