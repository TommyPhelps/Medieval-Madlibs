using System;

namespace MedievalMadlib
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Variables
            string species, name, objectPlural, creature, highPlace, verb;
            string[] adjective = new string[2], location = new string[2];

            // Get Input From User
            Console.WriteLine("Welcome, I'm sure you're confused right now, but don't be. You have been teleported into a computer. \n" +
                              "Don't worry though, All you have to do is not lose at this game and you get out! Pretty simple, eh?\n" +
                              "First I need you to enter your name: ");
            name = Console.ReadLine();
            
            // Users inputs a species
            Console.WriteLine("You're doing great, now enter a species: ");
            species = Console.ReadLine();
            
            // Users inputs location 1
            Console.WriteLine("Wonderful, now enter a location: ");
            location[0] = Console.ReadLine();
            
            // Users inputs location 2
            Console.WriteLine("Now another location: ");
            location[1] = Console.ReadLine();
            
            // Users inputs adjective 1
            Console.WriteLine("Awesome, now an adjective: ");
            adjective[0] = Console.ReadLine();
            
            // Users inputs adjective 2
            Console.WriteLine("Cool now another adjective: ");
            adjective[1] = Console.ReadLine();
            
            // Users inputs an object
            Console.WriteLine("Halfway there, now an object (plural): ");
            objectPlural = Console.ReadLine();
            
            // Users inputs a creature
            Console.WriteLine("You've made it so far! Now a creature, think scary: ");
            creature = Console.ReadLine();
            
            // Users inputs a high place
            Console.WriteLine("One more to go after this, now a high place: ");
            highPlace = Console.ReadLine();
            
            // Users inputs a verb
            Console.WriteLine("Last one, now a verb (past tense): ");
            verb = Console.ReadLine();
            
            Console.WriteLine("Congrats the hard part is over now to the fun bit! Let's see how you did!\n");

            // Init Story
            string madlibsStory = 
            $"Once upon a time in {location[0]}, a {species} named {name} was going to {location[1]}. " +
            $"As he trotted down his usual path he saw some {adjective[0]} {objectPlural}, he quickly picked them and looked around to see if anyone saw. " +
            $"Knowing he was safe he gobbled them up faster than any {species} had done before. " +
            $"As he was eating the {objectPlural} a {adjective[1]} {creature} flew down from the {highPlace} and {verb} him.";
            
            // Print Story
            Console.WriteLine(madlibsStory);
        }
    }
}