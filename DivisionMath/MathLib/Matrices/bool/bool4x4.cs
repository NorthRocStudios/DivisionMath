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
    /// Represents a 4x4 boolean matrix (4 rows, 4 columns) in column-major order.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool4x4
    {
        /// <summary>The first column of the matrix.</summary>
        public bool4 c0;
        /// <summary>The second column of the matrix.</summary>
        public bool4 c1;
        /// <summary>The third column of the matrix.</summary>
        public bool4 c2;
        /// <summary>The fourth column of the matrix.</summary>
        public bool4 c3;

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4x4"/> struct from sixteen component values specified in row-major order.
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
        public bool4x4(bool m00, bool m01, bool m02, bool m03,
                       bool m10, bool m11, bool m12, bool m13,
                       bool m20, bool m21, bool m22, bool m23,
                       bool m30, bool m31, bool m32, bool m33)
        {
            c0 = new bool4(m00, m10, m20, m30);
            c1 = new bool4(m01, m11, m21, m31);
            c2 = new bool4(m02, m12, m22, m32);
            c3 = new bool4(m03, m13, m23, m33);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="bool4x4"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        /// <param name="c2">The third column.</param>
        /// <param name="c3">The fourth column.</param>
        public bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        /// <summary>
        /// Initializes a new instance of the <see cref="bool4x4"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public bool4x4(bool value) { c0 = new bool4(value); c1 = new bool4(value); c2 = new bool4(value); c3 = new bool4(value); }
        /// <summary>
        /// Initializes a new instance of the <see cref="bool4x4"/> struct from a 4x4 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 4x4 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 4x4 array.</exception>
        public bool4x4(bool[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 4) throw new ArgumentException("Matrix must be 4x4");
            c0 = new bool4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new bool4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new bool4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
            c3 = new bool4(m[0, 3], m[1, 3], m[2, 3], m[3, 3]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1, 2 = c2, 3 = c3).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-3.</exception>
        public bool4 this[int column]
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
        public bool this[int row, int column]
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

        /// <summary>Gets a matrix with all components set to <see langword="false"/>.</summary>
        public static bool4x4 off => new bool4x4(false);
        /// <summary>Gets a matrix with all components set to <see langword="true"/>.</summary>
        public static bool4x4 on => new bool4x4(true);
        /// <summary>Gets a matrix with all components set to <see langword="false"/>.</summary>
        public static bool4x4 zero => off;
        /// <summary>Gets the identity matrix, with <see langword="true"/> on the main diagonal and <see langword="false"/> everywhere else.</summary>
        public static bool4x4 identity => new bool4x4(
            true, false, false, false,
            false, true, false, false,
            false, false, true, false,
            false, false, false, true);

        /// <summary>Computes the logical negation of each component.</summary>
        public static bool4x4 operator !(bool4x4 m) => new bool4x4(!m.c0, !m.c1, !m.c2, !m.c3);

        /// <summary>Computes the component-wise logical AND of two matrices.</summary>
        public static bool4x4 operator &(bool4x4 a, bool4x4 b) => new bool4x4(a.c0 & b.c0, a.c1 & b.c1, a.c2 & b.c2, a.c3 & b.c3);
        /// <summary>Computes the logical AND of each component and a scalar value.</summary>
        public static bool4x4 operator &(bool4x4 a, bool b) => new bool4x4(a.c0 & b, a.c1 & b, a.c2 & b, a.c3 & b);
        /// <summary>Computes the logical AND of a scalar value and each component of the matrix.</summary>
        public static bool4x4 operator &(bool a, bool4x4 b) => new bool4x4(a & b.c0, a & b.c1, a & b.c2, a & b.c3);

        /// <summary>Computes the component-wise logical OR of two matrices.</summary>
        public static bool4x4 operator |(bool4x4 a, bool4x4 b) => new bool4x4(a.c0 | b.c0, a.c1 | b.c1, a.c2 | b.c2, a.c3 | b.c3);
        /// <summary>Computes the logical OR of each component and a scalar value.</summary>
        public static bool4x4 operator |(bool4x4 a, bool b) => new bool4x4(a.c0 | b, a.c1 | b, a.c2 | b, a.c3 | b);
        /// <summary>Computes the logical OR of a scalar value and each component of the matrix.</summary>
        public static bool4x4 operator |(bool a, bool4x4 b) => new bool4x4(a | b.c0, a | b.c1, a | b.c2, a | b.c3);

        /// <summary>Computes the component-wise logical XOR of two matrices.</summary>
        public static bool4x4 operator ^(bool4x4 a, bool4x4 b) => new bool4x4(a.c0 ^ b.c0, a.c1 ^ b.c1, a.c2 ^ b.c2, a.c3 ^ b.c3);
        /// <summary>Computes the logical XOR of each component and a scalar value.</summary>
        public static bool4x4 operator ^(bool4x4 a, bool b) => new bool4x4(a.c0 ^ b, a.c1 ^ b, a.c2 ^ b, a.c3 ^ b);
        /// <summary>Computes the logical XOR of a scalar value and each component of the matrix.</summary>
        public static bool4x4 operator ^(bool a, bool4x4 b) => new bool4x4(a ^ b.c0, a ^ b.c1, a ^ b.c2, a ^ b.c3);

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool4x4"/>.</summary>
        public static bool4x4 operator ==(bool4x4 a, bool4x4 b) => new bool4x4(a.c0 == b.c0, a.c1 == b.c1, a.c2 == b.c2, a.c3 == b.c3);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool4x4"/>.</summary>
        public static bool4x4 operator !=(bool4x4 a, bool4x4 b) => new bool4x4(a.c0 != b.c0, a.c1 != b.c1, a.c2 != b.c2, a.c3 != b.c3);
        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool4x4"/>.</summary>
        public static bool4x4 operator ==(bool4x4 a, bool b) => new bool4x4(a.c0 == b, a.c1 == b, a.c2 == b, a.c3 == b);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool4x4"/>.</summary>
        public static bool4x4 operator !=(bool4x4 a, bool b) => new bool4x4(a.c0 != b, a.c1 != b, a.c2 != b, a.c3 != b);
        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool4x4"/>.</summary>
        public static bool4x4 operator ==(bool a, bool4x4 b) => new bool4x4(a == b.c0, a == b.c1, a == b.c2, a == b.c3);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool4x4"/>.</summary>
        public static bool4x4 operator !=(bool a, bool4x4 b) => new bool4x4(a != b.c0, a != b.c1, a != b.c2, a != b.c3);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static bool4x4 transpose(bool4x4 m) => new bool4x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w,
            m.c2.x, m.c2.y, m.c2.z, m.c2.w,
            m.c3.x, m.c3.y, m.c3.z, m.c3.w);
        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly bool4x4 transpose() => transpose(this);

        /// <summary>Gets a value indicating whether all components of the matrix are <see langword="true"/>.</summary>
        public readonly bool all => c0.all && c1.all && c2.all && c3.all;
        /// <summary>Gets a value indicating whether any component of the matrix is <see langword="true"/>.</summary>
        public readonly bool any => c0.any || c1.any || c2.any || c3.any;

        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="bool4x4"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="bool4x4"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="bool4x4"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is bool4x4 o && (c0 == o.c0).all && (c1 == o.c1).all && (c2 == o.c2).all && (c3 == o.c3).all;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() =>
            $"bool4x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z},  {c0.w}, {c1.w}, {c2.w}, {c3.w})";
    }
}
