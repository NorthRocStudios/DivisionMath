using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 4x2 matrix (4 columns, 2 rows) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float4x2
    {
        // Column-major storage (matching HLSL)
        public float2 c0;
        public float2 c1;
        public float2 c2;
        public float2 c3;

        #region Constructors

        // From 8 scalars (row-major order for convenience)
        public float4x2(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13)
        {
            c0 = new float2(m00, m10);
            c1 = new float2(m01, m11);
            c2 = new float2(m02, m12);
            c3 = new float2(m03, m13);
        }

        // From 4 column vectors
        public float4x2(float2 c0, float2 c1, float2 c2, float2 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        // From 4x2 array (row-major)
        public float4x2(float[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 4)
                throw new ArgumentException("Matrix must be 2x4 (2 rows, 4 columns)");
            c0 = new float2(m[0, 0], m[1, 0]);
            c1 = new float2(m[0, 1], m[1, 1]);
            c2 = new float2(m[0, 2], m[1, 2]);
            c3 = new float2(m[0, 3], m[1, 3]);
        }

        #endregion Constructors
        #region Indexers

        // Column-major indexer
        public float2 this[int column]
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
                0 => row switch { 0 => c0.x, 1 => c0.y, _ => throw new IndexOutOfRangeException() },
                1 => row switch { 0 => c1.x, 1 => c1.y, _ => throw new IndexOutOfRangeException() },
                2 => row switch { 0 => c2.x, 1 => c2.y, _ => throw new IndexOutOfRangeException() },
                3 => row switch { 0 => c3.x, 1 => c3.y, _ => throw new IndexOutOfRangeException() },
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0:
                        if (row == 0) c0.x = value; else c0.y = value;
                        break;
                    case 1:
                        if (row == 0) c1.x = value; else c1.y = value;
                        break;
                    case 2:
                        if (row == 0) c2.x = value; else c2.y = value;
                        break;
                    case 3:
                        if (row == 0) c3.x = value; else c3.y = value;
                        break;
                }
            }
        }

        #endregion Indexers
        #region StaticProperties

        public static float4x2 zero => new float4x2(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);

        #endregion StaticProperties
        #region ArithmeticOperators

        // Matrix-Matrix
        public static float4x2 operator +(float4x2 a, float4x2 b) => new float4x2(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        public static float4x2 operator -(float4x2 a, float4x2 b) => new float4x2(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        public static float4x2 operator *(float4x2 m, float scalar) => new float4x2(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar, m.c3 * scalar);
        public static float4x2 operator *(float scalar, float4x2 m) => new float4x2(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar, m.c3 * scalar);
        public static float4x2 operator /(float4x2 m, float scalar) => new float4x2(m.c0 / scalar, m.c1 / scalar, m.c2 / scalar, m.c3 / scalar);
        public static float4x2 operator -(float4x2 m) => new float4x2(-m.c0, -m.c1, -m.c2, -m.c3);
        public static float4x2 operator +(float4x2 m) => m;

        // Matrix-Vector (HLSL mul(matrix, vector))
        public static float2 operator *(float4x2 m, float4 v) => v.x * m.c0 + v.y * m.c1 + v.z * m.c2 + v.w * m.c3;

        // Matrix-Matrix multiplication (4x2 * 2x2 = 4x2)
        public static float4x2 operator *(float4x2 a, float2x2 b) => mul(a, b);

        #endregion ArithmeticOperators
        #region StaticMethods

        public static float4x2 mul(float4x2 m, float scalar) => m * scalar;

        public static float2 mul(float4x2 m, float4 v) => m * v;

        public static float4x2 mul(float4x2 a, float2x2 b) => new float4x2(
            a.c0.x * b.c0 + a.c0.y * b.c1,
            a.c1.x * b.c0 + a.c1.y * b.c1,
            a.c2.x * b.c0 + a.c2.y * b.c1,
            a.c3.x * b.c0 + a.c3.y * b.c1
        );

        public static float2x4 transpose(float4x2 m) => new float2x4(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y,
            m.c2.x, m.c2.y,
            m.c3.x, m.c3.y
        );

        #endregion StaticMethods
        #region InstanceMethods

        public readonly float2x4 transpose() => transpose(this);

        #endregion InstanceMethods
        #region Equality

        public static bool operator ==(float4x2 a, float4x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        public static bool operator !=(float4x2 a, float4x2 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is float4x2 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        #endregion Equality
        #region Conversion

        public override readonly string ToString() => $"float4x2({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y})";

        #endregion Conversion
    }
}
