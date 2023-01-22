namespace DndCharacterSheet
{
    public class CharacterStat : Stat
    {
        private sbyte baseVal;
        private sbyte racialVal;
        private sbyte ASI;
        private String[] proficiencies;
        private String[] expertise;

        public CharacterStat(String name, String[] skills, sbyte baseVal, sbyte racialVal, sbyte ASI, string[] proficiencies, string[] expertise) : base(name, skills)
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

        public sbyte GetRacialVal()
        {
            return racialVal;
        }

        public sbyte GetASI()
        {
            return ASI;
        }

        public String[] GetProficiencies()
        {
            return proficiencies;
        }

        public String[] GetExpertise()
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
