using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revolution.Database.DAO.Repository.Interface
{
    interface IRepository<T>
    {
        /* All the Sql method are processed by async, to make it faster, cheers for Matty introducing this to me in .NET 4.5 */

        void SaveOrUpdate(T item);

        void Delete(T item);
    }
}
