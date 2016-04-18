using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    class Location
    {
        [JsonRequired]
        private string title;
        [JsonRequired]
        private string description;
        [JsonRequired]
        private List<Exit> exits;
        [JsonRequired]
        private List<Item> inventory;

        public Location(string _title, string _description)
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
