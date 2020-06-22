using System.Drawing;
using System.Collections.Generic;
using System;
using System.Numerics;
using System.ComponentModel;

namespace Krzywe
{
    public class DeCasteljau
    {
        public static List<PointF> drawCasteljau(List<PointF> controlPoints)
        {
            List<PointF> bezierCurve = new List<PointF>();
            
            for (float t = 0; t <= 1; t += 0.001f)
            {
                bezierCurve.Add(getCasteljauPoint(controlPoints, t));
            }
            return bezierCurve;
        }


        private static PointF getCasteljauPoint(List<PointF> controlPoints, float u)
        {
            int n = controlPoints.Count - 1;
            PointF[][] calculatedCasteljauPoints = new PointF[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                calculatedCasteljauPoints[i] = new PointF[n - i + 1];
                calculatedCasteljauPoints[0][i] = controlPoints[i];
            }
            for (int k = 1; k <= n; k++)
            {
                for (int i = 0; i <= n - k; i++)
                {
                    calculatedCasteljauPoints[k][i] = new PointF((1 - u) * calculatedCasteljauPoints[k - 1][i].X + u * calculatedCasteljauPoints[k - 1][i + 1].X, (1 - u) * calculatedCasteljauPoints[k - 1][i].Y + u * calculatedCasteljauPoints[k - 1][i + 1].Y);
                }
            }
            return calculatedCasteljauPoints[n][0];

        }

        internal static List<PointF> drawRationalCasteljau(List<PointF> controlPoints, List<float> weights)
        {
            List<PointF> bezierCurve = new List<PointF>();

            for (float t = 0; t <= 1; t += 0.001f)
            {
                bezierCurve.Add(getRationalCasteljauPoint(controlPoints, weights, t));
            }
            return bezierCurve;
        }


        private static PointF getRationalCasteljauPoint(List<PointF> controlPoints, List<float> weights, float u)
        {

            int n = controlPoints.Count - 1;
            PointF[][] calculatedCasteljauPoints = new PointF[n + 1][];
            float[][] w = new float[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                calculatedCasteljauPoints[i] = new PointF[n - i + 1];
                w[i] = new float[n - i + 1];
                calculatedCasteljauPoints[0][i] = new PointF(controlPoints[i].X, controlPoints[i].Y);
                w[0][i] = weights[i];
            }
            for (int k = 1; k <= n; k++)
            {
                for (int i = 0; i <= n - k; i++)
                {
                    w[k][i] = (1 - u) * w[k - 1][i] + u * w[k - 1][i + 1];
                    calculatedCasteljauPoints[k][i] = new PointF((1 - u) * calculatedCasteljauPoints[k - 1][i].X * w[k - 1][i] / w[k][i] + u * calculatedCasteljauPoints[k - 1][i + 1].X * w[k - 1][i + 1] / w[k][i]
                        , (1 - u) * calculatedCasteljauPoints[k - 1][i].Y * w[k - 1][i] / w[k][i] + u * calculatedCasteljauPoints[k - 1][i + 1].Y * w[k - 1][i + 1] / w[k][i]);
                }
            }
            return calculatedCasteljauPoints[n][0];

        }

        public static Tuple<CurveAbstract, CurveAbstract> SplitBezier(BezierCurve originalCurve, float u)
        {
            List<PointF> controlPoints = Util.Vector2toPoints(originalCurve.Vectors);
            int n = controlPoints.Count - 1;
            PointF[][] calculatedCasteljauPoints = new PointF[n + 1][];
            for (int i = 0; i <= n; i++)
            {
                calculatedCasteljauPoints[i] = new PointF[n - i + 1];
                calculatedCasteljauPoints[0][i] = controlPoints[i];
            }
            for (int k = 1; k <= n; k++)
            {
                for (int i = 0; i <= n - k; i++)
                {
                    calculatedCasteljauPoints[k][i] = new PointF((1 - u) * calculatedCasteljauPoints[k - 1][i].X + u * calculatedCasteljauPoints[k - 1][i + 1].X, (1 - u) * calculatedCasteljauPoints[k - 1][i].Y + u * calculatedCasteljauPoints[k - 1][i + 1].Y);
                }
            }
            List<PointF> b1Points = new List<PointF>();
            List<PointF> b2Points = new List<PointF>();
            for(int i = 0; i <= n; i++)
            {
                b1Points.Add(calculatedCasteljauPoints[i][0]);
                b2Points.Add(calculatedCasteljauPoints[n - i][i]);
            }
            CurveAbstract b1 = new CurveBuilder().ForCurveType(CurveType.BezierCurve).ForColor(originalCurve.Color).ForName(originalCurve.Name + " (1)").ForVectorList(Util.PointsToVector2(b1Points)).Build();
            CurveAbstract b2 = new CurveBuilder().ForCurveType(CurveType.BezierCurve).ForColor(originalCurve.Color).ForName(originalCurve.Name + " (2)").ForVectorList(Util.PointsToVector2(b2Points)).Build();

            return Tuple.Create(b1, b2);

        }

        public static List<Vector2> ElevateDegree(BindingList<Vector2> oldCurve)
        {
            int n = oldCurve.Count;
            List<PointF> newPoints = new List<PointF>(n + 1);
            List<PointF> points = Util.Vector2toPoints(oldCurve);
            newPoints.Add(points[0]);
            for(int i = 1; i < n; i++)
            {
                double k = 1.0 * i / (n + 1);
                double l = 1 - 1.0 * i / (n + 1);
                double x = k * points[i - 1].X + l * points[i].X;
                double y = k * points[i - 1].Y + l * points[i].Y;
                newPoints.Add(new PointF(Convert.ToSingle(x), Convert.ToSingle(y)));
            }
            newPoints.Add(points[n - 1]);
            return Util.PointsToVector2(newPoints);
        }

        internal static List<Vector2> DecreaseDegree(BindingList<Vector2> oldCurve)
        {
            int n = oldCurve.Count;
            List<PointF> points = Util.Vector2toPoints(oldCurve);
            List<PointF> W1 = new List<PointF>();
            List<PointF> W2 = new List<PointF>();
            W1.Add(points[0]);
            W2.Add(points[points.Count - 1]);
            for(int k = 1; k < n/2; k++)
            {
                double a = 1 + 1.0 * k / (n - k);
                double b = 1.0 * k / (n - k);
                W1.Add(new PointF(Convert.ToSingle(points[k].X * a - W1[k - 1].X * b), Convert.ToSingle(points[k].Y * a - W1[k - 1].Y * b)));
            }
            for (int k = n - 2; k >= n / 2; k--)
            {
                double a = 1.0 * n / k;
                double b = 1 - 1.0 * n / k;
                W2.Add(new PointF(Convert.ToSingle(points[k].X * a + W2[W2.Count - 1].X * b), Convert.ToSingle(points[k].Y * a + W2[W2.Count - 1].Y * b)));
            }
            List < PointF > newPoints = new List<PointF>();
            for(int i = 0; i < W1.Count - 1; i++)
            {
                newPoints.Add(W1[i]);
            }
            newPoints.Add(new PointF((W1[W1.Count - 1].X + W2[W2.Count - 1].X) / 2, (W1[W1.Count - 1].Y + W2[W2.Count - 1].Y) / 2));
            for (int i = W2.Count - 2; i >= 0; i--)
            {
                newPoints.Add(W2[i]);
            }
            return Util.PointsToVector2(newPoints);
        }
    }
}
