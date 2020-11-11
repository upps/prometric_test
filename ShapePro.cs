using System;

namespace MathAppProTest
{
    public abstract class ShapePro
    {
        public string Name { get; set; }
        public abstract Double shsurfaceArea();
        public abstract Double shperimiter();
       

        public abstract String ToJSON();

    }
}
