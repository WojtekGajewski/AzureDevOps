using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C12TaskAthletes
{
    internal class PlayerManager
    {
        public Player[] LoadPlayers()
        {
           
            const string path = "http://tomaszles.pl/wp-content/uploads/2023/05/volleyball_players.csv";

            WebClient wc = new WebClient();
            string data = wc.DownloadString(path);

            string[] separator = new string[1] { "\r\n" };
            string[] rows = data.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            List<Player> players = new List<Player>();

            foreach (string row in rows)
            {
                string[] cells = row.Split(';');
                 
                Player player = new Player();

                player.PlayerNumber = Convert.ToInt32(cells[0]);

                if (!string.IsNullOrEmpty(cells[1]))
                    player.CoachId = Convert.ToInt32(cells[1]);
               
                player.FirstName = cells[2];
                player.LastName = cells[3];
                player.Country = cells[4];
                player.BirthDate = Convert.ToDateTime(cells[5]);
                player.Width = Convert.ToInt32(cells[6]);
                player.Height = Convert.ToInt32(cells[7]);

                players.Add(player);
            }
            return players.ToArray();
        }
    }
}
