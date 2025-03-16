using System;

namespace InheritenceLab
{
    /// <summary>  
    /// Represents a generic animal with a name, age, and species.
    /// This class is the base class for other animal types.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Stores the species of the animal. This field is accessed via the Species property.
        /// </summary>
        private string _species;

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
        public virtual void MakeSound() // Marked as virtual to allow overriding
        {
            Console.WriteLine("Some generic sound.");
        }

        /// <summary>
        /// Displays information about the animal, including its name, age, and species.
        /// </summary>
        public virtual void DisplayInfo() // Marked as virtual to allow overriding
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}");
        }
    }

    /// <summary>
    /// Represents mammals with a name, age, and species by extending the <see cref="Animal"/> class.
    /// This class also includes a property to indicate whether the mammal is warm-blooded.
    /// </summary>
    public class Mammal : Animal
    {
        /// <summary>
        /// Gets or sets a value indicating whether the mammal is warm-blooded.
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

   /// <summary>
    /// Represents reptiles with a name, age, and species by extending the <see cref="Animal"/> class.
    /// This class also includes a property to indicate whether the reptile can regrow its tail.
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
        /// Demonstrates accessing the protected Age property within a derived class.
        /// </summary>
        /// <returns>The age of the reptile.</returns>
        public int GetAgeFromDerivedClass()
        {
            return this.Age; // Accessing the protected Age property is allowed here.
        }

        /// <summary>
        /// Displays information about the reptile, including its name, age, species, and whether it can regrow its tail.
        /// </summary>
        public override void DisplayInfo()
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}, Can Regrow Tail: {CanRegrowTail}");
        }
    }

    // This class represents dogs, which are a type of mammal.
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