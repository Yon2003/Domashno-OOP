using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashno_oop
{
    public class Team
    {
        public Coach Coach { get; set; }
        public FootballPlayer[] Players { get; set; }

        public double CalculateAverageAge()
        {
            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }
            return (double)totalAge / Players.Length;
        }
    }
}
