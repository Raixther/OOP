using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class StringReverter
    {
        public string StringReverse(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int index = input.Length - 1; index >= 0; --index)
                stringBuilder.Append(input[index]);
            return stringBuilder.ToString();
        }
    }
}
