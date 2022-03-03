using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {

            Bank HeistedBank = new Bank();
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
                Crew.TeamList.Add(NewMember);
                Console.WriteLine($"Your team has {Crew.TeamList.Count} members");
            }
            Console.Write("Please Enter Number Of Tries: ");
            int userTries = int.Parse(Console.ReadLine());
            Crew.CalculateSkill();
            for (int i = 0; i < userTries; i++)
            {
            HeistedBank.CalculateLuck();

            Console.WriteLine($"The bank's difficulty is {HeistedBank.Difficulty}.");
            Console.WriteLine($"The crew's skill level is {Crew.CollectiveSkill}.");

            if (Crew.CollectiveSkill >= HeistedBank.Difficulty)
            {
                Console.WriteLine("You win");
            }
            else
            {
                Console.WriteLine("You Lose");
            }

            }




        }
    }
}
