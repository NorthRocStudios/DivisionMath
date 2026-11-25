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
    /// Represents a three-component vector of boolean values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>bool3</c> type.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct bool3
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public bool x;
        /// <summary>The Y component of the vector.</summary>
        public bool y;
        /// <summary>The Z component of the vector.</summary>
        public bool z;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-2.</exception>
        public bool this[int index]
        {
            readonly get => index switch
            {
                0 => x,
                1 => y,
                2 => z,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                }
            }
        }

        // Overrides

        /// <summary>Returns a string representation of the vector.</summary>
        public override readonly string ToString() => $"bool3({x}, {y}, {z})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="bool3"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="bool3"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="bool3"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is bool3 other && x == other.x && y == other.y && z == other.z;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="bool3"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public bool3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool3"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public bool3(bool value)
        {
            x = value;
            y = value;
            z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool3"/> struct from a <see cref="bool2"/> XY pair and a Z component.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="z">The Z component.</param>
        public bool3(bool2 xy, bool z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="bool3"/> struct from an X component and a <see cref="bool2"/> YZ pair.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yz">The Y and Z components.</param>
        public bool3(bool x, bool2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        /// <summary>Computes the logical negation of each component.</summary>
        public static bool3 operator !(bool3 v) => new bool3(!v.x, !v.y, !v.z);
        /// <summary>Returns <see langword="true"/> when all components are <see langword="true"/>; used by conditional operators.</summary>
        public static bool operator true(bool3 v) => v.x && v.y && v.z;
        /// <summary>Returns <see langword="true"/> when any component is <see langword="false"/>; used by conditional operators.</summary>
        public static bool operator false(bool3 v) => !(v.x && v.y && v.z);

        // Logical Operators

        // AND
        /// <summary>Computes the component-wise logical AND of two vectors.</summary>
        public static bool3 operator &(bool3 a, bool3 b) => new bool3(a.x & b.x, a.y & b.y, a.z & b.z);
        /// <summary>Computes the logical AND of each component and a scalar value.</summary>
        public static bool3 operator &(bool3 a, bool b) => new bool3(a.x & b, a.y & b, a.z & b);
        /// <summary>Computes the logical AND of a scalar value and each component of the vector.</summary>
        public static bool3 operator &(bool a, bool3 b) => new bool3(a & b.x, a & b.y, a & b.z);

        // OR
        /// <summary>Computes the component-wise logical OR of two vectors.</summary>
        public static bool3 operator |(bool3 a, bool3 b) => new bool3(a.x | b.x, a.y | b.y, a.z | b.z);
        /// <summary>Computes the logical OR of each component and a scalar value.</summary>
        public static bool3 operator |(bool3 a, bool b) => new bool3(a.x | b, a.y | b, a.z | b);
        /// <summary>Computes the logical OR of a scalar value and each component of the vector.</summary>
        public static bool3 operator |(bool a, bool3 b) => new bool3(a | b.x, a | b.y, a | b.z);

        // XOR
        /// <summary>Computes the component-wise logical XOR of two vectors.</summary>
        public static bool3 operator ^(bool3 a, bool3 b) => new bool3(a.x ^ b.x, a.y ^ b.y, a.z ^ b.z);
        /// <summary>Computes the logical XOR of each component and a scalar value.</summary>
        public static bool3 operator ^(bool3 a, bool b) => new bool3(a.x ^ b, a.y ^ b, a.z ^ b);
        /// <summary>Computes the logical XOR of a scalar value and each component of the vector.</summary>
        public static bool3 operator ^(bool a, bool3 b) => new bool3(a ^ b.x, a ^ b.y, a ^ b.z);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(bool3 a, bool3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(bool3 a, bool3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(bool3 a, bool b) => new bool3(a.x == b, a.y == b, a.z == b);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(bool3 a, bool b) => new bool3(a.x != b, a.y != b, a.z != b);
        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(bool a, bool3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(bool a, bool3 b) => new bool3(a != b.x, a != b.y, a != b.z);

        // Implicit Conversions

        /// <summary>Defines an implicit conversion from a <see cref="bool4"/> to a <see cref="bool3"/>, discarding the W component.</summary>
        public static implicit operator bool3(bool4 v) => new bool3(v.x, v.y, v.z);
        /// <summary>Defines an implicit conversion from a <see cref="bool2"/> to a <see cref="bool3"/>, setting the additional component to <see langword="false"/>.</summary>
        public static implicit operator bool3(bool2 v) => new bool3(v.x, v.y, false);
        /// <summary>Defines an implicit conversion from a <see cref="bool"/> to a <see cref="bool3"/>, replicating the value across all components.</summary>
        public static implicit operator bool3(bool v) => new bool3(v);

        // Static Properties

        /// <summary>Gets a vector with all components set to <see langword="false"/>.</summary>
        public static bool3 off => new bool3(false);
        /// <summary>Gets a vector with all components set to <see langword="true"/>.</summary>
        public static bool3 on => new bool3(true);
        /// <summary>Gets a vector with only the X component set to <see langword="true"/>.</summary>
        public static bool3 unitX => new bool3(true, false, false);
        /// <summary>Gets a vector with only the Y component set to <see langword="true"/>.</summary>
        public static bool3 unitY => new bool3(false, true, false);
        /// <summary>Gets a vector with only the Z component set to <see langword="true"/>.</summary>
        public static bool3 unitZ => new bool3(false, false, true);

        // Helper Methods

        /// <summary>Gets a value indicating whether all components of the vector are <see langword="true"/>.</summary>
        public readonly bool all => x && y && z;
        /// <summary>Gets a value indicating whether any component of the vector is <see langword="true"/>.</summary>
        public readonly bool any => x || y || z;

        // Swizzling - bool3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xxx => new bool3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xxy => new bool3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xxz => new bool3(x, x, z);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xyx => new bool3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xyy => new bool3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xyz => new bool3(x, y, z);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xzx => new bool3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xzy => new bool3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 xzz => new bool3(x, z, z);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yxx => new bool3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yxy => new bool3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yxz => new bool3(y, x, z);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yyx => new bool3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yyy => new bool3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yyz => new bool3(y, y, z);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yzx => new bool3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yzy => new bool3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 yzz => new bool3(y, z, z);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zxx => new bool3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zxy => new bool3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zxz => new bool3(z, x, z);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zyx => new bool3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zyy => new bool3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zyz => new bool3(z, y, z);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zzx => new bool3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zzy => new bool3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 zzz => new bool3(z, z, z);

        // Swizzling - bool2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xx => new bool2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xy => new bool2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 xz => new bool2(x, z);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yx => new bool2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yy => new bool2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 yz => new bool2(y, z);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 zx => new bool2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 zy => new bool2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 zz => new bool2(z, z);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly bool r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly bool g => y;
        /// <summary>Gets the blue channel, equivalent to <see cref="z"/>.</summary>
        public readonly bool b => z;

        // RGBA Swizzling - bool3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rrr => new bool3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rrg => new bool3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rrb => new bool3(r, r, b);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rgr => new bool3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rgg => new bool3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rgb => new bool3(r, g, b);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rbr => new bool3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rbg => new bool3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 rbb => new bool3(r, b, b);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 grr => new bool3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 grg => new bool3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 grb => new bool3(g, r, b);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ggr => new bool3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ggg => new bool3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 ggb => new bool3(g, g, b);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gbr => new bool3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gbg => new bool3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 gbb => new bool3(g, b, b);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 brr => new bool3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 brg => new bool3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 brb => new bool3(b, r, b);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bgr => new bool3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bgg => new bool3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bgb => new bool3(b, g, b);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bbr => new bool3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bbg => new bool3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as a <see cref="bool3"/>.</summary>
        public readonly bool3 bbb => new bool3(b, b, b);

        // RGBA Swizzling - bool2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 rr => new bool2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 rg => new bool2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 rb => new bool2(r, b);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 gr => new bool2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 gg => new bool2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 gb => new bool2(g, b);

        /// <summary>Gets the <c>br</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 br => new bool2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 bg => new bool2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as a <see cref="bool2"/>.</summary>
        public readonly bool2 bb => new bool2(b, b);
    }
}
