using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Krzywe
{
    class Horner
    {
        public static PointF getBezierValue(List<PointF> controlPoints, float t)
        {
            if(t < 0.5)
            {
                int n = controlPoints.Count - 1;
                float z = t / (1 - t);
                float rt = 1 - t, tn = 1;
                float bc = 1, zn = 1;  
                float tmpX = controlPoints[0].X;
                float tmpY = controlPoints[0].Y;
                for (int i = 1; i <= n; i++)
                {
                    tn *= rt;
                    zn *= z;
                    bc *= (n - i + 1) / (1.0f * i);
                    tmpX += zn * bc * controlPoints[i].X;
                    tmpY += zn * bc * controlPoints[i].Y;
                }

                return new PointF(tmpX * tn, tmpY * tn);
            } else
            {
                int n = controlPoints.Count - 1;
                float z = (1 - t) / t;
                float rt = t, tn = 1;
                float bc = 1, zn = 1;
                float tmpX = controlPoints[n].X;
                float tmpY = controlPoints[n].Y;
                for (int i = 1; i <= n; i++)
                {
                    tn *= rt;
                    zn *= z;
                    bc *= (n - i + 1) / (1.0f * i);
                    tmpX += zn * bc * controlPoints[n - i].X;
                    tmpY += zn * bc * controlPoints[n - i].Y;
                }

                return new PointF(tmpX * tn, tmpY * tn);
            }
        }
    }
}
/*function eval_horner(t) 
{ 
    
    bc = 1; tn = 1; 
    for (int i = 1; i < n; i++) 
    { 
        tn *= t; 
        bc *= (n - i + 1) / i; 
        tmp = (tmp + tn * bc * controlpoints) * u; 
    } 
    return (tmp + tn * t * controlpoints[n]);
    */