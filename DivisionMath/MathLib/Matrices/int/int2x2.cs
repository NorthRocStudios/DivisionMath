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
    /// Represents a 2x2 integer matrix in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct int2x2
    {
        // Column-major storage
        public int2 c0;
        public int2 c1;

        #region Constructors

        // From 4 scalars (row-major order for convenience)
        public int2x2(int m00, int m01, int m10, int m11)
        {
            c0 = new int2(m00, m10);
            c1 = new int2(m01, m11);
        }

        // From 2 column vectors
        public int2x2(int2 c0, int2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        // From single scalar (diagonal matrix)
        public int2x2(int diagonal)
        {
            c0 = new int2(diagonal, 0);
            c1 = new int2(0, diagonal);
        }

        // From 2x2 array (row-major)
        public int2x2(int[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 2x2");

            c0 = new int2(m[0, 0], m[1, 0]);
            c1 = new int2(m[0, 1], m[1, 1]);
        }

        #endregion Constructors

        #region Indexers

        // Column-major indexer
        public int2 this[int column]
        {
            readonly get => column switch
            {
                0 => c0,
                1 => c1,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: c0 = value; break;
                    case 1: c1 = value; break;
                }
            }
        }

        // Element access via [row, column]
        public int this[int row, int column]
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
                    case 0:
                        if (row == 0) c0.x = value;
                        else c0.y = value;
                        break;
                    case 1:
                        if (row == 0) c1.x = value;
                        else c1.y = value;
                        break;
                }
            }
        }

        #endregion Indexers

        #region StaticProperties

        public static int2x2 identity => new int2x2(1);

        public static int2x2 zero => new int2x2(0);

        #endregion StaticProperties

        #region ArithmeticOperators

        // Matrix-Matrix
        public static int2x2 operator +(int2x2 a, int2x2 b) => new int2x2(a.c0 + b.c0, a.c1 + b.c1);
        public static int2x2 operator -(int2x2 a, int2x2 b) => new int2x2(a.c0 - b.c0, a.c1 - b.c1);
        public static int2x2 operator *(int2x2 a, int2x2 b) => mul(a, b); // Matrix multiplication
        public static int2x2 operator *(int2x2 m, int scalar) => new int2x2(m.c0 * scalar, m.c1 * scalar);
        public static int2x2 operator *(int scalar, int2x2 m) => new int2x2(m.c0 * scalar, m.c1 * scalar);

        // Matrix-Vector
        public static int2 operator *(int2x2 m, int2 v) => v.x * m.c0 + v.y * m.c1;

        // Vector-Matrix (added for HLSL mul parity)
        public static int2 operator *(int2 v, int2x2 m) => mul(v, m);

        #endregion ArithmeticOperators

        #region StaticMethods

        public static int2x2 mul(int2x2 a, int2x2 b) => new int2x2(
            a.c0.x * b.c0.x + a.c1.x * b.c0.y,
            a.c0.y * b.c0.x + a.c1.y * b.c0.y,
            a.c0.x * b.c1.x + a.c1.x * b.c1.y,
            a.c0.y * b.c1.x + a.c1.y * b.c1.y
        );

        public static int2 mul(int2x2 m, int2 v) => m * v;

        public static int2 mul(int2 v, int2x2 m) => new int2(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y
        );

        public static int2x2 transpose(int2x2 m) => new int2x2(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y
        );

        public static int determinant(int2x2 m) => m.c0.x * m.c1.y - m.c1.x * m.c0.y;

        /// <summary>
        /// Integer matrices do not have an integer inverse in general.
        /// This returns a float2x2 so the reciprocal determinant can be represented.
        /// </summary>
        public static float2x2 inverse(int2x2 m)
        {
            int det = determinant(m);
            if (det == 0)
                return float2x2.zero;

            float invDet = 1f / det;
            return new float2x2(
                 m.c1.y * invDet, -m.c1.x * invDet,
                -m.c0.y * invDet, m.c0.x * invDet
            );
        }

        #endregion StaticMethods

        #region InstanceMethods

        public readonly int2x2 transpose() => transpose(this);
        public readonly int determinant() => determinant(this);
        public readonly float2x2 inverse() => inverse(this);

        #endregion InstanceMethods

        #region Equality

        public static bool operator ==(int2x2 a, int2x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        public static bool operator !=(int2x2 a, int2x2 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is int2x2 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        #endregion Equality

        #region Conversion

        public override readonly string ToString() => $"int2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";

        public static implicit operator float2x2(int2x2 m) => new float2x2(
            m.c0.x, m.c1.x,
            m.c0.y, m.c1.y
        );

        public static implicit operator float3x3(int2x2 m) => new float3x3(
            m.c0.x, m.c1.x, 0f,
            m.c0.y, m.c1.y, 0f,
            0f, 0f, 1f
        );

        public static implicit operator float4x4(int2x2 m) => new float4x4(
            m.c0.x, m.c1.x, 0f, 0f,
            m.c0.y, m.c1.y, 0f, 0f,
            0f, 0f, 1f, 0f,
            0f, 0f, 0f, 1f
        );

        #endregion Conversion
    }
}
