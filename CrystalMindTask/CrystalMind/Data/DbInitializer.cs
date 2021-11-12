using CrystalMind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalMind.Data
{
    public class DbInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Customers.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{CustomerLastName="Carson",CustomerFirstName="Alexander",CustomerGender="M",CustomerDOB=DateTime.Parse("2005-09-01"),CustomerEmail="Alexander@gmail.com"},
            new Customer{CustomerLastName="Meredith",CustomerFirstName="Alonso",CustomerGender="M",CustomerDOB=DateTime.Parse("2002-09-01"),CustomerEmail="Alonso@gmail.com"},
            new Customer{CustomerLastName="Arturo",CustomerFirstName="Anand",CustomerGender="F",CustomerDOB=DateTime.Parse("2003-09-01"),CustomerEmail="Anand@gmail.com"},
            new Customer{CustomerLastName="Gytis",CustomerFirstName="Barzdukas",CustomerGender="F",CustomerDOB=DateTime.Parse("2002-09-01"),CustomerEmail="Barzdukas@gmail.com"},
            new Customer{CustomerLastName="Yan",CustomerFirstName="Li",CustomerGender="M",CustomerDOB=DateTime.Parse("2002-09-01"),CustomerEmail="Li@gmail.com"},
            new Customer{CustomerLastName="Peggy",CustomerFirstName="Justice",CustomerGender="M",CustomerDOB=DateTime.Parse("2001-09-01"),CustomerEmail="Justice@gmail.com"},
            };
            foreach (Customer s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();

            var addresses = new Adress[]
            {
            new Adress{ID=1050,Street="27 Al Nozha",City="Cairo",CustomerID=1},
            new Adress{ID=4022,Street="15 Al Nozha2",City="Cairo", CustomerID=2},
            new Adress{ID=4041,Street="27 Al Nozha3",City="Cairo",CustomerID=3},
            new Adress{ID=1045,Street="22 Fisal",City="Giza" ,CustomerID=1},
            new Adress{ID=3141,Street="20 Abo ker",City="Alexzandria",CustomerID=2},
            new Adress{ID=2021,Street="Staly",City="Alexzandria",CustomerID=3},
            new Adress{ID=2042,Street="Mahkama",City="Mansora",CustomerID=4}
            };
            foreach (Adress c in addresses)
            {
                context.Addresses.Add(c);
            }
            context.SaveChanges();

            
            
        }
    }
}
