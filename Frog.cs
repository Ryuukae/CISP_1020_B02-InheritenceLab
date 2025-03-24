using System;

namespace InheritanceLab
{
    /// <summary>
    /// Represents a frog with a name, age, and species by extending the <see cref="Animal"/> class.
    /// This class inherits the aquatic property from the <see cref="Amphibian"/> class and adds behavior specific to frogs.
    /// </summary>
    public class Frog : Amphibian
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frog"/> class.
        /// </summary>
        /// <param name="name">The name of the frog.</param>
        /// <param name="age">The age of the frog.</param>
        /// <param name="species">The species of the frog.</param>
        /// <param name="isAquatic">Indicates whether the frog is aquatic.</param>
        /// <returns>An instantiated instance of the <see cref="Frog"/> class.</returns>
        public Frog(string name, int age, string species, bool isAquatic) : base(name, age, species, isAquatic) { }

        /// <summary>
        /// Overriden method that makes a sound specific to frogs.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Ribbit!");
        }

  
    }
}
