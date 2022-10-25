using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Balaie_Cristian_Lab2.Models;

namespace Balaie_Cristian_Lab2.Data
{
    public class Balaie_Cristian_Lab2Context : DbContext
    {
        public Balaie_Cristian_Lab2Context (DbContextOptions<Balaie_Cristian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Balaie_Cristian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Balaie_Cristian_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Balaie_Cristian_Lab2.Models.Author> Author { get; set; }
    }
}
