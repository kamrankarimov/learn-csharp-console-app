using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_console_app
{
	internal class SmsSystem
	{
		public static void generateRandomOTP(int limitStart, int limitEnd)
		{

			bool proccessStart = true;
			int limit = 0;
			int newLimit = 0;

			while(proccessStart)
			{
				Console.WriteLine($"\n\nEnter the number of sms codes to be generate, max {limitEnd}: (example 50) ");

				string? answer = Console.ReadLine();
				try
				{
					limit = int.Parse(answer) ;
				}catch (Exception) {
					Console.WriteLine("\nDo not enter wrong information or do not enter anything at all. ");
					continue;
				}

				if(limit > limitEnd)
				{
					Console.WriteLine($"\nPlease do not exceed the maximum limit setting or change the settings. Maximum limit: {limitEnd}. If you want, you can change the limit just for now. What would you like the limit to be? Yes/No");
					
					string? limitChangeAnswer = Console.ReadLine();
					limitChangeAnswer = limitChangeAnswer is not null ? limitChangeAnswer : "restart";

					if(limitChangeAnswer.ToLower() == "yes")
					{
						Console.WriteLine($"\nPlease write new limit number: example({ limitEnd * 10})");
						string? limitChangeAnswerNum = Console.ReadLine();
						
						try
						{
							limitChangeAnswerNum = limitChangeAnswerNum is not null ? limitChangeAnswerNum : limitEnd.ToString();
							newLimit = int.Parse(limitChangeAnswerNum);
						}catch(Exception)
						{
							Console.WriteLine($"Nothing has changed. Limit {limitEnd}");
							break;
						}
						

						if(newLimit == limitEnd)
						{
							Console.WriteLine($"Nothing has changed. Limit {limitEnd}");
							break;
						}
						else if (newLimit < limitEnd)
						{
							Console.WriteLine("\nThe new limit cannot be less than the old limit");
							continue;
						}
						else
						{
							Console.WriteLine($"Limit changed just for now. Old limit: {limitEnd} - New limit: {newLimit}");
							limitEnd = newLimit;
							break;
						}

					}
					else if(limitChangeAnswer.ToLower() == "no")
					{
						continue;
					}
					else
					{
						Console.WriteLine("Wrong answer! Please try again!");
						continue;
					}
				}
				else
				{
					break;
				}
				
			}

			int[] otpCodees = new int[limit];
			var randomOtp = new Random();

			Console.WriteLine("\n\nStarting Proccess:\n");

			for (int i = 0; i < otpCodees.Length; i++) {
				otpCodees[i] = randomOtp.Next(limitStart, limitEnd);
				Console.WriteLine($"{i}. Generated OTP Code: {otpCodees[i]}");
			}

			Console.WriteLine($"\nFinish! Generated {otpCodees.Length} code.\n");
		}
	}
}
