using eBooks.Data;
using eBooks.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Models
{
    public class Book:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime PublicationDate { get; set; }
        public BookCategory BookCategory { get; set; }

        //Relationships
        public List<Illustrator_Book> Illustrators_Books { get; set; }

        //Publisher
        public int PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }

        //Author
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
    }
}
