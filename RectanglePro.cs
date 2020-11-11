using System;
using System.Text;

namespace MathAppProTest
{
    public class RectanglePro : ShapePro
    {
        public Double rheight { get; set; }
        public Double rwidth { get; set; }
        public Double rlength { get; set; }

        public override Double shsurfaceArea() => rheight *rwidth;
        public override Double shperimiter() => (rwidth + rlength) * 2;

        public override String ToJSON()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            sb.Append("\"rheight\": " + rheight + ",");
            sb.Append("\"rwidth\": " + rwidth + ",");
            sb.Append("\"rlength\": " + rlength);
            sb.Append("}");

            return sb.ToString();
        }

        public override string ToString() => $"RectanglePro: rheight = {rheight}, rwidth {rwidth}, rlength {rlength}";

    }
}
