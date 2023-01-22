using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private String[] tags;
        private String[] actions;

        public Item(string itemName, string itemDescription, int itemCost) {
            name = itemName;
            description = itemDescription;
            cost = itemCost;
        }

        public string GetName() { 
            return name;
        }

        public string GetDescription() {
            return description;
        }

        public int GetCost() { 
            return cost;
        }

        public string GetTags() {
            string tagString = "[";
            foreach (string tag in tags)
            {
                tagString += ", " + tag;
            }
            return tagString + "]";
        }

        public string GetActions()
        {
            string actionString = "[";
            foreach (string action in actions)
            {
                actionString += ", " + action;
            }
            return actionString + "]";
        }
    }
}
