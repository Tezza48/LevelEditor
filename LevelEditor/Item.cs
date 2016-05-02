using Newtonsoft.Json;

namespace LevelEditor
{
    public class Item
    {
        [JsonRequired]
        private string itemName;
        [JsonRequired]
        private string itemDescription;

        [JsonIgnore]
        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }
        [JsonIgnore]
        public string ItemDescription
        {
            get
            {
                return itemDescription;
            }

            set
            {
                itemDescription = value;
            }
        }

        public Item(string _name = "New Item", string _description = "")
        {
            itemName = _name;
            itemDescription = _description;
        }

        public override string ToString()
        {
            return itemName;
        }
    }
}
