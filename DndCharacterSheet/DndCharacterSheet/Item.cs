using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterSheet
{
    public class Item
    {
        private string name;
        private string description;
        private int cost;

        public Item(string itemName, string itemDescription, int itemCost) {
            name = itemName;
            description = itemDescription;
            cost = itemCost;
        }
    }
}
