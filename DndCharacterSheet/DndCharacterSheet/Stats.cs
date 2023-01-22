namespace DndCharacterSheet {
    public class Stats
    {
        private SByte strength { get; set; }
        private SByte dexterity { get; set; }
        private SByte constitution { get; set; }
        private SByte intelligence { get; set; }
        private SByte wisdom { get; set; }
        private SByte charisma { get; set; }

        public Stats(SByte STR, SByte DEX, SByte CON, SByte INT, SByte WIS, SByte CHA)
        {
            strength = STR;
            dexterity = DEX;
            constitution = CON;
            intelligence = INT;
            wisdom = WIS;
            charisma = CHA;
        }

        public sbyte getStrMod()
        {
            return Convert.ToSByte((strength - (strength % 2) - 10) / 2);
        }

        public sbyte getDexMod()
        {
            return Convert.ToSByte((dexterity - (dexterity % 2) - 10) / 2);
        }

        public sbyte getConMod()
        {
            return Convert.ToSByte((constitution - (constitution % 2) - 10) / 2);
        }

        public sbyte getIntMod()
        {
            return Convert.ToSByte((intelligence - (intelligence % 2) - 10) / 2);
        }

        public sbyte getWisMod()
        {
            return Convert.ToSByte((wisdom - (wisdom % 2) - 10) / 2);
        }

        public sbyte getChaMod()
        {
            return Convert.ToSByte((charisma - (charisma % 2) - 10) / 2);
        }
    }
}
