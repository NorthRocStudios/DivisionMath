using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 4x3 matrix (4 columns, 3 rows) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float4x3
    {
        // Column-major storage (matching HLSL)
        public float3 c0;
        public float3 c1;
        public float3 c2;
        public float3 c3;

        #region Constructors

        // From 12 scalars (row-major order for convenience)
        public float4x3(float m00, float m01, float m02, float m03,
                        float m10, float m11, float m12, float m13,
                        float m20, float m21, float m22, float m23)
        {
            c0 = new float3(m00, m10, m20);
            c1 = new float3(m01, m11, m21);
            c2 = new float3(m02, m12, m22);
            c3 = new float3(m03, m13, m23);
        }

        // From 4 column vectors
        public float4x3(float3 c0, float3 c1, float3 c2, float3 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        // From 4x3 array (row-major)
        public float4x3(float[,] m)
        {
            if (m.GetLength(0) != 3 || m.GetLength(1) != 4)
                throw new ArgumentException("Matrix must be 3x4 (3 rows, 4 columns)");
            c0 = new float3(m[0, 0], m[1, 0], m[2, 0]);
            c1 = new float3(m[0, 1], m[1, 1], m[2, 1]);
            c2 = new float3(m[0, 2], m[1, 2], m[2, 2]);
            c3 = new float3(m[0, 3], m[1, 3], m[2, 3]);
        }

        #endregion Constructors
        #region Indexers

        // Column-major indexer
        public float3 this[int column]
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
                0 => row switch { 0 => c0.x, 1 => c0.y, 2 => c0.z, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, 2 => c1.z, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, 2 => c2.z, _ => throw new IndexOutOfRangeException() },
                3 => row switch { 0 => c3.x, 1 => c3.y, 2 => c3.z, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0:
                        switch (row) { case 0: c0.x = value; break; case 1: c0.y = value; break; case 2: c0.z = value; break; }
                        break;
                    case 1:
                        switch (row) { case 0: c1.x = value; break; case 1: c1.y = value; break; case 2: c1.z = value; break; }
                        break;
                    case 2:
                        switch (row) { case 0: c2.x = value; break; case 1: c2.y = value; break; case 2: c2.z = value; break; }
                        break;
                    case 3:
                        switch (row) { case 0: c3.x = value; break; case 1: c3.y = value; break; case 2: c3.z = value; break; }
                        break;
                }
            }
        }

        #endregion Indexers
        #region StaticProperties

        public static float4x3 zero => new float4x3(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

        #endregion StaticProperties
        #region ArithmeticOperators

        // Matrix-Matrix
        public static float4x3 operator +(float4x3 a, float4x3 b) => new float4x3(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        public static float4x3 operator -(float4x3 a, float4x3 b) => new float4x3(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        public static float4x3 operator *(float4x3 m, float scalar) => new float4x3(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar, m.c3 * scalar);
        public static float4x3 operator *(float scalar, float4x3 m) => new float4x3(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar, m.c3 * scalar);
        public static float4x3 operator /(float4x3 m, float scalar) => new float4x3(m.c0 / scalar, m.c1 / scalar, m.c2 / scalar, m.c3 / scalar);
        public static float4x3 operator -(float4x3 m) => new float4x3(-m.c0, -m.c1, -m.c2, -m.c3);
        public static float4x3 operator +(float4x3 m) => m;

        // Matrix-Vector (HLSL mul(matrix, vector))
        public static float3 operator *(float4x3 m, float4 v) => v.x * m.c0 + v.y * m.c1 + v.z * m.c2 + v.w * m.c3;

        // Matrix-Matrix multiplication (4x3 * 2x4 = 2x3)
        public static float3x4 operator *(float4x3 a, float2x4 b) => throw new NotImplementedException(); // 4x3 * 2x4 is invalid
        public static float4x3 operator *(float4x3 a, float4x4 b) => mul(a, b);

        #endregion ArithmeticOperators
        #region StaticMethods

        public static float4x3 mul(float4x3 m, float scalar) => m * scalar;

        public static float3 mul(float4x3 m, float4 v) => m * v;

        public static float4x3 mul(float4x3 a, float4x4 b) => new float4x3(
            a.c0.x * b.c0 + a.c0.y * b.c1 + a.c0.z * b.c2 + a.c0.z * b.c3,
            a.c1.x * b.c0 + a.c1.y * b.c1 + a.c1.z * b.c2 + a.c1.z * b.c3,
            a.c2.x * b.c0 + a.c2.y * b.c1 + a.c2.z * b.c2 + a.c2.z * b.c3,
            a.c3.x * b.c0 + a.c3.y * b.c1 + a.c3.z * b.c2 + a.c3.z * b.c3
        );

        public static float3x4 transpose(float4x3 m) => new float3x4(
            m.c0.x, m.c0.y, m.c0.z,
            m.c1.x, m.c1.y, m.c1.z,
            m.c2.x, m.c2.y, m.c2.z,
            m.c3.x, m.c3.y, m.c3.z
        );

        #endregion StaticMethods
        #region InstanceMethods

        public readonly float3x4 transpose() => transpose(this);

        #endregion InstanceMethods
        #region Equality

        public static bool operator ==(float4x3 a, float4x3 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        public static bool operator !=(float4x3 a, float4x3 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is float4x3 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        #endregion Equality
        #region Conversion

        public override readonly string ToString() => $"float4x3({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z})";

        #endregion Conversion
    }
}
