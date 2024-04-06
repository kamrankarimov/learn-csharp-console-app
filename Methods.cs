using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_console_app
{
	internal class Methods
	{
		public static void init()
		{
			/*Console.WriteLine(calculate(3, 3));
			Console.WriteLine(calculate(10, 10, 20, 30, 25, 5));
			Console.WriteLine(calculate(new int[] { 444, 444 }));*/

			/*int NumOne = 5;
			RefMethodTest(ref NumOne);
			Console.WriteLine(NumOne);*/

			/*bool TypeCheck = TypeChecker("admin", out string result);
			Console.WriteLine(string.Format("Username: {0}",result));*/

			#region Over Loading Methods

			/*var BioBuilderData = BioBuiler("Kamran", "Karimov", 1997);
			Console.WriteLine($"Your name is {BioBuilderData.fullname} and age {BioBuilderData.age}");

			bool response = BioBuiler("Kamran", "Karimov", 1997, out string data);
			Console.WriteLine($"Proccess Status: {response}. {data}");

			var BioBuilderData1 = BioBuiler(new string[] {"Kamran", "Karimov"}, 1997);
			Console.WriteLine($"Your name is {BioBuilderData1.fullname} and age {BioBuilderData1.age}");*/

			#endregion



		}

		private static int calculate(params int[] numbers)
		{
			int sum = 0;
			foreach (int number in numbers)
			{
				sum += number;
			}
			return sum;
		}

		private static int RefMethodTest(ref int num)
		{
			num++;
			return num;
		}

		private static bool TypeChecker(string type, out string response)
		{
			if (type == "admin") {
				response = "kamrankarimovv";
				return true;
			}
			else
			{
				response = "";
				return false;
			}
		}

		#region Over Loading Methods
		private static (string fullname, int age) BioBuiler(string name, string lastname, int birthday)
		{
			DateTime dateTime = DateTime.Now;
			string fullname = name + " " + lastname;
			int age = dateTime.Year - birthday;
			return (fullname, age);
		}

		private static (string fullname, int age) BioBuiler(string[] info , int birthday)
		{
			DateTime dateTime = DateTime.Now;
			string fullname = info[0] + " " + info[1];
			int age = dateTime.Year - birthday;
			return (fullname, age);
		}

		private static bool BioBuiler(string name, string lastname, int birthday, out string infoData)
		{
			DateTime dateTime = DateTime.Now;
			string fullname = name + " " + lastname;
			int age = dateTime.Year - birthday;


			if(age > 18)
			{
				infoData = $"Your name is {fullname} and age {age}";
				return true;
			}
			else
			{
				infoData = "";
				return false;
			}
			
		}
		#endregion

	}
}
