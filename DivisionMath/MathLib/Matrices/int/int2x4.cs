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
    /// Represents a 2x4 integer matrix (2 rows, 4 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct int2x4
    {
        public int2 c0;
        public int2 c1;
        public int2 c2;
        public int2 c3;

        public int2x4(int m00, int m01, int m02, int m03,
                      int m10, int m11, int m12, int m13)
        {
            c0 = new int2(m00, m10);
            c1 = new int2(m01, m11);
            c2 = new int2(m02, m12);
            c3 = new int2(m03, m13);
        }
        public int2x4(int2 c0, int2 c1, int2 c2, int2 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        public int2x4(int[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 4)
                throw new ArgumentException("Matrix must be 2x4 (2 rows, 4 columns)");
            c0 = new int2(m[0, 0], m[1, 0]);
            c1 = new int2(m[0, 1], m[1, 1]);
            c2 = new int2(m[0, 2], m[1, 2]);
            c3 = new int2(m[0, 3], m[1, 3]);
        }

        public int2 this[int column]
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
        public int this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row == 0 ? c0.x : c0.y,
                1 => row == 0 ? c1.x : c1.y,
                2 => row == 0 ? c2.x : c2.y,
                3 => row == 0 ? c3.x : c3.y,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: if (row == 0) c0.x = value; else c0.y = value; break;
                    case 1: if (row == 0) c1.x = value; else c1.y = value; break;
                    case 2: if (row == 0) c2.x = value; else c2.y = value; break;
                    case 3: if (row == 0) c3.x = value; else c3.y = value; break;
                }
            }
        }

        public static int2x4 zero => new int2x4(0, 0, 0, 0, 0, 0, 0, 0);

        public static int2x4 operator +(int2x4 a, int2x4 b) => new int2x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        public static int2x4 operator -(int2x4 a, int2x4 b) => new int2x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        public static int2x4 operator *(int2x4 m, int s) => new int2x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        public static int2x4 operator *(int s, int2x4 m) => new int2x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        public static int2x4 operator /(int2x4 m, int s) => new int2x4(m.c0 / s, m.c1 / s, m.c2 / s, m.c3 / s);
        public static int2x4 operator -(int2x4 m) => new int2x4(-m.c0, -m.c1, -m.c2, -m.c3);
        public static int2x4 operator +(int2x4 m) => m;
        public static int2 operator *(int2x4 m, int4 v) => mul(m, v);
        public static int4 operator *(int2 v, int2x4 m) => mul(v, m);

        public static int2x4 mul(int2x4 m, int s) => m * s;
        public static int2 mul(int2x4 m, int4 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z + m.c3 * v.w;
        public static int4 mul(int2 v, int2x4 m) => new int4(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y,
            v.x * m.c2.x + v.y * m.c2.y,
            v.x * m.c3.x + v.y * m.c3.y);

        public static int2x2 mul(int2x4 a, int4x2 b) => new int2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        public static int2x3 mul(int2x4 a, int4x3 b) => new int2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        public static int2x4 mul(int2x4 a, int4x4 b) => new int2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);

        public static int4x2 transpose(int2x4 m) => new int4x2(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y,
            m.c2.x, m.c2.y,
            m.c3.x, m.c3.y);

        public readonly int4x2 transpose() => transpose(this);

        public static bool operator ==(int2x4 a, int2x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        public static bool operator !=(int2x4 a, int2x4 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is int2x4 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        public override readonly string ToString() => $"int2x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y})";

        public static implicit operator float2x4(int2x4 m) => new float2x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y);

        public static implicit operator float4x4(int2x4 m) => new float4x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y,
            0f, 0f, 0f, 0f,
            0f, 0f, 0f, 1f);
    }
}
