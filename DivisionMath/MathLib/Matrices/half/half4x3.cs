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
    /// Represents a 4x3 half matrix (4 rows, 3 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct half4x3
    {
        public half4 c0;
        public half4 c1;
        public half4 c2;

        public half4x3(float m00, float m01, float m02,
                       float m10, float m11, float m12,
                       float m20, float m21, float m22,
                       float m30, float m31, float m32)
        {
            c0 = new half4(m00, m10, m20, m30);
            c1 = new half4(m01, m11, m21, m31);
            c2 = new half4(m02, m12, m22, m32);
        }
        public half4x3(half4 c0, half4 c1, half4 c2) { this.c0 = c0; this.c1 = c1; this.c2 = c2; }
        public half4x3(float[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 4x3 (4 rows, 3 columns)");
            c0 = new half4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new half4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new half4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
        }

        public half4 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; } }
        }
        public float this[int row, int column]
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

        public static half4x3 zero => new half4x3(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

        public static half4x3 operator +(half4x3 a, half4x3 b) => new half4x3(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        public static half4x3 operator -(half4x3 a, half4x3 b) => new half4x3(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        public static half4x3 operator *(half4x3 m, float s) => new half4x3(m.c0 * s, m.c1 * s, m.c2 * s);
        public static half4x3 operator *(float s, half4x3 m) => new half4x3(m.c0 * s, m.c1 * s, m.c2 * s);
        public static half4x3 operator /(half4x3 m, float s) => new half4x3(m.c0 / s, m.c1 / s, m.c2 / s);
        public static half4x3 operator -(half4x3 m) => new half4x3(-m.c0, -m.c1, -m.c2);
        public static half4x3 operator +(half4x3 m) => m;
        public static half4 operator *(half4x3 m, half3 v) => mul(m, v);
        public static half3 operator *(half4 v, half4x3 m) => mul(v, m);

        public static half4x3 mul(half4x3 m, float s) => m * s;
        public static half4 mul(half4x3 m, half3 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z;
        public static half3 mul(half4 v, half4x3 m) => new half3(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z + v.w * m.c0.w,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z + v.w * m.c1.w,
            v.x * m.c2.x + v.y * m.c2.y + v.z * m.c2.z + v.w * m.c2.w);

        public static half4x2 mul(half4x3 a, half3x2 b) => new half4x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        public static half4x3 mul(half4x3 a, half3x3 b) => new half4x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        public static half4x4 mul(half4x3 a, half3x4 b) => new half4x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);

        public static half3x4 transpose(half4x3 m) => new half3x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w,
            m.c2.x, m.c2.y, m.c2.z, m.c2.w);
        public readonly half3x4 transpose() => transpose(this);

        public static bool operator ==(half4x3 a, half4x3 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        public static bool operator !=(half4x3 a, half4x3 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is half4x3 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        public override readonly string ToString() => $"half4x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y},  {c0.z}, {c1.z}, {c2.z},  {c0.w}, {c1.w}, {c2.w})";

        public static implicit operator float4x3(half4x3 m) => new float4x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            m.c0.z, m.c1.z, m.c2.z,
            m.c0.w, m.c1.w, m.c2.w);

        public static implicit operator half4x4(half4x3 m) => new half4x4(
            m.c0.x, m.c1.x, m.c2.x, 0f,
            m.c0.y, m.c1.y, m.c2.y, 0f,
            m.c0.z, m.c1.z, m.c2.z, 0f,
            m.c0.w, m.c1.w, m.c2.w, 1f);
    }
}
