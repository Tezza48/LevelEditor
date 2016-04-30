using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public LocationEditor(ref BindingList<Location> locations)
        {
            InitializeComponent();
            this.locations = locations;
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
            groupbxLocEdit.Text = lstbxLocation.SelectedItem.ToString();
            txtbxLocTitle.Text = ((Location)lstbxLocation.SelectedItem).Title;
            txtbxLocDescription.Text = ((Location)lstbxLocation.SelectedItem).Description;
            combxItems.DataSource = ((Location)lstbxLocation.SelectedItem).Inventory;
        }

        private void addLoc_Click(object sender, EventArgs e)
        {
            locations.Add(new Location());
        }

        private void btnSetLoc_Click(object sender, EventArgs e)
        {
            string title = txtbxLocTitle.Text;
            string description = txtbxLocDescription.Text;
            locations[lstbxLocation.SelectedIndex] = new LevelEditor.Location(title, description);
        }

        private void removeLoc_Click(object sender, EventArgs e)
        {
            if (lstbxLocation.SelectedIndex >= 0)
            {
                locations.Remove(locations[lstbxLocation.SelectedIndex]);
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            locations[lstbxLocation.SelectedIndex].Inventory.Add(new Item());
        }

        private void addKey_Click(object sender, EventArgs e)
        {
            locations[lstbxLocation.SelectedIndex].Inventory.Add(new Key());
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            locations[lstbxLocation.SelectedIndex].Inventory.RemoveAt(combxItems.SelectedIndex);
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            int i = combxItems.SelectedIndex;
            if (locations[lstbxLocation.SelectedIndex].Inventory[i].GetType() == typeof(Key))
            {
                Key replacement = new Key(txtbxItemName.Text, txtbxItemDescription.Text);
                locations[lstbxLocation.SelectedIndex].Inventory[i] = replacement;
            }
            else
            {
                Item replacement = new Item(txtbxItemName.Text, txtbxItemDescription.Text);
                locations[lstbxLocation.SelectedIndex].Inventory[i] = replacement;
            }
        }

        private void combxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbxItemName.Text = locations[lstbxLocation.SelectedIndex].Inventory[combxItems.SelectedIndex].ItemName;
            txtbxItemDescription.Text = locations[lstbxLocation.SelectedIndex].Inventory[combxItems.SelectedIndex].ItemDescription;
        }
    }
}
