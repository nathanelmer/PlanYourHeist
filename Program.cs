using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            Team Crew = new Team();

            Console.WriteLine("Plan Your Heist!");

            bool Playing = true;

            while (Playing == true)
            {
                Console.Write("Enter the Team Member's Name: ");
                string chosenName = Console.ReadLine();
                if (chosenName == "")
                {
                    Playing = false;
                    break;
                }
                Console.WriteLine($"Enter {chosenName}'s Skill Level: ");
                int chosenSkill = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter {chosenName}'s Courage Level (0.0 - 2.0): ");
                double chosenCourage = double.Parse(Console.ReadLine());
                TeamMember NewMember = new TeamMember(chosenName, chosenSkill, chosenCourage);
                Console.WriteLine($"Your member is: {NewMember.Name}, skill level {NewMember.SkillLevel}, with a courage factor of {NewMember.CourageFactor}!!!");
                Crew.TeamList.Add(NewMember);
                Console.WriteLine($"Your team has {Crew.TeamList.Count} members");
            }

            foreach (TeamMember member in Crew.TeamList)
            {
                Console.WriteLine($"Team Member {member.Name} has a skill level of {member.SkillLevel} and a courage factor of {member.CourageFactor}.");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            }


        }
    }
}
