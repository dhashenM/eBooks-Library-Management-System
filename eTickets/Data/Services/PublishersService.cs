using eBooks.Data.Base;
using eBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data.Services
{
    public class PublishersService:EntityBaseRepository<Publisher>, IPublishersService
    {
        public PublishersService(AppDbContext context) : base(context)
        {
        }
    }
}
