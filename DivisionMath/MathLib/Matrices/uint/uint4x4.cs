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
    /// Represents a 4x4 uint matrix (4 rows, 4 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct uint4x4
    {
        /// <summary>The first column of the matrix.</summary>
        public uint4 c0;
        /// <summary>The second column of the matrix.</summary>
        public uint4 c1;
        /// <summary>The third column of the matrix.</summary>
        public uint4 c2;
        /// <summary>The fourth column of the matrix.</summary>
        public uint4 c3;

        /// <summary>
        /// Initializes a new instance of the <see cref="uint4x4"/> struct from sixteen component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m02">The value at row 0, column 2.</param>
        /// <param name="m03">The value at row 0, column 3.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m12">The value at row 1, column 2.</param>
        /// <param name="m13">The value at row 1, column 3.</param>
        /// <param name="m20">The value at row 2, column 0.</param>
        /// <param name="m21">The value at row 2, column 1.</param>
        /// <param name="m22">The value at row 2, column 2.</param>
        /// <param name="m23">The value at row 2, column 3.</param>
        /// <param name="m30">The value at row 3, column 0.</param>
        /// <param name="m31">The value at row 3, column 1.</param>
        /// <param name="m32">The value at row 3, column 2.</param>
        /// <param name="m33">The value at row 3, column 3.</param>
        public uint4x4(uint m00, uint m01, uint m02, uint m03,
                       uint m10, uint m11, uint m12, uint m13,
                       uint m20, uint m21, uint m22, uint m23,
                       uint m30, uint m31, uint m32, uint m33)
        {
            c0 = new uint4(m00, m10, m20, m30);
            c1 = new uint4(m01, m11, m21, m31);
            c2 = new uint4(m02, m12, m22, m32);
            c3 = new uint4(m03, m13, m23, m33);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="uint4x4"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        /// <param name="c2">The third column.</param>
        /// <param name="c3">The fourth column.</param>
        public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        /// <summary>
        /// Initializes a new instance of the <see cref="uint4x4"/> struct with the specified value on the main diagonal and zeros elsewhere.
        /// </summary>
        /// <param name="diagonal">The value placed on the main diagonal.</param>
        public uint4x4(uint diagonal)
        {
            c0 = new uint4(diagonal, 0u, 0u, 0u);
            c1 = new uint4(0u, diagonal, 0u, 0u);
            c2 = new uint4(0u, 0u, diagonal, 0u);
            c3 = new uint4(0u, 0u, 0u, diagonal);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="uint4x4"/> struct from a 4x4 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 4x4 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 4x4 array.</exception>
        public uint4x4(uint[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 4) throw new ArgumentException("Matrix must be 4x4");
            c0 = new uint4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new uint4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new uint4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
            c3 = new uint4(m[0, 3], m[1, 3], m[2, 3], m[3, 3]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1, 2 = c2, 3 = c3).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-3.</exception>
        public uint4 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, 3 => c3, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; case 3: c3 = value; break; } }
        }
        /// <summary>
        /// Gets or sets the matrix component at the specified row and column.
        /// </summary>
        /// <param name="row">The zero-based row index.</param>
        /// <param name="column">The zero-based column index.</param>
        /// <returns>The component at the specified row and column.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="row"/> or <paramref name="column"/> is out of range.</exception>
        public uint this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, 3 => c0.w, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, 3 => c1.w, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, 3 => c2.w, _ => throw new IndexOutOfRangeException() },
                3 => row switch { 0 => c3.x, 1 => c3.y, 2 => c3.z, 3 => c3.w, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; case 3: c0.w = value; break; } break;
                    case 1: switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; case 3: c1.w = value; break; } break;
                    case 2: switch (row) { case 0: c2.x = value; break; case 1: c2.y = value; break; case 2: c2.z = value; break; case 3: c2.w = value; break; } break;
                    case 3: switch (row) { case 0: c3.x = value; break; case 1: c3.y = value; break; case 2: c3.z = value; break; case 3: c3.w = value; break; } break;
                }
            }
        }

        /// <summary>Gets the identity matrix.</summary>
        public static uint4x4 identity => new uint4x4(1u);
        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static uint4x4 zero => new uint4x4(0u);

        /// <summary>Adds two matrices component-wise.</summary>
        public static uint4x4 operator +(uint4x4 a, uint4x4 b) => new uint4x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static uint4x4 operator -(uint4x4 a, uint4x4 b) => new uint4x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        /// <summary>Multiplies two matrices.</summary>
        public static uint4x4 operator *(uint4x4 a, uint4x4 b) => mul(a, b);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static uint4x4 operator *(uint4x4 m, uint s) => new uint4x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static uint4x4 operator *(uint s, uint4x4 m) => new uint4x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static uint4x4 operator /(uint4x4 m, uint s) => new uint4x4(m.c0 / s, m.c1 / s, m.c2 / s, m.c3 / s);
        /// <summary>Returns the matrix unchanged.</summary>
        public static uint4x4 operator +(uint4x4 m) => m;
        /// <summary>Negates each component; unsigned negation wraps, matching HLSL.</summary>
        public static uint4x4 operator -(uint4x4 m) => new uint4x4(-m.c0, -m.c1, -m.c2, -m.c3);
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static uint4 operator *(uint4x4 m, uint4 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static uint4 operator *(uint4 v, uint4x4 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static uint4x4 mul(uint4x4 m, uint s) => m * s;
        /// <summary>
        /// Multiplies a <see cref="uint4x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static uint4 mul(uint4x4 m, uint4 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z + m.c3 * v.w;
        /// <summary>
        /// Multiplies a row vector by a <see cref="uint4x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static uint4 mul(uint4 v, uint4x4 m) => new uint4(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z + v.w * m.c0.w,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z + v.w * m.c1.w,
            v.x * m.c2.x + v.y * m.c2.y + v.z * m.c2.z + v.w * m.c2.w,
            v.x * m.c3.x + v.y * m.c3.y + v.z * m.c3.z + v.w * m.c3.w);

        /// <summary>
        /// Multiplies a <see cref="uint4x4"/> by a <see cref="uint4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x2 mul(uint4x4 a, uint4x2 b) => new uint4x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        /// <summary>
        /// Multiplies a <see cref="uint4x4"/> by a <see cref="uint4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x3 mul(uint4x4 a, uint4x3 b) => new uint4x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        /// <summary>
        /// Multiplies two <see cref="uint4x4"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static uint4x4 mul(uint4x4 a, uint4x4 b) => new uint4x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static uint4x4 transpose(uint4x4 m) => new uint4x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w,
            m.c2.x, m.c2.y, m.c2.z, m.c2.w,
            m.c3.x, m.c3.y, m.c3.z, m.c3.w);
        /// <summary>
        /// Unsigned integer matrices promote to float, matching HLSL, so the determinant is
        /// computed in float rather than wrapping the way an unsigned determinant would.
        /// </summary>
        public static float determinant(uint4x4 m) => float4x4.determinant((float4x4)m);

        /// <summary>Unsigned integer matrix inverse is a float4x4 (integer inverses are generally not integral).</summary>
        public static float4x4 inverse(uint4x4 m) => float4x4.inverse((float4x4)m);
        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly uint4x4 transpose() => transpose(this);
        /// <summary>Computes the determinant of the matrix, promoting to float.</summary>
        public readonly float determinant() => determinant(this);
        /// <summary>Computes the inverse of the matrix as a <see cref="float4x4"/>, promoting to float.</summary>
        public readonly float4x4 inverse() => inverse(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(uint4x4 a, uint4x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(uint4x4 a, uint4x4 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="uint4x4"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="uint4x4"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="uint4x4"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is uint4x4 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() =>
            $"uint4x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z},  {c0.w}, {c1.w}, {c2.w}, {c3.w})";

        /// <summary>Defines an implicit conversion from a <see cref="uint4x4"/> to a <see cref="float4x4"/> by converting each component.</summary>
        public static implicit operator float4x4(uint4x4 m) => new float4x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y,
            m.c0.z, m.c1.z, m.c2.z, m.c3.z,
            m.c0.w, m.c1.w, m.c2.w, m.c3.w);
        /// <summary>Defines an implicit conversion from a <see cref="uint4x4"/> to an <see cref="int4x4"/> by converting each component.</summary>
        public static implicit operator int4x4(uint4x4 m) => new int4x4(
            (int)m.c0.x, (int)m.c1.x, (int)m.c2.x, (int)m.c3.x,
            (int)m.c0.y, (int)m.c1.y, (int)m.c2.y, (int)m.c3.y,
            (int)m.c0.z, (int)m.c1.z, (int)m.c2.z, (int)m.c3.z,
            (int)m.c0.w, (int)m.c1.w, (int)m.c2.w, (int)m.c3.w);
        /// <summary>Defines an implicit conversion from a <see cref="uint4x4"/> to a <see cref="double4x4"/> by converting each component.</summary>
        public static implicit operator double4x4(uint4x4 m) => new double4x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y,
            m.c0.z, m.c1.z, m.c2.z, m.c3.z,
            m.c0.w, m.c1.w, m.c2.w, m.c3.w);
    }
}
