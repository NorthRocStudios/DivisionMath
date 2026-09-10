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
    /// Represents a 3x2 half matrix (3 rows, 2 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct half3x2
    {
        public half3 c0;
        public half3 c1;

        public half3x2(float m00, float m01,
                       float m10, float m11,
                       float m20, float m21)
        {
            c0 = new half3(m00, m10, m20);
            c1 = new half3(m01, m11, m21);
        }
        public half3x2(half3 c0, half3 c1) { this.c0 = c0; this.c1 = c1; }
        public half3x2(float[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 3x2 (3 rows, 2 columns)");
            c0 = new half3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new half3(m[0, 1], m[1, 1], m[2, 1]);
        }

        public half3 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; } }
        }
        public float this[int row, int column]
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

        public static half3x2 zero => new half3x2(0f, 0f, 0f, 0f, 0f, 0f);

        public static half3x2 operator +(half3x2 a, half3x2 b) => new half3x2(a.c0 + b.c0, a.c1 + b.c1);
        public static half3x2 operator -(half3x2 a, half3x2 b) => new half3x2(a.c0 - b.c0, a.c1 - b.c1);
        public static half3x2 operator *(half3x2 m, float s) => new half3x2(m.c0 * s, m.c1 * s);
        public static half3x2 operator *(float s, half3x2 m) => new half3x2(m.c0 * s, m.c1 * s);
        public static half3x2 operator /(half3x2 m, float s) => new half3x2(m.c0 / s, m.c1 / s);
        public static half3x2 operator -(half3x2 m) => new half3x2(-m.c0, -m.c1);
        public static half3x2 operator +(half3x2 m) => m;
        public static half3 operator *(half3x2 m, half2 v) => mul(m, v);
        public static half2 operator *(half3 v, half3x2 m) => mul(v, m);

        public static half3x2 mul(half3x2 m, float s) => m * s;
        public static half3 mul(half3x2 m, half2 v) => m.c0 * v.x + m.c1 * v.y;
        public static half2 mul(half3 v, half3x2 m) => new half2(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z);

        public static half3x2 mul(half3x2 a, half2x2 b) => new half3x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y);
        public static half3x3 mul(half3x2 a, half2x3 b) => new half3x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y);
        public static half3x4 mul(half3x2 a, half2x4 b) => new half3x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y,
            a.c0 * b.c3.x + a.c1 * b.c3.y);

        public static half2x3 transpose(half3x2 m) => new half2x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z);
        public readonly half2x3 transpose() => transpose(this);

        public static bool operator ==(half3x2 a, half3x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        public static bool operator !=(half3x2 a, half3x2 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is half3x2 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        public override readonly string ToString() => $"half3x2({c0.x}, {c1.x},  {c0.y}, {c1.y},  {c0.z}, {c1.z})";

        public static implicit operator float3x2(half3x2 m) => new float3x2(
            m.c0.x, m.c1.x,
            m.c0.y, m.c1.y,
            m.c0.z, m.c1.z);

        public static implicit operator half3x3(half3x2 m) => new half3x3(
            m.c0.x, m.c1.x, 0f,
            m.c0.y, m.c1.y, 0f,
            m.c0.z, m.c1.z, 1f);
    }
}
