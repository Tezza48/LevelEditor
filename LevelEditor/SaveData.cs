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
        public string startText;
        public BindingList<Location> locations;
        public BindingList<Item> playerInventory;
    }
}
