using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BackEnd;

namespace DatabaseContext
{
    public class FestivalContext : DbContext
    {
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Movie> Movies { get; set; }
       public DbSet<Show> Shows { get; set; }
       public DbSet<Ticket> Tickets { get; set; }

       public FestivalContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DatabaseContext.FestivalContext;Integrated Security=True")
       {

       }

    }
}
