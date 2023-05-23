using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashno_oop
{
    class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Goal[] Goals { get; set; }
        public string Outcome { get; set; }

        public void DetermineWinner()
        {
            int team1Goals = Goals.Count(goal => goal.Player.Team == Team1);
            int team2Goals = Goals.Count(goal => goal.Player.Team == Team2);

            if (team1Goals > team2Goals)
            {
                Outcome = $"The team coached by {Team1.Coach.Name} wins!";
            }
            else if (team1Goals < team2Goals)
            {
                Outcome = $"The team coached by {Team2.Coach.Name} wins!";
            }
            else
            {
                Outcome = "It's a draw!";
            }
        }
    }
}
