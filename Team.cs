using System.Collections.Generic;

namespace Heist
{
    public class Team
    {
        private int _collectiveSkill = 0;
        public int CollectiveSkill
        {
            get
            {
                return _collectiveSkill;
            }
        }
        public List<TeamMember> TeamList = new List<TeamMember>();
        public void CalculateSkill()
        {
            foreach (TeamMember member in TeamList)
            {
                _collectiveSkill += member.SkillLevel;
            }
        }
    }
}