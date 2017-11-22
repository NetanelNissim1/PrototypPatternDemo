using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypPatternDemo
{
   public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string,Shape>();

        public static Shape getShape(string shapeId)
        {
            shapeMap.TryGetValue(shapeId,out Shape cacheShape);
            return (Shape)cacheShape.Clone();
        }

        public static void loadCache()
        {
            var circle = new Circle();
            circle.setId("1");
            shapeMap.Add(circle.getId(), circle);

            var square = new Square();
            square.setId("2");
            shapeMap.Add(square.getId(), square);

            var rectangle = new Rectangle();
            rectangle.setId("3");
            shapeMap.Add(rectangle.getId(), rectangle);
        }
    }
}
