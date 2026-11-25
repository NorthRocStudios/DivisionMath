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
    /// Represents a four-component vector of 32-bit signed integer values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>int4</c> type.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct int4
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public int x;
        /// <summary>The Y component of the vector.</summary>
        public int y;
        /// <summary>The Z component of the vector.</summary>
        public int z;
        /// <summary>The W component of the vector.</summary>
        public int w;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-3.</exception>
        public int this[int index]
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
        public override readonly string ToString() => $"int4({x}, {y}, {z}, {w})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="int4"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="int4"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is an <see cref="int4"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is int4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="int4"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public int4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int4"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public int4(int value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int4"/> struct from an <see cref="int3"/> XYZ triple and a W component.
        /// </summary>
        /// <param name="xyz">The X, Y and Z components.</param>
        /// <param name="w">The W component.</param>
        public int4(int3 xyz, int w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int4"/> struct from an X component and an <see cref="int3"/> YZW triple.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yzw">The Y, Z and W components.</param>
        public int4(int x, int3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int4"/> struct from an <see cref="int2"/> XY pair and an <see cref="int2"/> ZW pair.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="zw">The Z and W components.</param>
        public int4(int2 xy, int2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int4"/> struct from an X component, a Y component and an <see cref="int2"/> ZW pair.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="zw">The Z and W components.</param>
        public int4(int x, int y, int2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int4"/> struct from an <see cref="int2"/> XY pair, a Z component and a W component.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public int4(int2 xy, int z, int w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="int4"/> struct from an X component, an <see cref="int2"/> YZ pair and a W component.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yz">The Y and Z components.</param>
        /// <param name="w">The W component.</param>
        public int4(int x, int2 yz, int w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Unary Operations

        /// <summary>Negates each component of the vector.</summary>
        public static int4 operator -(int4 v) => new int4(-v.x, -v.y, -v.z, -v.w);
        /// <summary>Returns the vector unchanged.</summary>
        public static int4 operator +(int4 v) => v;

        // Implicit Operations

        /// <summary>Defines an implicit conversion from an <see cref="int3"/> to an <see cref="int4"/>, setting the additional component to zero.</summary>
        public static implicit operator int4(int3 v) => new int4(v, 0);
        /// <summary>Defines an implicit conversion from an <see cref="int2"/> to an <see cref="int4"/>, setting the additional components to zero.</summary>
        public static implicit operator int4(int2 v) => new int4(v, 0, 0);
        /// <summary>Defines an implicit conversion from an <see cref="int"/> to an <see cref="int4"/>, replicating the value across all components.</summary>
        public static implicit operator int4(int v) => new int4(v);

        // Unit Vectors

        /// <summary>Gets a vector with all components set to zero.</summary>
        public static int4 zero => new int4(0);
        /// <summary>Gets a vector with all components set to one.</summary>
        public static int4 one => new int4(1);
        /// <summary>Gets the unit vector along the X axis, (1, 0, 0, 0).</summary>
        public static int4 unitX => new int4(1, 0, 0, 0);
        /// <summary>Gets the unit vector along the Y axis, (0, 1, 0, 0).</summary>
        public static int4 unitY => new int4(0, 1, 0, 0);
        /// <summary>Gets the unit vector along the Z axis, (0, 0, 1, 0).</summary>
        public static int4 unitZ => new int4(0, 0, 1, 0);
        /// <summary>Gets the unit vector along the W axis, (0, 0, 0, 1).</summary>
        public static int4 unitW => new int4(0, 0, 0, 1);

        // Arithmetic Operations

        /// <summary>Adds two vectors component-wise.</summary>
        public static int4 operator +(int4 a, int4 b) => new int4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        /// <summary>Subtracts two vectors component-wise.</summary>
        public static int4 operator -(int4 a, int4 b) => new int4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        /// <summary>Multiplies two vectors component-wise.</summary>
        public static int4 operator *(int4 a, int4 b) => new int4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        /// <summary>Divides two vectors component-wise.</summary>
        public static int4 operator /(int4 a, int4 b) => new int4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);

        // Arithmetic - int

        /// <summary>Adds a scalar value to each component of the vector.</summary>
        public static int4 operator +(int4 a, int b) => new int4(a.x + b, a.y + b, a.z + b, a.w + b);
        /// <summary>Subtracts a scalar value from each component of the vector.</summary>
        public static int4 operator -(int4 a, int b) => new int4(a.x - b, a.y - b, a.z - b, a.w - b);
        /// <summary>Multiplies each component of the vector by a scalar value.</summary>
        public static int4 operator *(int4 a, int b) => new int4(a.x * b, a.y * b, a.z * b, a.w * b);
        /// <summary>Divides each component of the vector by a scalar value.</summary>
        public static int4 operator /(int4 a, int b) => new int4(a.x / b, a.y / b, a.z / b, a.w / b);

        /// <summary>Adds each component of the vector to a scalar value.</summary>
        public static int4 operator +(int a, int4 b) => new int4(a + b.x, a + b.y, a + b.z, a + b.w);
        /// <summary>Subtracts each component of the vector from a scalar value.</summary>
        public static int4 operator -(int a, int4 b) => new int4(a - b.x, a - b.y, a - b.z, a - b.w);
        /// <summary>Multiplies a scalar value by each component of the vector.</summary>
        public static int4 operator *(int a, int4 b) => new int4(a * b.x, a * b.y, a * b.z, a * b.w);
        /// <summary>Divides a scalar value by each component of the vector.</summary>
        public static int4 operator /(int a, int4 b) => new int4(a / b.x, a / b.y, a / b.z, a / b.w);

        // Arithmetic - int2

        /// <summary>Adds the corresponding components of an <see cref="int2"/> to the first two components of the vector; the remaining components are unchanged.</summary>
        public static int4 operator +(int4 a, int2 b) => new int4(a.x + b.x, a.y + b.y, a.z, a.w);
        /// <summary>Subtracts the corresponding components of an <see cref="int2"/> from the first two components of the vector; the remaining components are unchanged.</summary>
        public static int4 operator -(int4 a, int2 b) => new int4(a.x - b.x, a.y - b.y, a.z, a.w);
        /// <summary>Multiplies the first two components of the vector by the corresponding components of an <see cref="int2"/>; the remaining components are unchanged.</summary>
        public static int4 operator *(int4 a, int2 b) => new int4(a.x * b.x, a.y * b.y, a.z, a.w);
        /// <summary>Divides the first two components of the vector by the corresponding components of an <see cref="int2"/>; the remaining components are unchanged.</summary>
        public static int4 operator /(int4 a, int2 b) => new int4(a.x / b.x, a.y / b.y, a.z, a.w);

        /// <summary>Adds an <see cref="int2"/> to the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int4 operator +(int2 a, int4 b) => new int4(a.x + b.x, a.y + b.y, b.z, b.w);
        /// <summary>Subtracts the corresponding components of the vector from an <see cref="int2"/>; the extra components of the vector are passed through unchanged.</summary>
        public static int4 operator -(int2 a, int4 b) => new int4(a.x - b.x, a.y - b.y, b.z, b.w);
        /// <summary>Multiplies an <see cref="int2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int4 operator *(int2 a, int4 b) => new int4(a.x * b.x, a.y * b.y, b.z, b.w);
        /// <summary>Divides an <see cref="int2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int4 operator /(int2 a, int4 b) => new int4(a.x / b.x, a.y / b.y, b.z, b.w);

        // Arithmetic - int3

        /// <summary>Adds the corresponding components of an <see cref="int3"/> to the first three components of the vector; the remaining components are unchanged.</summary>
        public static int4 operator +(int4 a, int3 b) => new int4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        /// <summary>Subtracts the corresponding components of an <see cref="int3"/> from the first three components of the vector; the remaining components are unchanged.</summary>
        public static int4 operator -(int4 a, int3 b) => new int4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        /// <summary>Multiplies the first three components of the vector by the corresponding components of an <see cref="int3"/>; the remaining components are unchanged.</summary>
        public static int4 operator *(int4 a, int3 b) => new int4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        /// <summary>Divides the first three components of the vector by the corresponding components of an <see cref="int3"/>; the remaining components are unchanged.</summary>
        public static int4 operator /(int4 a, int3 b) => new int4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);

        /// <summary>Adds an <see cref="int3"/> to the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int4 operator +(int3 a, int4 b) => new int4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        /// <summary>Subtracts the corresponding components of the vector from an <see cref="int3"/>; the extra components of the vector are passed through unchanged.</summary>
        public static int4 operator -(int3 a, int4 b) => new int4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        /// <summary>Multiplies an <see cref="int3"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int4 operator *(int3 a, int4 b) => new int4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        /// <summary>Divides an <see cref="int3"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static int4 operator /(int3 a, int4 b) => new int4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator ==(int4 a, int4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator !=(int4 a, int4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        /// <summary>Performs a component-wise less-than comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <(int4 a, int4 b) => new bool4(a.x < b.x, a.y < b.y, a.z < b.z, a.w < b.w);
        /// <summary>Performs a component-wise greater-than comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >(int4 a, int4 b) => new bool4(a.x > b.x, a.y > b.y, a.z > b.z, a.w > b.w);
        /// <summary>Performs a component-wise less-than-or-equal comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <=(int4 a, int4 b) => new bool4(a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
        /// <summary>Performs a component-wise greater-than-or-equal comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >=(int4 a, int4 b) => new bool4(a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);

        // Vector-scalar comparisons
        /// <summary>Compares each component of the vector with a scalar value using equality and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator ==(int4 a, int b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        /// <summary>Compares each component of the vector with a scalar value using inequality and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator !=(int4 a, int b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        /// <summary>Compares each component of the vector with a scalar value using less-than and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <(int4 a, int b) => new bool4(a.x < b, a.y < b, a.z < b, a.w < b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >(int4 a, int b) => new bool4(a.x > b, a.y > b, a.z > b, a.w > b);
        /// <summary>Compares each component of the vector with a scalar value using less-than-or-equal and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <=(int4 a, int b) => new bool4(a.x <= b, a.y <= b, a.z <= b, a.w <= b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than-or-equal and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >=(int4 a, int b) => new bool4(a.x >= b, a.y >= b, a.z >= b, a.w >= b);

        // Scalar-vector comparisons
        /// <summary>Compares a scalar value with each component of the vector using equality and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator ==(int a, int4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        /// <summary>Compares a scalar value with each component of the vector using inequality and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator !=(int a, int4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);
        /// <summary>Compares a scalar value with each component of the vector using less-than and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <(int a, int4 b) => new bool4(a < b.x, a < b.y, a < b.z, a < b.w);
        /// <summary>Compares a scalar value with each component of the vector using greater-than and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >(int a, int4 b) => new bool4(a > b.x, a > b.y, a > b.z, a > b.w);
        /// <summary>Compares a scalar value with each component of the vector using less-than-or-equal and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <=(int a, int4 b) => new bool4(a <= b.x, a <= b.y, a <= b.z, a <= b.w);
        /// <summary>Compares a scalar value with each component of the vector using greater-than-or-equal and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >=(int a, int4 b) => new bool4(a >= b.x, a >= b.y, a >= b.z, a >= b.w);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly int r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly int g => y;
        /// <summary>Gets the blue channel, equivalent to <see cref="z"/>.</summary>
        public readonly int b => z;
        /// <summary>Gets the alpha channel, equivalent to <see cref="w"/>.</summary>
        public readonly int a => w;
    }
}
