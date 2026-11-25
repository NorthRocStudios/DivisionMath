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
    /// Represents a four-component vector of boolean values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>bool4</c> type.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct bool4
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public bool x;
        /// <summary>The Y component of the vector.</summary>
        public bool y;
        /// <summary>The Z component of the vector.</summary>
        public bool z;
        /// <summary>The W component of the vector.</summary>
        public bool w;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-3.</exception>
        public bool this[int index]
        {
            readonly get => index switch
            {
                0 => x,
                1 => y,
                2 => z,
                3 => w,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                }
            }
        }

        // Overrides

        /// <summary>Returns a string representation of the vector.</summary>
        public override readonly string ToString() => $"bool4({x}, {y}, {z}, {w})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="bool4"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="bool4"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="bool4"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is bool4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public bool4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public bool4(bool value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4"/> struct from a <see cref="bool3"/> XYZ triple and a W component.
        /// </summary>
        /// <param name="xyz">The X, Y and Z components.</param>
        /// <param name="w">The W component.</param>
        public bool4(bool3 xyz, bool w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4"/> struct from an X component and a <see cref="bool3"/> YZW triple.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yzw">The Y, Z and W components.</param>
        public bool4(bool x, bool3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4"/> struct from a <see cref="bool2"/> XY pair and a <see cref="bool2"/> ZW pair.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="zw">The Z and W components.</param>
        public bool4(bool2 xy, bool2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4"/> struct from an X component, a Y component and a <see cref="bool2"/> ZW pair.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="zw">The Z and W components.</param>
        public bool4(bool x, bool y, bool2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4"/> struct from a <see cref="bool2"/> XY pair, a Z component and a W component.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public bool4(bool2 xy, bool z, bool w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool4"/> struct from an X component, a <see cref="bool2"/> YZ pair and a W component.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yz">The Y and Z components.</param>
        /// <param name="w">The W component.</param>
        public bool4(bool x, bool2 yz, bool w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Unary Operations

        /// <summary>Computes the logical negation of each component.</summary>
        public static bool4 operator !(bool4 v) => new bool4(!v.x, !v.y, !v.z, !v.w);
        /// <summary>Returns <see langword="true"/> when all components are <see langword="true"/>; used by conditional operators.</summary>
        public static bool operator true(bool4 v) => v.x && v.y && v.z && v.w;
        /// <summary>Returns <see langword="true"/> when any component is <see langword="false"/>; used by conditional operators.</summary>
        public static bool operator false(bool4 v) => !(v.x && v.y && v.z && v.w);

        // Logical Operations

        // AND
        /// <summary>Computes the component-wise logical AND of two vectors.</summary>
        public static bool4 operator &(bool4 a, bool4 b) => new bool4(a.x & b.x, a.y & b.y, a.z & b.z, a.w & b.w);
        /// <summary>Computes the logical AND of each component and a scalar value.</summary>
        public static bool4 operator &(bool4 a, bool b) => new bool4(a.x & b, a.y & b, a.z & b, a.w & b);
        /// <summary>Computes the logical AND of a scalar value and each component of the vector.</summary>
        public static bool4 operator &(bool a, bool4 b) => new bool4(a & b.x, a & b.y, a & b.z, a & b.w);

        // OR
        /// <summary>Computes the component-wise logical OR of two vectors.</summary>
        public static bool4 operator |(bool4 a, bool4 b) => new bool4(a.x | b.x, a.y | b.y, a.z | b.z, a.w | b.w);
        /// <summary>Computes the logical OR of each component and a scalar value.</summary>
        public static bool4 operator |(bool4 a, bool b) => new bool4(a.x | b, a.y | b, a.z | b, a.w | b);
        /// <summary>Computes the logical OR of a scalar value and each component of the vector.</summary>
        public static bool4 operator |(bool a, bool4 b) => new bool4(a | b.x, a | b.y, a | b.z, a | b.w);

        // XOR
        /// <summary>Computes the component-wise logical XOR of two vectors.</summary>
        public static bool4 operator ^(bool4 a, bool4 b) => new bool4(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z, a.w ^ b.w);
        /// <summary>Computes the logical XOR of each component and a scalar value.</summary>
        public static bool4 operator ^(bool4 a, bool b) => new bool4(a.x ^ b, a.y ^ b, a.z ^ b, a.w ^ b);
        /// <summary>Computes the logical XOR of a scalar value and each component of the vector.</summary>
        public static bool4 operator ^(bool a, bool4 b) => new bool4(a ^ b.x, a ^ b.y, a ^ b.z, a ^ b.w);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator ==(bool4 a, bool4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator !=(bool4 a, bool4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        //public static bool4 operator ==(bool4 a, bool b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        //public static bool4 operator !=(bool4 a, bool b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        //public static bool4 operator ==(bool a, bool4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        //public static bool4 operator !=(bool a, bool4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);

        // Implicit Conversions

        /// <summary>Defines an implicit conversion from a <see cref="bool3"/> to a <see cref="bool4"/>, setting the additional component to <see langword="false"/>.</summary>
        public static implicit operator bool4(bool3 v) => new bool4(v.x, v.y, v.z, false);
        /// <summary>Defines an implicit conversion from a <see cref="bool2"/> to a <see cref="bool4"/>, setting the additional components to <see langword="false"/>.</summary>
        public static implicit operator bool4(bool2 v) => new bool4(v.x, v.y, false, false);
        /// <summary>Defines an implicit conversion from a <see cref="bool"/> to a <see cref="bool4"/>, replicating the value across all components.</summary>
        public static implicit operator bool4(bool v) => new bool4(v);

        // Static Properties

        /// <summary>Gets a vector with all components set to <see langword="false"/>.</summary>
        public static bool4 off => new bool4(false);
        /// <summary>Gets a vector with all components set to <see langword="true"/>.</summary>
        public static bool4 on => new bool4(true);
        /// <summary>Gets a vector with only the X component set to <see langword="true"/>.</summary>
        public static bool4 unitX => new bool4(true, false, false, false);
        /// <summary>Gets a vector with only the Y component set to <see langword="true"/>.</summary>
        public static bool4 unitY => new bool4(false, true, false, false);
        /// <summary>Gets a vector with only the Z component set to <see langword="true"/>.</summary>
        public static bool4 unitZ => new bool4(false, false, true, false);
        /// <summary>Gets a vector with only the W component set to <see langword="true"/>.</summary>
        public static bool4 unitW => new bool4(false, false, false, true);

        // Helper Methods

        /// <summary>Gets a value indicating whether all components of the vector are <see langword="true"/>.</summary>
        public readonly bool all => x && y && z && w;
        /// <summary>Gets a value indicating whether any component of the vector is <see langword="true"/>.</summary>
        public readonly bool any => x || y || z || w;

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly bool r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly bool g => y;
        /// <summary>Gets the blue channel, equivalent to <see cref="z"/>.</summary>
        public readonly bool b => z;
        /// <summary>Gets the alpha channel, equivalent to <see cref="w"/>.</summary>
        public readonly bool a => w;
    }
}
