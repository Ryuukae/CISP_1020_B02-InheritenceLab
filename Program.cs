﻿using System;
using InheritanceLab;
using System.Collections.Generic;

/*** Access Modifier Discussion ***/
//----------------------------------------------------------------------------------------------------
/** Discuss (as comments) how access modifiers can help protect sensitive
data in applications like banking or medical systems. **/

/* Access modifers can help protect sensitive data in applications by restricting access from
certain data and/or methods to specific classes and methods. How can this help protect sensative
information in real world scenarios??

   For instance, using a banking application as an example, you would want to restrict access to certain
information, such as the a users account number, balance, transaction history, email, age, address, ect.,
so that only certain classes and methods can access this information. One of the ways to acheive this is
by ensuring that only classes that need the access may have it by using access modifiers. This way,
sensitive data is not exposed unneccessarily and, as a result, the overall amount of exposure of
data to potential threats is reduced.

   Similarly, using a medical system as another example, you would want to restrict access to patient
information, such as their name, medical history, diagnosis, treatment, appointments, ect. to protect
the privacy of the patient. Again, by using access modifiers, only the classes and methods that need
access to this information have it, thus limiting exposure to potential threats unnecessarily. */


namespace InheritanceLab
{
    /// <summary>
    /// This class functions as the primary entry point of the application,
    /// initializing core components and orchestrating the
    /// flow of execution.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The method that kicks off the program execution and
        /// serves as the starting point of the application.
        /// This method initializes necessary components and begins execution.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {

            // Create instances of each class.

            // Generic Animal
            Animal animal = new Animal("Animal Unknown", 0, "Unknown");
            // Mammals
            Mammal mammal = new Mammal("Dave", 4, "Mammal");
            Dog dog = new Dog("Buddy", 4, "Canis Lupus Familiaris");
            Cat cat = new Cat("Whiskers", 3, "Felis catus");
            // Reptiles
            Reptile reptile = new Reptile("Leo", 2, "Reptile", true);
            Snake snake = new Snake("Slithers", 5, "Pythonidae", false);
            // Amphibians
            Amphibian amphibian = new Amphibian("Sally", 2, "Amphibian", false);
            Frog frog = new Frog("Kermit", 1, "Phyllobates Terribilis", true);

            // Print the sound each animal makes.
            Console.WriteLine("--- Sounds ---");
            // Call the MakeSound method for each object
            animal.MakeSound();
            // Mammals
            mammal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
            // Reptiles
            reptile.MakeSound();
            snake.MakeSound();
            // Amphibians
            amphibian.MakeSound();
            frog.MakeSound();
            Console.WriteLine();

            // Display the properties of each object to the console.
            Console.WriteLine("--- Object Properties ---");
            animal.PrintObjectProperties();
            // Mammals
            mammal.PrintObjectProperties();
            dog.PrintObjectProperties();
            cat.PrintObjectProperties();
            // Reptiles
            reptile.PrintObjectProperties();
            snake.PrintObjectProperties();
            // Amphibians
            amphibian.PrintObjectProperties();
            frog.PrintObjectProperties();
            Console.WriteLine();

            // Create a list of Animal objects
            List<Animal> zoo = new List<Animal>
            {
                animal,
                mammal,
                dog,
                cat,
                reptile,
                snake,
                amphibian,
                frog
            };

            // Print descriptions of all animals in the zoo
            Console.WriteLine("--- Zoo Animal Descriptions ---");
            PrintZoo(zoo);

            // Trying to access the Age property directly will result in the following outcome:
            // Console.WriteLine(animal.Age); // Error: 'Animal.Age' is inaccessible due to its protection level.
            // This is because the Age property is marked as 'protected', so it is only accessible within the Animal or child classes.

            // Use a method in a derived class to access the Age property
            Console.WriteLine($"Reptile Age (Accessed via method): {reptile.GetAgeFromDerivedClass()}");
        }

        /// <summary>
        /// Prints the description of each animal in the zoo from a list of animal objects.
        /// </summary>
        /// <param name="animals">A list of Animal objects.</param>
        static void PrintZoo(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                animal.Describe();
            }
            Console.WriteLine();
        }
    }
}

/*** A Last Note ***/
//----------------------------------------------------------------------------------------------------
/* Logically, the parent classes, such as Animal, Mammal, Reptile, Amphibian, etc., should be abstract,  
   as you would only ever make instances of their child classes, considering that they represent broad 
   categories rather than specific, instantiable entities, and that any object created as a mammal 
   should be instanted as a more specific subclass, such as dog or frog, but for the purposes of the
   assignment they have been left as concrete classes. */