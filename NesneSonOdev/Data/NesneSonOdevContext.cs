using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NesneSonOdev.Models;

namespace NesneSonOdev.Data
{
    public class NesneSonOdevContext : DbContext
    {
        public NesneSonOdevContext (DbContextOptions<NesneSonOdevContext> options)
            : base(options)
        {
        }

        public DbSet<NesneSonOdev.Models.Customer> Customer { get; set; } = default!;
        public DbSet<NesneSonOdev.Models.Order> Order { get; set; } = default!;
        public DbSet<NesneSonOdev.Models.Product> Product { get; set; } = default!;
    }
}
