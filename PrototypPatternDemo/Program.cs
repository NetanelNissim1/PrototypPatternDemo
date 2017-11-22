using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.loadCache();

            Shape cloneShape = (Shape)ShapeCache.getShape("1");
            Console.WriteLine("Shape: "+ cloneShape.getType());

            Shape cloneShape2 = (Shape)ShapeCache.getShape("2");
            Console.WriteLine("Shape: " + cloneShape2.getType());

            Shape cloneShape3 = (Shape)ShapeCache.getShape("3");
            Console.WriteLine("Shape: " + cloneShape3.getType());

        }
    }
}
