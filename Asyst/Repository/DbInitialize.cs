using Asyst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asyst.Repository
{
    public class DbInitialize
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Persons.Any())
            {
                return;
            }

            context.Persons.Add(new Person { Name = "John Doe", Email = "john@example.com" });
            context.Persons.Add(new Person { Name = "Jane Smith", Email = "jane@example.com" });
            context.Persons.Add(new Person { Name = "Bob Johnson", Email = "bob@example.com" });

            // Save changes to the database
            context.SaveChanges();
        }
    }
}
