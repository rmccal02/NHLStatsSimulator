using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHLStatsProject
{
    public class Goal
    {
        public int ScoredByPlayer { get; set; } 

        public String ScoredByTeam { get; set; } 

        public int AssistByPlayer { get; set; }

        public int ScoredAgainstGoalie { get; set; } 

        public double AssistX { get; set; }

        public double AssistY { get; set; }

        public double GoalX { get; set; }

        public double GoalY { get; set; }

        public String TimeScored { get; set; }

        public String Period { get; set; }
    }

}
