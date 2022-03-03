using System;

namespace PlanYourHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      //Small header for the program
      Console.WriteLine("Plan Your Heist!");

      Team HeistTeam = new Team();

      //allows the user to input a difficulty for the bank they want to simulate a heist on
      Console.Write("Please Enter a number to represent the Bank's Difficulty: ");
      int bankDifficulty = int.Parse(Console.ReadLine());

      //do-while loop that repeats until the user enters a blank name for a team member
      do
      {
        Member newMember = new Member();

        //asks the user to input a member for their next team member
        Console.Write("Please enter Team Member's Name: ");

        string newMemberName = Console.ReadLine();

        if (newMemberName == "")
        {
          //ends the loop when user enters a blank name
          break;
        }
        else
        {
          newMember.Name = newMemberName;

          //asks user to input the skill level for each member they input
          Console.Write("Please enter Team Member's Skill Level: ");
          newMember.SkillLevel = int.Parse(Console.ReadLine());

          //asks user to input the courage level for each member they input 
          Console.Write("Please enter Team Member's Courage Level: ");
          newMember.CourageFactor = double.Parse(Console.ReadLine());

          //adds the new member the user input into a member list
          HeistTeam.Members.Add(newMember);

          //small if statement that changes output based on whether the number of team members is greater than 1
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

      //for loop to run the simulation as many times as the user enters into trial runs above
      for (int i = 0; i < trialRuns; i++)
      {
        int skillLevels = HeistTeam.TeamSkillLevel();

        //the function to add the luck factor to the heist simulation
        int heistLuck = new Random().Next(-10, 11);

        //resets bank difficulty ever time the loop runs
        int resetBankDifficulty = bankDifficulty + heistLuck;

        //tells the user their teams skill level compared to the banks difficulty level
        Console.WriteLine($"Team's Combined Skill Level: {skillLevels}");
        Console.WriteLine($"Bank's Difficulty Level: {resetBankDifficulty}");

        //if statement to tell user whether their simulated heist was successful
        if (resetBankDifficulty > skillLevels)
        {
          Console.WriteLine("Your Heist Failed.");
          successfulRuns--;
        }
        else
        {
          Console.WriteLine("Your Heist was Successful!");
        }

      }

      //tells the user the number of successful and failed heist simualtions
      Console.WriteLine($"Successful Runs: {successfulRuns}");
      Console.WriteLine($"Failed Runs: {trialRuns - successfulRuns}");

    }
  }
}

