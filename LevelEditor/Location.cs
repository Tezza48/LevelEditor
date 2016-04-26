using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        private List<Exit> exits;
        [JsonRequired]
        private List<Item> inventory;

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
        public List<Exit> Exits
        {
            get
            {
                return exits;
            }

            set
            {
                exits = value;
            }
        }

        public Location(string _title = "New Location", string _description = "")
        {
            title = _title;
            description = _description;
            exits = new List<Exit>();
            inventory = new List<Item>();
        }

        public void addExit(Exit.Directions direction, int targetLoc)
        {
            bool exitAlreadyExists = false;
            foreach (Exit currentExit in exits)
            {
                if (currentExit.Direction == direction)
                {
                    currentExit.LeadsTo = targetLoc;
                    exitAlreadyExists = true;
                }
            }
            if (!exitAlreadyExists)
            {
                exits.Add(new Exit(direction, targetLoc));
            }
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
