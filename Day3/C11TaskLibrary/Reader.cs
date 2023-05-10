using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11TaskLibrary
{
    internal class Reader
    {
        public int CardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Borrowing> Borrowings { get; set; }
    }
}
