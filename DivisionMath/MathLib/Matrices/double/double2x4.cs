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
    /// Represents a 2x4 double matrix (2 rows, 4 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct double2x4
    {
        /// <summary>The first column of the matrix.</summary>
        public double2 c0;
        /// <summary>The second column of the matrix.</summary>
        public double2 c1;
        /// <summary>The third column of the matrix.</summary>
        public double2 c2;
        /// <summary>The fourth column of the matrix.</summary>
        public double2 c3;

        /// <summary>
        /// Initializes a new instance of the <see cref="double2x4"/> struct from eight component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m02">The value at row 0, column 2.</param>
        /// <param name="m03">The value at row 0, column 3.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m12">The value at row 1, column 2.</param>
        /// <param name="m13">The value at row 1, column 3.</param>
        public double2x4(double m00, double m01, double m02, double m03,
                         double m10, double m11, double m12, double m13)
        {
            c0 = new double2(m00, m10);
            c1 = new double2(m01, m11);
            c2 = new double2(m02, m12);
            c3 = new double2(m03, m13);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="double2x4"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        /// <param name="c2">The third column.</param>
        /// <param name="c3">The fourth column.</param>
        public double2x4(double2 c0, double2 c1, double2 c2, double2 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        /// <summary>
        /// Initializes a new instance of the <see cref="double2x4"/> struct from a 2x4 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 2x4 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 2x4 array.</exception>
        public double2x4(double[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 4)
                throw new ArgumentException("Matrix must be 2x4 (2 rows, 4 columns)");
            c0 = new double2(m[0, 0], m[1, 0]);
            c1 = new double2(m[0, 1], m[1, 1]);
            c2 = new double2(m[0, 2], m[1, 2]);
            c3 = new double2(m[0, 3], m[1, 3]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1, 2 = c2, 3 = c3).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-3.</exception>
        public double2 this[int column]
        {
            readonly get => column switch
            {
                0 => c0,
                1 => c1,
                2 => c2,
                3 => c3,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: c0 = value; break;
                    case 1: c1 = value; break;
                    case 2: c2 = value; break;
                    case 3: c3 = value; break;
                }
            }
        }
        /// <summary>
        /// Gets or sets the matrix component at the specified row and column.
        /// </summary>
        /// <param name="row">The zero-based row index.</param>
        /// <param name="column">The zero-based column index.</param>
        /// <returns>The component at the specified row and column.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown when <paramref name="row"/> or <paramref name="column"/> is out of range.</exception>
        public double this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, _ => throw new IndexOutOfRangeException() },
                3 => row switch { 0 => c3.x, 1 => c3.y, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: if (row == 0) c0.x = value; else if (row == 1) c0.y = value; else throw new IndexOutOfRangeException(); break;
                    case 1: if (row == 0) c1.x = value; else if (row == 1) c1.y = value; else throw new IndexOutOfRangeException(); break;
                    case 2: if (row == 0) c2.x = value; else if (row == 1) c2.y = value; else throw new IndexOutOfRangeException(); break;
                    case 3: if (row == 0) c3.x = value; else if (row == 1) c3.y = value; else throw new IndexOutOfRangeException(); break;
                }
            }
        }

        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static double2x4 zero => new double2x4(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0);

        /// <summary>Adds two matrices component-wise.</summary>
        public static double2x4 operator +(double2x4 a, double2x4 b) => new double2x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static double2x4 operator -(double2x4 a, double2x4 b) => new double2x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static double2x4 operator *(double2x4 m, double s) => new double2x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static double2x4 operator *(double s, double2x4 m) => new double2x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static double2x4 operator /(double2x4 m, double s) => new double2x4(m.c0 / s, m.c1 / s, m.c2 / s, m.c3 / s);
        /// <summary>Negates each component of the matrix.</summary>
        public static double2x4 operator -(double2x4 m) => new double2x4(-m.c0, -m.c1, -m.c2, -m.c3);
        /// <summary>Returns the matrix unchanged.</summary>
        public static double2x4 operator +(double2x4 m) => m;
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static double2 operator *(double2x4 m, double4 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static double4 operator *(double2 v, double2x4 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static double2x4 mul(double2x4 m, double s) => m * s;
        /// <summary>
        /// Multiplies a <see cref="double2x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static double2 mul(double2x4 m, double4 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z + m.c3 * v.w;
        /// <summary>
        /// Multiplies a row vector by a <see cref="double2x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static double4 mul(double2 v, double2x4 m) => new double4(
            v.x * m.c0.x + v.y * m.c0.y,
            v.x * m.c1.x + v.y * m.c1.y,
            v.x * m.c2.x + v.y * m.c2.y,
            v.x * m.c3.x + v.y * m.c3.y);

        /// <summary>
        /// Multiplies a <see cref="double2x4"/> by a <see cref="double4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x2 mul(double2x4 a, double4x2 b) => new double2x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        /// <summary>
        /// Multiplies a <see cref="double2x4"/> by a <see cref="double4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x3 mul(double2x4 a, double4x3 b) => new double2x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        /// <summary>
        /// Multiplies a <see cref="double2x4"/> by a <see cref="double4x4"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static double2x4 mul(double2x4 a, double4x4 b) => new double2x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static double4x2 transpose(double2x4 m) => new double4x2(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y,
            m.c2.x, m.c2.y,
            m.c3.x, m.c3.y);

        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly double4x2 transpose() => transpose(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(double2x4 a, double2x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(double2x4 a, double2x4 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="double2x4"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="double2x4"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="double2x4"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is double2x4 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"double2x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y})";

        /// <summary>Defines an implicit conversion from a <see cref="double2x4"/> to a <see cref="double4x4"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator double4x4(double2x4 m) => new double4x4(
            m.c0.x, m.c1.x, m.c2.x, m.c3.x,
            m.c0.y, m.c1.y, m.c2.y, m.c3.y,
            0.0, 0.0, 0.0, 0.0,
            0.0, 0.0, 0.0, 1.0);
    }
}
