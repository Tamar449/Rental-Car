using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_WebApi
{
    public interface I_WebApi<T>
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> AddAsync(T item);
        Task<List<T>> UpdateAsync(int id, T item);
        Task<List<T>> DeleteAsync(int id);

    }
}
