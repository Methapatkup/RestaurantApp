
using System;

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
            Restaurant restaurant = new Restaurant(
                1,
                "ร้านอาหารตามสั่ง",
                "อาหารไทย",
                4.5
            );

            Console.WriteLine("hello TIT.1/1");
            Console.WriteLine($"รหัสร้าน: {restaurant.Id}");
            Console.WriteLine($"ชื่อร้าน: {restaurant.Name}");
            Console.WriteLine($"ประเภท: {restaurant.Type}");
            Console.WriteLine($"คะแนน: {restaurant.Rating}");
        }
    }
}
