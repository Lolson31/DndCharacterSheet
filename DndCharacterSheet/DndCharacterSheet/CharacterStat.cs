namespace DndCharacterSheet
{
    public class CharacterStat : Stat
    {
        private sbyte baseVal;
        private sbyte racialVal;
        private sbyte ASI;
        private List<string> proficiencies;
        private List<string> expertise;

        public CharacterStat(String name, List<string> skills, sbyte baseVal, sbyte racialVal, sbyte ASI, List<string> proficiencies, List<string> expertise) : base(name, skills)
        {
            this.baseVal = baseVal;
            this.racialVal = racialVal;
            this.ASI = ASI;
            this.proficiencies = proficiencies;
            this.expertise = expertise;
        }

        public sbyte GetBaseVal()
        {
            return baseVal;
        }

        public void SetBaseVal(sbyte baseVal)
        {
            this.baseVal  = baseVal;
        }

        public sbyte GetRacialVal()
        {
            return racialVal;
        }

        public void SetRacialVal(sbyte racialVal) 
        {
            this.racialVal = racialVal;
        }

        public sbyte GetASI()
        {
            return ASI;
        }

        public void IncrementASI()
        {
            this.ASI++;
        }

        public void DecrementASI()
        {
            this.ASI--;
        }

        public List<string> GetProficiencies()
        {
            return proficiencies;
        }

        public bool AddProficiency(string newProficiency) {
            int proficiencyIndex = this.GetSkills().BinarySearch(newProficiency);
            if (proficiencyIndex < 0) 
            {
                return false;
            }

        }

        public List<string> GetExpertise()
        {
            return expertise;
        }

        public sbyte GetMod()
        {
            int stat = baseVal + racialVal + ASI;
            return Convert.ToSByte((stat - (stat % 2) - 10) / 2);
        }
    }
}
