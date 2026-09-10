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
    /// Represents a 4x4 uint matrix (4 rows, 4 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct uint4x4
    {
        public uint4 c0;
        public uint4 c1;
        public uint4 c2;
        public uint4 c3;

        public uint4x4(uint m00, uint m01, uint m02, uint m03,
                       uint m10, uint m11, uint m12, uint m13,
                       uint m20, uint m21, uint m22, uint m23,
                       uint m30, uint m31, uint m32, uint m33)
        {
            c0 = new uint4(m00, m10, m20, m30);
            c1 = new uint4(m01, m11, m21, m31);
            c2 = new uint4(m02, m12, m22, m32);
            c3 = new uint4(m03, m13, m23, m33);
        }
        public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        public uint4x4(uint diagonal)
        {
            c0 = new uint4(diagonal, 0u, 0u, 0u);
            c1 = new uint4(0u, diagonal, 0u, 0u);
            c2 = new uint4(0u, 0u, diagonal, 0u);
            c3 = new uint4(0u, 0u, 0u, diagonal);
        }
        public uint4x4(uint[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 4) throw new ArgumentException("Matrix must be 4x4");
            c0 = new uint4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new uint4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new uint4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
            c3 = new uint4(m[0, 3], m[1, 3], m[2, 3], m[3, 3]);
        }

        public uint4 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, 3 => c3, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; case 3: c3 = value; break; } }
        }
        public uint this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, 3 => c0.w, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, 3 => c1.w, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, 3 => c2.w, _ => throw new IndexOutOfRangeException() },
                3 => row switch { 0 => c3.x, 1 => c3.y, 2 => c3.z, 3 => c3.w, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; case 3: c0.w = value; break; } break;
                    case 1: switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; case 3: c1.w = value; break; } break;
                    case 2: switch (row) { case 0: c2.x = value; break; case 1: c2.y = value; break; case 2: c2.z = value; break; case 3: c2.w = value; break; } break;
                    case 3: switch (row) { case 0: c3.x = value; break; case 1: c3.y = value; break; case 2: c3.z = value; break; case 3: c3.w = value; break; } break;
                }
            }
        }

        public static uint4x4 identity => new uint4x4(1u);
        public static uint4x4 zero => new uint4x4(0u);

        public static uint4x4 operator +(uint4x4 a, uint4x4 b) => new uint4x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        public static uint4x4 operator -(uint4x4 a, uint4x4 b) => new uint4x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        public static uint4x4 operator *(uint4x4 a, uint4x4 b) => mul(a, b);
        public static uint4x4 operator *(uint4x4 m, uint s) => new uint4x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        public static uint4x4 operator *(uint s, uint4x4 m) => new uint4x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        public static uint4x4 operator /(uint4x4 m, uint s) => new uint4x4(m.c0 / s, m.c1 / s, m.c2 / s, m.c3 / s);
        public static uint4x4 operator +(uint4x4 m) => m;
        public static uint4 operator *(uint4x4 m, uint4 v) => mul(m, v);
        public static uint4 operator *(uint4 v, uint4x4 m) => mul(v, m);

        public static uint4x4 mul(uint4x4 m, uint s) => m * s;
        public static uint4 mul(uint4x4 m, uint4 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z + m.c3 * v.w;
        public static uint4 mul(uint4 v, uint4x4 m) => new uint4(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z + v.w * m.c0.w,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z + v.w * m.c1.w,
            v.x * m.c2.x + v.y * m.c2.y + v.z * m.c2.z + v.w * m.c2.w,
            v.x * m.c3.x + v.y * m.c3.y + v.z * m.c3.z + v.w * m.c3.w);

        public static uint4x2 mul(uint4x4 a, uint4x2 b) => new uint4x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        public static uint4x3 mul(uint4x4 a, uint4x3 b) => new uint4x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        public static uint4x4 mul(uint4x4 a, uint4x4 b) => new uint4x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);

        public static uint4x4 transpose(uint4x4 m) => new uint4x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w,
            m.c2.x, m.c2.y, m.c2.z, m.c2.w,
            m.c3.x, m.c3.y, m.c3.z, m.c3.w);
        public readonly uint4x4 transpose() => transpose(this);

        public static bool operator ==(uint4x4 a, uint4x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        public static bool operator !=(uint4x4 a, uint4x4 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is uint4x4 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        public override readonly string ToString() =>
            $"uint4x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z},  {c0.w}, {c1.w}, {c2.w}, {c3.w})";

        public static implicit operator float4x4(uint4x4 m) => new float4x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y,
            m.c0.z, m.c1.z, m.c2.z, m.c3.z,
            m.c0.w, m.c1.w, m.c2.w, m.c3.w);
        public static implicit operator int4x4(uint4x4 m) => new int4x4(
            (int)m.c0.x, (int)m.c1.x, (int)m.c2.x, (int)m.c3.x,
            (int)m.c0.y, (int)m.c1.y, (int)m.c2.y, (int)m.c3.y,
            (int)m.c0.z, (int)m.c1.z, (int)m.c2.z, (int)m.c3.z,
            (int)m.c0.w, (int)m.c1.w, (int)m.c2.w, (int)m.c3.w);
        public static implicit operator double4x4(uint4x4 m) => new double4x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y,
            m.c0.z, m.c1.z, m.c2.z, m.c3.z,
            m.c0.w, m.c1.w, m.c2.w, m.c3.w);
    }
}
