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
    /// Represents a 2x2 boolean matrix (2 rows, 2 columns) in column-major order.
    /// </summary>
    /// <remarks>Typically produced by element-wise comparison of numeric matrices.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool2x2
    {
        public bool2 c0;
        public bool2 c1;

        public bool2x2(bool m00, bool m01, bool m10, bool m11)
        {
            c0 = new bool2(m00, m10);
            c1 = new bool2(m01, m11);
        }
        public bool2x2(bool2 c0, bool2 c1) { this.c0 = c0; this.c1 = c1; }
        public bool2x2(bool value) { c0 = new bool2(value); c1 = new bool2(value); }
        public bool2x2(bool[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 2) throw new ArgumentException("Matrix must be 2x2");
            c0 = new bool2(m[0, 0], m[1, 0]);
            c1 = new bool2(m[0, 1], m[1, 1]);
        }

        public bool2 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; } }
        }
        public bool this[int row, int column]
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

        public static bool2x2 off => new bool2x2(false);
        public static bool2x2 on => new bool2x2(true);

        public static bool2x2 operator !(bool2x2 m) => new bool2x2(!m.c0, !m.c1);

        public static bool2x2 operator &(bool2x2 a, bool2x2 b) => new bool2x2(a.c0 & b.c0, a.c1 & b.c1);
        public static bool2x2 operator &(bool2x2 a, bool b) => new bool2x2(a.c0 & b, a.c1 & b);
        public static bool2x2 operator &(bool a, bool2x2 b) => new bool2x2(a & b.c0, a & b.c1);

        public static bool2x2 operator |(bool2x2 a, bool2x2 b) => new bool2x2(a.c0 | b.c0, a.c1 | b.c1);
        public static bool2x2 operator |(bool2x2 a, bool b) => new bool2x2(a.c0 | b, a.c1 | b);
        public static bool2x2 operator |(bool a, bool2x2 b) => new bool2x2(a | b.c0, a | b.c1);

        public static bool2x2 operator ^(bool2x2 a, bool2x2 b) => new bool2x2(a.c0 ^ b.c0, a.c1 ^ b.c1);
        public static bool2x2 operator ^(bool2x2 a, bool b) => new bool2x2(a.c0 ^ b, a.c1 ^ b);
        public static bool2x2 operator ^(bool a, bool2x2 b) => new bool2x2(a ^ b.c0, a ^ b.c1);

        public static bool2x2 operator ==(bool2x2 a, bool2x2 b) => new bool2x2(a.c0 == b.c0, a.c1 == b.c1);
        public static bool2x2 operator !=(bool2x2 a, bool2x2 b) => new bool2x2(a.c0 != b.c0, a.c1 != b.c1);
        public static bool2x2 operator ==(bool2x2 a, bool b) => new bool2x2(a.c0 == b, a.c1 == b);
        public static bool2x2 operator !=(bool2x2 a, bool b) => new bool2x2(a.c0 != b, a.c1 != b);
        public static bool2x2 operator ==(bool a, bool2x2 b) => new bool2x2(a == b.c0, a == b.c1);
        public static bool2x2 operator !=(bool a, bool2x2 b) => new bool2x2(a != b.c0, a != b.c1);

        public static bool2x2 transpose(bool2x2 m) => new bool2x2(m.c0.x, m.c0.y, m.c1.x, m.c1.y);
        public readonly bool2x2 transpose() => transpose(this);

        public readonly bool all => c0.all && c1.all;
        public readonly bool any => c0.any || c1.any;

        public override readonly bool Equals(object? obj) => obj is bool2x2 o && (c0 == o.c0).all && (c1 == o.c1).all;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        public override readonly string ToString() => $"bool2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";

        public static implicit operator bool3x3(bool2x2 m) => new bool3x3(
            m.c0.x, m.c1.x, false,
            m.c0.y, m.c1.y, false,
            false, false, true);

        public static implicit operator bool4x4(bool2x2 m) => new bool4x4(
            m.c0.x, m.c1.x, false, false,
            m.c0.y, m.c1.y, false, false,
            false, false, true, false,
            false, false, false, true);
    }
}
