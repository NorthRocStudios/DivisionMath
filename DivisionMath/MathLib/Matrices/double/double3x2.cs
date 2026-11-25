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
    /// Represents a 3x2 double matrix (3 rows, 2 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct double3x2
    {
        /// <summary>The first column of the matrix.</summary>
        public double3 c0;
        /// <summary>The second column of the matrix.</summary>
        public double3 c1;

        /// <summary>
        /// Initializes a new instance of the <see cref="double3x2"/> struct from six component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m20">The value at row 2, column 0.</param>
        /// <param name="m21">The value at row 2, column 1.</param>
        public double3x2(double m00, double m01,
                         double m10, double m11,
                         double m20, double m21)
        {
            c0 = new double3(m00, m10, m20);
            c1 = new double3(m01, m11, m21);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="double3x2"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        public double3x2(double3 c0, double3 c1) { this.c0 = c0; this.c1 = c1; }
        /// <summary>
        /// Initializes a new instance of the <see cref="double3x2"/> struct from a 3x2 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 3x2 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 3x2 array.</exception>
        public double3x2(double[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 3x2 (3 rows, 2 columns)");
            c0 = new double3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new double3(m[0, 1], m[1, 1], m[2, 1]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-1.</exception>
        public double3 this[int column]
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
        public double this[int row, int column]
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
        public static double3x2 zero => new double3x2(0.0, 0.0, 0.0, 0.0, 0.0, 0.0);

        /// <summary>Adds two matrices component-wise.</summary>
        public static double3x2 operator +(double3x2 a, double3x2 b) => new double3x2(a.c0 + b.c0, a.c1 + b.c1);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static double3x2 operator -(double3x2 a, double3x2 b) => new double3x2(a.c0 - b.c0, a.c1 - b.c1);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static double3x2 operator *(double3x2 m, double s) => new double3x2(m.c0 * s, m.c1 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static double3x2 operator *(double s, double3x2 m) => new double3x2(m.c0 * s, m.c1 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static double3x2 operator /(double3x2 m, double s) => new double3x2(m.c0 / s, m.c1 / s);
        /// <summary>Negates each component of the matrix.</summary>
        public static double3x2 operator -(double3x2 m) => new double3x2(-m.c0, -m.c1);
        /// <summary>Returns the matrix unchanged.</summary>
        public static double3x2 operator +(double3x2 m) => m;
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static double3 operator *(double3x2 m, double2 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static double2 operator *(double3 v, double3x2 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double3x2 mul(double3x2 m, double s) => m * s;
        /// <summary>
        /// Multiplies a <see cref="double3x2"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double3 mul(double3x2 m, double2 v) => m.c0 * v.x + m.c1 * v.y;
        /// <summary>
        /// Multiplies a row vector by a <see cref="double3x2"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double2 mul(double3 v, double3x2 m) => new double2(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z);

        /// <summary>
        /// Multiplies a <see cref="double3x2"/> by a <see cref="double2x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x2 mul(double3x2 a, double2x2 b) => new double3x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y);
        /// <summary>
        /// Multiplies a <see cref="double3x2"/> by a <see cref="double2x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x3 mul(double3x2 a, double2x3 b) => new double3x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y);
        /// <summary>
        /// Multiplies a <see cref="double3x2"/> by a <see cref="double2x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double3x4 mul(double3x2 a, double2x4 b) => new double3x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y,
            a.c0 * b.c1.x + a.c1 * b.c1.y,
            a.c0 * b.c2.x + a.c1 * b.c2.y,
            a.c0 * b.c3.x + a.c1 * b.c3.y);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double2x3 transpose(double3x2 m) => new double2x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z);

        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly double2x3 transpose() => transpose(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(double3x2 a, double3x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(double3x2 a, double3x2 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="double3x2"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="double3x2"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="double3x2"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is double3x2 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"double3x2({c0.x}, {c1.x},  {c0.y}, {c1.y},  {c0.z}, {c1.z})";

        /// <summary>Defines an implicit conversion from a <see cref="double3x2"/> to a <see cref="double3x3"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator double3x3(double3x2 m) => new double3x3(
            m.c0.x, m.c1.x, 0.0,
            m.c0.y, m.c1.y, 0.0,
            m.c0.z, m.c1.z, 1.0);
    }
}
