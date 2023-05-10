using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12TaskAthletes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            Player[] players = playerManager.LoadPlayers();

            foreach (Player player in players) 
            {
                Console.WriteLine(player.FullName);
            }

            Console.ReadKey();
        }
    }
}
