using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;

namespace Krzywe
{
    internal class Combine
    {
        internal static CurveAbstract CombineG1(CurveAbstract c1, CurveAbstract c2)
        {
            Vector2 v1 = c1.Vectors[c1.Vectors.Count - 1];
            Vector2 v2 = c2.Vectors[1];
            PointF sndCurveThirdPoint = new PointF(c2.Vectors[0].X + c2.Vectors[1].X + c2.Vectors[2].X, c2.Vectors[0].Y + c2.Vectors[1].Y + c2.Vectors[2].Y);
            float v1norm = Convert.ToSingle(Math.Sqrt(v1.X * v1.X + v1.Y * v1.Y));
            float v2norm = Convert.ToSingle(Math.Sqrt(v2.X * v2.X + v2.Y * v2.Y));
            Vector2 v1normalized = new Vector2(v1.X / v1norm, v1.Y / v1norm);
            Vector2 v2normalized = new Vector2(v2.X / v2norm, v1.Y / v2norm);
            Vector2 commonDir = new Vector2((v1normalized.X + v2normalized.X) / 2, (v1normalized.Y + v2normalized.Y) / 2);
            List<Vector2> newVectors = new List<Vector2>();
            PointF currentPoint = new PointF(0, 0);
            for(int i = 0; i < c1.Vectors.Count - 1; i++)
            {
                newVectors.Add(c1.Vectors[i]);
                currentPoint.X += newVectors[newVectors.Count - 1].X;
                currentPoint.Y += newVectors[newVectors.Count - 1].Y;
            }
            newVectors.Add(commonDir * v1norm);
            currentPoint.X += newVectors[newVectors.Count - 1].X;
            currentPoint.Y += newVectors[newVectors.Count - 1].Y;
            newVectors.Add(commonDir * v2norm);
            currentPoint.X += newVectors[newVectors.Count - 1].X;
            currentPoint.Y += newVectors[newVectors.Count - 1].Y;
            Vector2 newThirdPoint = new Vector2(sndCurveThirdPoint.X - currentPoint.X, sndCurveThirdPoint.Y - currentPoint.Y);
            newVectors.Add(newThirdPoint);
            for (int i = 3; i < c2.Vectors.Count; i++)
            {
                newVectors.Add(c2.Vectors[i]);
            }
            return new CurveBuilder().ForColor(c1.Color).ForCurveType(Util.getCurveType(c1)).ForName("Połączona").ForVectorList(newVectors).Build();

        }
    }
}