using System;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;

namespace Krzywe
{
    public class BezierCurve : CurveAbstract
    {
        public BezierCurve(BindingList<Vector2> vectors, Color Color, string name = "Krzywa beziera") : base(vectors, Color, name ?? "Krzywa beziera")
        {
            if(PointsToDraw == null && vectors != null)
            {
                PointsToDraw = DeCasteljau.drawCasteljau(Util.Vector2toPoints(Vectors));
            }
        }


        public override void VectorsListChangedEvent(object sender, ListChangedEventArgs e)
        {
            PointsToDraw = DeCasteljau.drawCasteljau(Util.Vector2toPoints(Vectors));
        }

        internal override Tuple<CurveAbstract, CurveAbstract> Split(string splitValue)
        {
            float u = float.Parse(splitValue);
            return DeCasteljau.SplitBezier(this, u);
        }
    }
}