using System;
using System.Collections.Generic;
using static System.Console;

namespace Factories_Method
{
    public interface IAnimal
    {
        void AboutMe();
    }

    public class Lion : IAnimal
    {
        public void AboutMe() => WriteLine("This is a Lion");

    }

    public class Tiger : IAnimal
    {
        public void AboutMe() => WriteLine("This is a Tiger");

    }

    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }

    public class LionFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Lion();
    }

    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Factory Method Pattern Demo.***\n");
            List<AnimalFactory> animalFactoryList = new List<AnimalFactory>
            {
                new TigerFactory(),
                new LionFactory()
            };

            foreach (var animalFactory in animalFactoryList)
            {
                animalFactory.CreateAnimal().AboutMe();

            }
            ReadLine();
        }
    }
}
