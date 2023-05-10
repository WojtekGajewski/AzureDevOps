using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12TaskAthletes
{
    internal class Player
    {
        public int PlayerNumber { get; set; }
        public int CoachId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public DateTime BirthDate { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
