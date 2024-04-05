using System;
using System.Collections;

namespace my_console_app
{
	internal class TeamMembers
	{
		public static void getNewMembersList()
		{
			ArrayList membersList = new ArrayList();
			membersList.Add("Sahil");
			membersList.Add("Nadir");
			membersList.Add("Kamal");
			membersList.Add("Alice");
			membersList.Add("Aykhan");

			foreach(string memberName in membersList)
			{
				Console.WriteLine(string.Format("Team member:{0}",memberName));
			}
		}

		public static void getOldMembersList()
		{
			//string[] memberList = {"Kamran", "Elman", "Sadiq", "Tural", "Solmaz"};

			string[] memberList = new string[5];
			memberList[0] = "Kamran";
			memberList[1] = "Elman";
			memberList[2] = "Sadiq";
			memberList[3] = "Tural";
			memberList[4] = "Solmaz";

			for(int i = 0; i<memberList.Length; i++)
			{
				Console.WriteLine($"Team member: {memberList[i]}");
			}
		} 
	}
}
