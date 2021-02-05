using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vidly.Models
{


    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }


    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MembershipType Membership { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}