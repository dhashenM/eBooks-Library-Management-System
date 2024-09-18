using eBooks.Data.Base;
using eBooks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data.Services
{
    public class IllustratorsService : EntityBaseRepository<Illustrator>, IIllustratorsService
    {
        public IllustratorsService(AppDbContext context) : base(context) { }
    }
}
