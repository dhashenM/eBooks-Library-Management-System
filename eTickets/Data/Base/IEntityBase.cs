using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBooks.Data.Base
{
    //Defining the common id property
    //All the entities in the app need to inherit from this IEntityBase
    public interface IEntityBase
    {
        int Id { get; set; }
    }
}
