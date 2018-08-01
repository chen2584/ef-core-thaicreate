using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TestEntityFramework
{
    public class TestDbContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Audit> Audit { get; set; }
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        { }
    }

    public class Customer
    {
        [Key]
        public string Customer_Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Country_Code { get; set; }
        public float Budget { get; set; }
        public float Used { get; set; }
        [ForeignKey("Country_Code")]
        public Country Country { get; set; }
    }

    public class Country
    {
        [Key]
        public string Country_Code { get; set; }
        public string Country_Name { get; set; }
    }

    public class Audit
    {
        [Key]
        public int Audit_Id { get; set; }
        public string Customer_Id { get; set; }
        public DateTime Log_Date { get; set; }
        public float Used { get; set; }
        [ForeignKey("Customer_Id")]
        public Customer Customer { get; set; }
    }


}