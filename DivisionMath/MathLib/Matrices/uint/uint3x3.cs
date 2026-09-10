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
    /// Represents a 3x3 uint matrix (3 rows, 3 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct uint3x3
    {
        public uint3 c0;
        public uint3 c1;
        public uint3 c2;

        public uint3x3(uint m00, uint m01, uint m02,
                       uint m10, uint m11, uint m12,
                       uint m20, uint m21, uint m22)
        {
            c0 = new uint3(m00, m10, m20);
            c1 = new uint3(m01, m11, m21);
            c2 = new uint3(m02, m12, m22);
        }
        public uint3x3(uint3 c0, uint3 c1, uint3 c2) { this.c0 = c0; this.c1 = c1; this.c2 = c2; }
        public uint3x3(uint diagonal)
        {
            c0 = new uint3(diagonal, 0u, 0u);
            c1 = new uint3(0u, diagonal, 0u);
            c2 = new uint3(0u, 0u, diagonal);
        }
        public uint3x3(uint[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 3) throw new ArgumentException("Matrix must be 3x3");
            c0 = new uint3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new uint3(m[0, 1], m[1, 1], m[2, 1]);
            c2 = new uint3(m[0, 2], m[1, 2], m[2, 2]);
        }

        public uint3 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; } }
        }
        public uint this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; } break;
                    case 1: switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; } break;
                    case 2: switch (row) { case 0: c2.x = value; break; case 1: c2.y = value; break; case 2: c2.z = value; break; } break;
                }
            }
        }

        public static uint3x3 identity => new uint3x3(1u);
        public static uint3x3 zero => new uint3x3(0u);

        public static uint3x3 operator +(uint3x3 a, uint3x3 b) => new uint3x3(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        public static uint3x3 operator -(uint3x3 a, uint3x3 b) => new uint3x3(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        public static uint3x3 operator *(uint3x3 a, uint3x3 b) => mul(a, b);
        public static uint3x3 operator *(uint3x3 m, uint s) => new uint3x3(m.c0 * s, m.c1 * s, m.c2 * s);
        public static uint3x3 operator *(uint s, uint3x3 m) => new uint3x3(m.c0 * s, m.c1 * s, m.c2 * s);
        public static uint3x3 operator /(uint3x3 m, uint s) => new uint3x3(m.c0 / s, m.c1 / s, m.c2 / s);
        public static uint3x3 operator +(uint3x3 m) => m;
        public static uint3 operator *(uint3x3 m, uint3 v) => mul(m, v);
        public static uint3 operator *(uint3 v, uint3x3 m) => mul(v, m);

        public static uint3x3 mul(uint3x3 m, uint s) => m * s;
        public static uint3 mul(uint3x3 m, uint3 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z;
        public static uint3 mul(uint3 v, uint3x3 m) => new uint3(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z,
            v.x * m.c2.x + v.y * m.c2.y + v.z * m.c2.z);

        public static uint3x2 mul(uint3x3 a, uint3x2 b) => new uint3x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        public static uint3x3 mul(uint3x3 a, uint3x3 b) => new uint3x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        public static uint3x4 mul(uint3x3 a, uint3x4 b) => new uint3x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);

        public static uint3x3 transpose(uint3x3 m) => new uint3x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z,
            m.c2.x, m.c2.y, m.c2.z);
        public readonly uint3x3 transpose() => transpose(this);

        public static bool operator ==(uint3x3 a, uint3x3 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        public static bool operator !=(uint3x3 a, uint3x3 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is uint3x3 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        public override readonly string ToString() => $"uint3x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y},  {c0.z}, {c1.z}, {c2.z})";

        public static implicit operator float3x3(uint3x3 m) => new float3x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            m.c0.z, m.c1.z, m.c2.z);
        public static implicit operator int3x3(uint3x3 m) => new int3x3(
            (int)m.c0.x, (int)m.c1.x, (int)m.c2.x,
            (int)m.c0.y, (int)m.c1.y, (int)m.c2.y,
            (int)m.c0.z, (int)m.c1.z, (int)m.c2.z);
        public static implicit operator double3x3(uint3x3 m) => new double3x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            m.c0.z, m.c1.z, m.c2.z);

        public static implicit operator uint4x4(uint3x3 m) => new uint4x4(
            m.c0.x, m.c1.x, m.c2.x, 0u,
            m.c0.y, m.c1.y, m.c2.y, 0u,
            m.c0.z, m.c1.z, m.c2.z, 0u,
            0u, 0u, 0u, 1u);

        public static implicit operator uint3x3(uint2x2 m) => new uint3x3(
            m.c0.x, m.c1.x, 0u,
            m.c0.y, m.c1.y, 0u,
            0u, 0u, 1u);
    }
}
