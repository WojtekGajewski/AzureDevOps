using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11TaskLibrary
{
    internal class Signature
    {
        public int Number { get; set; }
        public string Comments { get; set; }
        public DateTime PurchaseDate { get; set; }

        public List<Borrowing> BorrowingList { get; set; }

        public bool IsActive { get; set; }
    }
}
