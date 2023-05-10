using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11TaskLibrary
{
    internal class BookCard
    {
        public int Edition { get; set; }
        public DateTime PurchaseDate { get; set; }

        public BookPrice Price { get; set; }

        public string Title { get; set; }

        public List<Author> AuthorList { get; set; }

        public List<Signature> SignaturesList { get; set; }

        public BookCard PereviousBookCard { get; set; }

        public BookCard NextBookCard { get; set; }


    }
}
