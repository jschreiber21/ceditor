using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Numerics;

namespace Krzywe
{
    class CurveBuilder
    {
        CurveType CurveType;
        Color Color;
        BindingList<Vector2> Vectors;
        String Name;
        internal CurveBuilder ForCurveType(CurveType curveType)
        {
            this.CurveType = curveType;
            return this;
        }


        internal CurveBuilder() { }

        internal CurveAbstract Build()
        {
            switch (CurveType){
                case CurveType.BezierCurve: 
                {
                    return new BezierCurve(Vectors, Color, Name);
                }
                case CurveType.PolynomialCurve:
                {
                        return new PolynomialCurve(Vectors, Color, Name);
                }
                case CurveType.RationalBezier:
                    {
                        return new RationalBezier(Vectors, Color, Name);
                    }
                case CurveType.NFIS3:
                    {
                        return new NFIS3(Vectors, Color, Name);
                    }
            }
            throw new NotImplementedException();
        }

        internal CurveBuilder ForColor(Color color)
        {
            this.Color = color;
            return this;
        }

        internal CurveBuilder ForVectorList(BindingList<Vector2> vectors)
        {
            this.Vectors = new BindingList<Vector2>(vectors.Select(v => new Vector2(v.X, v.Y)).ToList());
            return this;
        }

        internal CurveBuilder ForVectorList(List<Vector2> vectors)
        {
            this.Vectors = new BindingList<Vector2>(vectors.Select(v => new Vector2(v.X, v.Y)).ToList());
            return this;
        }

        internal CurveBuilder ForName(string Name)
        {
            this.Name = Name;
                return this;
        }
    }
}