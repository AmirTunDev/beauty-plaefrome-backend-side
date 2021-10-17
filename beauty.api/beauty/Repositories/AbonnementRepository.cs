using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Data;
using beauty.Models;
using Microsoft.EntityFrameworkCore;

namespace beauty.Repositories
{
    public class AbonnementRepository : IAbonnementRepository
    {
        private readonly beautyContext _beautyContext;
        public AbonnementRepository(beautyContext beautyContext)
        {
            _beautyContext = beautyContext;
        }
        public IEnumerable<Abonnement> GetAllAbonnements()
        {
            return _beautyContext.Abonnement.ToList();
        }

        public Abonnement GetAbonnementById(int id)
        {
            return _beautyContext.Abonnement.Find(id);
        }

        public void Insert(Abonnement abonnement)
        {
            _beautyContext.Abonnement.Add(abonnement);
        }

        public void Update(Abonnement abonnement)
        {
            _beautyContext.Entry(abonnement).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Abonnement abonnement = _beautyContext.Abonnement.Find(id);

            abonnement.Active = true;
        }
    }
}
