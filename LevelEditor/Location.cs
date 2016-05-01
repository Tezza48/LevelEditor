using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    public class Location
    {
        [JsonRequired]
        private string title;
        [JsonRequired]
        private string description;
        [JsonRequired]
        private Exit[] exits;
        [JsonRequired]
        private BindingList<Item> inventory;

        [JsonIgnore]
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        [JsonIgnore]
        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
        [JsonIgnore]
        public BindingList<Item> Inventory
        {
            get
            {
                return inventory;
            }

            set
            {
                inventory = value;
            }
        }
        [JsonIgnore]
        public Exit[] Exits
        {
            get
            {
                return exits;
            }
        }

        public Location(string _title = "New Location", string _description = "")
        {
            title = _title;
            description = _description;
            exits = new Exit[(int)Exit.Directions.Out + 1];
            inventory = new BindingList<Item>();
        }

        public bool addExit(Exit exit)
        {
            bool isValid = !(exits[(int)exit.Direction] == exit);
            if (isValid)
            {
                exits[(int)exit.Direction] = exit;
                return true;
            }
            else
                return false;
        }

        public void addItem(Item newItem)
        {
            inventory.Add(newItem);
        }

        public override string ToString()
        {
            return title;
        }
    }
}
