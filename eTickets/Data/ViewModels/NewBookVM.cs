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
    public class NewBookVM
    {
        public int Id { get; set; }

        [Display(Name = "Book name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Book description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Book poster URL")]
        [Required(ErrorMessage = "Book poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Book publication date")]
        [Required(ErrorMessage = "Publication date is required")]
        public DateTime PublicationDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Book category is required")]
        public BookCategory BookCategory { get; set; }

        //Relationships
        [Display(Name = "Select illustrator(s)")]
        [Required(ErrorMessage = "Book illustrator(s) is required")]
        public List<int> IllustratorIds { get; set; }

        [Display(Name = "Select a publisher")]
        [Required(ErrorMessage = "Book publisher is required")]
        public int PublisherId { get; set; }

        [Display(Name = "Select a author")]
        [Required(ErrorMessage = "Book author is required")]
        public int AuthorId { get; set; }
    }
}
