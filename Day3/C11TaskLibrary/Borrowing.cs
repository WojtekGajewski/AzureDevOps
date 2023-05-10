using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11TaskLibrary
{
    // domain classes 
    internal class Borrowing
    {
        public Signature BookSignature { get; set; }
        public Reader BorrowingReader { get; set; }

        public DateTime BorrowingDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }

        public DateTime ActualReturnDate { get; set; }

        public string Notes { get; set; }
    }
}
