using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firestore
{
    public interface InterfaceCrud<T> where T : class
    {
        Task Create(T entity, string id);
        Task Update(T entity, string id);
        Task Delete(string id);
        Task<T> GetById(string id);
        Task<List<T>> GetAll();
        Task<bool> IFieldExists(string field, string value);
        Task<T> GetUserByField(string field, string value);
    }
}