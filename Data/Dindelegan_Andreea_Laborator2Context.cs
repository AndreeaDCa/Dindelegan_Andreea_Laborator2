using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dindelegan_Andreea_Laborator2.Models;

namespace Dindelegan_Andreea_Laborator2.Data
{
    public class Dindelegan_Andreea_Laborator2Context : DbContext
    {
        public Dindelegan_Andreea_Laborator2Context (DbContextOptions<Dindelegan_Andreea_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Dindelegan_Andreea_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dindelegan_Andreea_Laborator2.Models.Publisher>? Publisher { get; set; }
    }
}
