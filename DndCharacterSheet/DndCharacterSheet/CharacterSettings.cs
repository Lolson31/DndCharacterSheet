using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterSheet
{
    internal class CharacterSettings
    {
        private bool xpLeveling;
        private bool rolledHP;
        private bool useFeats;
        private bool mcRequirements;

        public CharacterSettings()
        {
            xpLeveling= xp;
            rolledHP= rollHP;
            useFeats= feats;
            mcRequirements= multiclass;
        }

        public setXP(bool OnOff) 
        { 
            xpLeveling= OnOff;
        }

        public setRolledHP(bool OnOff) 
        { 
            rolledHP= OnOff;
        }

        public setUseFeats(bool OnOff)
        {
            useFeats = OnOff;
        }

        public setMCRequirments(bool OnOff)
        {
            mcRequirements = OnOff;
        }
    }
}
