using System;
using System.Text;

namespace Lesson7
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "ABCD";

			ACoder A = new();

			BCoder B = new();

			string a = Encode(s, A);

			string b = Encode(s, B);

			Console.WriteLine(a);

			Console.WriteLine(b);

			Console.WriteLine(Decode(a, A));

			Console.WriteLine(Decode(b, B));



			static string Encode(string str, ICoder coder)
			{
				return coder.Encode(str);
			}

			static string Decode(string str, ICoder coder)
			{
				return coder.Decode(str);
			}


			Console.ReadKey();
		
		}
	}


	interface ICoder
	{
		string Encode(string str);
		string Decode(string str);
	}



	public class ACoder : ICoder
	{
	

		public string Decode(string str)
		{
			StringBuilder strb = new(str.Length);

			for (int i = 0; i < str.Length; i++)
			{
				strb.Append(Convert.ToChar((int)str[i]-1));
			}
			return strb.ToString();
		}

		public string Encode(string str)
		{
			StringBuilder strb = new(str.Length);

			for (int i = 0; i < str.Length; i++)
			{
				strb.Append(Convert.ToChar((int)str[i]+1));			
			}
			return strb.ToString();
		}
	}

	public class BCoder : ICoder
	{
		public string Decode(string str)
		{
			StringBuilder strb = new(str.Length);

			for (int i = 0, j = 25; i < str.Length; i++, j--)
			{
				strb.Append(Convert.ToChar((int)str[i] - (j - i)));
			}
			return strb.ToString();
		}
		
		public string Encode(string str)
		{
			StringBuilder strb = new(str.Length);

			for (int i = 0, j = 25; i < str.Length; i++, j--)
			{
				strb.Append(Convert.ToChar((int)str[i] + (j-i)));
			}
			return strb.ToString();
		}
	}
}
