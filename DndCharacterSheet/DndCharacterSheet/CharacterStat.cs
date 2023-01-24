using Microsoft.Maui.Controls;

namespace DndCharacterSheet
{
    public class CharacterStat : Stat
    {
        private sbyte baseVal;
        private sbyte racialVal;
        private sbyte ASI;
        private List<string> proficiencies;
        private List<string> expertises;

        public CharacterStat(String name, List<string> skills, sbyte baseVal, sbyte racialVal, sbyte ASI, List<string> proficiencies, List<string> expertise) : base(name, skills)
        {
            this.baseVal = baseVal;
            this.racialVal = racialVal;
            this.ASI = ASI;
            this.proficiencies = proficiencies;
            this.expertises = expertise;
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

        public bool AddProficiency(string proficiency) {
			if (proficiencies.IndexOf(proficiency) < 0)
			{
				proficiencies.Add(proficiency);
				proficiencies.Sort();
				return true;
			}
			return false;

		}

		public bool RemoveProficiency(string proficiency)
		{
			if (proficiencies.IndexOf(proficiency) < 0)
			{
				return false;
			}
			proficiencies.Remove(proficiency);
			proficiencies.Sort();
			return true;

		}

		public List<string> GetExpertise()
        {
            return expertises;
        }

		public bool AddExpertise(string expertise)
		{
			if (expertises.IndexOf(expertise) < 0)
			{
				expertises.Add(expertise);
				expertises.Sort();
				return true;
			}
			return false;

		}

		public bool RemoveExpertise(string expertise)
		{
			if (expertises.IndexOf(expertise) < 0)
			{
				return false;
			}
			expertises.Remove(expertise);
			expertises.Sort();
			return true;

		}

		public sbyte GetMod()
        {
            int stat = baseVal + racialVal + ASI;
            return Convert.ToSByte((stat - (stat % 2) - 10) / 2);
        }
    }
}
