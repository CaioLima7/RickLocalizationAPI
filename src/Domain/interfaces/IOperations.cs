using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IOperations
    {
        int Register(NavigationEntity navigation);
        bool Delete();
        Task<int> RegisterAsync(NavigationEntity navigation);
        Task<bool> DeleteAsync();
    }
}
