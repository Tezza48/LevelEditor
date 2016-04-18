using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LevelEditor
{
    class Key : Item
    {
        [JsonRequired]
        private bool destroyedOnUse;

        public Key()
        {
            itemName = "";
            itemDescription = "";
            destroyedOnUse = true;
        }

        public Key(string _name, string _description, bool _destroyedOnUse)
        {
            itemName = _name;
            itemDescription = _description;
            destroyedOnUse = _destroyedOnUse;
        }
    }
}
