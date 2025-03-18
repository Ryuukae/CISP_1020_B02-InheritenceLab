using System;
using InheritanceLab;

namespace InheritanceLab
{
    /// <summary>
    /// Represents mammals, and includes an additional property, is warm-blooded, that is always true.
    /// This class extends the <see cref="Animal"/> class and introduces behavior specific to mammals.
    /// </summary>
    public class Mammal : Animal
    {
        /// <summary>
        /// Gets or sets a value indicating whether the mammal is warm-blooded.
        /// Defaults to true as mammals are always warm-blooded.
        /// </summary>
        /// <value><c>true</c> if the mammal is warm-blooded; otherwise, <c>false</c>.</value>
        public bool IsWarmBlooded { get; set; } = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mammal"/> class without 
        /// specifying if the animal is warm-blooded (defaults to true).
        /// </summary>
        /// <param name="name">The name of the mammal.</param>
        /// <param name="age">The age of the mammal.</param>
        /// <param name="species">The species of the mammal.</param>
        public Mammal(string name, int age, string species) : base(name, age, species) {}
       
        /// <summary>
        /// Overriden method that makes a sound specific to mammals.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Mammal sound.");
        }
        
        // <summary>
        /// Displays the properties of the object.
        /// This method is overridden to provide specific descriptions.
        /// </summary>
        public override void PrintObjectProperties()
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}, Warm-blooded: {IsWarmBlooded}");
        }

        /// <summary>
        /// Displays information about the mammal, including its name, age, species, and whether it
        /// is warm blooded.
        /// This method is overridden to provide specific descriptions.
        /// </summary>
        public override void Describe()
        {
            Console.WriteLine($"This is a {Species}, a type of {GetType().Name}, named {Name} who is {Age} years old, and is {(IsWarmBlooded ? "warm-blooded" : "cold-blooded")}.");
        }
    }
}
