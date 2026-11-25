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
    /// Represents a four-component vector of half-precision floating-point values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>half4</c> type. Components are stored as <c>float</c> on the CPU.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public partial struct half4
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public float x;
        /// <summary>The Y component of the vector.</summary>
        public float y;
        /// <summary>The Z component of the vector.</summary>
        public float z;
        /// <summary>The W component of the vector.</summary>
        public float w;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y, 2 = Z, 3 = W).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-3.</exception>
        public float this[int index]
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
        public override readonly string ToString() => $"half4({x}, {y}, {z}, {w})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="half4"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="half4"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="half4"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is half4 other && x == other.x && y == other.y && z == other.z && w == other.w;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="half4"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public half4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half4"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public half4(float value)
        {
            x = value;
            y = value;
            z = value;
            w = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half4"/> struct from a <see cref="half3"/> XYZ triple and a W component.
        /// </summary>
        /// <param name="xyz">The X, Y and Z components.</param>
        /// <param name="w">The W component.</param>
        public half4(half3 xyz, float w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half4"/> struct from an X component and a <see cref="half3"/> YZW triple.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yzw">The Y, Z and W components.</param>
        public half4(float x, half3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half4"/> struct from a <see cref="half2"/> XY pair and a <see cref="half2"/> ZW pair.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="zw">The Z and W components.</param>
        public half4(half2 xy, half2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half4"/> struct from an X component, a Y component and a <see cref="half2"/> ZW pair.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="zw">The Z and W components.</param>
        public half4(float x, float y, half2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half4"/> struct from a <see cref="half2"/> XY pair, a Z component and a W component.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="z">The Z component.</param>
        /// <param name="w">The W component.</param>
        public half4(half2 xy, float z, float w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="half4"/> struct from an X component, a <see cref="half2"/> YZ pair and a W component.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yz">The Y and Z components.</param>
        /// <param name="w">The W component.</param>
        public half4(float x, half2 yz, float w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        // Unary Operations

        /// <summary>Negates each component of the vector.</summary>
        public static half4 operator -(half4 v) => new half4(-v.x, -v.y, -v.z, -v.w);
        /// <summary>Returns the vector unchanged.</summary>
        public static half4 operator +(half4 v) => v;

        // Implicit Operations

        /// <summary>Defines an implicit conversion from a <see cref="half3"/> to a <see cref="half4"/>, setting the additional component to zero.</summary>
        public static implicit operator half4(half3 v) => new half4(v, 0);
        /// <summary>Defines an implicit conversion from a <see cref="half2"/> to a <see cref="half4"/>, setting the additional components to zero.</summary>
        public static implicit operator half4(half2 v) => new half4(v, 0, 0);
        /// <summary>Defines an implicit conversion from a <see cref="float"/> to a <see cref="half4"/>, replicating the value across all components.</summary>
        public static implicit operator half4(float v) => new half4(v);

        /// <summary>Widens to <c>float4</c>, matching HLSL's implicit half-to-float promotion.</summary>
        public static implicit operator float4(half4 v) => new float4(v.x, v.y, v.z, v.w);

        /// <summary>Narrows to <c>half4</c>; explicit because the conversion loses precision.</summary>
        public static explicit operator half4(float4 v) => new half4(v.x, v.y, v.z, v.w);

        // Unit Vectors

        /// <summary>Gets a vector with all components set to zero.</summary>
        public static half4 zero => new half4(0);
        /// <summary>Gets a vector with all components set to one.</summary>
        public static half4 one => new half4(1);
        /// <summary>Gets the unit vector along the X axis, (1, 0, 0, 0).</summary>
        public static half4 unitX => new half4(1, 0, 0, 0);
        /// <summary>Gets the unit vector along the Y axis, (0, 1, 0, 0).</summary>
        public static half4 unitY => new half4(0, 1, 0, 0);
        /// <summary>Gets the unit vector along the Z axis, (0, 0, 1, 0).</summary>
        public static half4 unitZ => new half4(0, 0, 1, 0);
        /// <summary>Gets the unit vector along the W axis, (0, 0, 0, 1).</summary>
        public static half4 unitW => new half4(0, 0, 0, 1);

        // Arithmetic Operations

        /// <summary>Adds two vectors component-wise.</summary>
        public static half4 operator +(half4 a, half4 b) => new half4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        /// <summary>Subtracts two vectors component-wise.</summary>
        public static half4 operator -(half4 a, half4 b) => new half4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        /// <summary>Multiplies two vectors component-wise.</summary>
        public static half4 operator *(half4 a, half4 b) => new half4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        /// <summary>Divides two vectors component-wise.</summary>
        public static half4 operator /(half4 a, half4 b) => new half4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);

        // Arithmetic - half

        /// <summary>Adds a scalar value to each component of the vector.</summary>
        public static half4 operator +(half4 a, float b) => new half4(a.x + b, a.y + b, a.z + b, a.w + b);
        /// <summary>Subtracts a scalar value from each component of the vector.</summary>
        public static half4 operator -(half4 a, float b) => new half4(a.x - b, a.y - b, a.z - b, a.w - b);
        /// <summary>Multiplies each component of the vector by a scalar value.</summary>
        public static half4 operator *(half4 a, float b) => new half4(a.x * b, a.y * b, a.z * b, a.w * b);
        /// <summary>Divides each component of the vector by a scalar value.</summary>
        public static half4 operator /(half4 a, float b) => new half4(a.x / b, a.y / b, a.z / b, a.w / b);

        /// <summary>Adds each component of the vector to a scalar value.</summary>
        public static half4 operator +(float a, half4 b) => new half4(a + b.x, a + b.y, a + b.z, a + b.w);
        /// <summary>Subtracts each component of the vector from a scalar value.</summary>
        public static half4 operator -(float a, half4 b) => new half4(a - b.x, a - b.y, a - b.z, a - b.w);
        /// <summary>Multiplies a scalar value by each component of the vector.</summary>
        public static half4 operator *(float a, half4 b) => new half4(a * b.x, a * b.y, a * b.z, a * b.w);
        /// <summary>Divides a scalar value by each component of the vector.</summary>
        public static half4 operator /(float a, half4 b) => new half4(a / b.x, a / b.y, a / b.z, a / b.w);

        // Arithmetic - half2

        /// <summary>Adds the corresponding components of a <see cref="half2"/> to the first two components of the vector; the remaining components are unchanged.</summary>
        public static half4 operator +(half4 a, half2 b) => new half4(a.x + b.x, a.y + b.y, a.z, a.w);
        /// <summary>Subtracts the corresponding components of a <see cref="half2"/> from the first two components of the vector; the remaining components are unchanged.</summary>
        public static half4 operator -(half4 a, half2 b) => new half4(a.x - b.x, a.y - b.y, a.z, a.w);
        /// <summary>Multiplies the first two components of the vector by the corresponding components of a <see cref="half2"/>; the remaining components are unchanged.</summary>
        public static half4 operator *(half4 a, half2 b) => new half4(a.x * b.x, a.y * b.y, a.z, a.w);
        /// <summary>Divides the first two components of the vector by the corresponding components of a <see cref="half2"/>; the remaining components are unchanged.</summary>
        public static half4 operator /(half4 a, half2 b) => new half4(a.x / b.x, a.y / b.y, a.z, a.w);

        /// <summary>Adds a <see cref="half2"/> to the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half4 operator +(half2 a, half4 b) => new half4(a.x + b.x, a.y + b.y, b.z, b.w);
        /// <summary>Subtracts the corresponding components of the vector from a <see cref="half2"/>; the extra components of the vector are passed through unchanged.</summary>
        public static half4 operator -(half2 a, half4 b) => new half4(a.x - b.x, a.y - b.y, b.z, b.w);
        /// <summary>Multiplies a <see cref="half2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half4 operator *(half2 a, half4 b) => new half4(a.x * b.x, a.y * b.y, b.z, b.w);
        /// <summary>Divides a <see cref="half2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half4 operator /(half2 a, half4 b) => new half4(a.x / b.x, a.y / b.y, b.z, b.w);

        // Arithmetic - half3

        /// <summary>Adds the corresponding components of a <see cref="half3"/> to the first three components of the vector; the remaining components are unchanged.</summary>
        public static half4 operator +(half4 a, half3 b) => new half4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        /// <summary>Subtracts the corresponding components of a <see cref="half3"/> from the first three components of the vector; the remaining components are unchanged.</summary>
        public static half4 operator -(half4 a, half3 b) => new half4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        /// <summary>Multiplies the first three components of the vector by the corresponding components of a <see cref="half3"/>; the remaining components are unchanged.</summary>
        public static half4 operator *(half4 a, half3 b) => new half4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        /// <summary>Divides the first three components of the vector by the corresponding components of a <see cref="half3"/>; the remaining components are unchanged.</summary>
        public static half4 operator /(half4 a, half3 b) => new half4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);

        /// <summary>Adds a <see cref="half3"/> to the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half4 operator +(half3 a, half4 b) => new half4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        /// <summary>Subtracts the corresponding components of the vector from a <see cref="half3"/>; the extra components of the vector are passed through unchanged.</summary>
        public static half4 operator -(half3 a, half4 b) => new half4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        /// <summary>Multiplies a <see cref="half3"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half4 operator *(half3 a, half4 b) => new half4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        /// <summary>Divides a <see cref="half3"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static half4 operator /(half3 a, half4 b) => new half4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator ==(half4 a, half4 b) => new bool4(a.x == b.x, a.y == b.y, a.z == b.z, a.w == b.w);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator !=(half4 a, half4 b) => new bool4(a.x != b.x, a.y != b.y, a.z != b.z, a.w != b.w);
        /// <summary>Performs a component-wise less-than comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <(half4 a, half4 b) => new bool4(a.x < b.x, a.y < b.y, a.z < b.z, a.w < b.w);
        /// <summary>Performs a component-wise greater-than comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >(half4 a, half4 b) => new bool4(a.x > b.x, a.y > b.y, a.z > b.z, a.w > b.w);
        /// <summary>Performs a component-wise less-than-or-equal comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <=(half4 a, half4 b) => new bool4(a.x <= b.x, a.y <= b.y, a.z <= b.z, a.w <= b.w);
        /// <summary>Performs a component-wise greater-than-or-equal comparison and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >=(half4 a, half4 b) => new bool4(a.x >= b.x, a.y >= b.y, a.z >= b.z, a.w >= b.w);

        // Vector-scalar comparisons
        /// <summary>Compares each component of the vector with a scalar value using equality and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator ==(half4 a, float b) => new bool4(a.x == b, a.y == b, a.z == b, a.w == b);
        /// <summary>Compares each component of the vector with a scalar value using inequality and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator !=(half4 a, float b) => new bool4(a.x != b, a.y != b, a.z != b, a.w != b);
        /// <summary>Compares each component of the vector with a scalar value using less-than and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <(half4 a, float b) => new bool4(a.x < b, a.y < b, a.z < b, a.w < b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >(half4 a, float b) => new bool4(a.x > b, a.y > b, a.z > b, a.w > b);
        /// <summary>Compares each component of the vector with a scalar value using less-than-or-equal and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <=(half4 a, float b) => new bool4(a.x <= b, a.y <= b, a.z <= b, a.w <= b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than-or-equal and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >=(half4 a, float b) => new bool4(a.x >= b, a.y >= b, a.z >= b, a.w >= b);

        // Scalar-vector comparisons
        /// <summary>Compares a scalar value with each component of the vector using equality and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator ==(float a, half4 b) => new bool4(a == b.x, a == b.y, a == b.z, a == b.w);
        /// <summary>Compares a scalar value with each component of the vector using inequality and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator !=(float a, half4 b) => new bool4(a != b.x, a != b.y, a != b.z, a != b.w);
        /// <summary>Compares a scalar value with each component of the vector using less-than and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <(float a, half4 b) => new bool4(a < b.x, a < b.y, a < b.z, a < b.w);
        /// <summary>Compares a scalar value with each component of the vector using greater-than and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >(float a, half4 b) => new bool4(a > b.x, a > b.y, a > b.z, a > b.w);
        /// <summary>Compares a scalar value with each component of the vector using less-than-or-equal and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator <=(float a, half4 b) => new bool4(a <= b.x, a <= b.y, a <= b.z, a <= b.w);
        /// <summary>Compares a scalar value with each component of the vector using greater-than-or-equal and returns the results as a <see cref="bool4"/>.</summary>
        public static bool4 operator >=(float a, half4 b) => new bool4(a >= b.x, a >= b.y, a >= b.z, a >= b.w);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly float r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly float g => y;
        /// <summary>Gets the blue channel, equivalent to <see cref="z"/>.</summary>
        public readonly float b => z;
        /// <summary>Gets the alpha channel, equivalent to <see cref="w"/>.</summary>
        public readonly float a => w;
    }
}
