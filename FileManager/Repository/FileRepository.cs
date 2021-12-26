using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace FileManager
{
	 public class FilesReposiory:IFilesRepository
	{
		private string _currentDir;

		private DirectoryInfo _index;
		public FilesReposiory()
		{
			_currentDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

			_index = new DirectoryInfo(_currentDir);
		}
		public string CurrentDirectory
		{
			get
			{
				return _currentDir;
			}
			set	
			{
				_currentDir = value;
			}
		}


		public DirectoryInfo Index
		{
			get
			{
				return _index;
			}
			set
			{
				_index = value;
			}
		}

		public void Refresh()
		{
			DirectoryInfo info = Directory.GetParent(_currentDir);

			if (info is null) return;

			_currentDir = info.FullName;

			_index = info;
		}		

		public List<FileItem> Get()
		{
			FileInfo[] files = _index.GetFiles();

			List<FileItem> items = new List<FileItem>(files.Length);

			foreach (FileInfo fileInfo in files)
			{
				FileItem fileItem = new FileItem();

				fileItem.fileInfo = fileInfo;


				fileItem.Name = fileInfo.Name;

				fileItem.Extension = fileInfo.Extension;

				items.Add(fileItem);
			}
			return items;
		}

		public List<DirectoryInfo> GetDirectories(){
			DirectoryInfo[] directories = _index.GetDirectories();

			List<DirectoryInfo> items = new List<DirectoryInfo>(directories.Length);

			foreach (var item in directories)
			{
				items.Add(item);
			}
		
			return items;
		}

		public IEnumerator<FileItem> GetEnumerator()
		{
			foreach (FileItem item in Get())
			{
				yield return item;
			}

		}

		public void ChangeCurrentDir(string currentDir)
		{
			if (Directory.Exists(currentDir))
			{
				_currentDir = currentDir;

				_index = new DirectoryInfo(currentDir);
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
