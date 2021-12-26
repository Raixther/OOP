using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	public sealed class FileManager
	{
		private FilesReposiory _leftpanel;

		private FilesReposiory _rightpanel;

		public FileManager()
		{
			_leftpanel = new FilesReposiory();
			_rightpanel = new FilesReposiory();
		}
		public IFilesRepository LeftPanel => _leftpanel;

		public IFilesRepository RightPanel => _rightpanel;


		public void Display()
		{
			foreach (var item in LeftPanel.GetDirectories())
			{
				Console.WriteLine(item.Name);
				Console.WriteLine(item.FullName);
				Console.WriteLine();
			}

			foreach (var item in LeftPanel.Get())
			{
				Console.WriteLine(item.Name);
				Console.WriteLine(item.FullName);
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine();
			foreach (var item in RightPanel.GetDirectories())
			{
				Console.WriteLine(item.Name);
				Console.WriteLine(item.FullName);
				Console.WriteLine();
			}

			foreach (var item in RightPanel.Get())
			{
				Console.WriteLine(item.Name);
				Console.WriteLine(item.FullName);
				Console.WriteLine();
			}
		}

	
		public IOperation CreateOperation(string input)
		{
			CommandParser parser = new();
			return OperationFactory.CreateOperation(parser.ParseInput(input));
		}
	}
}