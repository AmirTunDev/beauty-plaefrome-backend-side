using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Models;

namespace beauty.Repositories
{
    public interface IAbonnementRepository
    {
        IEnumerable<Abonnement> GetAllAbonnements();
        Abonnement GetAbonnementById(int id);
        void Insert(Abonnement abonnement);
        void Update(Abonnement abonnement);
        void Delete(int id);
    }
}
