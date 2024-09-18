using eBooks.Data.Base;
using eBooks.Data.ViewModels;
using eBooks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data.Services
{
    public class BooksService : EntityBaseRepository<Book>, IBooksService
    {
        private readonly AppDbContext _context;
        public BooksService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewBookAsync(NewBookVM data)
        {
            var newBook = new Book()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                PublisherId = data.PublisherId,
                PublicationDate = data.PublicationDate,
                BookCategory = data.BookCategory,
                AuthorId = data.AuthorId
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            //Add Book Illustrators
            foreach (var illustratorId in data.IllustratorIds)
            {
                var newIllustratorBook = new Illustrator_Book()
                {
                    BookId = newBook.Id,
                    IllustratorId = illustratorId
                };
                await _context.Illustrators_Books.AddAsync(newIllustratorBook);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            var bookDetails = await _context.Books
                .Include(p => p.Publisher)
                .Include(a => a.Author)
                .Include(am => am.Illustrators_Books).ThenInclude(a => a.Illustrator)
                .FirstOrDefaultAsync(n => n.Id == id);

            return bookDetails;
        }

        public async Task<NewBookDropdownsVM> GetNewBookDropdownsValues()
        {
            var response = new NewBookDropdownsVM()
            {
                Illustrators = await _context.Illustrators.OrderBy(n => n.FullName).ToListAsync(),
                Publishers = await _context.Publishers.OrderBy(n => n.Name).ToListAsync(),
                Authors = await _context.Authors.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }

        public async Task UpdateBookAsync(NewBookVM data)
        {
            var dbBook = await _context.Books.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbBook != null)
            {
                dbBook.Name = data.Name;
                dbBook.Description = data.Description;
                dbBook.Price = data.Price;
                dbBook.ImageURL = data.ImageURL;
                dbBook.PublisherId = data.PublisherId;
                dbBook.PublicationDate = data.PublicationDate;
                dbBook.BookCategory = data.BookCategory;
                dbBook.AuthorId = data.AuthorId;
                await _context.SaveChangesAsync();
            }

            //Remove existing illustrators
            var existingIllustratorsDb = _context.Illustrators_Books.Where(n => n.BookId == data.Id).ToList();
            _context.Illustrators_Books.RemoveRange(existingIllustratorsDb);
            await _context.SaveChangesAsync();

            //Add Book Illustrators
            foreach (var illustratorId in data.IllustratorIds)
            {
                var newIllustratorBook = new Illustrator_Book()
                {
                    BookId = data.Id,
                    IllustratorId = illustratorId
                };
                await _context.Illustrators_Books.AddAsync(newIllustratorBook);
            }
            await _context.SaveChangesAsync();
        }
    }
}
