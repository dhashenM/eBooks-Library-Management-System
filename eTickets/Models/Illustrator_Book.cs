using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Models
{
    public class Illustrator_Book
    {
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int IllustratorId { get; set; }
        public Illustrator Illustrator { get; set; }
    }
}
