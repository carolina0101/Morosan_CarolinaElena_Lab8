using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Morosan_CarolinaElena_Lab8.Models;

namespace Morosan_CarolinaElena_Lab8.Data
{
    public class Morosan_CarolinaElena_Lab8Context : DbContext
    {
        public Morosan_CarolinaElena_Lab8Context (DbContextOptions<Morosan_CarolinaElena_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Morosan_CarolinaElena_Lab8.Models.Book> Book { get; set; }
    }
}
