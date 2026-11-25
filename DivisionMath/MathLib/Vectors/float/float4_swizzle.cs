//
// Copyright (c) 2026 Rex Woodfield and DivisionMath contributors
//
// This file is part of DivisionMath and is subject to the terms
// of the DivisionMath License. See the LICENSE.txt file in the
// project root for full license terms.
//
namespace DivisionEngine.MathLib
{
    public partial struct float4
    {
        #region Swizzles_float4

        // Swizzles - float4

        // x
        // xx
        /// <summary>Gets the <c>xxxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxxx => new float4(x, x, x, x);
        /// <summary>Gets the <c>xxxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxxy => new float4(x, x, x, y);
        /// <summary>Gets the <c>xxxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxxz => new float4(x, x, x, z);
        /// <summary>Gets the <c>xxxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxxw => new float4(x, x, x, w);

        /// <summary>Gets the <c>xxyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxyx => new float4(x, x, y, x);
        /// <summary>Gets the <c>xxyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxyy => new float4(x, x, y, y);
        /// <summary>Gets the <c>xxyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxyz => new float4(x, x, y, z);
        /// <summary>Gets the <c>xxyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxyw => new float4(x, x, y, w);

        /// <summary>Gets the <c>xxzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxzx => new float4(x, x, z, x);
        /// <summary>Gets the <c>xxzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxzy => new float4(x, x, z, y);
        /// <summary>Gets the <c>xxzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxzz => new float4(x, x, z, z);
        /// <summary>Gets the <c>xxzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxzw => new float4(x, x, z, w);

        /// <summary>Gets the <c>xxwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxwx => new float4(x, x, w, x);
        /// <summary>Gets the <c>xxwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxwy => new float4(x, x, w, y);
        /// <summary>Gets the <c>xxwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxwz => new float4(x, x, w, z);
        /// <summary>Gets the <c>xxww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xxww => new float4(x, x, w, w);

        // xy
        /// <summary>Gets the <c>xyxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyxx => new float4(x, y, x, x);
        /// <summary>Gets the <c>xyxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyxy => new float4(x, y, x, y);
        /// <summary>Gets the <c>xyxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyxz => new float4(x, y, x, z);
        /// <summary>Gets the <c>xyxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyxw => new float4(x, y, x, w);

        /// <summary>Gets the <c>xyyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyyx => new float4(x, y, y, x);
        /// <summary>Gets the <c>xyyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyyy => new float4(x, y, y, y);
        /// <summary>Gets the <c>xyyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyyz => new float4(x, y, y, z);
        /// <summary>Gets the <c>xyyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyyw => new float4(x, y, y, w);

        /// <summary>Gets the <c>xyzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyzx => new float4(x, y, z, x);
        /// <summary>Gets the <c>xyzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyzy => new float4(x, y, z, y);
        /// <summary>Gets the <c>xyzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyzz => new float4(x, y, z, z);
        /// <summary>Gets the <c>xyzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyzw => new float4(x, y, z, w);

        /// <summary>Gets the <c>xywx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xywx => new float4(x, y, w, x);
        /// <summary>Gets the <c>xywy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xywy => new float4(x, y, w, y);
        /// <summary>Gets the <c>xywz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xywz => new float4(x, y, w, z);
        /// <summary>Gets the <c>xyww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xyww => new float4(x, y, w, w);

        // xz
        /// <summary>Gets the <c>xzxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzxx => new float4(x, z, x, x);
        /// <summary>Gets the <c>xzxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzxy => new float4(x, z, x, y);
        /// <summary>Gets the <c>xzxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzxz => new float4(x, z, x, z);
        /// <summary>Gets the <c>xzxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzxw => new float4(x, z, x, w);

        /// <summary>Gets the <c>xzyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzyx => new float4(x, z, y, x);
        /// <summary>Gets the <c>xzyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzyy => new float4(x, z, y, y);
        /// <summary>Gets the <c>xzyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzyz => new float4(x, z, y, z);
        /// <summary>Gets the <c>xzyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzyw => new float4(x, z, y, w);

        /// <summary>Gets the <c>xzzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzzx => new float4(x, z, z, x);
        /// <summary>Gets the <c>xzzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzzy => new float4(x, z, z, y);
        /// <summary>Gets the <c>xzzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzzz => new float4(x, z, z, z);
        /// <summary>Gets the <c>xzzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzzw => new float4(x, z, z, w);

        /// <summary>Gets the <c>xzwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzwx => new float4(x, z, w, x);
        /// <summary>Gets the <c>xzwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzwy => new float4(x, z, w, y);
        /// <summary>Gets the <c>xzwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzwz => new float4(x, z, w, z);
        /// <summary>Gets the <c>xzww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xzww => new float4(x, z, w, w);

        // xw
        /// <summary>Gets the <c>xwxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwxx => new float4(x, w, x, x);
        /// <summary>Gets the <c>xwxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwxy => new float4(x, w, x, y);
        /// <summary>Gets the <c>xwxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwxz => new float4(x, w, x, z);
        /// <summary>Gets the <c>xwxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwxw => new float4(x, w, x, w);

        /// <summary>Gets the <c>xwyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwyx => new float4(x, w, y, x);
        /// <summary>Gets the <c>xwyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwyy => new float4(x, w, y, y);
        /// <summary>Gets the <c>xwyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwyz => new float4(x, w, y, z);
        /// <summary>Gets the <c>xwyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwyw => new float4(x, w, y, w);
        
        /// <summary>Gets the <c>xwzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwzx => new float4(x, w, z, x);
        /// <summary>Gets the <c>xwzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwzy => new float4(x, w, z, y);
        /// <summary>Gets the <c>xwzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwzz => new float4(x, w, z, z);
        /// <summary>Gets the <c>xwzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwzw => new float4(x, w, z, w);

        /// <summary>Gets the <c>xwwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwwx => new float4(x, w, w, x);
        /// <summary>Gets the <c>xwwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwwy => new float4(x, w, w, y);
        /// <summary>Gets the <c>xwwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwwz => new float4(x, w, w, z);
        /// <summary>Gets the <c>xwww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 xwww => new float4(x, w, w, w);


        // y
        // yx
        /// <summary>Gets the <c>yxxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxxx => new float4(y, x, x, x);
        /// <summary>Gets the <c>yxxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxxy => new float4(y, x, x, y);
        /// <summary>Gets the <c>yxxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxxz => new float4(y, x, x, z);
        /// <summary>Gets the <c>yxxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxxw => new float4(y, x, x, w);
        
        /// <summary>Gets the <c>yxyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxyx => new float4(y, x, y, x);
        /// <summary>Gets the <c>yxyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxyy => new float4(y, x, y, y);
        /// <summary>Gets the <c>yxyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxyz => new float4(y, x, y, z);
        /// <summary>Gets the <c>yxyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxyw => new float4(y, x, y, w);

        /// <summary>Gets the <c>yxzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxzx => new float4(y, x, z, x);
        /// <summary>Gets the <c>yxzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxzy => new float4(y, x, z, y);
        /// <summary>Gets the <c>yxzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxzz => new float4(y, x, z, z);
        /// <summary>Gets the <c>yxzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxzw => new float4(y, x, z, w);

        /// <summary>Gets the <c>yxwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxwx => new float4(y, x, w, x);
        /// <summary>Gets the <c>yxwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxwy => new float4(y, x, w, y);
        /// <summary>Gets the <c>yxwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxwz => new float4(y, x, w, z);
        /// <summary>Gets the <c>yxww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yxww => new float4(y, x, w, w);

        // yy
        /// <summary>Gets the <c>yyxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyxx => new float4(y, y, x, x);
        /// <summary>Gets the <c>yyxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyxy => new float4(y, y, x, y);
        /// <summary>Gets the <c>yyxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyxz => new float4(y, y, x, z);
        /// <summary>Gets the <c>yyxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyxw => new float4(y, y, x, w);

        /// <summary>Gets the <c>yyyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyyx => new float4(y, y, y, x);
        /// <summary>Gets the <c>yyyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyyy => new float4(y, y, y, y);
        /// <summary>Gets the <c>yyyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyyz => new float4(y, y, y, z);
        /// <summary>Gets the <c>yyyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyyw => new float4(y, y, y, w);

        /// <summary>Gets the <c>yyzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyzx => new float4(y, y, z, x);
        /// <summary>Gets the <c>yyzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyzy => new float4(y, y, z, y);
        /// <summary>Gets the <c>yyzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyzz => new float4(y, y, z, z);
        /// <summary>Gets the <c>yyzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyzw => new float4(y, y, z, w);

        /// <summary>Gets the <c>yywx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yywx => new float4(y, y, w, x);
        /// <summary>Gets the <c>yywy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yywy => new float4(y, y, w, y);
        /// <summary>Gets the <c>yywz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yywz => new float4(y, y, w, z);
        /// <summary>Gets the <c>yyww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yyww => new float4(y, y, w, w);
        
        // yz
        /// <summary>Gets the <c>yzxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzxx => new float4(y, z, x, x);
        /// <summary>Gets the <c>yzxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzxy => new float4(y, z, x, y);
        /// <summary>Gets the <c>yzxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzxz => new float4(y, z, x, z);
        /// <summary>Gets the <c>yzxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzxw => new float4(y, z, x, w);

        /// <summary>Gets the <c>yzyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzyx => new float4(y, z, y, x);
        /// <summary>Gets the <c>yzyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzyy => new float4(y, z, y, y);
        /// <summary>Gets the <c>yzyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzyz => new float4(y, z, y, z);
        /// <summary>Gets the <c>yzyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzyw => new float4(y, z, y, w);

        /// <summary>Gets the <c>yzzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzzx => new float4(y, z, z, x);
        /// <summary>Gets the <c>yzzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzzy => new float4(y, z, z, y);
        /// <summary>Gets the <c>yzzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzzz => new float4(y, z, z, z);
        /// <summary>Gets the <c>yzzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzzw => new float4(y, z, z, w);

        /// <summary>Gets the <c>yzwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzwx => new float4(y, z, w, x);
        /// <summary>Gets the <c>yzwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzwy => new float4(y, z, w, y);
        /// <summary>Gets the <c>yzwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzwz => new float4(y, z, w, z);
        /// <summary>Gets the <c>yzww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 yzww => new float4(y, z, w, w);

        // yw
        /// <summary>Gets the <c>ywxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywxx => new float4(y, w, x, x);
        /// <summary>Gets the <c>ywxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywxy => new float4(y, w, x, y);
        /// <summary>Gets the <c>ywxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywxz => new float4(y, w, x, z);
        /// <summary>Gets the <c>ywxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywxw => new float4(y, w, x, w);
        
        /// <summary>Gets the <c>ywyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywyx => new float4(y, w, y, x);
        /// <summary>Gets the <c>ywyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywyy => new float4(y, w, y, y);
        /// <summary>Gets the <c>ywyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywyz => new float4(y, w, y, z);
        /// <summary>Gets the <c>ywyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywyw => new float4(y, w, y, w);
        
        /// <summary>Gets the <c>ywzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywzx => new float4(y, w, z, x);
        /// <summary>Gets the <c>ywzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywzy => new float4(y, w, z, y);
        /// <summary>Gets the <c>ywzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywzz => new float4(y, w, z, z);
        /// <summary>Gets the <c>ywzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywzw => new float4(y, w, z, w);

        /// <summary>Gets the <c>ywwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywwx => new float4(y, w, w, x);
        /// <summary>Gets the <c>ywwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywwy => new float4(y, w, w, y);
        /// <summary>Gets the <c>ywwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywwz => new float4(y, w, w, z);
        /// <summary>Gets the <c>ywww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ywww => new float4(y, w, w, w);


        // z
        // zx
        /// <summary>Gets the <c>zxxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxxx => new float4(z, x, x, x);
        /// <summary>Gets the <c>zxxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxxy => new float4(z, x, x, y);
        /// <summary>Gets the <c>zxxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxxz => new float4(z, x, x, z);
        /// <summary>Gets the <c>zxxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxxw => new float4(z, x, x, w);
        
        /// <summary>Gets the <c>zxyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxyx => new float4(z, x, y, x);
        /// <summary>Gets the <c>zxyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxyy => new float4(z, x, y, y);
        /// <summary>Gets the <c>zxyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxyz => new float4(z, x, y, z);
        /// <summary>Gets the <c>zxyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxyw => new float4(z, x, y, w);

        /// <summary>Gets the <c>zxzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxzx => new float4(z, x, z, x);
        /// <summary>Gets the <c>zxzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxzy => new float4(z, x, z, y);
        /// <summary>Gets the <c>zxzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxzz => new float4(z, x, z, z);
        /// <summary>Gets the <c>zxzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxzw => new float4(z, x, z, w);

        /// <summary>Gets the <c>zxwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxwx => new float4(z, x, w, x);
        /// <summary>Gets the <c>zxwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxwy => new float4(z, x, w, y);
        /// <summary>Gets the <c>zxwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxwz => new float4(z, x, w, z);
        /// <summary>Gets the <c>zxww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zxww => new float4(z, x, w, w);

        // zy
        /// <summary>Gets the <c>zyxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyxx => new float4(z, y, x, x);
        /// <summary>Gets the <c>zyxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyxy => new float4(z, y, x, y);
        /// <summary>Gets the <c>zyxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyxz => new float4(z, y, x, z);
        /// <summary>Gets the <c>zyxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyxw => new float4(z, y, x, w);

        /// <summary>Gets the <c>zyyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyyx => new float4(z, y, y, x);
        /// <summary>Gets the <c>zyyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyyy => new float4(z, y, y, y);
        /// <summary>Gets the <c>zyyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyyz => new float4(z, y, y, z);
        /// <summary>Gets the <c>zyyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyyw => new float4(z, y, y, w);

        /// <summary>Gets the <c>zyzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyzx => new float4(z, y, z, x);
        /// <summary>Gets the <c>zyzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyzy => new float4(z, y, z, y);
        /// <summary>Gets the <c>zyzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyzz => new float4(z, y, z, z);
        /// <summary>Gets the <c>zyzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyzw => new float4(z, y, z, w);

        /// <summary>Gets the <c>zywx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zywx => new float4(z, y, w, x);
        /// <summary>Gets the <c>zywy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zywy => new float4(z, y, w, y);
        /// <summary>Gets the <c>zywz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zywz => new float4(z, y, w, z);
        /// <summary>Gets the <c>zyww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zyww => new float4(z, y, w, w);
        
        // zz
        /// <summary>Gets the <c>zzxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzxx => new float4(z, z, x, x);
        /// <summary>Gets the <c>zzxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzxy => new float4(z, z, x, y);
        /// <summary>Gets the <c>zzxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzxz => new float4(z, z, x, z);
        /// <summary>Gets the <c>zzxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzxw => new float4(z, z, x, w);

        /// <summary>Gets the <c>zzyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzyx => new float4(z, z, y, x);
        /// <summary>Gets the <c>zzyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzyy => new float4(z, z, y, y);
        /// <summary>Gets the <c>zzyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzyz => new float4(z, z, y, z);
        /// <summary>Gets the <c>zzyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzyw => new float4(z, z, y, w);

        /// <summary>Gets the <c>zzzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzzx => new float4(z, z, z, x);
        /// <summary>Gets the <c>zzzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzzy => new float4(z, z, z, y);
        /// <summary>Gets the <c>zzzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzzz => new float4(z, z, z, z);
        /// <summary>Gets the <c>zzzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzzw => new float4(z, z, z, w);

        /// <summary>Gets the <c>zzwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzwx => new float4(z, z, w, x);
        /// <summary>Gets the <c>zzwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzwy => new float4(z, z, w, y);
        /// <summary>Gets the <c>zzwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzwz => new float4(z, z, w, z);
        /// <summary>Gets the <c>zzww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zzww => new float4(z, z, w, w);

        // zw
        /// <summary>Gets the <c>zwxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwxx => new float4(z, w, x, x);
        /// <summary>Gets the <c>zwxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwxy => new float4(z, w, x, y);
        /// <summary>Gets the <c>zwxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwxz => new float4(z, w, x, z);
        /// <summary>Gets the <c>zwxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwxw => new float4(z, w, x, w);
        
        /// <summary>Gets the <c>zwyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwyx => new float4(z, w, y, x);
        /// <summary>Gets the <c>zwyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwyy => new float4(z, w, y, y);
        /// <summary>Gets the <c>zwyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwyz => new float4(z, w, y, z);
        /// <summary>Gets the <c>zwyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwyw => new float4(z, w, y, w);
        
        /// <summary>Gets the <c>zwzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwzx => new float4(z, w, z, x);
        /// <summary>Gets the <c>zwzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwzy => new float4(z, w, z, y);
        /// <summary>Gets the <c>zwzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwzz => new float4(z, w, z, z);
        /// <summary>Gets the <c>zwzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwzw => new float4(z, w, z, w);

        /// <summary>Gets the <c>zwwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwwx => new float4(z, w, w, x);
        /// <summary>Gets the <c>zwwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwwy => new float4(z, w, w, y);
        /// <summary>Gets the <c>zwwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwwz => new float4(z, w, w, z);
        /// <summary>Gets the <c>zwww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 zwww => new float4(z, w, w, w);


        // w
        // wx
        /// <summary>Gets the <c>wxxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxxx => new float4(w, x, x, x);
        /// <summary>Gets the <c>wxxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxxy => new float4(w, x, x, y);
        /// <summary>Gets the <c>wxxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxxz => new float4(w, x, x, z);
        /// <summary>Gets the <c>wxxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxxw => new float4(w, x, x, w);
        
        /// <summary>Gets the <c>wxyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxyx => new float4(w, x, y, x);
        /// <summary>Gets the <c>wxyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxyy => new float4(w, x, y, y);
        /// <summary>Gets the <c>wxyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxyz => new float4(w, x, y, z);
        /// <summary>Gets the <c>wxyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxyw => new float4(w, x, y, w);

        /// <summary>Gets the <c>wxzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxzx => new float4(w, x, z, x);
        /// <summary>Gets the <c>wxzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxzy => new float4(w, x, z, y);
        /// <summary>Gets the <c>wxzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxzz => new float4(w, x, z, z);
        /// <summary>Gets the <c>wxzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxzw => new float4(w, x, z, w);

        /// <summary>Gets the <c>wxwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxwx => new float4(w, x, w, x);
        /// <summary>Gets the <c>wxwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxwy => new float4(w, x, w, y);
        /// <summary>Gets the <c>wxwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxwz => new float4(w, x, w, z);
        /// <summary>Gets the <c>wxww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wxww => new float4(w, x, w, w);

        // wy
        /// <summary>Gets the <c>wyxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyxx => new float4(w, y, x, x);
        /// <summary>Gets the <c>wyxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyxy => new float4(w, y, x, y);
        /// <summary>Gets the <c>wyxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyxz => new float4(w, y, x, z);
        /// <summary>Gets the <c>wyxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyxw => new float4(w, y, x, w);

        /// <summary>Gets the <c>wyyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyyx => new float4(w, y, y, x);
        /// <summary>Gets the <c>wyyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyyy => new float4(w, y, y, y);
        /// <summary>Gets the <c>wyyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyyz => new float4(w, y, y, z);
        /// <summary>Gets the <c>wyyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyyw => new float4(w, y, y, w);

        /// <summary>Gets the <c>wyzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyzx => new float4(w, y, z, x);
        /// <summary>Gets the <c>wyzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyzy => new float4(w, y, z, y);
        /// <summary>Gets the <c>wyzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyzz => new float4(w, y, z, z);
        /// <summary>Gets the <c>wyzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyzw => new float4(w, y, z, w);

        /// <summary>Gets the <c>wywx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wywx => new float4(w, y, w, x);
        /// <summary>Gets the <c>wywy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wywy => new float4(w, y, w, y);
        /// <summary>Gets the <c>wywz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wywz => new float4(w, y, w, z);
        /// <summary>Gets the <c>wyww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wyww => new float4(w, y, w, w);
        
        // wz
        /// <summary>Gets the <c>wzxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzxx => new float4(w, z, x, x);
        /// <summary>Gets the <c>wzxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzxy => new float4(w, z, x, y);
        /// <summary>Gets the <c>wzxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzxz => new float4(w, z, x, z);
        /// <summary>Gets the <c>wzxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzxw => new float4(w, z, x, w);

        /// <summary>Gets the <c>wzyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzyx => new float4(w, z, y, x);
        /// <summary>Gets the <c>wzyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzyy => new float4(w, z, y, y);
        /// <summary>Gets the <c>wzyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzyz => new float4(w, z, y, z);
        /// <summary>Gets the <c>wzyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzyw => new float4(w, z, y, w);

        /// <summary>Gets the <c>wzzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzzx => new float4(w, z, z, x);
        /// <summary>Gets the <c>wzzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzzy => new float4(w, z, z, y);
        /// <summary>Gets the <c>wzzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzzz => new float4(w, z, z, z);
        /// <summary>Gets the <c>wzzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzzw => new float4(w, z, z, w);

        /// <summary>Gets the <c>wzwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzwx => new float4(w, z, w, x);
        /// <summary>Gets the <c>wzwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzwy => new float4(w, z, w, y);
        /// <summary>Gets the <c>wzwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzwz => new float4(w, z, w, z);
        /// <summary>Gets the <c>wzww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wzww => new float4(w, z, w, w);

        // ww
        /// <summary>Gets the <c>wwxx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwxx => new float4(w, w, x, x);
        /// <summary>Gets the <c>wwxy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwxy => new float4(w, w, x, y);
        /// <summary>Gets the <c>wwxz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwxz => new float4(w, w, x, z);
        /// <summary>Gets the <c>wwxw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwxw => new float4(w, w, x, w);
        
        /// <summary>Gets the <c>wwyx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwyx => new float4(w, w, y, x);
        /// <summary>Gets the <c>wwyy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwyy => new float4(w, w, y, y);
        /// <summary>Gets the <c>wwyz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwyz => new float4(w, w, y, z);
        /// <summary>Gets the <c>wwyw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwyw => new float4(w, w, y, w);
        
        /// <summary>Gets the <c>wwzx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwzx => new float4(w, w, z, x);
        /// <summary>Gets the <c>wwzy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwzy => new float4(w, w, z, y);
        /// <summary>Gets the <c>wwzz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwzz => new float4(w, w, z, z);
        /// <summary>Gets the <c>wwzw</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwzw => new float4(w, w, z, w);

        /// <summary>Gets the <c>wwwx</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwwx => new float4(w, w, w, x);
        /// <summary>Gets the <c>wwwy</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwwy => new float4(w, w, w, y);
        /// <summary>Gets the <c>wwwz</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwwz => new float4(w, w, w, z);
        /// <summary>Gets the <c>wwww</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 wwww => new float4(w, w, w, w);

        #endregion Swizzles_float4
        #region Swizzles_float4_RGBA

        // RGBA - Swizzles - float4

        // r
        // rr
        /// <summary>Gets the <c>rrrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrrr => new float4(r, r, r, r);
        /// <summary>Gets the <c>rrrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrrg => new float4(r, r, r, g);
        /// <summary>Gets the <c>rrrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrrb => new float4(r, r, r, b);
        /// <summary>Gets the <c>rrra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrra => new float4(r, r, r, a);

        /// <summary>Gets the <c>rrgr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrgr => new float4(r, r, g, r);
        /// <summary>Gets the <c>rrgg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrgg => new float4(r, r, g, g);
        /// <summary>Gets the <c>rrgb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrgb => new float4(r, r, g, b);
        /// <summary>Gets the <c>rrga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrga => new float4(r, r, g, a);

        /// <summary>Gets the <c>rrbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrbr => new float4(r, r, b, r);
        /// <summary>Gets the <c>rrbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrbg => new float4(r, r, b, g);
        /// <summary>Gets the <c>rrbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrbb => new float4(r, r, b, b);
        /// <summary>Gets the <c>rrba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrba => new float4(r, r, b, a);

        /// <summary>Gets the <c>rrar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrar => new float4(r, r, a, r);
        /// <summary>Gets the <c>rrag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrag => new float4(r, r, a, g);
        /// <summary>Gets the <c>rrab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rrab => new float4(r, r, a, b);
        /// <summary>Gets the <c>rraa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rraa => new float4(r, r, a, a);

        // rg
        /// <summary>Gets the <c>rgrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgrr => new float4(r, g, r, r);
        /// <summary>Gets the <c>rgrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgrg => new float4(r, g, r, g);
        /// <summary>Gets the <c>rgrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgrb => new float4(r, g, r, b);
        /// <summary>Gets the <c>rgra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgra => new float4(r, g, r, a);

        /// <summary>Gets the <c>rggr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rggr => new float4(r, g, g, r);
        /// <summary>Gets the <c>rggg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rggg => new float4(r, g, g, g);
        /// <summary>Gets the <c>rggb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rggb => new float4(r, g, g, b);
        /// <summary>Gets the <c>rgga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgga => new float4(r, g, g, a);

        /// <summary>Gets the <c>rgbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgbr => new float4(r, g, b, r);
        /// <summary>Gets the <c>rgbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgbg => new float4(r, g, b, g);
        /// <summary>Gets the <c>rgbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgbb => new float4(r, g, b, b);
        /// <summary>Gets the <c>rgba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgba => new float4(r, g, b, a);

        /// <summary>Gets the <c>rgar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgar => new float4(r, g, a, r);
        /// <summary>Gets the <c>rgag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgag => new float4(r, g, a, g);
        /// <summary>Gets the <c>rgab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgab => new float4(r, g, a, b);
        /// <summary>Gets the <c>rgaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rgaa => new float4(r, g, a, a);

        // rb
        /// <summary>Gets the <c>rbrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbrr => new float4(r, b, r, r);
        /// <summary>Gets the <c>rbrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbrg => new float4(r, b, r, g);
        /// <summary>Gets the <c>rbrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbrb => new float4(r, b, r, b);
        /// <summary>Gets the <c>rbra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbra => new float4(r, b, r, a);

        /// <summary>Gets the <c>rbgr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbgr => new float4(r, b, g, r);
        /// <summary>Gets the <c>rbgg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbgg => new float4(r, b, g, g);
        /// <summary>Gets the <c>rbgb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbgb => new float4(r, b, g, b);
        /// <summary>Gets the <c>rbga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbga => new float4(r, b, g, a);

        /// <summary>Gets the <c>rbbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbbr => new float4(r, b, b, r);
        /// <summary>Gets the <c>rbbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbbg => new float4(r, b, b, g);
        /// <summary>Gets the <c>rbbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbbb => new float4(r, b, b, b);
        /// <summary>Gets the <c>rbba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbba => new float4(r, b, b, a);

        /// <summary>Gets the <c>rbar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbar => new float4(r, b, a, r);
        /// <summary>Gets the <c>rbag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbag => new float4(r, b, a, g);
        /// <summary>Gets the <c>rbab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbab => new float4(r, b, a, b);
        /// <summary>Gets the <c>rbaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rbaa => new float4(r, b, a, a);

        // ra
        /// <summary>Gets the <c>rarr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rarr => new float4(r, a, r, r);
        /// <summary>Gets the <c>rarg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rarg => new float4(r, a, r, g);
        /// <summary>Gets the <c>rarb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rarb => new float4(r, a, r, b);
        /// <summary>Gets the <c>rara</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rara => new float4(r, a, r, a);

        /// <summary>Gets the <c>ragr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ragr => new float4(r, a, g, r);
        /// <summary>Gets the <c>ragg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ragg => new float4(r, a, g, g);
        /// <summary>Gets the <c>ragb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ragb => new float4(r, a, g, b);
        /// <summary>Gets the <c>raga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 raga => new float4(r, a, g, a);

        /// <summary>Gets the <c>rabr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rabr => new float4(r, a, b, r);
        /// <summary>Gets the <c>rabg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rabg => new float4(r, a, b, g);
        /// <summary>Gets the <c>rabb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 rabb => new float4(r, a, b, b);
        /// <summary>Gets the <c>raba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 raba => new float4(r, a, b, a);

        /// <summary>Gets the <c>raar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 raar => new float4(r, a, a, r);
        /// <summary>Gets the <c>raag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 raag => new float4(r, a, a, g);
        /// <summary>Gets the <c>raab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 raab => new float4(r, a, a, b);
        /// <summary>Gets the <c>raaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 raaa => new float4(r, a, a, a);


        // g
        // gr
        /// <summary>Gets the <c>grrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grrr => new float4(g, r, r, r);
        /// <summary>Gets the <c>grrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grrg => new float4(g, r, r, g);
        /// <summary>Gets the <c>grrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grrb => new float4(g, r, r, b);
        /// <summary>Gets the <c>grra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grra => new float4(g, r, r, a);

        /// <summary>Gets the <c>grgr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grgr => new float4(g, r, g, r);
        /// <summary>Gets the <c>grgg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grgg => new float4(g, r, g, g);
        /// <summary>Gets the <c>grgb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grgb => new float4(g, r, g, b);
        /// <summary>Gets the <c>grga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grga => new float4(g, r, g, a);

        /// <summary>Gets the <c>grbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grbr => new float4(g, r, b, r);
        /// <summary>Gets the <c>grbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grbg => new float4(g, r, b, g);
        /// <summary>Gets the <c>grbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grbb => new float4(g, r, b, b);
        /// <summary>Gets the <c>grba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grba => new float4(g, r, b, a);

        /// <summary>Gets the <c>grar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grar => new float4(g, r, a, r);
        /// <summary>Gets the <c>grag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grag => new float4(g, r, a, g);
        /// <summary>Gets the <c>grab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 grab => new float4(g, r, a, b);
        /// <summary>Gets the <c>graa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 graa => new float4(g, r, a, a);

        // gg
        /// <summary>Gets the <c>ggrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggrr => new float4(g, g, r, r);
        /// <summary>Gets the <c>ggrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggrg => new float4(g, g, r, g);
        /// <summary>Gets the <c>ggrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggrb => new float4(g, g, r, b);
        /// <summary>Gets the <c>ggra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggra => new float4(g, g, r, a);

        /// <summary>Gets the <c>gggr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gggr => new float4(g, g, g, r);
        /// <summary>Gets the <c>gggg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gggg => new float4(g, g, g, g);
        /// <summary>Gets the <c>gggb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gggb => new float4(g, g, g, b);
        /// <summary>Gets the <c>ggga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggga => new float4(g, g, g, a);

        /// <summary>Gets the <c>ggbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggbr => new float4(g, g, b, r);
        /// <summary>Gets the <c>ggbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggbg => new float4(g, g, b, g);
        /// <summary>Gets the <c>ggbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggbb => new float4(g, g, b, b);
        /// <summary>Gets the <c>ggba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggba => new float4(g, g, b, a);

        /// <summary>Gets the <c>ggar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggar => new float4(g, g, a, r);
        /// <summary>Gets the <c>ggag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggag => new float4(g, g, a, g);
        /// <summary>Gets the <c>ggab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggab => new float4(g, g, a, b);
        /// <summary>Gets the <c>ggaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 ggaa => new float4(g, g, a, a);

        // gb
        /// <summary>Gets the <c>gbrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbrr => new float4(g, b, r, r);
        /// <summary>Gets the <c>gbrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbrg => new float4(g, b, r, g);
        /// <summary>Gets the <c>gbrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbrb => new float4(g, b, r, b);
        /// <summary>Gets the <c>gbra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbra => new float4(g, b, r, a);

        /// <summary>Gets the <c>gbgr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbgr => new float4(g, b, g, r);
        /// <summary>Gets the <c>gbgg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbgg => new float4(g, b, g, g);
        /// <summary>Gets the <c>gbgb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbgb => new float4(g, b, g, b);
        /// <summary>Gets the <c>gbga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbga => new float4(g, b, g, a);

        /// <summary>Gets the <c>gbbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbbr => new float4(g, b, b, r);
        /// <summary>Gets the <c>gbbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbbg => new float4(g, b, b, g);
        /// <summary>Gets the <c>gbbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbbb => new float4(g, b, b, b);
        /// <summary>Gets the <c>gbba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbba => new float4(g, b, b, a);

        /// <summary>Gets the <c>gbar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbar => new float4(g, b, a, r);
        /// <summary>Gets the <c>gbag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbag => new float4(g, b, a, g);
        /// <summary>Gets the <c>gbab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbab => new float4(g, b, a, b);
        /// <summary>Gets the <c>gbaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gbaa => new float4(g, b, a, a);

        // ga
        /// <summary>Gets the <c>garr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 garr => new float4(g, a, r, r);
        /// <summary>Gets the <c>garg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 garg => new float4(g, a, r, g);
        /// <summary>Gets the <c>garb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 garb => new float4(g, a, r, b);
        /// <summary>Gets the <c>gara</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gara => new float4(g, a, r, a);

        /// <summary>Gets the <c>gagr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gagr => new float4(g, a, g, r);
        /// <summary>Gets the <c>gagg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gagg => new float4(g, a, g, g);
        /// <summary>Gets the <c>gagb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gagb => new float4(g, a, g, b);
        /// <summary>Gets the <c>gaga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gaga => new float4(g, a, g, a);

        /// <summary>Gets the <c>gabr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gabr => new float4(g, a, b, r);
        /// <summary>Gets the <c>gabg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gabg => new float4(g, a, b, g);
        /// <summary>Gets the <c>gabb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gabb => new float4(g, a, b, b);
        /// <summary>Gets the <c>gaba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gaba => new float4(g, a, b, a);

        /// <summary>Gets the <c>gaar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gaar => new float4(g, a, a, r);
        /// <summary>Gets the <c>gaag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gaag => new float4(g, a, a, g);
        /// <summary>Gets the <c>gaab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gaab => new float4(g, a, a, b);
        /// <summary>Gets the <c>gaaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 gaaa => new float4(g, a, a, a);


        // b
        // br
        /// <summary>Gets the <c>brrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brrr => new float4(b, r, r, r);
        /// <summary>Gets the <c>brrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brrg => new float4(b, r, r, g);
        /// <summary>Gets the <c>brrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brrb => new float4(b, r, r, b);
        /// <summary>Gets the <c>brra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brra => new float4(b, r, r, a);

        /// <summary>Gets the <c>brgr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brgr => new float4(b, r, g, r);
        /// <summary>Gets the <c>brgg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brgg => new float4(b, r, g, g);
        /// <summary>Gets the <c>brgb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brgb => new float4(b, r, g, b);
        /// <summary>Gets the <c>brga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brga => new float4(b, r, g, a);

        /// <summary>Gets the <c>brbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brbr => new float4(b, r, b, r);
        /// <summary>Gets the <c>brbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brbg => new float4(b, r, b, g);
        /// <summary>Gets the <c>brbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brbb => new float4(b, r, b, b);
        /// <summary>Gets the <c>brba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brba => new float4(b, r, b, a);

        /// <summary>Gets the <c>brar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brar => new float4(b, r, a, r);
        /// <summary>Gets the <c>brag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brag => new float4(b, r, a, g);
        /// <summary>Gets the <c>brab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 brab => new float4(b, r, a, b);
        /// <summary>Gets the <c>braa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 braa => new float4(b, r, a, a);

        // bg
        /// <summary>Gets the <c>bgrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgrr => new float4(b, g, r, r);
        /// <summary>Gets the <c>bgrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgrg => new float4(b, g, r, g);
        /// <summary>Gets the <c>bgrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgrb => new float4(b, g, r, b);
        /// <summary>Gets the <c>bgra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgra => new float4(b, g, r, a);

        /// <summary>Gets the <c>bggr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bggr => new float4(b, g, g, r);
        /// <summary>Gets the <c>bggg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bggg => new float4(b, g, g, g);
        /// <summary>Gets the <c>bggb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bggb => new float4(b, g, g, b);
        /// <summary>Gets the <c>bgga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgga => new float4(b, g, g, a);

        /// <summary>Gets the <c>bgbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgbr => new float4(b, g, b, r);
        /// <summary>Gets the <c>bgbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgbg => new float4(b, g, b, g);
        /// <summary>Gets the <c>bgbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgbb => new float4(b, g, b, b);
        /// <summary>Gets the <c>bgba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgba => new float4(b, g, b, a);

        /// <summary>Gets the <c>bgar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgar => new float4(b, g, a, r);
        /// <summary>Gets the <c>bgag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgag => new float4(b, g, a, g);
        /// <summary>Gets the <c>bgab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgab => new float4(b, g, a, b);
        /// <summary>Gets the <c>bgaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bgaa => new float4(b, g, a, a);

        // bb
        /// <summary>Gets the <c>bbrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbrr => new float4(b, b, r, r);
        /// <summary>Gets the <c>bbrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbrg => new float4(b, b, r, g);
        /// <summary>Gets the <c>bbrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbrb => new float4(b, b, r, b);
        /// <summary>Gets the <c>bbra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbra => new float4(b, b, r, a);

        /// <summary>Gets the <c>bbgr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbgr => new float4(b, b, g, r);
        /// <summary>Gets the <c>bbgg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbgg => new float4(b, b, g, g);
        /// <summary>Gets the <c>bbgb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbgb => new float4(b, b, g, b);
        /// <summary>Gets the <c>bbga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbga => new float4(b, b, g, a);

        /// <summary>Gets the <c>bbbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbbr => new float4(b, b, b, r);
        /// <summary>Gets the <c>bbbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbbg => new float4(b, b, b, g);
        /// <summary>Gets the <c>bbbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbbb => new float4(b, b, b, b);
        /// <summary>Gets the <c>bbba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbba => new float4(b, b, b, a);

        /// <summary>Gets the <c>bbar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbar => new float4(b, b, a, r);
        /// <summary>Gets the <c>bbag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbag => new float4(b, b, a, g);
        /// <summary>Gets the <c>bbab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbab => new float4(b, b, a, b);
        /// <summary>Gets the <c>bbaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bbaa => new float4(b, b, a, a);

        // ba
        /// <summary>Gets the <c>barr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 barr => new float4(b, a, r, r);
        /// <summary>Gets the <c>barg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 barg => new float4(b, a, r, g);
        /// <summary>Gets the <c>barb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 barb => new float4(b, a, r, b);
        /// <summary>Gets the <c>bara</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bara => new float4(b, a, r, a);

        /// <summary>Gets the <c>bagr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bagr => new float4(b, a, g, r);
        /// <summary>Gets the <c>bagg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bagg => new float4(b, a, g, g);
        /// <summary>Gets the <c>bagb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 bagb => new float4(b, a, g, b);
        /// <summary>Gets the <c>baga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 baga => new float4(b, a, g, a);

        /// <summary>Gets the <c>babr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 babr => new float4(b, a, b, r);
        /// <summary>Gets the <c>babg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 babg => new float4(b, a, b, g);
        /// <summary>Gets the <c>babb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 babb => new float4(b, a, b, b);
        /// <summary>Gets the <c>baba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 baba => new float4(b, a, b, a);

        /// <summary>Gets the <c>baar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 baar => new float4(b, a, a, r);
        /// <summary>Gets the <c>baag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 baag => new float4(b, a, a, g);
        /// <summary>Gets the <c>baab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 baab => new float4(b, a, a, b);
        /// <summary>Gets the <c>baaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 baaa => new float4(b, a, a, a);


        // a
        // ar
        /// <summary>Gets the <c>arrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arrr => new float4(a, r, r, r);
        /// <summary>Gets the <c>arrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arrg => new float4(a, r, r, g);
        /// <summary>Gets the <c>arrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arrb => new float4(a, r, r, b);
        /// <summary>Gets the <c>arra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arra => new float4(a, r, r, a);

        /// <summary>Gets the <c>argr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 argr => new float4(a, r, g, r);
        /// <summary>Gets the <c>argg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 argg => new float4(a, r, g, g);
        /// <summary>Gets the <c>argb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 argb => new float4(a, r, g, b);
        /// <summary>Gets the <c>arga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arga => new float4(a, r, g, a);

        /// <summary>Gets the <c>arbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arbr => new float4(a, r, b, r);
        /// <summary>Gets the <c>arbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arbg => new float4(a, r, b, g);
        /// <summary>Gets the <c>arbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arbb => new float4(a, r, b, b);
        /// <summary>Gets the <c>arba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arba => new float4(a, r, b, a);

        /// <summary>Gets the <c>arar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arar => new float4(a, r, a, r);
        /// <summary>Gets the <c>arag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arag => new float4(a, r, a, g);
        /// <summary>Gets the <c>arab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 arab => new float4(a, r, a, b);
        /// <summary>Gets the <c>araa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 araa => new float4(a, r, a, a);

        // ag
        /// <summary>Gets the <c>agrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agrr => new float4(a, g, r, r);
        /// <summary>Gets the <c>agrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agrg => new float4(a, g, r, g);
        /// <summary>Gets the <c>agrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agrb => new float4(a, g, r, b);
        /// <summary>Gets the <c>agra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agra => new float4(a, g, r, a);

        /// <summary>Gets the <c>aggr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aggr => new float4(a, g, g, r);
        /// <summary>Gets the <c>aggg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aggg => new float4(a, g, g, g);
        /// <summary>Gets the <c>aggb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aggb => new float4(a, g, g, b);
        /// <summary>Gets the <c>agga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agga => new float4(a, g, g, a);

        /// <summary>Gets the <c>agbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agbr => new float4(a, g, b, r);
        /// <summary>Gets the <c>agbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agbg => new float4(a, g, b, g);
        /// <summary>Gets the <c>agbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agbb => new float4(a, g, b, b);
        /// <summary>Gets the <c>agba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agba => new float4(a, g, b, a);

        /// <summary>Gets the <c>agar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agar => new float4(a, g, a, r);
        /// <summary>Gets the <c>agag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agag => new float4(a, g, a, g);
        /// <summary>Gets the <c>agab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agab => new float4(a, g, a, b);
        /// <summary>Gets the <c>agaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 agaa => new float4(a, g, a, a);

        // ab
        /// <summary>Gets the <c>abrr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abrr => new float4(a, b, r, r);
        /// <summary>Gets the <c>abrg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abrg => new float4(a, b, r, g);
        /// <summary>Gets the <c>abrb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abrb => new float4(a, b, r, b);
        /// <summary>Gets the <c>abra</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abra => new float4(a, b, r, a);

        /// <summary>Gets the <c>abgr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abgr => new float4(a, b, g, r);
        /// <summary>Gets the <c>abgg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abgg => new float4(a, b, g, g);
        /// <summary>Gets the <c>abgb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abgb => new float4(a, b, g, b);
        /// <summary>Gets the <c>abga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abga => new float4(a, b, g, a);

        /// <summary>Gets the <c>abbr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abbr => new float4(a, b, b, r);
        /// <summary>Gets the <c>abbg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abbg => new float4(a, b, b, g);
        /// <summary>Gets the <c>abbb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abbb => new float4(a, b, b, b);
        /// <summary>Gets the <c>abba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abba => new float4(a, b, b, a);

        /// <summary>Gets the <c>abar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abar => new float4(a, b, a, r);
        /// <summary>Gets the <c>abag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abag => new float4(a, b, a, g);
        /// <summary>Gets the <c>abab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abab => new float4(a, b, a, b);
        /// <summary>Gets the <c>abaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 abaa => new float4(a, b, a, a);

        // aa
        /// <summary>Gets the <c>aarr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aarr => new float4(a, a, r, r);
        /// <summary>Gets the <c>aarg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aarg => new float4(a, a, r, g);
        /// <summary>Gets the <c>aarb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aarb => new float4(a, a, r, b);
        /// <summary>Gets the <c>aara</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aara => new float4(a, a, r, a);

        /// <summary>Gets the <c>aagr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aagr => new float4(a, a, g, r);
        /// <summary>Gets the <c>aagg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aagg => new float4(a, a, g, g);
        /// <summary>Gets the <c>aagb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aagb => new float4(a, a, g, b);
        /// <summary>Gets the <c>aaga</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aaga => new float4(a, a, g, a);

        /// <summary>Gets the <c>aabr</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aabr => new float4(a, a, b, r);
        /// <summary>Gets the <c>aabg</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aabg => new float4(a, a, b, g);
        /// <summary>Gets the <c>aabb</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aabb => new float4(a, a, b, b);
        /// <summary>Gets the <c>aaba</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aaba => new float4(a, a, b, a);

        /// <summary>Gets the <c>aaar</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aaar => new float4(a, a, a, r);
        /// <summary>Gets the <c>aaag</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aaag => new float4(a, a, a, g);
        /// <summary>Gets the <c>aaab</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aaab => new float4(a, a, a, b);
        /// <summary>Gets the <c>aaaa</c> swizzle of the vector as a <see cref="float4"/>.</summary>
        public readonly float4 aaaa => new float4(a, a, a, a);

        #endregion Swizzles_float4_RGBA
        #region Swizzles_Extra

        // Swizzles - float3

        // x
        /// <summary>Gets the <c>xxx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xxx => new float3(x, x, x);
        /// <summary>Gets the <c>xxy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xxy => new float3(x, x, y);
        /// <summary>Gets the <c>xxz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xxz => new float3(x, x, z);
        /// <summary>Gets the <c>xxw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xxw => new float3(x, x, w);

        /// <summary>Gets the <c>xyx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xyx => new float3(x, y, x);
        /// <summary>Gets the <c>xyy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xyy => new float3(x, y, y);
        /// <summary>Gets the <c>xyz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xyz => new float3(x, y, z);
        /// <summary>Gets the <c>xyw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xyw => new float3(x, y, w);

        /// <summary>Gets the <c>xzx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xzx => new float3(x, z, x);
        /// <summary>Gets the <c>xzy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xzy => new float3(x, z, y);
        /// <summary>Gets the <c>xzz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xzz => new float3(x, z, z);
        /// <summary>Gets the <c>xzw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xzw => new float3(x, z, w);

        /// <summary>Gets the <c>xwx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xwx => new float3(x, w, x);
        /// <summary>Gets the <c>xwy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xwy => new float3(x, w, y);
        /// <summary>Gets the <c>xwz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xwz => new float3(x, w, z);
        /// <summary>Gets the <c>xww</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 xww => new float3(x, w, w);

        // y
        /// <summary>Gets the <c>yxx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yxx => new float3(y, x, x);
        /// <summary>Gets the <c>yxy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yxy => new float3(y, x, y);
        /// <summary>Gets the <c>yxz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yxz => new float3(y, x, z);
        /// <summary>Gets the <c>yxw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yxw => new float3(y, x, w);

        /// <summary>Gets the <c>yyx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yyx => new float3(y, y, x);
        /// <summary>Gets the <c>yyy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yyy => new float3(y, y, y);
        /// <summary>Gets the <c>yyz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yyz => new float3(y, y, z);
        /// <summary>Gets the <c>yyw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yyw => new float3(y, y, w);

        /// <summary>Gets the <c>yzx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yzx => new float3(y, z, x);
        /// <summary>Gets the <c>yzy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yzy => new float3(y, z, y);
        /// <summary>Gets the <c>yzz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yzz => new float3(y, z, z);
        /// <summary>Gets the <c>yzw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yzw => new float3(y, z, w);

        /// <summary>Gets the <c>ywx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 ywx => new float3(y, w, x);
        /// <summary>Gets the <c>ywy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 ywy => new float3(y, w, y);
        /// <summary>Gets the <c>ywz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 ywz => new float3(y, w, z);
        /// <summary>Gets the <c>yww</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 yww => new float3(y, w, w);

        // z
        /// <summary>Gets the <c>zxx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zxx => new float3(z, x, x);
        /// <summary>Gets the <c>zxy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zxy => new float3(z, x, y);
        /// <summary>Gets the <c>zxz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zxz => new float3(z, x, z);
        /// <summary>Gets the <c>zxw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zxw => new float3(z, x, w);

        /// <summary>Gets the <c>zyx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zyx => new float3(z, y, x);
        /// <summary>Gets the <c>zyy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zyy => new float3(z, y, y);
        /// <summary>Gets the <c>zyz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zyz => new float3(z, y, z);
        /// <summary>Gets the <c>zyw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zyw => new float3(z, y, w);

        /// <summary>Gets the <c>zzx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zzx => new float3(z, z, x);
        /// <summary>Gets the <c>zzy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zzy => new float3(z, z, y);
        /// <summary>Gets the <c>zzz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zzz => new float3(z, z, z);
        /// <summary>Gets the <c>zzw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zzw => new float3(z, z, w);

        /// <summary>Gets the <c>zwx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zwx => new float3(z, w, x);
        /// <summary>Gets the <c>zwy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zwy => new float3(z, w, y);
        /// <summary>Gets the <c>zwz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zwz => new float3(z, w, z);
        /// <summary>Gets the <c>zww</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 zww => new float3(z, w, w);

        // w
        /// <summary>Gets the <c>wxx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wxx => new float3(w, x, x);
        /// <summary>Gets the <c>wxy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wxy => new float3(w, x, y);
        /// <summary>Gets the <c>wxz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wxz => new float3(w, x, z);
        /// <summary>Gets the <c>wxw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wxw => new float3(w, x, w);
        
        /// <summary>Gets the <c>wyx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wyx => new float3(w, y, x);
        /// <summary>Gets the <c>wyy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wyy => new float3(w, y, y);
        /// <summary>Gets the <c>wyz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wyz => new float3(w, y, z);
        /// <summary>Gets the <c>wyw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wyw => new float3(w, y, w);

        /// <summary>Gets the <c>wzx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wzx => new float3(w, z, x);
        /// <summary>Gets the <c>wzy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wzy => new float3(w, z, y);
        /// <summary>Gets the <c>wzz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wzz => new float3(w, z, z);
        /// <summary>Gets the <c>wzw</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wzw => new float3(w, z, w);

        /// <summary>Gets the <c>wwx</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wwx => new float3(w, w, x);
        /// <summary>Gets the <c>wwy</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wwy => new float3(w, w, y);
        /// <summary>Gets the <c>wwz</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 wwz => new float3(w, w, z);
        /// <summary>Gets the <c>www</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 www => new float3(w, w, w);

        // Swizzles - float2

        /// <summary>Gets the <c>xx</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 xx => new float2(x, x);
        /// <summary>Gets the <c>xy</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 xy => new float2(x, y);
        /// <summary>Gets the <c>xz</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 xz => new float2(x, z);
        /// <summary>Gets the <c>xw</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 xw => new float2(x, w);

        /// <summary>Gets the <c>yx</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 yx => new float2(y, x);
        /// <summary>Gets the <c>yy</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 yy => new float2(y, y);
        /// <summary>Gets the <c>yz</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 yz => new float2(y, z);
        /// <summary>Gets the <c>yw</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 yw => new float2(y, w);

        /// <summary>Gets the <c>zx</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 zx => new float2(z, x);
        /// <summary>Gets the <c>zy</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 zy => new float2(z, y);
        /// <summary>Gets the <c>zz</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 zz => new float2(z, z);
        /// <summary>Gets the <c>zw</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 zw => new float2(z, w);

        /// <summary>Gets the <c>wx</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 wx => new float2(w, x);
        /// <summary>Gets the <c>wy</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 wy => new float2(w, y);
        /// <summary>Gets the <c>wz</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 wz => new float2(w, z);
        /// <summary>Gets the <c>ww</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 ww => new float2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - float3

        // r
        /// <summary>Gets the <c>rrr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rrr => new float3(r, r, r);
        /// <summary>Gets the <c>rrg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rrg => new float3(r, r, g);
        /// <summary>Gets the <c>rrb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rrb => new float3(r, r, b);
        /// <summary>Gets the <c>rra</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rra => new float3(r, r, a);

        /// <summary>Gets the <c>rgr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rgr => new float3(r, g, r);
        /// <summary>Gets the <c>rgg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rgg => new float3(r, g, g);
        /// <summary>Gets the <c>rgb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rgb => new float3(r, g, b);
        /// <summary>Gets the <c>rga</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rga => new float3(r, g, a);

        /// <summary>Gets the <c>rbr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rbr => new float3(r, b, r);
        /// <summary>Gets the <c>rbg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rbg => new float3(r, b, g);
        /// <summary>Gets the <c>rbb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rbb => new float3(r, b, b);
        /// <summary>Gets the <c>rba</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rba => new float3(r, b, a);

        /// <summary>Gets the <c>rar</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rar => new float3(r, a, r);
        /// <summary>Gets the <c>rag</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rag => new float3(r, a, g);
        /// <summary>Gets the <c>rab</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 rab => new float3(r, a, b);
        /// <summary>Gets the <c>raa</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 raa => new float3(r, a, a);

        // g
        /// <summary>Gets the <c>grr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 grr => new float3(g, r, r);
        /// <summary>Gets the <c>grg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 grg => new float3(g, r, g);
        /// <summary>Gets the <c>grb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 grb => new float3(g, r, b);
        /// <summary>Gets the <c>gra</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gra => new float3(g, r, a);

        /// <summary>Gets the <c>ggr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 ggr => new float3(g, g, r);
        /// <summary>Gets the <c>ggg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 ggg => new float3(g, g, g);
        /// <summary>Gets the <c>ggb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 ggb => new float3(g, g, b);
        /// <summary>Gets the <c>gga</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gga => new float3(g, g, a);

        /// <summary>Gets the <c>gbr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gbr => new float3(g, b, r);
        /// <summary>Gets the <c>gbg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gbg => new float3(g, b, g);
        /// <summary>Gets the <c>gbb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gbb => new float3(g, b, b);
        /// <summary>Gets the <c>gba</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gba => new float3(g, b, a);

        /// <summary>Gets the <c>gar</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gar => new float3(g, a, r);
        /// <summary>Gets the <c>gag</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gag => new float3(g, a, g);
        /// <summary>Gets the <c>gab</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gab => new float3(g, a, b);
        /// <summary>Gets the <c>gaa</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 gaa => new float3(g, a, a);

        // b
        /// <summary>Gets the <c>brr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 brr => new float3(b, r, r);
        /// <summary>Gets the <c>brg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 brg => new float3(b, r, g);
        /// <summary>Gets the <c>brb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 brb => new float3(b, r, b);
        /// <summary>Gets the <c>bra</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bra => new float3(b, r, a);

        /// <summary>Gets the <c>bgr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bgr => new float3(b, g, r);
        /// <summary>Gets the <c>bgg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bgg => new float3(b, g, g);
        /// <summary>Gets the <c>bgb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bgb => new float3(b, g, b);
        /// <summary>Gets the <c>bga</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bga => new float3(b, g, a);

        /// <summary>Gets the <c>bbr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bbr => new float3(b, b, r);
        /// <summary>Gets the <c>bbg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bbg => new float3(b, b, g);
        /// <summary>Gets the <c>bbb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bbb => new float3(b, b, b);
        /// <summary>Gets the <c>bba</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bba => new float3(b, b, a);

        /// <summary>Gets the <c>bar</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bar => new float3(b, a, r);
        /// <summary>Gets the <c>bag</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bag => new float3(b, a, g);
        /// <summary>Gets the <c>bab</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 bab => new float3(b, a, b);
        /// <summary>Gets the <c>baa</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 baa => new float3(b, a, a);

        // a
        /// <summary>Gets the <c>arr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 arr => new float3(a, r, r);
        /// <summary>Gets the <c>arg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 arg => new float3(a, r, g);
        /// <summary>Gets the <c>arb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 arb => new float3(a, r, b);
        /// <summary>Gets the <c>ara</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 ara => new float3(a, r, a);

        /// <summary>Gets the <c>agr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 agr => new float3(a, g, r);
        /// <summary>Gets the <c>agg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 agg => new float3(a, g, g);
        /// <summary>Gets the <c>agb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 agb => new float3(a, g, b);
        /// <summary>Gets the <c>aga</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 aga => new float3(a, g, a);

        /// <summary>Gets the <c>abr</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 abr => new float3(a, b, r);
        /// <summary>Gets the <c>abg</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 abg => new float3(a, b, g);
        /// <summary>Gets the <c>abb</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 abb => new float3(a, b, b);
        /// <summary>Gets the <c>aba</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 aba => new float3(a, b, a);

        /// <summary>Gets the <c>aar</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 aar => new float3(a, a, r);
        /// <summary>Gets the <c>aag</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 aag => new float3(a, a, g);
        /// <summary>Gets the <c>aab</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 aab => new float3(a, a, b);
        /// <summary>Gets the <c>aaa</c> swizzle of the vector as a <see cref="float3"/>.</summary>
        public readonly float3 aaa => new float3(a, a, a);

        // RGBA - Swizzles - float2

        /// <summary>Gets the <c>rr</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 rr => new float2(r, r);
        /// <summary>Gets the <c>rg</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 rg => new float2(r, g);
        /// <summary>Gets the <c>rb</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 rb => new float2(r, b);
        /// <summary>Gets the <c>ra</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 ra => new float2(r, a);

        /// <summary>Gets the <c>gr</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 gr => new float2(g, r);
        /// <summary>Gets the <c>gg</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 gg => new float2(g, g);
        /// <summary>Gets the <c>gb</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 gb => new float2(g, b);
        /// <summary>Gets the <c>ga</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 ga => new float2(g, a);

        /// <summary>Gets the <c>br</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 br => new float2(b, r);
        /// <summary>Gets the <c>bg</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 bg => new float2(b, g);
        /// <summary>Gets the <c>bb</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 bb => new float2(b, b);
        /// <summary>Gets the <c>ba</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 ba => new float2(b, a);

        /// <summary>Gets the <c>ar</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 ar => new float2(a, r);
        /// <summary>Gets the <c>ag</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 ag => new float2(a, g);
        /// <summary>Gets the <c>ab</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 ab => new float2(a, b);
        /// <summary>Gets the <c>aa</c> swizzle of the vector as a <see cref="float2"/>.</summary>
        public readonly float2 aa => new float2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
