using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Models;

namespace beauty.Repositories
{
    public interface IReclamationRepository
    {
        IEnumerable<Reclamation> GetAllReclamations();
        Reclamation GetReclamationById(int id);
        void Insert(Reclamation reclamation);
        void Update(Reclamation reclamation);
        void Delete(int id);
    }
}
