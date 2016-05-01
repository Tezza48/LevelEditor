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
        private string keyName;
        [JsonRequired]
        private string keyDescription;
        [JsonRequired]
        private bool destroyedOnUse;

        [JsonIgnore]
        public string KeyName { get { return keyName; } set { keyName = value; } }

        [JsonIgnore]
        public string KeyDescription { get { return keyDescription; } set { keyDescription = value; } }

        public Key(string _name = "New Key", string _description = "", bool _destroyedOnUse = true)
        {
            keyName = _name;
            keyDescription = _description;
            destroyedOnUse = _destroyedOnUse;
        }

        public override string ToString()
        {
            return "K: " + keyName + ((destroyedOnUse) ? ": D" : "");
        }
    }
}
