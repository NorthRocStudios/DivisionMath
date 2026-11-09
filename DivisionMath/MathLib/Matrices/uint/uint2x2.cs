//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 2x2 uint matrix (2 rows, 2 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct uint2x2
    {
        public uint2 c0;
        public uint2 c1;

        public uint2x2(uint m00, uint m01, uint m10, uint m11)
        {
            c0 = new uint2(m00, m10);
            c1 = new uint2(m01, m11);
        }
        public uint2x2(uint2 c0, uint2 c1) { this.c0 = c0; this.c1 = c1; }
        public uint2x2(uint diagonal) { c0 = new uint2(diagonal, 0u); c1 = new uint2(0u, diagonal); }
        public uint2x2(uint[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 2) throw new ArgumentException("Matrix must be 2x2");
            c0 = new uint2(m[0, 0], m[1, 0]);
            c1 = new uint2(m[0, 1], m[1, 1]);
        }

        public uint2 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; } }
        }
        public uint this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: if (row == 0) c0.x = value; else if (row == 1) c0.y = value; else throw new IndexOutOfRangeException(); break;
                    case 1: if (row == 0) c1.x = value; else if (row == 1) c1.y = value; else throw new IndexOutOfRangeException(); break;
                }
            }
        }

        public static uint2x2 identity => new uint2x2(1u);
        public static uint2x2 zero => new uint2x2(0u);

        public static uint2x2 operator +(uint2x2 a, uint2x2 b) => new uint2x2(a.c0 + b.c0, a.c1 + b.c1);
        public static uint2x2 operator -(uint2x2 a, uint2x2 b) => new uint2x2(a.c0 - b.c0, a.c1 - b.c1);
        public static uint2x2 operator *(uint2x2 a, uint2x2 b) => mul(a, b);
        public static uint2x2 operator *(uint2x2 m, uint s) => new uint2x2(m.c0 * s, m.c1 * s);
        public static uint2x2 operator *(uint s, uint2x2 m) => new uint2x2(m.c0 * s, m.c1 * s);
        public static uint2x2 operator /(uint2x2 m, uint s) => new uint2x2(m.c0 / s, m.c1 / s);
        public static uint2x2 operator +(uint2x2 m) => m;
        /// <summary>Negates each component; unsigned negation wraps, matching HLSL.</summary>
        public static uint2x2 operator -(uint2x2 m) => new uint2x2(-m.c0, -m.c1);
        public static uint2 operator *(uint2x2 m, uint2 v) => mul(m, v);
        public static uint2 operator *(uint2 v, uint2x2 m) => mul(v, m);

        public static uint2x2 mul(uint2x2 m, uint s) => m * s;
        public static uint2 mul(uint2x2 m, uint2 v) => m.c0 * v.x + m.c1 * v.y;
        public static uint2 mul(uint2 v, uint2x2 m) => new uint2(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y);

        public static uint2x2 mul(uint2x2 a, uint2x2 b) => new uint2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y);
        public static uint2x3 mul(uint2x2 a, uint2x3 b) => new uint2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y);
        public static uint2x4 mul(uint2x2 a, uint2x4 b) => new uint2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y,
            a.c0 * b.c3.x + a.c1 * b.c3.y);

        public static uint2x2 transpose(uint2x2 m) => new uint2x2(m.c0.x, m.c0.y, m.c1.x, m.c1.y);
        /// <summary>
        /// Unsigned integer matrices promote to float, matching HLSL, so the determinant is
        /// computed in float rather than wrapping the way an unsigned determinant would.
        /// </summary>
        public static float determinant(uint2x2 m) => float2x2.determinant((float2x2)m);

        /// <summary>Unsigned integer matrix inverse is a float2x2 (integer inverses are generally not integral).</summary>
        public static float2x2 inverse(uint2x2 m) => float2x2.inverse((float2x2)m);
        public readonly uint2x2 transpose() => transpose(this);
        public readonly float determinant() => determinant(this);
        public readonly float2x2 inverse() => inverse(this);

        public static bool operator ==(uint2x2 a, uint2x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        public static bool operator !=(uint2x2 a, uint2x2 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is uint2x2 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        public override readonly string ToString() => $"uint2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";

        public static implicit operator float2x2(uint2x2 m) => new float2x2(m.c0.x, m.c1.x, m.c0.y, m.c1.y);
        public static implicit operator int2x2(uint2x2 m) => new int2x2((int)m.c0.x, (int)m.c1.x, (int)m.c0.y, (int)m.c1.y);
        public static implicit operator double2x2(uint2x2 m) => new double2x2(m.c0.x, m.c1.x, m.c0.y, m.c1.y);

        public static implicit operator uint3x3(uint2x2 m) => new uint3x3(
            m.c0.x, m.c1.x, 0u,
            m.c0.y, m.c1.y, 0u,
            0u, 0u, 1u);
        public static implicit operator uint4x4(uint2x2 m) => new uint4x4(
            m.c0.x, m.c1.x, 0u, 0u,
            m.c0.y, m.c1.y, 0u, 0u,
            0u, 0u, 1u, 0u,
            0u, 0u, 0u, 1u);
    }
}
