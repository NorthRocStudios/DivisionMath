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
    /// Represents a 2x2 half matrix (2 rows, 2 columns) in column-major order (matching HLSL conventions).
    /// Backed by float on the CPU; translates to HLSL half2x2.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct half2x2
    {
        public half2 c0;
        public half2 c1;

        public half2x2(float m00, float m01, float m10, float m11)
        {
            c0 = new half2(m00, m10);
            c1 = new half2(m01, m11);
        }
        public half2x2(half2 c0, half2 c1) { this.c0 = c0; this.c1 = c1; }
        public half2x2(float diagonal) { c0 = new half2(diagonal, 0f); c1 = new half2(0f, diagonal); }
        public half2x2(float[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 2) throw new ArgumentException("Matrix must be 2x2");
            c0 = new half2(m[0, 0], m[1, 0]);
            c1 = new half2(m[0, 1], m[1, 1]);
        }

        public half2 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; } }
        }
        public float this[int row, int column]
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

        public static half2x2 identity => new half2x2(1f);
        public static half2x2 zero => new half2x2(0f);

        public static half2x2 operator +(half2x2 a, half2x2 b) => new half2x2(a.c0 + b.c0, a.c1 + b.c1);
        public static half2x2 operator -(half2x2 a, half2x2 b) => new half2x2(a.c0 - b.c0, a.c1 - b.c1);
        public static half2x2 operator *(half2x2 a, half2x2 b) => mul(a, b);
        public static half2x2 operator *(half2x2 m, float s) => new half2x2(m.c0 * s, m.c1 * s);
        public static half2x2 operator *(float s, half2x2 m) => new half2x2(m.c0 * s, m.c1 * s);
        public static half2x2 operator /(half2x2 m, float s) => new half2x2(m.c0 / s, m.c1 / s);
        public static half2x2 operator -(half2x2 m) => new half2x2(-m.c0, -m.c1);
        public static half2x2 operator +(half2x2 m) => m;
        public static half2 operator *(half2x2 m, half2 v) => mul(m, v);
        public static half2 operator *(half2 v, half2x2 m) => mul(v, m);

        public static half2x2 mul(half2x2 m, float s) => m * s;
        public static half2 mul(half2x2 m, half2 v) => m.c0 * v.x + m.c1 * v.y;
        public static half2 mul(half2 v, half2x2 m) => new half2(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y);

        public static half2x2 mul(half2x2 a, half2x2 b) => new half2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y);
        public static half2x3 mul(half2x2 a, half2x3 b) => new half2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y);
        public static half2x4 mul(half2x2 a, half2x4 b) => new half2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y,
            a.c0 * b.c3.x + a.c1 * b.c3.y);

        public static half2x2 transpose(half2x2 m) => new half2x2(m.c0.x, m.c0.y, m.c1.x, m.c1.y);
        public static float determinant(half2x2 m) => m.c0.x * m.c1.y - m.c1.x * m.c0.y;
        public static half2x2 inverse(half2x2 m)
        {
            float det = determinant(m);
            if (det == 0f) return zero;
            float invDet = 1f / det;
            return new half2x2(
                 m.c1.y * invDet, -m.c1.x * invDet,
                -m.c0.y * invDet, m.c0.x * invDet);
        }

        public readonly half2x2 transpose() => transpose(this);
        public readonly float determinant() => determinant(this);
        public readonly half2x2 inverse() => inverse(this);

        public static bool operator ==(half2x2 a, half2x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        public static bool operator !=(half2x2 a, half2x2 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is half2x2 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        public override readonly string ToString() => $"half2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";

        public static implicit operator float2x2(half2x2 m) => new float2x2(m.c0.x, m.c1.x, m.c0.y, m.c1.y);

        public static implicit operator half3x3(half2x2 m) => new half3x3(
            m.c0.x, m.c1.x, 0f,
            m.c0.y, m.c1.y, 0f,
            0f, 0f, 1f);
        public static implicit operator half4x4(half2x2 m) => new half4x4(
            m.c0.x, m.c1.x, 0f, 0f,
            m.c0.y, m.c1.y, 0f, 0f,
            0f, 0f, 1f, 0f,
            0f, 0f, 0f, 1f);
    }
}
