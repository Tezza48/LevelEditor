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

        private Dictionary<string, Location> locations = new Dictionary<string, Location>();

        //locations.Add("l1a1", new Location("The Car", "You are at the end of a long alleyway, behind the car is a sheer drop, best not go that way."));
        //    locations.Add("l2a1", new Location("Basement", "A totally dank basement."));

        //    locations["l1a1"].addExit(new Exit(Exit.Directions.Down, "l1a2"));
        //    locations["l2a1"].addExit(new Exit(Exit.Directions.Up, "l1a1"));

        //    locations["l2a1"].addItem(new Item("A fuck off massive dildo!", "you really need a description?"));



        public MainWindow()
        {
            InitializeComponent();
        }

        public void SaveLocations ()
        {
            string locStr = JsonConvert.SerializeObject(locations);
            File.WriteAllText("data.json", locStr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            locations.Add(locationKeyBox.Text, new Location(locationNameBox.Text, locationDisplayBox.Text));
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLocations();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void breakLocationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
