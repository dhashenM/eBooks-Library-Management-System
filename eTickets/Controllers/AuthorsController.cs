using eBooks.Data;
using eBooks.Data.Services;
using eBooks.Data.Static;
using eBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class AuthorsController : Controller
    {
        //declaring the IAuthorsService
        private readonly IAuthorsService _service;

        //injecting the IAuthorsService into the Constructor so that it can be used
        public AuthorsController(IAuthorsService service)
        {
            //Assigning the parameter to the data member
            _service = service;
        }

        //using Asynchronous methods to get the data from the database
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            //getting the data to return the authors in this controller
            var allAuthors = await _service.GetAllAsync();
            //Passing the authors data from the controller to the view
            return View(allAuthors);
        }

        //Getting the Author's details 
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            //checking to see if an author with that id is already in the database
            var authorDetails = await _service.GetByIdAsync(id);
            //checking to see if the author details are null
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        //Creating a new author
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")]Author author)
        {
            //checking/validating to see if the entered input matches with the required criteria
            if (!ModelState.IsValid) return View(author);
            //method to add authors
            await _service.AddAsync(author);
            //method to return the author view
            return RedirectToAction(nameof(Index));
        }

        //Editing an author
        public async Task<IActionResult> Edit(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfilePictureURL,FullName,Bio")] Author author)
        {
            if (!ModelState.IsValid) return View(author);

            if(id == author.Id)
            {
                await _service.UpdateAsync(id, author);
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        //Deleting an author
        public async Task<IActionResult> Delete(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");
            return View(authorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var authorDetails = await _service.GetByIdAsync(id);
            if (authorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
