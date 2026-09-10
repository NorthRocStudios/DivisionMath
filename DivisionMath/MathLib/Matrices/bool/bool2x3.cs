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
    /// Represents a 2x3 boolean matrix (2 rows, 3 columns) in column-major order.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool2x3
    {
        public bool2 c0;
        public bool2 c1;
        public bool2 c2;

        public bool2x3(bool m00, bool m01, bool m02,
                       bool m10, bool m11, bool m12)
        {
            c0 = new bool2(m00, m10);
            c1 = new bool2(m01, m11);
            c2 = new bool2(m02, m12);
        }
        public bool2x3(bool2 c0, bool2 c1, bool2 c2) { this.c0 = c0; this.c1 = c1; this.c2 = c2; }
        public bool2x3(bool value) { c0 = new bool2(value); c1 = new bool2(value); c2 = new bool2(value); }
        public bool2x3(bool[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 2x3 (2 rows, 3 columns)");
            c0 = new bool2(m[0, 0], m[1, 0]);
            c1 = new bool2(m[0, 1], m[1, 1]);
            c2 = new bool2(m[0, 2], m[1, 2]);
        }

        public bool2 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; } }
        }
        public bool this[int row, int column]
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

        public static bool2x3 off => new bool2x3(false);
        public static bool2x3 on => new bool2x3(true);

        public static bool2x3 operator !(bool2x3 m) => new bool2x3(!m.c0, !m.c1, !m.c2);

        public static bool2x3 operator &(bool2x3 a, bool2x3 b) => new bool2x3(a.c0 & b.c0, a.c1 & b.c1, a.c2 & b.c2);
        public static bool2x3 operator &(bool2x3 a, bool b) => new bool2x3(a.c0 & b, a.c1 & b, a.c2 & b);
        public static bool2x3 operator &(bool a, bool2x3 b) => new bool2x3(a & b.c0, a & b.c1, a & b.c2);

        public static bool2x3 operator |(bool2x3 a, bool2x3 b) => new bool2x3(a.c0 | b.c0, a.c1 | b.c1, a.c2 | b.c2);
        public static bool2x3 operator |(bool2x3 a, bool b) => new bool2x3(a.c0 | b, a.c1 | b, a.c2 | b);
        public static bool2x3 operator |(bool a, bool2x3 b) => new bool2x3(a | b.c0, a | b.c1, a | b.c2);

        public static bool2x3 operator ^(bool2x3 a, bool2x3 b) => new bool2x3(a.c0 ^ b.c0, a.c1 ^ b.c1, a.c2 ^ b.c2);
        public static bool2x3 operator ^(bool2x3 a, bool b) => new bool2x3(a.c0 ^ b, a.c1 ^ b, a.c2 ^ b);
        public static bool2x3 operator ^(bool a, bool2x3 b) => new bool2x3(a ^ b.c0, a ^ b.c1, a ^ b.c2);

        public static bool2x3 operator ==(bool2x3 a, bool2x3 b) => new bool2x3(a.c0 == b.c0, a.c1 == b.c1, a.c2 == b.c2);
        public static bool2x3 operator !=(bool2x3 a, bool2x3 b) => new bool2x3(a.c0 != b.c0, a.c1 != b.c1, a.c2 != b.c2);
        public static bool2x3 operator ==(bool2x3 a, bool b) => new bool2x3(a.c0 == b, a.c1 == b, a.c2 == b);
        public static bool2x3 operator !=(bool2x3 a, bool b) => new bool2x3(a.c0 != b, a.c1 != b, a.c2 != b);
        public static bool2x3 operator ==(bool a, bool2x3 b) => new bool2x3(a == b.c0, a == b.c1, a == b.c2);
        public static bool2x3 operator !=(bool a, bool2x3 b) => new bool2x3(a != b.c0, a != b.c1, a != b.c2);

        public static bool3x2 transpose(bool2x3 m) => new bool3x2(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y,
            m.c2.x, m.c2.y);
        public readonly bool3x2 transpose() => transpose(this);

        public readonly bool all => c0.all && c1.all && c2.all;
        public readonly bool any => c0.any || c1.any || c2.any;

        public override readonly bool Equals(object? obj) => obj is bool2x3 o && (c0 == o.c0).all && (c1 == o.c1).all && (c2 == o.c2).all;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        public override readonly string ToString() => $"bool2x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y})";

        public static implicit operator bool3x3(bool2x3 m) => new bool3x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            false, false, true);
    }
}
