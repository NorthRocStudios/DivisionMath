using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 3x2 matrix (3 columns, 2 rows) in column-major order (matching HLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float3x2
    {
        // Column-major storage (matching HLSL)
        public float2 c0;
        public float2 c1;
        public float2 c2;

        #region Constructors

        // From 6 scalars (row-major order for convenience)
        public float3x2(float m00, float m01, float m02, float m10, float m11, float m12)
        {
            c0 = new float2(m00, m10);
            c1 = new float2(m01, m11);
            c2 = new float2(m02, m12);
        }

        // From 3 column vectors
        public float3x2(float2 c0, float2 c1, float2 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        // From 3x2 array (row-major)
        public float3x2(float[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 3)
                throw new ArgumentException("Matrix must be 2x3 (2 rows, 3 columns)");
            c0 = new float2(m[0, 0], m[1, 0]);
            c1 = new float2(m[0, 1], m[1, 1]);
            c2 = new float2(m[0, 2], m[1, 2]);
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
                0 => row == 0 ? c0.x : c0.y,
                1 => row == 0 ? c1.x : c1.y,
                2 => row == 0 ? c2.x : c2.y,
                _ => throw new IndexOutOfRangeException()
            };
            set
            {
                switch (column)
                {
                    case 0:
                        if (row == 0) c0.x = value;
                        else c0.y = value;
                        break;
                    case 1:
                        if (row == 0) c1.x = value;
                        else c1.y = value;
                        break;
                    case 2:
                        if (row == 0) c2.x = value;
                        else c2.y = value;
                        break;
                }
            }
        }

        #endregion Indexers
        #region StaticProperties

        public static float3x2 zero => new float3x2(0f, 0f, 0f, 0f, 0f, 0f);

        #endregion StaticProperties
        #region ArithmeticOperators

        // Matrix-Matrix
        public static float3x2 operator +(float3x2 a, float3x2 b) => new float3x2(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2);
        public static float3x2 operator -(float3x2 a, float3x2 b) => new float3x2(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2);
        public static float3x2 operator *(float3x2 m, float scalar) => new float3x2(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar);
        public static float3x2 operator *(float scalar, float3x2 m) => new float3x2(m.c0 * scalar, m.c1 * scalar, m.c2 * scalar);

        // Matrix-Vector
        public static float2 operator *(float3x2 m, float3 v) => v.x * m.c0 + v.y * m.c1 + v.z * m.c2;

        // Matrix-Matrix multiplication (3x2 * 2x2 = 3x2)
        public static float3x2 operator *(float3x2 a, float2x2 b) => mul(a, b);

        #endregion ArithmeticOperators
        #region StaticMethods

        public static float3x2 mul(float3x2 m, float scalar) => m * scalar;

        public static float3x2 mul(float3x2 a, float2x2 b) => new float3x2(
            a.c0.x * b.c0 + a.c0.y * b.c1,
            a.c1.x * b.c0 + a.c1.y * b.c1,
            a.c2.x * b.c0 + a.c2.y * b.c1
        );

        public static float2x3 transpose(float3x2 m) => new float2x3(
            m.c0.x, m.c0.y,
            m.c1.x, m.c1.y,
            m.c2.x, m.c2.y
        );

        #endregion StaticMethods
        #region InstanceMethods

        public readonly float2x3 transpose() => transpose(this);

        #endregion InstanceMethods
        #region Equality

        public static bool operator ==(float3x2 a, float3x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all;
        public static bool operator !=(float3x2 a, float3x2 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is float3x2 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2);

        #endregion Equality
        #region Conversion

        public override readonly string ToString() => $"float3x2({c0.x}, {c1.x}, {c2.x},  {c0.y}, {c1.y}, {c2.y})";

        public static implicit operator float3x3(float3x2 m) => new float3x3(
            m.c0.x, m.c1.x, m.c2.x,
            m.c0.y, m.c1.y, m.c2.y,
            0f, 0f, 1f
        );

        #endregion Conversion
    }
}
