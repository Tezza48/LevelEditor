using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
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
            // default valuse to use before the user loads their saved story (or for a new story)
            gameData.startText = "Start Text";
            gameData.locations = new BindingList<Location>();
            gameData.locations.Add(new Location());
            gameData.playerInventory = new BindingList<Item>();

            txtbxStartText.Text = gameData.startText;
        }

        private void btnEditLocations_Click(object sender, EventArgs e)
        {
            // launch the location editor window
            LocationEditor locEditWindow = new LocationEditor(ref gameData.locations);
            locEditWindow.Show();
        }

        private void txtbxStartText_TextChanged(object sender, EventArgs e)
        {
            // this textbox automatically updates the gamedata when you change it
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
            string data = JsonConvert.SerializeObject(gameData, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto// automatically save the type  of the object if it's different to the list's type (for keys)
            });
            File.WriteAllText("data.json", data);
        }

        private void LoadGameData()
        {
            // load the data file
            try// the file might not exist yes to i use a try here
            {
                string data = File.ReadAllText("data.json");

                gameData = JsonConvert.DeserializeObject<SaveData>(data);

                if (gameData.playerInventory == null)
                    gameData.playerInventory = new BindingList<Item>();

                txtbxStartText.Text = gameData.startText;
            }
            catch
            {
                MessageBox.Show("You need to save a story before you can load one.\n(there needs to be a file called \"data.json\" in the root dir.");
            }
        }

        private void SaveBasicLevelStuff()
        {
            // this was how i designed the new story data structure and gave me things i coud edit
            // without having to have made the editor yet. saved a lot of headaches
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
            SaveGameData();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // prompt the user to save before quitting
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

        private void btnEditExits_Click(object sender, EventArgs e)
        {
            // open the exit editor
            ExitEditor exitEditor = new ExitEditor(ref gameData.locations);
            exitEditor.Show();
        }

        private void btnEditPlayer_Click(object sender, EventArgs e)
        {
            // open the player editor
            PlayerEditor playerEditor = new PlayerEditor(ref gameData.playerInventory);
            playerEditor.Show();
        }
    }
}
