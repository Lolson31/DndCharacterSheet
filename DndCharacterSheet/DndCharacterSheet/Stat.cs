namespace DndCharacterSheet
{
    public class Stat
    {
        private string name;
        private String[] skills;

        public Stat(string statName, string[] StatSkills)
        {
            this.name = statName;
            this.skills = StatSkills;
        }

        public string GetName()
        {
            return name;
        }

        public string[] GetSkills()
        {
            return skills;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSkills(string[] skills)
        {
            this.skills = skills;
        }
    }
}
