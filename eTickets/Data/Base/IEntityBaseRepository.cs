using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace eBooks.Data.Base
{
    //Generic interface with the parameter T
    //Creating a generic solution to add, update, and delete (this interface defines all these methods) for all the Authors, Books, Illustrators and Publishers
    public interface IEntityBaseRepository<T> where T: class, IEntityBase, new()
    {
        //This method is used to return all the T from the database
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);

        //This method is used to return a single T
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] includeProperties);

        //This method is used to add data to the database. This data will not be returned to the user
        Task AddAsync(T entity);

        //This method is the functionality to update data in the database. This will return the updated version of the T to the user
        Task UpdateAsync(int id, T entity);

        //This method is the delete method that will delete a record. It will not have a return type
        Task DeleteAsync(int id);
    }
}
