using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContactBook.Models
{
    public class ContactBookContext : DbContext
    {
        public ContactBookContext (DbContextOptions<ContactBookContext> options)
            : base(options)
        {
        }
        public DbSet<ContactBook.User> User { get; set; }
        public DbSet<ContactBook.Models.Contact> Contact { get; set; }
    }
}
