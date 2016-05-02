using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    struct SaveData
    {
        // struct for keeping story data together
        // and for making serializing easier.
        public string startText;
        public BindingList<Location> locations;
        public BindingList<Item> playerInventory;
    }
}
