// See https://aka.ms/new-console-template for more information
using CarSalesApp.Data;
using System.Collections.Generic;

//method to display the list of cars
static void displayCars(List<Cars> car) {
    foreach (Cars cars in car) { 
        Console.WriteLine(cars);
    }
}

//connect and open database
using var db = new CarSalesDbContext();

//Load all car records from database#
var cars = db.Car.ToList();

//display all car records from memory list
displayCars(cars);

//add a new car record
var newCar = new Cars(0, "Corolla", "Toyota", 2023, Fuel.HYBRID, 13995, DateTime.Now, false);
db.Car.Add(newCar);
db.SaveChanges();