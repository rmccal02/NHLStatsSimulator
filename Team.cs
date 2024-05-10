using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLStatsProject
{
    public class Team
    {
        public string TeamName { get; set; }
        public List<Player> Players { get; } = new List<Player>();

        // Additional attributes and methods specific to the Team class can be added here
    }

}
