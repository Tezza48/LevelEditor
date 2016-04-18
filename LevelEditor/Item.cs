//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Newtonsoft.Json;

namespace LevelEditor
{
    class Item
    {
        [JsonRequired]
        protected string itemName;
        [JsonRequired]
        protected string itemDescription;

        public Item ()
        {
            itemName = "";
            itemDescription = "";
        }

        public Item(string _name, string _description)
        {
            itemName = _name;
            itemDescription = _description;
        }
    }
}
