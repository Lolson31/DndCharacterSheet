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
            xpLeveling= true;
            rolledHP= true;
            useFeats= true;
            mcRequirements= true;
        }

        public void setXP(bool OnOff) 
        { 
            xpLeveling= OnOff;
        }

        public void setRolledHP(bool OnOff) 
        { 
            rolledHP= OnOff;
        }

        public void setUseFeats(bool OnOff)
        {
            useFeats = OnOff;
        }

        public void setMCRequirments(bool OnOff)
        {
            mcRequirements = OnOff;
        }
    }
}
