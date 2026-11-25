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
    /// Represents a two-component vector of 32-bit signed integer values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>int2</c> type.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct int2
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public int x;
        /// <summary>The Y component of the vector.</summary>
        public int y;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-1.</exception>
        public int this[int index]
        {
            readonly get => index switch
            {
                0 => x,
                1 => y,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                }
            }
        }

        // Overrides

        /// <summary>Returns a string representation of the vector.</summary>
        public override readonly string ToString() => $"int2({x}, {y})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="int2"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="int2"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is an <see cref="int2"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is int2 other && x == other.x && y == other.y;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="int2"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public int2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int2"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public int2(int value)
        {
            x = value;
            y = value;
        }

        // Unary Operations

        /// <summary>Negates each component of the vector.</summary>
        public static int2 operator -(int2 v) => new int2(-v.x, -v.y);
        /// <summary>Returns the vector unchanged.</summary>
        public static int2 operator +(int2 v) => v;

        // Implicit Operations

        /// <summary>Defines an implicit conversion from an <see cref="int4"/> to an <see cref="int2"/>, discarding the Z and W components.</summary>
        public static implicit operator int2(int4 v) => new int2(v.x, v.y);
        /// <summary>Defines an implicit conversion from an <see cref="int3"/> to an <see cref="int2"/>, discarding the Z component.</summary>
        public static implicit operator int2(int3 v) => new int2(v.x, v.y);
        /// <summary>Defines an implicit conversion from an <see cref="int"/> to an <see cref="int2"/>, replicating the value across all components.</summary>
        public static implicit operator int2(int v) => new int2(v);

        // Unit Vectors

        /// <summary>Gets a vector with all components set to zero.</summary>
        public static int2 zero => new int2(0);
        /// <summary>Gets a vector with all components set to one.</summary>
        public static int2 one => new int2(1);
        /// <summary>Gets the unit vector along the X axis, (1, 0).</summary>
        public static int2 unitX => new int2(1, 0);
        /// <summary>Gets the unit vector along the Y axis, (0, 1).</summary>
        public static int2 unitY => new int2(0, 1);

        // Arithmetic Operations

        /// <summary>Adds two vectors component-wise.</summary>
        public static int2 operator +(int2 a, int2 b) => new int2(a.x + b.x, a.y + b.y);
        /// <summary>Subtracts two vectors component-wise.</summary>
        public static int2 operator -(int2 a, int2 b) => new int2(a.x - b.x, a.y - b.y);
        /// <summary>Multiplies two vectors component-wise.</summary>
        public static int2 operator *(int2 a, int2 b) => new int2(a.x * b.x, a.y * b.y);
        /// <summary>Divides two vectors component-wise.</summary>
        public static int2 operator /(int2 a, int2 b) => new int2(a.x / b.x, a.y / b.y);

        /// <summary>Adds a scalar value to each component of the vector.</summary>
        public static int2 operator +(int2 a, int b) => new int2(a.x + b, a.y + b);
        /// <summary>Subtracts a scalar value from each component of the vector.</summary>
        public static int2 operator -(int2 a, int b) => new int2(a.x - b, a.y - b);
        /// <summary>Multiplies each component of the vector by a scalar value.</summary>
        public static int2 operator *(int2 a, int b) => new int2(a.x * b, a.y * b);
        /// <summary>Divides each component of the vector by a scalar value.</summary>
        public static int2 operator /(int2 a, int b) => new int2(a.x / b, a.y / b);

        /// <summary>Adds each component of the vector to a scalar value.</summary>
        public static int2 operator +(int a, int2 b) => new int2(a + b.x, a + b.y);
        /// <summary>Subtracts each component of the vector from a scalar value.</summary>
        public static int2 operator -(int a, int2 b) => new int2(a - b.x, a - b.y);
        /// <summary>Multiplies a scalar value by each component of the vector.</summary>
        public static int2 operator *(int a, int2 b) => new int2(a * b.x, a * b.y);
        /// <summary>Divides a scalar value by each component of the vector.</summary>
        public static int2 operator /(int a, int2 b) => new int2(a / b.x, a / b.y);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator ==(int2 a, int2 b) => new bool2(a.x == b.x, a.y == b.y);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator !=(int2 a, int2 b) => new bool2(a.x != b.x, a.y != b.y);
        /// <summary>Performs a component-wise less-than comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator <(int2 a, int2 b) => new bool2(a.x < b.x, a.y < b.y);
        /// <summary>Performs a component-wise greater-than comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator >(int2 a, int2 b) => new bool2(a.x > b.x, a.y > b.y);
        /// <summary>Performs a component-wise less-than-or-equal comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator <=(int2 a, int2 b) => new bool2(a.x <= b.x, a.y <= b.y);
        /// <summary>Performs a component-wise greater-than-or-equal comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator >=(int2 a, int2 b) => new bool2(a.x >= b.x, a.y >= b.y);

        // Scalar-vector comparisons
        /// <summary>Compares each component of the vector with a scalar value using equality and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator ==(int2 a, int b) => new bool2(a.x == b, a.y == b);
        /// <summary>Compares each component of the vector with a scalar value using inequality and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator !=(int2 a, int b) => new bool2(a.x != b, a.y != b);
        /// <summary>Compares each component of the vector with a scalar value using less-than and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator <(int2 a, int b) => new bool2(a.x < b, a.y < b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator >(int2 a, int b) => new bool2(a.x > b, a.y > b);
        /// <summary>Compares each component of the vector with a scalar value using less-than-or-equal and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator <=(int2 a, int b) => new bool2(a.x <= b, a.y <= b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than-or-equal and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator >=(int2 a, int b) => new bool2(a.x >= b, a.y >= b);

        /// <summary>Compares a scalar value with each component of the vector using equality and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator ==(int a, int2 b) => new bool2(a == b.x, a == b.y);
        /// <summary>Compares a scalar value with each component of the vector using inequality and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator !=(int a, int2 b) => new bool2(a != b.x, a != b.y);
        /// <summary>Compares a scalar value with each component of the vector using less-than and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator <(int a, int2 b) => new bool2(a < b.x, a < b.y);
        /// <summary>Compares a scalar value with each component of the vector using greater-than and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator >(int a, int2 b) => new bool2(a > b.x, a > b.y);
        /// <summary>Compares a scalar value with each component of the vector using less-than-or-equal and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator <=(int a, int2 b) => new bool2(a <= b.x, a <= b.y);
        /// <summary>Compares a scalar value with each component of the vector using greater-than-or-equal and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator >=(int a, int2 b) => new bool2(a >= b.x, a >= b.y);

        // Swizzling

        /// <summary>Gets the <c>xx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xx => new int2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xy => new int2(x, y);
        /// <summary>Gets the <c>yx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yx => new int2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yy => new int2(y, y);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly int r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly int g => y;

        /// <summary>Gets the <c>rr</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 rr => new int2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 rg => new int2(r, g);
        /// <summary>Gets the <c>gr</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 gr => new int2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 gg => new int2(g, g);
    }
}
