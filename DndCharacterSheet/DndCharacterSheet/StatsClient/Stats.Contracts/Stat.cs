namespace Stats.Contracts
{
    public class Stat
    {
        private string name;
        private List<string> skills;

        public Stat(string statName, List<string> StatSkills)
        {
            name = statName;
            skills = StatSkills;
        }

        public string GetName()
        {
            return name;
        }

        public List<string> GetSkills()
        {
            return skills;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSkills(List<string> skills)
        {
            this.skills = skills.Sort;
        }

        public bool RemoveSkill(string skill)
        {
            if (skills.IndexOf(skill) < 0)
            {
                return false;
            }
            skills.Remove(skill);
            return true;
        }


        public bool AddSkill(string skill)
        {
            if (skills.IndexOf(skill) < 0)
            {
                skills.Add(skill);
                skills.Sort();
                return true;
            }
            return false;
        }


    }
}
