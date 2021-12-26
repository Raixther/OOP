using System;
using System.Collections.Generic;
using System.IO;

namespace FileManager
{
	class Program{
		static void Main(string[] args)
		{
	       FileManager fileManager = new();

			fileManager.Display();

			while (true)
			{
				string input = Console.ReadLine();

				CommandParser parser = new();

				IOperation operation = OperationFactory.CreateOperation(parser.ParseInput(input));

				operation.Execute();

				Console.Clear();

				fileManager.Display();			
			}
		}	
	}
 
}
