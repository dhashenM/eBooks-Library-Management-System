using eBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data.ViewModels
{
    public class NewBookDropdownsVM
    {
        public NewBookDropdownsVM()
        {
            Authors = new List<Author>();
            Publishers = new List<Publisher>();
            Illustrators = new List<Illustrator>();
        }

        public List<Author> Authors { get; set; }
        public List<Publisher> Publishers { get; set; }
        public List<Illustrator> Illustrators { get; set; }
    }
}
