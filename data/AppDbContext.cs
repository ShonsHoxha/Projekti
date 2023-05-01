using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PetagogetdheDepartamenti.data.Models;

namespace PetagogetdheDepartamenti.data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Petagog> Petagoget { get; set; }
        public DbSet<Departament> Departamentet { get; set; }
    }
}
