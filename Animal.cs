using System;
using InheritanceLab;

namespace InheritanceLab
{
    /// <summary>  
    /// Represents a generic animal with a name, age, and species.
    /// This class is the base class for other animal types.
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
            get
            {
                return _species;
            }
            set
            {
                _species = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the animal.
        /// </summary>
        /// <value>The name of the animal as a string.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age of the animal.
        /// This property is accessible only within this class and its derived classes.
        /// </summary>
        /// <value>The age of the animal in years.</value>
        protected int Age { get; set; }

        /// <summary>
        /// Constructor to initialize an Animal with a name, age, and species.
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
        /// Makes a generic sound.
        /// </summary>
        public virtual void MakeSound() 
        {
            Console.WriteLine("Some generic sound.");
        }

        /// <summary>
        /// Displays information about the animal, including its name, age, and species.
        /// </summary>
        public virtual void DisplayInfo() 
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}");
        }
    }
}
