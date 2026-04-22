using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib
{
    /// <summary>
    /// Represents a 2x2 matrix in column-major order (matching HLSL and GLSL conventions).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct float2x2
    {
        // Column-major storage (matching HLSL)
        public float2 c0;
        public float2 c1;

        #region Constructors

        // From 4 scalars (row-major order for convenience)
        public float2x2(float m00, float m01, float m10, float m11)
        {
            c0 = new float2(m00, m10);
            c1 = new float2(m01, m11);
        }

        // From 2 column vectors
        public float2x2(float2 c0, float2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        // From single scalar (diagonal matrix)
        public float2x2(float diagonal)
        {
            c0 = new float2(diagonal, 0f);
            c1 = new float2(0f, diagonal);
        }

        // From 2x2 array (row-major)
        public float2x2(float[,] m)
        {
            if (m.GetLength(0) != 2 || m.GetLength(1) != 2)
                throw new ArgumentException("Matrix must be 2x2");
            c0 = new float2(m[0, 0], m[1, 0]);
            c1 = new float2(m[0, 1], m[1, 1]);
        }

        #endregion

        #region Indexers

        // Column-major indexer
        public float2 this[int column]
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
                0 => row == 0 ? c0.x : c0.y,
                1 => row == 0 ? c1.x : c1.y,
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
                }
            }
        }

        #endregion

        #region Static Properties

        public static float2x2 identity => new float2x2(1f);

        public static float2x2 zero => new float2x2(0f);

        #endregion

        #region Arithmetic Operators

        // Matrix-Matrix
        public static float2x2 operator +(float2x2 a, float2x2 b) => new float2x2(a.c0 + b.c0, a.c1 + b.c1);
        public static float2x2 operator -(float2x2 a, float2x2 b) => new float2x2(a.c0 - b.c0, a.c1 - b.c1);
        public static float2x2 operator *(float2x2 a, float2x2 b) => mul(a, b);  // Matrix multiplication
        public static float2x2 operator *(float2x2 m, float scalar) => new float2x2(m.c0 * scalar, m.c1 * scalar);
        public static float2x2 operator *(float scalar, float2x2 m) => new float2x2(m.c0 * scalar, m.c1 * scalar);

        // Matrix-Vector
        public static float2 operator *(float2x2 m, float2 v) => v.x * m.c0 + v.y * m.c1;

        #endregion

        #region Static Methods

        public static float2x2 mul(float2x2 a, float2x2 b)
        {
            return new float2x2(
                a.c0.x * b.c0.x + a.c1.x * b.c0.y,
                a.c0.y * b.c0.x + a.c1.y * b.c0.y,
                a.c0.x * b.c1.x + a.c1.x * b.c1.y,
                a.c0.y * b.c1.x + a.c1.y * b.c1.y
            );
        }

        public static float2x2 transpose(float2x2 m)
        {
            return new float2x2(
                m.c0.x, m.c1.x,
                m.c0.y, m.c1.y
            );
        }

        public static float determinant(float2x2 m)
        {
            return m.c0.x * m.c1.y - m.c1.x * m.c0.y;
        }

        public static float2x2 inverse(float2x2 m)
        {
            float det = determinant(m);
            if (det == 0f)
                return zero;

            float invDet = 1f / det;
            return new float2x2(
                 m.c1.y * invDet, -m.c1.x * invDet,
                -m.c0.y * invDet, m.c0.x * invDet
            );
        }

        #endregion

        #region Instance Methods

        public readonly float2x2 transpose() => transpose(this);
        public readonly float determinant() => determinant(this);
        public readonly float2x2 inverse() => inverse(this);

        #endregion

        #region Equality

        public static bool operator ==(float2x2 a, float2x2 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all;
        public static bool operator !=(float2x2 a, float2x2 b) => !(a == b);
        public override readonly bool Equals(object obj) => obj is float2x2 other && this == other;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1);

        #endregion

        #region Conversion

        public override readonly string ToString() => $"float2x2({c0.x}, {c1.x},  {c0.y}, {c1.y})";

        // Conversion to float3x3 (adds identity row/column)
        //public static implicit operator float3x3(float2x2 m) => new float3x3(
        //    m.c0.x, m.c1.x, 0f,
        //    m.c0.y, m.c1.y, 0f,
        //    0f, 0f, 1f
        //);

        //// Conversion to float4x4
        //public static implicit operator float4x4(float2x2 m) => new float4x4(
        //    m.c0.x, m.c1.x, 0f, 0f,
        //    m.c0.y, m.c1.y, 0f, 0f,
        //    0f, 0f, 1f, 0f,
        //    0f, 0f, 0f, 1f
        //);

        #endregion
    }
}
