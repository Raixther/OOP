using System;

namespace Lesson5
{
	class Program
	{
		static void Main(string[] args)
		{
			RationalNumber R = new(15, 18);

			RationalNumber T = new(46, 16);

			Console.WriteLine(R);

			Console.WriteLine(T);

			Console.WriteLine();

			Console.WriteLine(R + T);

			Console.WriteLine(R - T);

			Console.WriteLine(R * T);

			Console.WriteLine(R / T);

			Console.WriteLine();

			Console.WriteLine(R == T);

			Console.WriteLine(R != T);


			Console.WriteLine(R <= T);

			Console.WriteLine(R>=T);


			float F = (float)T;

			int I = (int)T;

			Console.WriteLine();


			Console.WriteLine(F);

			Console.WriteLine(I);

			Console.ReadKey();
		}
	}









	public sealed class RationalNumber
	{
		private int _numerator;

	    private int _denominator;


		public RationalNumber(int numerator)
		{
			_numerator = numerator;

			_denominator = 1;
		}

		public RationalNumber(int numerator, int denominator)
		{
			_numerator = numerator;

			if(denominator==0)
			{
				return;
			}			
				_denominator = denominator;		
		}

		public override string ToString()
		{
			Simplify();
			return _numerator + "/" + _denominator;
		}	
		  private int GetGreatestCommonDivisor(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

		private void Simplify()
		{
			int d = GetGreatestCommonDivisor(_numerator, _denominator);

			_numerator = _numerator / d;

			_denominator = _denominator / d;
		}

		public static RationalNumber operator *(RationalNumber A, RationalNumber B)
		{
			int newNumerator = A._numerator * B._numerator;

			int newDenominator = A._denominator * B._denominator;

			return new RationalNumber(newNumerator, newDenominator);
		}
		public static RationalNumber operator/(RationalNumber A, RationalNumber B)
		{//дописать проверку на ноль

			if (B._numerator == 0)
			{
				Console.WriteLine("Деление на ноль недопустимо");
				return null;// ????
			}
			else {

				int newNumerator = A._numerator * B._denominator;

				int newDenominator = A._denominator * B._numerator;

				return new RationalNumber(newNumerator, newDenominator);
				}
		}
	
		public  static RationalNumber operator +(RationalNumber A, RationalNumber B)
		{
			int newNumerator = A._numerator * B._denominator + B._numerator * A._denominator;

			int newDenominator = A._denominator * B._denominator;
			
			return new RationalNumber(newNumerator, newDenominator);
		}
		public  static RationalNumber operator -(RationalNumber A, RationalNumber B)
		{
			int newNumerator = A._numerator * B._denominator - B._numerator * A._denominator;

			int newDenominator = A._denominator * B._denominator;

			return new RationalNumber(newNumerator, newDenominator);
		}
		public static RationalNumber operator ++(RationalNumber A)
		{
			return new RationalNumber(A._numerator + A._denominator, A._denominator);		   
		}
		public static RationalNumber operator --(RationalNumber A)
		{
			return new RationalNumber(A._numerator - A._denominator, A._denominator);

		}
		public  static bool operator <(RationalNumber A, RationalNumber B)
		{
			int newAnumerator = A._numerator * B._denominator;

			int newBnumerator = B._numerator * A._denominator;


			if (newAnumerator<newBnumerator)
			{
				return true;
			}
			return false;			
		}
		public  static bool operator >(RationalNumber A, RationalNumber B)
		{
			int newAnumerator = A._numerator * B._denominator;

			int newBnumerator = B._numerator * A._denominator;


			if (newAnumerator > newBnumerator)
			{
				return true;
			}			
				return false;			
		}
		public static bool operator >=(RationalNumber A, RationalNumber B)
		{
			int newAnumerator = A._numerator * B._denominator;

			int newBnumerator = B._numerator * A._denominator;


			if (newAnumerator >= newBnumerator)
			{
				return true;
			}			
				return false;			
		}
		public static bool operator <=(RationalNumber A, RationalNumber B)
		{
			int newAnumerator = A._numerator * B._denominator;

			int newBnumerator = B._numerator * A._denominator;


			if (newAnumerator <= newBnumerator)
			{
				return true;
			}			
				return false;			
		}

		public static explicit operator float(RationalNumber A)
		{
			float a = Convert.ToSingle(A._numerator);

			float b = Convert.ToSingle(A._denominator);

			return a/b;
		}
		public static explicit operator int(RationalNumber A)
		{
			int a = A._numerator / A._denominator;
			return a;
		}
	}
}

