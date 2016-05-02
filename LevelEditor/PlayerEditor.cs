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
    public partial class PlayerEditor : Form
    {
        BindingList<Item> inventory;

        public PlayerEditor()
        {
            InitializeComponent();
        }

        public PlayerEditor(ref BindingList<Item> _inventory)
        {
            InitializeComponent();
            inventory = _inventory;
        }

        private void PlayerEditor_Load(object sender, EventArgs e)
        {
            // set the data source for the inventory combobox
            // items here cant be used as keys (cant be selected when setting exits)
            // deter user from using this program to cheat items into their inventory.
            combxItems.DataSource = inventory;
        }

        private void combxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fill the textboxes with theit relevent data
            if (combxItems.SelectedIndex >= 0)
            {
                txtbxItemName.Text = inventory[combxItems.SelectedIndex].ItemName;
                txtbxItemDescription.Text = inventory[combxItems.SelectedIndex].ItemDescription;
            }
            else
            {
                txtbxItemName.Clear();
                txtbxItemDescription.Clear();
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            // add a new item
            inventory.Add(new Item());
        }

        private void addKey_Click(object sender, EventArgs e)
        {
            // add a new key
            inventory.Add(new Key());
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            //remove the selected item or key
            inventory.RemoveAt(combxItems.SelectedIndex);
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            // replace the selected item / key with a new one using the new values
            int i = combxItems.SelectedIndex;
            if (inventory[i].GetType() == typeof(Key))
            {
                Key replacement = new Key(txtbxItemName.Text, txtbxItemDescription.Text);
                inventory[i] = replacement;
            }
            else
            {
                Item replacement = new Item(txtbxItemName.Text, txtbxItemDescription.Text);
                inventory[i] = replacement;
            }
        }
    }
}
