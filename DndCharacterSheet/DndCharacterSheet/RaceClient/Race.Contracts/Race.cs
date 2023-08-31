using System;
using Stats.Contracts;

namespace Race.Contracts
{
    public class Race
    {
        private readonly string name;
        private string description;
        private string creatureType;
        private sbyte size;
        private sbyte speed;
        private List<string> proficiencies;
		// TODO: Implement feature once class is created
		private List<string> languages;
		private ASI asi;
        private List<string> resistances;
        private List<string> immunities;

        public Race(string name, string desc, sbyte size, sbyte speed, List<string> proficiencies,
	        List<string> languages, ASI asi)
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string getName()
        {
            return name;
        }

        public string getDescription()
        {
            return description;
        }

        public List<string> GetProficiencies
        {

        }
    }
}
