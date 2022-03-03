using System;
using System.Linq;
using System.Collections.Generic;

namespace PlanYourHeist
{
  public class Team
  {
    public List<Member> Members { get; set; }

    public Team()
    {
      Members = new List<Member>();
    }

    public void ShowMembers()
    {
      foreach (Member member in Members)
      {
        Console.WriteLine($"{member.Name} has a skill level of {member.SkillLevel} and a courage factor of {member.CourageFactor}.");
      }
    }

    public int TeamSkillLevel()
    {
      return Members.ConvertAll<int>(member => member.SkillLevel).Sum();
    }

  }
}