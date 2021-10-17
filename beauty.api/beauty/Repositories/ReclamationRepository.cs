using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Data;
using beauty.Models;
using Microsoft.EntityFrameworkCore;

namespace beauty.Repositories
{
    public class ReclamationRepository : IReclamationRepository
    {
        private readonly beautyContext _beautyContext;
        public ReclamationRepository(beautyContext beautyContext)
        {
            _beautyContext = beautyContext;
        }
        public IEnumerable<Reclamation> GetAllReclamations()
        {
            return _beautyContext.Reclamation.ToList();
        }

        public Reclamation GetReclamationById(int id)
        {
            return _beautyContext.Reclamation.Find(id);
        }

        public void Insert(Reclamation reclamation)
        {
            _beautyContext.Reclamation.Add(reclamation);
        }

        public void Update(Reclamation reclamation)
        {
            _beautyContext.Entry(reclamation).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Reclamation reclamation = _beautyContext.Reclamation.Find(id);

            reclamation.Active = true;
        }
    }
}
