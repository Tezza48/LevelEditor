using Newtonsoft.Json;
using System.ComponentModel;

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
            // array with each item being an assignable exit
            // (no longer a list to aviod user adding multiple exits with the same direction.)
            exits = new Exit[(int)Exit.Directions.Out + 1];
            inventory = new BindingList<Item>();
        }

        public bool addExit(Exit exit)
        {
            // has this location already got an exit going tht way
            bool isValid = !(exits[(int)exit.Direction] == exit);
            if (isValid)
            {
                // set that exit
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
