using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace xamarintraining.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<User>> GetDataAsync(string searchCriteria);
    }
}