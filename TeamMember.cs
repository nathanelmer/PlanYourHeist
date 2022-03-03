using System;

namespace Heist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        public TeamMember(string userName, int userSkillLevel, double userCourageFactor)
        {
            Name = userName;
            SkillLevel = userSkillLevel;
            CourageFactor = userCourageFactor;
        }
    }
}