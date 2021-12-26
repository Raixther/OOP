using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
     public	interface IFilesRepository :IEnumerable<FileItem>{ 
	    public string CurrentDirectory { get; set; }

		public DirectoryInfo Index { get; set; }

		public List<FileItem> Get();

		public List<DirectoryInfo> GetDirectories();

		public void ChangeCurrentDir(string currentDir);
		public void Refresh();

	}
}
