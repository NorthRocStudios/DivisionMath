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
    /// Represents a 2x4 matrix (2 rows, 4 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float2x4
    {
        public float2 c0;
        public float2 c1;
        public float2 c2;
        public float2 c3;

        public float2x4(float m00, float m01, float m02, float m03,
                        float m10, float m11, float m12, float m13)
        {
            c0 = new float2(m00, m10);
            c1 = new float2(m01, m11);
            c2 = new float2(m02, m12);
            c3 = new float2(m03, m13);
        }
        public float2x4(float2 c0, float2 c1, float2 c2, float2 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        public float2x4(float[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 4)
                throw new ArgumentException("Matrix must be 2x4 (2 rows, 4 columns)");
            c0 = new float2(m[0, 0], m[1, 0]);
            c1 = new float2(m[0, 1], m[1, 1]);
            c2 = new float2(m[0, 2], m[1, 2]);
            c3 = new float2(m[0, 3], m[1, 3]);
        }

        public float2 this[int column]
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
        public float this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, _ => throw new IndexOutOfRangeException() },
                3 => row switch { 0 => c3.x, 1 => c3.y, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: if (row == 0) c0.x = value; else if (row == 1) c0.y = value; else throw new IndexOutOfRangeException(); break;
                    case 1: if (row == 0) c1.x = value; else if (row == 1) c1.y = value; else throw new IndexOutOfRangeException(); break;
                    case 2: if (row == 0) c2.x = value; else if (row == 1) c2.y = value; else throw new IndexOutOfRangeException(); break;
                    case 3: if (row == 0) c3.x = value; else if (row == 1) c3.y = value; else throw new IndexOutOfRangeException(); break;
                }
            }
        }

        public static float2x4 zero => new float2x4(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

        public static float2x4 operator +(float2x4 a, float2x4 b) => new float2x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        public static float2x4 operator -(float2x4 a, float2x4 b) => new float2x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        public static float2x4 operator *(float2x4 m, float s) => new float2x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        public static float2x4 operator *(float s, float2x4 m) => new float2x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        public static float2x4 operator /(float2x4 m, float s) => new float2x4(m.c0 / s, m.c1 / s, m.c2 / s, m.c3 / s);
        public static float2x4 operator -(float2x4 m) => new float2x4(-m.c0, -m.c1, -m.c2, -m.c3);
        public static float2x4 operator +(float2x4 m) => m;
        public static float2 operator *(float2x4 m, float4 v) => mul(m, v);
        public static float4 operator *(float2 v, float2x4 m) => mul(v, m);

        public static float2x4 mul(float2x4 m, float s) => m * s;
        public static float2 mul(float2x4 m, float4 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z + m.c3 * v.w;
        public static float4 mul(float2 v, float2x4 m) => new float4(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y,
            v.x * m.c2.x + v.y * m.c2.y,
            v.x * m.c3.x + v.y * m.c3.y);

        public static float2x2 mul(float2x4 a, float4x2 b) => new float2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        public static float2x3 mul(float2x4 a, float4x3 b) => new float2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        public static float2x4 mul(float2x4 a, float4x4 b) => new float2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);

        public static float4x2 transpose(float2x4 m) => new float4x2(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y,
            m.c2.x, m.c2.y,
            m.c3.x, m.c3.y);

        public readonly float4x2 transpose() => transpose(this);

        public static bool operator ==(float2x4 a, float2x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        public static bool operator !=(float2x4 a, float2x4 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is float2x4 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        public override readonly string ToString() => $"float2x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y})";

        public static implicit operator float4x4(float2x4 m) => new float4x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y,
            0f, 0f, 0f, 0f,
            0f, 0f, 0f, 1f);
    }
}
