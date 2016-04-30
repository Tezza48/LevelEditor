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

        private SaveData gameData;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            gameData.startText = "Start Text";
            gameData.locations = new BindingList<Location>();
            gameData.locations.Add(new Location());

            txtbxStartText.Text = gameData.startText;
        }

        private void btnEditLocations_Click(object sender, EventArgs e)
        {
            LocationEditor locEditWindow = new LocationEditor(ref gameData.locations);
            locEditWindow.ShowDialog();
        }

        private void txtbxStartText_TextChanged(object sender, EventArgs e)
        {
            gameData.startText = txtbxStartText.Text;
        }

        #region Menu Strip
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveGameData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGameData();
        }
        #endregion

        private void SaveGameData()
        {
            string data = JsonConvert.SerializeObject(gameData);
            File.WriteAllText("data.json", data);
        }

        private void LoadGameData()
        {
            string data = File.ReadAllText("data.json");

            gameData = JsonConvert.DeserializeObject<SaveData>(data);

            txtbxStartText.Text = gameData.startText;
        }

        private void SaveBasicLevelStuff()
        {
            gameData.startText = "This is the game's start text.";

            BindingList<Location> locations = new BindingList<Location>();

            #region Make Items
            Item l0_screwdriver = new Item("Screwdriver", "it's a phillips head screwdriver");

            Key l1_Key_steelPipe = new Key("Steel Pipe", "A bent steel pipe, it probably fell from the pipework above.", true);
            #endregion

            #region Make Locations
            locations.Add(new Location("The Car", "It's not going to be moving any time soon."));

            locations.Add(new Location("Alleyway", "A dark alleyway."));

            locations.Add(new Location("Gate", "A Gate wit a rusted Lock."));

            locations.Add(new Location("Empty Street", "A wide Street with barricades at either end."));
            #endregion

            #region Add Items
            locations[0].addItem(l0_screwdriver);

            locations[1].addItem(l1_Key_steelPipe);
            #endregion

            #region Add Exits
            locations[0].addExit(new Exit(Exit.Directions.North, 1));
            locations[1].addExit(new Exit(Exit.Directions.South, 0));

            locations[1].addExit(new Exit(Exit.Directions.North, 2));
            locations[2].addExit(new Exit(Exit.Directions.South, 1));

            locations[2].addExit(new Exit(Exit.Directions.North, 3, l1_Key_steelPipe));
            locations[3].addExit(new Exit(Exit.Directions.South, 2));
            #endregion

            gameData.locations = locations;

            string data = JsonConvert.SerializeObject(gameData, Formatting.Indented, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Include
            });
            File.WriteAllText("data.json", data);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult quitWarningMessage = MessageBox.Show("Do you want to Save first?", "Warning", MessageBoxButtons.YesNoCancel);
            switch (quitWarningMessage)
            {
                case DialogResult.Yes:
                    SaveGameData();
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
    }
}
