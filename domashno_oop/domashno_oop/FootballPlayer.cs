using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashno_oop
{
    public class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }
        public Team Team { get; set; }
    }
}
