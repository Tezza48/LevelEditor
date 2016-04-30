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

<<<<<<< HEAD
        private BindingList<LevelEditor.Location> locations;
        private string path = @"data.json";
=======
        private SaveData gameData;
>>>>>>> SeparatingFuncions

        public MainWindow()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
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
=======
        private void MainWindow_Load(object sender, EventArgs e)
        {
            gameData.startText = "Start Text";
            gameData.locations = new BindingList<Location>();
            gameData.locations.Add(new Location());
            gameData.playerInventory = new BindingList<Item>();
>>>>>>> SeparatingFuncions

            txtbxStartText.Text = gameData.startText;
        }

        private void btnEditLocations_Click(object sender, EventArgs e)
        {
            LocationEditor locEditWindow = new LocationEditor(ref gameData.locations);
            locEditWindow.Show();
        }

<<<<<<< HEAD
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
=======
        private void txtbxStartText_TextChanged(object sender, EventArgs e)
        {
            gameData.startText = txtbxStartText.Text;
        }

        #region Menu Strip
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveGameData();
>>>>>>> SeparatingFuncions
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGameData();
        }
        #endregion

<<<<<<< HEAD
        private void locationDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEditArea(locDisplayBox.SelectedIndex);
=======
        private void SaveGameData()
        {
            string data = JsonConvert.SerializeObject(gameData);
            File.WriteAllText("data.json", data);
>>>>>>> SeparatingFuncions
        }

        private void LoadGameData()
        {
<<<<<<< HEAD
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
=======
            string data = File.ReadAllText("data.json");

            gameData = JsonConvert.DeserializeObject<SaveData>(data);

            if (gameData.playerInventory == null)
                gameData.playerInventory = new BindingList<Item>();

            txtbxStartText.Text = gameData.startText;
        }

        private void SaveBasicLevelStuff()
        {
            gameData.startText = "This is the game's start text.";

            BindingList<Location> locations = new BindingList<Location>();
>>>>>>> SeparatingFuncions

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

<<<<<<< HEAD
        private void SaveLocations ()
=======
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
>>>>>>> SeparatingFuncions
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

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            PlayerEditor playerEditor = new PlayerEditor(ref gameData.playerInventory);
            playerEditor.Show();
>>>>>>> SeparatingFuncions
        }
    }
}
