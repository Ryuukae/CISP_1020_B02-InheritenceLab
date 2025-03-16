using System;
using InheritanceLab;

namespace InheritanceLab
{
    /// <summary>
    /// This class represents reptiles with a name, age, and species by extending the <see cref="Animal"/> class.
    /// The class also includes a property to indicate whether the reptile can regrow its tail.
    /// </summary>
    public class Reptile : Animal
    {
        /// <summary>
        /// Gets or sets a value indicating whether the reptile can regrow its tail.
        /// </summary>
        /// <value><c>true</c> if the reptile can regrow its tail; otherwise, <c>false</c>.</value>
        public bool CanRegrowTail { get; set; }

        /// <summary>
        /// Creates a new reptile with the specified name, age, and species.
        /// </summary>
        /// <param name="name">The name of the reptile.</param>
        /// <param name="age">The age of the reptile.</param>
        /// <param name="species">The species of the reptile.</param>
        public Reptile(string name, int age, string species) : base(name, age, species) { }

        /// <summary>
        /// Makes a sound specific to reptiles.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Reptile sound.");
        }

        /// <summary>
        /// Demonstrates accessing the protected Age property in an 
        /// external class throuh a derived class.
        /// </summary>
        /// <returns>The age of the reptile.</returns>
        public int GetAgeFromDerivedClass()
        {
            return this.Age; // Accessing the protected Age property is allowed here.
        }

        /// <summary>
        /// Displays information about the reptile.
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}, Can Regrow Tail: {CanRegrowTail}");
        }
    }
}
