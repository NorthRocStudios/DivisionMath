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
    /// Represents a three-component vector of half-precision floating-point values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>half3</c> type. Components are stored as <c>float</c> on the CPU.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct half3
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public float x;
        /// <summary>The Y component of the vector.</summary>
        public float y;
        /// <summary>The Z component of the vector.</summary>
        public float z;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-2.</exception>
        public float this[int index]
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
        public override readonly string ToString() => $"half3({x}, {y}, {z})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="half3"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="half3"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="half3"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is half3 other && x == other.x && y == other.y && z == other.z;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="half3"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public half3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half3"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public half3(float value)
        {
            x = value;
            y = value;
            z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half3"/> struct from a <see cref="half2"/> XY pair and a Z component.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="z">The Z component.</param>
        public half3(half2 xy, float z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half3"/> struct from an X component and a <see cref="half2"/> YZ pair.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yz">The Y and Z components.</param>
        public half3(float x, half2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        /// <summary>Negates each component of the vector.</summary>
        public static half3 operator -(half3 v) => new half3(-v.x, -v.y, -v.z);
        /// <summary>Returns the vector unchanged.</summary>
        public static half3 operator +(half3 v) => v;

        // Implicit Operations

        /// <summary>Defines an implicit conversion from a <see cref="half4"/> to a <see cref="half3"/>, discarding the W component.</summary>
        public static implicit operator half3(half4 v) => new half3(v.x, v.y, v.z);
        /// <summary>Defines an implicit conversion from a <see cref="half2"/> to a <see cref="half3"/>, setting the additional component to zero.</summary>
        public static implicit operator half3(half2 v) => new half3(v, 0);
        /// <summary>Defines an implicit conversion from a <see cref="float"/> to a <see cref="half3"/>, replicating the value across all components.</summary>
        public static implicit operator half3(float v) => new half3(v);

        /// <summary>Widens to <c>float3</c>, matching HLSL's implicit half-to-float promotion.</summary>
        public static implicit operator float3(half3 v) => new float3(v.x, v.y, v.z);

        /// <summary>Narrows to <c>half3</c>; explicit because the conversion loses precision.</summary>
        public static explicit operator half3(float3 v) => new half3(v.x, v.y, v.z);

        // Unit Vectors

        /// <summary>Gets a vector with all components set to zero.</summary>
        public static half3 zero => new half3(0);
        /// <summary>Gets a vector with all components set to one.</summary>
        public static half3 one => new half3(1);
        /// <summary>Gets the unit vector along the X axis, (1, 0, 0).</summary>
        public static half3 unitX => new half3(1, 0, 0);
        /// <summary>Gets the unit vector along the Y axis, (0, 1, 0).</summary>
        public static half3 unitY => new half3(0, 1, 0);
        /// <summary>Gets the unit vector along the Z axis, (0, 0, 1).</summary>
        public static half3 unitZ => new half3(0, 0, 1);

        /// <summary>Gets the up direction, (0, 1, 0).</summary>
        public static half3 up => unitY;
        /// <summary>Gets the down direction, (0, -1, 0).</summary>
        public static half3 down => new half3(0, -1, 0);
        /// <summary>Gets the left direction, (-1, 0, 0).</summary>
        public static half3 left => new half3(-1, 0, 0);
        /// <summary>Gets the right direction, (1, 0, 0).</summary>
        public static half3 right => new half3(1, 0, 0);
        /// <summary>Gets the forward direction, (0, 0, 1).</summary>
        public static half3 forward => new half3(0, 0, 1);
        /// <summary>Gets the back direction, (0, 0, -1).</summary>
        public static half3 back => new half3(0, 0, -1);

        // Arithmetic Operations

        /// <summary>Adds two vectors component-wise.</summary>
        public static half3 operator +(half3 a, half3 b) => new half3(a.x + b.x, a.y + b.y, a.z + b.z);
        /// <summary>Subtracts two vectors component-wise.</summary>
        public static half3 operator -(half3 a, half3 b) => new half3(a.x - b.x, a.y - b.y, a.z - b.z);
        /// <summary>Multiplies two vectors component-wise.</summary>
        public static half3 operator *(half3 a, half3 b) => new half3(a.x * b.x, a.y * b.y, a.z * b.z);
        /// <summary>Divides two vectors component-wise.</summary>
        public static half3 operator /(half3 a, half3 b) => new half3(a.x / b.x, a.y / b.y, a.z / b.z);

        // Arithmetic - half

        /// <summary>Adds a scalar value to each component of the vector.</summary>
        public static half3 operator +(half3 a, float b) => new half3(a.x + b, a.y + b, a.z + b);
        /// <summary>Subtracts a scalar value from each component of the vector.</summary>
        public static half3 operator -(half3 a, float b) => new half3(a.x - b, a.y - b, a.z - b);
        /// <summary>Multiplies each component of the vector by a scalar value.</summary>
        public static half3 operator *(half3 a, float b) => new half3(a.x * b, a.y * b, a.z * b);
        /// <summary>Divides each component of the vector by a scalar value.</summary>
        public static half3 operator /(half3 a, float b) => new half3(a.x / b, a.y / b, a.z / b);

        /// <summary>Adds each component of the vector to a scalar value.</summary>
        public static half3 operator +(float a, half3 b) => new half3(a + b.x, a + b.y, a + b.z);
        /// <summary>Subtracts each component of the vector from a scalar value.</summary>
        public static half3 operator -(float a, half3 b) => new half3(a - b.x, a - b.y, a - b.z);
        /// <summary>Multiplies a scalar value by each component of the vector.</summary>
        public static half3 operator *(float a, half3 b) => new half3(a * b.x, a * b.y, a * b.z);
        /// <summary>Divides a scalar value by each component of the vector.</summary>
        public static half3 operator /(float a, half3 b) => new half3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - half2

        /// <summary>Adds the corresponding components of a <see cref="half2"/> to the first two components of the vector; the remaining components are unchanged.</summary>
        public static half3 operator +(half3 a, half2 b) => new half3(a.x + b.x, a.y + b.y, a.z);
        /// <summary>Subtracts the corresponding components of a <see cref="half2"/> from the first two components of the vector; the remaining components are unchanged.</summary>
        public static half3 operator -(half3 a, half2 b) => new half3(a.x - b.x, a.y - b.y, a.z);
        /// <summary>Multiplies the first two components of the vector by the corresponding components of a <see cref="half2"/>; the remaining components are unchanged.</summary>
        public static half3 operator *(half3 a, half2 b) => new half3(a.x * b.x, a.y * b.y, a.z);
        /// <summary>Divides the first two components of the vector by the corresponding components of a <see cref="half2"/>; the remaining components are unchanged.</summary>
        public static half3 operator /(half3 a, half2 b) => new half3(a.x / b.x, a.y / b.y, a.z);

        /// <summary>Adds a <see cref="half2"/> to the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half3 operator +(half2 a, half3 b) => new half3(a.x + b.x, a.y + b.y, b.z);
        /// <summary>Subtracts the corresponding components of the vector from a <see cref="half2"/>; the extra components of the vector are passed through unchanged.</summary>
        public static half3 operator -(half2 a, half3 b) => new half3(a.x - b.x, a.y - b.y, b.z);
        /// <summary>Multiplies a <see cref="half2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half3 operator *(half2 a, half3 b) => new half3(a.x * b.x, a.y * b.y, b.z);
        /// <summary>Divides a <see cref="half2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half3 operator /(half2 a, half3 b) => new half3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(half3 a, half3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(half3 a, half3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        /// <summary>Performs a component-wise less-than comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(half3 a, half3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        /// <summary>Performs a component-wise greater-than comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(half3 a, half3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        /// <summary>Performs a component-wise less-than-or-equal comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(half3 a, half3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        /// <summary>Performs a component-wise greater-than-or-equal comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(half3 a, half3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        /// <summary>Compares each component of the vector with a scalar value using equality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(half3 a, float b) => new bool3(a.x == b, a.y == b, a.z == b);
        /// <summary>Compares each component of the vector with a scalar value using inequality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(half3 a, float b) => new bool3(a.x != b, a.y != b, a.z != b);
        /// <summary>Compares each component of the vector with a scalar value using less-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(half3 a, float b) => new bool3(a.x < b, a.y < b, a.z < b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(half3 a, float b) => new bool3(a.x > b, a.y > b, a.z > b);
        /// <summary>Compares each component of the vector with a scalar value using less-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(half3 a, float b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(half3 a, float b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        /// <summary>Compares a scalar value with each component of the vector using equality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(float a, half3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        /// <summary>Compares a scalar value with each component of the vector using inequality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(float a, half3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        /// <summary>Compares a scalar value with each component of the vector using less-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(float a, half3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        /// <summary>Compares a scalar value with each component of the vector using greater-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(float a, half3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        /// <summary>Compares a scalar value with each component of the vector using less-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(float a, half3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        /// <summary>Compares a scalar value with each component of the vector using greater-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(float a, half3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - half3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xxx => new half3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xxy => new half3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xxz => new half3(x, x, z);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xyx => new half3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xyy => new half3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xyz => new half3(x, y, z);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xzx => new half3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xzy => new half3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xzz => new half3(x, z, z);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yxx => new half3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yxy => new half3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yxz => new half3(y, x, z);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yyx => new half3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yyy => new half3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yyz => new half3(y, y, z);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yzx => new half3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yzy => new half3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yzz => new half3(y, z, z);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zxx => new half3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zxy => new half3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zxz => new half3(z, x, z);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zyx => new half3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zyy => new half3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zyz => new half3(z, y, z);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zzx => new half3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zzy => new half3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zzz => new half3(z, z, z);

        // Swizzling - half2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 xx => new half2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 xy => new half2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 xz => new half2(x, z);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 yx => new half2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 yy => new half2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 yz => new half2(y, z);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 zx => new half2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 zy => new half2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 zz => new half2(z, z);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly float r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly float g => y;
        /// <summary>Gets the blue channel, equivalent to <see cref="z"/>.</summary>
        public readonly float b => z;

        // RGBA Swizzling - half3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rrr => new half3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rrg => new half3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rrb => new half3(r, r, b);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rgr => new half3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rgg => new half3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rgb => new half3(r, g, b);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rbr => new half3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rbg => new half3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rbb => new half3(r, b, b);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 grr => new half3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 grg => new half3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 grb => new half3(g, r, b);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ggr => new half3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ggg => new half3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ggb => new half3(g, g, b);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gbr => new half3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gbg => new half3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gbb => new half3(g, b, b);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 brr => new half3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 brg => new half3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 brb => new half3(b, r, b);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bgr => new half3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bgg => new half3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bgb => new half3(b, g, b);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bbr => new half3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bbg => new half3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bbb => new half3(b, b, b);

        // RGBA Swizzling - half2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 rr => new half2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 rg => new half2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 rb => new half2(r, b);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 gr => new half2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 gg => new half2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 gb => new half2(g, b);

        /// <summary>Gets the <c>br</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 br => new half2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 bg => new half2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 bb => new half2(b, b);
    }
}
