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
    public class PublishersController : Controller
    {
        //declaring the IPublishersService
        private readonly IPublishersService _service;

        //injecting the IPublishersService into the Constructor so that it can be used
        public PublishersController(IPublishersService service)
        {
            //Assigning the parameter to the data member
            _service = service;
        }

        //using Asynchronous methods to get the data from the database
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            //getting the data to return the publishers in this controller
            var allPublishers = await _service.GetAllAsync();
            //Passing the publishers data from the controller to the view
            return View(allPublishers);
        }


        //Creating a new Publisher
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo,Name,Description")]Publisher publisher)
        {
            if (!ModelState.IsValid) return View(publisher);
            await _service.AddAsync(publisher);
            return RedirectToAction(nameof(Index));
        }

        //Getting a Publishers details
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }

        //Editing a Publishers details
        public async Task<IActionResult> Edit(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Logo,Name,Description")] Publisher publisher)
        {
            if (!ModelState.IsValid) return View(publisher);
            await _service.UpdateAsync(id, publisher);
            return RedirectToAction(nameof(Index));
        }

        //Deleting a Publisher
        public async Task<IActionResult> Delete(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");
            return View(publisherDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);
            if (publisherDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
