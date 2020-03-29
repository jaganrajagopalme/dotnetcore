using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webappsdemo.Models
{
    public class Appcontext:DbContext
     {

        public Appcontext(DbContextOptions<Appcontext> options): base(options)
        {

        }

        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(new Products { ProductId = 34, ProductName = "TV", Department = Dept.HR, CatelogType = "Ele" });
        }

    }
}
