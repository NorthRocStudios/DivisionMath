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
    /// Represents a 3x2 half matrix (3 rows, 2 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct half3x2
    {
        /// <summary>The first column of the matrix.</summary>
        public half3 c0;
        /// <summary>The second column of the matrix.</summary>
        public half3 c1;

        /// <summary>
        /// Initializes a new instance of the <see cref="half3x2"/> struct from six component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m20">The value at row 2, column 0.</param>
        /// <param name="m21">The value at row 2, column 1.</param>
        public half3x2(float m00, float m01,
                       float m10, float m11,
                       float m20, float m21)
        {
            c0 = new half3(m00, m10, m20);
            c1 = new half3(m01, m11, m21);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="half3x2"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        public half3x2(half3 c0, half3 c1) { this.c0 = c0; this.c1 = c1; }
        /// <summary>
        /// Initializes a new instance of the <see cref="half3x2"/> struct from a 3x2 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 3x2 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 3x2 array.</exception>
        public half3x2(float[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 3x2 (3 rows, 2 columns)");
            c0 = new half3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new half3(m[0, 1], m[1, 1], m[2, 1]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-1.</exception>
        public half3 this[int column]
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

        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static half3x2 zero => new half3x2(0f, 0f, 0f, 0f, 0f, 0f);

        /// <summary>Adds two matrices component-wise.</summary>
        public static half3x2 operator +(half3x2 a, half3x2 b) => new half3x2(a.c0 + b.c0, a.c1 + b.c1);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static half3x2 operator -(half3x2 a, half3x2 b) => new half3x2(a.c0 - b.c0, a.c1 - b.c1);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static half3x2 operator *(half3x2 m, float s) => new half3x2(m.c0 * s, m.c1 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static half3x2 operator *(float s, half3x2 m) => new half3x2(m.c0 * s, m.c1 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static half3x2 operator /(half3x2 m, float s) => new half3x2(m.c0 / s, m.c1 / s);
        /// <summary>Negates each component of the matrix.</summary>
        public static half3x2 operator -(half3x2 m) => new half3x2(-m.c0, -m.c1);
        /// <summary>Returns the matrix unchanged.</summary>
        public static half3x2 operator +(half3x2 m) => m;
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static half3 operator *(half3x2 m, half2 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static half2 operator *(half3 v, half3x2 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half3x2 mul(half3x2 m, float s) => m * s;
        /// <summary>
        /// Multiplies a <see cref="half3x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half3 mul(half3x2 m, half2 v) => m.c0 * v.x + m.c1 * v.y;
        /// <summary>
        /// Multiplies a row vector by a <see cref="half3x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half2 mul(half3 v, half3x2 m) => new half2(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z);

        /// <summary>
        /// Multiplies a <see cref="half3x2"/> by a <see cref="half2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x2 mul(half3x2 a, half2x2 b) => new half3x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y);
        /// <summary>
        /// Multiplies a <see cref="half3x2"/> by a <see cref="half2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x3 mul(half3x2 a, half2x3 b) => new half3x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y);
        /// <summary>
        /// Multiplies a <see cref="half3x2"/> by a <see cref="half2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half3x4 mul(half3x2 a, half2x4 b) => new half3x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y,
            a.c0 * b.c3.x + a.c1 * b.c3.y);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half2x3 transpose(half3x2 m) => new half2x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z);
        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly half2x3 transpose() => transpose(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(half3x2 a, half3x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(half3x2 a, half3x2 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="half3x2"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="half3x2"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="half3x2"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is half3x2 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"half3x2({c0.x}, {c1.x},  {c0.y}, {c1.y},  {c0.z}, {c1.z})";

        /// <summary>Defines an implicit widening conversion from a <see cref="half3x2"/> to a <see cref="float3x2"/>, matching HLSL's half-to-float promotion.</summary>
        public static implicit operator float3x2(half3x2 m) => new float3x2(
            m.c0.x, m.c1.x,
            m.c0.y, m.c1.y,
            m.c0.z, m.c1.z);

        /// <summary>Defines an implicit conversion from a <see cref="half3x2"/> to a <see cref="half3x3"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator half3x3(half3x2 m) => new half3x3(
            m.c0.x, m.c1.x, 0f,
            m.c0.y, m.c1.y, 0f,
            m.c0.z, m.c1.z, 1f);
    }
}
