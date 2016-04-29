using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LevelEditor
{
    public partial class MainWindow : Form
    {

        private BindingList<LevelEditor.Location> locations;
        private string path = @"data.json";

        public MainWindow()
        {
            InitializeComponent();
        }

        #region Events
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (locations == null) locations = new BindingList<LevelEditor.Location>();
            locations.Add(new LevelEditor.Location());
            combobxExits.DataSource = Enum.GetValues(typeof(Exit.Directions));
            locDisplayBox.DataSource = locations;
            //combobxExitLeadsTo.DataSource = locations.ToString();
            RefreshExitLocations();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLocations();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLocations();
        }

        private void btnSaveLoc_Click(object sender, EventArgs e)
        {
            if (locDisplayBox.SelectedIndex > -1)
            {
                SetLocationAt(locDisplayBox.SelectedIndex);
            }
            else
            {
                AddLocation();
            }
        }

        private void btnNewLoc_Click(object sender, EventArgs e)
        {
            AddLocation();
        }

        private void locationDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEditArea(locDisplayBox.SelectedIndex);
        }

        private void btnRemoveLoc_Click(object sender, EventArgs e)
        {
            if (locDisplayBox.SelectedIndex >= 0 && locDisplayBox.SelectedIndex < locDisplayBox.Items.Count)
            {
                RemoveLocationAt(locDisplayBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You must select a Location to remove first", "Warning");
            }
        }

        private void btnClearExit_Click(object sender, EventArgs e)
        {

        }

        private void btnSetExit_Click(object sender, EventArgs e)
        {
            int i = combobxExitLeadsTo.SelectedIndex;
            Location selectedLocation = locations[i];
            Exit.Directions selectedDirection = (Exit.Directions)combobxExits.SelectedItem;
            selectedLocation.addExit(selectedDirection, i);
        }
        #endregion

        #region Methods

        private void RefreshExitLocations()
        {
            combobxExitLeadsTo.Items.Clear();
            combobxExitLeadsTo.Items.AddRange(locations.ToArray());
        }

        private void AddLocation()
        {
            locations.Add(new Location(txtbxLocName.Text != "" ? txtbxLocName.Text : "New Location", txtbxLocDescription.Text));
            ClearEditArea();
        }

        private void RemoveLocationAt(int i)
        {
            locations[i] = new LevelEditor.Location("REMOVED", "THIS ITEM HAS BEEN REMOVED");
        }

        private void SetLocationAt(int i)
        {
            locations[i].Title = txtbxLocName.Text;
            locations[i].Description = txtbxLocDescription.Text;
            locDisplayBox.Refresh();
        }

        private void UpdateEditArea(int i)
        {
            if (locations.Count > 0 && i >= 0)
            {
                txtbxLocName.Text = ((Location)locDisplayBox.SelectedItem).Title;
                txtbxLocDescription.Text = ((Location)locDisplayBox.SelectedItem).Description;
            }
            else
            {
                txtbxLocName.Text = "";
                txtbxLocDescription.Text = "";
            }
        }

        private void ClearEditArea()
        {
            txtbxLocName.Text = "";
            txtbxLocDescription.Text = "";
        }

        private void SaveLocations ()
        {
            string locStr = JsonConvert.SerializeObject(locations);
            File.WriteAllText(path, locStr);
        }

        private void LoadLocations()
        {
            string data = File.ReadAllText(path);
            locations = JsonConvert.DeserializeObject<BindingList<Location>>(data);
            if (locations == null) locations = new BindingList<Location>();
            locDisplayBox.DataSource = locations;
            combobxExitLeadsTo.DataSource = locations;
        }
        #endregion

        private void combobxExits_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshExitLocations();
        }
    }
}
