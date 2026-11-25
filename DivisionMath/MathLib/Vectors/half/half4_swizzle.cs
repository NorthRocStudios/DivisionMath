//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
namespace DivisionEngine.MathLib
{
    public partial struct half4
    {
        #region Swizzles_half4

        // Swizzles - half4

        // x
        // xx
        /// <summary>Gets the <c>xxxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxxx => new half4(x, x, x, x);
        /// <summary>Gets the <c>xxxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxxy => new half4(x, x, x, y);
        /// <summary>Gets the <c>xxxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxxz => new half4(x, x, x, z);
        /// <summary>Gets the <c>xxxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxxw => new half4(x, x, x, w);

        /// <summary>Gets the <c>xxyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxyx => new half4(x, x, y, x);
        /// <summary>Gets the <c>xxyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxyy => new half4(x, x, y, y);
        /// <summary>Gets the <c>xxyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxyz => new half4(x, x, y, z);
        /// <summary>Gets the <c>xxyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxyw => new half4(x, x, y, w);

        /// <summary>Gets the <c>xxzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxzx => new half4(x, x, z, x);
        /// <summary>Gets the <c>xxzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxzy => new half4(x, x, z, y);
        /// <summary>Gets the <c>xxzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxzz => new half4(x, x, z, z);
        /// <summary>Gets the <c>xxzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxzw => new half4(x, x, z, w);

        /// <summary>Gets the <c>xxwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxwx => new half4(x, x, w, x);
        /// <summary>Gets the <c>xxwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxwy => new half4(x, x, w, y);
        /// <summary>Gets the <c>xxwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxwz => new half4(x, x, w, z);
        /// <summary>Gets the <c>xxww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xxww => new half4(x, x, w, w);

        // xy
        /// <summary>Gets the <c>xyxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyxx => new half4(x, y, x, x);
        /// <summary>Gets the <c>xyxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyxy => new half4(x, y, x, y);
        /// <summary>Gets the <c>xyxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyxz => new half4(x, y, x, z);
        /// <summary>Gets the <c>xyxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyxw => new half4(x, y, x, w);

        /// <summary>Gets the <c>xyyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyyx => new half4(x, y, y, x);
        /// <summary>Gets the <c>xyyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyyy => new half4(x, y, y, y);
        /// <summary>Gets the <c>xyyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyyz => new half4(x, y, y, z);
        /// <summary>Gets the <c>xyyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyyw => new half4(x, y, y, w);

        /// <summary>Gets the <c>xyzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyzx => new half4(x, y, z, x);
        /// <summary>Gets the <c>xyzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyzy => new half4(x, y, z, y);
        /// <summary>Gets the <c>xyzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyzz => new half4(x, y, z, z);
        /// <summary>Gets the <c>xyzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyzw => new half4(x, y, z, w);

        /// <summary>Gets the <c>xywx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xywx => new half4(x, y, w, x);
        /// <summary>Gets the <c>xywy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xywy => new half4(x, y, w, y);
        /// <summary>Gets the <c>xywz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xywz => new half4(x, y, w, z);
        /// <summary>Gets the <c>xyww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xyww => new half4(x, y, w, w);

        // xz
        /// <summary>Gets the <c>xzxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzxx => new half4(x, z, x, x);
        /// <summary>Gets the <c>xzxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzxy => new half4(x, z, x, y);
        /// <summary>Gets the <c>xzxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzxz => new half4(x, z, x, z);
        /// <summary>Gets the <c>xzxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzxw => new half4(x, z, x, w);

        /// <summary>Gets the <c>xzyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzyx => new half4(x, z, y, x);
        /// <summary>Gets the <c>xzyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzyy => new half4(x, z, y, y);
        /// <summary>Gets the <c>xzyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzyz => new half4(x, z, y, z);
        /// <summary>Gets the <c>xzyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzyw => new half4(x, z, y, w);

        /// <summary>Gets the <c>xzzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzzx => new half4(x, z, z, x);
        /// <summary>Gets the <c>xzzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzzy => new half4(x, z, z, y);
        /// <summary>Gets the <c>xzzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzzz => new half4(x, z, z, z);
        /// <summary>Gets the <c>xzzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzzw => new half4(x, z, z, w);

        /// <summary>Gets the <c>xzwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzwx => new half4(x, z, w, x);
        /// <summary>Gets the <c>xzwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzwy => new half4(x, z, w, y);
        /// <summary>Gets the <c>xzwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzwz => new half4(x, z, w, z);
        /// <summary>Gets the <c>xzww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xzww => new half4(x, z, w, w);

        // xw
        /// <summary>Gets the <c>xwxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwxx => new half4(x, w, x, x);
        /// <summary>Gets the <c>xwxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwxy => new half4(x, w, x, y);
        /// <summary>Gets the <c>xwxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwxz => new half4(x, w, x, z);
        /// <summary>Gets the <c>xwxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwxw => new half4(x, w, x, w);

        /// <summary>Gets the <c>xwyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwyx => new half4(x, w, y, x);
        /// <summary>Gets the <c>xwyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwyy => new half4(x, w, y, y);
        /// <summary>Gets the <c>xwyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwyz => new half4(x, w, y, z);
        /// <summary>Gets the <c>xwyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwyw => new half4(x, w, y, w);

        /// <summary>Gets the <c>xwzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwzx => new half4(x, w, z, x);
        /// <summary>Gets the <c>xwzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwzy => new half4(x, w, z, y);
        /// <summary>Gets the <c>xwzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwzz => new half4(x, w, z, z);
        /// <summary>Gets the <c>xwzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwzw => new half4(x, w, z, w);

        /// <summary>Gets the <c>xwwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwwx => new half4(x, w, w, x);
        /// <summary>Gets the <c>xwwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwwy => new half4(x, w, w, y);
        /// <summary>Gets the <c>xwwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwwz => new half4(x, w, w, z);
        /// <summary>Gets the <c>xwww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 xwww => new half4(x, w, w, w);


        // y
        // yx
        /// <summary>Gets the <c>yxxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxxx => new half4(y, x, x, x);
        /// <summary>Gets the <c>yxxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxxy => new half4(y, x, x, y);
        /// <summary>Gets the <c>yxxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxxz => new half4(y, x, x, z);
        /// <summary>Gets the <c>yxxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxxw => new half4(y, x, x, w);

        /// <summary>Gets the <c>yxyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxyx => new half4(y, x, y, x);
        /// <summary>Gets the <c>yxyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxyy => new half4(y, x, y, y);
        /// <summary>Gets the <c>yxyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxyz => new half4(y, x, y, z);
        /// <summary>Gets the <c>yxyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxyw => new half4(y, x, y, w);

        /// <summary>Gets the <c>yxzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxzx => new half4(y, x, z, x);
        /// <summary>Gets the <c>yxzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxzy => new half4(y, x, z, y);
        /// <summary>Gets the <c>yxzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxzz => new half4(y, x, z, z);
        /// <summary>Gets the <c>yxzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxzw => new half4(y, x, z, w);

        /// <summary>Gets the <c>yxwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxwx => new half4(y, x, w, x);
        /// <summary>Gets the <c>yxwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxwy => new half4(y, x, w, y);
        /// <summary>Gets the <c>yxwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxwz => new half4(y, x, w, z);
        /// <summary>Gets the <c>yxww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yxww => new half4(y, x, w, w);

        // yy
        /// <summary>Gets the <c>yyxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyxx => new half4(y, y, x, x);
        /// <summary>Gets the <c>yyxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyxy => new half4(y, y, x, y);
        /// <summary>Gets the <c>yyxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyxz => new half4(y, y, x, z);
        /// <summary>Gets the <c>yyxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyxw => new half4(y, y, x, w);

        /// <summary>Gets the <c>yyyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyyx => new half4(y, y, y, x);
        /// <summary>Gets the <c>yyyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyyy => new half4(y, y, y, y);
        /// <summary>Gets the <c>yyyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyyz => new half4(y, y, y, z);
        /// <summary>Gets the <c>yyyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyyw => new half4(y, y, y, w);

        /// <summary>Gets the <c>yyzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyzx => new half4(y, y, z, x);
        /// <summary>Gets the <c>yyzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyzy => new half4(y, y, z, y);
        /// <summary>Gets the <c>yyzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyzz => new half4(y, y, z, z);
        /// <summary>Gets the <c>yyzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyzw => new half4(y, y, z, w);

        /// <summary>Gets the <c>yywx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yywx => new half4(y, y, w, x);
        /// <summary>Gets the <c>yywy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yywy => new half4(y, y, w, y);
        /// <summary>Gets the <c>yywz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yywz => new half4(y, y, w, z);
        /// <summary>Gets the <c>yyww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yyww => new half4(y, y, w, w);

        // yz
        /// <summary>Gets the <c>yzxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzxx => new half4(y, z, x, x);
        /// <summary>Gets the <c>yzxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzxy => new half4(y, z, x, y);
        /// <summary>Gets the <c>yzxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzxz => new half4(y, z, x, z);
        /// <summary>Gets the <c>yzxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzxw => new half4(y, z, x, w);

        /// <summary>Gets the <c>yzyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzyx => new half4(y, z, y, x);
        /// <summary>Gets the <c>yzyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzyy => new half4(y, z, y, y);
        /// <summary>Gets the <c>yzyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzyz => new half4(y, z, y, z);
        /// <summary>Gets the <c>yzyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzyw => new half4(y, z, y, w);

        /// <summary>Gets the <c>yzzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzzx => new half4(y, z, z, x);
        /// <summary>Gets the <c>yzzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzzy => new half4(y, z, z, y);
        /// <summary>Gets the <c>yzzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzzz => new half4(y, z, z, z);
        /// <summary>Gets the <c>yzzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzzw => new half4(y, z, z, w);

        /// <summary>Gets the <c>yzwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzwx => new half4(y, z, w, x);
        /// <summary>Gets the <c>yzwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzwy => new half4(y, z, w, y);
        /// <summary>Gets the <c>yzwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzwz => new half4(y, z, w, z);
        /// <summary>Gets the <c>yzww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 yzww => new half4(y, z, w, w);

        // yw
        /// <summary>Gets the <c>ywxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywxx => new half4(y, w, x, x);
        /// <summary>Gets the <c>ywxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywxy => new half4(y, w, x, y);
        /// <summary>Gets the <c>ywxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywxz => new half4(y, w, x, z);
        /// <summary>Gets the <c>ywxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywxw => new half4(y, w, x, w);

        /// <summary>Gets the <c>ywyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywyx => new half4(y, w, y, x);
        /// <summary>Gets the <c>ywyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywyy => new half4(y, w, y, y);
        /// <summary>Gets the <c>ywyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywyz => new half4(y, w, y, z);
        /// <summary>Gets the <c>ywyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywyw => new half4(y, w, y, w);

        /// <summary>Gets the <c>ywzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywzx => new half4(y, w, z, x);
        /// <summary>Gets the <c>ywzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywzy => new half4(y, w, z, y);
        /// <summary>Gets the <c>ywzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywzz => new half4(y, w, z, z);
        /// <summary>Gets the <c>ywzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywzw => new half4(y, w, z, w);

        /// <summary>Gets the <c>ywwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywwx => new half4(y, w, w, x);
        /// <summary>Gets the <c>ywwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywwy => new half4(y, w, w, y);
        /// <summary>Gets the <c>ywwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywwz => new half4(y, w, w, z);
        /// <summary>Gets the <c>ywww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ywww => new half4(y, w, w, w);


        // z
        // zx
        /// <summary>Gets the <c>zxxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxxx => new half4(z, x, x, x);
        /// <summary>Gets the <c>zxxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxxy => new half4(z, x, x, y);
        /// <summary>Gets the <c>zxxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxxz => new half4(z, x, x, z);
        /// <summary>Gets the <c>zxxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxxw => new half4(z, x, x, w);

        /// <summary>Gets the <c>zxyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxyx => new half4(z, x, y, x);
        /// <summary>Gets the <c>zxyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxyy => new half4(z, x, y, y);
        /// <summary>Gets the <c>zxyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxyz => new half4(z, x, y, z);
        /// <summary>Gets the <c>zxyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxyw => new half4(z, x, y, w);

        /// <summary>Gets the <c>zxzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxzx => new half4(z, x, z, x);
        /// <summary>Gets the <c>zxzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxzy => new half4(z, x, z, y);
        /// <summary>Gets the <c>zxzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxzz => new half4(z, x, z, z);
        /// <summary>Gets the <c>zxzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxzw => new half4(z, x, z, w);

        /// <summary>Gets the <c>zxwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxwx => new half4(z, x, w, x);
        /// <summary>Gets the <c>zxwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxwy => new half4(z, x, w, y);
        /// <summary>Gets the <c>zxwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxwz => new half4(z, x, w, z);
        /// <summary>Gets the <c>zxww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zxww => new half4(z, x, w, w);

        // zy
        /// <summary>Gets the <c>zyxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyxx => new half4(z, y, x, x);
        /// <summary>Gets the <c>zyxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyxy => new half4(z, y, x, y);
        /// <summary>Gets the <c>zyxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyxz => new half4(z, y, x, z);
        /// <summary>Gets the <c>zyxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyxw => new half4(z, y, x, w);

        /// <summary>Gets the <c>zyyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyyx => new half4(z, y, y, x);
        /// <summary>Gets the <c>zyyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyyy => new half4(z, y, y, y);
        /// <summary>Gets the <c>zyyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyyz => new half4(z, y, y, z);
        /// <summary>Gets the <c>zyyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyyw => new half4(z, y, y, w);

        /// <summary>Gets the <c>zyzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyzx => new half4(z, y, z, x);
        /// <summary>Gets the <c>zyzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyzy => new half4(z, y, z, y);
        /// <summary>Gets the <c>zyzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyzz => new half4(z, y, z, z);
        /// <summary>Gets the <c>zyzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyzw => new half4(z, y, z, w);

        /// <summary>Gets the <c>zywx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zywx => new half4(z, y, w, x);
        /// <summary>Gets the <c>zywy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zywy => new half4(z, y, w, y);
        /// <summary>Gets the <c>zywz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zywz => new half4(z, y, w, z);
        /// <summary>Gets the <c>zyww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zyww => new half4(z, y, w, w);

        // zz
        /// <summary>Gets the <c>zzxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzxx => new half4(z, z, x, x);
        /// <summary>Gets the <c>zzxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzxy => new half4(z, z, x, y);
        /// <summary>Gets the <c>zzxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzxz => new half4(z, z, x, z);
        /// <summary>Gets the <c>zzxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzxw => new half4(z, z, x, w);

        /// <summary>Gets the <c>zzyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzyx => new half4(z, z, y, x);
        /// <summary>Gets the <c>zzyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzyy => new half4(z, z, y, y);
        /// <summary>Gets the <c>zzyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzyz => new half4(z, z, y, z);
        /// <summary>Gets the <c>zzyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzyw => new half4(z, z, y, w);

        /// <summary>Gets the <c>zzzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzzx => new half4(z, z, z, x);
        /// <summary>Gets the <c>zzzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzzy => new half4(z, z, z, y);
        /// <summary>Gets the <c>zzzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzzz => new half4(z, z, z, z);
        /// <summary>Gets the <c>zzzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzzw => new half4(z, z, z, w);

        /// <summary>Gets the <c>zzwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzwx => new half4(z, z, w, x);
        /// <summary>Gets the <c>zzwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzwy => new half4(z, z, w, y);
        /// <summary>Gets the <c>zzwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzwz => new half4(z, z, w, z);
        /// <summary>Gets the <c>zzww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zzww => new half4(z, z, w, w);

        // zw
        /// <summary>Gets the <c>zwxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwxx => new half4(z, w, x, x);
        /// <summary>Gets the <c>zwxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwxy => new half4(z, w, x, y);
        /// <summary>Gets the <c>zwxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwxz => new half4(z, w, x, z);
        /// <summary>Gets the <c>zwxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwxw => new half4(z, w, x, w);

        /// <summary>Gets the <c>zwyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwyx => new half4(z, w, y, x);
        /// <summary>Gets the <c>zwyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwyy => new half4(z, w, y, y);
        /// <summary>Gets the <c>zwyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwyz => new half4(z, w, y, z);
        /// <summary>Gets the <c>zwyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwyw => new half4(z, w, y, w);

        /// <summary>Gets the <c>zwzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwzx => new half4(z, w, z, x);
        /// <summary>Gets the <c>zwzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwzy => new half4(z, w, z, y);
        /// <summary>Gets the <c>zwzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwzz => new half4(z, w, z, z);
        /// <summary>Gets the <c>zwzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwzw => new half4(z, w, z, w);

        /// <summary>Gets the <c>zwwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwwx => new half4(z, w, w, x);
        /// <summary>Gets the <c>zwwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwwy => new half4(z, w, w, y);
        /// <summary>Gets the <c>zwwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwwz => new half4(z, w, w, z);
        /// <summary>Gets the <c>zwww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 zwww => new half4(z, w, w, w);


        // w
        // wx
        /// <summary>Gets the <c>wxxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxxx => new half4(w, x, x, x);
        /// <summary>Gets the <c>wxxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxxy => new half4(w, x, x, y);
        /// <summary>Gets the <c>wxxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxxz => new half4(w, x, x, z);
        /// <summary>Gets the <c>wxxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxxw => new half4(w, x, x, w);

        /// <summary>Gets the <c>wxyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxyx => new half4(w, x, y, x);
        /// <summary>Gets the <c>wxyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxyy => new half4(w, x, y, y);
        /// <summary>Gets the <c>wxyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxyz => new half4(w, x, y, z);
        /// <summary>Gets the <c>wxyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxyw => new half4(w, x, y, w);

        /// <summary>Gets the <c>wxzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxzx => new half4(w, x, z, x);
        /// <summary>Gets the <c>wxzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxzy => new half4(w, x, z, y);
        /// <summary>Gets the <c>wxzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxzz => new half4(w, x, z, z);
        /// <summary>Gets the <c>wxzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxzw => new half4(w, x, z, w);

        /// <summary>Gets the <c>wxwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxwx => new half4(w, x, w, x);
        /// <summary>Gets the <c>wxwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxwy => new half4(w, x, w, y);
        /// <summary>Gets the <c>wxwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxwz => new half4(w, x, w, z);
        /// <summary>Gets the <c>wxww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wxww => new half4(w, x, w, w);

        // wy
        /// <summary>Gets the <c>wyxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyxx => new half4(w, y, x, x);
        /// <summary>Gets the <c>wyxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyxy => new half4(w, y, x, y);
        /// <summary>Gets the <c>wyxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyxz => new half4(w, y, x, z);
        /// <summary>Gets the <c>wyxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyxw => new half4(w, y, x, w);

        /// <summary>Gets the <c>wyyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyyx => new half4(w, y, y, x);
        /// <summary>Gets the <c>wyyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyyy => new half4(w, y, y, y);
        /// <summary>Gets the <c>wyyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyyz => new half4(w, y, y, z);
        /// <summary>Gets the <c>wyyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyyw => new half4(w, y, y, w);

        /// <summary>Gets the <c>wyzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyzx => new half4(w, y, z, x);
        /// <summary>Gets the <c>wyzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyzy => new half4(w, y, z, y);
        /// <summary>Gets the <c>wyzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyzz => new half4(w, y, z, z);
        /// <summary>Gets the <c>wyzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyzw => new half4(w, y, z, w);

        /// <summary>Gets the <c>wywx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wywx => new half4(w, y, w, x);
        /// <summary>Gets the <c>wywy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wywy => new half4(w, y, w, y);
        /// <summary>Gets the <c>wywz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wywz => new half4(w, y, w, z);
        /// <summary>Gets the <c>wyww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wyww => new half4(w, y, w, w);

        // wz
        /// <summary>Gets the <c>wzxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzxx => new half4(w, z, x, x);
        /// <summary>Gets the <c>wzxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzxy => new half4(w, z, x, y);
        /// <summary>Gets the <c>wzxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzxz => new half4(w, z, x, z);
        /// <summary>Gets the <c>wzxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzxw => new half4(w, z, x, w);

        /// <summary>Gets the <c>wzyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzyx => new half4(w, z, y, x);
        /// <summary>Gets the <c>wzyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzyy => new half4(w, z, y, y);
        /// <summary>Gets the <c>wzyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzyz => new half4(w, z, y, z);
        /// <summary>Gets the <c>wzyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzyw => new half4(w, z, y, w);

        /// <summary>Gets the <c>wzzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzzx => new half4(w, z, z, x);
        /// <summary>Gets the <c>wzzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzzy => new half4(w, z, z, y);
        /// <summary>Gets the <c>wzzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzzz => new half4(w, z, z, z);
        /// <summary>Gets the <c>wzzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzzw => new half4(w, z, z, w);

        /// <summary>Gets the <c>wzwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzwx => new half4(w, z, w, x);
        /// <summary>Gets the <c>wzwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzwy => new half4(w, z, w, y);
        /// <summary>Gets the <c>wzwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzwz => new half4(w, z, w, z);
        /// <summary>Gets the <c>wzww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wzww => new half4(w, z, w, w);

        // ww
        /// <summary>Gets the <c>wwxx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwxx => new half4(w, w, x, x);
        /// <summary>Gets the <c>wwxy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwxy => new half4(w, w, x, y);
        /// <summary>Gets the <c>wwxz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwxz => new half4(w, w, x, z);
        /// <summary>Gets the <c>wwxw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwxw => new half4(w, w, x, w);

        /// <summary>Gets the <c>wwyx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwyx => new half4(w, w, y, x);
        /// <summary>Gets the <c>wwyy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwyy => new half4(w, w, y, y);
        /// <summary>Gets the <c>wwyz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwyz => new half4(w, w, y, z);
        /// <summary>Gets the <c>wwyw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwyw => new half4(w, w, y, w);

        /// <summary>Gets the <c>wwzx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwzx => new half4(w, w, z, x);
        /// <summary>Gets the <c>wwzy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwzy => new half4(w, w, z, y);
        /// <summary>Gets the <c>wwzz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwzz => new half4(w, w, z, z);
        /// <summary>Gets the <c>wwzw</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwzw => new half4(w, w, z, w);

        /// <summary>Gets the <c>wwwx</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwwx => new half4(w, w, w, x);
        /// <summary>Gets the <c>wwwy</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwwy => new half4(w, w, w, y);
        /// <summary>Gets the <c>wwwz</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwwz => new half4(w, w, w, z);
        /// <summary>Gets the <c>wwww</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 wwww => new half4(w, w, w, w);

        #endregion Swizzles_half4
        #region Swizzles_half4_RGBA

        // RGBA - Swizzles - half4

        // r
        // rr
        /// <summary>Gets the <c>rrrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrrr => new half4(r, r, r, r);
        /// <summary>Gets the <c>rrrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrrg => new half4(r, r, r, g);
        /// <summary>Gets the <c>rrrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrrb => new half4(r, r, r, b);
        /// <summary>Gets the <c>rrra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrra => new half4(r, r, r, a);

        /// <summary>Gets the <c>rrgr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrgr => new half4(r, r, g, r);
        /// <summary>Gets the <c>rrgg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrgg => new half4(r, r, g, g);
        /// <summary>Gets the <c>rrgb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrgb => new half4(r, r, g, b);
        /// <summary>Gets the <c>rrga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrga => new half4(r, r, g, a);

        /// <summary>Gets the <c>rrbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrbr => new half4(r, r, b, r);
        /// <summary>Gets the <c>rrbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrbg => new half4(r, r, b, g);
        /// <summary>Gets the <c>rrbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrbb => new half4(r, r, b, b);
        /// <summary>Gets the <c>rrba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrba => new half4(r, r, b, a);

        /// <summary>Gets the <c>rrar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrar => new half4(r, r, a, r);
        /// <summary>Gets the <c>rrag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrag => new half4(r, r, a, g);
        /// <summary>Gets the <c>rrab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rrab => new half4(r, r, a, b);
        /// <summary>Gets the <c>rraa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rraa => new half4(r, r, a, a);

        // rg
        /// <summary>Gets the <c>rgrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgrr => new half4(r, g, r, r);
        /// <summary>Gets the <c>rgrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgrg => new half4(r, g, r, g);
        /// <summary>Gets the <c>rgrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgrb => new half4(r, g, r, b);
        /// <summary>Gets the <c>rgra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgra => new half4(r, g, r, a);

        /// <summary>Gets the <c>rggr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rggr => new half4(r, g, g, r);
        /// <summary>Gets the <c>rggg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rggg => new half4(r, g, g, g);
        /// <summary>Gets the <c>rggb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rggb => new half4(r, g, g, b);
        /// <summary>Gets the <c>rgga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgga => new half4(r, g, g, a);

        /// <summary>Gets the <c>rgbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgbr => new half4(r, g, b, r);
        /// <summary>Gets the <c>rgbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgbg => new half4(r, g, b, g);
        /// <summary>Gets the <c>rgbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgbb => new half4(r, g, b, b);
        /// <summary>Gets the <c>rgba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgba => new half4(r, g, b, a);

        /// <summary>Gets the <c>rgar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgar => new half4(r, g, a, r);
        /// <summary>Gets the <c>rgag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgag => new half4(r, g, a, g);
        /// <summary>Gets the <c>rgab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgab => new half4(r, g, a, b);
        /// <summary>Gets the <c>rgaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rgaa => new half4(r, g, a, a);

        // rb
        /// <summary>Gets the <c>rbrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbrr => new half4(r, b, r, r);
        /// <summary>Gets the <c>rbrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbrg => new half4(r, b, r, g);
        /// <summary>Gets the <c>rbrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbrb => new half4(r, b, r, b);
        /// <summary>Gets the <c>rbra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbra => new half4(r, b, r, a);

        /// <summary>Gets the <c>rbgr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbgr => new half4(r, b, g, r);
        /// <summary>Gets the <c>rbgg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbgg => new half4(r, b, g, g);
        /// <summary>Gets the <c>rbgb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbgb => new half4(r, b, g, b);
        /// <summary>Gets the <c>rbga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbga => new half4(r, b, g, a);

        /// <summary>Gets the <c>rbbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbbr => new half4(r, b, b, r);
        /// <summary>Gets the <c>rbbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbbg => new half4(r, b, b, g);
        /// <summary>Gets the <c>rbbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbbb => new half4(r, b, b, b);
        /// <summary>Gets the <c>rbba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbba => new half4(r, b, b, a);

        /// <summary>Gets the <c>rbar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbar => new half4(r, b, a, r);
        /// <summary>Gets the <c>rbag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbag => new half4(r, b, a, g);
        /// <summary>Gets the <c>rbab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbab => new half4(r, b, a, b);
        /// <summary>Gets the <c>rbaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rbaa => new half4(r, b, a, a);

        // ra
        /// <summary>Gets the <c>rarr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rarr => new half4(r, a, r, r);
        /// <summary>Gets the <c>rarg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rarg => new half4(r, a, r, g);
        /// <summary>Gets the <c>rarb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rarb => new half4(r, a, r, b);
        /// <summary>Gets the <c>rara</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rara => new half4(r, a, r, a);

        /// <summary>Gets the <c>ragr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ragr => new half4(r, a, g, r);
        /// <summary>Gets the <c>ragg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ragg => new half4(r, a, g, g);
        /// <summary>Gets the <c>ragb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ragb => new half4(r, a, g, b);
        /// <summary>Gets the <c>raga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 raga => new half4(r, a, g, a);

        /// <summary>Gets the <c>rabr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rabr => new half4(r, a, b, r);
        /// <summary>Gets the <c>rabg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rabg => new half4(r, a, b, g);
        /// <summary>Gets the <c>rabb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 rabb => new half4(r, a, b, b);
        /// <summary>Gets the <c>raba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 raba => new half4(r, a, b, a);

        /// <summary>Gets the <c>raar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 raar => new half4(r, a, a, r);
        /// <summary>Gets the <c>raag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 raag => new half4(r, a, a, g);
        /// <summary>Gets the <c>raab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 raab => new half4(r, a, a, b);
        /// <summary>Gets the <c>raaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 raaa => new half4(r, a, a, a);


        // g
        // gr
        /// <summary>Gets the <c>grrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grrr => new half4(g, r, r, r);
        /// <summary>Gets the <c>grrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grrg => new half4(g, r, r, g);
        /// <summary>Gets the <c>grrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grrb => new half4(g, r, r, b);
        /// <summary>Gets the <c>grra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grra => new half4(g, r, r, a);

        /// <summary>Gets the <c>grgr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grgr => new half4(g, r, g, r);
        /// <summary>Gets the <c>grgg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grgg => new half4(g, r, g, g);
        /// <summary>Gets the <c>grgb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grgb => new half4(g, r, g, b);
        /// <summary>Gets the <c>grga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grga => new half4(g, r, g, a);

        /// <summary>Gets the <c>grbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grbr => new half4(g, r, b, r);
        /// <summary>Gets the <c>grbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grbg => new half4(g, r, b, g);
        /// <summary>Gets the <c>grbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grbb => new half4(g, r, b, b);
        /// <summary>Gets the <c>grba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grba => new half4(g, r, b, a);

        /// <summary>Gets the <c>grar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grar => new half4(g, r, a, r);
        /// <summary>Gets the <c>grag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grag => new half4(g, r, a, g);
        /// <summary>Gets the <c>grab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 grab => new half4(g, r, a, b);
        /// <summary>Gets the <c>graa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 graa => new half4(g, r, a, a);

        // gg
        /// <summary>Gets the <c>ggrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggrr => new half4(g, g, r, r);
        /// <summary>Gets the <c>ggrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggrg => new half4(g, g, r, g);
        /// <summary>Gets the <c>ggrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggrb => new half4(g, g, r, b);
        /// <summary>Gets the <c>ggra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggra => new half4(g, g, r, a);

        /// <summary>Gets the <c>gggr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gggr => new half4(g, g, g, r);
        /// <summary>Gets the <c>gggg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gggg => new half4(g, g, g, g);
        /// <summary>Gets the <c>gggb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gggb => new half4(g, g, g, b);
        /// <summary>Gets the <c>ggga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggga => new half4(g, g, g, a);

        /// <summary>Gets the <c>ggbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggbr => new half4(g, g, b, r);
        /// <summary>Gets the <c>ggbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggbg => new half4(g, g, b, g);
        /// <summary>Gets the <c>ggbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggbb => new half4(g, g, b, b);
        /// <summary>Gets the <c>ggba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggba => new half4(g, g, b, a);

        /// <summary>Gets the <c>ggar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggar => new half4(g, g, a, r);
        /// <summary>Gets the <c>ggag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggag => new half4(g, g, a, g);
        /// <summary>Gets the <c>ggab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggab => new half4(g, g, a, b);
        /// <summary>Gets the <c>ggaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 ggaa => new half4(g, g, a, a);

        // gb
        /// <summary>Gets the <c>gbrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbrr => new half4(g, b, r, r);
        /// <summary>Gets the <c>gbrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbrg => new half4(g, b, r, g);
        /// <summary>Gets the <c>gbrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbrb => new half4(g, b, r, b);
        /// <summary>Gets the <c>gbra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbra => new half4(g, b, r, a);

        /// <summary>Gets the <c>gbgr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbgr => new half4(g, b, g, r);
        /// <summary>Gets the <c>gbgg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbgg => new half4(g, b, g, g);
        /// <summary>Gets the <c>gbgb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbgb => new half4(g, b, g, b);
        /// <summary>Gets the <c>gbga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbga => new half4(g, b, g, a);

        /// <summary>Gets the <c>gbbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbbr => new half4(g, b, b, r);
        /// <summary>Gets the <c>gbbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbbg => new half4(g, b, b, g);
        /// <summary>Gets the <c>gbbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbbb => new half4(g, b, b, b);
        /// <summary>Gets the <c>gbba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbba => new half4(g, b, b, a);

        /// <summary>Gets the <c>gbar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbar => new half4(g, b, a, r);
        /// <summary>Gets the <c>gbag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbag => new half4(g, b, a, g);
        /// <summary>Gets the <c>gbab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbab => new half4(g, b, a, b);
        /// <summary>Gets the <c>gbaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gbaa => new half4(g, b, a, a);

        // ga
        /// <summary>Gets the <c>garr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 garr => new half4(g, a, r, r);
        /// <summary>Gets the <c>garg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 garg => new half4(g, a, r, g);
        /// <summary>Gets the <c>garb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 garb => new half4(g, a, r, b);
        /// <summary>Gets the <c>gara</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gara => new half4(g, a, r, a);

        /// <summary>Gets the <c>gagr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gagr => new half4(g, a, g, r);
        /// <summary>Gets the <c>gagg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gagg => new half4(g, a, g, g);
        /// <summary>Gets the <c>gagb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gagb => new half4(g, a, g, b);
        /// <summary>Gets the <c>gaga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gaga => new half4(g, a, g, a);

        /// <summary>Gets the <c>gabr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gabr => new half4(g, a, b, r);
        /// <summary>Gets the <c>gabg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gabg => new half4(g, a, b, g);
        /// <summary>Gets the <c>gabb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gabb => new half4(g, a, b, b);
        /// <summary>Gets the <c>gaba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gaba => new half4(g, a, b, a);

        /// <summary>Gets the <c>gaar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gaar => new half4(g, a, a, r);
        /// <summary>Gets the <c>gaag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gaag => new half4(g, a, a, g);
        /// <summary>Gets the <c>gaab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gaab => new half4(g, a, a, b);
        /// <summary>Gets the <c>gaaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 gaaa => new half4(g, a, a, a);


        // b
        // br
        /// <summary>Gets the <c>brrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brrr => new half4(b, r, r, r);
        /// <summary>Gets the <c>brrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brrg => new half4(b, r, r, g);
        /// <summary>Gets the <c>brrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brrb => new half4(b, r, r, b);
        /// <summary>Gets the <c>brra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brra => new half4(b, r, r, a);

        /// <summary>Gets the <c>brgr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brgr => new half4(b, r, g, r);
        /// <summary>Gets the <c>brgg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brgg => new half4(b, r, g, g);
        /// <summary>Gets the <c>brgb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brgb => new half4(b, r, g, b);
        /// <summary>Gets the <c>brga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brga => new half4(b, r, g, a);

        /// <summary>Gets the <c>brbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brbr => new half4(b, r, b, r);
        /// <summary>Gets the <c>brbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brbg => new half4(b, r, b, g);
        /// <summary>Gets the <c>brbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brbb => new half4(b, r, b, b);
        /// <summary>Gets the <c>brba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brba => new half4(b, r, b, a);

        /// <summary>Gets the <c>brar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brar => new half4(b, r, a, r);
        /// <summary>Gets the <c>brag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brag => new half4(b, r, a, g);
        /// <summary>Gets the <c>brab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 brab => new half4(b, r, a, b);
        /// <summary>Gets the <c>braa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 braa => new half4(b, r, a, a);

        // bg
        /// <summary>Gets the <c>bgrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgrr => new half4(b, g, r, r);
        /// <summary>Gets the <c>bgrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgrg => new half4(b, g, r, g);
        /// <summary>Gets the <c>bgrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgrb => new half4(b, g, r, b);
        /// <summary>Gets the <c>bgra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgra => new half4(b, g, r, a);

        /// <summary>Gets the <c>bggr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bggr => new half4(b, g, g, r);
        /// <summary>Gets the <c>bggg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bggg => new half4(b, g, g, g);
        /// <summary>Gets the <c>bggb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bggb => new half4(b, g, g, b);
        /// <summary>Gets the <c>bgga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgga => new half4(b, g, g, a);

        /// <summary>Gets the <c>bgbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgbr => new half4(b, g, b, r);
        /// <summary>Gets the <c>bgbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgbg => new half4(b, g, b, g);
        /// <summary>Gets the <c>bgbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgbb => new half4(b, g, b, b);
        /// <summary>Gets the <c>bgba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgba => new half4(b, g, b, a);

        /// <summary>Gets the <c>bgar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgar => new half4(b, g, a, r);
        /// <summary>Gets the <c>bgag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgag => new half4(b, g, a, g);
        /// <summary>Gets the <c>bgab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgab => new half4(b, g, a, b);
        /// <summary>Gets the <c>bgaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bgaa => new half4(b, g, a, a);

        // bb
        /// <summary>Gets the <c>bbrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbrr => new half4(b, b, r, r);
        /// <summary>Gets the <c>bbrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbrg => new half4(b, b, r, g);
        /// <summary>Gets the <c>bbrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbrb => new half4(b, b, r, b);
        /// <summary>Gets the <c>bbra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbra => new half4(b, b, r, a);

        /// <summary>Gets the <c>bbgr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbgr => new half4(b, b, g, r);
        /// <summary>Gets the <c>bbgg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbgg => new half4(b, b, g, g);
        /// <summary>Gets the <c>bbgb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbgb => new half4(b, b, g, b);
        /// <summary>Gets the <c>bbga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbga => new half4(b, b, g, a);

        /// <summary>Gets the <c>bbbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbbr => new half4(b, b, b, r);
        /// <summary>Gets the <c>bbbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbbg => new half4(b, b, b, g);
        /// <summary>Gets the <c>bbbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbbb => new half4(b, b, b, b);
        /// <summary>Gets the <c>bbba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbba => new half4(b, b, b, a);

        /// <summary>Gets the <c>bbar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbar => new half4(b, b, a, r);
        /// <summary>Gets the <c>bbag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbag => new half4(b, b, a, g);
        /// <summary>Gets the <c>bbab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbab => new half4(b, b, a, b);
        /// <summary>Gets the <c>bbaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bbaa => new half4(b, b, a, a);

        // ba
        /// <summary>Gets the <c>barr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 barr => new half4(b, a, r, r);
        /// <summary>Gets the <c>barg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 barg => new half4(b, a, r, g);
        /// <summary>Gets the <c>barb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 barb => new half4(b, a, r, b);
        /// <summary>Gets the <c>bara</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bara => new half4(b, a, r, a);

        /// <summary>Gets the <c>bagr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bagr => new half4(b, a, g, r);
        /// <summary>Gets the <c>bagg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bagg => new half4(b, a, g, g);
        /// <summary>Gets the <c>bagb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 bagb => new half4(b, a, g, b);
        /// <summary>Gets the <c>baga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 baga => new half4(b, a, g, a);

        /// <summary>Gets the <c>babr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 babr => new half4(b, a, b, r);
        /// <summary>Gets the <c>babg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 babg => new half4(b, a, b, g);
        /// <summary>Gets the <c>babb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 babb => new half4(b, a, b, b);
        /// <summary>Gets the <c>baba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 baba => new half4(b, a, b, a);

        /// <summary>Gets the <c>baar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 baar => new half4(b, a, a, r);
        /// <summary>Gets the <c>baag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 baag => new half4(b, a, a, g);
        /// <summary>Gets the <c>baab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 baab => new half4(b, a, a, b);
        /// <summary>Gets the <c>baaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 baaa => new half4(b, a, a, a);


        // a
        // ar
        /// <summary>Gets the <c>arrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arrr => new half4(a, r, r, r);
        /// <summary>Gets the <c>arrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arrg => new half4(a, r, r, g);
        /// <summary>Gets the <c>arrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arrb => new half4(a, r, r, b);
        /// <summary>Gets the <c>arra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arra => new half4(a, r, r, a);

        /// <summary>Gets the <c>argr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 argr => new half4(a, r, g, r);
        /// <summary>Gets the <c>argg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 argg => new half4(a, r, g, g);
        /// <summary>Gets the <c>argb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 argb => new half4(a, r, g, b);
        /// <summary>Gets the <c>arga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arga => new half4(a, r, g, a);

        /// <summary>Gets the <c>arbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arbr => new half4(a, r, b, r);
        /// <summary>Gets the <c>arbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arbg => new half4(a, r, b, g);
        /// <summary>Gets the <c>arbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arbb => new half4(a, r, b, b);
        /// <summary>Gets the <c>arba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arba => new half4(a, r, b, a);

        /// <summary>Gets the <c>arar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arar => new half4(a, r, a, r);
        /// <summary>Gets the <c>arag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arag => new half4(a, r, a, g);
        /// <summary>Gets the <c>arab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 arab => new half4(a, r, a, b);
        /// <summary>Gets the <c>araa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 araa => new half4(a, r, a, a);

        // ag
        /// <summary>Gets the <c>agrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agrr => new half4(a, g, r, r);
        /// <summary>Gets the <c>agrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agrg => new half4(a, g, r, g);
        /// <summary>Gets the <c>agrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agrb => new half4(a, g, r, b);
        /// <summary>Gets the <c>agra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agra => new half4(a, g, r, a);

        /// <summary>Gets the <c>aggr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aggr => new half4(a, g, g, r);
        /// <summary>Gets the <c>aggg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aggg => new half4(a, g, g, g);
        /// <summary>Gets the <c>aggb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aggb => new half4(a, g, g, b);
        /// <summary>Gets the <c>agga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agga => new half4(a, g, g, a);

        /// <summary>Gets the <c>agbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agbr => new half4(a, g, b, r);
        /// <summary>Gets the <c>agbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agbg => new half4(a, g, b, g);
        /// <summary>Gets the <c>agbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agbb => new half4(a, g, b, b);
        /// <summary>Gets the <c>agba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agba => new half4(a, g, b, a);

        /// <summary>Gets the <c>agar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agar => new half4(a, g, a, r);
        /// <summary>Gets the <c>agag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agag => new half4(a, g, a, g);
        /// <summary>Gets the <c>agab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agab => new half4(a, g, a, b);
        /// <summary>Gets the <c>agaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 agaa => new half4(a, g, a, a);

        // ab
        /// <summary>Gets the <c>abrr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abrr => new half4(a, b, r, r);
        /// <summary>Gets the <c>abrg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abrg => new half4(a, b, r, g);
        /// <summary>Gets the <c>abrb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abrb => new half4(a, b, r, b);
        /// <summary>Gets the <c>abra</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abra => new half4(a, b, r, a);

        /// <summary>Gets the <c>abgr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abgr => new half4(a, b, g, r);
        /// <summary>Gets the <c>abgg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abgg => new half4(a, b, g, g);
        /// <summary>Gets the <c>abgb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abgb => new half4(a, b, g, b);
        /// <summary>Gets the <c>abga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abga => new half4(a, b, g, a);

        /// <summary>Gets the <c>abbr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abbr => new half4(a, b, b, r);
        /// <summary>Gets the <c>abbg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abbg => new half4(a, b, b, g);
        /// <summary>Gets the <c>abbb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abbb => new half4(a, b, b, b);
        /// <summary>Gets the <c>abba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abba => new half4(a, b, b, a);

        /// <summary>Gets the <c>abar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abar => new half4(a, b, a, r);
        /// <summary>Gets the <c>abag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abag => new half4(a, b, a, g);
        /// <summary>Gets the <c>abab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abab => new half4(a, b, a, b);
        /// <summary>Gets the <c>abaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 abaa => new half4(a, b, a, a);

        // aa
        /// <summary>Gets the <c>aarr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aarr => new half4(a, a, r, r);
        /// <summary>Gets the <c>aarg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aarg => new half4(a, a, r, g);
        /// <summary>Gets the <c>aarb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aarb => new half4(a, a, r, b);
        /// <summary>Gets the <c>aara</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aara => new half4(a, a, r, a);

        /// <summary>Gets the <c>aagr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aagr => new half4(a, a, g, r);
        /// <summary>Gets the <c>aagg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aagg => new half4(a, a, g, g);
        /// <summary>Gets the <c>aagb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aagb => new half4(a, a, g, b);
        /// <summary>Gets the <c>aaga</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aaga => new half4(a, a, g, a);

        /// <summary>Gets the <c>aabr</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aabr => new half4(a, a, b, r);
        /// <summary>Gets the <c>aabg</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aabg => new half4(a, a, b, g);
        /// <summary>Gets the <c>aabb</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aabb => new half4(a, a, b, b);
        /// <summary>Gets the <c>aaba</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aaba => new half4(a, a, b, a);

        /// <summary>Gets the <c>aaar</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aaar => new half4(a, a, a, r);
        /// <summary>Gets the <c>aaag</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aaag => new half4(a, a, a, g);
        /// <summary>Gets the <c>aaab</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aaab => new half4(a, a, a, b);
        /// <summary>Gets the <c>aaaa</c> swizzle of the vector as a <see cref="half4"/>.</summary>
        public readonly half4 aaaa => new half4(a, a, a, a);

        #endregion Swizzles_half4_RGBA
        #region Swizzles_Extra

        // Swizzles - half3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xxx => new half3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xxy => new half3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xxz => new half3(x, x, z);
        /// <summary>Gets the <c>xxw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xxw => new half3(x, x, w);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xyx => new half3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xyy => new half3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xyz => new half3(x, y, z);
        /// <summary>Gets the <c>xyw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xyw => new half3(x, y, w);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xzx => new half3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xzy => new half3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xzz => new half3(x, z, z);
        /// <summary>Gets the <c>xzw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xzw => new half3(x, z, w);

        /// <summary>Gets the <c>xwx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xwx => new half3(x, w, x);
        /// <summary>Gets the <c>xwy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xwy => new half3(x, w, y);
        /// <summary>Gets the <c>xwz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xwz => new half3(x, w, z);
        /// <summary>Gets the <c>xww</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 xww => new half3(x, w, w);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yxx => new half3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yxy => new half3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yxz => new half3(y, x, z);
        /// <summary>Gets the <c>yxw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yxw => new half3(y, x, w);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yyx => new half3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yyy => new half3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yyz => new half3(y, y, z);
        /// <summary>Gets the <c>yyw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yyw => new half3(y, y, w);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yzx => new half3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yzy => new half3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yzz => new half3(y, z, z);
        /// <summary>Gets the <c>yzw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yzw => new half3(y, z, w);

        /// <summary>Gets the <c>ywx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ywx => new half3(y, w, x);
        /// <summary>Gets the <c>ywy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ywy => new half3(y, w, y);
        /// <summary>Gets the <c>ywz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ywz => new half3(y, w, z);
        /// <summary>Gets the <c>yww</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 yww => new half3(y, w, w);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zxx => new half3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zxy => new half3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zxz => new half3(z, x, z);
        /// <summary>Gets the <c>zxw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zxw => new half3(z, x, w);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zyx => new half3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zyy => new half3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zyz => new half3(z, y, z);
        /// <summary>Gets the <c>zyw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zyw => new half3(z, y, w);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zzx => new half3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zzy => new half3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zzz => new half3(z, z, z);
        /// <summary>Gets the <c>zzw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zzw => new half3(z, z, w);

        /// <summary>Gets the <c>zwx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zwx => new half3(z, w, x);
        /// <summary>Gets the <c>zwy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zwy => new half3(z, w, y);
        /// <summary>Gets the <c>zwz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zwz => new half3(z, w, z);
        /// <summary>Gets the <c>zww</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 zww => new half3(z, w, w);

        // w
        /// <summary>Gets the <c>wxx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wxx => new half3(w, x, x);
        /// <summary>Gets the <c>wxy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wxy => new half3(w, x, y);
        /// <summary>Gets the <c>wxz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wxz => new half3(w, x, z);
        /// <summary>Gets the <c>wxw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wxw => new half3(w, x, w);

        /// <summary>Gets the <c>wyx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wyx => new half3(w, y, x);
        /// <summary>Gets the <c>wyy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wyy => new half3(w, y, y);
        /// <summary>Gets the <c>wyz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wyz => new half3(w, y, z);
        /// <summary>Gets the <c>wyw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wyw => new half3(w, y, w);

        /// <summary>Gets the <c>wzx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wzx => new half3(w, z, x);
        /// <summary>Gets the <c>wzy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wzy => new half3(w, z, y);
        /// <summary>Gets the <c>wzz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wzz => new half3(w, z, z);
        /// <summary>Gets the <c>wzw</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wzw => new half3(w, z, w);

        /// <summary>Gets the <c>wwx</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wwx => new half3(w, w, x);
        /// <summary>Gets the <c>wwy</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wwy => new half3(w, w, y);
        /// <summary>Gets the <c>wwz</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 wwz => new half3(w, w, z);
        /// <summary>Gets the <c>www</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 www => new half3(w, w, w);

        // Swizzles - half2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 xx => new half2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 xy => new half2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 xz => new half2(x, z);
        /// <summary>Gets the <c>xw</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 xw => new half2(x, w);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 yx => new half2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 yy => new half2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 yz => new half2(y, z);
        /// <summary>Gets the <c>yw</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 yw => new half2(y, w);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 zx => new half2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 zy => new half2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 zz => new half2(z, z);
        /// <summary>Gets the <c>zw</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 zw => new half2(z, w);

        /// <summary>Gets the <c>wx</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 wx => new half2(w, x);
        /// <summary>Gets the <c>wy</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 wy => new half2(w, y);
        /// <summary>Gets the <c>wz</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 wz => new half2(w, z);
        /// <summary>Gets the <c>ww</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 ww => new half2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - half3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rrr => new half3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rrg => new half3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rrb => new half3(r, r, b);
        /// <summary>Gets the <c>rra</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rra => new half3(r, r, a);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rgr => new half3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rgg => new half3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rgb => new half3(r, g, b);
        /// <summary>Gets the <c>rga</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rga => new half3(r, g, a);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rbr => new half3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rbg => new half3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rbb => new half3(r, b, b);
        /// <summary>Gets the <c>rba</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rba => new half3(r, b, a);

        /// <summary>Gets the <c>rar</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rar => new half3(r, a, r);
        /// <summary>Gets the <c>rag</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rag => new half3(r, a, g);
        /// <summary>Gets the <c>rab</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 rab => new half3(r, a, b);
        /// <summary>Gets the <c>raa</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 raa => new half3(r, a, a);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 grr => new half3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 grg => new half3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 grb => new half3(g, r, b);
        /// <summary>Gets the <c>gra</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gra => new half3(g, r, a);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ggr => new half3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ggg => new half3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ggb => new half3(g, g, b);
        /// <summary>Gets the <c>gga</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gga => new half3(g, g, a);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gbr => new half3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gbg => new half3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gbb => new half3(g, b, b);
        /// <summary>Gets the <c>gba</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gba => new half3(g, b, a);

        /// <summary>Gets the <c>gar</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gar => new half3(g, a, r);
        /// <summary>Gets the <c>gag</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gag => new half3(g, a, g);
        /// <summary>Gets the <c>gab</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gab => new half3(g, a, b);
        /// <summary>Gets the <c>gaa</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 gaa => new half3(g, a, a);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 brr => new half3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 brg => new half3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 brb => new half3(b, r, b);
        /// <summary>Gets the <c>bra</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bra => new half3(b, r, a);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bgr => new half3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bgg => new half3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bgb => new half3(b, g, b);
        /// <summary>Gets the <c>bga</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bga => new half3(b, g, a);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bbr => new half3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bbg => new half3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bbb => new half3(b, b, b);
        /// <summary>Gets the <c>bba</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bba => new half3(b, b, a);

        /// <summary>Gets the <c>bar</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bar => new half3(b, a, r);
        /// <summary>Gets the <c>bag</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bag => new half3(b, a, g);
        /// <summary>Gets the <c>bab</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 bab => new half3(b, a, b);
        /// <summary>Gets the <c>baa</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 baa => new half3(b, a, a);

        // a
        /// <summary>Gets the <c>arr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 arr => new half3(a, r, r);
        /// <summary>Gets the <c>arg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 arg => new half3(a, r, g);
        /// <summary>Gets the <c>arb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 arb => new half3(a, r, b);
        /// <summary>Gets the <c>ara</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 ara => new half3(a, r, a);

        /// <summary>Gets the <c>agr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 agr => new half3(a, g, r);
        /// <summary>Gets the <c>agg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 agg => new half3(a, g, g);
        /// <summary>Gets the <c>agb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 agb => new half3(a, g, b);
        /// <summary>Gets the <c>aga</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 aga => new half3(a, g, a);

        /// <summary>Gets the <c>abr</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 abr => new half3(a, b, r);
        /// <summary>Gets the <c>abg</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 abg => new half3(a, b, g);
        /// <summary>Gets the <c>abb</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 abb => new half3(a, b, b);
        /// <summary>Gets the <c>aba</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 aba => new half3(a, b, a);

        /// <summary>Gets the <c>aar</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 aar => new half3(a, a, r);
        /// <summary>Gets the <c>aag</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 aag => new half3(a, a, g);
        /// <summary>Gets the <c>aab</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 aab => new half3(a, a, b);
        /// <summary>Gets the <c>aaa</c> swizzle of the vector as a <see cref="half3"/>.</summary>
        public readonly half3 aaa => new half3(a, a, a);

        // RGBA - Swizzles - half2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 rr => new half2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 rg => new half2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 rb => new half2(r, b);
        /// <summary>Gets the <c>ra</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 ra => new half2(r, a);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 gr => new half2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 gg => new half2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 gb => new half2(g, b);
        /// <summary>Gets the <c>ga</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 ga => new half2(g, a);

        /// <summary>Gets the <c>br</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 br => new half2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 bg => new half2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 bb => new half2(b, b);
        /// <summary>Gets the <c>ba</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 ba => new half2(b, a);

        /// <summary>Gets the <c>ar</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 ar => new half2(a, r);
        /// <summary>Gets the <c>ag</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 ag => new half2(a, g);
        /// <summary>Gets the <c>ab</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 ab => new half2(a, b);
        /// <summary>Gets the <c>aa</c> swizzle of the vector as a <see cref="half2"/>.</summary>
        public readonly half2 aa => new half2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
