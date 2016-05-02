using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class LocationEditor : Form
    {
        private BindingList<Location> locations;

        public LocationEditor()
        {
            InitializeComponent();
        }        

        public LocationEditor(ref BindingList<Location> _locations)
        {
            InitializeComponent();
            locations = _locations;
        }

        private void LocationEditor_Load(object sender, EventArgs e)
        {
            lstbxLocation.DataSource = locations;
            UpdateLocEdit();
        }

        private void lstbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxLocation.SelectedItem == null)
            {
                // make the edit area invisible if the list box ends up with a null selected item
                groupbxLocEdit.Visible = false;
            }
            else
            {
                groupbxLocEdit.Visible = true;
                UpdateLocEdit();
            }
        }

        private void UpdateLocEdit()
        {
            // fill all of the boxes with their corresponding data
            groupbxLocEdit.Text = lstbxLocation.SelectedItem.ToString();
            txtbxLocTitle.Text = ((Location)lstbxLocation.SelectedItem).Title;
            txtbxLocDescription.Text = ((Location)lstbxLocation.SelectedItem).Description;
            combxItems.DataSource = ((Location)lstbxLocation.SelectedItem).Inventory;
        }

        private void addLoc_Click(object sender, EventArgs e)
        {
            // add a new location with default values
            locations.Add(new Location());
        }

        private void btnSetLoc_Click(object sender, EventArgs e)
        {
            // set the title and description of this location by overwriting the current one with a new location
            // doing it this way updates the bound listbox
            string title = txtbxLocTitle.Text;
            string description = txtbxLocDescription.Text;
            locations[lstbxLocation.SelectedIndex] = new LevelEditor.Location(title, description);
        }

        private void removeLoc_Click(object sender, EventArgs e)
        {
            // if there is actually a selected location
            if (lstbxLocation.SelectedIndex >= 0)
            {
                // remove it
                locations.Remove(locations[lstbxLocation.SelectedIndex]);
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            // add a blank item to this location
            locations[lstbxLocation.SelectedIndex].Inventory.Add(new Item());
        }

        private void addKey_Click(object sender, EventArgs e)
        {
            // add a blank key to this location
            // keys will always be destroyed on use as i found the reusable keys
            // to be a bit useless and alienating for players whi miss the keys
            locations[lstbxLocation.SelectedIndex].Inventory.Add(new Key());
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            // remove the selected key or item
            locations[lstbxLocation.SelectedIndex].Inventory.RemoveAt(combxItems.SelectedIndex);
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            // make a variable for the item index because we use it a lot
            int i = combxItems.SelectedIndex;
            // if this item is a key
            if (locations[lstbxLocation.SelectedIndex].Inventory[i].GetType() == typeof(Key))
            {
                // replace it with a new key and the newer values
                Key replacement = new Key(txtbxItemName.Text, txtbxItemDescription.Text);
                locations[lstbxLocation.SelectedIndex].Inventory[i] = replacement;
            }
            else
            {
                // same but with a key
                Item replacement = new Item(txtbxItemName.Text, txtbxItemDescription.Text);
                locations[lstbxLocation.SelectedIndex].Inventory[i] = replacement;
            }
        }

        private void combxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fill the text boxes with their respected values from the selected item (or key)
            if (combxItems.SelectedIndex >= 0)
            {
                txtbxItemName.Text = locations[lstbxLocation.SelectedIndex].Inventory[combxItems.SelectedIndex].ItemName;
                txtbxItemDescription.Text = locations[lstbxLocation.SelectedIndex].Inventory[combxItems.SelectedIndex].ItemDescription;
            }
            else
            {
                txtbxItemName.Clear();
                txtbxItemDescription.Clear();
            }
        }
    }
}
