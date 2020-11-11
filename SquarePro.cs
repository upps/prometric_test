using System;
using System.Text;

namespace MathAppProTest
{
    public class SquarePro : ShapePro
    {
        public Double sqheight { get; set; }
        public Double sqwidth { get; set; }
        public Double sqlength { get; set; }

        public override Double shsurfaceArea() => sqheight * sqwidth;
        public override Double shperimiter() => (sqwidth + sqlength) * 2;

        public override String ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"sqheight\": " + sqheight + ",");
            sb.Append("\"sqwidth\": " + sqwidth + ",");
            sb.Append("\"sqlength\": " + sqlength);
            sb.Append("}");

            return sb.ToString();
        }

        public override string ToString() => $"SquarePro: sqheight = {sqheight}, sqwidth {sqwidth}, sqlength {sqlength}";
    }
}
