using System.ComponentModel;

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
