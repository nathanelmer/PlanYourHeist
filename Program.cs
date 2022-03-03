using System;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.Write("Enter the Team Member's Name: ");
            string chosenName = Console.ReadLine();
            Console.WriteLine($"Enter {chosenName}'s Skill Level: ");
            int chosenSkill = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {chosenName}'s Courage Level (0.0 - 2.0): ");
            double chosenCourage = double.Parse(Console.ReadLine());
            TeamMember NewMember = new TeamMember(chosenName, chosenSkill, chosenCourage);
            Console.WriteLine($"Your member is: {NewMember.Name}, skill level {NewMember.SkillLevel}, with a courage factor of {NewMember.CourageFactor}!!!");
        }
    }
}
