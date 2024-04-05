using System;

namespace my_console_app
{
	internal class MagicNumber
	{
		public static void start()
		{

			bool thisOkay = false;

			while (!thisOkay)
			{
				Console.WriteLine("Are you ready to start the game ? (Yes/No)");
				string? userAnswer = Console.ReadLine();
				userAnswer = userAnswer is not null ? userAnswer : "no";
				thisOkay = userAnswer.ToLower() == "yes";
				continue;
			}

			var magicNumberGenerate = new Random();
			var myMagicNumber = magicNumberGenerate.Next(0, 101);

			int inputValue = 0;

			Console.WriteLine("Enter a value to find the magic number. In the range of 1-100 (example 35)");

			while (inputValue != myMagicNumber)
			{
				string? answer = Console.ReadLine();

				if (answer is null)
				{
					break;
				}
				else
				{
					inputValue = int.Parse(answer);
				}

				if (inputValue < myMagicNumber)
				{
					Console.WriteLine($"This is small number: {inputValue}");
					continue;
				}
				else if (inputValue > myMagicNumber)
				{
					Console.WriteLine($"This is big number: {inputValue}");
					continue;
				}
				else
				{
					break;
				}

			}

			Console.WriteLine($"Wow. This is true. Congratulations. Your magic number is {inputValue}");
		}
	}
}
