namespace DivisionEngine.MathLib
{
    public partial struct bool4
    {
        #region Swizzles_bool4

        // Swizzles - bool4

        // x
        // xx
        public readonly bool4 xxxx => new bool4(x, x, x, x);
        public readonly bool4 xxxy => new bool4(x, x, x, y);
        public readonly bool4 xxxz => new bool4(x, x, x, z);
        public readonly bool4 xxxw => new bool4(x, x, x, w);

        public readonly bool4 xxyx => new bool4(x, x, y, x);
        public readonly bool4 xxyy => new bool4(x, x, y, y);
        public readonly bool4 xxyz => new bool4(x, x, y, z);
        public readonly bool4 xxyw => new bool4(x, x, y, w);

        public readonly bool4 xxzx => new bool4(x, x, z, x);
        public readonly bool4 xxzy => new bool4(x, x, z, y);
        public readonly bool4 xxzz => new bool4(x, x, z, z);
        public readonly bool4 xxzw => new bool4(x, x, z, w);

        public readonly bool4 xxwx => new bool4(x, x, w, x);
        public readonly bool4 xxwy => new bool4(x, x, w, y);
        public readonly bool4 xxwz => new bool4(x, x, w, z);
        public readonly bool4 xxww => new bool4(x, x, w, w);

        // xy
        public readonly bool4 xyxx => new bool4(x, y, x, x);
        public readonly bool4 xyxy => new bool4(x, y, x, y);
        public readonly bool4 xyxz => new bool4(x, y, x, z);
        public readonly bool4 xyxw => new bool4(x, y, x, w);

        public readonly bool4 xyyx => new bool4(x, y, y, x);
        public readonly bool4 xyyy => new bool4(x, y, y, y);
        public readonly bool4 xyyz => new bool4(x, y, y, z);
        public readonly bool4 xyyw => new bool4(x, y, y, w);

        public readonly bool4 xyzx => new bool4(x, y, z, x);
        public readonly bool4 xyzy => new bool4(x, y, z, y);
        public readonly bool4 xyzz => new bool4(x, y, z, z);
        public readonly bool4 xyzw => new bool4(x, y, z, w);

        public readonly bool4 xywx => new bool4(x, y, w, x);
        public readonly bool4 xywy => new bool4(x, y, w, y);
        public readonly bool4 xywz => new bool4(x, y, w, z);
        public readonly bool4 xyww => new bool4(x, y, w, w);

        // xz
        public readonly bool4 xzxx => new bool4(x, z, x, x);
        public readonly bool4 xzxy => new bool4(x, z, x, y);
        public readonly bool4 xzxz => new bool4(x, z, x, z);
        public readonly bool4 xzxw => new bool4(x, z, x, w);

        public readonly bool4 xzyx => new bool4(x, z, y, x);
        public readonly bool4 xzyy => new bool4(x, z, y, y);
        public readonly bool4 xzyz => new bool4(x, z, y, z);
        public readonly bool4 xzyw => new bool4(x, z, y, w);

        public readonly bool4 xzzx => new bool4(x, z, z, x);
        public readonly bool4 xzzy => new bool4(x, z, z, y);
        public readonly bool4 xzzz => new bool4(x, z, z, z);
        public readonly bool4 xzzw => new bool4(x, z, z, w);

        public readonly bool4 xzwx => new bool4(x, z, w, x);
        public readonly bool4 xzwy => new bool4(x, z, w, y);
        public readonly bool4 xzwz => new bool4(x, z, w, z);
        public readonly bool4 xzww => new bool4(x, z, w, w);

        // xw
        public readonly bool4 xwxx => new bool4(x, w, x, x);
        public readonly bool4 xwxy => new bool4(x, w, x, y);
        public readonly bool4 xwxz => new bool4(x, w, x, z);
        public readonly bool4 xwxw => new bool4(x, w, x, w);

        public readonly bool4 xwyx => new bool4(x, w, y, x);
        public readonly bool4 xwyy => new bool4(x, w, y, y);
        public readonly bool4 xwyz => new bool4(x, w, y, z);
        public readonly bool4 xwyw => new bool4(x, w, y, w);

        public readonly bool4 xwzx => new bool4(x, w, z, x);
        public readonly bool4 xwzy => new bool4(x, w, z, y);
        public readonly bool4 xwzz => new bool4(x, w, z, z);
        public readonly bool4 xwzw => new bool4(x, w, z, w);

        public readonly bool4 xwwx => new bool4(x, w, w, x);
        public readonly bool4 xwwy => new bool4(x, w, w, y);
        public readonly bool4 xwwz => new bool4(x, w, w, z);
        public readonly bool4 xwww => new bool4(x, w, w, w);


        // y
        // yx
        public readonly bool4 yxxx => new bool4(y, x, x, x);
        public readonly bool4 yxxy => new bool4(y, x, x, y);
        public readonly bool4 yxxz => new bool4(y, x, x, z);
        public readonly bool4 yxxw => new bool4(y, x, x, w);

        public readonly bool4 yxyx => new bool4(y, x, y, x);
        public readonly bool4 yxyy => new bool4(y, x, y, y);
        public readonly bool4 yxyz => new bool4(y, x, y, z);
        public readonly bool4 yxyw => new bool4(y, x, y, w);

        public readonly bool4 yxzx => new bool4(y, x, z, x);
        public readonly bool4 yxzy => new bool4(y, x, z, y);
        public readonly bool4 yxzz => new bool4(y, x, z, z);
        public readonly bool4 yxzw => new bool4(y, x, z, w);

        public readonly bool4 yxwx => new bool4(y, x, w, x);
        public readonly bool4 yxwy => new bool4(y, x, w, y);
        public readonly bool4 yxwz => new bool4(y, x, w, z);
        public readonly bool4 yxww => new bool4(y, x, w, w);

        // yy
        public readonly bool4 yyxx => new bool4(y, y, x, x);
        public readonly bool4 yyxy => new bool4(y, y, x, y);
        public readonly bool4 yyxz => new bool4(y, y, x, z);
        public readonly bool4 yyxw => new bool4(y, y, x, w);

        public readonly bool4 yyyx => new bool4(y, y, y, x);
        public readonly bool4 yyyy => new bool4(y, y, y, y);
        public readonly bool4 yyyz => new bool4(y, y, y, z);
        public readonly bool4 yyyw => new bool4(y, y, y, w);

        public readonly bool4 yyzx => new bool4(y, y, z, x);
        public readonly bool4 yyzy => new bool4(y, y, z, y);
        public readonly bool4 yyzz => new bool4(y, y, z, z);
        public readonly bool4 yyzw => new bool4(y, y, z, w);

        public readonly bool4 yywx => new bool4(y, y, w, x);
        public readonly bool4 yywy => new bool4(y, y, w, y);
        public readonly bool4 yywz => new bool4(y, y, w, z);
        public readonly bool4 yyww => new bool4(y, y, w, w);

        // yz
        public readonly bool4 yzxx => new bool4(y, z, x, x);
        public readonly bool4 yzxy => new bool4(y, z, x, y);
        public readonly bool4 yzxz => new bool4(y, z, x, z);
        public readonly bool4 yzxw => new bool4(y, z, x, w);

        public readonly bool4 yzyx => new bool4(y, z, y, x);
        public readonly bool4 yzyy => new bool4(y, z, y, y);
        public readonly bool4 yzyz => new bool4(y, z, y, z);
        public readonly bool4 yzyw => new bool4(y, z, y, w);

        public readonly bool4 yzzx => new bool4(y, z, z, x);
        public readonly bool4 yzzy => new bool4(y, z, z, y);
        public readonly bool4 yzzz => new bool4(y, z, z, z);
        public readonly bool4 yzzw => new bool4(y, z, z, w);

        public readonly bool4 yzwx => new bool4(y, z, w, x);
        public readonly bool4 yzwy => new bool4(y, z, w, y);
        public readonly bool4 yzwz => new bool4(y, z, w, z);
        public readonly bool4 yzww => new bool4(y, z, w, w);

        // yw
        public readonly bool4 ywxx => new bool4(y, w, x, x);
        public readonly bool4 ywxy => new bool4(y, w, x, y);
        public readonly bool4 ywxz => new bool4(y, w, x, z);
        public readonly bool4 ywxw => new bool4(y, w, x, w);

        public readonly bool4 ywyx => new bool4(y, w, y, x);
        public readonly bool4 ywyy => new bool4(y, w, y, y);
        public readonly bool4 ywyz => new bool4(y, w, y, z);
        public readonly bool4 ywyw => new bool4(y, w, y, w);

        public readonly bool4 ywzx => new bool4(y, w, z, x);
        public readonly bool4 ywzy => new bool4(y, w, z, y);
        public readonly bool4 ywzz => new bool4(y, w, z, z);
        public readonly bool4 ywzw => new bool4(y, w, z, w);

        public readonly bool4 ywwx => new bool4(y, w, w, x);
        public readonly bool4 ywwy => new bool4(y, w, w, y);
        public readonly bool4 ywwz => new bool4(y, w, w, z);
        public readonly bool4 ywww => new bool4(y, w, w, w);


        // z
        // zx
        public readonly bool4 zxxx => new bool4(z, x, x, x);
        public readonly bool4 zxxy => new bool4(z, x, x, y);
        public readonly bool4 zxxz => new bool4(z, x, x, z);
        public readonly bool4 zxxw => new bool4(z, x, x, w);

        public readonly bool4 zxyx => new bool4(z, x, y, x);
        public readonly bool4 zxyy => new bool4(z, x, y, y);
        public readonly bool4 zxyz => new bool4(z, x, y, z);
        public readonly bool4 zxyw => new bool4(z, x, y, w);

        public readonly bool4 zxzx => new bool4(z, x, z, x);
        public readonly bool4 zxzy => new bool4(z, x, z, y);
        public readonly bool4 zxzz => new bool4(z, x, z, z);
        public readonly bool4 zxzw => new bool4(z, x, z, w);

        public readonly bool4 zxwx => new bool4(z, x, w, x);
        public readonly bool4 zxwy => new bool4(z, x, w, y);
        public readonly bool4 zxwz => new bool4(z, x, w, z);
        public readonly bool4 zxww => new bool4(z, x, w, w);

        // zy
        public readonly bool4 zyxx => new bool4(z, y, x, x);
        public readonly bool4 zyxy => new bool4(z, y, x, y);
        public readonly bool4 zyxz => new bool4(z, y, x, z);
        public readonly bool4 zyxw => new bool4(z, y, x, w);

        public readonly bool4 zyyx => new bool4(z, y, y, x);
        public readonly bool4 zyyy => new bool4(z, y, y, y);
        public readonly bool4 zyyz => new bool4(z, y, y, z);
        public readonly bool4 zyyw => new bool4(z, y, y, w);

        public readonly bool4 zyzx => new bool4(z, y, z, x);
        public readonly bool4 zyzy => new bool4(z, y, z, y);
        public readonly bool4 zyzz => new bool4(z, y, z, z);
        public readonly bool4 zyzw => new bool4(z, y, z, w);

        public readonly bool4 zywx => new bool4(z, y, w, x);
        public readonly bool4 zywy => new bool4(z, y, w, y);
        public readonly bool4 zywz => new bool4(z, y, w, z);
        public readonly bool4 zyww => new bool4(z, y, w, w);

        // zz
        public readonly bool4 zzxx => new bool4(z, z, x, x);
        public readonly bool4 zzxy => new bool4(z, z, x, y);
        public readonly bool4 zzxz => new bool4(z, z, x, z);
        public readonly bool4 zzxw => new bool4(z, z, x, w);

        public readonly bool4 zzyx => new bool4(z, z, y, x);
        public readonly bool4 zzyy => new bool4(z, z, y, y);
        public readonly bool4 zzyz => new bool4(z, z, y, z);
        public readonly bool4 zzyw => new bool4(z, z, y, w);

        public readonly bool4 zzzx => new bool4(z, z, z, x);
        public readonly bool4 zzzy => new bool4(z, z, z, y);
        public readonly bool4 zzzz => new bool4(z, z, z, z);
        public readonly bool4 zzzw => new bool4(z, z, z, w);

        public readonly bool4 zzwx => new bool4(z, z, w, x);
        public readonly bool4 zzwy => new bool4(z, z, w, y);
        public readonly bool4 zzwz => new bool4(z, z, w, z);
        public readonly bool4 zzww => new bool4(z, z, w, w);

        // zw
        public readonly bool4 zwxx => new bool4(z, w, x, x);
        public readonly bool4 zwxy => new bool4(z, w, x, y);
        public readonly bool4 zwxz => new bool4(z, w, x, z);
        public readonly bool4 zwxw => new bool4(z, w, x, w);

        public readonly bool4 zwyx => new bool4(z, w, y, x);
        public readonly bool4 zwyy => new bool4(z, w, y, y);
        public readonly bool4 zwyz => new bool4(z, w, y, z);
        public readonly bool4 zwyw => new bool4(z, w, y, w);

        public readonly bool4 zwzx => new bool4(z, w, z, x);
        public readonly bool4 zwzy => new bool4(z, w, z, y);
        public readonly bool4 zwzz => new bool4(z, w, z, z);
        public readonly bool4 zwzw => new bool4(z, w, z, w);

        public readonly bool4 zwwx => new bool4(z, w, w, x);
        public readonly bool4 zwwy => new bool4(z, w, w, y);
        public readonly bool4 zwwz => new bool4(z, w, w, z);
        public readonly bool4 zwww => new bool4(z, w, w, w);


        // w
        // wx
        public readonly bool4 wxxx => new bool4(w, x, x, x);
        public readonly bool4 wxxy => new bool4(w, x, x, y);
        public readonly bool4 wxxz => new bool4(w, x, x, z);
        public readonly bool4 wxxw => new bool4(w, x, x, w);

        public readonly bool4 wxyx => new bool4(w, x, y, x);
        public readonly bool4 wxyy => new bool4(w, x, y, y);
        public readonly bool4 wxyz => new bool4(w, x, y, z);
        public readonly bool4 wxyw => new bool4(w, x, y, w);

        public readonly bool4 wxzx => new bool4(w, x, z, x);
        public readonly bool4 wxzy => new bool4(w, x, z, y);
        public readonly bool4 wxzz => new bool4(w, x, z, z);
        public readonly bool4 wxzw => new bool4(w, x, z, w);

        public readonly bool4 wxwx => new bool4(w, x, w, x);
        public readonly bool4 wxwy => new bool4(w, x, w, y);
        public readonly bool4 wxwz => new bool4(w, x, w, z);
        public readonly bool4 wxww => new bool4(w, x, w, w);

        // wy
        public readonly bool4 wyxx => new bool4(w, y, x, x);
        public readonly bool4 wyxy => new bool4(w, y, x, y);
        public readonly bool4 wyxz => new bool4(w, y, x, z);
        public readonly bool4 wyxw => new bool4(w, y, x, w);

        public readonly bool4 wyyx => new bool4(w, y, y, x);
        public readonly bool4 wyyy => new bool4(w, y, y, y);
        public readonly bool4 wyyz => new bool4(w, y, y, z);
        public readonly bool4 wyyw => new bool4(w, y, y, w);

        public readonly bool4 wyzx => new bool4(w, y, z, x);
        public readonly bool4 wyzy => new bool4(w, y, z, y);
        public readonly bool4 wyzz => new bool4(w, y, z, z);
        public readonly bool4 wyzw => new bool4(w, y, z, w);

        public readonly bool4 wywx => new bool4(w, y, w, x);
        public readonly bool4 wywy => new bool4(w, y, w, y);
        public readonly bool4 wywz => new bool4(w, y, w, z);
        public readonly bool4 wyww => new bool4(w, y, w, w);

        // wz
        public readonly bool4 wzxx => new bool4(w, z, x, x);
        public readonly bool4 wzxy => new bool4(w, z, x, y);
        public readonly bool4 wzxz => new bool4(w, z, x, z);
        public readonly bool4 wzxw => new bool4(w, z, x, w);

        public readonly bool4 wzyx => new bool4(w, z, y, x);
        public readonly bool4 wzyy => new bool4(w, z, y, y);
        public readonly bool4 wzyz => new bool4(w, z, y, z);
        public readonly bool4 wzyw => new bool4(w, z, y, w);

        public readonly bool4 wzzx => new bool4(w, z, z, x);
        public readonly bool4 wzzy => new bool4(w, z, z, y);
        public readonly bool4 wzzz => new bool4(w, z, z, z);
        public readonly bool4 wzzw => new bool4(w, z, z, w);

        public readonly bool4 wzwx => new bool4(w, z, w, x);
        public readonly bool4 wzwy => new bool4(w, z, w, y);
        public readonly bool4 wzwz => new bool4(w, z, w, z);
        public readonly bool4 wzww => new bool4(w, z, w, w);

        // ww
        public readonly bool4 wwxx => new bool4(w, w, x, x);
        public readonly bool4 wwxy => new bool4(w, w, x, y);
        public readonly bool4 wwxz => new bool4(w, w, x, z);
        public readonly bool4 wwxw => new bool4(w, w, x, w);

        public readonly bool4 wwyx => new bool4(w, w, y, x);
        public readonly bool4 wwyy => new bool4(w, w, y, y);
        public readonly bool4 wwyz => new bool4(w, w, y, z);
        public readonly bool4 wwyw => new bool4(w, w, y, w);

        public readonly bool4 wwzx => new bool4(w, w, z, x);
        public readonly bool4 wwzy => new bool4(w, w, z, y);
        public readonly bool4 wwzz => new bool4(w, w, z, z);
        public readonly bool4 wwzw => new bool4(w, w, z, w);

        public readonly bool4 wwwx => new bool4(w, w, w, x);
        public readonly bool4 wwwy => new bool4(w, w, w, y);
        public readonly bool4 wwwz => new bool4(w, w, w, z);
        public readonly bool4 wwww => new bool4(w, w, w, w);

        #endregion Swizzles_bool4
        #region Swizzles_bool4_RGBA

        // RGBA - Swizzles - bool4

        // r
        // rr
        public readonly bool4 rrrr => new bool4(r, r, r, r);
        public readonly bool4 rrrg => new bool4(r, r, r, g);
        public readonly bool4 rrrb => new bool4(r, r, r, b);
        public readonly bool4 rrra => new bool4(r, r, r, a);

        public readonly bool4 rrgr => new bool4(r, r, g, r);
        public readonly bool4 rrgg => new bool4(r, r, g, g);
        public readonly bool4 rrgb => new bool4(r, r, g, b);
        public readonly bool4 rrga => new bool4(r, r, g, a);

        public readonly bool4 rrbr => new bool4(r, r, b, r);
        public readonly bool4 rrbg => new bool4(r, r, b, g);
        public readonly bool4 rrbb => new bool4(r, r, b, b);
        public readonly bool4 rrba => new bool4(r, r, b, a);

        public readonly bool4 rrar => new bool4(r, r, a, r);
        public readonly bool4 rrag => new bool4(r, r, a, g);
        public readonly bool4 rrab => new bool4(r, r, a, b);
        public readonly bool4 rraa => new bool4(r, r, a, a);

        // rg
        public readonly bool4 rgrr => new bool4(r, g, r, r);
        public readonly bool4 rgrg => new bool4(r, g, r, g);
        public readonly bool4 rgrb => new bool4(r, g, r, b);
        public readonly bool4 rgra => new bool4(r, g, r, a);

        public readonly bool4 rggr => new bool4(r, g, g, r);
        public readonly bool4 rggg => new bool4(r, g, g, g);
        public readonly bool4 rggb => new bool4(r, g, g, b);
        public readonly bool4 rgga => new bool4(r, g, g, a);

        public readonly bool4 rgbr => new bool4(r, g, b, r);
        public readonly bool4 rgbg => new bool4(r, g, b, g);
        public readonly bool4 rgbb => new bool4(r, g, b, b);
        public readonly bool4 rgba => new bool4(r, g, b, a);

        public readonly bool4 rgar => new bool4(r, g, a, r);
        public readonly bool4 rgag => new bool4(r, g, a, g);
        public readonly bool4 rgab => new bool4(r, g, a, b);
        public readonly bool4 rgaa => new bool4(r, g, a, a);

        // rb
        public readonly bool4 rbrr => new bool4(r, b, r, r);
        public readonly bool4 rbrg => new bool4(r, b, r, g);
        public readonly bool4 rbrb => new bool4(r, b, r, b);
        public readonly bool4 rbra => new bool4(r, b, r, a);

        public readonly bool4 rbgr => new bool4(r, b, g, r);
        public readonly bool4 rbgg => new bool4(r, b, g, g);
        public readonly bool4 rbgb => new bool4(r, b, g, b);
        public readonly bool4 rbga => new bool4(r, b, g, a);

        public readonly bool4 rbbr => new bool4(r, b, b, r);
        public readonly bool4 rbbg => new bool4(r, b, b, g);
        public readonly bool4 rbbb => new bool4(r, b, b, b);
        public readonly bool4 rbba => new bool4(r, b, b, a);

        public readonly bool4 rbar => new bool4(r, b, a, r);
        public readonly bool4 rbag => new bool4(r, b, a, g);
        public readonly bool4 rbab => new bool4(r, b, a, b);
        public readonly bool4 rbaa => new bool4(r, b, a, a);

        // ra
        public readonly bool4 rarr => new bool4(r, a, r, r);
        public readonly bool4 rarg => new bool4(r, a, r, g);
        public readonly bool4 rarb => new bool4(r, a, r, b);
        public readonly bool4 rara => new bool4(r, a, r, a);

        public readonly bool4 ragr => new bool4(r, a, g, r);
        public readonly bool4 ragg => new bool4(r, a, g, g);
        public readonly bool4 ragb => new bool4(r, a, g, b);
        public readonly bool4 raga => new bool4(r, a, g, a);

        public readonly bool4 rabr => new bool4(r, a, b, r);
        public readonly bool4 rabg => new bool4(r, a, b, g);
        public readonly bool4 rabb => new bool4(r, a, b, b);
        public readonly bool4 raba => new bool4(r, a, b, a);

        public readonly bool4 raar => new bool4(r, a, a, r);
        public readonly bool4 raag => new bool4(r, a, a, g);
        public readonly bool4 raab => new bool4(r, a, a, b);
        public readonly bool4 raaa => new bool4(r, a, a, a);


        // g
        // gr
        public readonly bool4 grrr => new bool4(g, r, r, r);
        public readonly bool4 grrg => new bool4(g, r, r, g);
        public readonly bool4 grrb => new bool4(g, r, r, b);
        public readonly bool4 grra => new bool4(g, r, r, a);

        public readonly bool4 grgr => new bool4(g, r, g, r);
        public readonly bool4 grgg => new bool4(g, r, g, g);
        public readonly bool4 grgb => new bool4(g, r, g, b);
        public readonly bool4 grga => new bool4(g, r, g, a);

        public readonly bool4 grbr => new bool4(g, r, b, r);
        public readonly bool4 grbg => new bool4(g, r, b, g);
        public readonly bool4 grbb => new bool4(g, r, b, b);
        public readonly bool4 grba => new bool4(g, r, b, a);

        public readonly bool4 grar => new bool4(g, r, a, r);
        public readonly bool4 grag => new bool4(g, r, a, g);
        public readonly bool4 grab => new bool4(g, r, a, b);
        public readonly bool4 graa => new bool4(g, r, a, a);

        // gg
        public readonly bool4 ggrr => new bool4(g, g, r, r);
        public readonly bool4 ggrg => new bool4(g, g, r, g);
        public readonly bool4 ggrb => new bool4(g, g, r, b);
        public readonly bool4 ggra => new bool4(g, g, r, a);

        public readonly bool4 gggr => new bool4(g, g, g, r);
        public readonly bool4 gggg => new bool4(g, g, g, g);
        public readonly bool4 gggb => new bool4(g, g, g, b);
        public readonly bool4 ggga => new bool4(g, g, g, a);

        public readonly bool4 ggbr => new bool4(g, g, b, r);
        public readonly bool4 ggbg => new bool4(g, g, b, g);
        public readonly bool4 ggbb => new bool4(g, g, b, b);
        public readonly bool4 ggba => new bool4(g, g, b, a);

        public readonly bool4 ggar => new bool4(g, g, a, r);
        public readonly bool4 ggag => new bool4(g, g, a, g);
        public readonly bool4 ggab => new bool4(g, g, a, b);
        public readonly bool4 ggaa => new bool4(g, g, a, a);

        // gb
        public readonly bool4 gbrr => new bool4(g, b, r, r);
        public readonly bool4 gbrg => new bool4(g, b, r, g);
        public readonly bool4 gbrb => new bool4(g, b, r, b);
        public readonly bool4 gbra => new bool4(g, b, r, a);

        public readonly bool4 gbgr => new bool4(g, b, g, r);
        public readonly bool4 gbgg => new bool4(g, b, g, g);
        public readonly bool4 gbgb => new bool4(g, b, g, b);
        public readonly bool4 gbga => new bool4(g, b, g, a);

        public readonly bool4 gbbr => new bool4(g, b, b, r);
        public readonly bool4 gbbg => new bool4(g, b, b, g);
        public readonly bool4 gbbb => new bool4(g, b, b, b);
        public readonly bool4 gbba => new bool4(g, b, b, a);

        public readonly bool4 gbar => new bool4(g, b, a, r);
        public readonly bool4 gbag => new bool4(g, b, a, g);
        public readonly bool4 gbab => new bool4(g, b, a, b);
        public readonly bool4 gbaa => new bool4(g, b, a, a);

        // ga
        public readonly bool4 garr => new bool4(g, a, r, r);
        public readonly bool4 garg => new bool4(g, a, r, g);
        public readonly bool4 garb => new bool4(g, a, r, b);
        public readonly bool4 gara => new bool4(g, a, r, a);

        public readonly bool4 gagr => new bool4(g, a, g, r);
        public readonly bool4 gagg => new bool4(g, a, g, g);
        public readonly bool4 gagb => new bool4(g, a, g, b);
        public readonly bool4 gaga => new bool4(g, a, g, a);

        public readonly bool4 gabr => new bool4(g, a, b, r);
        public readonly bool4 gabg => new bool4(g, a, b, g);
        public readonly bool4 gabb => new bool4(g, a, b, b);
        public readonly bool4 gaba => new bool4(g, a, b, a);

        public readonly bool4 gaar => new bool4(g, a, a, r);
        public readonly bool4 gaag => new bool4(g, a, a, g);
        public readonly bool4 gaab => new bool4(g, a, a, b);
        public readonly bool4 gaaa => new bool4(g, a, a, a);


        // b
        // br
        public readonly bool4 brrr => new bool4(b, r, r, r);
        public readonly bool4 brrg => new bool4(b, r, r, g);
        public readonly bool4 brrb => new bool4(b, r, r, b);
        public readonly bool4 brra => new bool4(b, r, r, a);

        public readonly bool4 brgr => new bool4(b, r, g, r);
        public readonly bool4 brgg => new bool4(b, r, g, g);
        public readonly bool4 brgb => new bool4(b, r, g, b);
        public readonly bool4 brga => new bool4(b, r, g, a);

        public readonly bool4 brbr => new bool4(b, r, b, r);
        public readonly bool4 brbg => new bool4(b, r, b, g);
        public readonly bool4 brbb => new bool4(b, r, b, b);
        public readonly bool4 brba => new bool4(b, r, b, a);

        public readonly bool4 brar => new bool4(b, r, a, r);
        public readonly bool4 brag => new bool4(b, r, a, g);
        public readonly bool4 brab => new bool4(b, r, a, b);
        public readonly bool4 braa => new bool4(b, r, a, a);

        // bg
        public readonly bool4 bgrr => new bool4(b, g, r, r);
        public readonly bool4 bgrg => new bool4(b, g, r, g);
        public readonly bool4 bgrb => new bool4(b, g, r, b);
        public readonly bool4 bgra => new bool4(b, g, r, a);

        public readonly bool4 bggr => new bool4(b, g, g, r);
        public readonly bool4 bggg => new bool4(b, g, g, g);
        public readonly bool4 bggb => new bool4(b, g, g, b);
        public readonly bool4 bgga => new bool4(b, g, g, a);

        public readonly bool4 bgbr => new bool4(b, g, b, r);
        public readonly bool4 bgbg => new bool4(b, g, b, g);
        public readonly bool4 bgbb => new bool4(b, g, b, b);
        public readonly bool4 bgba => new bool4(b, g, b, a);

        public readonly bool4 bgar => new bool4(b, g, a, r);
        public readonly bool4 bgag => new bool4(b, g, a, g);
        public readonly bool4 bgab => new bool4(b, g, a, b);
        public readonly bool4 bgaa => new bool4(b, g, a, a);

        // bb
        public readonly bool4 bbrr => new bool4(b, b, r, r);
        public readonly bool4 bbrg => new bool4(b, b, r, g);
        public readonly bool4 bbrb => new bool4(b, b, r, b);
        public readonly bool4 bbra => new bool4(b, b, r, a);

        public readonly bool4 bbgr => new bool4(b, b, g, r);
        public readonly bool4 bbgg => new bool4(b, b, g, g);
        public readonly bool4 bbgb => new bool4(b, b, g, b);
        public readonly bool4 bbga => new bool4(b, b, g, a);

        public readonly bool4 bbbr => new bool4(b, b, b, r);
        public readonly bool4 bbbg => new bool4(b, b, b, g);
        public readonly bool4 bbbb => new bool4(b, b, b, b);
        public readonly bool4 bbba => new bool4(b, b, b, a);

        public readonly bool4 bbar => new bool4(b, b, a, r);
        public readonly bool4 bbag => new bool4(b, b, a, g);
        public readonly bool4 bbab => new bool4(b, b, a, b);
        public readonly bool4 bbaa => new bool4(b, b, a, a);

        // ba
        public readonly bool4 barr => new bool4(b, a, r, r);
        public readonly bool4 barg => new bool4(b, a, r, g);
        public readonly bool4 barb => new bool4(b, a, r, b);
        public readonly bool4 bara => new bool4(b, a, r, a);

        public readonly bool4 bagr => new bool4(b, a, g, r);
        public readonly bool4 bagg => new bool4(b, a, g, g);
        public readonly bool4 bagb => new bool4(b, a, g, b);
        public readonly bool4 baga => new bool4(b, a, g, a);

        public readonly bool4 babr => new bool4(b, a, b, r);
        public readonly bool4 babg => new bool4(b, a, b, g);
        public readonly bool4 babb => new bool4(b, a, b, b);
        public readonly bool4 baba => new bool4(b, a, b, a);

        public readonly bool4 baar => new bool4(b, a, a, r);
        public readonly bool4 baag => new bool4(b, a, a, g);
        public readonly bool4 baab => new bool4(b, a, a, b);
        public readonly bool4 baaa => new bool4(b, a, a, a);


        // a
        // ar
        public readonly bool4 arrr => new bool4(a, r, r, r);
        public readonly bool4 arrg => new bool4(a, r, r, g);
        public readonly bool4 arrb => new bool4(a, r, r, b);
        public readonly bool4 arra => new bool4(a, r, r, a);

        public readonly bool4 argr => new bool4(a, r, g, r);
        public readonly bool4 argg => new bool4(a, r, g, g);
        public readonly bool4 argb => new bool4(a, r, g, b);
        public readonly bool4 arga => new bool4(a, r, g, a);

        public readonly bool4 arbr => new bool4(a, r, b, r);
        public readonly bool4 arbg => new bool4(a, r, b, g);
        public readonly bool4 arbb => new bool4(a, r, b, b);
        public readonly bool4 arba => new bool4(a, r, b, a);

        public readonly bool4 arar => new bool4(a, r, a, r);
        public readonly bool4 arag => new bool4(a, r, a, g);
        public readonly bool4 arab => new bool4(a, r, a, b);
        public readonly bool4 araa => new bool4(a, r, a, a);

        // ag
        public readonly bool4 agrr => new bool4(a, g, r, r);
        public readonly bool4 agrg => new bool4(a, g, r, g);
        public readonly bool4 agrb => new bool4(a, g, r, b);
        public readonly bool4 agra => new bool4(a, g, r, a);

        public readonly bool4 aggr => new bool4(a, g, g, r);
        public readonly bool4 aggg => new bool4(a, g, g, g);
        public readonly bool4 aggb => new bool4(a, g, g, b);
        public readonly bool4 agga => new bool4(a, g, g, a);

        public readonly bool4 agbr => new bool4(a, g, b, r);
        public readonly bool4 agbg => new bool4(a, g, b, g);
        public readonly bool4 agbb => new bool4(a, g, b, b);
        public readonly bool4 agba => new bool4(a, g, b, a);

        public readonly bool4 agar => new bool4(a, g, a, r);
        public readonly bool4 agag => new bool4(a, g, a, g);
        public readonly bool4 agab => new bool4(a, g, a, b);
        public readonly bool4 agaa => new bool4(a, g, a, a);

        // ab
        public readonly bool4 abrr => new bool4(a, b, r, r);
        public readonly bool4 abrg => new bool4(a, b, r, g);
        public readonly bool4 abrb => new bool4(a, b, r, b);
        public readonly bool4 abra => new bool4(a, b, r, a);

        public readonly bool4 abgr => new bool4(a, b, g, r);
        public readonly bool4 abgg => new bool4(a, b, g, g);
        public readonly bool4 abgb => new bool4(a, b, g, b);
        public readonly bool4 abga => new bool4(a, b, g, a);

        public readonly bool4 abbr => new bool4(a, b, b, r);
        public readonly bool4 abbg => new bool4(a, b, b, g);
        public readonly bool4 abbb => new bool4(a, b, b, b);
        public readonly bool4 abba => new bool4(a, b, b, a);

        public readonly bool4 abar => new bool4(a, b, a, r);
        public readonly bool4 abag => new bool4(a, b, a, g);
        public readonly bool4 abab => new bool4(a, b, a, b);
        public readonly bool4 abaa => new bool4(a, b, a, a);

        // aa
        public readonly bool4 aarr => new bool4(a, a, r, r);
        public readonly bool4 aarg => new bool4(a, a, r, g);
        public readonly bool4 aarb => new bool4(a, a, r, b);
        public readonly bool4 aara => new bool4(a, a, r, a);

        public readonly bool4 aagr => new bool4(a, a, g, r);
        public readonly bool4 aagg => new bool4(a, a, g, g);
        public readonly bool4 aagb => new bool4(a, a, g, b);
        public readonly bool4 aaga => new bool4(a, a, g, a);

        public readonly bool4 aabr => new bool4(a, a, b, r);
        public readonly bool4 aabg => new bool4(a, a, b, g);
        public readonly bool4 aabb => new bool4(a, a, b, b);
        public readonly bool4 aaba => new bool4(a, a, b, a);

        public readonly bool4 aaar => new bool4(a, a, a, r);
        public readonly bool4 aaag => new bool4(a, a, a, g);
        public readonly bool4 aaab => new bool4(a, a, a, b);
        public readonly bool4 aaaa => new bool4(a, a, a, a);

        #endregion Swizzles_bool4_RGBA
        #region Swizzles_Extra

        // Swizzles - bool3

        // x
        public readonly bool3 xxx => new bool3(x, x, x);
        public readonly bool3 xxy => new bool3(x, x, y);
        public readonly bool3 xxz => new bool3(x, x, z);
        public readonly bool3 xxw => new bool3(x, x, w);

        public readonly bool3 xyx => new bool3(x, y, x);
        public readonly bool3 xyy => new bool3(x, y, y);
        public readonly bool3 xyz => new bool3(x, y, z);
        public readonly bool3 xyw => new bool3(x, y, w);

        public readonly bool3 xzx => new bool3(x, z, x);
        public readonly bool3 xzy => new bool3(x, z, y);
        public readonly bool3 xzz => new bool3(x, z, z);
        public readonly bool3 xzw => new bool3(x, z, w);

        public readonly bool3 xwx => new bool3(x, w, x);
        public readonly bool3 xwy => new bool3(x, w, y);
        public readonly bool3 xwz => new bool3(x, w, z);
        public readonly bool3 xww => new bool3(x, w, w);

        // y
        public readonly bool3 yxx => new bool3(y, x, x);
        public readonly bool3 yxy => new bool3(y, x, y);
        public readonly bool3 yxz => new bool3(y, x, z);
        public readonly bool3 yxw => new bool3(y, x, w);

        public readonly bool3 yyx => new bool3(y, y, x);
        public readonly bool3 yyy => new bool3(y, y, y);
        public readonly bool3 yyz => new bool3(y, y, z);
        public readonly bool3 yyw => new bool3(y, y, w);

        public readonly bool3 yzx => new bool3(y, z, x);
        public readonly bool3 yzy => new bool3(y, z, y);
        public readonly bool3 yzz => new bool3(y, z, z);
        public readonly bool3 yzw => new bool3(y, z, w);

        public readonly bool3 ywx => new bool3(y, w, x);
        public readonly bool3 ywy => new bool3(y, w, y);
        public readonly bool3 ywz => new bool3(y, w, z);
        public readonly bool3 yww => new bool3(y, w, w);

        // z
        public readonly bool3 zxx => new bool3(z, x, x);
        public readonly bool3 zxy => new bool3(z, x, y);
        public readonly bool3 zxz => new bool3(z, x, z);
        public readonly bool3 zxw => new bool3(z, x, w);

        public readonly bool3 zyx => new bool3(z, y, x);
        public readonly bool3 zyy => new bool3(z, y, y);
        public readonly bool3 zyz => new bool3(z, y, z);
        public readonly bool3 zyw => new bool3(z, y, w);

        public readonly bool3 zzx => new bool3(z, z, x);
        public readonly bool3 zzy => new bool3(z, z, y);
        public readonly bool3 zzz => new bool3(z, z, z);
        public readonly bool3 zzw => new bool3(z, z, w);

        public readonly bool3 zwx => new bool3(z, w, x);
        public readonly bool3 zwy => new bool3(z, w, y);
        public readonly bool3 zwz => new bool3(z, w, z);
        public readonly bool3 zww => new bool3(z, w, w);

        // w
        public readonly bool3 wxx => new bool3(w, x, x);
        public readonly bool3 wxy => new bool3(w, x, y);
        public readonly bool3 wxz => new bool3(w, x, z);
        public readonly bool3 wxw => new bool3(w, x, w);

        public readonly bool3 wyx => new bool3(w, y, x);
        public readonly bool3 wyy => new bool3(w, y, y);
        public readonly bool3 wyz => new bool3(w, y, z);
        public readonly bool3 wyw => new bool3(w, y, w);

        public readonly bool3 wzx => new bool3(w, z, x);
        public readonly bool3 wzy => new bool3(w, z, y);
        public readonly bool3 wzz => new bool3(w, z, z);
        public readonly bool3 wzw => new bool3(w, z, w);

        public readonly bool3 wwx => new bool3(w, w, x);
        public readonly bool3 wwy => new bool3(w, w, y);
        public readonly bool3 wwz => new bool3(w, w, z);
        public readonly bool3 www => new bool3(w, w, w);

        // Swizzles - bool2

        public readonly bool2 xx => new bool2(x, x);
        public readonly bool2 xy => new bool2(x, y);
        public readonly bool2 xz => new bool2(x, z);
        public readonly bool2 xw => new bool2(x, w);

        public readonly bool2 yx => new bool2(y, x);
        public readonly bool2 yy => new bool2(y, y);
        public readonly bool2 yz => new bool2(y, z);
        public readonly bool2 yw => new bool2(y, w);

        public readonly bool2 zx => new bool2(z, x);
        public readonly bool2 zy => new bool2(z, y);
        public readonly bool2 zz => new bool2(z, z);
        public readonly bool2 zw => new bool2(z, w);

        public readonly bool2 wx => new bool2(w, x);
        public readonly bool2 wy => new bool2(w, y);
        public readonly bool2 wz => new bool2(w, z);
        public readonly bool2 ww => new bool2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - bool3

        // r
        public readonly bool3 rrr => new bool3(r, r, r);
        public readonly bool3 rrg => new bool3(r, r, g);
        public readonly bool3 rrb => new bool3(r, r, b);
        public readonly bool3 rra => new bool3(r, r, a);

        public readonly bool3 rgr => new bool3(r, g, r);
        public readonly bool3 rgg => new bool3(r, g, g);
        public readonly bool3 rgb => new bool3(r, g, b);
        public readonly bool3 rga => new bool3(r, g, a);

        public readonly bool3 rbr => new bool3(r, b, r);
        public readonly bool3 rbg => new bool3(r, b, g);
        public readonly bool3 rbb => new bool3(r, b, b);
        public readonly bool3 rba => new bool3(r, b, a);

        public readonly bool3 rar => new bool3(r, a, r);
        public readonly bool3 rag => new bool3(r, a, g);
        public readonly bool3 rab => new bool3(r, a, b);
        public readonly bool3 raa => new bool3(r, a, a);

        // g
        public readonly bool3 grr => new bool3(g, r, r);
        public readonly bool3 grg => new bool3(g, r, g);
        public readonly bool3 grb => new bool3(g, r, b);
        public readonly bool3 gra => new bool3(g, r, a);

        public readonly bool3 ggr => new bool3(g, g, r);
        public readonly bool3 ggg => new bool3(g, g, g);
        public readonly bool3 ggb => new bool3(g, g, b);
        public readonly bool3 gga => new bool3(g, g, a);

        public readonly bool3 gbr => new bool3(g, b, r);
        public readonly bool3 gbg => new bool3(g, b, g);
        public readonly bool3 gbb => new bool3(g, b, b);
        public readonly bool3 gba => new bool3(g, b, a);

        public readonly bool3 gar => new bool3(g, a, r);
        public readonly bool3 gag => new bool3(g, a, g);
        public readonly bool3 gab => new bool3(g, a, b);
        public readonly bool3 gaa => new bool3(g, a, a);

        // b
        public readonly bool3 brr => new bool3(b, r, r);
        public readonly bool3 brg => new bool3(b, r, g);
        public readonly bool3 brb => new bool3(b, r, b);
        public readonly bool3 bra => new bool3(b, r, a);

        public readonly bool3 bgr => new bool3(b, g, r);
        public readonly bool3 bgg => new bool3(b, g, g);
        public readonly bool3 bgb => new bool3(b, g, b);
        public readonly bool3 bga => new bool3(b, g, a);

        public readonly bool3 bbr => new bool3(b, b, r);
        public readonly bool3 bbg => new bool3(b, b, g);
        public readonly bool3 bbb => new bool3(b, b, b);
        public readonly bool3 bba => new bool3(b, b, a);

        public readonly bool3 bar => new bool3(b, a, r);
        public readonly bool3 bag => new bool3(b, a, g);
        public readonly bool3 bab => new bool3(b, a, b);
        public readonly bool3 baa => new bool3(b, a, a);

        // a
        public readonly bool3 arr => new bool3(a, r, r);
        public readonly bool3 arg => new bool3(a, r, g);
        public readonly bool3 arb => new bool3(a, r, b);
        public readonly bool3 ara => new bool3(a, r, a);

        public readonly bool3 agr => new bool3(a, g, r);
        public readonly bool3 agg => new bool3(a, g, g);
        public readonly bool3 agb => new bool3(a, g, b);
        public readonly bool3 aga => new bool3(a, g, a);

        public readonly bool3 abr => new bool3(a, b, r);
        public readonly bool3 abg => new bool3(a, b, g);
        public readonly bool3 abb => new bool3(a, b, b);
        public readonly bool3 aba => new bool3(a, b, a);

        public readonly bool3 aar => new bool3(a, a, r);
        public readonly bool3 aag => new bool3(a, a, g);
        public readonly bool3 aab => new bool3(a, a, b);
        public readonly bool3 aaa => new bool3(a, a, a);

        // RGBA - Swizzles - bool2

        public readonly bool2 rr => new bool2(r, r);
        public readonly bool2 rg => new bool2(r, g);
        public readonly bool2 rb => new bool2(r, b);
        public readonly bool2 ra => new bool2(r, a);

        public readonly bool2 gr => new bool2(g, r);
        public readonly bool2 gg => new bool2(g, g);
        public readonly bool2 gb => new bool2(g, b);
        public readonly bool2 ga => new bool2(g, a);

        public readonly bool2 br => new bool2(b, r);
        public readonly bool2 bg => new bool2(b, g);
        public readonly bool2 bb => new bool2(b, b);
        public readonly bool2 ba => new bool2(b, a);

        public readonly bool2 ar => new bool2(a, r);
        public readonly bool2 ag => new bool2(a, g);
        public readonly bool2 ab => new bool2(a, b);
        public readonly bool2 aa => new bool2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
