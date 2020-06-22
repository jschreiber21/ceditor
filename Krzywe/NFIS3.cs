using Extreme.Mathematics.Curves;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;

namespace Krzywe
{
    public class NFIS3 : CurveAbstract
    {
        public NFIS3(BindingList<Vector2> vectors, Color Color, string name = "Krzywa sklejana") : base(vectors, Color, name ?? "Krzywa sklejana") { }

        public override void VectorsListChangedEvent(object sender, ListChangedEventArgs e)
        {
            if(Vectors.Count == 1)
            {
                PointsToDraw = new List<PointF>() { new PointF(Vectors[0].X, Vectors[0].Y), new PointF(Vectors[0].X, Vectors[0].Y) };
                return;
            }
            PointsToDraw = new List<PointF>();
            List<PointF> points = Util.Vector2toPoints(Vectors);
            List<float> m = calculateM(points);
            PointsToDraw.Add(points[0]);
            for (int i = 1; i < points.Count; i++)
            {
                PointsToDraw.AddRange(generateNFIS3(points[i - 1], points[i], m, i));
            }
        }

        private List<float> calculateM(List<PointF> points)
        {
            int n = points.Count - 1;
            List<float> m = new List<float>(new float[n + 1]);
            List<float> q = new List<float>(new float[n + 1]);
            List<float> u = new List<float>(new float[n + 1]);
            List<float> p = new List<float>(new float[n + 1]);
            for (int k = 1; k < points.Count - 1; k++)
            {
                float hk = points[k].X - points[k - 1].X;
                float hk1 = points[k + 1].X - points[k].X;
                float alpha = hk / (hk + hk1);
                float dk = (points[k + 1].Y - points[k].Y) / ((points[k + 1].X - points[k].X) * (points[k + 1].X - points[k - 1].X)) -
                    (points[k].Y - points[k - 1].Y) / ((points[k].X - points[k - 1].X) * (points[k + 1].X - points[k - 1].X));
                p[k] = alpha * q[k - 1] + 2;
                q[k] = (alpha - 1) / p[k];
                u[k] = (dk - alpha * u[k - 1])
                    / p[k];


            }
            m[n - 1] = u[n - 1];
            for (int k = n - 2; k >= 0; k--) {
                m[k] = u[k] + q[k] * m[k + 1];
            }
            return m;
        }

        private List<PointF> generateNFIS3(PointF p1, PointF p2, List<float> m, int it)
        {
            List<PointF> generatedPoints = new List<PointF>();
            for (float i = 0.001f; i <= 1.0f; i += 0.001f) {
                float x = p1.X + (p2.X - p1.X) * i;
                generatedPoints.Add(new PointF(x, solveEquations(p1, p2, x, m, it)));
            }
            return generatedPoints;
        }

        private float solveEquations(PointF p1, PointF p2, float x, List<float> m, int k)
        {
            float hk = p2.X - p1.X;
            return (m[k-1] * (p2.X - x) * (p2.X - x) * (p2.X - x ) / 6 
                + m[k] * (x - p1.X) * (x - p1.X) * (x - p1.X) / 6 
                + (p1.Y - m[k-1] * hk * hk / 6) * (p2.X - x) 
                + (p2.Y - m[k] * hk * hk / 6) * (x - p1.X)) / hk;
/*            return m[it] / (6 * hk) * (v2.X - x) * (v2.X - x) * (v2.X - x) 
                + m[it + 1] / (6 * hk) * (x - v1.X) * (x - v1.X) * (x - v1.X) + (v1.Y / hk - m[it] * hk / 6) * (v2.X - x) + (v2.Y / hk - m[it + 1] * hk / 6) * (x - v2.X);*/
        }

        internal override Tuple<CurveAbstract, CurveAbstract> Split(string splitValue)
        {
            throw new NotImplementedException();
        }
    }
}
/*
((points[k + 1].Y - points[k].Y) / ((points[k + 1].X - points[k].X) * (points[k + 1].X - points[k - 1].X)) - 
                    (points[k].Y - points[k - 1].Y) / ((points[k].X - points[k - 1].X) * (points[k + 1].X - points[k - 1].X)) */