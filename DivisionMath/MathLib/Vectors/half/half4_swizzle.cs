namespace DivisionEngine.MathLib
{
    public partial struct half4
    {
        #region Swizzles_half4

        // Swizzles - half4

        // x
        // xx
        public readonly half4 xxxx => new half4(x, x, x, x);
        public readonly half4 xxxy => new half4(x, x, x, y);
        public readonly half4 xxxz => new half4(x, x, x, z);
        public readonly half4 xxxw => new half4(x, x, x, w);

        public readonly half4 xxyx => new half4(x, x, y, x);
        public readonly half4 xxyy => new half4(x, x, y, y);
        public readonly half4 xxyz => new half4(x, x, y, z);
        public readonly half4 xxyw => new half4(x, x, y, w);

        public readonly half4 xxzx => new half4(x, x, z, x);
        public readonly half4 xxzy => new half4(x, x, z, y);
        public readonly half4 xxzz => new half4(x, x, z, z);
        public readonly half4 xxzw => new half4(x, x, z, w);

        public readonly half4 xxwx => new half4(x, x, w, x);
        public readonly half4 xxwy => new half4(x, x, w, y);
        public readonly half4 xxwz => new half4(x, x, w, z);
        public readonly half4 xxww => new half4(x, x, w, w);

        // xy
        public readonly half4 xyxx => new half4(x, y, x, x);
        public readonly half4 xyxy => new half4(x, y, x, y);
        public readonly half4 xyxz => new half4(x, y, x, z);
        public readonly half4 xyxw => new half4(x, y, x, w);

        public readonly half4 xyyx => new half4(x, y, y, x);
        public readonly half4 xyyy => new half4(x, y, y, y);
        public readonly half4 xyyz => new half4(x, y, y, z);
        public readonly half4 xyyw => new half4(x, y, y, w);

        public readonly half4 xyzx => new half4(x, y, z, x);
        public readonly half4 xyzy => new half4(x, y, z, y);
        public readonly half4 xyzz => new half4(x, y, z, z);
        public readonly half4 xyzw => new half4(x, y, z, w);

        public readonly half4 xywx => new half4(x, y, w, x);
        public readonly half4 xywy => new half4(x, y, w, y);
        public readonly half4 xywz => new half4(x, y, w, z);
        public readonly half4 xyww => new half4(x, y, w, w);

        // xz
        public readonly half4 xzxx => new half4(x, z, x, x);
        public readonly half4 xzxy => new half4(x, z, x, y);
        public readonly half4 xzxz => new half4(x, z, x, z);
        public readonly half4 xzxw => new half4(x, z, x, w);

        public readonly half4 xzyx => new half4(x, z, y, x);
        public readonly half4 xzyy => new half4(x, z, y, y);
        public readonly half4 xzyz => new half4(x, z, y, z);
        public readonly half4 xzyw => new half4(x, z, y, w);

        public readonly half4 xzzx => new half4(x, z, z, x);
        public readonly half4 xzzy => new half4(x, z, z, y);
        public readonly half4 xzzz => new half4(x, z, z, z);
        public readonly half4 xzzw => new half4(x, z, z, w);

        public readonly half4 xzwx => new half4(x, z, w, x);
        public readonly half4 xzwy => new half4(x, z, w, y);
        public readonly half4 xzwz => new half4(x, z, w, z);
        public readonly half4 xzww => new half4(x, z, w, w);

        // xw
        public readonly half4 xwxx => new half4(x, w, x, x);
        public readonly half4 xwxy => new half4(x, w, x, y);
        public readonly half4 xwxz => new half4(x, w, x, z);
        public readonly half4 xwxw => new half4(x, w, x, w);

        public readonly half4 xwyx => new half4(x, w, y, x);
        public readonly half4 xwyy => new half4(x, w, y, y);
        public readonly half4 xwyz => new half4(x, w, y, z);
        public readonly half4 xwyw => new half4(x, w, y, w);

        public readonly half4 xwzx => new half4(x, w, z, x);
        public readonly half4 xwzy => new half4(x, w, z, y);
        public readonly half4 xwzz => new half4(x, w, z, z);
        public readonly half4 xwzw => new half4(x, w, z, w);

        public readonly half4 xwwx => new half4(x, w, w, x);
        public readonly half4 xwwy => new half4(x, w, w, y);
        public readonly half4 xwwz => new half4(x, w, w, z);
        public readonly half4 xwww => new half4(x, w, w, w);


        // y
        // yx
        public readonly half4 yxxx => new half4(y, x, x, x);
        public readonly half4 yxxy => new half4(y, x, x, y);
        public readonly half4 yxxz => new half4(y, x, x, z);
        public readonly half4 yxxw => new half4(y, x, x, w);

        public readonly half4 yxyx => new half4(y, x, y, x);
        public readonly half4 yxyy => new half4(y, x, y, y);
        public readonly half4 yxyz => new half4(y, x, y, z);
        public readonly half4 yxyw => new half4(y, x, y, w);

        public readonly half4 yxzx => new half4(y, x, z, x);
        public readonly half4 yxzy => new half4(y, x, z, y);
        public readonly half4 yxzz => new half4(y, x, z, z);
        public readonly half4 yxzw => new half4(y, x, z, w);

        public readonly half4 yxwx => new half4(y, x, w, x);
        public readonly half4 yxwy => new half4(y, x, w, y);
        public readonly half4 yxwz => new half4(y, x, w, z);
        public readonly half4 yxww => new half4(y, x, w, w);

        // yy
        public readonly half4 yyxx => new half4(y, y, x, x);
        public readonly half4 yyxy => new half4(y, y, x, y);
        public readonly half4 yyxz => new half4(y, y, x, z);
        public readonly half4 yyxw => new half4(y, y, x, w);

        public readonly half4 yyyx => new half4(y, y, y, x);
        public readonly half4 yyyy => new half4(y, y, y, y);
        public readonly half4 yyyz => new half4(y, y, y, z);
        public readonly half4 yyyw => new half4(y, y, y, w);

        public readonly half4 yyzx => new half4(y, y, z, x);
        public readonly half4 yyzy => new half4(y, y, z, y);
        public readonly half4 yyzz => new half4(y, y, z, z);
        public readonly half4 yyzw => new half4(y, y, z, w);

        public readonly half4 yywx => new half4(y, y, w, x);
        public readonly half4 yywy => new half4(y, y, w, y);
        public readonly half4 yywz => new half4(y, y, w, z);
        public readonly half4 yyww => new half4(y, y, w, w);

        // yz
        public readonly half4 yzxx => new half4(y, z, x, x);
        public readonly half4 yzxy => new half4(y, z, x, y);
        public readonly half4 yzxz => new half4(y, z, x, z);
        public readonly half4 yzxw => new half4(y, z, x, w);

        public readonly half4 yzyx => new half4(y, z, y, x);
        public readonly half4 yzyy => new half4(y, z, y, y);
        public readonly half4 yzyz => new half4(y, z, y, z);
        public readonly half4 yzyw => new half4(y, z, y, w);

        public readonly half4 yzzx => new half4(y, z, z, x);
        public readonly half4 yzzy => new half4(y, z, z, y);
        public readonly half4 yzzz => new half4(y, z, z, z);
        public readonly half4 yzzw => new half4(y, z, z, w);

        public readonly half4 yzwx => new half4(y, z, w, x);
        public readonly half4 yzwy => new half4(y, z, w, y);
        public readonly half4 yzwz => new half4(y, z, w, z);
        public readonly half4 yzww => new half4(y, z, w, w);

        // yw
        public readonly half4 ywxx => new half4(y, w, x, x);
        public readonly half4 ywxy => new half4(y, w, x, y);
        public readonly half4 ywxz => new half4(y, w, x, z);
        public readonly half4 ywxw => new half4(y, w, x, w);

        public readonly half4 ywyx => new half4(y, w, y, x);
        public readonly half4 ywyy => new half4(y, w, y, y);
        public readonly half4 ywyz => new half4(y, w, y, z);
        public readonly half4 ywyw => new half4(y, w, y, w);

        public readonly half4 ywzx => new half4(y, w, z, x);
        public readonly half4 ywzy => new half4(y, w, z, y);
        public readonly half4 ywzz => new half4(y, w, z, z);
        public readonly half4 ywzw => new half4(y, w, z, w);

        public readonly half4 ywwx => new half4(y, w, w, x);
        public readonly half4 ywwy => new half4(y, w, w, y);
        public readonly half4 ywwz => new half4(y, w, w, z);
        public readonly half4 ywww => new half4(y, w, w, w);


        // z
        // zx
        public readonly half4 zxxx => new half4(z, x, x, x);
        public readonly half4 zxxy => new half4(z, x, x, y);
        public readonly half4 zxxz => new half4(z, x, x, z);
        public readonly half4 zxxw => new half4(z, x, x, w);

        public readonly half4 zxyx => new half4(z, x, y, x);
        public readonly half4 zxyy => new half4(z, x, y, y);
        public readonly half4 zxyz => new half4(z, x, y, z);
        public readonly half4 zxyw => new half4(z, x, y, w);

        public readonly half4 zxzx => new half4(z, x, z, x);
        public readonly half4 zxzy => new half4(z, x, z, y);
        public readonly half4 zxzz => new half4(z, x, z, z);
        public readonly half4 zxzw => new half4(z, x, z, w);

        public readonly half4 zxwx => new half4(z, x, w, x);
        public readonly half4 zxwy => new half4(z, x, w, y);
        public readonly half4 zxwz => new half4(z, x, w, z);
        public readonly half4 zxww => new half4(z, x, w, w);

        // zy
        public readonly half4 zyxx => new half4(z, y, x, x);
        public readonly half4 zyxy => new half4(z, y, x, y);
        public readonly half4 zyxz => new half4(z, y, x, z);
        public readonly half4 zyxw => new half4(z, y, x, w);

        public readonly half4 zyyx => new half4(z, y, y, x);
        public readonly half4 zyyy => new half4(z, y, y, y);
        public readonly half4 zyyz => new half4(z, y, y, z);
        public readonly half4 zyyw => new half4(z, y, y, w);

        public readonly half4 zyzx => new half4(z, y, z, x);
        public readonly half4 zyzy => new half4(z, y, z, y);
        public readonly half4 zyzz => new half4(z, y, z, z);
        public readonly half4 zyzw => new half4(z, y, z, w);

        public readonly half4 zywx => new half4(z, y, w, x);
        public readonly half4 zywy => new half4(z, y, w, y);
        public readonly half4 zywz => new half4(z, y, w, z);
        public readonly half4 zyww => new half4(z, y, w, w);

        // zz
        public readonly half4 zzxx => new half4(z, z, x, x);
        public readonly half4 zzxy => new half4(z, z, x, y);
        public readonly half4 zzxz => new half4(z, z, x, z);
        public readonly half4 zzxw => new half4(z, z, x, w);

        public readonly half4 zzyx => new half4(z, z, y, x);
        public readonly half4 zzyy => new half4(z, z, y, y);
        public readonly half4 zzyz => new half4(z, z, y, z);
        public readonly half4 zzyw => new half4(z, z, y, w);

        public readonly half4 zzzx => new half4(z, z, z, x);
        public readonly half4 zzzy => new half4(z, z, z, y);
        public readonly half4 zzzz => new half4(z, z, z, z);
        public readonly half4 zzzw => new half4(z, z, z, w);

        public readonly half4 zzwx => new half4(z, z, w, x);
        public readonly half4 zzwy => new half4(z, z, w, y);
        public readonly half4 zzwz => new half4(z, z, w, z);
        public readonly half4 zzww => new half4(z, z, w, w);

        // zw
        public readonly half4 zwxx => new half4(z, w, x, x);
        public readonly half4 zwxy => new half4(z, w, x, y);
        public readonly half4 zwxz => new half4(z, w, x, z);
        public readonly half4 zwxw => new half4(z, w, x, w);

        public readonly half4 zwyx => new half4(z, w, y, x);
        public readonly half4 zwyy => new half4(z, w, y, y);
        public readonly half4 zwyz => new half4(z, w, y, z);
        public readonly half4 zwyw => new half4(z, w, y, w);

        public readonly half4 zwzx => new half4(z, w, z, x);
        public readonly half4 zwzy => new half4(z, w, z, y);
        public readonly half4 zwzz => new half4(z, w, z, z);
        public readonly half4 zwzw => new half4(z, w, z, w);

        public readonly half4 zwwx => new half4(z, w, w, x);
        public readonly half4 zwwy => new half4(z, w, w, y);
        public readonly half4 zwwz => new half4(z, w, w, z);
        public readonly half4 zwww => new half4(z, w, w, w);


        // w
        // wx
        public readonly half4 wxxx => new half4(w, x, x, x);
        public readonly half4 wxxy => new half4(w, x, x, y);
        public readonly half4 wxxz => new half4(w, x, x, z);
        public readonly half4 wxxw => new half4(w, x, x, w);

        public readonly half4 wxyx => new half4(w, x, y, x);
        public readonly half4 wxyy => new half4(w, x, y, y);
        public readonly half4 wxyz => new half4(w, x, y, z);
        public readonly half4 wxyw => new half4(w, x, y, w);

        public readonly half4 wxzx => new half4(w, x, z, x);
        public readonly half4 wxzy => new half4(w, x, z, y);
        public readonly half4 wxzz => new half4(w, x, z, z);
        public readonly half4 wxzw => new half4(w, x, z, w);

        public readonly half4 wxwx => new half4(w, x, w, x);
        public readonly half4 wxwy => new half4(w, x, w, y);
        public readonly half4 wxwz => new half4(w, x, w, z);
        public readonly half4 wxww => new half4(w, x, w, w);

        // wy
        public readonly half4 wyxx => new half4(w, y, x, x);
        public readonly half4 wyxy => new half4(w, y, x, y);
        public readonly half4 wyxz => new half4(w, y, x, z);
        public readonly half4 wyxw => new half4(w, y, x, w);

        public readonly half4 wyyx => new half4(w, y, y, x);
        public readonly half4 wyyy => new half4(w, y, y, y);
        public readonly half4 wyyz => new half4(w, y, y, z);
        public readonly half4 wyyw => new half4(w, y, y, w);

        public readonly half4 wyzx => new half4(w, y, z, x);
        public readonly half4 wyzy => new half4(w, y, z, y);
        public readonly half4 wyzz => new half4(w, y, z, z);
        public readonly half4 wyzw => new half4(w, y, z, w);

        public readonly half4 wywx => new half4(w, y, w, x);
        public readonly half4 wywy => new half4(w, y, w, y);
        public readonly half4 wywz => new half4(w, y, w, z);
        public readonly half4 wyww => new half4(w, y, w, w);

        // wz
        public readonly half4 wzxx => new half4(w, z, x, x);
        public readonly half4 wzxy => new half4(w, z, x, y);
        public readonly half4 wzxz => new half4(w, z, x, z);
        public readonly half4 wzxw => new half4(w, z, x, w);

        public readonly half4 wzyx => new half4(w, z, y, x);
        public readonly half4 wzyy => new half4(w, z, y, y);
        public readonly half4 wzyz => new half4(w, z, y, z);
        public readonly half4 wzyw => new half4(w, z, y, w);

        public readonly half4 wzzx => new half4(w, z, z, x);
        public readonly half4 wzzy => new half4(w, z, z, y);
        public readonly half4 wzzz => new half4(w, z, z, z);
        public readonly half4 wzzw => new half4(w, z, z, w);

        public readonly half4 wzwx => new half4(w, z, w, x);
        public readonly half4 wzwy => new half4(w, z, w, y);
        public readonly half4 wzwz => new half4(w, z, w, z);
        public readonly half4 wzww => new half4(w, z, w, w);

        // ww
        public readonly half4 wwxx => new half4(w, w, x, x);
        public readonly half4 wwxy => new half4(w, w, x, y);
        public readonly half4 wwxz => new half4(w, w, x, z);
        public readonly half4 wwxw => new half4(w, w, x, w);

        public readonly half4 wwyx => new half4(w, w, y, x);
        public readonly half4 wwyy => new half4(w, w, y, y);
        public readonly half4 wwyz => new half4(w, w, y, z);
        public readonly half4 wwyw => new half4(w, w, y, w);

        public readonly half4 wwzx => new half4(w, w, z, x);
        public readonly half4 wwzy => new half4(w, w, z, y);
        public readonly half4 wwzz => new half4(w, w, z, z);
        public readonly half4 wwzw => new half4(w, w, z, w);

        public readonly half4 wwwx => new half4(w, w, w, x);
        public readonly half4 wwwy => new half4(w, w, w, y);
        public readonly half4 wwwz => new half4(w, w, w, z);
        public readonly half4 wwww => new half4(w, w, w, w);

        #endregion Swizzles_half4
        #region Swizzles_half4_RGBA

        // RGBA - Swizzles - half4

        // r
        // rr
        public readonly half4 rrrr => new half4(r, r, r, r);
        public readonly half4 rrrg => new half4(r, r, r, g);
        public readonly half4 rrrb => new half4(r, r, r, b);
        public readonly half4 rrra => new half4(r, r, r, a);

        public readonly half4 rrgr => new half4(r, r, g, r);
        public readonly half4 rrgg => new half4(r, r, g, g);
        public readonly half4 rrgb => new half4(r, r, g, b);
        public readonly half4 rrga => new half4(r, r, g, a);

        public readonly half4 rrbr => new half4(r, r, b, r);
        public readonly half4 rrbg => new half4(r, r, b, g);
        public readonly half4 rrbb => new half4(r, r, b, b);
        public readonly half4 rrba => new half4(r, r, b, a);

        public readonly half4 rrar => new half4(r, r, a, r);
        public readonly half4 rrag => new half4(r, r, a, g);
        public readonly half4 rrab => new half4(r, r, a, b);
        public readonly half4 rraa => new half4(r, r, a, a);

        // rg
        public readonly half4 rgrr => new half4(r, g, r, r);
        public readonly half4 rgrg => new half4(r, g, r, g);
        public readonly half4 rgrb => new half4(r, g, r, b);
        public readonly half4 rgra => new half4(r, g, r, a);

        public readonly half4 rggr => new half4(r, g, g, r);
        public readonly half4 rggg => new half4(r, g, g, g);
        public readonly half4 rggb => new half4(r, g, g, b);
        public readonly half4 rgga => new half4(r, g, g, a);

        public readonly half4 rgbr => new half4(r, g, b, r);
        public readonly half4 rgbg => new half4(r, g, b, g);
        public readonly half4 rgbb => new half4(r, g, b, b);
        public readonly half4 rgba => new half4(r, g, b, a);

        public readonly half4 rgar => new half4(r, g, a, r);
        public readonly half4 rgag => new half4(r, g, a, g);
        public readonly half4 rgab => new half4(r, g, a, b);
        public readonly half4 rgaa => new half4(r, g, a, a);

        // rb
        public readonly half4 rbrr => new half4(r, b, r, r);
        public readonly half4 rbrg => new half4(r, b, r, g);
        public readonly half4 rbrb => new half4(r, b, r, b);
        public readonly half4 rbra => new half4(r, b, r, a);

        public readonly half4 rbgr => new half4(r, b, g, r);
        public readonly half4 rbgg => new half4(r, b, g, g);
        public readonly half4 rbgb => new half4(r, b, g, b);
        public readonly half4 rbga => new half4(r, b, g, a);

        public readonly half4 rbbr => new half4(r, b, b, r);
        public readonly half4 rbbg => new half4(r, b, b, g);
        public readonly half4 rbbb => new half4(r, b, b, b);
        public readonly half4 rbba => new half4(r, b, b, a);

        public readonly half4 rbar => new half4(r, b, a, r);
        public readonly half4 rbag => new half4(r, b, a, g);
        public readonly half4 rbab => new half4(r, b, a, b);
        public readonly half4 rbaa => new half4(r, b, a, a);

        // ra
        public readonly half4 rarr => new half4(r, a, r, r);
        public readonly half4 rarg => new half4(r, a, r, g);
        public readonly half4 rarb => new half4(r, a, r, b);
        public readonly half4 rara => new half4(r, a, r, a);

        public readonly half4 ragr => new half4(r, a, g, r);
        public readonly half4 ragg => new half4(r, a, g, g);
        public readonly half4 ragb => new half4(r, a, g, b);
        public readonly half4 raga => new half4(r, a, g, a);

        public readonly half4 rabr => new half4(r, a, b, r);
        public readonly half4 rabg => new half4(r, a, b, g);
        public readonly half4 rabb => new half4(r, a, b, b);
        public readonly half4 raba => new half4(r, a, b, a);

        public readonly half4 raar => new half4(r, a, a, r);
        public readonly half4 raag => new half4(r, a, a, g);
        public readonly half4 raab => new half4(r, a, a, b);
        public readonly half4 raaa => new half4(r, a, a, a);


        // g
        // gr
        public readonly half4 grrr => new half4(g, r, r, r);
        public readonly half4 grrg => new half4(g, r, r, g);
        public readonly half4 grrb => new half4(g, r, r, b);
        public readonly half4 grra => new half4(g, r, r, a);

        public readonly half4 grgr => new half4(g, r, g, r);
        public readonly half4 grgg => new half4(g, r, g, g);
        public readonly half4 grgb => new half4(g, r, g, b);
        public readonly half4 grga => new half4(g, r, g, a);

        public readonly half4 grbr => new half4(g, r, b, r);
        public readonly half4 grbg => new half4(g, r, b, g);
        public readonly half4 grbb => new half4(g, r, b, b);
        public readonly half4 grba => new half4(g, r, b, a);

        public readonly half4 grar => new half4(g, r, a, r);
        public readonly half4 grag => new half4(g, r, a, g);
        public readonly half4 grab => new half4(g, r, a, b);
        public readonly half4 graa => new half4(g, r, a, a);

        // gg
        public readonly half4 ggrr => new half4(g, g, r, r);
        public readonly half4 ggrg => new half4(g, g, r, g);
        public readonly half4 ggrb => new half4(g, g, r, b);
        public readonly half4 ggra => new half4(g, g, r, a);

        public readonly half4 gggr => new half4(g, g, g, r);
        public readonly half4 gggg => new half4(g, g, g, g);
        public readonly half4 gggb => new half4(g, g, g, b);
        public readonly half4 ggga => new half4(g, g, g, a);

        public readonly half4 ggbr => new half4(g, g, b, r);
        public readonly half4 ggbg => new half4(g, g, b, g);
        public readonly half4 ggbb => new half4(g, g, b, b);
        public readonly half4 ggba => new half4(g, g, b, a);

        public readonly half4 ggar => new half4(g, g, a, r);
        public readonly half4 ggag => new half4(g, g, a, g);
        public readonly half4 ggab => new half4(g, g, a, b);
        public readonly half4 ggaa => new half4(g, g, a, a);

        // gb
        public readonly half4 gbrr => new half4(g, b, r, r);
        public readonly half4 gbrg => new half4(g, b, r, g);
        public readonly half4 gbrb => new half4(g, b, r, b);
        public readonly half4 gbra => new half4(g, b, r, a);

        public readonly half4 gbgr => new half4(g, b, g, r);
        public readonly half4 gbgg => new half4(g, b, g, g);
        public readonly half4 gbgb => new half4(g, b, g, b);
        public readonly half4 gbga => new half4(g, b, g, a);

        public readonly half4 gbbr => new half4(g, b, b, r);
        public readonly half4 gbbg => new half4(g, b, b, g);
        public readonly half4 gbbb => new half4(g, b, b, b);
        public readonly half4 gbba => new half4(g, b, b, a);

        public readonly half4 gbar => new half4(g, b, a, r);
        public readonly half4 gbag => new half4(g, b, a, g);
        public readonly half4 gbab => new half4(g, b, a, b);
        public readonly half4 gbaa => new half4(g, b, a, a);

        // ga
        public readonly half4 garr => new half4(g, a, r, r);
        public readonly half4 garg => new half4(g, a, r, g);
        public readonly half4 garb => new half4(g, a, r, b);
        public readonly half4 gara => new half4(g, a, r, a);

        public readonly half4 gagr => new half4(g, a, g, r);
        public readonly half4 gagg => new half4(g, a, g, g);
        public readonly half4 gagb => new half4(g, a, g, b);
        public readonly half4 gaga => new half4(g, a, g, a);

        public readonly half4 gabr => new half4(g, a, b, r);
        public readonly half4 gabg => new half4(g, a, b, g);
        public readonly half4 gabb => new half4(g, a, b, b);
        public readonly half4 gaba => new half4(g, a, b, a);

        public readonly half4 gaar => new half4(g, a, a, r);
        public readonly half4 gaag => new half4(g, a, a, g);
        public readonly half4 gaab => new half4(g, a, a, b);
        public readonly half4 gaaa => new half4(g, a, a, a);


        // b
        // br
        public readonly half4 brrr => new half4(b, r, r, r);
        public readonly half4 brrg => new half4(b, r, r, g);
        public readonly half4 brrb => new half4(b, r, r, b);
        public readonly half4 brra => new half4(b, r, r, a);

        public readonly half4 brgr => new half4(b, r, g, r);
        public readonly half4 brgg => new half4(b, r, g, g);
        public readonly half4 brgb => new half4(b, r, g, b);
        public readonly half4 brga => new half4(b, r, g, a);

        public readonly half4 brbr => new half4(b, r, b, r);
        public readonly half4 brbg => new half4(b, r, b, g);
        public readonly half4 brbb => new half4(b, r, b, b);
        public readonly half4 brba => new half4(b, r, b, a);

        public readonly half4 brar => new half4(b, r, a, r);
        public readonly half4 brag => new half4(b, r, a, g);
        public readonly half4 brab => new half4(b, r, a, b);
        public readonly half4 braa => new half4(b, r, a, a);

        // bg
        public readonly half4 bgrr => new half4(b, g, r, r);
        public readonly half4 bgrg => new half4(b, g, r, g);
        public readonly half4 bgrb => new half4(b, g, r, b);
        public readonly half4 bgra => new half4(b, g, r, a);

        public readonly half4 bggr => new half4(b, g, g, r);
        public readonly half4 bggg => new half4(b, g, g, g);
        public readonly half4 bggb => new half4(b, g, g, b);
        public readonly half4 bgga => new half4(b, g, g, a);

        public readonly half4 bgbr => new half4(b, g, b, r);
        public readonly half4 bgbg => new half4(b, g, b, g);
        public readonly half4 bgbb => new half4(b, g, b, b);
        public readonly half4 bgba => new half4(b, g, b, a);

        public readonly half4 bgar => new half4(b, g, a, r);
        public readonly half4 bgag => new half4(b, g, a, g);
        public readonly half4 bgab => new half4(b, g, a, b);
        public readonly half4 bgaa => new half4(b, g, a, a);

        // bb
        public readonly half4 bbrr => new half4(b, b, r, r);
        public readonly half4 bbrg => new half4(b, b, r, g);
        public readonly half4 bbrb => new half4(b, b, r, b);
        public readonly half4 bbra => new half4(b, b, r, a);

        public readonly half4 bbgr => new half4(b, b, g, r);
        public readonly half4 bbgg => new half4(b, b, g, g);
        public readonly half4 bbgb => new half4(b, b, g, b);
        public readonly half4 bbga => new half4(b, b, g, a);

        public readonly half4 bbbr => new half4(b, b, b, r);
        public readonly half4 bbbg => new half4(b, b, b, g);
        public readonly half4 bbbb => new half4(b, b, b, b);
        public readonly half4 bbba => new half4(b, b, b, a);

        public readonly half4 bbar => new half4(b, b, a, r);
        public readonly half4 bbag => new half4(b, b, a, g);
        public readonly half4 bbab => new half4(b, b, a, b);
        public readonly half4 bbaa => new half4(b, b, a, a);

        // ba
        public readonly half4 barr => new half4(b, a, r, r);
        public readonly half4 barg => new half4(b, a, r, g);
        public readonly half4 barb => new half4(b, a, r, b);
        public readonly half4 bara => new half4(b, a, r, a);

        public readonly half4 bagr => new half4(b, a, g, r);
        public readonly half4 bagg => new half4(b, a, g, g);
        public readonly half4 bagb => new half4(b, a, g, b);
        public readonly half4 baga => new half4(b, a, g, a);

        public readonly half4 babr => new half4(b, a, b, r);
        public readonly half4 babg => new half4(b, a, b, g);
        public readonly half4 babb => new half4(b, a, b, b);
        public readonly half4 baba => new half4(b, a, b, a);

        public readonly half4 baar => new half4(b, a, a, r);
        public readonly half4 baag => new half4(b, a, a, g);
        public readonly half4 baab => new half4(b, a, a, b);
        public readonly half4 baaa => new half4(b, a, a, a);


        // a
        // ar
        public readonly half4 arrr => new half4(a, r, r, r);
        public readonly half4 arrg => new half4(a, r, r, g);
        public readonly half4 arrb => new half4(a, r, r, b);
        public readonly half4 arra => new half4(a, r, r, a);

        public readonly half4 argr => new half4(a, r, g, r);
        public readonly half4 argg => new half4(a, r, g, g);
        public readonly half4 argb => new half4(a, r, g, b);
        public readonly half4 arga => new half4(a, r, g, a);

        public readonly half4 arbr => new half4(a, r, b, r);
        public readonly half4 arbg => new half4(a, r, b, g);
        public readonly half4 arbb => new half4(a, r, b, b);
        public readonly half4 arba => new half4(a, r, b, a);

        public readonly half4 arar => new half4(a, r, a, r);
        public readonly half4 arag => new half4(a, r, a, g);
        public readonly half4 arab => new half4(a, r, a, b);
        public readonly half4 araa => new half4(a, r, a, a);

        // ag
        public readonly half4 agrr => new half4(a, g, r, r);
        public readonly half4 agrg => new half4(a, g, r, g);
        public readonly half4 agrb => new half4(a, g, r, b);
        public readonly half4 agra => new half4(a, g, r, a);

        public readonly half4 aggr => new half4(a, g, g, r);
        public readonly half4 aggg => new half4(a, g, g, g);
        public readonly half4 aggb => new half4(a, g, g, b);
        public readonly half4 agga => new half4(a, g, g, a);

        public readonly half4 agbr => new half4(a, g, b, r);
        public readonly half4 agbg => new half4(a, g, b, g);
        public readonly half4 agbb => new half4(a, g, b, b);
        public readonly half4 agba => new half4(a, g, b, a);

        public readonly half4 agar => new half4(a, g, a, r);
        public readonly half4 agag => new half4(a, g, a, g);
        public readonly half4 agab => new half4(a, g, a, b);
        public readonly half4 agaa => new half4(a, g, a, a);

        // ab
        public readonly half4 abrr => new half4(a, b, r, r);
        public readonly half4 abrg => new half4(a, b, r, g);
        public readonly half4 abrb => new half4(a, b, r, b);
        public readonly half4 abra => new half4(a, b, r, a);

        public readonly half4 abgr => new half4(a, b, g, r);
        public readonly half4 abgg => new half4(a, b, g, g);
        public readonly half4 abgb => new half4(a, b, g, b);
        public readonly half4 abga => new half4(a, b, g, a);

        public readonly half4 abbr => new half4(a, b, b, r);
        public readonly half4 abbg => new half4(a, b, b, g);
        public readonly half4 abbb => new half4(a, b, b, b);
        public readonly half4 abba => new half4(a, b, b, a);

        public readonly half4 abar => new half4(a, b, a, r);
        public readonly half4 abag => new half4(a, b, a, g);
        public readonly half4 abab => new half4(a, b, a, b);
        public readonly half4 abaa => new half4(a, b, a, a);

        // aa
        public readonly half4 aarr => new half4(a, a, r, r);
        public readonly half4 aarg => new half4(a, a, r, g);
        public readonly half4 aarb => new half4(a, a, r, b);
        public readonly half4 aara => new half4(a, a, r, a);

        public readonly half4 aagr => new half4(a, a, g, r);
        public readonly half4 aagg => new half4(a, a, g, g);
        public readonly half4 aagb => new half4(a, a, g, b);
        public readonly half4 aaga => new half4(a, a, g, a);

        public readonly half4 aabr => new half4(a, a, b, r);
        public readonly half4 aabg => new half4(a, a, b, g);
        public readonly half4 aabb => new half4(a, a, b, b);
        public readonly half4 aaba => new half4(a, a, b, a);

        public readonly half4 aaar => new half4(a, a, a, r);
        public readonly half4 aaag => new half4(a, a, a, g);
        public readonly half4 aaab => new half4(a, a, a, b);
        public readonly half4 aaaa => new half4(a, a, a, a);

        #endregion Swizzles_half4_RGBA
        #region Swizzles_Extra

        // Swizzles - half3

        // x
        public readonly half3 xxx => new half3(x, x, x);
        public readonly half3 xxy => new half3(x, x, y);
        public readonly half3 xxz => new half3(x, x, z);
        public readonly half3 xxw => new half3(x, x, w);

        public readonly half3 xyx => new half3(x, y, x);
        public readonly half3 xyy => new half3(x, y, y);
        public readonly half3 xyz => new half3(x, y, z);
        public readonly half3 xyw => new half3(x, y, w);

        public readonly half3 xzx => new half3(x, z, x);
        public readonly half3 xzy => new half3(x, z, y);
        public readonly half3 xzz => new half3(x, z, z);
        public readonly half3 xzw => new half3(x, z, w);

        public readonly half3 xwx => new half3(x, w, x);
        public readonly half3 xwy => new half3(x, w, y);
        public readonly half3 xwz => new half3(x, w, z);
        public readonly half3 xww => new half3(x, w, w);

        // y
        public readonly half3 yxx => new half3(y, x, x);
        public readonly half3 yxy => new half3(y, x, y);
        public readonly half3 yxz => new half3(y, x, z);
        public readonly half3 yxw => new half3(y, x, w);

        public readonly half3 yyx => new half3(y, y, x);
        public readonly half3 yyy => new half3(y, y, y);
        public readonly half3 yyz => new half3(y, y, z);
        public readonly half3 yyw => new half3(y, y, w);

        public readonly half3 yzx => new half3(y, z, x);
        public readonly half3 yzy => new half3(y, z, y);
        public readonly half3 yzz => new half3(y, z, z);
        public readonly half3 yzw => new half3(y, z, w);

        public readonly half3 ywx => new half3(y, w, x);
        public readonly half3 ywy => new half3(y, w, y);
        public readonly half3 ywz => new half3(y, w, z);
        public readonly half3 yww => new half3(y, w, w);

        // z
        public readonly half3 zxx => new half3(z, x, x);
        public readonly half3 zxy => new half3(z, x, y);
        public readonly half3 zxz => new half3(z, x, z);
        public readonly half3 zxw => new half3(z, x, w);

        public readonly half3 zyx => new half3(z, y, x);
        public readonly half3 zyy => new half3(z, y, y);
        public readonly half3 zyz => new half3(z, y, z);
        public readonly half3 zyw => new half3(z, y, w);

        public readonly half3 zzx => new half3(z, z, x);
        public readonly half3 zzy => new half3(z, z, y);
        public readonly half3 zzz => new half3(z, z, z);
        public readonly half3 zzw => new half3(z, z, w);

        public readonly half3 zwx => new half3(z, w, x);
        public readonly half3 zwy => new half3(z, w, y);
        public readonly half3 zwz => new half3(z, w, z);
        public readonly half3 zww => new half3(z, w, w);

        // w
        public readonly half3 wxx => new half3(w, x, x);
        public readonly half3 wxy => new half3(w, x, y);
        public readonly half3 wxz => new half3(w, x, z);
        public readonly half3 wxw => new half3(w, x, w);

        public readonly half3 wyx => new half3(w, y, x);
        public readonly half3 wyy => new half3(w, y, y);
        public readonly half3 wyz => new half3(w, y, z);
        public readonly half3 wyw => new half3(w, y, w);

        public readonly half3 wzx => new half3(w, z, x);
        public readonly half3 wzy => new half3(w, z, y);
        public readonly half3 wzz => new half3(w, z, z);
        public readonly half3 wzw => new half3(w, z, w);

        public readonly half3 wwx => new half3(w, w, x);
        public readonly half3 wwy => new half3(w, w, y);
        public readonly half3 wwz => new half3(w, w, z);
        public readonly half3 www => new half3(w, w, w);

        // Swizzles - half2

        public readonly half2 xx => new half2(x, x);
        public readonly half2 xy => new half2(x, y);
        public readonly half2 xz => new half2(x, z);
        public readonly half2 xw => new half2(x, w);

        public readonly half2 yx => new half2(y, x);
        public readonly half2 yy => new half2(y, y);
        public readonly half2 yz => new half2(y, z);
        public readonly half2 yw => new half2(y, w);

        public readonly half2 zx => new half2(z, x);
        public readonly half2 zy => new half2(z, y);
        public readonly half2 zz => new half2(z, z);
        public readonly half2 zw => new half2(z, w);

        public readonly half2 wx => new half2(w, x);
        public readonly half2 wy => new half2(w, y);
        public readonly half2 wz => new half2(w, z);
        public readonly half2 ww => new half2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - half3

        // r
        public readonly half3 rrr => new half3(r, r, r);
        public readonly half3 rrg => new half3(r, r, g);
        public readonly half3 rrb => new half3(r, r, b);
        public readonly half3 rra => new half3(r, r, a);

        public readonly half3 rgr => new half3(r, g, r);
        public readonly half3 rgg => new half3(r, g, g);
        public readonly half3 rgb => new half3(r, g, b);
        public readonly half3 rga => new half3(r, g, a);

        public readonly half3 rbr => new half3(r, b, r);
        public readonly half3 rbg => new half3(r, b, g);
        public readonly half3 rbb => new half3(r, b, b);
        public readonly half3 rba => new half3(r, b, a);

        public readonly half3 rar => new half3(r, a, r);
        public readonly half3 rag => new half3(r, a, g);
        public readonly half3 rab => new half3(r, a, b);
        public readonly half3 raa => new half3(r, a, a);

        // g
        public readonly half3 grr => new half3(g, r, r);
        public readonly half3 grg => new half3(g, r, g);
        public readonly half3 grb => new half3(g, r, b);
        public readonly half3 gra => new half3(g, r, a);

        public readonly half3 ggr => new half3(g, g, r);
        public readonly half3 ggg => new half3(g, g, g);
        public readonly half3 ggb => new half3(g, g, b);
        public readonly half3 gga => new half3(g, g, a);

        public readonly half3 gbr => new half3(g, b, r);
        public readonly half3 gbg => new half3(g, b, g);
        public readonly half3 gbb => new half3(g, b, b);
        public readonly half3 gba => new half3(g, b, a);

        public readonly half3 gar => new half3(g, a, r);
        public readonly half3 gag => new half3(g, a, g);
        public readonly half3 gab => new half3(g, a, b);
        public readonly half3 gaa => new half3(g, a, a);

        // b
        public readonly half3 brr => new half3(b, r, r);
        public readonly half3 brg => new half3(b, r, g);
        public readonly half3 brb => new half3(b, r, b);
        public readonly half3 bra => new half3(b, r, a);

        public readonly half3 bgr => new half3(b, g, r);
        public readonly half3 bgg => new half3(b, g, g);
        public readonly half3 bgb => new half3(b, g, b);
        public readonly half3 bga => new half3(b, g, a);

        public readonly half3 bbr => new half3(b, b, r);
        public readonly half3 bbg => new half3(b, b, g);
        public readonly half3 bbb => new half3(b, b, b);
        public readonly half3 bba => new half3(b, b, a);

        public readonly half3 bar => new half3(b, a, r);
        public readonly half3 bag => new half3(b, a, g);
        public readonly half3 bab => new half3(b, a, b);
        public readonly half3 baa => new half3(b, a, a);

        // a
        public readonly half3 arr => new half3(a, r, r);
        public readonly half3 arg => new half3(a, r, g);
        public readonly half3 arb => new half3(a, r, b);
        public readonly half3 ara => new half3(a, r, a);

        public readonly half3 agr => new half3(a, g, r);
        public readonly half3 agg => new half3(a, g, g);
        public readonly half3 agb => new half3(a, g, b);
        public readonly half3 aga => new half3(a, g, a);

        public readonly half3 abr => new half3(a, b, r);
        public readonly half3 abg => new half3(a, b, g);
        public readonly half3 abb => new half3(a, b, b);
        public readonly half3 aba => new half3(a, b, a);

        public readonly half3 aar => new half3(a, a, r);
        public readonly half3 aag => new half3(a, a, g);
        public readonly half3 aab => new half3(a, a, b);
        public readonly half3 aaa => new half3(a, a, a);

        // RGBA - Swizzles - half2

        public readonly half2 rr => new half2(r, r);
        public readonly half2 rg => new half2(r, g);
        public readonly half2 rb => new half2(r, b);
        public readonly half2 ra => new half2(r, a);

        public readonly half2 gr => new half2(g, r);
        public readonly half2 gg => new half2(g, g);
        public readonly half2 gb => new half2(g, b);
        public readonly half2 ga => new half2(g, a);

        public readonly half2 br => new half2(b, r);
        public readonly half2 bg => new half2(b, g);
        public readonly half2 bb => new half2(b, b);
        public readonly half2 ba => new half2(b, a);

        public readonly half2 ar => new half2(a, r);
        public readonly half2 ag => new half2(a, g);
        public readonly half2 ab => new half2(a, b);
        public readonly half2 aa => new half2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
