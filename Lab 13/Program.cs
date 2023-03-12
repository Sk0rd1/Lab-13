using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    public class Flower
    {
        protected virtual int Price { get; set; }

        public virtual void NameOfFlower()
        {
            Console.WriteLine("Flower without name.");
        }

        public Flower()
        {
            Price = 0;
        }

        public int ResultCost(List<Flower> flowers)
        {
            int resultCost = 0;

            for(int i = 0; i < flowers.Count; i++)
            {
                resultCost += flowers[i].Price;
            }

            return resultCost;
        }
    }

    public class Rose : Flower
    {
        protected override int Price => base.Price;
        public override void NameOfFlower()
        {
            Console.WriteLine("Rose");
        }

        public Rose() 
        {
            Price = 33;
        }
    }

    public class Narcissus : Flower
    {
        protected override int Price => base.Price;
        public override void NameOfFlower() 
        {
            Console.WriteLine("Narcissus");
        }

        public Narcissus() 
        {
            Price = 18;
        }
    }

    public class Tulip : Flower
    {
        protected override int Price => base.Price;

        public override void NameOfFlower()
        {
            Console.WriteLine("Tulip");
        }

        public Tulip() 
        {
            Price = 24;
        }
    }


    internal class Program
    {

        static public List<Flower> BuyFlowers()
        {
            Console.WriteLine("Select the name of the flower:");
            Console.WriteLine("1 - Rose (=33)\n2 - Narcissus (=18)\n3 - Tulip(=24)\n4 - Exit");

            List<Flower> flowers = new List<Flower>();
            int inputAnswer;
            bool isContinue = true;

            while (isContinue)
            {
                inputAnswer = int.Parse(Console.ReadLine());

                switch (inputAnswer)
                {
                    case 1:
                        var rs = new Rose();
                        flowers.Add(rs);
                        break;
                    case 2:
                        var nr = new Narcissus();
                        flowers.Add(nr);
                        break;
                    case 3:
                        var tl = new Tulip();
                        flowers.Add(tl);
                        break;
                    case 4:
                        isContinue = false;
                        break;
                    default:
                        Console.WriteLine("Unkmown number.");
                        break;

                }
            }

            return flowers;
        }

        static void Main(string[] args)
        {
            List<Flower> flowers = BuyFlowers();

            Console.WriteLine("Result cost: " + flowers[0].ResultCost(flowers));

            Console.Read();
        }
    }
}
