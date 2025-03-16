using System;
using InheritanceLab;

namespace InheritanceLab
{
    /// <summary>
    /// Represents mammals with a name, age, and species by extending the <see cref="Animal"/> class.
    /// This class also includes a property to indicate whether the mammal is warm-blooded.
    /// </summary>
    public class Mammal : Animal
    {
        /// <summary>
        /// Gets or sets a value indicating whether the mammal is warm-blooded.
        /// Defaults to true.
        /// </summary>
        /// <value><c>true</c> if the mammal is warm-blooded; otherwise, <c>false</c>.</value>
        public bool IsWarmBlooded { get; set; } = true;

        /// <summary>
        /// Constructor to initialize a Mammal with a name, age, and species.
        /// </summary>
        /// <param name="name">The name of the mammal.</param>
        /// <param name="age">The age of the mammal.</param>
        /// <param name="species">The species of the mammal.</param>
        public Mammal(string name, int age, string species) : base(name, age, species) { }

        /// <summary>
        /// Makes a sound specific to mammals.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Mammal sound.");
        }

        /// <summary>
        /// Displays information about the mammal, including its name, age, species, and whether it is warm-blooded.
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}, Warm-blooded: {IsWarmBlooded}");
        }
    }
}
