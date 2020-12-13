using BuildPattern.Products;
using System;

namespace BuildPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Director productDirector = new Director();

            BagBuilder productBuilderA = new BagBuilder();
            productDirector.Construct(productBuilderA);
            Product product1 = productBuilderA.GetProduct();
            Console.WriteLine("{0}", product1);
            Console.WriteLine("===============================\n");
            
            BookBuilder productBuilderB = new BookBuilder();
            productDirector.Construct(productBuilderB);
            Product product2 = productBuilderB.GetProduct();
            Console.WriteLine("{0}", product2);
            Console.WriteLine("===============================");
        }
    }
}
