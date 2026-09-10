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
    /// Represents a 4x3 boolean matrix (4 rows, 3 columns) in column-major order.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool4x3
    {
        public bool4 c0;
        public bool4 c1;
        public bool4 c2;

        public bool4x3(bool m00, bool m01, bool m02,
                       bool m10, bool m11, bool m12,
                       bool m20, bool m21, bool m22,
                       bool m30, bool m31, bool m32)
        {
            c0 = new bool4(m00, m10, m20, m30);
            c1 = new bool4(m01, m11, m21, m31);
            c2 = new bool4(m02, m12, m22, m32);
        }
        public bool4x3(bool4 c0, bool4 c1, bool4 c2) { this.c0 = c0; this.c1 = c1; this.c2 = c2; }
        public bool4x3(bool value) { c0 = new bool4(value); c1 = new bool4(value); c2 = new bool4(value); }
        public bool4x3(bool[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 4x3 (4 rows, 3 columns)");
            c0 = new bool4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new bool4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new bool4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
        }

        public bool4 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; } }
        }
        public bool this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, 3 => c0.w, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, 3 => c1.w, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, 3 => c2.w, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; case 3: c0.w = value; break; } break;
                    case 1: switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; case 3: c1.w = value; break; } break;
                    case 2: switch (row) { case 0: c2.x = value; break; case 1: c2.y = value; break; case 2: c2.z = value; break; case 3: c2.w = value; break; } break;
                }
            }
        }

        public static bool4x3 off => new bool4x3(false);
        public static bool4x3 on => new bool4x3(true);

        public static bool4x3 operator !(bool4x3 m) => new bool4x3(!m.c0, !m.c1, !m.c2);

        public static bool4x3 operator &(bool4x3 a, bool4x3 b) => new bool4x3(a.c0 & b.c0, a.c1 & b.c1, a.c2 & b.c2);
        public static bool4x3 operator &(bool4x3 a, bool b) => new bool4x3(a.c0 & b, a.c1 & b, a.c2 & b);
        public static bool4x3 operator &(bool a, bool4x3 b) => new bool4x3(a & b.c0, a & b.c1, a & b.c2);

        public static bool4x3 operator |(bool4x3 a, bool4x3 b) => new bool4x3(a.c0 | b.c0, a.c1 | b.c1, a.c2 | b.c2);
        public static bool4x3 operator |(bool4x3 a, bool b) => new bool4x3(a.c0 | b, a.c1 | b, a.c2 | b);
        public static bool4x3 operator |(bool a, bool4x3 b) => new bool4x3(a | b.c0, a | b.c1, a | b.c2);

        public static bool4x3 operator ^(bool4x3 a, bool4x3 b) => new bool4x3(a.c0 ^ b.c0, a.c1 ^ b.c1, a.c2 ^ b.c2);
        public static bool4x3 operator ^(bool4x3 a, bool b) => new bool4x3(a.c0 ^ b, a.c1 ^ b, a.c2 ^ b);
        public static bool4x3 operator ^(bool a, bool4x3 b) => new bool4x3(a ^ b.c0, a ^ b.c1, a ^ b.c2);

        public static bool4x3 operator ==(bool4x3 a, bool4x3 b) => new bool4x3(a.c0 == b.c0, a.c1 == b.c1, a.c2 == b.c2);
        public static bool4x3 operator !=(bool4x3 a, bool4x3 b) => new bool4x3(a.c0 != b.c0, a.c1 != b.c1, a.c2 != b.c2);
        public static bool4x3 operator ==(bool4x3 a, bool b) => new bool4x3(a.c0 == b, a.c1 == b, a.c2 == b);
        public static bool4x3 operator !=(bool4x3 a, bool b) => new bool4x3(a.c0 != b, a.c1 != b, a.c2 != b);
        public static bool4x3 operator ==(bool a, bool4x3 b) => new bool4x3(a == b.c0, a == b.c1, a == b.c2);
        public static bool4x3 operator !=(bool a, bool4x3 b) => new bool4x3(a != b.c0, a != b.c1, a != b.c2);

        public static bool3x4 transpose(bool4x3 m) => new bool3x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w,
            m.c2.x, m.c2.y, m.c2.z, m.c2.w);
        public readonly bool3x4 transpose() => transpose(this);

        public readonly bool all => c0.all && c1.all && c2.all;
        public readonly bool any => c0.any || c1.any || c2.any;

        public override readonly bool Equals(object? obj) => obj is bool4x3 o && (c0 == o.c0).all && (c1 == o.c1).all && (c2 == o.c2).all;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        public override readonly string ToString() => $"bool4x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y},  {c0.z}, {c1.z}, {c2.z},  {c0.w}, {c1.w}, {c2.w})";

        public static implicit operator bool4x4(bool4x3 m) => new bool4x4(
            m.c0.x, m.c1.x, m.c2.x, false,
            m.c0.y, m.c1.y, m.c2.y, false,
            m.c0.z, m.c1.z, m.c2.z, false,
            m.c0.w, m.c1.w, m.c2.w, true);
    }
}
