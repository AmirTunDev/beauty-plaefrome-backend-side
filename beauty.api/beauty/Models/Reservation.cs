using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace beauty.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public bool Active { get; set; }
        public DateTime Datedereservation { get; set; }
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
        public DateTime dateDeleted { get; set; }


    }
}
