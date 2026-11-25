//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
namespace DivisionEngine.MathLib
{
    public partial struct int4
    {
        #region Swizzles_int4

        // Swizzles - int4

        // x
        // xx
        /// <summary>Gets the <c>xxxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxxx => new int4(x, x, x, x);
        /// <summary>Gets the <c>xxxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxxy => new int4(x, x, x, y);
        /// <summary>Gets the <c>xxxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxxz => new int4(x, x, x, z);
        /// <summary>Gets the <c>xxxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxxw => new int4(x, x, x, w);

        /// <summary>Gets the <c>xxyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxyx => new int4(x, x, y, x);
        /// <summary>Gets the <c>xxyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxyy => new int4(x, x, y, y);
        /// <summary>Gets the <c>xxyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxyz => new int4(x, x, y, z);
        /// <summary>Gets the <c>xxyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxyw => new int4(x, x, y, w);

        /// <summary>Gets the <c>xxzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxzx => new int4(x, x, z, x);
        /// <summary>Gets the <c>xxzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxzy => new int4(x, x, z, y);
        /// <summary>Gets the <c>xxzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxzz => new int4(x, x, z, z);
        /// <summary>Gets the <c>xxzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxzw => new int4(x, x, z, w);

        /// <summary>Gets the <c>xxwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxwx => new int4(x, x, w, x);
        /// <summary>Gets the <c>xxwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxwy => new int4(x, x, w, y);
        /// <summary>Gets the <c>xxwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxwz => new int4(x, x, w, z);
        /// <summary>Gets the <c>xxww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xxww => new int4(x, x, w, w);

        // xy
        /// <summary>Gets the <c>xyxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyxx => new int4(x, y, x, x);
        /// <summary>Gets the <c>xyxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyxy => new int4(x, y, x, y);
        /// <summary>Gets the <c>xyxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyxz => new int4(x, y, x, z);
        /// <summary>Gets the <c>xyxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyxw => new int4(x, y, x, w);

        /// <summary>Gets the <c>xyyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyyx => new int4(x, y, y, x);
        /// <summary>Gets the <c>xyyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyyy => new int4(x, y, y, y);
        /// <summary>Gets the <c>xyyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyyz => new int4(x, y, y, z);
        /// <summary>Gets the <c>xyyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyyw => new int4(x, y, y, w);

        /// <summary>Gets the <c>xyzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyzx => new int4(x, y, z, x);
        /// <summary>Gets the <c>xyzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyzy => new int4(x, y, z, y);
        /// <summary>Gets the <c>xyzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyzz => new int4(x, y, z, z);
        /// <summary>Gets the <c>xyzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyzw => new int4(x, y, z, w);

        /// <summary>Gets the <c>xywx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xywx => new int4(x, y, w, x);
        /// <summary>Gets the <c>xywy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xywy => new int4(x, y, w, y);
        /// <summary>Gets the <c>xywz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xywz => new int4(x, y, w, z);
        /// <summary>Gets the <c>xyww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xyww => new int4(x, y, w, w);

        // xz
        /// <summary>Gets the <c>xzxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzxx => new int4(x, z, x, x);
        /// <summary>Gets the <c>xzxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzxy => new int4(x, z, x, y);
        /// <summary>Gets the <c>xzxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzxz => new int4(x, z, x, z);
        /// <summary>Gets the <c>xzxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzxw => new int4(x, z, x, w);

        /// <summary>Gets the <c>xzyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzyx => new int4(x, z, y, x);
        /// <summary>Gets the <c>xzyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzyy => new int4(x, z, y, y);
        /// <summary>Gets the <c>xzyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzyz => new int4(x, z, y, z);
        /// <summary>Gets the <c>xzyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzyw => new int4(x, z, y, w);

        /// <summary>Gets the <c>xzzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzzx => new int4(x, z, z, x);
        /// <summary>Gets the <c>xzzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzzy => new int4(x, z, z, y);
        /// <summary>Gets the <c>xzzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzzz => new int4(x, z, z, z);
        /// <summary>Gets the <c>xzzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzzw => new int4(x, z, z, w);

        /// <summary>Gets the <c>xzwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzwx => new int4(x, z, w, x);
        /// <summary>Gets the <c>xzwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzwy => new int4(x, z, w, y);
        /// <summary>Gets the <c>xzwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzwz => new int4(x, z, w, z);
        /// <summary>Gets the <c>xzww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xzww => new int4(x, z, w, w);

        // xw
        /// <summary>Gets the <c>xwxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwxx => new int4(x, w, x, x);
        /// <summary>Gets the <c>xwxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwxy => new int4(x, w, x, y);
        /// <summary>Gets the <c>xwxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwxz => new int4(x, w, x, z);
        /// <summary>Gets the <c>xwxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwxw => new int4(x, w, x, w);

        /// <summary>Gets the <c>xwyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwyx => new int4(x, w, y, x);
        /// <summary>Gets the <c>xwyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwyy => new int4(x, w, y, y);
        /// <summary>Gets the <c>xwyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwyz => new int4(x, w, y, z);
        /// <summary>Gets the <c>xwyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwyw => new int4(x, w, y, w);

        /// <summary>Gets the <c>xwzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwzx => new int4(x, w, z, x);
        /// <summary>Gets the <c>xwzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwzy => new int4(x, w, z, y);
        /// <summary>Gets the <c>xwzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwzz => new int4(x, w, z, z);
        /// <summary>Gets the <c>xwzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwzw => new int4(x, w, z, w);

        /// <summary>Gets the <c>xwwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwwx => new int4(x, w, w, x);
        /// <summary>Gets the <c>xwwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwwy => new int4(x, w, w, y);
        /// <summary>Gets the <c>xwwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwwz => new int4(x, w, w, z);
        /// <summary>Gets the <c>xwww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 xwww => new int4(x, w, w, w);


        // y
        // yx
        /// <summary>Gets the <c>yxxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxxx => new int4(y, x, x, x);
        /// <summary>Gets the <c>yxxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxxy => new int4(y, x, x, y);
        /// <summary>Gets the <c>yxxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxxz => new int4(y, x, x, z);
        /// <summary>Gets the <c>yxxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxxw => new int4(y, x, x, w);

        /// <summary>Gets the <c>yxyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxyx => new int4(y, x, y, x);
        /// <summary>Gets the <c>yxyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxyy => new int4(y, x, y, y);
        /// <summary>Gets the <c>yxyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxyz => new int4(y, x, y, z);
        /// <summary>Gets the <c>yxyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxyw => new int4(y, x, y, w);

        /// <summary>Gets the <c>yxzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxzx => new int4(y, x, z, x);
        /// <summary>Gets the <c>yxzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxzy => new int4(y, x, z, y);
        /// <summary>Gets the <c>yxzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxzz => new int4(y, x, z, z);
        /// <summary>Gets the <c>yxzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxzw => new int4(y, x, z, w);

        /// <summary>Gets the <c>yxwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxwx => new int4(y, x, w, x);
        /// <summary>Gets the <c>yxwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxwy => new int4(y, x, w, y);
        /// <summary>Gets the <c>yxwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxwz => new int4(y, x, w, z);
        /// <summary>Gets the <c>yxww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yxww => new int4(y, x, w, w);

        // yy
        /// <summary>Gets the <c>yyxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyxx => new int4(y, y, x, x);
        /// <summary>Gets the <c>yyxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyxy => new int4(y, y, x, y);
        /// <summary>Gets the <c>yyxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyxz => new int4(y, y, x, z);
        /// <summary>Gets the <c>yyxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyxw => new int4(y, y, x, w);

        /// <summary>Gets the <c>yyyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyyx => new int4(y, y, y, x);
        /// <summary>Gets the <c>yyyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyyy => new int4(y, y, y, y);
        /// <summary>Gets the <c>yyyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyyz => new int4(y, y, y, z);
        /// <summary>Gets the <c>yyyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyyw => new int4(y, y, y, w);

        /// <summary>Gets the <c>yyzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyzx => new int4(y, y, z, x);
        /// <summary>Gets the <c>yyzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyzy => new int4(y, y, z, y);
        /// <summary>Gets the <c>yyzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyzz => new int4(y, y, z, z);
        /// <summary>Gets the <c>yyzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyzw => new int4(y, y, z, w);

        /// <summary>Gets the <c>yywx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yywx => new int4(y, y, w, x);
        /// <summary>Gets the <c>yywy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yywy => new int4(y, y, w, y);
        /// <summary>Gets the <c>yywz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yywz => new int4(y, y, w, z);
        /// <summary>Gets the <c>yyww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yyww => new int4(y, y, w, w);

        // yz
        /// <summary>Gets the <c>yzxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzxx => new int4(y, z, x, x);
        /// <summary>Gets the <c>yzxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzxy => new int4(y, z, x, y);
        /// <summary>Gets the <c>yzxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzxz => new int4(y, z, x, z);
        /// <summary>Gets the <c>yzxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzxw => new int4(y, z, x, w);

        /// <summary>Gets the <c>yzyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzyx => new int4(y, z, y, x);
        /// <summary>Gets the <c>yzyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzyy => new int4(y, z, y, y);
        /// <summary>Gets the <c>yzyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzyz => new int4(y, z, y, z);
        /// <summary>Gets the <c>yzyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzyw => new int4(y, z, y, w);

        /// <summary>Gets the <c>yzzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzzx => new int4(y, z, z, x);
        /// <summary>Gets the <c>yzzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzzy => new int4(y, z, z, y);
        /// <summary>Gets the <c>yzzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzzz => new int4(y, z, z, z);
        /// <summary>Gets the <c>yzzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzzw => new int4(y, z, z, w);

        /// <summary>Gets the <c>yzwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzwx => new int4(y, z, w, x);
        /// <summary>Gets the <c>yzwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzwy => new int4(y, z, w, y);
        /// <summary>Gets the <c>yzwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzwz => new int4(y, z, w, z);
        /// <summary>Gets the <c>yzww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 yzww => new int4(y, z, w, w);

        // yw
        /// <summary>Gets the <c>ywxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywxx => new int4(y, w, x, x);
        /// <summary>Gets the <c>ywxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywxy => new int4(y, w, x, y);
        /// <summary>Gets the <c>ywxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywxz => new int4(y, w, x, z);
        /// <summary>Gets the <c>ywxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywxw => new int4(y, w, x, w);

        /// <summary>Gets the <c>ywyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywyx => new int4(y, w, y, x);
        /// <summary>Gets the <c>ywyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywyy => new int4(y, w, y, y);
        /// <summary>Gets the <c>ywyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywyz => new int4(y, w, y, z);
        /// <summary>Gets the <c>ywyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywyw => new int4(y, w, y, w);

        /// <summary>Gets the <c>ywzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywzx => new int4(y, w, z, x);
        /// <summary>Gets the <c>ywzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywzy => new int4(y, w, z, y);
        /// <summary>Gets the <c>ywzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywzz => new int4(y, w, z, z);
        /// <summary>Gets the <c>ywzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywzw => new int4(y, w, z, w);

        /// <summary>Gets the <c>ywwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywwx => new int4(y, w, w, x);
        /// <summary>Gets the <c>ywwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywwy => new int4(y, w, w, y);
        /// <summary>Gets the <c>ywwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywwz => new int4(y, w, w, z);
        /// <summary>Gets the <c>ywww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ywww => new int4(y, w, w, w);


        // z
        // zx
        /// <summary>Gets the <c>zxxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxxx => new int4(z, x, x, x);
        /// <summary>Gets the <c>zxxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxxy => new int4(z, x, x, y);
        /// <summary>Gets the <c>zxxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxxz => new int4(z, x, x, z);
        /// <summary>Gets the <c>zxxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxxw => new int4(z, x, x, w);

        /// <summary>Gets the <c>zxyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxyx => new int4(z, x, y, x);
        /// <summary>Gets the <c>zxyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxyy => new int4(z, x, y, y);
        /// <summary>Gets the <c>zxyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxyz => new int4(z, x, y, z);
        /// <summary>Gets the <c>zxyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxyw => new int4(z, x, y, w);

        /// <summary>Gets the <c>zxzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxzx => new int4(z, x, z, x);
        /// <summary>Gets the <c>zxzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxzy => new int4(z, x, z, y);
        /// <summary>Gets the <c>zxzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxzz => new int4(z, x, z, z);
        /// <summary>Gets the <c>zxzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxzw => new int4(z, x, z, w);

        /// <summary>Gets the <c>zxwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxwx => new int4(z, x, w, x);
        /// <summary>Gets the <c>zxwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxwy => new int4(z, x, w, y);
        /// <summary>Gets the <c>zxwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxwz => new int4(z, x, w, z);
        /// <summary>Gets the <c>zxww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zxww => new int4(z, x, w, w);

        // zy
        /// <summary>Gets the <c>zyxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyxx => new int4(z, y, x, x);
        /// <summary>Gets the <c>zyxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyxy => new int4(z, y, x, y);
        /// <summary>Gets the <c>zyxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyxz => new int4(z, y, x, z);
        /// <summary>Gets the <c>zyxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyxw => new int4(z, y, x, w);

        /// <summary>Gets the <c>zyyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyyx => new int4(z, y, y, x);
        /// <summary>Gets the <c>zyyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyyy => new int4(z, y, y, y);
        /// <summary>Gets the <c>zyyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyyz => new int4(z, y, y, z);
        /// <summary>Gets the <c>zyyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyyw => new int4(z, y, y, w);

        /// <summary>Gets the <c>zyzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyzx => new int4(z, y, z, x);
        /// <summary>Gets the <c>zyzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyzy => new int4(z, y, z, y);
        /// <summary>Gets the <c>zyzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyzz => new int4(z, y, z, z);
        /// <summary>Gets the <c>zyzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyzw => new int4(z, y, z, w);

        /// <summary>Gets the <c>zywx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zywx => new int4(z, y, w, x);
        /// <summary>Gets the <c>zywy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zywy => new int4(z, y, w, y);
        /// <summary>Gets the <c>zywz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zywz => new int4(z, y, w, z);
        /// <summary>Gets the <c>zyww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zyww => new int4(z, y, w, w);

        // zz
        /// <summary>Gets the <c>zzxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzxx => new int4(z, z, x, x);
        /// <summary>Gets the <c>zzxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzxy => new int4(z, z, x, y);
        /// <summary>Gets the <c>zzxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzxz => new int4(z, z, x, z);
        /// <summary>Gets the <c>zzxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzxw => new int4(z, z, x, w);

        /// <summary>Gets the <c>zzyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzyx => new int4(z, z, y, x);
        /// <summary>Gets the <c>zzyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzyy => new int4(z, z, y, y);
        /// <summary>Gets the <c>zzyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzyz => new int4(z, z, y, z);
        /// <summary>Gets the <c>zzyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzyw => new int4(z, z, y, w);

        /// <summary>Gets the <c>zzzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzzx => new int4(z, z, z, x);
        /// <summary>Gets the <c>zzzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzzy => new int4(z, z, z, y);
        /// <summary>Gets the <c>zzzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzzz => new int4(z, z, z, z);
        /// <summary>Gets the <c>zzzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzzw => new int4(z, z, z, w);

        /// <summary>Gets the <c>zzwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzwx => new int4(z, z, w, x);
        /// <summary>Gets the <c>zzwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzwy => new int4(z, z, w, y);
        /// <summary>Gets the <c>zzwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzwz => new int4(z, z, w, z);
        /// <summary>Gets the <c>zzww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zzww => new int4(z, z, w, w);

        // zw
        /// <summary>Gets the <c>zwxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwxx => new int4(z, w, x, x);
        /// <summary>Gets the <c>zwxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwxy => new int4(z, w, x, y);
        /// <summary>Gets the <c>zwxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwxz => new int4(z, w, x, z);
        /// <summary>Gets the <c>zwxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwxw => new int4(z, w, x, w);

        /// <summary>Gets the <c>zwyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwyx => new int4(z, w, y, x);
        /// <summary>Gets the <c>zwyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwyy => new int4(z, w, y, y);
        /// <summary>Gets the <c>zwyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwyz => new int4(z, w, y, z);
        /// <summary>Gets the <c>zwyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwyw => new int4(z, w, y, w);

        /// <summary>Gets the <c>zwzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwzx => new int4(z, w, z, x);
        /// <summary>Gets the <c>zwzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwzy => new int4(z, w, z, y);
        /// <summary>Gets the <c>zwzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwzz => new int4(z, w, z, z);
        /// <summary>Gets the <c>zwzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwzw => new int4(z, w, z, w);

        /// <summary>Gets the <c>zwwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwwx => new int4(z, w, w, x);
        /// <summary>Gets the <c>zwwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwwy => new int4(z, w, w, y);
        /// <summary>Gets the <c>zwwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwwz => new int4(z, w, w, z);
        /// <summary>Gets the <c>zwww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 zwww => new int4(z, w, w, w);


        // w
        // wx
        /// <summary>Gets the <c>wxxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxxx => new int4(w, x, x, x);
        /// <summary>Gets the <c>wxxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxxy => new int4(w, x, x, y);
        /// <summary>Gets the <c>wxxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxxz => new int4(w, x, x, z);
        /// <summary>Gets the <c>wxxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxxw => new int4(w, x, x, w);

        /// <summary>Gets the <c>wxyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxyx => new int4(w, x, y, x);
        /// <summary>Gets the <c>wxyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxyy => new int4(w, x, y, y);
        /// <summary>Gets the <c>wxyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxyz => new int4(w, x, y, z);
        /// <summary>Gets the <c>wxyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxyw => new int4(w, x, y, w);

        /// <summary>Gets the <c>wxzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxzx => new int4(w, x, z, x);
        /// <summary>Gets the <c>wxzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxzy => new int4(w, x, z, y);
        /// <summary>Gets the <c>wxzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxzz => new int4(w, x, z, z);
        /// <summary>Gets the <c>wxzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxzw => new int4(w, x, z, w);

        /// <summary>Gets the <c>wxwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxwx => new int4(w, x, w, x);
        /// <summary>Gets the <c>wxwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxwy => new int4(w, x, w, y);
        /// <summary>Gets the <c>wxwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxwz => new int4(w, x, w, z);
        /// <summary>Gets the <c>wxww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wxww => new int4(w, x, w, w);

        // wy
        /// <summary>Gets the <c>wyxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyxx => new int4(w, y, x, x);
        /// <summary>Gets the <c>wyxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyxy => new int4(w, y, x, y);
        /// <summary>Gets the <c>wyxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyxz => new int4(w, y, x, z);
        /// <summary>Gets the <c>wyxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyxw => new int4(w, y, x, w);

        /// <summary>Gets the <c>wyyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyyx => new int4(w, y, y, x);
        /// <summary>Gets the <c>wyyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyyy => new int4(w, y, y, y);
        /// <summary>Gets the <c>wyyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyyz => new int4(w, y, y, z);
        /// <summary>Gets the <c>wyyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyyw => new int4(w, y, y, w);

        /// <summary>Gets the <c>wyzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyzx => new int4(w, y, z, x);
        /// <summary>Gets the <c>wyzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyzy => new int4(w, y, z, y);
        /// <summary>Gets the <c>wyzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyzz => new int4(w, y, z, z);
        /// <summary>Gets the <c>wyzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyzw => new int4(w, y, z, w);

        /// <summary>Gets the <c>wywx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wywx => new int4(w, y, w, x);
        /// <summary>Gets the <c>wywy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wywy => new int4(w, y, w, y);
        /// <summary>Gets the <c>wywz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wywz => new int4(w, y, w, z);
        /// <summary>Gets the <c>wyww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wyww => new int4(w, y, w, w);

        // wz
        /// <summary>Gets the <c>wzxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzxx => new int4(w, z, x, x);
        /// <summary>Gets the <c>wzxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzxy => new int4(w, z, x, y);
        /// <summary>Gets the <c>wzxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzxz => new int4(w, z, x, z);
        /// <summary>Gets the <c>wzxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzxw => new int4(w, z, x, w);

        /// <summary>Gets the <c>wzyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzyx => new int4(w, z, y, x);
        /// <summary>Gets the <c>wzyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzyy => new int4(w, z, y, y);
        /// <summary>Gets the <c>wzyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzyz => new int4(w, z, y, z);
        /// <summary>Gets the <c>wzyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzyw => new int4(w, z, y, w);

        /// <summary>Gets the <c>wzzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzzx => new int4(w, z, z, x);
        /// <summary>Gets the <c>wzzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzzy => new int4(w, z, z, y);
        /// <summary>Gets the <c>wzzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzzz => new int4(w, z, z, z);
        /// <summary>Gets the <c>wzzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzzw => new int4(w, z, z, w);

        /// <summary>Gets the <c>wzwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzwx => new int4(w, z, w, x);
        /// <summary>Gets the <c>wzwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzwy => new int4(w, z, w, y);
        /// <summary>Gets the <c>wzwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzwz => new int4(w, z, w, z);
        /// <summary>Gets the <c>wzww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wzww => new int4(w, z, w, w);

        // ww
        /// <summary>Gets the <c>wwxx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwxx => new int4(w, w, x, x);
        /// <summary>Gets the <c>wwxy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwxy => new int4(w, w, x, y);
        /// <summary>Gets the <c>wwxz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwxz => new int4(w, w, x, z);
        /// <summary>Gets the <c>wwxw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwxw => new int4(w, w, x, w);

        /// <summary>Gets the <c>wwyx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwyx => new int4(w, w, y, x);
        /// <summary>Gets the <c>wwyy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwyy => new int4(w, w, y, y);
        /// <summary>Gets the <c>wwyz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwyz => new int4(w, w, y, z);
        /// <summary>Gets the <c>wwyw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwyw => new int4(w, w, y, w);

        /// <summary>Gets the <c>wwzx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwzx => new int4(w, w, z, x);
        /// <summary>Gets the <c>wwzy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwzy => new int4(w, w, z, y);
        /// <summary>Gets the <c>wwzz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwzz => new int4(w, w, z, z);
        /// <summary>Gets the <c>wwzw</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwzw => new int4(w, w, z, w);

        /// <summary>Gets the <c>wwwx</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwwx => new int4(w, w, w, x);
        /// <summary>Gets the <c>wwwy</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwwy => new int4(w, w, w, y);
        /// <summary>Gets the <c>wwwz</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwwz => new int4(w, w, w, z);
        /// <summary>Gets the <c>wwww</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 wwww => new int4(w, w, w, w);

        #endregion Swizzles_int4
        #region Swizzles_int4_RGBA

        // RGBA - Swizzles - int4

        // r
        // rr
        /// <summary>Gets the <c>rrrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrrr => new int4(r, r, r, r);
        /// <summary>Gets the <c>rrrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrrg => new int4(r, r, r, g);
        /// <summary>Gets the <c>rrrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrrb => new int4(r, r, r, b);
        /// <summary>Gets the <c>rrra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrra => new int4(r, r, r, a);

        /// <summary>Gets the <c>rrgr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrgr => new int4(r, r, g, r);
        /// <summary>Gets the <c>rrgg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrgg => new int4(r, r, g, g);
        /// <summary>Gets the <c>rrgb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrgb => new int4(r, r, g, b);
        /// <summary>Gets the <c>rrga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrga => new int4(r, r, g, a);

        /// <summary>Gets the <c>rrbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrbr => new int4(r, r, b, r);
        /// <summary>Gets the <c>rrbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrbg => new int4(r, r, b, g);
        /// <summary>Gets the <c>rrbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrbb => new int4(r, r, b, b);
        /// <summary>Gets the <c>rrba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrba => new int4(r, r, b, a);

        /// <summary>Gets the <c>rrar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrar => new int4(r, r, a, r);
        /// <summary>Gets the <c>rrag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrag => new int4(r, r, a, g);
        /// <summary>Gets the <c>rrab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rrab => new int4(r, r, a, b);
        /// <summary>Gets the <c>rraa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rraa => new int4(r, r, a, a);

        // rg
        /// <summary>Gets the <c>rgrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgrr => new int4(r, g, r, r);
        /// <summary>Gets the <c>rgrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgrg => new int4(r, g, r, g);
        /// <summary>Gets the <c>rgrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgrb => new int4(r, g, r, b);
        /// <summary>Gets the <c>rgra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgra => new int4(r, g, r, a);

        /// <summary>Gets the <c>rggr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rggr => new int4(r, g, g, r);
        /// <summary>Gets the <c>rggg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rggg => new int4(r, g, g, g);
        /// <summary>Gets the <c>rggb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rggb => new int4(r, g, g, b);
        /// <summary>Gets the <c>rgga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgga => new int4(r, g, g, a);

        /// <summary>Gets the <c>rgbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgbr => new int4(r, g, b, r);
        /// <summary>Gets the <c>rgbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgbg => new int4(r, g, b, g);
        /// <summary>Gets the <c>rgbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgbb => new int4(r, g, b, b);
        /// <summary>Gets the <c>rgba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgba => new int4(r, g, b, a);

        /// <summary>Gets the <c>rgar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgar => new int4(r, g, a, r);
        /// <summary>Gets the <c>rgag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgag => new int4(r, g, a, g);
        /// <summary>Gets the <c>rgab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgab => new int4(r, g, a, b);
        /// <summary>Gets the <c>rgaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rgaa => new int4(r, g, a, a);

        // rb
        /// <summary>Gets the <c>rbrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbrr => new int4(r, b, r, r);
        /// <summary>Gets the <c>rbrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbrg => new int4(r, b, r, g);
        /// <summary>Gets the <c>rbrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbrb => new int4(r, b, r, b);
        /// <summary>Gets the <c>rbra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbra => new int4(r, b, r, a);

        /// <summary>Gets the <c>rbgr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbgr => new int4(r, b, g, r);
        /// <summary>Gets the <c>rbgg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbgg => new int4(r, b, g, g);
        /// <summary>Gets the <c>rbgb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbgb => new int4(r, b, g, b);
        /// <summary>Gets the <c>rbga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbga => new int4(r, b, g, a);

        /// <summary>Gets the <c>rbbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbbr => new int4(r, b, b, r);
        /// <summary>Gets the <c>rbbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbbg => new int4(r, b, b, g);
        /// <summary>Gets the <c>rbbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbbb => new int4(r, b, b, b);
        /// <summary>Gets the <c>rbba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbba => new int4(r, b, b, a);

        /// <summary>Gets the <c>rbar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbar => new int4(r, b, a, r);
        /// <summary>Gets the <c>rbag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbag => new int4(r, b, a, g);
        /// <summary>Gets the <c>rbab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbab => new int4(r, b, a, b);
        /// <summary>Gets the <c>rbaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rbaa => new int4(r, b, a, a);

        // ra
        /// <summary>Gets the <c>rarr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rarr => new int4(r, a, r, r);
        /// <summary>Gets the <c>rarg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rarg => new int4(r, a, r, g);
        /// <summary>Gets the <c>rarb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rarb => new int4(r, a, r, b);
        /// <summary>Gets the <c>rara</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rara => new int4(r, a, r, a);

        /// <summary>Gets the <c>ragr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ragr => new int4(r, a, g, r);
        /// <summary>Gets the <c>ragg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ragg => new int4(r, a, g, g);
        /// <summary>Gets the <c>ragb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ragb => new int4(r, a, g, b);
        /// <summary>Gets the <c>raga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 raga => new int4(r, a, g, a);

        /// <summary>Gets the <c>rabr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rabr => new int4(r, a, b, r);
        /// <summary>Gets the <c>rabg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rabg => new int4(r, a, b, g);
        /// <summary>Gets the <c>rabb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 rabb => new int4(r, a, b, b);
        /// <summary>Gets the <c>raba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 raba => new int4(r, a, b, a);

        /// <summary>Gets the <c>raar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 raar => new int4(r, a, a, r);
        /// <summary>Gets the <c>raag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 raag => new int4(r, a, a, g);
        /// <summary>Gets the <c>raab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 raab => new int4(r, a, a, b);
        /// <summary>Gets the <c>raaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 raaa => new int4(r, a, a, a);


        // g
        // gr
        /// <summary>Gets the <c>grrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grrr => new int4(g, r, r, r);
        /// <summary>Gets the <c>grrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grrg => new int4(g, r, r, g);
        /// <summary>Gets the <c>grrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grrb => new int4(g, r, r, b);
        /// <summary>Gets the <c>grra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grra => new int4(g, r, r, a);

        /// <summary>Gets the <c>grgr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grgr => new int4(g, r, g, r);
        /// <summary>Gets the <c>grgg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grgg => new int4(g, r, g, g);
        /// <summary>Gets the <c>grgb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grgb => new int4(g, r, g, b);
        /// <summary>Gets the <c>grga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grga => new int4(g, r, g, a);

        /// <summary>Gets the <c>grbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grbr => new int4(g, r, b, r);
        /// <summary>Gets the <c>grbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grbg => new int4(g, r, b, g);
        /// <summary>Gets the <c>grbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grbb => new int4(g, r, b, b);
        /// <summary>Gets the <c>grba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grba => new int4(g, r, b, a);

        /// <summary>Gets the <c>grar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grar => new int4(g, r, a, r);
        /// <summary>Gets the <c>grag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grag => new int4(g, r, a, g);
        /// <summary>Gets the <c>grab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 grab => new int4(g, r, a, b);
        /// <summary>Gets the <c>graa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 graa => new int4(g, r, a, a);

        // gg
        /// <summary>Gets the <c>ggrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggrr => new int4(g, g, r, r);
        /// <summary>Gets the <c>ggrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggrg => new int4(g, g, r, g);
        /// <summary>Gets the <c>ggrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggrb => new int4(g, g, r, b);
        /// <summary>Gets the <c>ggra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggra => new int4(g, g, r, a);

        /// <summary>Gets the <c>gggr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gggr => new int4(g, g, g, r);
        /// <summary>Gets the <c>gggg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gggg => new int4(g, g, g, g);
        /// <summary>Gets the <c>gggb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gggb => new int4(g, g, g, b);
        /// <summary>Gets the <c>ggga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggga => new int4(g, g, g, a);

        /// <summary>Gets the <c>ggbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggbr => new int4(g, g, b, r);
        /// <summary>Gets the <c>ggbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggbg => new int4(g, g, b, g);
        /// <summary>Gets the <c>ggbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggbb => new int4(g, g, b, b);
        /// <summary>Gets the <c>ggba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggba => new int4(g, g, b, a);

        /// <summary>Gets the <c>ggar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggar => new int4(g, g, a, r);
        /// <summary>Gets the <c>ggag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggag => new int4(g, g, a, g);
        /// <summary>Gets the <c>ggab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggab => new int4(g, g, a, b);
        /// <summary>Gets the <c>ggaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 ggaa => new int4(g, g, a, a);

        // gb
        /// <summary>Gets the <c>gbrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbrr => new int4(g, b, r, r);
        /// <summary>Gets the <c>gbrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbrg => new int4(g, b, r, g);
        /// <summary>Gets the <c>gbrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbrb => new int4(g, b, r, b);
        /// <summary>Gets the <c>gbra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbra => new int4(g, b, r, a);

        /// <summary>Gets the <c>gbgr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbgr => new int4(g, b, g, r);
        /// <summary>Gets the <c>gbgg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbgg => new int4(g, b, g, g);
        /// <summary>Gets the <c>gbgb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbgb => new int4(g, b, g, b);
        /// <summary>Gets the <c>gbga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbga => new int4(g, b, g, a);

        /// <summary>Gets the <c>gbbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbbr => new int4(g, b, b, r);
        /// <summary>Gets the <c>gbbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbbg => new int4(g, b, b, g);
        /// <summary>Gets the <c>gbbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbbb => new int4(g, b, b, b);
        /// <summary>Gets the <c>gbba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbba => new int4(g, b, b, a);

        /// <summary>Gets the <c>gbar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbar => new int4(g, b, a, r);
        /// <summary>Gets the <c>gbag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbag => new int4(g, b, a, g);
        /// <summary>Gets the <c>gbab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbab => new int4(g, b, a, b);
        /// <summary>Gets the <c>gbaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gbaa => new int4(g, b, a, a);

        // ga
        /// <summary>Gets the <c>garr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 garr => new int4(g, a, r, r);
        /// <summary>Gets the <c>garg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 garg => new int4(g, a, r, g);
        /// <summary>Gets the <c>garb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 garb => new int4(g, a, r, b);
        /// <summary>Gets the <c>gara</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gara => new int4(g, a, r, a);

        /// <summary>Gets the <c>gagr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gagr => new int4(g, a, g, r);
        /// <summary>Gets the <c>gagg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gagg => new int4(g, a, g, g);
        /// <summary>Gets the <c>gagb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gagb => new int4(g, a, g, b);
        /// <summary>Gets the <c>gaga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gaga => new int4(g, a, g, a);

        /// <summary>Gets the <c>gabr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gabr => new int4(g, a, b, r);
        /// <summary>Gets the <c>gabg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gabg => new int4(g, a, b, g);
        /// <summary>Gets the <c>gabb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gabb => new int4(g, a, b, b);
        /// <summary>Gets the <c>gaba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gaba => new int4(g, a, b, a);

        /// <summary>Gets the <c>gaar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gaar => new int4(g, a, a, r);
        /// <summary>Gets the <c>gaag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gaag => new int4(g, a, a, g);
        /// <summary>Gets the <c>gaab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gaab => new int4(g, a, a, b);
        /// <summary>Gets the <c>gaaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 gaaa => new int4(g, a, a, a);


        // b
        // br
        /// <summary>Gets the <c>brrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brrr => new int4(b, r, r, r);
        /// <summary>Gets the <c>brrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brrg => new int4(b, r, r, g);
        /// <summary>Gets the <c>brrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brrb => new int4(b, r, r, b);
        /// <summary>Gets the <c>brra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brra => new int4(b, r, r, a);

        /// <summary>Gets the <c>brgr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brgr => new int4(b, r, g, r);
        /// <summary>Gets the <c>brgg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brgg => new int4(b, r, g, g);
        /// <summary>Gets the <c>brgb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brgb => new int4(b, r, g, b);
        /// <summary>Gets the <c>brga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brga => new int4(b, r, g, a);

        /// <summary>Gets the <c>brbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brbr => new int4(b, r, b, r);
        /// <summary>Gets the <c>brbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brbg => new int4(b, r, b, g);
        /// <summary>Gets the <c>brbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brbb => new int4(b, r, b, b);
        /// <summary>Gets the <c>brba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brba => new int4(b, r, b, a);

        /// <summary>Gets the <c>brar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brar => new int4(b, r, a, r);
        /// <summary>Gets the <c>brag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brag => new int4(b, r, a, g);
        /// <summary>Gets the <c>brab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 brab => new int4(b, r, a, b);
        /// <summary>Gets the <c>braa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 braa => new int4(b, r, a, a);

        // bg
        /// <summary>Gets the <c>bgrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgrr => new int4(b, g, r, r);
        /// <summary>Gets the <c>bgrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgrg => new int4(b, g, r, g);
        /// <summary>Gets the <c>bgrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgrb => new int4(b, g, r, b);
        /// <summary>Gets the <c>bgra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgra => new int4(b, g, r, a);

        /// <summary>Gets the <c>bggr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bggr => new int4(b, g, g, r);
        /// <summary>Gets the <c>bggg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bggg => new int4(b, g, g, g);
        /// <summary>Gets the <c>bggb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bggb => new int4(b, g, g, b);
        /// <summary>Gets the <c>bgga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgga => new int4(b, g, g, a);

        /// <summary>Gets the <c>bgbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgbr => new int4(b, g, b, r);
        /// <summary>Gets the <c>bgbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgbg => new int4(b, g, b, g);
        /// <summary>Gets the <c>bgbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgbb => new int4(b, g, b, b);
        /// <summary>Gets the <c>bgba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgba => new int4(b, g, b, a);

        /// <summary>Gets the <c>bgar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgar => new int4(b, g, a, r);
        /// <summary>Gets the <c>bgag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgag => new int4(b, g, a, g);
        /// <summary>Gets the <c>bgab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgab => new int4(b, g, a, b);
        /// <summary>Gets the <c>bgaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bgaa => new int4(b, g, a, a);

        // bb
        /// <summary>Gets the <c>bbrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbrr => new int4(b, b, r, r);
        /// <summary>Gets the <c>bbrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbrg => new int4(b, b, r, g);
        /// <summary>Gets the <c>bbrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbrb => new int4(b, b, r, b);
        /// <summary>Gets the <c>bbra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbra => new int4(b, b, r, a);

        /// <summary>Gets the <c>bbgr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbgr => new int4(b, b, g, r);
        /// <summary>Gets the <c>bbgg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbgg => new int4(b, b, g, g);
        /// <summary>Gets the <c>bbgb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbgb => new int4(b, b, g, b);
        /// <summary>Gets the <c>bbga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbga => new int4(b, b, g, a);

        /// <summary>Gets the <c>bbbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbbr => new int4(b, b, b, r);
        /// <summary>Gets the <c>bbbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbbg => new int4(b, b, b, g);
        /// <summary>Gets the <c>bbbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbbb => new int4(b, b, b, b);
        /// <summary>Gets the <c>bbba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbba => new int4(b, b, b, a);

        /// <summary>Gets the <c>bbar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbar => new int4(b, b, a, r);
        /// <summary>Gets the <c>bbag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbag => new int4(b, b, a, g);
        /// <summary>Gets the <c>bbab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbab => new int4(b, b, a, b);
        /// <summary>Gets the <c>bbaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bbaa => new int4(b, b, a, a);

        // ba
        /// <summary>Gets the <c>barr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 barr => new int4(b, a, r, r);
        /// <summary>Gets the <c>barg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 barg => new int4(b, a, r, g);
        /// <summary>Gets the <c>barb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 barb => new int4(b, a, r, b);
        /// <summary>Gets the <c>bara</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bara => new int4(b, a, r, a);

        /// <summary>Gets the <c>bagr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bagr => new int4(b, a, g, r);
        /// <summary>Gets the <c>bagg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bagg => new int4(b, a, g, g);
        /// <summary>Gets the <c>bagb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 bagb => new int4(b, a, g, b);
        /// <summary>Gets the <c>baga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 baga => new int4(b, a, g, a);

        /// <summary>Gets the <c>babr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 babr => new int4(b, a, b, r);
        /// <summary>Gets the <c>babg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 babg => new int4(b, a, b, g);
        /// <summary>Gets the <c>babb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 babb => new int4(b, a, b, b);
        /// <summary>Gets the <c>baba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 baba => new int4(b, a, b, a);

        /// <summary>Gets the <c>baar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 baar => new int4(b, a, a, r);
        /// <summary>Gets the <c>baag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 baag => new int4(b, a, a, g);
        /// <summary>Gets the <c>baab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 baab => new int4(b, a, a, b);
        /// <summary>Gets the <c>baaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 baaa => new int4(b, a, a, a);


        // a
        // ar
        /// <summary>Gets the <c>arrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arrr => new int4(a, r, r, r);
        /// <summary>Gets the <c>arrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arrg => new int4(a, r, r, g);
        /// <summary>Gets the <c>arrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arrb => new int4(a, r, r, b);
        /// <summary>Gets the <c>arra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arra => new int4(a, r, r, a);

        /// <summary>Gets the <c>argr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 argr => new int4(a, r, g, r);
        /// <summary>Gets the <c>argg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 argg => new int4(a, r, g, g);
        /// <summary>Gets the <c>argb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 argb => new int4(a, r, g, b);
        /// <summary>Gets the <c>arga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arga => new int4(a, r, g, a);

        /// <summary>Gets the <c>arbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arbr => new int4(a, r, b, r);
        /// <summary>Gets the <c>arbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arbg => new int4(a, r, b, g);
        /// <summary>Gets the <c>arbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arbb => new int4(a, r, b, b);
        /// <summary>Gets the <c>arba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arba => new int4(a, r, b, a);

        /// <summary>Gets the <c>arar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arar => new int4(a, r, a, r);
        /// <summary>Gets the <c>arag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arag => new int4(a, r, a, g);
        /// <summary>Gets the <c>arab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 arab => new int4(a, r, a, b);
        /// <summary>Gets the <c>araa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 araa => new int4(a, r, a, a);

        // ag
        /// <summary>Gets the <c>agrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agrr => new int4(a, g, r, r);
        /// <summary>Gets the <c>agrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agrg => new int4(a, g, r, g);
        /// <summary>Gets the <c>agrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agrb => new int4(a, g, r, b);
        /// <summary>Gets the <c>agra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agra => new int4(a, g, r, a);

        /// <summary>Gets the <c>aggr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aggr => new int4(a, g, g, r);
        /// <summary>Gets the <c>aggg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aggg => new int4(a, g, g, g);
        /// <summary>Gets the <c>aggb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aggb => new int4(a, g, g, b);
        /// <summary>Gets the <c>agga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agga => new int4(a, g, g, a);

        /// <summary>Gets the <c>agbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agbr => new int4(a, g, b, r);
        /// <summary>Gets the <c>agbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agbg => new int4(a, g, b, g);
        /// <summary>Gets the <c>agbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agbb => new int4(a, g, b, b);
        /// <summary>Gets the <c>agba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agba => new int4(a, g, b, a);

        /// <summary>Gets the <c>agar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agar => new int4(a, g, a, r);
        /// <summary>Gets the <c>agag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agag => new int4(a, g, a, g);
        /// <summary>Gets the <c>agab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agab => new int4(a, g, a, b);
        /// <summary>Gets the <c>agaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 agaa => new int4(a, g, a, a);

        // ab
        /// <summary>Gets the <c>abrr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abrr => new int4(a, b, r, r);
        /// <summary>Gets the <c>abrg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abrg => new int4(a, b, r, g);
        /// <summary>Gets the <c>abrb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abrb => new int4(a, b, r, b);
        /// <summary>Gets the <c>abra</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abra => new int4(a, b, r, a);

        /// <summary>Gets the <c>abgr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abgr => new int4(a, b, g, r);
        /// <summary>Gets the <c>abgg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abgg => new int4(a, b, g, g);
        /// <summary>Gets the <c>abgb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abgb => new int4(a, b, g, b);
        /// <summary>Gets the <c>abga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abga => new int4(a, b, g, a);

        /// <summary>Gets the <c>abbr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abbr => new int4(a, b, b, r);
        /// <summary>Gets the <c>abbg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abbg => new int4(a, b, b, g);
        /// <summary>Gets the <c>abbb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abbb => new int4(a, b, b, b);
        /// <summary>Gets the <c>abba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abba => new int4(a, b, b, a);

        /// <summary>Gets the <c>abar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abar => new int4(a, b, a, r);
        /// <summary>Gets the <c>abag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abag => new int4(a, b, a, g);
        /// <summary>Gets the <c>abab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abab => new int4(a, b, a, b);
        /// <summary>Gets the <c>abaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 abaa => new int4(a, b, a, a);

        // aa
        /// <summary>Gets the <c>aarr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aarr => new int4(a, a, r, r);
        /// <summary>Gets the <c>aarg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aarg => new int4(a, a, r, g);
        /// <summary>Gets the <c>aarb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aarb => new int4(a, a, r, b);
        /// <summary>Gets the <c>aara</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aara => new int4(a, a, r, a);

        /// <summary>Gets the <c>aagr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aagr => new int4(a, a, g, r);
        /// <summary>Gets the <c>aagg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aagg => new int4(a, a, g, g);
        /// <summary>Gets the <c>aagb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aagb => new int4(a, a, g, b);
        /// <summary>Gets the <c>aaga</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aaga => new int4(a, a, g, a);

        /// <summary>Gets the <c>aabr</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aabr => new int4(a, a, b, r);
        /// <summary>Gets the <c>aabg</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aabg => new int4(a, a, b, g);
        /// <summary>Gets the <c>aabb</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aabb => new int4(a, a, b, b);
        /// <summary>Gets the <c>aaba</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aaba => new int4(a, a, b, a);

        /// <summary>Gets the <c>aaar</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aaar => new int4(a, a, a, r);
        /// <summary>Gets the <c>aaag</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aaag => new int4(a, a, a, g);
        /// <summary>Gets the <c>aaab</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aaab => new int4(a, a, a, b);
        /// <summary>Gets the <c>aaaa</c> swizzle of the vector as an <see cref="int4"/>.</summary>
        public readonly int4 aaaa => new int4(a, a, a, a);

        #endregion Swizzles_int4_RGBA
        #region Swizzles_Extra

        // Swizzles - int3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xxx => new int3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xxy => new int3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xxz => new int3(x, x, z);
        /// <summary>Gets the <c>xxw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xxw => new int3(x, x, w);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xyx => new int3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xyy => new int3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xyz => new int3(x, y, z);
        /// <summary>Gets the <c>xyw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xyw => new int3(x, y, w);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xzx => new int3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xzy => new int3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xzz => new int3(x, z, z);
        /// <summary>Gets the <c>xzw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xzw => new int3(x, z, w);

        /// <summary>Gets the <c>xwx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xwx => new int3(x, w, x);
        /// <summary>Gets the <c>xwy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xwy => new int3(x, w, y);
        /// <summary>Gets the <c>xwz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xwz => new int3(x, w, z);
        /// <summary>Gets the <c>xww</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 xww => new int3(x, w, w);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yxx => new int3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yxy => new int3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yxz => new int3(y, x, z);
        /// <summary>Gets the <c>yxw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yxw => new int3(y, x, w);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yyx => new int3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yyy => new int3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yyz => new int3(y, y, z);
        /// <summary>Gets the <c>yyw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yyw => new int3(y, y, w);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yzx => new int3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yzy => new int3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yzz => new int3(y, z, z);
        /// <summary>Gets the <c>yzw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yzw => new int3(y, z, w);

        /// <summary>Gets the <c>ywx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ywx => new int3(y, w, x);
        /// <summary>Gets the <c>ywy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ywy => new int3(y, w, y);
        /// <summary>Gets the <c>ywz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ywz => new int3(y, w, z);
        /// <summary>Gets the <c>yww</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 yww => new int3(y, w, w);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zxx => new int3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zxy => new int3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zxz => new int3(z, x, z);
        /// <summary>Gets the <c>zxw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zxw => new int3(z, x, w);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zyx => new int3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zyy => new int3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zyz => new int3(z, y, z);
        /// <summary>Gets the <c>zyw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zyw => new int3(z, y, w);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zzx => new int3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zzy => new int3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zzz => new int3(z, z, z);
        /// <summary>Gets the <c>zzw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zzw => new int3(z, z, w);

        /// <summary>Gets the <c>zwx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zwx => new int3(z, w, x);
        /// <summary>Gets the <c>zwy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zwy => new int3(z, w, y);
        /// <summary>Gets the <c>zwz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zwz => new int3(z, w, z);
        /// <summary>Gets the <c>zww</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 zww => new int3(z, w, w);

        // w
        /// <summary>Gets the <c>wxx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wxx => new int3(w, x, x);
        /// <summary>Gets the <c>wxy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wxy => new int3(w, x, y);
        /// <summary>Gets the <c>wxz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wxz => new int3(w, x, z);
        /// <summary>Gets the <c>wxw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wxw => new int3(w, x, w);

        /// <summary>Gets the <c>wyx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wyx => new int3(w, y, x);
        /// <summary>Gets the <c>wyy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wyy => new int3(w, y, y);
        /// <summary>Gets the <c>wyz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wyz => new int3(w, y, z);
        /// <summary>Gets the <c>wyw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wyw => new int3(w, y, w);

        /// <summary>Gets the <c>wzx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wzx => new int3(w, z, x);
        /// <summary>Gets the <c>wzy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wzy => new int3(w, z, y);
        /// <summary>Gets the <c>wzz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wzz => new int3(w, z, z);
        /// <summary>Gets the <c>wzw</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wzw => new int3(w, z, w);

        /// <summary>Gets the <c>wwx</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wwx => new int3(w, w, x);
        /// <summary>Gets the <c>wwy</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wwy => new int3(w, w, y);
        /// <summary>Gets the <c>wwz</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 wwz => new int3(w, w, z);
        /// <summary>Gets the <c>www</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 www => new int3(w, w, w);

        // Swizzles - int2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xx => new int2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xy => new int2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xz => new int2(x, z);
        /// <summary>Gets the <c>xw</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 xw => new int2(x, w);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yx => new int2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yy => new int2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yz => new int2(y, z);
        /// <summary>Gets the <c>yw</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 yw => new int2(y, w);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 zx => new int2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 zy => new int2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 zz => new int2(z, z);
        /// <summary>Gets the <c>zw</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 zw => new int2(z, w);

        /// <summary>Gets the <c>wx</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 wx => new int2(w, x);
        /// <summary>Gets the <c>wy</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 wy => new int2(w, y);
        /// <summary>Gets the <c>wz</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 wz => new int2(w, z);
        /// <summary>Gets the <c>ww</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 ww => new int2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - int3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rrr => new int3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rrg => new int3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rrb => new int3(r, r, b);
        /// <summary>Gets the <c>rra</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rra => new int3(r, r, a);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rgr => new int3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rgg => new int3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rgb => new int3(r, g, b);
        /// <summary>Gets the <c>rga</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rga => new int3(r, g, a);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rbr => new int3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rbg => new int3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rbb => new int3(r, b, b);
        /// <summary>Gets the <c>rba</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rba => new int3(r, b, a);

        /// <summary>Gets the <c>rar</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rar => new int3(r, a, r);
        /// <summary>Gets the <c>rag</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rag => new int3(r, a, g);
        /// <summary>Gets the <c>rab</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 rab => new int3(r, a, b);
        /// <summary>Gets the <c>raa</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 raa => new int3(r, a, a);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 grr => new int3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 grg => new int3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 grb => new int3(g, r, b);
        /// <summary>Gets the <c>gra</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gra => new int3(g, r, a);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ggr => new int3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ggg => new int3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ggb => new int3(g, g, b);
        /// <summary>Gets the <c>gga</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gga => new int3(g, g, a);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gbr => new int3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gbg => new int3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gbb => new int3(g, b, b);
        /// <summary>Gets the <c>gba</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gba => new int3(g, b, a);

        /// <summary>Gets the <c>gar</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gar => new int3(g, a, r);
        /// <summary>Gets the <c>gag</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gag => new int3(g, a, g);
        /// <summary>Gets the <c>gab</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gab => new int3(g, a, b);
        /// <summary>Gets the <c>gaa</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 gaa => new int3(g, a, a);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 brr => new int3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 brg => new int3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 brb => new int3(b, r, b);
        /// <summary>Gets the <c>bra</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bra => new int3(b, r, a);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bgr => new int3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bgg => new int3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bgb => new int3(b, g, b);
        /// <summary>Gets the <c>bga</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bga => new int3(b, g, a);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bbr => new int3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bbg => new int3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bbb => new int3(b, b, b);
        /// <summary>Gets the <c>bba</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bba => new int3(b, b, a);

        /// <summary>Gets the <c>bar</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bar => new int3(b, a, r);
        /// <summary>Gets the <c>bag</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bag => new int3(b, a, g);
        /// <summary>Gets the <c>bab</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 bab => new int3(b, a, b);
        /// <summary>Gets the <c>baa</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 baa => new int3(b, a, a);

        // a
        /// <summary>Gets the <c>arr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 arr => new int3(a, r, r);
        /// <summary>Gets the <c>arg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 arg => new int3(a, r, g);
        /// <summary>Gets the <c>arb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 arb => new int3(a, r, b);
        /// <summary>Gets the <c>ara</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 ara => new int3(a, r, a);

        /// <summary>Gets the <c>agr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 agr => new int3(a, g, r);
        /// <summary>Gets the <c>agg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 agg => new int3(a, g, g);
        /// <summary>Gets the <c>agb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 agb => new int3(a, g, b);
        /// <summary>Gets the <c>aga</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 aga => new int3(a, g, a);

        /// <summary>Gets the <c>abr</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 abr => new int3(a, b, r);
        /// <summary>Gets the <c>abg</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 abg => new int3(a, b, g);
        /// <summary>Gets the <c>abb</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 abb => new int3(a, b, b);
        /// <summary>Gets the <c>aba</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 aba => new int3(a, b, a);

        /// <summary>Gets the <c>aar</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 aar => new int3(a, a, r);
        /// <summary>Gets the <c>aag</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 aag => new int3(a, a, g);
        /// <summary>Gets the <c>aab</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 aab => new int3(a, a, b);
        /// <summary>Gets the <c>aaa</c> swizzle of the vector as an <see cref="int3"/>.</summary>
        public readonly int3 aaa => new int3(a, a, a);

        // RGBA - Swizzles - int2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 rr => new int2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 rg => new int2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 rb => new int2(r, b);
        /// <summary>Gets the <c>ra</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 ra => new int2(r, a);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 gr => new int2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 gg => new int2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 gb => new int2(g, b);
        /// <summary>Gets the <c>ga</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 ga => new int2(g, a);

        /// <summary>Gets the <c>br</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 br => new int2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 bg => new int2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 bb => new int2(b, b);
        /// <summary>Gets the <c>ba</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 ba => new int2(b, a);

        /// <summary>Gets the <c>ar</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 ar => new int2(a, r);
        /// <summary>Gets the <c>ag</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 ag => new int2(a, g);
        /// <summary>Gets the <c>ab</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 ab => new int2(a, b);
        /// <summary>Gets the <c>aa</c> swizzle of the vector as an <see cref="int2"/>.</summary>
        public readonly int2 aa => new int2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
