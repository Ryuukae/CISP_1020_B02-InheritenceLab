using System;
using InheritanceLab;

namespace InheritanceLab
{
    /// <summary>
    /// Represents reptiles, and includes an additional property, HasRattler.
    /// This class extends the <see cref="Animal"/> class and adds behaviour specific to reptiles.
    /// </summary>
    public class Reptile : Animal
    {

        /// <summary>
        /// Gets or sets a value indicating whether the reptile can regrow its tail.
        /// </summary>
        /// <value><c>true</c> if the reptile can regrow its tail; otherwise, <c>false</c>.</value>
        public bool CanRegrowTail { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reptile"/> class.
        /// </summary>
        /// <param name="name">The name of the reptile.</param>
        /// <param name="age">The age of the reptile.</param>
        /// <param name="species">The species of the reptile.</param>
        /// <param name="canRegrowTail">Indicates whether the reptile can regrow its tail.</param>
        public Reptile(string name, int age, string species, bool canRegrowTail) : base(name, age, species)
        {
            CanRegrowTail = canRegrowTail;
        }

        /// <summary>
        /// Overriden method that makes a sound specific to reptiles.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Reptile sound.");
        }

        // <summary>
        /// Displays the properties of the object.
        /// This method is overridden to provide specific descriptions.
        /// </summary>
        public override void PrintObjectProperties()
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}, CanRegrowTail: {CanRegrowTail}");
        }

        /// <summary>
        /// Displays information about the reptile, including its name, age, species, and whether it
        /// can regrow its tail.
        /// This method is overridden to provide specific descriptions.
        /// </summary>
        public override void Describe()
        {
            Console.WriteLine($"This is a {Species}, a type of {GetType().Name}, named {Name}, and who is {Age} years old, and {(CanRegrowTail ? "can" : "cannot")} regrow its tail.");
        }
        public int GetAgeFromDerivedClass()
        {
            return this.Age; // Accessing the protected Age property is allowed here.
        }
    }
}
