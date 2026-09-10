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
    /// Represents a 2x3 double matrix (2 rows, 3 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct double2x3
    {
        public double2 c0;
        public double2 c1;
        public double2 c2;

        public double2x3(double m00, double m01, double m02,
                         double m10, double m11, double m12)
        {
            c0 = new double2(m00, m10);
            c1 = new double2(m01, m11);
            c2 = new double2(m02, m12);
        }
        public double2x3(double2 c0, double2 c1, double2 c2) { this.c0 = c0; this.c1 = c1; this.c2 = c2; }
        public double2x3(double[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 2x3 (2 rows, 3 columns)");
            c0 = new double2(m[0, 0], m[1, 0]);
            c1 = new double2(m[0, 1], m[1, 1]);
            c2 = new double2(m[0, 2], m[1, 2]);
        }

        public double2 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; } }
        }
        public double this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row == 0 ? c0.x : c0.y,
                1 => row == 0 ? c1.x : c1.y,
                2 => row == 0 ? c2.x : c2.y,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: if (row == 0) c0.x = value; else c0.y = value; break;
                    case 1: if (row == 0) c1.x = value; else c1.y = value; break;
                    case 2: if (row == 0) c2.x = value; else c2.y = value; break;
                }
            }
        }

        public static double2x3 zero => new double2x3(0.0, 0.0, 0.0, 0.0, 0.0, 0.0);

        public static double2x3 operator +(double2x3 a, double2x3 b) => new double2x3(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        public static double2x3 operator -(double2x3 a, double2x3 b) => new double2x3(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        public static double2x3 operator *(double2x3 m, double s) => new double2x3(m.c0 * s, m.c1 * s, m.c2 * s);
        public static double2x3 operator *(double s, double2x3 m) => new double2x3(m.c0 * s, m.c1 * s, m.c2 * s);
        public static double2x3 operator /(double2x3 m, double s) => new double2x3(m.c0 / s, m.c1 / s, m.c2 / s);
        public static double2x3 operator -(double2x3 m) => new double2x3(-m.c0, -m.c1, -m.c2);
        public static double2x3 operator +(double2x3 m) => m;
        public static double2 operator *(double2x3 m, double3 v) => mul(m, v);
        public static double3 operator *(double2 v, double2x3 m) => mul(v, m);

        public static double2x3 mul(double2x3 m, double s) => m * s;
        public static double2 mul(double2x3 m, double3 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z;
        public static double3 mul(double2 v, double2x3 m) => new double3(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y,
            v.x * m.c2.x + v.y * m.c2.y);

        public static double2x2 mul(double2x3 a, double3x2 b) => new double2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        public static double2x3 mul(double2x3 a, double3x3 b) => new double2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        public static double2x4 mul(double2x3 a, double3x4 b) => new double2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);

        public static double3x2 transpose(double2x3 m) => new double3x2(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y,
            m.c2.x, m.c2.y);

        public readonly double3x2 transpose() => transpose(this);

        public static bool operator ==(double2x3 a, double2x3 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        public static bool operator !=(double2x3 a, double2x3 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is double2x3 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        public override readonly string ToString() => $"double2x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y})";

        public static implicit operator double3x3(double2x3 m) => new double3x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            0.0, 0.0, 1.0);
    }
}
