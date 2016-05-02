using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class ExitEditor : Form
    {
        private BindingList<Location> locations;

        public ExitEditor()
        {
            InitializeComponent();
        }

        public ExitEditor(ref BindingList<Location> locations)
        {
            InitializeComponent();
            this.locations = locations;
        }

        private void ExitEditor_Load(object sender, EventArgs e)
        {
            // set datasources for the location selection box, exit list,
            // exit's destination and the location that contains the key to that exit.
            lstbxLocations.DataSource = locations;
            combobxExits.DataSource = Enum.GetValues(typeof(Exit.Directions));
            // here we use ToArray() to avoid them changing the lstbxLocations's index
            combobxExitLeads.DataSource = locations.ToArray();
            combobxKeyLoc.DataSource = locations.ToArray();
        }

        private void combobxExits_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatecombobxLeads();
        }

        private void UpdatecombobxLeads()
        {
            // when you select an exit direction in the combobox, make an attempt
            // to set the exit's destination box to that exit's destination
            Location loc = locations[lstbxLocations.SelectedIndex];
            // if the selected exit is not null
            // and using a ternary operator to maks sure the index is positive
            // (comboboxes default to -1 when they dont have a selection)
            if (loc.Exits[(combobxExits.SelectedIndex) >= 0 ? combobxExits.SelectedIndex : 0] != null)
            {
                // make the box display the selected index's location
                combobxExitLeads.SelectedIndex = loc.Exits[combobxExits.SelectedIndex].LeadsTo;
            }
        }

        private void lstbxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the text of the edit area to the location we'ree editing
            groupbxEditor.Text = locations[lstbxLocations.SelectedIndex].Title;
            // and update the exit's location box
            UpdatecombobxLeads();
        }

        private void btnSetExit_Click(object sender, EventArgs e)
        {
            // if the selected index isn't 0
            if (combobxExits.SelectedIndex != (int)Exit.Directions.Undefined)
            {
                // if this location is meant to have a key
                if (chbxIsLocked.Checked)
                {
                    // if the key has been selected
                    if (combobxKey.SelectedIndex >= 0)
                    {
                        // make a copy of the selected key
                        Key key = (Key)combobxKey.SelectedItem;
                        // set the exit to a new exit with the selected key and index for the new location
                        bool worked = locations[lstbxLocations.SelectedIndex].addExit(new Exit((Exit.Directions)combobxExits.SelectedIndex, combobxExitLeads.SelectedIndex, key));
                        if (!worked) MessageBox.Show("This location already has a " + combobxExits.SelectedItem.ToString() + "."); // tell the user that that location has already been set
                    }
                    else // tell the user they need to select a key.
                        MessageBox.Show("You need to select a key if this exit is locked.");
                }
                else
                {
                    // set a location without a key
                    bool worked = locations[lstbxLocations.SelectedIndex].addExit(new Exit((Exit.Directions)combobxExits.SelectedIndex, combobxExitLeads.SelectedIndex));
                    if (!worked) MessageBox.Show("This location already has a " + combobxExits.SelectedItem.ToString() + ".");
                }
            }
            else
            {
                MessageBox.Show("You need to select a direction.");
            }
        }

        private void btnClearExit_Click(object sender, EventArgs e)
        {
            // set the selected exit to null (removes it)
            if (combobxExits.SelectedIndex >= 0)
            {
                locations[lstbxLocations.SelectedIndex].Exits[combobxExits.SelectedIndex] = null;
            }
        }

        private void chbxIsLocked_CheckedChanged(object sender, EventArgs e)
        {
            // make the key selecting area visible only when the location has a key
            groupbxKey.Visible = chbxIsLocked.Checked;
            if (chbxIsLocked.Checked)
            {
                combobxKeyLoc.ResetText();
                combobxKey.ResetText();
            }
        }

        private void combobxKeyLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // go through the keys in the selected location and add them to a list we can show to the user.
            List<Key> availableKeys = new List<Key>();
            foreach (Item item in locations[combobxKeyLoc.SelectedIndex].Inventory)
            {
                Key key = item as Key;
                if (key != null) availableKeys.Add(key);
            }
            // set the data source of the key combobox to that list.
            combobxKey.DataSource = availableKeys;
        }
    }
}
