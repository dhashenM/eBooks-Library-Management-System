using eBooks.Data.Base;
using eBooks.Data.ViewModels;
using eBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data.Services
{
    public interface IBooksService:IEntityBaseRepository<Book>
    {
        Task<Book> GetBookByIdAsync(int id);
        Task<NewBookDropdownsVM> GetNewBookDropdownsValues();
        Task AddNewBookAsync(NewBookVM data);
        Task UpdateBookAsync(NewBookVM data);
    }
}
