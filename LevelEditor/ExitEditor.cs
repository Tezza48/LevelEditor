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
            lstbxLocations.DataSource = locations;
            combobxExits.DataSource = Enum.GetValues(typeof(Exit.Directions));
            combobxExitLeads.DataSource = locations.ToArray();
        }

        private void combobxExits_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatecombobxLeads();
        }

        private void UpdatecombobxLeads()
        {
            Location loc = locations[lstbxLocations.SelectedIndex];
            if (loc.Exits[(combobxExits.SelectedIndex) >= 0 ? combobxExits.SelectedIndex : 0] != null)
            {
                combobxExitLeads.SelectedIndex = loc.Exits[combobxExits.SelectedIndex].LeadsTo;
            }
        }

        private void lstbxLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupbxEditor.Text = locations[lstbxLocations.SelectedIndex].Title;
            UpdatecombobxLeads();
        }

        private void btnSetExit_Click(object sender, EventArgs e)
        {
            if (combobxExits.SelectedIndex != (int)Exit.Directions.Undefined)
            {
                bool worked = locations[lstbxLocations.SelectedIndex].addExit(new Exit((Exit.Directions)combobxExits.SelectedIndex, combobxExitLeads.SelectedIndex));
                if (!worked) MessageBox.Show("This location already has a " + combobxExits.SelectedItem.ToString() + ".");
            }
            else
            {
                MessageBox.Show("You need to select a direction.");
            }
        }

        private void btnClearExit_Click(object sender, EventArgs e)
        {

        }
    }
}
