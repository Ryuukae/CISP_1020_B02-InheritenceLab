using System;
using InheritanceLab;

namespace InheritanceLab
{
    /// <summary>
    /// Represents an unknown animal with properties for name, age, and species.
    /// This class serves as the base class for all specific animal types.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// The private variable that stores the species of the animal. 
        /// This field is accessed via the Species property.
        /// This field is only directly accessible within this class and its derived classes.
        /// </summary>
        private string _species = "Unknown"; // Initialize with a default value

        /// <summary>
        /// Gets or sets the species of the animal.
        /// </summary>
        /// <value>The species of the animal as a string.</value>
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        /// <summary>
        /// Gets or sets the name of the animal.
        /// </summary>
        /// <value>The name of the animal as a string.</value>
        public string Name { get; set; } = "Unknown";
        
        /// <summary>
        /// Gets or sets the age of the animal.
        /// This property is accessible only within this class and its derived classes.
        /// </summary>
        /// <value>The age of the animal in years.</value>
        protected int Age { get; set; } = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        /// <param name="age">The age of the animal.</param>
        /// <param name="species">The species of the animal.</param>
        public Animal(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }

        /// <summary>
        /// Makes an unknown animal sound.
        /// This method is overriden in derived classes to provide animal-specific sounds.
        /// </summary>
        public virtual void MakeSound() 
        {
            Console.WriteLine("Unknown animal sound.");
        }

        /// <summary>
        /// Displays the properties of the object.
        /// This method is overridden in derived classes to provide specific descriptions.
        /// </summary>
        public virtual void PrintObjectProperties() 
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}");

        }

        /// <summary>
        /// Describes the animal, including its class, name, age, and species.
        /// This method is overridden in derived classes to provide specific descriptions.
        /// </summary>
        public virtual void Describe()
        {
            Console.WriteLine($"This is a {Species}, a type of {GetType().Name}, named {Name} who is {Age} years old.");
        }
    }
}
