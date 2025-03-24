using System;

namespace InheritanceLab
{
    /// <summary>
    /// Represents a cat with a name, age, and species by extending the <see cref="Animal"/> class.
    /// This class inherits the warm-blooded property from the <see cref="Mammal"/> class and adds behavior specific to cats.
    /// </summary>
    public class Cat : Mammal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat"/> class.
        /// </summary>
        /// <param name="name">The name of the cat.</param>
        /// <param name="age">The age of the cat.</param>
        /// <param name="species">The species of the cat.</param>
        /// <returns>An instance of the <see cref="Cat"/> class.</returns>
        public Cat(string name, int age, string species) : base(name, age, species) { }

        /// <summary>
        /// Overriden method that makes a sound specific to cats.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
