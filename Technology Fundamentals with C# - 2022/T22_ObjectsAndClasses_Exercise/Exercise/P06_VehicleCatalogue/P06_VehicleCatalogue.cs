﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

namespace P06_VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicle> catalogue = new List<Vehicle>();

            while (input != "End")
            {
                string[] vehicleInfo = input.Split();

                string type = vehicleInfo[0].ToLower();
                string model = vehicleInfo[1];
                string color = vehicleInfo[2].ToLower();
                int horsePower = int.Parse(vehicleInfo[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(vehicle);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                Console.WriteLine(catalogue.Find(x => x.Model == input));

                input = Console.ReadLine();
            }

            var onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            var onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();
            double totalCarsHorsepower = 0;
            double totalTrucksHorsepower = 0;

            foreach (var car in onlyCars)
            {
                totalCarsHorsepower += car.HorsePower;
            }

            foreach (var truck in onlyTrucks)
            {
                totalTrucksHorsepower += truck.HorsePower;
            }

            double averageCarsHorsepower = totalCarsHorsepower / onlyCars.Count;
            double averageTrucksHorsepower = totalTrucksHorsepower / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                $"Model: {this.Model}{Environment.NewLine}" +
                $"Color: {this.Color}{Environment.NewLine}" +
                $"Horsepower: {this.HorsePower}";
        }
    }
}