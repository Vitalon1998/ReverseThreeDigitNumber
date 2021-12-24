using System;
using System.Linq;

namespace ReverseThreeDigitNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			string numberString = Console.ReadLine();
			string reversedNumberString = new string(numberString.Reverse().ToArray());
			Console.WriteLine(reversedNumberString);
		}
	}
}
