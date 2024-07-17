
using FoodDelivery.Models;
using FoodDelivery.Services;
using System;

namespace FoodDeliveryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodServices foodServices = new FoodServices();

            // Display all available foods
            var foods = foodServices.GetAvailableFoods();

            foreach (var food in foods)
            {
                Console.WriteLine($"Name: {food.Name}, Price: {food.Price}, Available: {food.IsAvailable}");
            }

            // Other operations (add/update/delete) can be similarly invoked

            Console.ReadLine();
        }
    }
}

