using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashno_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer[] players = new FootballPlayer[]
            {
            new FootballPlayer { Name = "Viktor", Age = 25, Number = 1, Height = 1.8 },
            new FootballPlayer { Name = "Pesho", Age = 18, Number = 1, Height = 1.5 }
                    };

            Team[] teams = new Team[]
            {
            new Team
            {
                Coach = new Coach { Name = "Bastin", Age = 50 },
                Players = new FootballPlayer[] { players[0], players[0], players[0], players[0], players[0], players[0], players[0], players[0], players[0], players[0], players[0], players[0], }
            },
            new Team
            {
                Coach = new Coach { Name = "Pergo", Age = 60 },
                Players = new FootballPlayer[] { players[1], players[1], players[1], players[1], players[1], players[1], players[1], players[1], players[1], players[1], players[1], players[1] }
            }
            };

            // Assign teams to players
            foreach (var player in players)
            {
                player.Team = teams.FirstOrDefault(team => team.Players.Contains(player));
            }

            // Create game
            Game game = new Game
            {
                Team1 = teams[0],
                Team2 = teams[1],
                Referee = new Referee { Name = "Referee", Age = 35 },
                Goals = new Goal[]
                {
                new Goal { Minet = 10, Player = players[0] },
                new Goal { Minet = 20, Player = players[1] },
                new Goal { Minet = 20, Player = players[1] }
                }
            };
            foreach (var team in teams)
            {
                Console.WriteLine($"Team: {team.Coach.Name}'s team");
                Console.WriteLine("Players:");
                foreach (var player in team.Players)
                {
                    Console.WriteLine($"{player.Name} (Number: {player.Number})");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Goals:");
            foreach (var goal in game.Goals)
            {
                Console.WriteLine($"Minute: {goal.Minet} - Player: {goal.Player.Name} (Team: {goal.Player.Team.Coach.Name}'s team)");
            }
            // Determine the winner
            game.DetermineWinner();

            // Print game outcome
            Console.WriteLine(game.Outcome);
            Console.ReadKey();
        }
    }
}
