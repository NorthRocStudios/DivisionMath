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
    /// Represents a 3x3 matrix in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float3x3
    {
        // Column-major storage (matching HLSL)
        /// <summary>The first column of the matrix.</summary>
        public float3 c0;
        /// <summary>The second column of the matrix.</summary>
        public float3 c1;
        /// <summary>The third column of the matrix.</summary>
        public float3 c2;

        #region Constructors

        // From 9 scalars (row-major order for convenience)
        /// <summary>
        /// Initializes a new instance of the <see cref="float3x3"/> struct from nine component values specified in row-major order.
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
        public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
        {
            c0 = new float3(m00, m10, m20);
            c1 = new float3(m01, m11, m21);
            c2 = new float3(m02, m12, m22);
        }

        // From 3 column vectors
        /// <summary>
        /// Initializes a new instance of the <see cref="float3x3"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        /// <param name="c2">The third column.</param>
        public float3x3(float3 c0, float3 c1, float3 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        // From single scalar (diagonal matrix)
        /// <summary>
        /// Initializes a new instance of the <see cref="float3x3"/> struct with the specified value on the main diagonal and zeros elsewhere.
        /// </summary>
        /// <param name="diagonal">The value placed on the main diagonal.</param>
        public float3x3(float diagonal)
        {
            c0 = new float3(diagonal, 0f, 0f);
            c1 = new float3(0f, diagonal, 0f);
            c2 = new float3(0f, 0f, diagonal);
        }

        // From 3x3 array (row-major)
        /// <summary>
        /// Initializes a new instance of the <see cref="float3x3"/> struct from a 3x3 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 3x3 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 3x3 array.</exception>
        public float3x3(float[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 3x3");
            c0 = new float3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new float3(m[0, 1], m[1, 1], m[2, 1]);
            c2 = new float3(m[0, 2], m[1, 2], m[2, 2]);
        }

        #endregion Constructors
        #region Indexers

        // Column-major indexer
        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1, 2 = c2).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-2.</exception>
        public float3 this[int column]
        {
            readonly get => column switch
            {
                0 => c0,
                1 => c1,
                2 => c2,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: c0 = value; break;
                    case 1: c1 = value; break;
                    case 2: c2 = value; break;
                }
            }
        }

        // Element access via [row, column]
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
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0:
                        switch (row)
                        {
                            case 0: c0.x = value; break;
                            case 1: c0.y = value; break;
                            case 2: c0.z = value; break;
                        }
                        break;
                    case 1:
                        switch (row)
                        {
                            case 0: c1.x = value; break;
                            case 1: c1.y = value; break;
                            case 2: c1.z = value; break;
                        }
                        break;
                    case 2:
                        switch (row)
                        {
                            case 0: c2.x = value; break;
                            case 1: c2.y = value; break;
                            case 2: c2.z = value; break;
                        }
                        break;
                }
            }
        }

        #endregion Indexers
        #region StaticProperties

        /// <summary>Gets the identity matrix.</summary>
        public static float3x3 identity => new float3x3(1f);
        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static float3x3 zero => new float3x3(0f);

        #endregion StaticProperties
        #region ArithmeticOperators

        // Matrix-Matrix
        /// <summary>Adds two matrices component-wise.</summary>
        public static float3x3 operator +(float3x3 a, float3x3 b) => new float3x3(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static float3x3 operator -(float3x3 a, float3x3 b) => new float3x3(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        /// <summary>Multiplies two matrices.</summary>
        public static float3x3 operator *(float3x3 a, float3x3 b) => mul(a, b);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static float3x3 operator *(float3x3 m, float scalar) => new float3x3(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static float3x3 operator *(float scalar, float3x3 m) => new float3x3(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static float3x3 operator /(float3x3 m, float scalar) => new float3x3(m.c0 / scalar, m.c1 / scalar, m.c2 / scalar);
        /// <summary>Negates each component of the matrix.</summary>
        public static float3x3 operator -(float3x3 m) => new float3x3(-m.c0, -m.c1, -m.c2);
        /// <summary>Returns the matrix unchanged.</summary>
        public static float3x3 operator +(float3x3 m) => m;

        // Matrix-Vector
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static float3 operator *(float3x3 m, float3 v) => v.x * m.c0 + v.y * m.c1 + v.z * m.c2;
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static float3 operator *(float3 v, float3x3 m) => mul(v, m);

        #endregion ArithmeticOperators
        #region StaticMethods

        /// <summary>
        /// Multiplies two <see cref="float3x3"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x3 mul(float3x3 a, float3x3 b) => new float3x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z
        );

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float3x3 mul(float3x3 m, float s) => m * s;
        /// <summary>
        /// Multiplies a <see cref="float3x3"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float3 mul(float3x3 m, float3 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z;
        /// <summary>
        /// Multiplies a row vector by a <see cref="float3x3"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float3 mul(float3 v, float3x3 m) => new float3(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z,
            v.x * m.c2.x + v.y * m.c2.y + v.z * m.c2.z);

        /// <summary>
        /// Multiplies a <see cref="float3x3"/> by a <see cref="float3x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x2 mul(float3x3 a, float3x2 b) => new float3x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);

        /// <summary>
        /// Multiplies a <see cref="float3x3"/> by a <see cref="float3x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float3x4 mul(float3x3 a, float3x4 b) => new float3x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float3x3 transpose(float3x3 m) => new float3x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z,
            m.c2.x, m.c2.y, m.c2.z
        );

        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(float3x3 m) =>
            m.c0.x * (m.c1.y * m.c2.z - m.c2.y * m.c1.z)
            - m.c1.x * (m.c0.y * m.c2.z - m.c2.y * m.c0.z)
            + m.c2.x * (m.c0.y * m.c1.z - m.c1.y * m.c0.z);

        /// <summary>
        /// Computes the inverse of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to invert.</param>
        /// <returns>The inverse of the matrix.</returns>
        public static float3x3 inverse(float3x3 m)
        {
            float det = determinant(m);
            float invDet = 1f / det;

            // The expressions below are the rows of the cofactor matrix. Supplying those rows as
            // the constructor's column vectors applies the transpose that the adjugate requires.
            return new float3x3(
                new float3(
                    (m.c1.y * m.c2.z - m.c2.y * m.c1.z) * invDet,
                    (m.c2.y * m.c0.z - m.c0.y * m.c2.z) * invDet,
                    (m.c0.y * m.c1.z - m.c1.y * m.c0.z) * invDet),
                new float3(
                    (m.c2.x * m.c1.z - m.c1.x * m.c2.z) * invDet,
                    (m.c0.x * m.c2.z - m.c2.x * m.c0.z) * invDet,
                    (m.c1.x * m.c0.z - m.c0.x * m.c1.z) * invDet),
                new float3(
                    (m.c1.x * m.c2.y - m.c2.x * m.c1.y) * invDet,
                    (m.c2.x * m.c0.y - m.c0.x * m.c2.y) * invDet,
                    (m.c0.x * m.c1.y - m.c1.x * m.c0.y) * invDet)
            );
        }

        #endregion StaticMethods
        #region InstanceMethods

        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly float3x3 transpose() => transpose(this);
        /// <summary>Computes the determinant of the matrix.</summary>
        public readonly float determinant() => determinant(this);
        /// <summary>Computes the inverse of the matrix.</summary>
        public readonly float3x3 inverse() => inverse(this);

        #endregion InstanceMethods
        #region Equality

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(float3x3 a, float3x3 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(float3x3 a, float3x3 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="float3x3"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="float3x3"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="float3x3"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is float3x3 other && this == other;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        #endregion Equality
        #region Conversion

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"float3x3({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y},  {c0.z}, {c1.z}, {c2.z})";

        // Conversion to float4x4
        /// <summary>Defines an implicit conversion from a <see cref="float3x3"/> to a <see cref="float4x4"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator float4x4(float3x3 m) => new float4x4(
            m.c0.x, m.c1.x, m.c2.x, 0f,
            m.c0.y, m.c1.y, m.c2.y, 0f,
            m.c0.z, m.c1.z, m.c2.z, 0f,
            0f, 0f, 0f, 1f
        );

        // Conversion from float2x2
        /// <summary>Defines an implicit conversion from a <see cref="float2x2"/> to a <see cref="float3x3"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator float3x3(float2x2 m) => new float3x3(
            m.c0.x, m.c1.x, 0f,
            m.c0.y, m.c1.y, 0f,
            0f, 0f, 1f
        );

        #endregion Conversion
    }
}
