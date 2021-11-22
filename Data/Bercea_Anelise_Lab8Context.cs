using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bercea_Anelise_Lab8.Models;

namespace Bercea_Anelise_Lab8.Data
{
    public class Bercea_Anelise_Lab8Context : DbContext
    {
        public Bercea_Anelise_Lab8Context (DbContextOptions<Bercea_Anelise_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Bercea_Anelise_Lab8.Models.Publisher> Publisher { get; set; }
        public DbSet<Bercea_Anelise_Lab8.Models.Book> Book { get; set; }
        public DbSet<Bercea_Anelise_Lab8.Models.Category> Category { get; set; }
    }
}
