using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalDI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lion leo = new Lion();
            //Bear br = new  Bear();
            //Elephant ele = new Elephant();
            //Squirrel sq = new Squirrel();

            //leo.Sound();
            //br.Sound();
            //ele.Sound();
            //sq.Sound();
        }
    }

    public interface IAnimal
    {
        void Sound();

    }

    public class Lion : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("ROAR!");
        }

        public void EatZebra()
        {
            Console.WriteLine("Eating zebra");
        }

       
    }

    public class Elephant : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Hurrrrreererrrreeeerrrrrrr");
        }

        public void EatFruit()
        {
            Console.WriteLine("Eating Fruit");
        }

        
    }
    public class Bear : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("GRRRROOOOOOWWLLL");
        }

        public void EatFish()
        {
            Console.WriteLine("Eating Fish");
        }

        
    }
    public class Squirrel : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine(" Snip Snip");
        }

        public void EatFish()
        {
            Console.WriteLine("Eating Nuts");
        }

        
    }

    // Main class
    public class Animals
    {
        private IAnimal _animal;

        public Animals(IAnimal animal)
        {
            _animal = animal;
        }

        public void Sound()
        {
            _animal.Sound();
        }


    }
   
    
}

