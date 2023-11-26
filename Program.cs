using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Superhero objects 
            SuperHero hero1 = new SuperHero("Aquaman", "Atlantis", "Telepathic control of aquatic life", 1941, "Utilizing The Sacred Trident");
            SuperHero hero2 = new SuperHero("Batman", "Gotham-City", "Genius-Level intellect", 1939, "Master of Martial Arts");
            SuperHero hero3 = new SuperHero("Superman", "Metropolis", "Super-Sterngth", 1938, "Flight");
            SuperHero hero4 = new SuperHero("The Flash", "Star City", "Super-Speed", 1940, "Time Travel");
            SuperHero hero5 = new SuperHero("Wonder Woman", "Amazon", "Strength of Hercules", 1984, "Lasso of truth");

            //Storing the superheroes in an array
            SuperHero[] superHeroes = { hero1, hero2, hero3, hero4, hero5 };
            //Writeline to print out each superheroes(the original statement)
            Console.WriteLine("List of Justice leagues members..\n");
            printSuperHeroes(superHeroes);
            //The change changed data for either the heroes power or their status on earth
            hero1.FirstSuperpower = "Can breathe underwater";
            hero2.OnPlanetEarth();
            hero3.FirstSuperpower = "Laser Vision";
            hero4.OnPlanetEarth();
            hero5.FirstSuperpower = "Wisdom of Athena";
            //Method to print out the heroes new powers/status on earth.  
            Console.WriteLine("After Changes..\n");
            printSuperHeroes(superHeroes);     







        }//Full print out method for the heroes
        public static void printSuperHeroes(SuperHero[] superHeroes)
        {
            for(int i=0; i < superHeroes.Length; i++) 
            {
                Console.WriteLine(superHeroes[i]); ;
            }
        }
          
    }
}
