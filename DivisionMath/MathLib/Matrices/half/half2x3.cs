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
    /// Represents a 2x3 half matrix (2 rows, 3 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct half2x3
    {
        /// <summary>The first column of the matrix.</summary>
        public half2 c0;
        /// <summary>The second column of the matrix.</summary>
        public half2 c1;
        /// <summary>The third column of the matrix.</summary>
        public half2 c2;

        /// <summary>
        /// Initializes a new instance of the <see cref="half2x3"/> struct from six component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m02">The value at row 0, column 2.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m12">The value at row 1, column 2.</param>
        public half2x3(float m00, float m01, float m02,
                       float m10, float m11, float m12)
        {
            c0 = new half2(m00, m10);
            c1 = new half2(m01, m11);
            c2 = new half2(m02, m12);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="half2x3"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        /// <param name="c2">The third column.</param>
        public half2x3(half2 c0, half2 c1, half2 c2) { this.c0 = c0; this.c1 = c1; this.c2 = c2; }
        /// <summary>
        /// Initializes a new instance of the <see cref="half2x3"/> struct from a 2x3 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 2x3 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 2x3 array.</exception>
        public half2x3(float[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 2x3 (2 rows, 3 columns)");
            c0 = new half2(m[0, 0], m[1, 0]);
            c1 = new half2(m[0, 1], m[1, 1]);
            c2 = new half2(m[0, 2], m[1, 2]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1, 2 = c2).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-2.</exception>
        public half2 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; } }
        }
        /// <summary>
        /// Gets or sets the matrix component at the specified row and column.
        /// </summary>
        /// <param name="row">The zero-based row index.</param>
        /// <param name="column">The zero-based column index.</param>
        /// <returns>The component at the specified row and column.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown when <paramref name="row"/> or <paramref name="column"/> is out of range.</exception>
        public float this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: if (row == 0) c0.x = value; else if (row == 1) c0.y = value; else throw new IndexOutOfRangeException(); break;
                    case 1: if (row == 0) c1.x = value; else if (row == 1) c1.y = value; else throw new IndexOutOfRangeException(); break;
                    case 2: if (row == 0) c2.x = value; else if (row == 1) c2.y = value; else throw new IndexOutOfRangeException(); break;
                }
            }
        }

        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static half2x3 zero => new half2x3(0f, 0f, 0f, 0f, 0f, 0f);

        /// <summary>Adds two matrices component-wise.</summary>
        public static half2x3 operator +(half2x3 a, half2x3 b) => new half2x3(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static half2x3 operator -(half2x3 a, half2x3 b) => new half2x3(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static half2x3 operator *(half2x3 m, float s) => new half2x3(m.c0 * s, m.c1 * s, m.c2 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static half2x3 operator *(float s, half2x3 m) => new half2x3(m.c0 * s, m.c1 * s, m.c2 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static half2x3 operator /(half2x3 m, float s) => new half2x3(m.c0 / s, m.c1 / s, m.c2 / s);
        /// <summary>Negates each component of the matrix.</summary>
        public static half2x3 operator -(half2x3 m) => new half2x3(-m.c0, -m.c1, -m.c2);
        /// <summary>Returns the matrix unchanged.</summary>
        public static half2x3 operator +(half2x3 m) => m;
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static half2 operator *(half2x3 m, half3 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static half3 operator *(half2 v, half2x3 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static half2x3 mul(half2x3 m, float s) => m * s;
        /// <summary>
        /// Multiplies a <see cref="half2x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static half2 mul(half2x3 m, half3 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z;
        /// <summary>
        /// Multiplies a row vector by a <see cref="half2x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static half3 mul(half2 v, half2x3 m) => new half3(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y,
            v.x * m.c2.x + v.y * m.c2.y);

        /// <summary>
        /// Multiplies a <see cref="half2x3"/> by a <see cref="half3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x2 mul(half2x3 a, half3x2 b) => new half2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        /// <summary>
        /// Multiplies a <see cref="half2x3"/> by a <see cref="half3x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x3 mul(half2x3 a, half3x3 b) => new half2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        /// <summary>
        /// Multiplies a <see cref="half2x3"/> by a <see cref="half3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static half2x4 mul(half2x3 a, half3x4 b) => new half2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static half3x2 transpose(half2x3 m) => new half3x2(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y,
            m.c2.x, m.c2.y);
        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly half3x2 transpose() => transpose(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(half2x3 a, half2x3 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(half2x3 a, half2x3 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="half2x3"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="half2x3"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="half2x3"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is half2x3 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"half2x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y})";

        /// <summary>Defines an implicit widening conversion from a <see cref="half2x3"/> to a <see cref="float2x3"/>, matching HLSL's half-to-float promotion.</summary>
        public static implicit operator float2x3(half2x3 m) => new float2x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y);

        /// <summary>Defines an implicit conversion from a <see cref="half2x3"/> to a <see cref="half3x3"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator half3x3(half2x3 m) => new half3x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            0f, 0f, 1f);
    }
}
