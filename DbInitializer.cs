using System;
using System.Linq;

namespace TestEntityFramework.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TestDbContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var countrys = new Country[]
            {
                new Country() { Country_Code = "TH", Country_Name = "Thailand" },
                new Country() { Country_Code = "UK", Country_Name = "United Kingdom" },
                new Country() { Country_Code = "US", Country_Name = "United States" }
            };

            db.Country.AddRange(countrys);
            db.SaveChanges();

            var customers = new Customer[]
            {
                new Customer() { Customer_Id = "C001", Name = "Win Weerachai", Email = "win.weerachai@thaicreate.com", Country_Code = "TH", Budget = 1000000f, Used = 600000f },
                new Customer() { Customer_Id = "C002", Name = "John  Smith", Email = "john.smith@thaicreate.com", Country_Code = "UK", Budget = 2000000f, Used = 800000f },
                new Customer() { Customer_Id = "C003", Name = "Jame Born", Email = "jame.born@thaicreate.com", Country_Code = "US", Budget = 3000000f, Used = 600000f },
                new Customer() { Customer_Id = "C004", Name = "Chalee Angel", Email = "chalee.angel@thaicreate.com", Country_Code = "US", Budget = 4000000f, Used = 100000f },
            };

            db.Customer.AddRange(customers);
            db.SaveChanges();

            var audits = new Audit[]
            {
                new Audit() { Audit_Id = 1, Customer_Id = "C001", Log_Date = Convert.ToDateTime("01-Aug-2015"), Used = 100000f  },
                new Audit() { Audit_Id = 2, Customer_Id = "C001", Log_Date = Convert.ToDateTime("05-Aug-2015"), Used = 200000f  },
                new Audit() { Audit_Id = 3, Customer_Id = "C001", Log_Date = Convert.ToDateTime("10-Aug-2015"), Used = 300000f  },
                new Audit() { Audit_Id = 4, Customer_Id = "C002", Log_Date = Convert.ToDateTime("02-Aug-2015"), Used = 400000f  },
                new Audit() { Audit_Id = 5, Customer_Id = "C002", Log_Date = Convert.ToDateTime("07-Aug-2015"), Used = 100000f  },
                new Audit() { Audit_Id = 6, Customer_Id = "C002", Log_Date = Convert.ToDateTime("15-Aug-2015"), Used = 300000f  },
                new Audit() { Audit_Id = 7, Customer_Id = "C003", Log_Date = Convert.ToDateTime("20-Aug-2015"), Used = 400000f  },
                new Audit() { Audit_Id = 8, Customer_Id = "C003", Log_Date = Convert.ToDateTime("25-Aug-2015"), Used = 200000f  },
                new Audit() { Audit_Id = 9, Customer_Id = "C004", Log_Date = Convert.ToDateTime("04-Aug-2015"), Used = 100000f  },
            };
        }
    }
}