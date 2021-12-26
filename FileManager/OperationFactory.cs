using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
	internal static class OperationFactory
	{
		static public IOperation CreateOperation(CommandParser.ParsedInput input)
		{
			switch (input.command_type)
			{		
				case "DeleteF":

				    return new DeleteFileOperation(input.target);

				case "DeleteD":

			        return new DeleteDirectoryOperation(input.target);

				case "CopyF":

					return new CopyFileOperation(input.target, input.second_target);

				case "CopyD":

					return new CopyDirectoryOperation(input.target, input.second_target);

				case "MoveF":

					return new MoveFileOperation(input.target, input.second_target);

				case "MoveD":

					return new MoveDirectoryOperation(input.target, input.second_target);

				case "GetSizeF":

					return new GetFileSizeOperation(input.target);

				case "GetSizeD":

					return new GetDirectorySizeOperation(input.target);

				case "CreateF":

					return new CreateFileOperation(input.target);

				case "CreateD":

					return new CreateDirectoryOperation(input.target);		
			}
			return null;
		}
	}
}
