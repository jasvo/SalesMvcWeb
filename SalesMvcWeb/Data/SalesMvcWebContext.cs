using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMvcWeb.Models;

namespace SalesMvcWeb.Data
{
    public class SalesMvcWebContext : DbContext
    {
        public SalesMvcWebContext (DbContextOptions<SalesMvcWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
