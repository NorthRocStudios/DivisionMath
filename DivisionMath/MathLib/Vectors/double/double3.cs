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
    /// Represents a three-component vector of 64-bit floating-point values.
    /// </summary>
    /// <remarks>Mirrors the HLSL <c>double3</c> type.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct double3
    {
        // Data Storage

        /// <summary>The X component of the vector.</summary>
        public double x;
        /// <summary>The Y component of the vector.</summary>
        public double y;
        /// <summary>The Z component of the vector.</summary>
        public double z;

        // Component Access

        /// <summary>
        /// Gets or sets the component at the specified index.
        /// </summary>
        /// <param name="index">The zero-based component index (0 = X, 1 = Y, 2 = Z).</param>
        /// <returns>The component at <paramref name="index"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="index"/> is outside the range 0-2.</exception>
        public double this[int index]
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
        public override readonly string ToString() => $"double3({x}, {y}, {z})";
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="double3"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="double3"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="double3"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is double3 other && x == other.x && y == other.y && z == other.z;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(x, y, z);

        // Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="double3"/> struct with the specified components.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="y">The Y component.</param>
        /// <param name="z">The Z component.</param>
        public double3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="double3"/> struct with all components set to the specified value.
        /// </summary>
        /// <param name="value">The value assigned to every component.</param>
        public double3(double value)
        {
            x = value;
            y = value;
            z = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="double3"/> struct from a <see cref="double2"/> XY pair and a Z component.
        /// </summary>
        /// <param name="xy">The X and Y components.</param>
        /// <param name="z">The Z component.</param>
        public double3(double2 xy, double z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="double3"/> struct from an X component and a <see cref="double2"/> YZ pair.
        /// </summary>
        /// <param name="x">The X component.</param>
        /// <param name="yz">The Y and Z components.</param>
        public double3(double x, double2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        // Unary Operations

        /// <summary>Negates each component of the vector.</summary>
        public static double3 operator -(double3 v) => new double3(-v.x, -v.y, -v.z);
        /// <summary>Returns the vector unchanged.</summary>
        public static double3 operator +(double3 v) => v;

        // Implicit Operations

        /// <summary>Defines an implicit conversion from a <see cref="double4"/> to a <see cref="double3"/>, discarding the W component.</summary>
        public static implicit operator double3(double4 v) => new double3(v.x, v.y, v.z);
        /// <summary>Defines an implicit conversion from a <see cref="double2"/> to a <see cref="double3"/>, setting the additional component to zero.</summary>
        public static implicit operator double3(double2 v) => new double3(v, 0);
        /// <summary>Defines an implicit conversion from a <see cref="double"/> to a <see cref="double3"/>, replicating the value across all components.</summary>
        public static implicit operator double3(double v) => new double3(v);

        // Unit Vectors

        /// <summary>Gets a vector with all components set to zero.</summary>
        public static double3 zero => new double3(0);
        /// <summary>Gets a vector with all components set to one.</summary>
        public static double3 one => new double3(1);
        /// <summary>Gets the unit vector along the X axis, (1, 0, 0).</summary>
        public static double3 unitX => new double3(1, 0, 0);
        /// <summary>Gets the unit vector along the Y axis, (0, 1, 0).</summary>
        public static double3 unitY => new double3(0, 1, 0);
        /// <summary>Gets the unit vector along the Z axis, (0, 0, 1).</summary>
        public static double3 unitZ => new double3(0, 0, 1);

        /// <summary>Gets the up direction, (0, 1, 0).</summary>
        public static double3 up => unitY;
        /// <summary>Gets the down direction, (0, -1, 0).</summary>
        public static double3 down => new double3(0, -1, 0);
        /// <summary>Gets the left direction, (-1, 0, 0).</summary>
        public static double3 left => new double3(-1, 0, 0);
        /// <summary>Gets the right direction, (1, 0, 0).</summary>
        public static double3 right => new double3(1, 0, 0);
        /// <summary>Gets the forward direction, (0, 0, 1).</summary>
        public static double3 forward => new double3(0, 0, 1);
        /// <summary>Gets the back direction, (0, 0, -1).</summary>
        public static double3 back => new double3(0, 0, -1);

        // Arithmetic Operations

        /// <summary>Adds two vectors component-wise.</summary>
        public static double3 operator +(double3 a, double3 b) => new double3(a.x + b.x, a.y + b.y, a.z + b.z);
        /// <summary>Subtracts two vectors component-wise.</summary>
        public static double3 operator -(double3 a, double3 b) => new double3(a.x - b.x, a.y - b.y, a.z - b.z);
        /// <summary>Multiplies two vectors component-wise.</summary>
        public static double3 operator *(double3 a, double3 b) => new double3(a.x * b.x, a.y * b.y, a.z * b.z);
        /// <summary>Divides two vectors component-wise.</summary>
        public static double3 operator /(double3 a, double3 b) => new double3(a.x / b.x, a.y / b.y, a.z / b.z);

        // Arithmetic - double

        /// <summary>Adds a scalar value to each component of the vector.</summary>
        public static double3 operator +(double3 a, double b) => new double3(a.x + b, a.y + b, a.z + b);
        /// <summary>Subtracts a scalar value from each component of the vector.</summary>
        public static double3 operator -(double3 a, double b) => new double3(a.x - b, a.y - b, a.z - b);
        /// <summary>Multiplies each component of the vector by a scalar value.</summary>
        public static double3 operator *(double3 a, double b) => new double3(a.x * b, a.y * b, a.z * b);
        /// <summary>Divides each component of the vector by a scalar value.</summary>
        public static double3 operator /(double3 a, double b) => new double3(a.x / b, a.y / b, a.z / b);

        /// <summary>Adds each component of the vector to a scalar value.</summary>
        public static double3 operator +(double a, double3 b) => new double3(a + b.x, a + b.y, a + b.z);
        /// <summary>Subtracts each component of the vector from a scalar value.</summary>
        public static double3 operator -(double a, double3 b) => new double3(a - b.x, a - b.y, a - b.z);
        /// <summary>Multiplies a scalar value by each component of the vector.</summary>
        public static double3 operator *(double a, double3 b) => new double3(a * b.x, a * b.y, a * b.z);
        /// <summary>Divides a scalar value by each component of the vector.</summary>
        public static double3 operator /(double a, double3 b) => new double3(a / b.x, a / b.y, a / b.z);

        // Arithmetic - double2

        /// <summary>Adds the corresponding components of a <see cref="double2"/> to the first two components of the vector; the remaining components are unchanged.</summary>
        public static double3 operator +(double3 a, double2 b) => new double3(a.x + b.x, a.y + b.y, a.z);
        /// <summary>Subtracts the corresponding components of a <see cref="double2"/> from the first two components of the vector; the remaining components are unchanged.</summary>
        public static double3 operator -(double3 a, double2 b) => new double3(a.x - b.x, a.y - b.y, a.z);
        /// <summary>Multiplies the first two components of the vector by the corresponding components of a <see cref="double2"/>; the remaining components are unchanged.</summary>
        public static double3 operator *(double3 a, double2 b) => new double3(a.x * b.x, a.y * b.y, a.z);
        /// <summary>Divides the first two components of the vector by the corresponding components of a <see cref="double2"/>; the remaining components are unchanged.</summary>
        public static double3 operator /(double3 a, double2 b) => new double3(a.x / b.x, a.y / b.y, a.z);

        /// <summary>Adds a <see cref="double2"/> to the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static double3 operator +(double2 a, double3 b) => new double3(a.x + b.x, a.y + b.y, b.z);
        /// <summary>Subtracts the corresponding components of the vector from a <see cref="double2"/>; the extra components of the vector are passed through unchanged.</summary>
        public static double3 operator -(double2 a, double3 b) => new double3(a.x - b.x, a.y - b.y, b.z);
        /// <summary>Multiplies a <see cref="double2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static double3 operator *(double2 a, double3 b) => new double3(a.x * b.x, a.y * b.y, b.z);
        /// <summary>Divides a <see cref="double2"/> by the corresponding components of the vector; the extra components of the vector are passed through unchanged.</summary>
        public static double3 operator /(double2 a, double3 b) => new double3(a.x / b.x, a.y / b.y, b.z);

        // Comparison Operations

        /// <summary>Performs a component-wise equality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(double3 a, double3 b) => new bool3(a.x == b.x, a.y == b.y, a.z == b.z);
        /// <summary>Performs a component-wise inequality comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(double3 a, double3 b) => new bool3(a.x != b.x, a.y != b.y, a.z != b.z);
        /// <summary>Performs a component-wise less-than comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(double3 a, double3 b) => new bool3(a.x < b.x, a.y < b.y, a.z < b.z);
        /// <summary>Performs a component-wise greater-than comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(double3 a, double3 b) => new bool3(a.x > b.x, a.y > b.y, a.z > b.z);
        /// <summary>Performs a component-wise less-than-or-equal comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(double3 a, double3 b) => new bool3(a.x <= b.x, a.y <= b.y, a.z <= b.z);
        /// <summary>Performs a component-wise greater-than-or-equal comparison and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(double3 a, double3 b) => new bool3(a.x >= b.x, a.y >= b.y, a.z >= b.z);

        // Vector-scalar comparisons
        /// <summary>Compares each component of the vector with a scalar value using equality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(double3 a, double b) => new bool3(a.x == b, a.y == b, a.z == b);
        /// <summary>Compares each component of the vector with a scalar value using inequality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(double3 a, double b) => new bool3(a.x != b, a.y != b, a.z != b);
        /// <summary>Compares each component of the vector with a scalar value using less-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(double3 a, double b) => new bool3(a.x < b, a.y < b, a.z < b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(double3 a, double b) => new bool3(a.x > b, a.y > b, a.z > b);
        /// <summary>Compares each component of the vector with a scalar value using less-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(double3 a, double b) => new bool3(a.x <= b, a.y <= b, a.z <= b);
        /// <summary>Compares each component of the vector with a scalar value using greater-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(double3 a, double b) => new bool3(a.x >= b, a.y >= b, a.z >= b);

        // Scalar-vector comparisons
        /// <summary>Compares a scalar value with each component of the vector using equality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator ==(double a, double3 b) => new bool3(a == b.x, a == b.y, a == b.z);
        /// <summary>Compares a scalar value with each component of the vector using inequality and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator !=(double a, double3 b) => new bool3(a != b.x, a != b.y, a != b.z);
        /// <summary>Compares a scalar value with each component of the vector using less-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <(double a, double3 b) => new bool3(a < b.x, a < b.y, a < b.z);
        /// <summary>Compares a scalar value with each component of the vector using greater-than and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >(double a, double3 b) => new bool3(a > b.x, a > b.y, a > b.z);
        /// <summary>Compares a scalar value with each component of the vector using less-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator <=(double a, double3 b) => new bool3(a <= b.x, a <= b.y, a <= b.z);
        /// <summary>Compares a scalar value with each component of the vector using greater-than-or-equal and returns the results as a <see cref="bool3"/>.</summary>
        public static bool3 operator >=(double a, double3 b) => new bool3(a >= b.x, a >= b.y, a >= b.z);

        // Swizzling - double3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xxx => new double3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xxy => new double3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xxz => new double3(x, x, z);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xyx => new double3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xyy => new double3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xyz => new double3(x, y, z);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xzx => new double3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xzy => new double3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 xzz => new double3(x, z, z);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yxx => new double3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yxy => new double3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yxz => new double3(y, x, z);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yyx => new double3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yyy => new double3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yyz => new double3(y, y, z);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yzx => new double3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yzy => new double3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 yzz => new double3(y, z, z);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zxx => new double3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zxy => new double3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zxz => new double3(z, x, z);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zyx => new double3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zyy => new double3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zyz => new double3(z, y, z);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zzx => new double3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zzy => new double3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 zzz => new double3(z, z, z);

        // Swizzling - double2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 xx => new double2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 xy => new double2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 xz => new double2(x, z);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 yx => new double2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 yy => new double2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 yz => new double2(y, z);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 zx => new double2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 zy => new double2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 zz => new double2(z, z);

        // RGBA Equvalence

        /// <summary>Gets the red channel, equivalent to <see cref="x"/>.</summary>
        public readonly double r => x;
        /// <summary>Gets the green channel, equivalent to <see cref="y"/>.</summary>
        public readonly double g => y;
        /// <summary>Gets the blue channel, equivalent to <see cref="z"/>.</summary>
        public readonly double b => z;

        // RGBA Swizzling - double3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rrr => new double3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rrg => new double3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rrb => new double3(r, r, b);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rgr => new double3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rgg => new double3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rgb => new double3(r, g, b);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rbr => new double3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rbg => new double3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 rbb => new double3(r, b, b);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 grr => new double3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 grg => new double3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 grb => new double3(g, r, b);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 ggr => new double3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 ggg => new double3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 ggb => new double3(g, g, b);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 gbr => new double3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 gbg => new double3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 gbb => new double3(g, b, b);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 brr => new double3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 brg => new double3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 brb => new double3(b, r, b);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 bgr => new double3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 bgg => new double3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 bgb => new double3(b, g, b);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 bbr => new double3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 bbg => new double3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as a <see cref="double3"/>.</summary>
        public readonly double3 bbb => new double3(b, b, b);

        // RGBA Swizzling - double2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 rr => new double2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 rg => new double2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 rb => new double2(r, b);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 gr => new double2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 gg => new double2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 gb => new double2(g, b);

        /// <summary>Gets the <c>br</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 br => new double2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 bg => new double2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as a <see cref="double2"/>.</summary>
        public readonly double2 bb => new double2(b, b);
    }
}
