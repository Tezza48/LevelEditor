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

        public Location(string _title = "New Location", string _description = "")
        {
            title = _title;
            description = _description;
            exits = new List<Exit>();
            inventory = new List<Item>();
        }

        public void addExit(Exit exit)
        {
            exits.Add(exit);
        }

        public void addItem(Item newItem)
        {
            inventory.Add(newItem);
        }
    }
}
