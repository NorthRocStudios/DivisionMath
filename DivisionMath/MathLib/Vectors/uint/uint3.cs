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
    /// Represents a three-component vector of 32-bit unsigned integer values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>uint3</c> type.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct uint3
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public uint x;
        /// <summary>The Y component of the vector.</summary>
        public uint y;
        /// <summary>The Z component of the vector.</summary>
        public uint z;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-2.</exception>
        public uint this[int index]
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
        public override readonly string ToString() => $"uint3({x}, {y}, {z})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="uint3"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="uint3"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="uint3"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is uint3 other && x == other.x && y == other.y && z == other.z;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="uint3"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public uint3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="uint3"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public uint3(uint value)
        {
            x = value;
            y = value;
            z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="uint3"/> struct from a <see cref="uint2"/> XY pair and a Z component.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="z">The Z component.</param>
        public uint3(uint2 xy, uint z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="uint3"/> struct from an X component and a <see cref="uint2"/> YZ pair.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yz">The Y and Z components.</param>
        public uint3(uint x, uint2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Implicit Operations

        /// <summary>Defines an implicit conversion from a <see cref="uint4"/> to a <see cref="uint3"/>, discarding the W component.</summary>
        public static implicit operator uint3(uint4 v) => new uint3(v.x, v.y, v.z);
        /// <summary>Defines an implicit conversion from a <see cref="uint2"/> to a <see cref="uint3"/>, setting the additional component to zero.</summary>
        public static implicit operator uint3(uint2 v) => new uint3(v, 0);
        /// <summary>Defines an implicit conversion from a <see cref="uint"/> to a <see cref="uint3"/>, replicating the value across all components.</summary>
        public static implicit operator uint3(uint v) => new uint3(v);

        // Unit Vectors

        /// <summary>Gets a vector with all components set to zero.</summary>
        public static uint3 zero => new uint3(0);
        /// <summary>Gets a vector with all components set to one.</summary>
        public static uint3 one => new uint3(1);
        /// <summary>Gets the unit vector along the X axis, (1, 0, 0).</summary>
        public static uint3 unitX => new uint3(1, 0, 0);
        /// <summary>Gets the unit vector along the Y axis, (0, 1, 0).</summary>
        public static uint3 unitY => new uint3(0, 1, 0);
        /// <summary>Gets the unit vector along the Z axis, (0, 0, 1).</summary>
        public static uint3 unitZ => new uint3(0, 0, 1);

        /// <summary>Gets the up direction, (0, 1, 0).</summary>
        public static uint3 up => unitY;
        /// <summary>Gets the right direction, (1, 0, 0).</summary>
        public static uint3 right => new uint3(1, 0, 0);
        /// <summary>Gets the forward direction, (0, 0, 1).</summary>
        public static uint3 forward => new uint3(0, 0, 1);

        // Arithmetic Operations

        /// <summary>Adds two vectors component-wise.</summary>
        public static uint3 operator +(uint3 a, uint3 b) => new uint3(a.x + b.x, a.y + b.y, a.z + b.z);
        /// <summary>Subtracts two vectors component-wise.</summary>
        public static uint3 operator -(uint3 a, uint3 b) => new uint3(a.x - b.x, a.y - b.y, a.z - b.z);
        /// <summary>Multiplies two vectors component-wise.</summary>
        public static uint3 operator *(uint3 a, uint3 b) => new uint3(a.x * b.x, a.y * b.y, a.z * b.z);
        /// <summary>Divides two vectors component-wise.</summary>
        public static uint3 operator /(uint3 a, uint3 b) => new uint3(a.x / b.x, a.y / b.y, a.z / b.z);


        /// <summary>Negates each component; unsigned negation wraps, matching HLSL.</summary>
        public static uint3 operator -(uint3 v) => new uint3(0u - v.x, 0u - v.y, 0u - v.z);
        // Arithmetic - uint

        /// <summary>Adds a scalar value to each component of the vector.</summary>
        public static uint3 operator +(uint3 a, uint b) => new uint3(a.x + b, a.y + b, a.z + b);
        /// <summary>Subtracts a scalar value from each component of the vector.</summary>
        public static uint3 operator -(uint3 a, uint b) => new uint3(a.x - b, a.y - b, a.z - b);
        /// <summary>Multiplies each component of the vector by a scalar value.</summary>
        public static uint3 operator *(uint3 a, uint b) => new uint3(a.x * b, a.y * b, a.z * b);
        /// <summary>Divides each component of the vector by a scalar value.</summary>
        public static uint3 operator /(uint3 a, uint b) => new uint3(a.x / b, a.y / b, a.z / b);

        /// <summary>Adds each component of the vector to a scalar value.</summary>
        public static uint3 operator +(uint a, uint3 b) => new uint3(a + b.x, a + b.y, a + b.z);
        /// <summary>Subtracts each component of the vector from a scalar value.</summary>
        public static uint3 operator -(uint a, uint3 b) => new uint3(a - b.x, a - b.y, a - b.z);
        /// <summary>Multiplies a scalar value by each component of the vector.</summary>
        public static uint3 operator *(uint a, uint3 b) => new uint3(a * b.x, a * b.y, a * b.z);
        /// <summary>Divides a scalar value by each component of the vector.</summary>
        public static uint3 operator /(uint a, uint3 b) => new uint3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - uint2

        /// <summary>Adds the corresponding components of a <see cref="uint2"/> to the first two components of the vector; the remaining components are unchanged.</summary>
        public static uint3 operator +(uint3 a, uint2 b) => new uint3(a.x + b.x, a.y + b.y, a.z);
        /// <summary>Subtracts the corresponding components of a <see cref="uint2"/> from the first two components of the vector; the remaining components are unchanged.</summary>
        public static uint3 operator -(uint3 a, uint2 b) => new uint3(a.x - b.x, a.y - b.y, a.z);
        /// <summary>Multiplies the first two components of the vector by the corresponding components of a <see cref="uint2"/>; the remaining components are unchanged.</summary>
        public static uint3 operator *(uint3 a, uint2 b) => new uint3(a.x * b.x, a.y * b.y, a.z);
        /// <summary>Divides the first two components of the vector by the corresponding components of a <see cref="uint2"/>; the remaining components are unchanged.</summary>
        public static uint3 operator /(uint3 a, uint2 b) => new uint3(a.x / b.x, a.y / b.y, a.z);

        /// <summary>Adds a <see cref="uint2"/> to the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static uint3 operator +(uint2 a, uint3 b) => new uint3(a.x + b.x, a.y + b.y, b.z);
        /// <summary>Subtracts the corresponding components of the vector from a <see cref="uint2"/>; the extra components of the vector are passed through unchanged.</summary>
        public static uint3 operator -(uint2 a, uint3 b) => new uint3(a.x - b.x, a.y - b.y, b.z);
        /// <summary>Multiplies a <see cref="uint2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static uint3 operator *(uint2 a, uint3 b) => new uint3(a.x * b.x, a.y * b.y, b.z);
        /// <summary>Divides a <see cref="uint2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static uint3 operator /(uint2 a, uint3 b) => new uint3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(uint3 a, uint3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(uint3 a, uint3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        /// <summary>Performs a component-wise less-than comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(uint3 a, uint3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        /// <summary>Performs a component-wise greater-than comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(uint3 a, uint3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        /// <summary>Performs a component-wise less-than-or-equal comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(uint3 a, uint3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        /// <summary>Performs a component-wise greater-than-or-equal comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(uint3 a, uint3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        /// <summary>Compares each component of the vector with a scalar value using equality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(uint3 a, uint b) => new bool3(a.x == b, a.y == b, a.z == b);
        /// <summary>Compares each component of the vector with a scalar value using inequality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(uint3 a, uint b) => new bool3(a.x != b, a.y != b, a.z != b);
        /// <summary>Compares each component of the vector with a scalar value using less-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(uint3 a, uint b) => new bool3(a.x < b, a.y < b, a.z < b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(uint3 a, uint b) => new bool3(a.x > b, a.y > b, a.z > b);
        /// <summary>Compares each component of the vector with a scalar value using less-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(uint3 a, uint b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(uint3 a, uint b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        /// <summary>Compares a scalar value with each component of the vector using equality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(uint a, uint3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        /// <summary>Compares a scalar value with each component of the vector using inequality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(uint a, uint3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        /// <summary>Compares a scalar value with each component of the vector using less-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(uint a, uint3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        /// <summary>Compares a scalar value with each component of the vector using greater-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(uint a, uint3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        /// <summary>Compares a scalar value with each component of the vector using less-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(uint a, uint3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        /// <summary>Compares a scalar value with each component of the vector using greater-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(uint a, uint3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - uint3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xxx => new uint3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xxy => new uint3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xxz => new uint3(x, x, z);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xyx => new uint3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xyy => new uint3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xyz => new uint3(x, y, z);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xzx => new uint3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xzy => new uint3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 xzz => new uint3(x, z, z);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yxx => new uint3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yxy => new uint3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yxz => new uint3(y, x, z);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yyx => new uint3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yyy => new uint3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yyz => new uint3(y, y, z);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yzx => new uint3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yzy => new uint3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 yzz => new uint3(y, z, z);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zxx => new uint3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zxy => new uint3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zxz => new uint3(z, x, z);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zyx => new uint3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zyy => new uint3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zyz => new uint3(z, y, z);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zzx => new uint3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zzy => new uint3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 zzz => new uint3(z, z, z);

        // Swizzling - uint2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 xx => new uint2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 xy => new uint2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 xz => new uint2(x, z);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 yx => new uint2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 yy => new uint2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 yz => new uint2(y, z);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 zx => new uint2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 zy => new uint2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 zz => new uint2(z, z);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly uint r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly uint g => y;
        /// <summary>Gets the blue channel, equivalent to <see cref="z"/>.</summary>
        public readonly uint b => z;

        // RGBA Swizzling - uint3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rrr => new uint3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rrg => new uint3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rrb => new uint3(r, r, b);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rgr => new uint3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rgg => new uint3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rgb => new uint3(r, g, b);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rbr => new uint3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rbg => new uint3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 rbb => new uint3(r, b, b);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 grr => new uint3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 grg => new uint3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 grb => new uint3(g, r, b);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ggr => new uint3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ggg => new uint3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 ggb => new uint3(g, g, b);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gbr => new uint3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gbg => new uint3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 gbb => new uint3(g, b, b);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 brr => new uint3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 brg => new uint3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 brb => new uint3(b, r, b);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bgr => new uint3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bgg => new uint3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bgb => new uint3(b, g, b);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bbr => new uint3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bbg => new uint3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as a <see cref="uint3"/>.</summary>
        public readonly uint3 bbb => new uint3(b, b, b);

        // RGBA Swizzling - uint2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 rr => new uint2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 rg => new uint2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 rb => new uint2(r, b);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 gr => new uint2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 gg => new uint2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 gb => new uint2(g, b);

        /// <summary>Gets the <c>br</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 br => new uint2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 bg => new uint2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as a <see cref="uint2"/>.</summary>
        public readonly uint2 bb => new uint2(b, b);
    }
}
