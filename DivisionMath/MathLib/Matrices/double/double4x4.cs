using System.Runtime.InteropServices;

namespace DivisionEngine.MathLib.Matrices
{
    /// <summary>
    /// Represents a 4x4 double matrix (4 rows, 4 columns) in column-major order (matching HLSL conventions).
    /// </summary>
    /// <remarks>This is the most commonly used matrix for 3D transformations.</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct double4x4
    {
        public double4 c0;
        public double4 c1;
        public double4 c2;
        public double4 c3;

        public double4x4(double m00, double m01, double m02, double m03,
                         double m10, double m11, double m12, double m13,
                         double m20, double m21, double m22, double m23,
                         double m30, double m31, double m32, double m33)
        {
            c0 = new double4(m00, m10, m20, m30);
            c1 = new double4(m01, m11, m21, m31);
            c2 = new double4(m02, m12, m22, m32);
            c3 = new double4(m03, m13, m23, m33);
        }
        public double4x4(double4 c0, double4 c1, double4 c2, double4 c3)
        { this.c0 = c0; this.c1 = c1; this.c2 = c2; this.c3 = c3; }
        public double4x4(double diagonal)
        {
            c0 = new double4(diagonal, 0.0, 0.0, 0.0);
            c1 = new double4(0.0, diagonal, 0.0, 0.0);
            c2 = new double4(0.0, 0.0, diagonal, 0.0);
            c3 = new double4(0.0, 0.0, 0.0, diagonal);
        }
        public double4x4(double[,] m)
        {
            if (m.GetLength(0) != 4 || m.GetLength(1) != 4) throw new ArgumentException("Matrix must be 4x4");
            c0 = new double4(m[0, 0], m[1, 0], m[2, 0], m[3, 0]);
            c1 = new double4(m[0, 1], m[1, 1], m[2, 1], m[3, 1]);
            c2 = new double4(m[0, 2], m[1, 2], m[2, 2], m[3, 2]);
            c3 = new double4(m[0, 3], m[1, 3], m[2, 3], m[3, 3]);
        }

        public double4 this[int column]
        {
            readonly get => column switch { 0 => c0, 1 => c1, 2 => c2, 3 => c3, _ => throw new IndexOutOfRangeException() };
            set { switch (column) { case 0: c0 = value; break; case 1: c1 = value; break; case 2: c2 = value; break; case 3: c3 = value; break; } }
        }
        public double this[int row, int column]
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

        public static double4x4 identity => new double4x4(1.0);
        public static double4x4 zero => new double4x4(0.0);

        public static double4x4 operator +(double4x4 a, double4x4 b) => new double4x4(a.c0 + b.c0, a.c1 + b.c1, a.c2 + b.c2, a.c3 + b.c3);
        public static double4x4 operator -(double4x4 a, double4x4 b) => new double4x4(a.c0 - b.c0, a.c1 - b.c1, a.c2 - b.c2, a.c3 - b.c3);
        public static double4x4 operator *(double4x4 a, double4x4 b) => mul(a, b);
        public static double4x4 operator *(double4x4 m, double s) => new double4x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        public static double4x4 operator *(double s, double4x4 m) => new double4x4(m.c0 * s, m.c1 * s, m.c2 * s, m.c3 * s);
        public static double4x4 operator /(double4x4 m, double s) => new double4x4(m.c0 / s, m.c1 / s, m.c2 / s, m.c3 / s);
        public static double4x4 operator -(double4x4 m) => new double4x4(-m.c0, -m.c1, -m.c2, -m.c3);
        public static double4x4 operator +(double4x4 m) => m;
        public static double4 operator *(double4x4 m, double4 v) => mul(m, v);
        public static double4 operator *(double4 v, double4x4 m) => mul(v, m);

        public static double4x4 mul(double4x4 m, double s) => m * s;
        public static double4 mul(double4x4 m, double4 v) => m.c0 * v.x + m.c1 * v.y + m.c2 * v.z + m.c3 * v.w;
        public static double4 mul(double4 v, double4x4 m) => new double4(
            v.x * m.c0.x + v.y * m.c0.y + v.z * m.c0.z + v.w * m.c0.w,
            v.x * m.c1.x + v.y * m.c1.y + v.z * m.c1.z + v.w * m.c1.w,
            v.x * m.c2.x + v.y * m.c2.y + v.z * m.c2.z + v.w * m.c2.w,
            v.x * m.c3.x + v.y * m.c3.y + v.z * m.c3.z + v.w * m.c3.w);

        public static double4x2 mul(double4x4 a, double4x2 b) => new double4x2(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        public static double4x3 mul(double4x4 a, double4x3 b) => new double4x3(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        public static double4x4 mul(double4x4 a, double4x4 b) => new double4x4(
            a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
            a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
            a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
            a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);

        public static double4x4 transpose(double4x4 m) => new double4x4(
            m.c0.x, m.c0.y, m.c0.z, m.c0.w,
            m.c1.x, m.c1.y, m.c1.z, m.c1.w,
            m.c2.x, m.c2.y, m.c2.z, m.c2.w,
            m.c3.x, m.c3.y, m.c3.z, m.c3.w);

        public static double determinant(double4x4 m)
        {
            double det = m.c0.x * (
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

        public static double4x4 inverse(double4x4 m)
        {
            double det = determinant(m);
            if (det == 0.0) return zero;
            double invDet = 1.0 / det;

            double c00 = (m.c1.y * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) - m.c1.z * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) + m.c1.w * (m.c2.y * m.c3.z - m.c2.z * m.c3.y)) * invDet;
            double c01 = -(m.c0.y * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) - m.c0.z * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) + m.c0.w * (m.c2.y * m.c3.z - m.c2.z * m.c3.y)) * invDet;
            double c02 = (m.c0.y * (m.c1.z * m.c3.w - m.c1.w * m.c3.z) - m.c0.z * (m.c1.y * m.c3.w - m.c1.w * m.c3.y) + m.c0.w * (m.c1.y * m.c3.z - m.c1.z * m.c3.y)) * invDet;
            double c03 = -(m.c0.y * (m.c1.z * m.c2.w - m.c1.w * m.c2.z) - m.c0.z * (m.c1.y * m.c2.w - m.c1.w * m.c2.y) + m.c0.w * (m.c1.y * m.c2.z - m.c1.z * m.c2.y)) * invDet;

            double c10 = -(m.c1.x * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) - m.c1.z * (m.c2.x * m.c3.w - m.c2.w * m.c3.x) + m.c1.w * (m.c2.x * m.c3.z - m.c2.z * m.c3.x)) * invDet;
            double c11 = (m.c0.x * (m.c2.z * m.c3.w - m.c2.w * m.c3.z) - m.c0.z * (m.c2.x * m.c3.w - m.c2.w * m.c3.x) + m.c0.w * (m.c2.x * m.c3.z - m.c2.z * m.c3.x)) * invDet;
            double c12 = -(m.c0.x * (m.c1.z * m.c3.w - m.c1.w * m.c3.z) - m.c0.z * (m.c1.x * m.c3.w - m.c1.w * m.c3.x) + m.c0.w * (m.c1.x * m.c3.z - m.c1.z * m.c3.x)) * invDet;
            double c13 = (m.c0.x * (m.c1.z * m.c2.w - m.c1.w * m.c2.z) - m.c0.z * (m.c1.x * m.c2.w - m.c1.w * m.c2.x) + m.c0.w * (m.c1.x * m.c2.z - m.c1.z * m.c2.x)) * invDet;

            double c20 = (m.c1.x * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) - m.c1.y * (m.c2.x * m.c3.w - m.c2.w * m.c3.x) + m.c1.w * (m.c2.x * m.c3.y - m.c2.y * m.c3.x)) * invDet;
            double c21 = -(m.c0.x * (m.c2.y * m.c3.w - m.c2.w * m.c3.y) - m.c0.y * (m.c2.x * m.c3.w - m.c2.w * m.c3.x) + m.c0.w * (m.c2.x * m.c3.y - m.c2.y * m.c3.x)) * invDet;
            double c22 = (m.c0.x * (m.c1.y * m.c3.w - m.c1.w * m.c3.y) - m.c0.y * (m.c1.x * m.c3.w - m.c1.w * m.c3.x) + m.c0.w * (m.c1.x * m.c3.y - m.c1.y * m.c3.x)) * invDet;
            double c23 = -(m.c0.x * (m.c1.y * m.c2.w - m.c1.w * m.c2.y) - m.c0.y * (m.c1.x * m.c2.w - m.c1.w * m.c2.x) + m.c0.w * (m.c1.x * m.c2.y - m.c1.y * m.c2.x)) * invDet;

            double c30 = -(m.c1.x * (m.c2.y * m.c3.z - m.c2.z * m.c3.y) - m.c1.y * (m.c2.x * m.c3.z - m.c2.z * m.c3.x) + m.c1.z * (m.c2.x * m.c3.y - m.c2.y * m.c3.x)) * invDet;
            double c31 = (m.c0.x * (m.c2.y * m.c3.z - m.c2.z * m.c3.y) - m.c0.y * (m.c2.x * m.c3.z - m.c2.z * m.c3.x) + m.c0.z * (m.c2.x * m.c3.y - m.c2.y * m.c3.x)) * invDet;
            double c32 = -(m.c0.x * (m.c1.y * m.c3.z - m.c1.z * m.c3.y) - m.c0.y * (m.c1.x * m.c3.z - m.c1.z * m.c3.x) + m.c0.z * (m.c1.x * m.c3.y - m.c1.y * m.c3.x)) * invDet;
            double c33 = (m.c0.x * (m.c1.y * m.c2.z - m.c1.z * m.c2.y) - m.c0.y * (m.c1.x * m.c2.z - m.c1.z * m.c2.x) + m.c0.z * (m.c1.x * m.c2.y - m.c1.y * m.c2.x)) * invDet;

            return new double4x4(
                c00, c10, c20, c30,
                c01, c11, c21, c31,
                c02, c12, c22, c32,
                c03, c13, c23, c33);
        }

        public static double4x4 translate(double3 t) => new double4x4(
            1.0, 0.0, 0.0, t.x,
            0.0, 1.0, 0.0, t.y,
            0.0, 0.0, 1.0, t.z,
            0.0, 0.0, 0.0, 1.0);

        public static double4x4 scale(double3 s) => new double4x4(
            s.x, 0.0, 0.0, 0.0,
            0.0, s.y, 0.0, 0.0,
            0.0, 0.0, s.z, 0.0,
            0.0, 0.0, 0.0, 1.0);

        public static double4x4 rotateX(double angle)
        {
            double c = math.cos(angle);
            double s = math.sin(angle);
            return new double4x4(
                1.0, 0.0, 0.0, 0.0,
                0.0, c, -s, 0.0,
                0.0, s, c, 0.0,
                0.0, 0.0, 0.0, 1.0);
        }
        public static double4x4 rotateY(double angle)
        {
            double c = math.cos(angle);
            double s = math.sin(angle);
            return new double4x4(
                c, 0.0, s, 0.0,
                0.0, 1.0, 0.0, 0.0,
                -s, 0.0, c, 0.0,
                0.0, 0.0, 0.0, 1.0);
        }
        public static double4x4 rotateZ(double angle)
        {
            double c = math.cos(angle);
            double s = math.sin(angle);
            return new double4x4(
                c, -s, 0.0, 0.0,
                s, c, 0.0, 0.0,
                0.0, 0.0, 1.0, 0.0,
                0.0, 0.0, 0.0, 1.0);
        }

        public static double4x4 perspectiveFov(double fovY, double aspect, double near, double far)
        {
            double h = 1.0 / math.tan(fovY * 0.5);
            double w = h / aspect;
            double range = far / (near - far);
            return new double4x4(
                w, 0.0, 0.0, 0.0,
                0.0, h, 0.0, 0.0,
                0.0, 0.0, range, -1.0,
                0.0, 0.0, range * near, 0.0);
        }

        public static double4x4 lookAt(double3 eye, double3 target, double3 up)
        {
            double3 zaxis = math.normalize(target - eye);
            double3 xaxis = math.normalize(math.cross(up, zaxis));
            double3 yaxis = math.cross(zaxis, xaxis);
            return new double4x4(
                xaxis.x, yaxis.x, zaxis.x, eye.x,
                xaxis.y, yaxis.y, zaxis.y, eye.y,
                xaxis.z, yaxis.z, zaxis.z, eye.z,
                0.0, 0.0, 0.0, 1.0);
        }

        public readonly double4x4 transpose() => transpose(this);
        public readonly double determinant() => determinant(this);
        public readonly double4x4 inverse() => inverse(this);

        public static bool operator ==(double4x4 a, double4x4 b) => (a.c0 == b.c0).all && (a.c1 == b.c1).all && (a.c2 == b.c2).all && (a.c3 == b.c3).all;
        public static bool operator !=(double4x4 a, double4x4 b) => !(a == b);
        public override readonly bool Equals(object? obj) => obj is double4x4 o && this == o;
        public override readonly int GetHashCode() => HashCode.Combine(c0, c1, c2, c3);

        public override readonly string ToString() =>
            $"double4x4({c0.x}, {c1.x}, {c2.x}, {c3.x},  {c0.y}, {c1.y}, {c2.y}, {c3.y},  {c0.z}, {c1.z}, {c2.z}, {c3.z},  {c0.w}, {c1.w}, {c2.w}, {c3.w})";
    }
}
