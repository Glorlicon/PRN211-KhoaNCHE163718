using System;

namespace Prototype_Pattern
{
    public abstract class Car
    {
        protected int basePrice = 0, onRoadPrice = 0;
        public string modelName { get; set; }
        public int BasePrice
        {
           set => basePrice = value;
            get => basePrice;
        }
        public int OnRoadPrice
        {
            set => onRoadPrice = value;
            get => onRoadPrice;
        }
        public static int SetAdditionalPrice()
        {
            Random random = new Random();
            int AdditionalPrice = random.Next(200_000, 500_000);
            return AdditionalPrice;
        }
        public abstract Car Clone();
    }

    public class Mustang : Car
    {
        public Mustang(string model)=>(modelName, basePrice) = (model, 200_000);
        public override Car Clone()=>this.MemberwiseClone() as Mustang;
    }
    public class Bentley : Car
    {
        public Bentley(string model)=>(modelName, BasePrice) = (model, 300_000);
        public override Car Clone()=>this.MemberwiseClone() as Bentley;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo***\n");

            Car Mustang = new Mustang("Mustang EcoBoost");
            Car Bentley = new Bentley("Continental GT Mulliner");

            Console.WriteLine($"Car is: {Mustang.modelName}, and it's base price is Rs. {Mustang.BasePrice} ");
            Console.WriteLine($"Car is: {Bentley.modelName}, and it's base price is Rs. {Bentley.BasePrice} ");

            Car Car;
            Car = Mustang.Clone();
            Car.OnRoadPrice = Car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {Mustang.modelName}, and it's base price is Rs. {Mustang.BasePrice} ");

            Car = Bentley.Clone();
            Car.OnRoadPrice = Car.BasePrice + Car.SetAdditionalPrice();
            Console.WriteLine($"Car is: {Bentley.modelName}, and it's base price is Rs. {Bentley.BasePrice} ");
            Console.ReadLine();
        }
    }
}
