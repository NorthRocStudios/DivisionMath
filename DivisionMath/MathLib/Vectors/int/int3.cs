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
    /// Represents a three-component vector of 32-bit signed integer values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>int3</c> type.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct int3
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public int x;
        /// <summary>The Y component of the vector.</summary>
        public int y;
        /// <summary>The Z component of the vector.</summary>
        public int z;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-2.</exception>
        public int this[int index]
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
        public override readonly string ToString() => $"int3({x}, {y}, {z})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="int3"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="int3"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is an <see cref="int3"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is int3 other && x == other.x && y == other.y && z == other.z;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="int3"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public int3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int3"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public int3(int value)
        {
            x = value;
            y = value;
            z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int3"/> struct from an <see cref="int2"/> XY pair and a Z component.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="z">The Z component.</param>
        public int3(int2 xy, int z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int3"/> struct from an X component and an <see cref="int2"/> YZ pair.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yz">The Y and Z components.</param>
        public int3(int x, int2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        /// <summary>Negates each component of the vector.</summary>
        public static int3 operator -(int3 v) => new int3(-v.x, -v.y, -v.z);
        /// <summary>Returns the vector unchanged.</summary>
        public static int3 operator +(int3 v) => v;

        // Implicit Operations

        /// <summary>Defines an implicit conversion from an <see cref="int4"/> to an <see cref="int3"/>, discarding the W component.</summary>
        public static implicit operator int3(int4 v) => new int3(v.x, v.y, v.z);
        /// <summary>Defines an implicit conversion from an <see cref="int2"/> to an <see cref="int3"/>, setting the additional component to zero.</summary>
        public static implicit operator int3(int2 v) => new int3(v, 0);
        /// <summary>Defines an implicit conversion from an <see cref="int"/> to an <see cref="int3"/>, replicating the value across all components.</summary>
        public static implicit operator int3(int v) => new int3(v);

        // Unit Vectors

        /// <summary>Gets a vector with all components set to zero.</summary>
        public static int3 zero => new int3(0);
        /// <summary>Gets a vector with all components set to one.</summary>
        public static int3 one => new int3(1);
        /// <summary>Gets the unit vector along the X axis, (1, 0, 0).</summary>
        public static int3 unitX => new int3(1, 0, 0);
        /// <summary>Gets the unit vector along the Y axis, (0, 1, 0).</summary>
        public static int3 unitY => new int3(0, 1, 0);
        /// <summary>Gets the unit vector along the Z axis, (0, 0, 1).</summary>
        public static int3 unitZ => new int3(0, 0, 1);

        /// <summary>Gets the up direction, (0, 1, 0).</summary>
        public static int3 up => unitY;
        /// <summary>Gets the down direction, (0, -1, 0).</summary>
        public static int3 down => new int3(0, -1, 0);
        /// <summary>Gets the left direction, (-1, 0, 0).</summary>
        public static int3 left => new int3(-1, 0, 0);
        /// <summary>Gets the right direction, (1, 0, 0).</summary>
        public static int3 right => new int3(1, 0, 0);
        /// <summary>Gets the forward direction, (0, 0, 1).</summary>
        public static int3 forward => new int3(0, 0, 1);
        /// <summary>Gets the back direction, (0, 0, -1).</summary>
        public static int3 back => new int3(0, 0, -1);

        // Arithmetic Operations

        /// <summary>Adds two vectors component-wise.</summary>
        public static int3 operator +(int3 a, int3 b) => new int3(a.x + b.x, a.y + b.y, a.z + b.z);
        /// <summary>Subtracts two vectors component-wise.</summary>
        public static int3 operator -(int3 a, int3 b) => new int3(a.x - b.x, a.y - b.y, a.z - b.z);
        /// <summary>Multiplies two vectors component-wise.</summary>
        public static int3 operator *(int3 a, int3 b) => new int3(a.x * b.x, a.y * b.y, a.z * b.z);
        /// <summary>Divides two vectors component-wise.</summary>
        public static int3 operator /(int3 a, int3 b) => new int3(a.x / b.x, a.y / b.y, a.z / b.z);

        // Arithmetic - int

        /// <summary>Adds a scalar value to each component of the vector.</summary>
        public static int3 operator +(int3 a, int b) => new int3(a.x + b, a.y + b, a.z + b);
        /// <summary>Subtracts a scalar value from each component of the vector.</summary>
        public static int3 operator -(int3 a, int b) => new int3(a.x - b, a.y - b, a.z - b);
        /// <summary>Multiplies each component of the vector by a scalar value.</summary>
        public static int3 operator *(int3 a, int b) => new int3(a.x * b, a.y * b, a.z * b);
        /// <summary>Divides each component of the vector by a scalar value.</summary>
        public static int3 operator /(int3 a, int b) => new int3(a.x / b, a.y / b, a.z / b);

        /// <summary>Adds each component of the vector to a scalar value.</summary>
        public static int3 operator +(int a, int3 b) => new int3(a + b.x, a + b.y, a + b.z);
        /// <summary>Subtracts each component of the vector from a scalar value.</summary>
        public static int3 operator -(int a, int3 b) => new int3(a - b.x, a - b.y, a - b.z);
        /// <summary>Multiplies a scalar value by each component of the vector.</summary>
        public static int3 operator *(int a, int3 b) => new int3(a * b.x, a * b.y, a * b.z);
        /// <summary>Divides a scalar value by each component of the vector.</summary>
        public static int3 operator /(int a, int3 b) => new int3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - int2

        /// <summary>Adds the corresponding components of an <see cref="int2"/> to the first two components of the vector; the remaining components are unchanged.</summary>
        public static int3 operator +(int3 a, int2 b) => new int3(a.x + b.x, a.y + b.y, a.z);
        /// <summary>Subtracts the corresponding components of an <see cref="int2"/> from the first two components of the vector; the remaining components are unchanged.</summary>
        public static int3 operator -(int3 a, int2 b) => new int3(a.x - b.x, a.y - b.y, a.z);
        /// <summary>Multiplies the first two components of the vector by the corresponding components of an <see cref="int2"/>; the remaining components are unchanged.</summary>
        public static int3 operator *(int3 a, int2 b) => new int3(a.x * b.x, a.y * b.y, a.z);
        /// <summary>Divides the first two components of the vector by the corresponding components of an <see cref="int2"/>; the remaining components are unchanged.</summary>
        public static int3 operator /(int3 a, int2 b) => new int3(a.x / b.x, a.y / b.y, a.z);

        /// <summary>Adds an <see cref="int2"/> to the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int3 operator +(int2 a, int3 b) => new int3(a.x + b.x, a.y + b.y, b.z);
        /// <summary>Subtracts the corresponding components of the vector from an <see cref="int2"/>; the extra components of the vector are passed through unchanged.</summary>
        public static int3 operator -(int2 a, int3 b) => new int3(a.x - b.x, a.y - b.y, b.z);
        /// <summary>Multiplies an <see cref="int2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int3 operator *(int2 a, int3 b) => new int3(a.x * b.x, a.y * b.y, b.z);
        /// <summary>Divides an <see cref="int2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int3 operator /(int2 a, int3 b) => new int3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(int3 a, int3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(int3 a, int3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        /// <summary>Performs a component-wise less-than comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(int3 a, int3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        /// <summary>Performs a component-wise greater-than comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(int3 a, int3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        /// <summary>Performs a component-wise less-than-or-equal comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(int3 a, int3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        /// <summary>Performs a component-wise greater-than-or-equal comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(int3 a, int3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        /// <summary>Compares each component of the vector with a scalar value using equality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(int3 a, int b) => new bool3(a.x == b, a.y == b, a.z == b);
        /// <summary>Compares each component of the vector with a scalar value using inequality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(int3 a, int b) => new bool3(a.x != b, a.y != b, a.z != b);
        /// <summary>Compares each component of the vector with a scalar value using less-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(int3 a, int b) => new bool3(a.x < b, a.y < b, a.z < b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(int3 a, int b) => new bool3(a.x > b, a.y > b, a.z > b);
        /// <summary>Compares each component of the vector with a scalar value using less-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(int3 a, int b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(int3 a, int b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        /// <summary>Compares a scalar value with each component of the vector using equality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(int a, int3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        /// <summary>Compares a scalar value with each component of the vector using inequality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(int a, int3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        /// <summary>Compares a scalar value with each component of the vector using less-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(int a, int3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        /// <summary>Compares a scalar value with each component of the vector using greater-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(int a, int3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        /// <summary>Compares a scalar value with each component of the vector using less-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(int a, int3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        /// <summary>Compares a scalar value with each component of the vector using greater-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(int a, int3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - int3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xxx => new int3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xxy => new int3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xxz => new int3(x, x, z);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xyx => new int3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xyy => new int3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xyz => new int3(x, y, z);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xzx => new int3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xzy => new int3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xzz => new int3(x, z, z);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yxx => new int3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yxy => new int3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yxz => new int3(y, x, z);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yyx => new int3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yyy => new int3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yyz => new int3(y, y, z);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yzx => new int3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yzy => new int3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yzz => new int3(y, z, z);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zxx => new int3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zxy => new int3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zxz => new int3(z, x, z);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zyx => new int3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zyy => new int3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zyz => new int3(z, y, z);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zzx => new int3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zzy => new int3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zzz => new int3(z, z, z);

        // Swizzling - int2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xx => new int2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xy => new int2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xz => new int2(x, z);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yx => new int2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yy => new int2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yz => new int2(y, z);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 zx => new int2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 zy => new int2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 zz => new int2(z, z);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly int r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly int g => y;
        /// <summary>Gets the blue channel, equivalent to <see cref="z"/>.</summary>
        public readonly int b => z;

        // RGBA Swizzling - int3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rrr => new int3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rrg => new int3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rrb => new int3(r, r, b);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rgr => new int3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rgg => new int3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rgb => new int3(r, g, b);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rbr => new int3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rbg => new int3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rbb => new int3(r, b, b);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 grr => new int3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 grg => new int3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 grb => new int3(g, r, b);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ggr => new int3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ggg => new int3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ggb => new int3(g, g, b);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gbr => new int3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gbg => new int3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gbb => new int3(g, b, b);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 brr => new int3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 brg => new int3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 brb => new int3(b, r, b);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bgr => new int3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bgg => new int3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bgb => new int3(b, g, b);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bbr => new int3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bbg => new int3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bbb => new int3(b, b, b);

        // RGBA Swizzling - int2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 rr => new int2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 rg => new int2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 rb => new int2(r, b);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 gr => new int2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 gg => new int2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 gb => new int2(g, b);

        /// <summary>Gets the <c>br</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 br => new int2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 bg => new int2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 bb => new int2(b, b);
    }
}
