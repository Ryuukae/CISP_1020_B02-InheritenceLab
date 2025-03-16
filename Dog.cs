using System;

namespace InheritanceLab
{
    /// <summary>
    /// Represents a dog with a name, age, and species by extending the <see cref="Mammal"/> class.
    /// This class inherits the warm-blooded property from the <see cref="Mammal"/> class and adds behavior specific to dogs.
    /// </summary>
    public class Dog : Mammal
    {
        /// <summary>
        /// Constructor to initialize a Dog with a name, age, and species.
        /// </summary>
        /// <param name="name">The name of the dog.</param>
        /// <param name="age">The age of the dog.</param>
        /// <param name="species">The species of the dog.</param>
        public Dog(string name, int age, string species) : base(name, age, species) { }

        /// <summary>
        /// Makes a sound specific to dogs.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }
}
