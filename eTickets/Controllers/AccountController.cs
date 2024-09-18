using AspNetCore.Reporting;
using eBooks.Data;
using eBooks.Data.Static;
using eBooks.Data.ViewModels;
using eBooks.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnv;

        public UserDetailsService userDetailsService = new UserDetailsService();

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context, IWebHostEnvironment webHostEnv)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _webHostEnv = webHostEnv;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }


        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }


        public IActionResult Login() => View(new LoginVM());

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if(user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Books");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(loginVM);
            }

            TempData["Error"] = "Wrong credentials. Please, try again!";
            return View(loginVM);
        }


        public IActionResult Register() => View(new RegisterVM());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
            if(user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerVM);
            }

            var newUser = new ApplicationUser()
            {
                FullName = registerVM.FullName,
                Email = registerVM.EmailAddress,
                UserName = registerVM.EmailAddress
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

            return View("RegisterCompleted");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Books");
        }

        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult DeleteUser()
        {
            return View();
        }
        public ActionResult UserDeleted()
        {
            return View();
        }

        public ActionResult ReportGenerationPage()
        {
            return View();
        }

        public IActionResult UserDetailsReport()
        {
            var dt = new DataTable();
            dt = userDetailsService.GetUserDetails();

            string mimeType = "";
            int extension = 1;
            var path = $"{_webHostEnv.WebRootPath}\\Reports\\rptUserDetails.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("prm1", "RDLC Report");
            parameters.Add("prm2", DateTime.Now.ToString("dd-MM-yyyy"));
            parameters.Add("prm3", "User Details Report");

            LocalReport localReport = new LocalReport(path);
            localReport.AddDataSource("dsUserDetails", dt);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);
            return File(res.MainStream, "application/pdf");

        }
    }
}
