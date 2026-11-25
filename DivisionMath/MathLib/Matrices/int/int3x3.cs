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
    /// Represents a 3x3 integer matrix (3 rows, 3 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct int3x3
    {
        /// <summary>The first column of the matrix.</summary>
        public int3 c0;
        /// <summary>The second column of the matrix.</summary>
        public int3 c1;
        /// <summary>The third column of the matrix.</summary>
        public int3 c2;

        /// <summary>
        /// Initializes a new instance of the <see cref="int3x3"/> struct from nine component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m02">The value at row 0, column 2.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m12">The value at row 1, column 2.</param>
        /// <param name="m20">The value at row 2, column 0.</param>
        /// <param name="m21">The value at row 2, column 1.</param>
        /// <param name="m22">The value at row 2, column 2.</param>
        public int3x3(int m00, int m01, int m02,
                      int m10, int m11, int m12,
                      int m20, int m21, int m22)
        {
            c0 = new int3(m00, m10, m20);
            c1 = new int3(m01, m11, m21);
            c2 = new int3(m02, m12, m22);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="int3x3"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        /// <param name="c2">The third column.</param>
        public int3x3(int3 c0, int3 c1, int3 c2) { this.c0 = c0; this.c1 = c1; this.c2 = c2; }
        /// <summary>
        /// Initializes a new instance of the <see cref="int3x3"/> struct with the specified value on the main diagonal and zeros elsewhere.
        /// </summary>
        /// <param name="diagonal">The value placed on the main diagonal.</param>
        public int3x3(int diagonal)
        {
            c0 = new int3(diagonal, 0, 0);
            c1 = new int3(0, diagonal, 0);
            c2 = new int3(0, 0, diagonal);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="int3x3"/> struct from a 3x3 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 3x3 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 3x3 array.</exception>
        public int3x3(int[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 3) throw new ArgumentException("Matrix must be 3x3");
            c0 = new int3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new int3(m[0, 1], m[1, 1], m[2, 1]);
            c2 = new int3(m[0, 2], m[1, 2], m[2, 2]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1, 2 = c2).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-2.</exception>
        public int3 this[int column]
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
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="row"/> or <paramref name="column"/> is out of range.</exception>
        public int this[int row, int column]
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

        /// <summary>Gets the identity matrix.</summary>
        public static int3x3 identity => new int3x3(1);
        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static int3x3 zero => new int3x3(0);

        /// <summary>Adds two matrices component-wise.</summary>
        public static int3x3 operator +(int3x3 a, int3x3 b) => new int3x3(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static int3x3 operator -(int3x3 a, int3x3 b) => new int3x3(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        /// <summary>Multiplies two matrices.</summary>
        public static int3x3 operator *(int3x3 a, int3x3 b) => mul(a, b);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static int3x3 operator *(int3x3 m, int s) => new int3x3(m.c0 * s, m.c1 * s, m.c2 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static int3x3 operator *(int s, int3x3 m) => new int3x3(m.c0 * s, m.c1 * s, m.c2 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static int3x3 operator /(int3x3 m, int s) => new int3x3(m.c0 / s, m.c1 / s, m.c2 / s);
        /// <summary>Negates each component of the matrix.</summary>
        public static int3x3 operator -(int3x3 m) => new int3x3(-m.c0, -m.c1, -m.c2);
        /// <summary>Returns the matrix unchanged.</summary>
        public static int3x3 operator +(int3x3 m) => m;
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static int3 operator *(int3x3 m, int3 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static int3 operator *(int3 v, int3x3 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static int3x3 mul(int3x3 m, int s) => m * s;
        /// <summary>
        /// Multiplies an <see cref="int3x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static int3 mul(int3x3 m, int3 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z;
        /// <summary>
        /// Multiplies a row vector by an <see cref="int3x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static int3 mul(int3 v, int3x3 m) => new int3(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z,
            v.x * m.c2.x + v.y * m.c2.y + v.z * m.c2.z);

        /// <summary>
        /// Multiplies an <see cref="int3x3"/> by an <see cref="int3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x2 mul(int3x3 a, int3x2 b) => new int3x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);

        /// <summary>
        /// Multiplies two <see cref="int3x3"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x3 mul(int3x3 a, int3x3 b) => new int3x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);

        /// <summary>
        /// Multiplies an <see cref="int3x3"/> by an <see cref="int3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static int3x4 mul(int3x3 a, int3x4 b) => new int3x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static int3x3 transpose(int3x3 m) => new int3x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z,
            m.c2.x, m.c2.y, m.c2.z);

        /// <summary>
        /// Integer matrices promote to float, matching HLSL, so the determinant is computed in
        /// float rather than overflowing the way an int determinant would.
        /// </summary>
        public static float determinant(int3x3 m) => float3x3.determinant((float3x3)m);

        /// <summary>Integer matrix inverse is a float3x3 (integer inverses are generally not integral).</summary>
        public static float3x3 inverse(int3x3 m) => float3x3.inverse((float3x3)m);
        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly int3x3 transpose() => transpose(this);
        /// <summary>Computes the determinant of the matrix, promoting to float.</summary>
        public readonly float determinant() => determinant(this);
        /// <summary>Computes the inverse of the matrix as a <see cref="float3x3"/>, promoting to float.</summary>
        public readonly float3x3 inverse() => inverse(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(int3x3 a, int3x3 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(int3x3 a, int3x3 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="int3x3"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="int3x3"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is an <see cref="int3x3"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is int3x3 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"int3x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y},  {c0.z}, {c1.z}, {c2.z})";

        /// <summary>Defines an implicit conversion from an <see cref="int3x3"/> to a <see cref="float3x3"/> by converting each component.</summary>
        public static implicit operator float3x3(int3x3 m) => new float3x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            m.c0.z, m.c1.z, m.c2.z);

        /// <summary>Defines an implicit conversion from an <see cref="int3x3"/> to a <see cref="float4x4"/>, placing the source in the upper-left corner, converting each component, and padding the remaining components with the identity matrix.</summary>
        public static implicit operator float4x4(int3x3 m) => new float4x4(
            m.c0.x, m.c1.x, m.c2.x, 0f,
            m.c0.y, m.c1.y, m.c2.y, 0f,
            m.c0.z, m.c1.z, m.c2.z, 0f,
            0f, 0f, 0f, 1f);
    }
}
