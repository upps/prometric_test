using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MathAppProTest
{
    class CollectionPro
    {
        static void Main(string[] args)
        {
            

            List<ShapePro> shapes = GetShapes();

            Console.WriteLine("Order by Perimeter:");
            shapes = shapes.OrderBy(shape => shape.shperimiter()).ToList();
            Print(shapes);

            Console.WriteLine("Order by Surface Area:");
            shapes = shapes.OrderBy(shape => shape.shsurfaceArea()).ToList();
            Print(shapes);

            GetTypes(shapes);

        }

        public static void Print(List<ShapePro> shapes)
        {
            Console.WriteLine("Total number of Shapes: " + shapes.Count);

            foreach (var shape in shapes)
                Console.WriteLine(shape);        
        }

       

        public static void GetTypes(List<ShapePro> shapes)
        {
            int cirProCount = 0;
            int rectProCount = 0;
            int sqProCount = 0;
            int triProCount = 0;
           
            

            foreach (var shape in shapes)
            {
                if (shape is CirclePro) cirProCount++;
                if (shape is RectanglePro) rectProCount++;
                if (shape is SquarePro) sqProCount++;
                if (shape is TrianglePro) triProCount++;
                
                
            }
            Console.WriteLine($"CirclePro: {cirProCount}, RectanglePro {rectProCount}, " +
                    $"SquarePro: {sqProCount},TrianglePro: {triProCount} ");
        }

        public static List<ShapePro> GetShapes()
        {
            var shapes = new List<ShapePro>();

            CirclePro c = new CirclePro{ cradius = 10};
            RectanglePro r = new RectanglePro
            {
                rwidth = 10,
                rheight = 20
            };
            SquarePro s = new SquarePro
            {
                sqwidth = 10,
                sqheight = 20
            };
            TrianglePro t = new TrianglePro
            {
                sideA = 10,
                sideB = 20,
                sideC = 30,
                theight = 40,
                tbase = 50
            };
            

            shapes.Add(c);
            shapes.Add(r);
            shapes.Add(s);
            shapes.Add(t);
           

            return shapes;
        }
    }
}
