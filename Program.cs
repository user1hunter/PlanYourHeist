using System;

namespace PlanYourHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Plan Your Heist!");

      do
      {
        Member member = new Member();

        Console.WriteLine("Please enter Team Member's Name:");

        string newMemberName = Console.ReadLine();

        if (newMemberName == "")
        {
          break;
        }
        else
        {
          member.Name = newMemberName;

          Console.WriteLine("Please enter Team Member's Skill Level:");
          member.SkillLevel = Int32.Parse(Console.ReadLine());

          Console.WriteLine("Please enter Team Member's Courage Level:");
          member.CourageFactor = double.Parse(Console.ReadLine());


          Console.WriteLine($"{member.Name} has a skill level of {member.SkillLevel} and a courage factor of {member.CourageFactor}.");
        }

      } while (true);

    }
  }
}

