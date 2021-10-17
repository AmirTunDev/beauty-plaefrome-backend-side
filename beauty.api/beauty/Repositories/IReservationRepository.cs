using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Models;

namespace beauty.Repositories
{
    interface IReservationRepository
    {
        IEnumerable<Reservation> GetAllReservations();
        Reservation GetReservationById(int id);
        void Insert(Reservation reservation);
        void Update(Reservation reservation);
        void Delete(int id);
        
    }
}
