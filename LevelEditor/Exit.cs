using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelEditor
{
    public class Exit
    {
        public enum Directions
        {
            UNDEFINED, North, South, East, West, Up, Down, NorthEast, NorthWest, SouthEast, SouthWest, In, Out
        };

        [JsonRequired]
        private int leadsTo;
        [JsonRequired]
        private Directions direction;
        private Key key;

<<<<<<< HEAD
        public Directions Direction
        {
            get
            {
                return direction;
            }
        }

        public int LeadsTo
        {
            set
            {
                leadsTo = value;
            }
        }

        public Exit(Directions _direction, int newLeadsTo, Key _key = null)
=======
        [JsonProperty]
        public Key Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
        }

        public Exit(Directions _direction, int _leadsTo, Key _key = null)
>>>>>>> SeparatingFuncions
        {
            direction = _direction;
            leadsTo = _leadsTo;
            key = _key;
        }
    }
}
