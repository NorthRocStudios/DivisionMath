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
    /// Represents a 2x2 uint matrix (2 rows, 2 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct uint2x2
    {
        /// <summary>The first column of the matrix.</summary>
        public uint2 c0;
        /// <summary>The second column of the matrix.</summary>
        public uint2 c1;

        /// <summary>
        /// Initializes a new instance of the <see cref="uint2x2"/> struct from four component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        public uint2x2(uint m00, uint m01, uint m10, uint m11)
        {
            c0 = new uint2(m00, m10);
            c1 = new uint2(m01, m11);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="uint2x2"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        public uint2x2(uint2 c0, uint2 c1) { this.c0 = c0; this.c1 = c1; }
        /// <summary>
        /// Initializes a new instance of the <see cref="uint2x2"/> struct with the specified value on the main diagonal and zeros elsewhere.
        /// </summary>
        /// <param name="diagonal">The value placed on the main diagonal.</param>
        public uint2x2(uint diagonal) { c0 = new uint2(diagonal, 0u); c1 = new uint2(0u, diagonal); }
        /// <summary>
        /// Initializes a new instance of the <see cref="uint2x2"/> struct from a 2x2 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 2x2 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 2x2 array.</exception>
        public uint2x2(uint[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 2) throw new ArgumentException("Matrix must be 2x2");
            c0 = new uint2(m[0, 0], m[1, 0]);
            c1 = new uint2(m[0, 1], m[1, 1]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-1.</exception>
        public uint2 this[int column]
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
        /// <exception cref="IndexOutOfRangeException">Thrown when <paramref name="row"/> or <paramref name="column"/> is out of range.</exception>
        public uint this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: if (row == 0) c0.x = value; else if (row == 1) c0.y = value; else throw new IndexOutOfRangeException(); break;
                    case 1: if (row == 0) c1.x = value; else if (row == 1) c1.y = value; else throw new IndexOutOfRangeException(); break;
                }
            }
        }

        /// <summary>Gets the identity matrix.</summary>
        public static uint2x2 identity => new uint2x2(1u);
        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static uint2x2 zero => new uint2x2(0u);

        /// <summary>Adds two matrices component-wise.</summary>
        public static uint2x2 operator +(uint2x2 a, uint2x2 b) => new uint2x2(a.c0 + b.c0, a.c1 + b.c1);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static uint2x2 operator -(uint2x2 a, uint2x2 b) => new uint2x2(a.c0 - b.c0, a.c1 - b.c1);
        /// <summary>Multiplies two matrices.</summary>
        public static uint2x2 operator *(uint2x2 a, uint2x2 b) => mul(a, b);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static uint2x2 operator *(uint2x2 m, uint s) => new uint2x2(m.c0 * s, m.c1 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static uint2x2 operator *(uint s, uint2x2 m) => new uint2x2(m.c0 * s, m.c1 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static uint2x2 operator /(uint2x2 m, uint s) => new uint2x2(m.c0 / s, m.c1 / s);
        /// <summary>Returns the matrix unchanged.</summary>
        public static uint2x2 operator +(uint2x2 m) => m;
        /// <summary>Negates each component; unsigned negation wraps, matching HLSL.</summary>
        public static uint2x2 operator -(uint2x2 m) => new uint2x2(-m.c0, -m.c1);
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static uint2 operator *(uint2x2 m, uint2 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static uint2 operator *(uint2 v, uint2x2 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint2x2 mul(uint2x2 m, uint s) => m * s;
        /// <summary>
        /// Multiplies a <see cref="uint2x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint2 mul(uint2x2 m, uint2 v) => m.c0 * v.x + m.c1 * v.y;
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint2x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint2 mul(uint2 v, uint2x2 m) => new uint2(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y);

        /// <summary>
        /// Multiplies two <see cref="uint2x2"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x2 mul(uint2x2 a, uint2x2 b) => new uint2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y);
        /// <summary>
        /// Multiplies a <see cref="uint2x2"/> by a <see cref="uint2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x3 mul(uint2x2 a, uint2x3 b) => new uint2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y);
        /// <summary>
        /// Multiplies a <see cref="uint2x2"/> by a <see cref="uint2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint2x4 mul(uint2x2 a, uint2x4 b) => new uint2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y,
            a.c0 * b.c3.x + a.c1 * b.c3.y);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint2x2 transpose(uint2x2 m) => new uint2x2(m.c0.x, m.c0.y, m.c1.x, m.c1.y);
        /// <summary>
        /// Unsigned integer matrices promote to float, matching HLSL, so the determinant is
        /// computed in float rather than wrapping the way an unsigned determinant would.
        /// </summary>
        public static float determinant(uint2x2 m) => float2x2.determinant((float2x2)m);

        /// <summary>Unsigned integer matrix inverse is a float2x2 (integer inverses are generally not integral).</summary>
        public static float2x2 inverse(uint2x2 m) => float2x2.inverse((float2x2)m);
        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly uint2x2 transpose() => transpose(this);
        /// <summary>Computes the determinant of the matrix, promoting to float.</summary>
        public readonly float determinant() => determinant(this);
        /// <summary>Computes the inverse of the matrix as a <see cref="float2x2"/>, promoting to float.</summary>
        public readonly float2x2 inverse() => inverse(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(uint2x2 a, uint2x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(uint2x2 a, uint2x2 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="uint2x2"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="uint2x2"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="uint2x2"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is uint2x2 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"uint2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";

        /// <summary>Defines an implicit conversion from a <see cref="uint2x2"/> to a <see cref="float2x2"/> by converting each component.</summary>
        public static implicit operator float2x2(uint2x2 m) => new float2x2(m.c0.x, m.c1.x, m.c0.y, m.c1.y);
        /// <summary>Defines an implicit conversion from a <see cref="uint2x2"/> to an <see cref="int2x2"/> by converting each component.</summary>
        public static implicit operator int2x2(uint2x2 m) => new int2x2((int)m.c0.x, (int)m.c1.x, (int)m.c0.y, (int)m.c1.y);
        /// <summary>Defines an implicit conversion from a <see cref="uint2x2"/> to a <see cref="double2x2"/> by converting each component.</summary>
        public static implicit operator double2x2(uint2x2 m) => new double2x2(m.c0.x, m.c1.x, m.c0.y, m.c1.y);

        /// <summary>Defines an implicit conversion from a <see cref="uint2x2"/> to a <see cref="uint3x3"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator uint3x3(uint2x2 m) => new uint3x3(
            m.c0.x, m.c1.x, 0u,
            m.c0.y, m.c1.y, 0u,
            0u, 0u, 1u);
        /// <summary>Defines an implicit conversion from a <see cref="uint2x2"/> to a <see cref="uint4x4"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator uint4x4(uint2x2 m) => new uint4x4(
            m.c0.x, m.c1.x, 0u, 0u,
            m.c0.y, m.c1.y, 0u, 0u,
            0u, 0u, 1u, 0u,
            0u, 0u, 0u, 1u);
    }
}
