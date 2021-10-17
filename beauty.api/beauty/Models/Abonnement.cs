using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace beauty.Models
{
    public class Abonnement
    {
        
        [Key]
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public User user { get; set; }
        public bool Active { get; set; }
    }
}
