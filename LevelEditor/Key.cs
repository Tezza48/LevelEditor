using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LevelEditor
{
    public class Key : Item
    {
        [JsonRequired]
        private bool destroyedOnUse;

        public Key(string _name = "New Key", string _description = "", bool _destroyedOnUse = true)
        {
            itemName = _name;
            itemDescription = _description;
            destroyedOnUse = _destroyedOnUse;
        }

        public override string ToString()
        {
            return "K: " + itemName + ((destroyedOnUse) ? ": D" : "");
        }
    }
}
