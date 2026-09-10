//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib.Matrices
{
    /// <summary>
    /// Represents a 2x2 double matrix (2 rows, 2 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct double2x2
    {
        public double2 c0;
        public double2 c1;

        public double2x2(double m00, double m01, double m10, double m11)
        {
            c0 = new double2(m00, m10);
            c1 = new double2(m01, m11);
        }
        public double2x2(double2 c0, double2 c1) { this.c0 = c0; this.c1 = c1; }
        public double2x2(double diagonal) { c0 = new double2(diagonal, 0.0); c1 = new double2(0.0, diagonal); }
        public double2x2(double[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 2) throw new ArgumentException("Matrix must be 2x2");
            c0 = new double2(m[0, 0], m[1, 0]);
            c1 = new double2(m[0, 1], m[1, 1]);
        }

        public double2 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; } }
        }
        public double this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row == 0 ? c0.x : c0.y,
                1 => row == 0 ? c1.x : c1.y,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: if (row == 0) c0.x = value; else c0.y = value; break;
                    case 1: if (row == 0) c1.x = value; else c1.y = value; break;
                }
            }
        }

        public static double2x2 identity => new double2x2(1.0);
        public static double2x2 zero => new double2x2(0.0);

        public static double2x2 operator +(double2x2 a, double2x2 b) => new double2x2(a.c0 + b.c0, a.c1 + b.c1);
        public static double2x2 operator -(double2x2 a, double2x2 b) => new double2x2(a.c0 - b.c0, a.c1 - b.c1);
        public static double2x2 operator *(double2x2 a, double2x2 b) => mul(a, b);
        public static double2x2 operator *(double2x2 m, double s) => new double2x2(m.c0 * s, m.c1 * s);
        public static double2x2 operator *(double s, double2x2 m) => new double2x2(m.c0 * s, m.c1 * s);
        public static double2x2 operator /(double2x2 m, double s) => new double2x2(m.c0 / s, m.c1 / s);
        public static double2x2 operator -(double2x2 m) => new double2x2(-m.c0, -m.c1);
        public static double2x2 operator +(double2x2 m) => m;
        public static double2 operator *(double2x2 m, double2 v) => mul(m, v);
        public static double2 operator *(double2 v, double2x2 m) => mul(v, m);

        public static double2x2 mul(double2x2 m, double s) => m * s;
        public static double2 mul(double2x2 m, double2 v) => m.c0 * v.x + m.c1 * v.y;
        public static double2 mul(double2 v, double2x2 m) => new double2(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y);

        public static double2x2 mul(double2x2 a, double2x2 b) => new double2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y);

        public static double2x3 mul(double2x2 a, double2x3 b) => new double2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y);

        public static double2x4 mul(double2x2 a, double2x4 b) => new double2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y,
            a.c0 * b.c3.x + a.c1 * b.c3.y);

        public static double2x2 transpose(double2x2 m) => new double2x2(m.c0.x, m.c0.y, m.c1.x, m.c1.y);
        public static double determinant(double2x2 m) => m.c0.x * m.c1.y - m.c1.x * m.c0.y;
        public static double2x2 inverse(double2x2 m)
        {
            double det = determinant(m);
            if (det == 0.0) return zero;
            double invDet = 1.0 / det;
            return new double2x2(
                 m.c1.y * invDet, -m.c1.x * invDet,
                -m.c0.y * invDet, m.c0.x * invDet);
        }

        public readonly double2x2 transpose() => transpose(this);
        public readonly double determinant() => determinant(this);
        public readonly double2x2 inverse() => inverse(this);

        public static bool operator ==(double2x2 a, double2x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        public static bool operator !=(double2x2 a, double2x2 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is double2x2 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        public override readonly string ToString() => $"double2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";

        public static implicit operator double3x3(double2x2 m) => new double3x3(
            m.c0.x, m.c1.x, 0.0,
            m.c0.y, m.c1.y, 0.0,
            0.0, 0.0, 1.0);

        public static implicit operator double4x4(double2x2 m) => new double4x4(
            m.c0.x, m.c1.x, 0.0, 0.0,
            m.c0.y, m.c1.y, 0.0, 0.0,
            0.0, 0.0, 1.0, 0.0,
            0.0, 0.0, 0.0, 1.0);
    }
}
