using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using beauty.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace beauty.Data
{
    public class beautyContext : IdentityDbContext<User>
    {
        public beautyContext (DbContextOptions<beautyContext> options)
            : base(options)
        {
        }

        public DbSet<beauty.Models.User> User { get; set; }

        public DbSet<beauty.Models.Abonnement> Abonnement { get; set; }
        public DbSet<beauty.Models.Service>Service { get; set; }
        public DbSet<beauty.Models.Reservation> Reservation { get; set; }
        public DbSet<beauty.Models.Reclamation> Reclamation { get; set; }
        public DbSet<beauty.Models.Note> Note { get; set; }
        public DbSet<beauty.Models.Notification> Notification { get; set; }
        

    }
}
