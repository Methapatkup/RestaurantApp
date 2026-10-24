
using System;
using System.Collections.Generic;

namespace RestaurantApp
{
    internal class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

        public Restaurant(int id, string name, string type, double rating)
        {
            Id = id;
            Name = name;
            Type = type;
            Rating = rating;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
            };

            foreach (Restaurant restaurant in restaurants)
            {
                Console.WriteLine($"ID: {restaurant.Id}");
                Console.WriteLine($"Name: {restaurant.Name}");
                Console.WriteLine($"Type: {restaurant.Type}");
                Console.WriteLine($"Rating: {restaurant.Rating}");
                Console.WriteLine("----------------------");
            }
        }
    }
}
