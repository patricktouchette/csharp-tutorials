using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SOLID_Design_Principles
{
    public enum Color
    {
        Red, Green ,Blue
    }

    public enum Size
    {
        Small, Medium, Large, Huge
    }

    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products,
            Size size)
        {
            foreach (var p in products)
                if (p.Size == size)
                    yield return p;
        }

        public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products,
            Color color)
        {
            foreach (var p in products)
                if (p.Color == color)
                    yield return p;
        }
    }

    public class OpenClosedPrinciple
    {
        public OpenClosedPrinciple()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new ProductFilter();
            Console.WriteLine("Green Products (old):");

        }
    }
}
