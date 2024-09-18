using eBooks.Data.Base;
using eBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data.Services
{
    public class AuthorsService: EntityBaseRepository<Author>, IAuthorsService
    {
        public AuthorsService(AppDbContext context) : base(context)
        {
        }
    }
}
