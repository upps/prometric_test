using System;
using System.Text;

namespace MathAppProTest
{
    public class TrianglePro : ShapePro
    {
        public Double sideA { get; set; }
        public Double sideB { get; set; }
        public Double sideC { get; set; }
        public Double theight { get; set; }
        public Double tbase { get; set; }

        public override double shperimiter() => sideA + sideB + sideC;

        public override double shsurfaceArea() => theight * tbase / 2;

        public override String ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"sideA\": " + sideA + ",");
            sb.Append("\"sideB\": " + sideB + ",");
            sb.Append("\"sideC\": " + sideC + ",");
            sb.Append("\"theight\": " + theight + ",");
            sb.Append("\"tbase\": " + tbase);
            sb.Append("}");

            return sb.ToString();
        }

        public override string ToString()
        {
           return $"TrianglePro: sideA = {sideA}, sideB = {sideB}, sideC + {sideC}, theight = {theight}, tbase = {tbase}";
        }
    }
}
