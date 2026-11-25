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
    /// Represents a 4x2 integer matrix (4 rows, 2 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct int4x2
    {
        /// <summary>The first column of the matrix.</summary>
        public int4 c0;
        /// <summary>The second column of the matrix.</summary>
        public int4 c1;

        /// <summary>
        /// Initializes a new instance of the <see cref="int4x2"/> struct from eight component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m20">The value at row 2, column 0.</param>
        /// <param name="m21">The value at row 2, column 1.</param>
        /// <param name="m30">The value at row 3, column 0.</param>
        /// <param name="m31">The value at row 3, column 1.</param>
        public int4x2(int m00, int m01,
                      int m10, int m11,
                      int m20, int m21,
                      int m30, int m31)
        {
            c0 = new int4(m00, m10, m20, m30);
            c1 = new int4(m01, m11, m21, m31);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="int4x2"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        public int4x2(int4 c0, int4 c1) { this.c0 = c0; this.c1 = c1; }
        /// <summary>
        /// Initializes a new instance of the <see cref="int4x2"/> struct from a 4x2 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 4x2 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 4x2 array.</exception>
        public int4x2(int[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 4x2 (4 rows, 2 columns)");
            c0 = new int4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new int4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-1.</exception>
        public int4 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; } }
        }
        /// <summary>
        /// Gets or sets the matrix component at the specified row and column.
        /// </summary>
        /// <param name="row">The zero-based row index.</param>
        /// <param name="column">The zero-based column index.</param>
        /// <returns>The component at the specified row and column.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="row"/> or <paramref name="column"/> is out of range.</exception>
        public int this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, 3 => c0.w, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, 3 => c1.w, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; case 3: c0.w = value; break; } break;
                    case 1: switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; case 3: c1.w = value; break; } break;
                }
            }
        }

        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static int4x2 zero => new int4x2(0, 0, 0, 0, 0, 0, 0, 0);

        /// <summary>Adds two matrices component-wise.</summary>
        public static int4x2 operator +(int4x2 a, int4x2 b) => new int4x2(a.c0 + b.c0, a.c1 + b.c1);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static int4x2 operator -(int4x2 a, int4x2 b) => new int4x2(a.c0 - b.c0, a.c1 - b.c1);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static int4x2 operator *(int4x2 m, int s) => new int4x2(m.c0 * s, m.c1 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static int4x2 operator *(int s, int4x2 m) => new int4x2(m.c0 * s, m.c1 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static int4x2 operator /(int4x2 m, int s) => new int4x2(m.c0 / s, m.c1 / s);
        /// <summary>Negates each component of the matrix.</summary>
        public static int4x2 operator -(int4x2 m) => new int4x2(-m.c0, -m.c1);
        /// <summary>Returns the matrix unchanged.</summary>
        public static int4x2 operator +(int4x2 m) => m;
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static int4 operator *(int4x2 m, int2 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static int2 operator *(int4 v, int4x2 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int4x2 mul(int4x2 m, int s) => m * s;
        /// <summary>
        /// Multiplies an <see cref="int4x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int4 mul(int4x2 m, int2 v) => m.c0 * v.x + m.c1 * v.y;
        /// <summary>
        /// Multiplies a row vector by an <see cref="int4x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int2 mul(int4 v, int4x2 m) => new int2(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z + v.w * m.c0.w,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z + v.w * m.c1.w);

        /// <summary>
        /// Multiplies an <see cref="int4x2"/> by an <see cref="int2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x2 mul(int4x2 a, int2x2 b) => new int4x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y);
        /// <summary>
        /// Multiplies an <see cref="int4x2"/> by an <see cref="int2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x3 mul(int4x2 a, int2x3 b) => new int4x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y);
        /// <summary>
        /// Multiplies an <see cref="int4x2"/> by an <see cref="int2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int4x4 mul(int4x2 a, int2x4 b) => new int4x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y,
            a.c0 * b.c3.x + a.c1 * b.c3.y);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int2x4 transpose(int4x2 m) => new int2x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w);

        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly int2x4 transpose() => transpose(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(int4x2 a, int4x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(int4x2 a, int4x2 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="int4x2"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="int4x2"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is an <see cref="int4x2"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is int4x2 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"int4x2({c0.x}, {c1.x},  {c0.y}, {c1.y},  {c0.z}, {c1.z},  {c0.w}, {c1.w})";

        /// <summary>Defines an implicit conversion from an <see cref="int4x2"/> to a <see cref="float4x2"/> by converting each component.</summary>
        public static implicit operator float4x2(int4x2 m) => new float4x2(
            m.c0.x, m.c1.x,
            m.c0.y, m.c1.y,
            m.c0.z, m.c1.z,
            m.c0.w, m.c1.w);
    }
}
