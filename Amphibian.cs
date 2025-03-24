using System;

namespace InheritanceLab
{
    /// <summary>
    /// Represents amphibians, and includes an additional property, IsAquatic.
    /// This class extends the <see cref="Animal"/> class and adds behaviour specific to amphibians.
    /// </summary>
    public class Amphibian : Animal
    {
        /// <summary>
        /// Gets or sets a value indicating whether the amphibian is primarily aquatic.
        /// Defaults to true.
        /// </summary>
        /// <value><c>true</c> if the amphibian is aquatic; otherwise, <c>false</c>.</value>
        public bool IsAquatic { get; set; } = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="Amphibian"/> class.
        /// </summary>
        /// <param name="name">The name of the amphibian.</param>
        /// <param name="age">The age of the amphibian.</param>
        /// <param name="species">The species of the amphibian.</param>
        /// <param name="isAquatic">Indicates whether the amphibian is aquatic.</param>
        /// <returns>An instantiated <see cref="Amphibian"/>  object.</returns>
        public Amphibian(string name, int age, string species, bool isAquatic) : base(name, age, species)
        {
            IsAquatic = isAquatic;
        }

        /// <summary>
        /// Overriden method that makes a sound specific to amphibians.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Amphibian sound.");
        }

        /// <summary>
        /// Displays the properties of the object.
        /// This method is overridden to provide specific descriptions.
        /// </summary>
        public override void PrintObjectProperties()
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}, IsAquatic: {IsAquatic}");
        }

        /// <summary>
        /// Displays information about the amphibian, including its name, age, species, and whether it
        /// is primarily aquatic.
        /// This method is overridden to provide specific descriptions.
        /// </summary>
        public override void Describe()
        {
            Console.WriteLine($"This is a {Species}, a type of {GetType().Name}, named {Name} who is {Age} years old, and is {(IsAquatic ? "primarily aquatic" : "not primarily aquatic")}.");
        }
    }
}
