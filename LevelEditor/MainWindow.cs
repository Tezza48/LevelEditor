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

        private List<LevelEditor.Location> locations;
        private string path = @"data.json";

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (locations == null) locations = new List<LevelEditor.Location>();
            locations.Add(new LevelEditor.Location());
            RefreshLocationDisplay();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLocations();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLocations();
        }

        private void refreshLocationDisplay_Click(object sender, EventArgs e)
        {
            RefreshLocationDisplay();
        }


        private void btnSaveLoc_Click(object sender, EventArgs e)
        {
            if (locationDisplayBox.SelectedIndex > -1)
            {
                SetLocationAt(locationDisplayBox.SelectedIndex);
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

        private void AddLocation()
        {
            locations.Add(new Location(txtbxLocName.Text != "" ? txtbxLocName.Text : "New Location", txtbxLocDescription.Text));
            RefreshLocationDisplay();
            ClearEditArea();
        }

        private void btnRemoveLoc_Click(object sender, EventArgs e)
        {
            if (locationDisplayBox.SelectedIndex > -1)
            {
                RemoveLocationAt(locationDisplayBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("You must select a Location to remove first", "Warning");
            }
        }

        private void RefreshLocationDisplay()
        {
            locationDisplayBox.Items.Clear();
            foreach (Location loc in locations)
            {
                locationDisplayBox.Items.Add(loc.Title);
            }
        }

        private void RemoveLocationAt(int i)
        {
            locations.RemoveAt(i);
        }

        private void SetLocationAt(int i)
        {
            locations[i].Title = txtbxLocName.Text;
            locations[i].Description = txtbxLocDescription.Text;
            RefreshLocationDisplay();
        }

        private void locationDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEditArea(locationDisplayBox.SelectedIndex);
        }

        private void UpdateEditArea(int i)
        {
            txtbxLocName.Text = locations[i].Title;
            txtbxLocDescription.Text = locations[i].Description;
        }

        private void ClearEditArea()
        {
            txtbxLocName.Text = "";
            txtbxLocDescription.Text = "";
        }

        public void SaveLocations ()
        {
            string locStr = JsonConvert.SerializeObject(locations);
            File.WriteAllText(path, locStr);
        }

        private void LoadLocations()
        {
            string data = File.ReadAllText(path);
            locations = JsonConvert.DeserializeObject<List<Location>>(data);
            if (locations == null) locations = new List<Location>();
            RefreshLocationDisplay();
        }
    }
}
