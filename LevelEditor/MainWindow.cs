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

        private static List<LevelEditor.Location> locations;

        public MainWindow()
        {
            InitializeComponent();

            if (locations == null) locations = new List<LevelEditor.Location>();
            locations.Add(new LevelEditor.Location());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string data = File.ReadAllText("data.json");
            locations = JsonConvert.DeserializeObject<List<Location>>(data);
        }

        public void SaveLocations ()
        {
            string locStr = JsonConvert.SerializeObject(locations);
            File.WriteAllText("data.json", locStr);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLocations();
        }

        private void refreshLocationDisplay_Click(object sender, EventArgs e)
        {
            locationDisplayBox.Items.Clear();
            foreach (Location loc in locations)
            {
                locationDisplayBox.Items.Add(loc.Title);
            }
        }

        private void btnSaveLoc_Click(object sender, EventArgs e)
        {

        }

        private void btnNewLoc_Click(object sender, EventArgs e)
        {
            locations.Add(new LevelEditor.Location());
        }
    }
}
