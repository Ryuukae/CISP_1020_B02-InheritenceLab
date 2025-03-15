﻿using System;
namespace InheritenceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each class using their constructors.
            Animal animal = new Animal("Generic Animal", 5);
            Mammal mammal = new Mammal("Dave", 4);
            Reptile reptile = new Reptile("Leo", 2);
            Dog dog = new Dog("Buddy", 4);

            // Print the sound each animal makes.
            Console.WriteLine("--- Sounds ---");
            // Call the MakeSound method for each object
            animal.MakeSound();
            mammal.MakeSound();
            reptile.MakeSound();
            dog.MakeSound();
            Console.WriteLine();

            // Display the properties of each object to the console.
            Console.WriteLine("--- Object Properties ---");
            Console.WriteLine($"Animal: Name: {animal.Name}, Age: {animal.Age}");
            Console.WriteLine($"Mammal: Name: {mammal.Name}, Age: {mammal.Age}, IsWarmBlooded: {mammal.IsWarmBlooded}");
            Console.WriteLine($"Reptile: Name: {reptile.Name}, Age: {reptile.Age}, CanRegrowTail: {reptile.CanRegrowTail}");
            Console.WriteLine($"Dog: Name: {dog.Name}, Age: {dog.Age}, IsWarmBlooded: {dog.IsWarmBlooded}");
            Console.WriteLine();
        }
    }
}
