using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAssignment
{
    public static class Assignments
    {
        //Assignment 1: Inheritance
        //Create a new abstarct class called Animal that contains public abstact string method called Speak
        //After that create a new classes called that inherits from Animal and implements the Speak method. Below animals you need to create
        //Dog that speaks woof
        //Cat that speaks meow
        //Bird that speaks kakaw

        //Assignment 2: Inheritance unit tests
        //Create unit tests for each animal that checks that the animal speaks what is expected. You can use [Fact] or [InlineData] for this.

        //Assignment 3: Interfaces
        //Create new interface called IFlyable that contains a method called Fly
        //Fly method should return a string that says "I am flying"
        //Implement the interface on the Bird class

        //Assignment 4: Interface unit tests
        //Create a unit test that checks if the animal is correctly flyable.
        //So if animal is a bird it should be able to fly, if it is a dog it should not be able to fly. Basically determinet by if the class implements the interface or not.

        //Assignment 5: Factory pattern
        //Create a new class called AnimalFactory that contains a method called CreateAnimal
        //CreateAnimal should take a string as a parameter and return an animal based on the string

        //Assigment 6: AnimalFactory Unit tests
        //Create a unit test (or tests how you want to implement this) that checks if the AnimalFactory returns the correct animal based on the string parameter

        //Assignment 7:Singleton pattern
        //Create Zookeeper class that is singleton (uses singleton pattern) and create unit test for it that checks that it is a singleton

        //Assignment 8: Observer pattern
        //Create a feed method for Zookeeper class that is called when an animal is hungry and an string property called LastAction that is public.
        //The feed method should take an animal as a parameter and set LastAction string to be "Feeding x" where x is the type of animal that is fed.
        //For example dog "says" it's hungry then the zookeeper should receive the message. The zookeeper should then set "Feeding dog" to LastAction property.
        //And lastly create unit test to test the observer pattern
        //
        //Example of LastAction property that Zookeeper should have that you can use for unit testing to check if the pattern is working correctly
        //public string LastAction { get; private set; } = "";
    }
}
