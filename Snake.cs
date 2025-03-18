using System;

namespace InheritanceLab
{
    /// <summary>
    /// Represents a snake with a name, age, and species by extending the <see cref="Animal"/> class.
    /// This class inherits the CanRegrowTail property from the <see cref="Reptile"/> class,
    /// introduces a unique property HasRattler, and adds behavior specific to snakes.
    /// </summary>
    public class Snake : Reptile
    {
        /// <summary>
        /// Gets or sets a value indicating whether the snake has a rattler.
        /// </summary>
        /// <value><c>true</c> if the snake has a rattler; otherwise, <c>false</c>.</value>
        public bool HasRattler { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Snake"/> class.
        /// </summary>
        /// <param name="name">The name of the snake.</param>
        /// <param name="age">The age of the snake.</param>
        /// <param name="species">The species of the snake.</param>
        /// <param name="hasRattler">Indicates whether the snake has a rattler.</param>
        public Snake(string name, int age, string species, bool hasRattler) : base(name, age, species, canRegrowTail: false)
        {
            HasRattler = hasRattler;
        }

        /// <summary>
        /// Overriden method that makes a sound specific to snakes.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Hiss!");
        }

        /// <summary>
        /// Displays the properties of the object.
        /// This method is overridden to provide specific descriptions.
        /// </summary>
        public override void PrintObjectProperties()
        {
            Console.WriteLine($"Class: {GetType().Name}, Name: {Name}, Age: {Age}, Species: {Species}, CanRegrowTail: {CanRegrowTail}, HasRattler: {HasRattler}");
        }

        /// <summary>
        /// Displays information about the snake, including its name, age, species, whether it
        /// can regrow its tail, and if it has a rattler.
        /// This method is overridden to provide specific descriptions.
        /// </summary>
        public override void Describe()
        {
            Console.WriteLine($"This is a {Species}, a type of {(HasRattler ? "rattle" : "rattleless")} {GetType().Name} that cannot regrow their tail, named {Name} who is {Age} years old.");
        }
    }
}
