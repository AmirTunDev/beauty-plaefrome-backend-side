using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Models;

namespace beauty.Repositories
{
    interface IServiceRepository
    {
        IEnumerable<Service> GetAllServices();
        Service GetServiceById(int id);
        void Insert(Service service);
        void Update(Service service);
        void Delete(int id);
        
    }
}
