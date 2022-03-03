using System;

namespace PlanYourHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");

      Team HeistTeam = new Team();

      Console.Write("Please Enter a number to represent the Bank's Difficulty: ");
      int bankDifficulty = int.Parse(Console.ReadLine());

      do
      {
        Member newMember = new Member();

        Console.Write("Please enter Team Member's Name: ");

        string newMemberName = Console.ReadLine();

        if (newMemberName == "")
        {
          break;
        }
        else
        {
          newMember.Name = newMemberName;

          Console.Write("Please enter Team Member's Skill Level: ");
          newMember.SkillLevel = int.Parse(Console.ReadLine());

          Console.Write("Please enter Team Member's Courage Level: ");
          newMember.CourageFactor = double.Parse(Console.ReadLine());

          HeistTeam.Members.Add(newMember);

          if (HeistTeam.Members.Count > 1)
          {
            Console.WriteLine($"You have {HeistTeam.Members.Count} team members.");
          }
          else
          {
            Console.WriteLine($"You have {HeistTeam.Members.Count} team member.");
          }

        }

      } while (true);

      Console.WriteLine("How many heists would you like to simulate?");

      int trialRuns = int.Parse(Console.ReadLine());

      int successfulRuns = trialRuns;

      for (int i = 0; i < trialRuns; i++)
      {
        int skillLevels = HeistTeam.TeamSkillLevel();

        int heistLuck = new Random().Next(-10, 11);

        bankDifficulty += heistLuck;

        Console.WriteLine($"Team's Combined Skill Level: {skillLevels}");
        Console.WriteLine($"Bank's Difficulty Level: {bankDifficulty}");


        if (bankDifficulty > skillLevels)
        {
          Console.WriteLine("Your Heist Failed.");
          successfulRuns--;
        }
        else
        {
          Console.WriteLine("Your Heist was Successful!");
        }

      }

      Console.WriteLine($"Successful Runs: {successfulRuns}");
      Console.WriteLine($"Failed Runs: {trialRuns - successfulRuns}");

    }
  }
}

