using System;
using System.Collections.Generic;

namespace planets
{
    public class Program
    {
        public static void Main()
        {
            //List behaves like an array 
            List<string> planets = new List<string>(){"Mercury", "Mars"};
            // Add() Jupiter and Saturn at the end of the list.
                planets.Add("Jupiter");
                planets.Add("Saturn");
            // Create another List that contains that last two planet of our solar system.
                List<string> lastPlanets = new List<string>(){"Venus", "Neptune"};
            // Combine the two lists by using AddRange().
                planets.AddRange(lastPlanets);
            // Use Insert() to add Earth, and Venus in the correct order.
                planets.Insert(1, "Venus");
                planets.Insert(2, "Earth");
                
                planets.RemoveAt(6);

                planets.Insert(6, "Uranus");
            // Use Add() again to add Pluto to the end of the list
                planets.Add("Pluto");
            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
                planets.Remove("Pluto");

            

                //for each string in the planet list Console.WritLine each string (planet).
                foreach(string planet in planets){
                    Console.WriteLine(planet);
                };

            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.

                List<string> rockyPlanets = planets.GetRange(0, 4);

                rockyPlanets.RemoveAt(1);
                rockyPlanets.RemoveAt(2);
                rockyPlanets.Remove("Earth");

                rockyPlanets.Add("Jupiter");
                rockyPlanets.Add("Saturn");
                rockyPlanets.Add("Mars");

                Console.WriteLine();
                foreach(string rocky in rockyPlanets){
                    Console.WriteLine(rocky);
                };


            
        }
    }
}





