using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 3x4 matrix (3 columns, 4 rows) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float3x4
    {
        // Column-major storage (matching HLSL)
        public float4 c0;
        public float4 c1;
        public float4 c2;

        #region Constructors

        // From 12 scalars (row-major order for convenience)
        public float3x4(float m00, float m01, float m02,
                        float m10, float m11, float m12,
                        float m20, float m21, float m22,
                        float m30, float m31, float m32)
        {
            c0 = new float4(m00, m10, m20, m30);
            c1 = new float4(m01, m11, m21, m31);
            c2 = new float4(m02, m12, m22, m32);
        }

        // From 3 column vectors
        public float3x4(float4 c0, float4 c1, float4 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        // From 3x4 array (row-major)
        public float3x4(float[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 4x3 (4 rows, 3 columns)");
            c0 = new float4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new float4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new float4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
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
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: c0 = value; break;
                    case 1: c1 = value; break;
                    case 2: c2 = value; break;
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
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0:
                        switch (row)
                        {
                            case 0: c0.x = value; break;
                            case 1: c0.y = value; break;
                            case 2: c0.z = value; break;
                            case 3: c0.w = value; break;
                        }
                        break;
                    case 1:
                        switch (row)
                        {
                            case 0: c1.x = value; break;
                            case 1: c1.y = value; break;
                            case 2: c1.z = value; break;
                            case 3: c1.w = value; break;
                        }
                        break;
                    case 2:
                        switch (row)
                        {
                            case 0: c2.x = value; break;
                            case 1: c2.y = value; break;
                            case 2: c2.z = value; break;
                            case 3: c2.w = value; break;
                        }
                        break;
                }
            }
        }

        #endregion Indexers
        #region StaticProperties

        public static float3x4 zero => new float3x4(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

        #endregion StaticProperties
        #region ArithmeticOperators

        // Matrix-Matrix
        public static float3x4 operator +(float3x4 a, float3x4 b) => new float3x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        public static float3x4 operator -(float3x4 a, float3x4 b) => new float3x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        public static float3x4 operator *(float3x4 m, float scalar) => new float3x4(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar);
        public static float3x4 operator *(float scalar, float3x4 m) => new float3x4(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar);
        public static float3x4 operator /(float3x4 m, float scalar) => new float3x4(m.c0 / scalar, m.c1 / scalar, m.c2 / scalar);
        public static float3x4 operator -(float3x4 m) => new float3x4(-m.c0, -m.c1, -m.c2);
        public static float3x4 operator +(float3x4 m) => m;

        // Matrix-Vector (HLSL mul(matrix, vector))
        public static float4 operator *(float3x4 m, float3 v) => v.x * m.c0 + v.y * m.c1 + v.z * m.c2;

        // Matrix-Matrix multiplication (3x4 * 3x3 = 3x4)
        public static float3x4 operator *(float3x4 a, float3x3 b) => mul(a, b);

        #endregion ArithmeticOperators
        #region StaticMethods

        public static float3x4 mul(float3x4 m, float scalar) => m * scalar;

        public static float4 mul(float3x4 m, float3 v) => m * v;

        public static float3x4 mul(float3x4 a, float3x3 b) => new float3x4(
            a.c0.x * b.c0 + a.c0.y * b.c1 + a.c0.z * b.c2,
            a.c1.x * b.c0 + a.c1.y * b.c1 + a.c1.z * b.c2,
            a.c2.x * b.c0 + a.c2.y * b.c1 + a.c2.z * b.c2
        );

        public static float4x3 transpose(float3x4 m) => new float4x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            m.c0.z, m.c1.z, m.c2.z,
            m.c0.w, m.c1.w, m.c2.w
        );

        #endregion StaticMethods
        #region InstanceMethods

        public readonly float4x3 transpose() => transpose(this);

        #endregion InstanceMethods
        #region Equality

        public static bool operator ==(float3x4 a, float3x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        public static bool operator !=(float3x4 a, float3x4 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is float3x4 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        #endregion Equality
        #region Conversion

        public override readonly string ToString() => $"float3x4({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y},  {c0.z}, {c1.z}, {c2.z},  {c0.w}, {c1.w}, {c2.w})";

        #endregion Conversion
    }
}
