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
    /// Represents a 4x4 matrix (4 rows, 4 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    /// <remarks>This is the most commonly used matrix for 3D transformations.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct float4x4
    {
        /// <summary>The first column of the matrix.</summary>
        public float4 c0;
        /// <summary>The second column of the matrix.</summary>
        public float4 c1;
        /// <summary>The third column of the matrix.</summary>
        public float4 c2;
        /// <summary>The fourth column of the matrix.</summary>
        public float4 c3;

        /// <summary>
        /// Initializes a new instance of the <see cref="float4x4"/> struct from sixteen component values specified in row-major order.
        /// </summary>
        /// <param name="m00">The value at row 0, column 0.</param>
        /// <param name="m01">The value at row 0, column 1.</param>
        /// <param name="m02">The value at row 0, column 2.</param>
        /// <param name="m03">The value at row 0, column 3.</param>
        /// <param name="m10">The value at row 1, column 0.</param>
        /// <param name="m11">The value at row 1, column 1.</param>
        /// <param name="m12">The value at row 1, column 2.</param>
        /// <param name="m13">The value at row 1, column 3.</param>
        /// <param name="m20">The value at row 2, column 0.</param>
        /// <param name="m21">The value at row 2, column 1.</param>
        /// <param name="m22">The value at row 2, column 2.</param>
        /// <param name="m23">The value at row 2, column 3.</param>
        /// <param name="m30">The value at row 3, column 0.</param>
        /// <param name="m31">The value at row 3, column 1.</param>
        /// <param name="m32">The value at row 3, column 2.</param>
        /// <param name="m33">The value at row 3, column 3.</param>
        public float4x4(float m00, float m01, float m02, float m03,
                        float m10, float m11, float m12, float m13,
                        float m20, float m21, float m22, float m23,
                        float m30, float m31, float m32, float m33)
        {
            c0 = new float4(m00, m10, m20, m30);
            c1 = new float4(m01, m11, m21, m31);
            c2 = new float4(m02, m12, m22, m32);
            c3 = new float4(m03, m13, m23, m33);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="float4x4"/> struct from the specified columns.
        /// </summary>
        /// <param name="c0">The first column.</param>
        /// <param name="c1">The second column.</param>
        /// <param name="c2">The third column.</param>
        /// <param name="c3">The fourth column.</param>
        public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        /// <summary>
        /// Initializes a new instance of the <see cref="float4x4"/> struct with the specified value on the main diagonal and zeros elsewhere.
        /// </summary>
        /// <param name="diagonal">The value placed on the main diagonal.</param>
        public float4x4(float diagonal)
        {
            c0 = new float4(diagonal, 0f, 0f, 0f);
            c1 = new float4(0f, diagonal, 0f, 0f);
            c2 = new float4(0f, 0f, diagonal, 0f);
            c3 = new float4(0f, 0f, 0f, diagonal);
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="float4x4"/> struct from a 4x4 array of values in row-major order.
        /// </summary>
        /// <param name="m">The 4x4 array of values in row-major order.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="m"/> is not a 4x4 array.</exception>
        public float4x4(float[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 4) throw new ArgumentException("Matrix must be 4x4");
            c0 = new float4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new float4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new float4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
            c3 = new float4(m[0, 3], m[1, 3], m[2, 3], m[3, 3]);
        }

        /// <summary>
        /// Gets or sets the column at the specified index.
        /// </summary>
        /// <param name="column">The zero-based column index (0 = c0, 1 = c1, 2 = c2, 3 = c3).</param>
        /// <returns>The column at <paramref name="column"/>.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="column"/> is outside the range 0-3.</exception>
        public float4 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, 3 => c3, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; case 3: c3 = value; break; } }
        }
        /// <summary>
        /// Gets or sets the matrix component at the specified row and column.
        /// </summary>
        /// <param name="row">The zero-based row index.</param>
        /// <param name="column">The zero-based column index.</param>
        /// <returns>The component at the specified row and column.</returns>
        /// <exception cref="IndexOutOfRangeException">Thrown by the getter when <paramref name="row"/> or <paramref name="column"/> is out of range.</exception>
        public float this[int row, int column]
        {
            readonly get => column switch
            {
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, 3 => c0.w, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, 3 => c1.w, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, 3 => c2.w, _ => throw new IndexOutOfRangeException() },
                3 => row switch { 0 => c3.x, 1 => c3.y, 2 => c3.z, 3 => c3.w, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; case 3: c0.w = value; break; } break;
                    case 1: switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; case 3: c1.w = value; break; } break;
                    case 2: switch (row) { case 0: c2.x = value; break; case 1: c2.y = value; break; case 2: c2.z = value; break; case 3: c2.w = value; break; } break;
                    case 3: switch (row) { case 0: c3.x = value; break; case 1: c3.y = value; break; case 2: c3.z = value; break; case 3: c3.w = value; break; } break;
                }
            }
        }

        /// <summary>Gets the identity matrix.</summary>
        public static float4x4 identity => new float4x4(1f);
        /// <summary>Gets a matrix with all components set to zero.</summary>
        public static float4x4 zero => new float4x4(0f);

        /// <summary>Adds two matrices component-wise.</summary>
        public static float4x4 operator +(float4x4 a, float4x4 b) => new float4x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        /// <summary>Subtracts two matrices component-wise.</summary>
        public static float4x4 operator -(float4x4 a, float4x4 b) => new float4x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        /// <summary>Multiplies two matrices.</summary>
        public static float4x4 operator *(float4x4 a, float4x4 b) => mul(a, b);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static float4x4 operator *(float4x4 m, float s) => new float4x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        /// <summary>Multiplies each component of the matrix by a scalar value.</summary>
        public static float4x4 operator *(float s, float4x4 m) => new float4x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        /// <summary>Divides each component of the matrix by a scalar value.</summary>
        public static float4x4 operator /(float4x4 m, float s) => new float4x4(m.c0 / s, m.c1 / s, m.c2 / s, m.c3 / s);
        /// <summary>Negates each component of the matrix.</summary>
        public static float4x4 operator -(float4x4 m) => new float4x4(-m.c0, -m.c1, -m.c2, -m.c3);
        /// <summary>Returns the matrix unchanged.</summary>
        public static float4x4 operator +(float4x4 m) => m;
        /// <summary>Multiplies a matrix by a column vector.</summary>
        public static float4 operator *(float4x4 m, float4 v) => mul(m, v);
        /// <summary>Multiplies a row vector by a matrix.</summary>
        public static float4 operator *(float4 v, float4x4 m) => mul(v, m);

        /// <summary>
        /// Multiplies each component of the matrix by a scalar value.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="s">The scalar value.</param>
        /// <returns>The scaled matrix.</returns>
        public static float4x4 mul(float4x4 m, float s) => m * s;
        /// <summary>
        /// Multiplies a <see cref="float4x4"/> by a column vector.
        /// </summary>
        /// <param name="m">The matrix.</param>
        /// <param name="v">The column vector.</param>
        /// <returns>The transformed vector.</returns>
        public static float4 mul(float4x4 m, float4 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z + m.c3 * v.w;
        /// <summary>
        /// Multiplies a row vector by a <see cref="float4x4"/>.
        /// </summary>
        /// <param name="v">The row vector.</param>
        /// <param name="m">The matrix.</param>
        /// <returns>The transformed vector.</returns>
        public static float4 mul(float4 v, float4x4 m) => new float4(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z + v.w * m.c0.w,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z + v.w * m.c1.w,
            v.x * m.c2.x + v.y * m.c2.y + v.z * m.c2.z + v.w * m.c2.w,
            v.x * m.c3.x + v.y * m.c3.y + v.z * m.c3.z + v.w * m.c3.w);

        /// <summary>
        /// Multiplies a <see cref="float4x4"/> by a <see cref="float4x2"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x2 mul(float4x4 a, float4x2 b) => new float4x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        /// <summary>
        /// Multiplies a <see cref="float4x4"/> by a <see cref="float4x3"/>.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x3 mul(float4x4 a, float4x3 b) => new float4x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        /// <summary>
        /// Multiplies two <see cref="float4x4"/> matrices.
        /// </summary>
        /// <param name="a">The left matrix.</param>
        /// <param name="b">The right matrix.</param>
        /// <returns>The product matrix.</returns>
        public static float4x4 mul(float4x4 a, float4x4 b) => new float4x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);

        /// <summary>
        /// Returns the transpose of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to transpose.</param>
        /// <returns>The transposed matrix.</returns>
        public static float4x4 transpose(float4x4 m) => new float4x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w,
            m.c2.x, m.c2.y, m.c2.z, m.c2.w,
            m.c3.x, m.c3.y, m.c3.z, m.c3.w);

        /// <summary>
        /// Computes the determinant of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix whose determinant is computed.</param>
        /// <returns>The determinant of the matrix.</returns>
        public static float determinant(float4x4 m)
        {
            float det = m.c0.x * (
                m.c1.y * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) -
                m.c1.z * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) +
                m.c1.w * (m.c2.y * m.c3.z - m.c2.z * m.c3.y)
            ) - m.c1.x * (
                m.c0.y * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) -
                m.c0.z * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) +
                m.c0.w * (m.c2.y * m.c3.z - m.c2.z * m.c3.y)
            ) + m.c2.x * (
                m.c0.y * (m.c1.z * m.c3.w - m.c1.w * m.c3.z) -
                m.c0.z * (m.c1.y * m.c3.w - m.c1.w * m.c3.y) +
                m.c0.w * (m.c1.y * m.c3.z - m.c1.z * m.c3.y)
            ) - m.c3.x * (
                m.c0.y * (m.c1.z * m.c2.w - m.c1.w * m.c2.z) -
                m.c0.z * (m.c1.y * m.c2.w - m.c1.w * m.c2.y) +
                m.c0.w * (m.c1.y * m.c2.z - m.c1.z * m.c2.y)
            );
            return det;
        }

        /// <summary>
        /// Computes the inverse of the specified matrix.
        /// </summary>
        /// <param name="m">The matrix to invert.</param>
        /// <returns>The inverse of the matrix.</returns>
        public static float4x4 inverse(float4x4 m)
        {
            float det = determinant(m);
            float invDet = 1f / det;

            float c00 = (m.c1.y * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) - m.c1.z * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) + m.c1.w * (m.c2.y * m.c3.z - m.c2.z * m.c3.y)) * invDet;
            float c01 = -(m.c0.y * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) - m.c0.z * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) + m.c0.w * (m.c2.y * m.c3.z - m.c2.z * m.c3.y)) * invDet;
            float c02 = (m.c0.y * (m.c1.z * m.c3.w - m.c1.w * m.c3.z) - m.c0.z * (m.c1.y * m.c3.w - m.c1.w * m.c3.y) + m.c0.w * (m.c1.y * m.c3.z - m.c1.z * m.c3.y)) * invDet;
            float c03 = -(m.c0.y * (m.c1.z * m.c2.w - m.c1.w * m.c2.z) - m.c0.z * (m.c1.y * m.c2.w - m.c1.w * m.c2.y) + m.c0.w * (m.c1.y * m.c2.z - m.c1.z * m.c2.y)) * invDet;
            float c10 = -(m.c1.x * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) - m.c1.z * (m.c2.x * m.c3.w - m.c2.w * m.c3.x) + m.c1.w * (m.c2.x * m.c3.z - m.c2.z * m.c3.x)) * invDet;
            float c11 = (m.c0.x * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) - m.c0.z * (m.c2.x * m.c3.w - m.c2.w * m.c3.x) + m.c0.w * (m.c2.x * m.c3.z - m.c2.z * m.c3.x)) * invDet;
            float c12 = -(m.c0.x * (m.c1.z * m.c3.w - m.c1.w * m.c3.z) - m.c0.z * (m.c1.x * m.c3.w - m.c1.w * m.c3.x) + m.c0.w * (m.c1.x * m.c3.z - m.c1.z * m.c3.x)) * invDet;
            float c13 = (m.c0.x * (m.c1.z * m.c2.w - m.c1.w * m.c2.z) - m.c0.z * (m.c1.x * m.c2.w - m.c1.w * m.c2.x) + m.c0.w * (m.c1.x * m.c2.z - m.c1.z * m.c2.x)) * invDet;
            float c20 = (m.c1.x * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) - m.c1.y * (m.c2.x * m.c3.w - m.c2.w * m.c3.x) + m.c1.w * (m.c2.x * m.c3.y - m.c2.y * m.c3.x)) * invDet;
            float c21 = -(m.c0.x * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) - m.c0.y * (m.c2.x * m.c3.w - m.c2.w * m.c3.x) + m.c0.w * (m.c2.x * m.c3.y - m.c2.y * m.c3.x)) * invDet;
            float c22 = (m.c0.x * (m.c1.y * m.c3.w - m.c1.w * m.c3.y) - m.c0.y * (m.c1.x * m.c3.w - m.c1.w * m.c3.x) + m.c0.w * (m.c1.x * m.c3.y - m.c1.y * m.c3.x)) * invDet;
            float c23 = -(m.c0.x * (m.c1.y * m.c2.w - m.c1.w * m.c2.y) - m.c0.y * (m.c1.x * m.c2.w - m.c1.w * m.c2.x) + m.c0.w * (m.c1.x * m.c2.y - m.c1.y * m.c2.x)) * invDet;
            float c30 = -(m.c1.x * (m.c2.y * m.c3.z - m.c2.z * m.c3.y) - m.c1.y * (m.c2.x * m.c3.z - m.c2.z * m.c3.x) + m.c1.z * (m.c2.x * m.c3.y - m.c2.y * m.c3.x)) * invDet;
            float c31 = (m.c0.x * (m.c2.y * m.c3.z - m.c2.z * m.c3.y) - m.c0.y * (m.c2.x * m.c3.z - m.c2.z * m.c3.x) + m.c0.z * (m.c2.x * m.c3.y - m.c2.y * m.c3.x)) * invDet;
            float c32 = -(m.c0.x * (m.c1.y * m.c3.z - m.c1.z * m.c3.y) - m.c0.y * (m.c1.x * m.c3.z - m.c1.z * m.c3.x) + m.c0.z * (m.c1.x * m.c3.y - m.c1.y * m.c3.x)) * invDet;
            float c33 = (m.c0.x * (m.c1.y * m.c2.z - m.c1.z * m.c2.y) - m.c0.y * (m.c1.x * m.c2.z - m.c1.z * m.c2.x) + m.c0.z * (m.c1.x * m.c2.y - m.c1.y * m.c2.x)) * invDet;

            return new float4x4(
                c00, c10, c20, c30,
                c01, c11, c21, c31,
                c02, c12, c22, c32,
                c03, c13, c23, c33);
        }

        #region Non-HLSL extensions (Unity-style helpers; DivisionTranslate expands these)

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="t">The translation offset.</param>
        /// <returns>The translation matrix.</returns>
        public static float4x4 translate(float3 t) => new float4x4(
            1f, 0f, 0f, t.x,
            0f, 1f, 0f, t.y,
            0f, 0f, 1f, t.z,
            0f, 0f, 0f, 1f);

        /// <summary>
        /// Creates a scale matrix.
        /// </summary>
        /// <param name="s">The scale factor for each axis.</param>
        /// <returns>The scale matrix.</returns>
        public static float4x4 scale(float3 s) => new float4x4(
            s.x, 0f, 0f, 0f,
            0f, s.y, 0f, 0f,
            0f, 0f, s.z, 0f,
            0f, 0f, 0f, 1f);

        /// <summary>
        /// Creates a rotation matrix about the X axis.
        /// </summary>
        /// <param name="angle">The rotation angle in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static float4x4 rotateX(float angle)
        {
            float c = math.cos(angle);
            float s = math.sin(angle);
            return new float4x4(
                1f, 0f, 0f, 0f,
                0f, c, -s, 0f,
                0f, s, c, 0f,
                0f, 0f, 0f, 1f);
        }
        /// <summary>
        /// Creates a rotation matrix about the Y axis.
        /// </summary>
        /// <param name="angle">The rotation angle in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static float4x4 rotateY(float angle)
        {
            float c = math.cos(angle);
            float s = math.sin(angle);
            return new float4x4(
                c, 0f, s, 0f,
                0f, 1f, 0f, 0f,
                -s, 0f, c, 0f,
                0f, 0f, 0f, 1f);
        }
        /// <summary>
        /// Creates a rotation matrix about the Z axis.
        /// </summary>
        /// <param name="angle">The rotation angle in radians.</param>
        /// <returns>The rotation matrix.</returns>
        public static float4x4 rotateZ(float angle)
        {
            float c = math.cos(angle);
            float s = math.sin(angle);
            return new float4x4(
                c, -s, 0f, 0f,
                s, c, 0f, 0f,
                0f, 0f, 1f, 0f,
                0f, 0f, 0f, 1f);
        }

        /// <summary>
        /// Creates a perspective projection matrix.
        /// </summary>
        /// <param name="fovY">The vertical field of view in radians.</param>
        /// <param name="aspect">The aspect ratio (width divided by height).</param>
        /// <param name="near">The near clip plane distance.</param>
        /// <param name="far">The far clip plane distance.</param>
        /// <returns>The perspective projection matrix.</returns>
        public static float4x4 perspectiveFov(float fovY, float aspect, float near, float far)
        {
            float h = 1f / math.tan(fovY * 0.5f);
            float w = h / aspect;
            float range = far / (near - far);
            return new float4x4(
                w, 0f, 0f, 0f,
                0f, h, 0f, 0f,
                0f, 0f, range, -1f,
                0f, 0f, range * near, 0f);
        }

        /// <summary>
        /// Creates a camera-to-world matrix for an eye position looking toward a target position.
        /// </summary>
        /// <remarks>The basis is built from the eye-to-target direction and the up vector, and the translation column is the eye position. Invert the result to obtain a conventional view matrix.</remarks>
        /// <param name="eye">The eye position.</param>
        /// <param name="target">The target position.</param>
        /// <param name="up">The up vector.</param>
        /// <returns>The camera-to-world matrix.</returns>
        public static float4x4 lookAt(float3 eye, float3 target, float3 up)
        {
            float3 zaxis = math.normalize(target - eye);
            float3 xaxis = math.normalize(math.cross(up, zaxis));
            float3 yaxis = math.cross(zaxis, xaxis);
            return new float4x4(
                xaxis.x, yaxis.x, zaxis.x, eye.x,
                xaxis.y, yaxis.y, zaxis.y, eye.y,
                xaxis.z, yaxis.z, zaxis.z, eye.z,
                0f, 0f, 0f, 1f);
        }

        #endregion

        /// <summary>Returns the transpose of the matrix.</summary>
        public readonly float4x4 transpose() => transpose(this);
        /// <summary>Computes the determinant of the matrix.</summary>
        public readonly float determinant() => determinant(this);
        /// <summary>Computes the inverse of the matrix.</summary>
        public readonly float4x4 inverse() => inverse(this);

        /// <summary>Determines whether two matrices are equal.</summary>
        public static bool operator ==(float4x4 a, float4x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        /// <summary>Determines whether two matrices are not equal.</summary>
        public static bool operator !=(float4x4 a, float4x4 b) => !(a == b);
        /// <summary>
        /// Determines whether the specified object is equal to the current <see cref="float4x4"/>.
        /// </summary>
        /// <param name="obj">The object to compare with the current <see cref="float4x4"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="float4x4"/> with equal components; otherwise, <see langword="false"/>.</returns>
        public override readonly bool Equals(object? obj) => obj is float4x4 o && this == o;
        /// <summary>Returns a hash code for the current instance.</summary>
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        /// <summary>Returns a string representation of the matrix.</summary>
        public override readonly string ToString() =>
            $"float4x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z},  {c0.w}, {c1.w}, {c2.w}, {c3.w})";
    }
}
