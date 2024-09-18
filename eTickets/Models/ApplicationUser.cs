using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Models
{
    //IdentityUser is the ASP.NET Core MVC class that contains information about users registered in your application.
    //This class inherits the IdentityUser class
    public class ApplicationUser:IdentityUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
