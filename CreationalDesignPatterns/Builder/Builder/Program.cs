using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder builder = new ConcreteBuilder();
            director.Construct(builder);
            Product product = builder.GetProduct();

            Console.WriteLine($"{product.Part1} / {product.Part2} / {product.Part3}");

            Console.ReadKey();
        }

        public interface IBuilder
        {
            void BuildPart1();
            void BuildPart2();
            void BuildPart3();
            Product GetProduct();
        }

        public class Product
        {
            public string Part1 { get; set; }
            public string Part2 { get; set; }
            public string Part3 { get; set; }
        }

        public class Director
        {
            public void Construct(IBuilder builder)
            {
                builder.BuildPart1();
                builder.BuildPart2();
                builder.BuildPart3();
            }
        }

        public class ConcreteBuilder : IBuilder
        {

            private Product product;


            public ConcreteBuilder()
            {
                product = new Product();
            }

            public void BuildPart1()
            {
                product.Part1 = "Part 1";
            }

            public void BuildPart2()
            {
                product.Part2 = "Part 2";
            }

            public void BuildPart3()
            {
                product.Part3 = "Part 3";
            }

            public Product GetProduct()
            {
                return product;
            }
        }

    }
}
