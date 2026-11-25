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
    /// Represents a two-component vector of boolean values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>bool2</c> type.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool2
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public bool x;
        /// <summary>The Y component of the vector.</summary>
        public bool y;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-1.</exception>
        public bool this[int index]
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
        public override readonly string ToString() => $"bool2({x}, {y})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="bool2"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="bool2"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="bool2"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is bool2 other && x == other.x && y == other.y;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="bool2"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        public bool2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool2"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public bool2(bool value)
        {
            x = value;
            y = value;
        }

        // Unary Operations

        /// <summary>Computes the logical negation of each component.</summary>
        public static bool2 operator !(bool2 v) => new bool2(!v.x, !v.y);
        /// <summary>Returns <see langword="true"/> when all components are <see langword="true"/>; used by conditional operators.</summary>
        public static bool operator true(bool2 v) => v.x && v.y;
        /// <summary>Returns <see langword="true"/> when any component is <see langword="false"/>; used by conditional operators.</summary>
        public static bool operator false(bool2 v) => !(v.x && v.y);

        // Implicit Operations

        /// <summary>Defines an implicit conversion from a <see cref="bool4"/> to a <see cref="bool2"/>, discarding the Z and W components.</summary>
        public static implicit operator bool2(bool4 v) => new bool2(v.x, v.y);
        /// <summary>Defines an implicit conversion from a <see cref="bool3"/> to a <see cref="bool2"/>, discarding the Z component.</summary>
        public static implicit operator bool2(bool3 v) => new bool2(v.x, v.y);
        /// <summary>Defines an implicit conversion from a <see cref="bool"/> to a <see cref="bool2"/>, replicating the value across all components.</summary>
        public static implicit operator bool2(bool v) => new bool2(v);

        // Logical Operations

        // AND
        /// <summary>Computes the component-wise logical AND of two vectors.</summary>
        public static bool2 operator &(bool2 a, bool2 b) => new bool2(a.x & b.x, a.y & b.y);
        /// <summary>Computes the logical AND of each component and a scalar value.</summary>
        public static bool2 operator &(bool2 a, bool b) => new bool2(a.x & b, a.y & b);
        /// <summary>Computes the logical AND of a scalar value and each component of the vector.</summary>
        public static bool2 operator &(bool a, bool2 b) => new bool2(a & b.x, a & b.y);

        // OR
        /// <summary>Computes the component-wise logical OR of two vectors.</summary>
        public static bool2 operator |(bool2 a, bool2 b) => new bool2(a.x | b.x, a.y | b.y);
        /// <summary>Computes the logical OR of each component and a scalar value.</summary>
        public static bool2 operator |(bool2 a, bool b) => new bool2(a.x | b, a.y | b);
        /// <summary>Computes the logical OR of a scalar value and each component of the vector.</summary>
        public static bool2 operator |(bool a, bool2 b) => new bool2(a | b.x, a | b.y);

        // XOR
        /// <summary>Computes the component-wise logical XOR of two vectors.</summary>
        public static bool2 operator ^(bool2 a, bool2 b) => new bool2(a.x ^ b.x, a.y ^ b.y);
        /// <summary>Computes the logical XOR of each component and a scalar value.</summary>
        public static bool2 operator ^(bool2 a, bool b) => new bool2(a.x ^ b, a.y ^ b);
        /// <summary>Computes the logical XOR of a scalar value and each component of the vector.</summary>
        public static bool2 operator ^(bool a, bool2 b) => new bool2(a ^ b.x, a ^ b.y);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator ==(bool2 a, bool2 b) => new bool2(a.x == b.x, a.y == b.y);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator !=(bool2 a, bool2 b) => new bool2(a.x != b.x, a.y != b.y);
        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator ==(bool2 a, bool b) => new bool2(a.x == b, a.y == b);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator !=(bool2 a, bool b) => new bool2(a.x != b, a.y != b);
        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator ==(bool a, bool2 b) => new bool2(a == b.x, a == b.y);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool2"/>.</summary>
        public static bool2 operator !=(bool a, bool2 b) => new bool2(a != b.x, a != b.y);

        // Static Properties

        /// <summary>Gets a vector with all components set to <see langword="false"/>.</summary>
        public static bool2 off => new bool2(false);
        /// <summary>Gets a vector with all components set to <see langword="true"/>.</summary>
        public static bool2 on => new bool2(true);
        /// <summary>Gets a vector with only the X component set to <see langword="true"/>.</summary>
        public static bool2 unitX => new bool2(true, false);
        /// <summary>Gets a vector with only the Y component set to <see langword="true"/>.</summary>
        public static bool2 unitY => new bool2(false, true);

        // Helper Methods

        /// <summary>Gets a value indicating whether all components of the vector are <see langword="true"/>.</summary>
        public readonly bool all => x && y;
        /// <summary>Gets a value indicating whether any component of the vector is <see langword="true"/>.</summary>
        public readonly bool any => x || y;

        // Swizzling

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xx => new bool2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xy => new bool2(x, y);
        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yx => new bool2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yy => new bool2(y, y);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly bool r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly bool g => y;

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 rr => new bool2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 rg => new bool2(r, g);
        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 gr => new bool2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 gg => new bool2(g, g);
    }
}
