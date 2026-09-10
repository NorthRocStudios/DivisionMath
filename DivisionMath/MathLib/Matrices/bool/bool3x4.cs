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
    /// Represents a 3x4 boolean matrix (3 rows, 4 columns) in column-major order.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool3x4
    {
        public bool3 c0;
        public bool3 c1;
        public bool3 c2;
        public bool3 c3;

        public bool3x4(bool m00, bool m01, bool m02, bool m03,
                       bool m10, bool m11, bool m12, bool m13,
                       bool m20, bool m21, bool m22, bool m23)
        {
            c0 = new bool3(m00, m10, m20);
            c1 = new bool3(m01, m11, m21);
            c2 = new bool3(m02, m12, m22);
            c3 = new bool3(m03, m13, m23);
        }
        public bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        public bool3x4(bool value) { c0 = new bool3(value); c1 = new bool3(value); c2 = new bool3(value); c3 = new bool3(value); }
        public bool3x4(bool[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 4)
                throw new ArgumentException("Matrix must be 3x4 (3 rows, 4 columns)");
            c0 = new bool3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new bool3(m[0, 1], m[1, 1], m[2, 1]);
            c2 = new bool3(m[0, 2], m[1, 2], m[2, 2]);
            c3 = new bool3(m[0, 3], m[1, 3], m[2, 3]);
        }

        public bool3 this[int column]
        {
            readonly get => column switch
            {
                0 => c0,
                1 => c1,
                2 => c2,
                3 => c3,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: c0 = value; break;
                    case 1: c1 = value; break;
                    case 2: c2 = value; break;
                    case 3: c3 = value; break;
                }
            }
        }
        public bool this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, _ => throw new IndexOutOfRangeException() },
                3 => row switch { 0 => c3.x, 1 => c3.y, 2 => c3.z, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; } break;
                    case 1: switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; } break;
                    case 2: switch (row) { case 0: c2.x = value; break; case 1: c2.y = value; break; case 2: c2.z = value; break; } break;
                    case 3: switch (row) { case 0: c3.x = value; break; case 1: c3.y = value; break; case 2: c3.z = value; break; } break;
                }
            }
        }

        public static bool3x4 off => new bool3x4(false);
        public static bool3x4 on => new bool3x4(true);

        public static bool3x4 operator !(bool3x4 m) => new bool3x4(!m.c0, !m.c1, !m.c2, !m.c3);

        public static bool3x4 operator &(bool3x4 a, bool3x4 b) => new bool3x4(a.c0 & b.c0, a.c1 & b.c1, a.c2 & b.c2, a.c3 & b.c3);
        public static bool3x4 operator &(bool3x4 a, bool b) => new bool3x4(a.c0 & b, a.c1 & b, a.c2 & b, a.c3 & b);
        public static bool3x4 operator &(bool a, bool3x4 b) => new bool3x4(a & b.c0, a & b.c1, a & b.c2, a & b.c3);

        public static bool3x4 operator |(bool3x4 a, bool3x4 b) => new bool3x4(a.c0 | b.c0, a.c1 | b.c1, a.c2 | b.c2, a.c3 | b.c3);
        public static bool3x4 operator |(bool3x4 a, bool b) => new bool3x4(a.c0 | b, a.c1 | b, a.c2 | b, a.c3 | b);
        public static bool3x4 operator |(bool a, bool3x4 b) => new bool3x4(a | b.c0, a | b.c1, a | b.c2, a | b.c3);

        public static bool3x4 operator ^(bool3x4 a, bool3x4 b) => new bool3x4(a.c0 ^ b.c0, a.c1 ^ b.c1, a.c2 ^ b.c2, a.c3 ^ b.c3);
        public static bool3x4 operator ^(bool3x4 a, bool b) => new bool3x4(a.c0 ^ b, a.c1 ^ b, a.c2 ^ b, a.c3 ^ b);
        public static bool3x4 operator ^(bool a, bool3x4 b) => new bool3x4(a ^ b.c0, a ^ b.c1, a ^ b.c2, a ^ b.c3);

        public static bool3x4 operator ==(bool3x4 a, bool3x4 b) => new bool3x4(a.c0 == b.c0, a.c1 == b.c1, a.c2 == b.c2, a.c3 == b.c3);
        public static bool3x4 operator !=(bool3x4 a, bool3x4 b) => new bool3x4(a.c0 != b.c0, a.c1 != b.c1, a.c2 != b.c2, a.c3 != b.c3);
        public static bool3x4 operator ==(bool3x4 a, bool b) => new bool3x4(a.c0 == b, a.c1 == b, a.c2 == b, a.c3 == b);
        public static bool3x4 operator !=(bool3x4 a, bool b) => new bool3x4(a.c0 != b, a.c1 != b, a.c2 != b, a.c3 != b);
        public static bool3x4 operator ==(bool a, bool3x4 b) => new bool3x4(a == b.c0, a == b.c1, a == b.c2, a == b.c3);
        public static bool3x4 operator !=(bool a, bool3x4 b) => new bool3x4(a != b.c0, a != b.c1, a != b.c2, a != b.c3);

        public static bool4x3 transpose(bool3x4 m) => new bool4x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z,
            m.c2.x, m.c2.y, m.c2.z,
            m.c3.x, m.c3.y, m.c3.z);
        public readonly bool4x3 transpose() => transpose(this);

        public readonly bool all => c0.all && c1.all && c2.all && c3.all;
        public readonly bool any => c0.any || c1.any || c2.any || c3.any;

        public override readonly bool Equals(object? obj) => obj is bool3x4 o && (c0 == o.c0).all && (c1 == o.c1).all && (c2 == o.c2).all && (c3 == o.c3).all;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        public override readonly string ToString() => $"bool3x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z})";

        public static implicit operator bool4x4(bool3x4 m) => new bool4x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y,
            m.c0.z, m.c1.z, m.c2.z, m.c3.z,
            false, false, false, true);
    }
}
