using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace CarSalesApp.Data
{
    public class Cars
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public Fuel Fuel { get; set; }
        public double Price { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Sold { get; set; }

        //Default constructor
        public Cars() { 
            Name = string.Empty;
            Manufacturer = string.Empty;
        }

        public Cars(int id, string name, string manufacturer, int year, Fuel fuel, double price, DateTime dateAdded, bool sold) {
            Id = id;
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
            Fuel = fuel;
            Price = price;
            DateAdded = dateAdded;
            Sold = sold;

        }

        public override string ToString() { 
            var str = Id + ":" + Manufacturer + "-" + Name +"("+Year+")£" + Price
                + "" + Fuel + "(" + DateAdded.ToShortDateString() +")";

            if (Sold) {
                str = str + "**";
            }
            return str;
        }

    }//End of class
    //I came to send this project to my old git page
}
