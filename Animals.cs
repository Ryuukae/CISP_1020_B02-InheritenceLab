using System;
namespace InheritenceLab
{
    // Base class representing a generic animal
    public class Animal
    {
        // Properties for the animal's name and age
        public string Name { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Constructor to initialize an Animal with a name and age.
        /// </summary>
        /// <param name="name">The name of the animal.</param>
        /// <param name="age">The age of the animal.</param>
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /// <summary>
        /// Makes a generic sound.
        /// </summary>
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound.");
        }
    }

    // This class represents mammals and extends the Animal class.
    public class Mammal : Animal
    {
        // Property that indicates if the mammal is warm-blooded.
        public bool IsWarmBlooded { get; set; } = true;

        /// <summary>
        /// Constructor to initialize a Mammal with a name and age.
        /// </summary>
        /// <param name="name">The name of the mammal.</param>
        /// <param name="age">The age of the mammal.</param>
        public Mammal(string name, int age) : base(name, age) { }

        /// <summary>
        /// Makes a sound specific to mammals.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Mammal sound.");
        }
    }

    // This class represents reptiles and inherits from the Animal class.
    public class Reptile : Animal
    {
        // Property that indicates if the reptile is able to regrow its tail.
        public bool CanRegrowTail { get; set; }

        /// <summary>
        /// Creates a new reptile with the specified name and age.
        /// </summary>
        /// <param name="name">The name of the reptile.</param>
        /// <param name="age">The age of the reptile.</param>
        public Reptile(string name, int age) : base(name, age) { }

        /// <summary>
        /// Makes a sound specific to reptiles.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Reptile sound.");
        }
    }

    // This class represents dogs, which are a type of mammal.
    public class Dog : Mammal
    {
        /// <summary>
        /// Constructor to initialize a Dog with a name and age.
        /// </summary>
        /// <param name="name">The name of the dog.</param>
        /// <param name="age">The age of the dog.</param>
        public Dog(string name, int age) : base(name, age) { }

        /// <summary>
        /// Makes a sound specific to dogs.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }
}
