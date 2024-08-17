using System;
using System.Collections.Generic;

namespace ARShoppingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var availableProducts = new List<Product>
            {
                new Product("T-Shirt", "Medium", "Red"),
                new Product("Jeans", "32", "Blue"),
                new Product("Jacket", "Large", "Black"),
                new Product("Sneakers", "Size 10", "White")
            };

            Console.WriteLine("Welcome to the AR Shopping Mall!");

            // Step 1: Display available products
            Console.WriteLine("\nAvailable Products:");
            for (int i = 0; i < availableProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {availableProducts[i].Name} - {availableProducts[i].Size}, {availableProducts[i].Color}");
            }

            // Step 2: User selects a product
            Console.Write("\nSelect a product to try on (Enter number): ");
            int selectedProductIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (selectedProductIndex < 0 || selectedProductIndex >= availableProducts.Count)
            {
                Console.WriteLine("Invalid selection. Exiting...");
                return;
            }

            var selectedProduct = availableProducts[selectedProductIndex];

            // Step 3: Simulate "trying on" the product
            Console.WriteLine($"\nYou selected to try on a {selectedProduct.Color} {selectedProduct.Name} (Size: {selectedProduct.Size})");

            // Step 4: Provide additional options
            Console.WriteLine("\nWhat would you like to do next?");
            Console.WriteLine("1. Purchase the product");
            Console.WriteLine("2. Try another product");
            Console.WriteLine("3. Exit");

            Console.Write("\nEnter your choice: ");
            int action = Convert.ToInt32(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine($"\nCongratulations! You have successfully purchased the {selectedProduct.Name}.");
                    break;
                case 2:
                    Console.WriteLine("\nRestarting simulation...\n");
                    Main(args); // Restart the simulation
                    break;
                case 3:
                    Console.WriteLine("\nThank you for visiting the AR Shopping Mall. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting...");
                    break;
            }
        }
    }

    class Product
    {
        public string Name { get; }
        public string Size { get; }
        public string Color { get; }

        public Product(string name, string size, string color)
        {
            Name = name;
            Size = size;
            Color = color;
        }
    }
}