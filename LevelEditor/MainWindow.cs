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

        private List<Location> locations;

        public MainWindow()
        {
            InitializeComponent();
            SaveBasicLevelStuff();
            //LoadGameData();
        }

        private void SaveBasicLevelStuff()
        {

            locations = new List<Location>();

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

            string data = JsonConvert.SerializeObject(gameData);
            File.WriteAllText("data.json", data);
        }

        private void LoadGameData()
        {
            string data = File.ReadAllText("data.json");
            gameData = (SaveData)JsonConvert.DeserializeObject(data);
            locations = gameData.locations;
        }
    }
}
