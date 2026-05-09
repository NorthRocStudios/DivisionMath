using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 2x4 matrix (2 columns, 4 rows) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float2x4
    {
        // Column-major storage (matching HLSL)
        public float4 c0;
        public float4 c1;

        #region Constructors

        // From 8 scalars (row-major order for convenience)
        public float2x4(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
        {
            c0 = new float4(m00, m10, m20, m30);
            c1 = new float4(m01, m11, m21, m31);
        }

        // From 2 column vectors
        public float2x4(float4 c0, float4 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        // From 2x4 array (row-major)
        public float2x4(float[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 4x2 (4 rows, 2 columns)");
            c0 = new float4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new float4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
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
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0: c0 = value; break;
                    case 1: c1 = value; break;
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
                }
            }
        }

        #endregion Indexers
        #region StaticProperties

        public static float2x4 zero => new float2x4(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

        #endregion StaticProperties
        #region ArithmeticOperators

        // Matrix-Matrix
        public static float2x4 operator +(float2x4 a, float2x4 b) => new float2x4(a.c0 + b.c0, a.c1 + b.c1);
        public static float2x4 operator -(float2x4 a, float2x4 b) => new float2x4(a.c0 - b.c0, a.c1 - b.c1);
        public static float2x4 operator *(float2x4 m, float scalar) => new float2x4(m.c0 * scalar, m.c1 * scalar);
        public static float2x4 operator *(float scalar, float2x4 m) => new float2x4(m.c0 * scalar, m.c1 * scalar);
        public static float2x4 operator /(float2x4 m, float scalar) => new float2x4(m.c0 / scalar, m.c1 / scalar);
        public static float2x4 operator -(float2x4 m) => new float2x4(-m.c0, -m.c1);
        public static float2x4 operator +(float2x4 m) => m;

        // Matrix-Vector (HLSL mul(matrix, vector))
        public static float4 operator *(float2x4 m, float2 v) => v.x * m.c0 + v.y * m.c1;

        #endregion ArithmeticOperators
        #region StaticMethods

        public static float2x4 mul(float2x4 m, float scalar) => m * scalar;

        public static float4 mul(float2x4 m, float2 v) => m * v;

        public static float4x2 transpose(float2x4 m) => new float4x2(
            m.c0.x, m.c1.x,
            m.c0.y, m.c1.y,
            m.c0.z, m.c1.z,
            m.c0.w, m.c1.w
        );

        #endregion StaticMethods
        #region InstanceMethods

        public readonly float4x2 transpose() => transpose(this);

        #endregion InstanceMethods
        #region Equality

        public static bool operator ==(float2x4 a, float2x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        public static bool operator !=(float2x4 a, float2x4 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is float2x4 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        #endregion Equality
        #region Conversion

        public override readonly string ToString() => $"float2x4({c0.x}, {c1.x},  {c0.y}, {c1.y},  {c0.z}, {c1.z},  {c0.w}, {c1.w})";

        #endregion Conversion
    }
}
