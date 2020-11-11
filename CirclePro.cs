using System;
using System.Text;

namespace MathAppProTest
{
    public class CirclePro : ShapePro
    {
        public Double cradius { get; set; }
        public override Double shsurfaceArea() => Math.PI * cradius * cradius;
        public override Double shperimiter() => 2 * Math.PI * cradius;

        public override String ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"cradius\": " + cradius);
            sb.Append("}");

            return sb.ToString();
        }

        public override string ToString() => $"CirclePro: cradius = {cradius}";
        
    }
}
