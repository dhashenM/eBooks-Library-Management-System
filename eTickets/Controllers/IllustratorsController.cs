using eBooks.Data;
using eBooks.Data.Services;
using eBooks.Data.Static;
using eBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class IllustratorsController : Controller
    {
        //declaring the IIllustratorsService
        private readonly IIllustratorsService _service;

        //injecting the IIllustratorsService into the Constructor so that it can be used
        public IllustratorsController(IIllustratorsService service)
        {
            //Assigning the parameter to the data member
            _service = service;
        }

        [AllowAnonymous]
        //using Asynchronous methods to get the data from the database
        public async Task<IActionResult> Index()
        {
            //getting the data to return the illustrators in this controller
            var data = await _service.GetAllAsync();
            //Passing the illustrators data from the controller to the view
            return View(data);
        }

        //Creating a new Illustrator
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Illustrator illustrator)
        {
            if (!ModelState.IsValid)
            {
                return View(illustrator);
            }
            await _service.AddAsync(illustrator);
            return RedirectToAction(nameof(Index));
        }

        //Getting the Illustrator's details 
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var illustratorDetails = await _service.GetByIdAsync(id);

            if (illustratorDetails == null) return View("NotFound");
            return View(illustratorDetails);
        }

        //Editing an Illustrator's details 
        public async Task<IActionResult> Edit(int id)
        {
            var illustratorDetails = await _service.GetByIdAsync(id);
            if (illustratorDetails == null) return View("NotFound");
            return View(illustratorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Illustrator illustrator)
        {
            if (!ModelState.IsValid)
            {
                return View(illustrator);
            }
            await _service.UpdateAsync(id, illustrator);
            return RedirectToAction(nameof(Index));
        }

        //Deleting an Illustrator 
        public async Task<IActionResult> Delete(int id)
        {
            var illustratorDetails = await _service.GetByIdAsync(id);
            if (illustratorDetails == null) return View("NotFound");
            return View(illustratorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var illustratorDetails = await _service.GetByIdAsync(id);
            if (illustratorDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
