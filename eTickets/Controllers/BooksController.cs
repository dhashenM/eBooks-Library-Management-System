using eBooks.Data;
using eBooks.Data.Services;
using eBooks.Data.Static;
using eBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class BooksController : Controller
    {
        //declaring the IBooksService
        private readonly IBooksService _service;

        //injecting the IBooksService into the Constructor so that it can be used
        public BooksController(IBooksService service)
        {
            //Assigning the parameter to the data member
            _service = service;
        }

        [AllowAnonymous]
        //using Asynchronous methods to get the data from the database
        public async Task<IActionResult> Index()
        {
            //getting the data to return the books in this controller
            //including Author information for each book
            //organizing the books in ascending order
            var allBooks = await _service.GetAllAsync(n => n.Author);
            //Passing the books data from the controller to the view
            return View(allBooks);
        }

        [AllowAnonymous]
        //Finding/Searching for a book
        public async Task<IActionResult> Filter(string searchString)
        {
            var allBooks = await _service.GetAllAsync(n => n.Author);
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    //var filteredResult = allBooks.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                    var filteredResultNew = allBooks.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                    return View("Index", filteredResultNew);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured while searching for the specified book");
            }
            

            return View("Index", allBooks);
        }

        //Getting the Books's details
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var bookDetail = await _service.GetBookByIdAsync(id);
            return View(bookDetail);
        }

        //Creating a Book
        public async Task<IActionResult> Create()
        {
            try
            {
                var bookDropdownsData = await _service.GetNewBookDropdownsValues();

                ViewBag.Publishers = new SelectList(bookDropdownsData.Publishers, "Id", "Name");
                ViewBag.Authors = new SelectList(bookDropdownsData.Authors, "Id", "FullName");
                ViewBag.Illustrators = new SelectList(bookDropdownsData.Illustrators, "Id", "FullName");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured while creating book");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewBookVM book)
        {
            if (!ModelState.IsValid)
            {
                var bookDropdownsData = await _service.GetNewBookDropdownsValues();

                ViewBag.Publishers = new SelectList(bookDropdownsData.Publishers, "Id", "Name");
                ViewBag.Authors = new SelectList(bookDropdownsData.Authors, "Id", "FullName");
                ViewBag.Illustrators = new SelectList(bookDropdownsData.Illustrators, "Id", "FullName");

                return View(book);
            }

            await _service.AddNewBookAsync(book);
            return RedirectToAction(nameof(Index));
        }


        //Editing a Book
        public async Task<IActionResult> Edit(int id)
        {

            var bookDetails = await _service.GetBookByIdAsync(id);
            if (bookDetails == null) return View("NotFound");

            var response = new NewBookVM()
            {
                Id = bookDetails.Id,
                Name = bookDetails.Name,
                Description = bookDetails.Description,
                Price = bookDetails.Price,
                PublicationDate = bookDetails.PublicationDate,
                ImageURL = bookDetails.ImageURL,
                BookCategory = bookDetails.BookCategory,
                PublisherId = bookDetails.PublisherId,
                AuthorId = bookDetails.AuthorId,
                IllustratorIds = bookDetails.Illustrators_Books.Select(n => n.IllustratorId).ToList(),
            };

            var bookDropdownsData = await _service.GetNewBookDropdownsValues();
            ViewBag.Publishers = new SelectList(bookDropdownsData.Publishers, "Id", "Name");
            ViewBag.Authors = new SelectList(bookDropdownsData.Authors, "Id", "FullName");
            ViewBag.Illustrators = new SelectList(bookDropdownsData.Illustrators, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewBookVM book)
        {
            if (id != book.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var bookDropdownsData = await _service.GetNewBookDropdownsValues();

                ViewBag.Publishers = new SelectList(bookDropdownsData.Publishers, "Id", "Name");
                ViewBag.Authors = new SelectList(bookDropdownsData.Authors, "Id", "FullName");
                ViewBag.Illustrators = new SelectList(bookDropdownsData.Illustrators, "Id", "FullName");

                return View(book);
            }

            await _service.UpdateBookAsync(book);
            return RedirectToAction(nameof(Index));
        }
    }
}