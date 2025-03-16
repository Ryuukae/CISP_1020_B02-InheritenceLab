﻿using System;
using InheritanceLab;

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

Using a medical system as another example, you would want to restrict access to patient information, 
such as their name, medical history, diagnosis, treatment, appointments, ect. to protect the privacy
of the patient. Again, by using access modifiers, only the classes and methods that need access to 
this information have it, and that the information is not exposed to potential threats unnecessarily. */

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
            Animal animal = new Animal("Generic Animal", 5, "Unknown");
            Mammal mammal = new Mammal("Dave", 4, "Primate");
            Reptile reptile = new Reptile("Leo", 2, "Lizard");
            Dog dog = new Dog("Buddy", 4, "Canine");

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
            animal.DisplayInfo();
            mammal.DisplayInfo();
            reptile.DisplayInfo();
            dog.DisplayInfo();
            Console.WriteLine();
            
            // Trying to access the Age property directly will result in the following outcome:
            // Console.WriteLine(animal.Age); // Error: 'Animal.Age' is inaccessible due to its protection level.
            // This is because the Age property is marked as 'protected', so it is only accessible within the Animal or child classes.

            // Use a method in a derived class to access the Age property
            Console.WriteLine($"Reptile Age (via method): {reptile.GetAgeFromDerivedClass()}");
        }
    }
}
