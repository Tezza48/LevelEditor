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
            combxItems.DataSource = inventory;
        }

        private void combxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            inventory.Add(new Item());
        }

        private void addKey_Click(object sender, EventArgs e)
        {
            inventory.Add(new Key());
        }

        private void removeItem_Click(object sender, EventArgs e)
        {
            inventory.RemoveAt(combxItems.SelectedIndex);
        }

        private void btnSetLoc_Click(object sender, EventArgs e)
        {
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
