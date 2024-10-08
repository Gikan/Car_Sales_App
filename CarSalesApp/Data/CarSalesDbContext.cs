using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesApp.Data
{
    public class CarSalesDbContext:DbContext
    {
        public string DbPath { get; }//the location of the database filename

        public CarSalesDbContext() {
            //set the database filename(inc.full path to the user's Documents folder)
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Cars.db");
        }

        //specify the database tables(s)
        public DbSet<Cars> Car => Set<Cars>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // set the database filename (inc.path) for sqlite to use
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // execute the base OnModelCreating method
                                                // Add test data
            modelBuilder.Entity<Cars>().HasData(
            new Cars(1, "Polo", "Volkswagen", 2013, Fuel.PETROL, 4795,
            DateTime.Parse("2022-07-10"), true),
            new Cars(2, "Fiesta", "Ford", 2017, Fuel.PETROL, 9597,
            DateTime.Parse("2022-07-13"), false),
            new Cars(3, "1 Series", "BMW", 2016, Fuel.DIESEL, 11749,
            DateTime.Parse("2022-07-19"), true),
            new Cars(4, "2 Series", "BMW", 2017, Fuel.HYBRID, 18989,
            DateTime.Parse("2022-07-21"), true),
            new Cars(5, "Prius", "Toyota", 2014, Fuel.HYBRID, 13490,
            DateTime.Parse("2022-07-21"), true),
            new Cars(6, "Focus", "Ford", 2015, Fuel.DIESEL, 3995,
            DateTime.Parse("2022-07-25"), false),
            new Cars(7, "Golf", "Volkswagen", 2018, Fuel.ELECTRIC, 21000,
            DateTime.Parse("2022-07-30"), true),
            new Cars(8, "Yaris", "Toyota", 2021, Fuel.HYBRID, 18990,
            DateTime.Parse("2022-08-01"), false),
            new Cars(9, "i3", "BMW", 2014, Fuel.ELECTRIC, 14990,
            DateTime.Parse("2022-08-01"), false),
            new Cars(10, "RAV4", "Toyota", 2018, Fuel.HYBRID, 18495,
            DateTime.Parse("2022-08-03"), true),
            new Cars(11, "3 Series", "BMW", 2017, Fuel.HYBRID, 15000,
            DateTime.Parse("2022-08-07"), true),
            new Cars(12, "Focus", "Ford", 2014, Fuel.DIESEL, 4995,
            DateTime.Parse("2022-08-08"), false),
            new Cars(13, "1 Series", "BMW", 2018, Fuel.PETROL, 17250,
            DateTime.Parse("2022-08-10"), true),
            new Cars(14, "Fiesta", "Ford", 2015, Fuel.PETROL, 5400,
            DateTime.Parse("2022-08-15"), true),
            new Cars(15, "Z4", "BMW", 2014, Fuel.PETROL, 8990,
            DateTime.Parse("2022-08-20"), false),
            new Cars(16, "4 Series", "BMW", 2015, Fuel.DIESEL, 16990,
            DateTime.Parse("2022-08-27"), true),
            new Cars(17, "Zoe", "Renault", 2014, Fuel.ELECTRIC, 8995,
            DateTime.Parse("2022-09-02"), true),
            new Cars(18, "Fiesta", "Ford", 2016, Fuel.PETROL, 9380,
            DateTime.Parse("2022-09-05"), false),
            new Cars(19, "3 Series", "BMW", 2014, Fuel.PETROL, 11595,
            DateTime.Parse("2022-09-07"), false),
            new Cars(20, "Focus", "Ford", 2017, Fuel.PETROL, 8495,
            DateTime.Parse("2022-09-10"), false)
            );
        }

    }
}
