using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beauty.Data;
using beauty.Models;
using Microsoft.EntityFrameworkCore;

namespace beauty.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly beautyContext _beautyContext;

        public ReservationRepository(beautyContext beautyContext)
        {
            _beautyContext = beautyContext;
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _beautyContext.Reservation.ToList();
        }

        public Reservation GetReservationById(int id)
        {
            return _beautyContext.Reservation.Find(id);
        }

     


        public void Insert(Reservation reservation)
        {
            _beautyContext.Reservation.Add(reservation);
        }

        public void Update(Reservation reservation)
        {
            _beautyContext.Entry(reservation).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
           Reservation reservation= _beautyContext.Reservation.Find(id);

            reservation.Active = true;
        }

        public IEnumerable<Reservation> getAllReservations()
        {
            throw new NotImplementedException();
        }

        public Reservation getReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
