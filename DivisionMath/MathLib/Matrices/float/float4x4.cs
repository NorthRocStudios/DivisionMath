using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 4x4 matrix in column-major order (matching HLSL conventions).
    /// <remarks>This is the most commonly used matrix for 3D transformations</remarks> 
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float4x4
    {
        // Column-major storage (matching HLSL)
        public float4 c0;
        public float4 c1;
        public float4 c2;
        public float4 c3;

        #region Constructors

        // From 16 scalars (row-major order for convenience)
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

        // From 4 column vectors
        public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        // From single scalar (diagonal matrix)
        public float4x4(float diagonal)
        {
            c0 = new float4(diagonal, 0f, 0f, 0f);
            c1 = new float4(0f, diagonal, 0f, 0f);
            c2 = new float4(0f, 0f, diagonal, 0f);
            c3 = new float4(0f, 0f, 0f, diagonal);
        }

        // From 4x4 array (row-major)
        public float4x4(float[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 4)
                throw new ArgumentException("Matrix must be 4x4");
            c0 = new float4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new float4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new float4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
            c3 = new float4(m[0, 3], m[1, 3], m[2, 3], m[3, 3]);
        }

        #endregion Constructors
        #region Indexers

        // Column-major indexer
        public float4 this[int column]
        {
            readonly get => column switch
            {
                0 => c0,
                1 => c1,
                2 => c2,
                3 => c3,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: c0 = value; break;
                    case 1: c1 = value; break;
                    case 2: c2 = value; break;
                    case 3: c3 = value; break;
                }
            }
        }

        // Element access via [row, column]
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
                    case 0:
                        switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; case 3: c0.w = value; break; }
                        break;
                    case 1:
                        switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; case 3: c1.w = value; break; }
                        break;
                    case 2:
                        switch (row) { case 0: c2.x = value; break; case 1: c2.y = value; break; case 2: c2.z = value; break; case 3: c2.w = value; break; }
                        break;
                    case 3:
                        switch (row) { case 0: c3.x = value; break; case 1: c3.y = value; break; case 2: c3.z = value; break; case 3: c3.w = value; break; }
                        break;
                }
            }
        }

        #endregion Indexers
        #region StaticProperties

        public static float4x4 identity => new float4x4(1f);
        public static float4x4 zero => new float4x4(0f);

        #endregion StaticProperties
        #region ArithmeticOperators

        // Matrix-Matrix
        public static float4x4 operator +(float4x4 a, float4x4 b) => new float4x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        public static float4x4 operator -(float4x4 a, float4x4 b) => new float4x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        public static float4x4 operator *(float4x4 a, float4x4 b) => mul(a, b);
        public static float4x4 operator *(float4x4 m, float scalar) => new float4x4(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar, m.c3 * scalar);
        public static float4x4 operator *(float scalar, float4x4 m) => new float4x4(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar, m.c3 * scalar);
        public static float4x4 operator /(float4x4 m, float scalar) => new float4x4(m.c0 / scalar, m.c1 / scalar, m.c2 / scalar, m.c3 / scalar);
        public static float4x4 operator -(float4x4 m) => new float4x4(-m.c0, -m.c1, -m.c2, -m.c3);
        public static float4x4 operator +(float4x4 m) => m;

        // Matrix-Vector (HLSL mul(matrix, vector))
        public static float4 operator *(float4x4 m, float4 v) => v.x * m.c0 + v.y * m.c1 + v.z * m.c2 + v.w * m.c3;

        #endregion ArithmeticOperators
        #region StaticMethods

        public static float4x4 mul(float4x4 a, float4x4 b)
        {
            float4 c0 = a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w;
            float4 c1 = a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w;
            float4 c2 = a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w;
            float4 c3 = a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w;
            return new float4x4(c0, c1, c2, c3);
        }

        public static float4 mul(float4x4 m, float4 v) => m * v;

        public static float4x4 transpose(float4x4 m) => new float4x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w,
            m.c2.x, m.c2.y, m.c2.z, m.c2.w,
            m.c3.x, m.c3.y, m.c3.z, m.c3.w
        );

        public static float determinant(float4x4 m)
        {
            // Laplace expansion along first row
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

        public static float4x4 inverse(float4x4 m)
        {
            float det = determinant(m);
            if (det == 0f)
                return zero;

            float invDet = 1f / det;

            // Cofactor matrix (then transpose for adjugate)
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
                c03, c13, c23, c33
            );
        }

        // HLSL matrix construction methods
        public static float4x4 translate(float3 translation) => new float4x4(
            1f, 0f, 0f, translation.x,
            0f, 1f, 0f, translation.y,
            0f, 0f, 1f, translation.z,
            0f, 0f, 0f, 1f
        );

        public static float4x4 scale(float3 scale) => new float4x4(
            scale.x, 0f, 0f, 0f,
            0f, scale.y, 0f, 0f,
            0f, 0f, scale.z, 0f,
            0f, 0f, 0f, 1f
        );

        public static float4x4 rotateX(float angle)
        {
            float c = math.cos(angle);
            float s = math.sin(angle);
            return new float4x4(
                1f, 0f, 0f, 0f,
                0f, c, -s, 0f,
                0f, s, c, 0f,
                0f, 0f, 0f, 1f
            );
        }

        public static float4x4 rotateY(float angle)
        {
            float c = math.cos(angle);
            float s = math.sin(angle);
            return new float4x4(
                c, 0f, s, 0f,
                0f, 1f, 0f, 0f,
                -s, 0f, c, 0f,
                0f, 0f, 0f, 1f
            );
        }

        public static float4x4 rotateZ(float angle)
        {
            float c = math.cos(angle);
            float s = math.sin(angle);
            return new float4x4(
                c, -s, 0f, 0f,
                s, c, 0f, 0f,
                0f, 0f, 1f, 0f,
                0f, 0f, 0f, 1f
            );
        }

        public static float4x4 perspectiveFov(float fovY, float aspect, float near, float far)
        {
            float h = 1f / math.tan(fovY * 0.5f);
            float w = h / aspect;
            float range = far / (near - far);

            return new float4x4(
                w, 0f, 0f, 0f,
                0f, h, 0f, 0f,
                0f, 0f, range, -1f,
                0f, 0f, range * near, 0f
            );
        }

        public static float4x4 lookAt(float3 eye, float3 target, float3 up)
        {
            float3 zaxis = math.normalize(target - eye);
            float3 xaxis = math.normalize(math.cross(up, zaxis));
            float3 yaxis = math.cross(zaxis, xaxis);

            return new float4x4(
                xaxis.x, yaxis.x, zaxis.x, eye.x,
                xaxis.y, yaxis.y, zaxis.y, eye.y,
                xaxis.z, yaxis.z, zaxis.z, eye.z,
                0f, 0f, 0f, 1f
            );
        }

        #endregion StaticMethods
        #region InstanceMethods

        public readonly float4x4 transpose() => transpose(this);
        public readonly float determinant() => determinant(this);
        public readonly float4x4 inverse() => inverse(this);

        #endregion InstanceMethods
        #region Equality

        public static bool operator ==(float4x4 a, float4x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        public static bool operator !=(float4x4 a, float4x4 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is float4x4 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        #endregion Equality
        #region Conversion

        public override readonly string ToString() =>
            $"float4x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z},  {c0.w}, {c1.w}, {c2.w}, {c3.w})";

        #endregion Conversion
    }
}
