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
    /// Represents a 3x2 boolean matrix (3 rows, 2 columns) in column-major order.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool3x2
    {
        /// <summary>The first column of the matrix.</summary>
        public bool3 c0;
        /// <summary>The second column of the matrix.</summary>
        public bool3 c1;

        /// <summary>
        /// Initializes a new instance of the <see cref="bool3x2"/> struct from six component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m20">The value at row 2, column 0.</param>
        /// <param name="m21">The value at row 2, column 1.</param>
        public bool3x2(bool m00, bool m01,
                       bool m10, bool m11,
                       bool m20, bool m21)
        {
            c0 = new bool3(m00, m10, m20);
            c1 = new bool3(m01, m11, m21);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="bool3x2"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        public bool3x2(bool3 c0, bool3 c1) { this.c0 = c0; this.c1 = c1; }
        /// <summary>
        /// Initializes a new instance of the <see cref="bool3x2"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public bool3x2(bool value) { c0 = new bool3(value); c1 = new bool3(value); }
        /// <summary>
        /// Initializes a new instance of the <see cref="bool3x2"/> struct from a 3x2 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 3x2 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 3x2 array.</exception>
        public bool3x2(bool[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 3x2 (3 rows, 2 columns)");
            c0 = new bool3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new bool3(m[0, 1], m[1, 1], m[2, 1]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-1.</exception>
        public bool3 this[int column]
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
        public bool this[int row, int column]
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

        /// <summary>Gets a matrix with all components set to <see langword="false"/>.</summary>
        public static bool3x2 off => new bool3x2(false);
        /// <summary>Gets a matrix with all components set to <see langword="true"/>.</summary>
        public static bool3x2 on => new bool3x2(true);
        /// <summary>Gets a matrix with all components set to <see langword="false"/>.</summary>
        public static bool3x2 zero => off;

        /// <summary>Computes the logical negation of each component.</summary>
        public static bool3x2 operator !(bool3x2 m) => new bool3x2(!m.c0, !m.c1);

        /// <summary>Computes the component-wise logical AND of two matrices.</summary>
        public static bool3x2 operator &(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 & b.c0, a.c1 & b.c1);
        /// <summary>Computes the logical AND of each component and a scalar value.</summary>
        public static bool3x2 operator &(bool3x2 a, bool b) => new bool3x2(a.c0 & b, a.c1 & b);
        /// <summary>Computes the logical AND of a scalar value and each component of the matrix.</summary>
        public static bool3x2 operator &(bool a, bool3x2 b) => new bool3x2(a & b.c0, a & b.c1);

        /// <summary>Computes the component-wise logical OR of two matrices.</summary>
        public static bool3x2 operator |(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 | b.c0, a.c1 | b.c1);
        /// <summary>Computes the logical OR of each component and a scalar value.</summary>
        public static bool3x2 operator |(bool3x2 a, bool b) => new bool3x2(a.c0 | b, a.c1 | b);
        /// <summary>Computes the logical OR of a scalar value and each component of the matrix.</summary>
        public static bool3x2 operator |(bool a, bool3x2 b) => new bool3x2(a | b.c0, a | b.c1);

        /// <summary>Computes the component-wise logical XOR of two matrices.</summary>
        public static bool3x2 operator ^(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 ^ b.c0, a.c1 ^ b.c1);
        /// <summary>Computes the logical XOR of each component and a scalar value.</summary>
        public static bool3x2 operator ^(bool3x2 a, bool b) => new bool3x2(a.c0 ^ b, a.c1 ^ b);
        /// <summary>Computes the logical XOR of a scalar value and each component of the matrix.</summary>
        public static bool3x2 operator ^(bool a, bool3x2 b) => new bool3x2(a ^ b.c0, a ^ b.c1);

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3x2"/>.</summary>
        public static bool3x2 operator ==(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 == b.c0, a.c1 == b.c1);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3x2"/>.</summary>
        public static bool3x2 operator !=(bool3x2 a, bool3x2 b) => new bool3x2(a.c0 != b.c0, a.c1 != b.c1);
        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3x2"/>.</summary>
        public static bool3x2 operator ==(bool3x2 a, bool b) => new bool3x2(a.c0 == b, a.c1 == b);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3x2"/>.</summary>
        public static bool3x2 operator !=(bool3x2 a, bool b) => new bool3x2(a.c0 != b, a.c1 != b);
        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3x2"/>.</summary>
        public static bool3x2 operator ==(bool a, bool3x2 b) => new bool3x2(a == b.c0, a == b.c1);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3x2"/>.</summary>
        public static bool3x2 operator !=(bool a, bool3x2 b) => new bool3x2(a != b.c0, a != b.c1);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool2x3 transpose(bool3x2 m) => new bool2x3(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z);
        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly bool2x3 transpose() => transpose(this);

        /// <summary>Gets a value indicating whether all components of the matrix are <see langword="true"/>.</summary>
        public readonly bool all => c0.all && c1.all;
        /// <summary>Gets a value indicating whether any component of the matrix is <see langword="true"/>.</summary>
        public readonly bool any => c0.any || c1.any;

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="bool3x2"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="bool3x2"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="bool3x2"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is bool3x2 o && (c0 == o.c0).all && (c1 == o.c1).all;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() => $"bool3x2({c0.x}, {c1.x},  {c0.y}, {c1.y},  {c0.z}, {c1.z})";

        /// <summary>Defines an implicit conversion from a <see cref="bool3x2"/> to a <see cref="bool3x3"/>, placing the source in the upper-left corner and padding the remaining components with the identity matrix.</summary>
        public static implicit operator bool3x3(bool3x2 m) => new bool3x3(
            m.c0.x, m.c1.x, false,
            m.c0.y, m.c1.y, false,
            m.c0.z, m.c1.z, true);
    }

}
