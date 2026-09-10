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
    /// Represents a 3x2 boolean matrix (3 rows, 2 columns) in column-major order.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool3x2
    {
        public bool3 c0;
        public bool3 c1;

        public bool3x2(bool m00, bool m01,
                       bool m10, bool m11,
                       bool m20, bool m21)
        {
            c0 = new bool3(m00, m10, m20);
            c1 = new bool3(m01, m11, m21);
        }
        public bool3x2(bool3 c0, bool3 c1) { this.c0 = c0; this.c1 = c1; }
        public bool3x2(bool value) { c0 = new bool3(value); c1 = new bool3(value); }
        public bool3x2(bool[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 3x2 (3 rows, 2 columns)");
            c0 = new bool3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new bool3(m[0, 1], m[1, 1], m[2, 1]);
        }

        public bool3 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; } }
        }
        public bool this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; } break;
                    case 1: switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; } break;
                }
            }
        }

        public static bool3x2 off => new bool3x2(false);
        public static bool3x2 on => new bool3x2(true);

        public static bool3x2 operator !(bool3x2 m) => new bool3x2(!m.c0, !m.c1);

        public static bool3x2 operator &(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 & b.c0, a.c1 & b.c1);
        public static bool3x2 operator &(bool3x2 a, bool b) => new bool3x2(a.c0 & b, a.c1 & b);
        public static bool3x2 operator &(bool a, bool3x2 b) => new bool3x2(a & b.c0, a & b.c1);

        public static bool3x2 operator |(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 | b.c0, a.c1 | b.c1);
        public static bool3x2 operator |(bool3x2 a, bool b) => new bool3x2(a.c0 | b, a.c1 | b);
        public static bool3x2 operator |(bool a, bool3x2 b) => new bool3x2(a | b.c0, a | b.c1);

        public static bool3x2 operator ^(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 ^ b.c0, a.c1 ^ b.c1);
        public static bool3x2 operator ^(bool3x2 a, bool b) => new bool3x2(a.c0 ^ b, a.c1 ^ b);
        public static bool3x2 operator ^(bool a, bool3x2 b) => new bool3x2(a ^ b.c0, a ^ b.c1);

        public static bool3x2 operator ==(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 == b.c0, a.c1 == b.c1);
        public static bool3x2 operator !=(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 != b.c0, a.c1 != b.c1);
        public static bool3x2 operator ==(bool3x2 a, bool b) => new bool3x2(a.c0 == b, a.c1 == b);
        public static bool3x2 operator !=(bool3x2 a, bool b) => new bool3x2(a.c0 != b, a.c1 != b);
        public static bool3x2 operator ==(bool a, bool3x2 b) => new bool3x2(a == b.c0, a == b.c1);
        public static bool3x2 operator !=(bool a, bool3x2 b) => new bool3x2(a != b.c0, a != b.c1);

        public static bool2x3 transpose(bool3x2 m) => new bool2x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z);
        public readonly bool2x3 transpose() => transpose(this);

        public readonly bool all => c0.all && c1.all;
        public readonly bool any => c0.any || c1.any;

        public override readonly bool Equals(object? obj) => obj is bool3x2 o && (c0 == o.c0).all && (c1 == o.c1).all;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        public override readonly string ToString() => $"bool3x2({c0.x}, {c1.x},  {c0.y}, {c1.y},  {c0.z}, {c1.z})";

        public static implicit operator bool3x3(bool3x2 m) => new bool3x3(
            m.c0.x, m.c1.x, false,
            m.c0.y, m.c1.y, false,
            m.c0.z, m.c1.z, true);
    }

}
