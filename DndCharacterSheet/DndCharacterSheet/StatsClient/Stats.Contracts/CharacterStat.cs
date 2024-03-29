﻿using System.Security.Cryptography;
using Microsoft.Maui.Controls;

namespace Stats.Contracts
{
    public class CharacterStat : Stat
    {
        private sbyte baseVal;
        private sbyte racialASI;
        private sbyte ASI;
        private sbyte stat;
        private List<string> proficiencies;
        private List<string> expertises;

        public CharacterStat(string name, List<string> skills, sbyte baseVal, sbyte racialASI, sbyte ASI, List<string> proficiencies, List<string> expertise) : base(name, skills)
        {
            this.baseVal = baseVal;
            this.racialASI = racialASI;
            this.ASI = ASI;
            this.proficiencies = proficiencies;
            expertises = expertise;
        }

        public sbyte GetBaseVal()
        {
            return baseVal;
        }

        public void SetBaseVal(sbyte baseVal)
        {
            this.baseVal = baseVal;
        }

        public sbyte GetRacialASI()
        {
            return racialASI;
        }

        public void SetRacialASI(sbyte racialASI)
        {
            this.racialASI = racialASI;
        }

        public sbyte GetASI()
        {
            return ASI;
        }

        public void IncrementASI(sbyte incrementalNum)
        {
            this.ASI += incrementalNum;
        }

		public void DecrementASI(sbyte decrementalNum)
		{
			this.ASI -= decrementalNum;
		}

		public List<string> GetProficiencies()
        {
            return proficiencies;
        }

        public bool AddProficiency(string proficiency)
        {
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
            return Convert.ToSByte((this.stat - this.stat % 2 - 10) / 2);
        }
    }
}
