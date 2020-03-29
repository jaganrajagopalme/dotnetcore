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

    }
}
