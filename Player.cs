using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLStatsProject
{
    public class Player
    {
        public string Name { get; set; }
        public int JerseyNumber { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"{Name} - Jersey: {JerseyNumber}, Position: {Position}";
        }

        // Additional attributes and methods specific to the Player class can be added here
    }

}
