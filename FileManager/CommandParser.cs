using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileManager
{
    public class CommandParser
    {
		public class ParsedInput
        {
           public readonly  string command_type;
           public readonly  string target;
           public readonly  string second_target;
			public ParsedInput(string command_type, string target)
            {
                this.command_type = command_type;
                this.target = target;
                second_target = null;
			}
            public ParsedInput(string command_type, string target, string second_target)
            {
                this.command_type = command_type;
                this.target = target;
                this.second_target = second_target;
            }
        }
        private static string[] SplitInput(string input)
        {
            string separator = @"\s+";
            string[] split_input = Regex.Split(input, separator);
            return split_input;
        }
        public ParsedInput ParseInput(string input){

            string[] parsed_input = SplitInput(input);
            string command_type = parsed_input[0];

            if (parsed_input.Length == 3)
            {
               string target = parsed_input[1];
               string second_target = parsed_input[2];
               return new ParsedInput(command_type, target, second_target);
            }
            else if (parsed_input.Length == 2)
            {
               string target = parsed_input[1];
               return new ParsedInput(command_type, target);
            }
			else
			{
                return null;
			}
        }
    }

	
}

