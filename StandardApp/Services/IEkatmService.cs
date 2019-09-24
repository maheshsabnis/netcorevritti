using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardApp.Services
{
    /// <summary>
    /// TEntity is Entity Class on which CRUD Operations are performed
    /// TPk is input type primary ket
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    public interface IEkatmService<TEntity, in TPk> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync(); // all records
        Task<TEntity> GetAsync(TPk id); // single record based on P.K.
        Task<TEntity> CreateAsync(TEntity entity); // create new record
        Task<bool> UpdateAsync(TPk id, TEntity entity); // update
        Task<bool> DeleteAsync(TPk id); // delete
    }
}
