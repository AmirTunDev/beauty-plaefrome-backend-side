using beauty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Data;
using Microsoft.EntityFrameworkCore;

namespace beauty.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly beautyContext _beautyContext;
        public ServiceRepository(beautyContext beautyContext)
        {
            _beautyContext = beautyContext;
        }
        public void Delete(int id)
        {
          Service service = _beautyContext.Service.Find(id);

            service.Active = true;
        }

        public IEnumerable<Service> GetAllServices()
        {
            return _beautyContext.Service.ToList();
        }

        public Service GetServiceById(int id)
        {
            return _beautyContext.Service.Find(id);
        }

        public void Insert(Service service)
        {
            _beautyContext.Service.Add(service);
        }

        public void Update(Service service)
        {
            _beautyContext.Entry(service).State = EntityState.Modified;
        }
    }
}
