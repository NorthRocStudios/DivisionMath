namespace DivisionEngine.MathLib
{
    public partial struct float4
    {
        #region Swizzles_float4

        // Swizzles - float4

        // x
        // xx
        public readonly float4 xxxx => new float4(x, x, x, x);
        public readonly float4 xxxy => new float4(x, x, x, y);
        public readonly float4 xxxz => new float4(x, x, x, z);
        public readonly float4 xxxw => new float4(x, x, x, w);

        public readonly float4 xxyx => new float4(x, x, y, x);
        public readonly float4 xxyy => new float4(x, x, y, y);
        public readonly float4 xxyz => new float4(x, x, y, z);
        public readonly float4 xxyw => new float4(x, x, y, w);

        public readonly float4 xxzx => new float4(x, x, z, x);
        public readonly float4 xxzy => new float4(x, x, z, y);
        public readonly float4 xxzz => new float4(x, x, z, z);
        public readonly float4 xxzw => new float4(x, x, z, w);

        public readonly float4 xxwx => new float4(x, x, w, x);
        public readonly float4 xxwy => new float4(x, x, w, y);
        public readonly float4 xxwz => new float4(x, x, w, z);
        public readonly float4 xxww => new float4(x, x, w, w);

        // xy
        public readonly float4 xyxx => new float4(x, y, x, x);
        public readonly float4 xyxy => new float4(x, y, x, y);
        public readonly float4 xyxz => new float4(x, y, x, z);
        public readonly float4 xyxw => new float4(x, y, x, w);

        public readonly float4 xyyx => new float4(x, y, y, x);
        public readonly float4 xyyy => new float4(x, y, y, y);
        public readonly float4 xyyz => new float4(x, y, y, z);
        public readonly float4 xyyw => new float4(x, y, y, w);

        public readonly float4 xyzx => new float4(x, y, z, x);
        public readonly float4 xyzy => new float4(x, y, z, y);
        public readonly float4 xyzz => new float4(x, y, z, z);
        public readonly float4 xyzw => new float4(x, y, z, w);

        public readonly float4 xywx => new float4(x, y, w, x);
        public readonly float4 xywy => new float4(x, y, w, y);
        public readonly float4 xywz => new float4(x, y, w, z);
        public readonly float4 xyww => new float4(x, y, w, w);

        // xz
        public readonly float4 xzxx => new float4(x, z, x, x);
        public readonly float4 xzxy => new float4(x, z, x, y);
        public readonly float4 xzxz => new float4(x, z, x, z);
        public readonly float4 xzxw => new float4(x, z, x, w);

        public readonly float4 xzyx => new float4(x, z, y, x);
        public readonly float4 xzyy => new float4(x, z, y, y);
        public readonly float4 xzyz => new float4(x, z, y, z);
        public readonly float4 xzyw => new float4(x, z, y, w);

        public readonly float4 xzzx => new float4(x, z, z, x);
        public readonly float4 xzzy => new float4(x, z, z, y);
        public readonly float4 xzzz => new float4(x, z, z, z);
        public readonly float4 xzzw => new float4(x, z, z, w);

        public readonly float4 xzwx => new float4(x, z, w, x);
        public readonly float4 xzwy => new float4(x, z, w, y);
        public readonly float4 xzwz => new float4(x, z, w, z);
        public readonly float4 xzww => new float4(x, z, w, w);

        // xw
        public readonly float4 xwxx => new float4(x, w, x, x);
        public readonly float4 xwxy => new float4(x, w, x, y);
        public readonly float4 xwxz => new float4(x, w, x, z);
        public readonly float4 xwxw => new float4(x, w, x, w);

        public readonly float4 xwyx => new float4(x, w, y, x);
        public readonly float4 xwyy => new float4(x, w, y, y);
        public readonly float4 xwyz => new float4(x, w, y, z);
        public readonly float4 xwyw => new float4(x, w, y, w);
        
        public readonly float4 xwzx => new float4(x, w, z, x);
        public readonly float4 xwzy => new float4(x, w, z, y);
        public readonly float4 xwzz => new float4(x, w, z, z);
        public readonly float4 xwzw => new float4(x, w, z, w);

        public readonly float4 xwwx => new float4(x, w, w, x);
        public readonly float4 xwwy => new float4(x, w, w, y);
        public readonly float4 xwwz => new float4(x, w, w, z);
        public readonly float4 xwww => new float4(x, w, w, w);


        // y
        // yx
        public readonly float4 yxxx => new float4(y, x, x, x);
        public readonly float4 yxxy => new float4(y, x, x, y);
        public readonly float4 yxxz => new float4(y, x, x, z);
        public readonly float4 yxxw => new float4(y, x, x, w);
        
        public readonly float4 yxyx => new float4(y, x, y, x);
        public readonly float4 yxyy => new float4(y, x, y, y);
        public readonly float4 yxyz => new float4(y, x, y, z);
        public readonly float4 yxyw => new float4(y, x, y, w);

        public readonly float4 yxzx => new float4(y, x, z, x);
        public readonly float4 yxzy => new float4(y, x, z, y);
        public readonly float4 yxzz => new float4(y, x, z, z);
        public readonly float4 yxzw => new float4(y, x, z, w);

        public readonly float4 yxwx => new float4(y, x, w, x);
        public readonly float4 yxwy => new float4(y, x, w, y);
        public readonly float4 yxwz => new float4(y, x, w, z);
        public readonly float4 yxww => new float4(y, x, w, w);

        // yy
        public readonly float4 yyxx => new float4(y, y, x, x);
        public readonly float4 yyxy => new float4(y, y, x, y);
        public readonly float4 yyxz => new float4(y, y, x, z);
        public readonly float4 yyxw => new float4(y, y, x, w);

        public readonly float4 yyyx => new float4(y, y, y, x);
        public readonly float4 yyyy => new float4(y, y, y, y);
        public readonly float4 yyyz => new float4(y, y, y, z);
        public readonly float4 yyyw => new float4(y, y, y, w);

        public readonly float4 yyzx => new float4(y, y, z, x);
        public readonly float4 yyzy => new float4(y, y, z, y);
        public readonly float4 yyzz => new float4(y, y, z, z);
        public readonly float4 yyzw => new float4(y, y, z, w);

        public readonly float4 yywx => new float4(y, y, w, x);
        public readonly float4 yywy => new float4(y, y, w, y);
        public readonly float4 yywz => new float4(y, y, w, z);
        public readonly float4 yyww => new float4(y, y, w, w);
        
        // yz
        public readonly float4 yzxx => new float4(y, z, x, x);
        public readonly float4 yzxy => new float4(y, z, x, y);
        public readonly float4 yzxz => new float4(y, z, x, z);
        public readonly float4 yzxw => new float4(y, z, x, w);

        public readonly float4 yzyx => new float4(y, z, y, x);
        public readonly float4 yzyy => new float4(y, z, y, y);
        public readonly float4 yzyz => new float4(y, z, y, z);
        public readonly float4 yzyw => new float4(y, z, y, w);

        public readonly float4 yzzx => new float4(y, z, z, x);
        public readonly float4 yzzy => new float4(y, z, z, y);
        public readonly float4 yzzz => new float4(y, z, z, z);
        public readonly float4 yzzw => new float4(y, z, z, w);

        public readonly float4 yzwx => new float4(y, z, w, x);
        public readonly float4 yzwy => new float4(y, z, w, y);
        public readonly float4 yzwz => new float4(y, z, w, z);
        public readonly float4 yzww => new float4(y, z, w, w);

        // yw
        public readonly float4 ywxx => new float4(y, w, x, x);
        public readonly float4 ywxy => new float4(y, w, x, y);
        public readonly float4 ywxz => new float4(y, w, x, z);
        public readonly float4 ywxw => new float4(y, w, x, w);
        
        public readonly float4 ywyx => new float4(y, w, y, x);
        public readonly float4 ywyy => new float4(y, w, y, y);
        public readonly float4 ywyz => new float4(y, w, y, z);
        public readonly float4 ywyw => new float4(y, w, y, w);
        
        public readonly float4 ywzx => new float4(y, w, z, x);
        public readonly float4 ywzy => new float4(y, w, z, y);
        public readonly float4 ywzz => new float4(y, w, z, z);
        public readonly float4 ywzw => new float4(y, w, z, w);

        public readonly float4 ywwx => new float4(y, w, w, x);
        public readonly float4 ywwy => new float4(y, w, w, y);
        public readonly float4 ywwz => new float4(y, w, w, z);
        public readonly float4 ywww => new float4(y, w, w, w);


        // z
        // zx
        public readonly float4 zxxx => new float4(z, x, x, x);
        public readonly float4 zxxy => new float4(z, x, x, y);
        public readonly float4 zxxz => new float4(z, x, x, z);
        public readonly float4 zxxw => new float4(z, x, x, w);
        
        public readonly float4 zxyx => new float4(z, x, y, x);
        public readonly float4 zxyy => new float4(z, x, y, y);
        public readonly float4 zxyz => new float4(z, x, y, z);
        public readonly float4 zxyw => new float4(z, x, y, w);

        public readonly float4 zxzx => new float4(z, x, z, x);
        public readonly float4 zxzy => new float4(z, x, z, y);
        public readonly float4 zxzz => new float4(z, x, z, z);
        public readonly float4 zxzw => new float4(z, x, z, w);

        public readonly float4 zxwx => new float4(z, x, w, x);
        public readonly float4 zxwy => new float4(z, x, w, y);
        public readonly float4 zxwz => new float4(z, x, w, z);
        public readonly float4 zxww => new float4(z, x, w, w);

        // zy
        public readonly float4 zyxx => new float4(z, y, x, x);
        public readonly float4 zyxy => new float4(z, y, x, y);
        public readonly float4 zyxz => new float4(z, y, x, z);
        public readonly float4 zyxw => new float4(z, y, x, w);

        public readonly float4 zyyx => new float4(z, y, y, x);
        public readonly float4 zyyy => new float4(z, y, y, y);
        public readonly float4 zyyz => new float4(z, y, y, z);
        public readonly float4 zyyw => new float4(z, y, y, w);

        public readonly float4 zyzx => new float4(z, y, z, x);
        public readonly float4 zyzy => new float4(z, y, z, y);
        public readonly float4 zyzz => new float4(z, y, z, z);
        public readonly float4 zyzw => new float4(z, y, z, w);

        public readonly float4 zywx => new float4(z, y, w, x);
        public readonly float4 zywy => new float4(z, y, w, y);
        public readonly float4 zywz => new float4(z, y, w, z);
        public readonly float4 zyww => new float4(z, y, w, w);
        
        // zz
        public readonly float4 zzxx => new float4(z, z, x, x);
        public readonly float4 zzxy => new float4(z, z, x, y);
        public readonly float4 zzxz => new float4(z, z, x, z);
        public readonly float4 zzxw => new float4(z, z, x, w);

        public readonly float4 zzyx => new float4(z, z, y, x);
        public readonly float4 zzyy => new float4(z, z, y, y);
        public readonly float4 zzyz => new float4(z, z, y, z);
        public readonly float4 zzyw => new float4(z, z, y, w);

        public readonly float4 zzzx => new float4(z, z, z, x);
        public readonly float4 zzzy => new float4(z, z, z, y);
        public readonly float4 zzzz => new float4(z, z, z, z);
        public readonly float4 zzzw => new float4(z, z, z, w);

        public readonly float4 zzwx => new float4(z, z, w, x);
        public readonly float4 zzwy => new float4(z, z, w, y);
        public readonly float4 zzwz => new float4(z, z, w, z);
        public readonly float4 zzww => new float4(z, z, w, w);

        // zw
        public readonly float4 zwxx => new float4(z, w, x, x);
        public readonly float4 zwxy => new float4(z, w, x, y);
        public readonly float4 zwxz => new float4(z, w, x, z);
        public readonly float4 zwxw => new float4(z, w, x, w);
        
        public readonly float4 zwyx => new float4(z, w, y, x);
        public readonly float4 zwyy => new float4(z, w, y, y);
        public readonly float4 zwyz => new float4(z, w, y, z);
        public readonly float4 zwyw => new float4(z, w, y, w);
        
        public readonly float4 zwzx => new float4(z, w, z, x);
        public readonly float4 zwzy => new float4(z, w, z, y);
        public readonly float4 zwzz => new float4(z, w, z, z);
        public readonly float4 zwzw => new float4(z, w, z, w);

        public readonly float4 zwwx => new float4(z, w, w, x);
        public readonly float4 zwwy => new float4(z, w, w, y);
        public readonly float4 zwwz => new float4(z, w, w, z);
        public readonly float4 zwww => new float4(z, w, w, w);


        // w
        // wx
        public readonly float4 wxxx => new float4(w, x, x, x);
        public readonly float4 wxxy => new float4(w, x, x, y);
        public readonly float4 wxxz => new float4(w, x, x, z);
        public readonly float4 wxxw => new float4(w, x, x, w);
        
        public readonly float4 wxyx => new float4(w, x, y, x);
        public readonly float4 wxyy => new float4(w, x, y, y);
        public readonly float4 wxyz => new float4(w, x, y, z);
        public readonly float4 wxyw => new float4(w, x, y, w);

        public readonly float4 wxzx => new float4(w, x, z, x);
        public readonly float4 wxzy => new float4(w, x, z, y);
        public readonly float4 wxzz => new float4(w, x, z, z);
        public readonly float4 wxzw => new float4(w, x, z, w);

        public readonly float4 wxwx => new float4(w, x, w, x);
        public readonly float4 wxwy => new float4(w, x, w, y);
        public readonly float4 wxwz => new float4(w, x, w, z);
        public readonly float4 wxww => new float4(w, x, w, w);

        // wy
        public readonly float4 wyxx => new float4(w, y, x, x);
        public readonly float4 wyxy => new float4(w, y, x, y);
        public readonly float4 wyxz => new float4(w, y, x, z);
        public readonly float4 wyxw => new float4(w, y, x, w);

        public readonly float4 wyyx => new float4(w, y, y, x);
        public readonly float4 wyyy => new float4(w, y, y, y);
        public readonly float4 wyyz => new float4(w, y, y, z);
        public readonly float4 wyyw => new float4(w, y, y, w);

        public readonly float4 wyzx => new float4(w, y, z, x);
        public readonly float4 wyzy => new float4(w, y, z, y);
        public readonly float4 wyzz => new float4(w, y, z, z);
        public readonly float4 wyzw => new float4(w, y, z, w);

        public readonly float4 wywx => new float4(w, y, w, x);
        public readonly float4 wywy => new float4(w, y, w, y);
        public readonly float4 wywz => new float4(w, y, w, z);
        public readonly float4 wyww => new float4(w, y, w, w);
        
        // wz
        public readonly float4 wzxx => new float4(w, z, x, x);
        public readonly float4 wzxy => new float4(w, z, x, y);
        public readonly float4 wzxz => new float4(w, z, x, z);
        public readonly float4 wzxw => new float4(w, z, x, w);

        public readonly float4 wzyx => new float4(w, z, y, x);
        public readonly float4 wzyy => new float4(w, z, y, y);
        public readonly float4 wzyz => new float4(w, z, y, z);
        public readonly float4 wzyw => new float4(w, z, y, w);

        public readonly float4 wzzx => new float4(w, z, z, x);
        public readonly float4 wzzy => new float4(w, z, z, y);
        public readonly float4 wzzz => new float4(w, z, z, z);
        public readonly float4 wzzw => new float4(w, z, z, w);

        public readonly float4 wzwx => new float4(w, z, w, x);
        public readonly float4 wzwy => new float4(w, z, w, y);
        public readonly float4 wzwz => new float4(w, z, w, z);
        public readonly float4 wzww => new float4(w, z, w, w);

        // ww
        public readonly float4 wwxx => new float4(w, w, x, x);
        public readonly float4 wwxy => new float4(w, w, x, y);
        public readonly float4 wwxz => new float4(w, w, x, z);
        public readonly float4 wwxw => new float4(w, w, x, w);
        
        public readonly float4 wwyx => new float4(w, w, y, x);
        public readonly float4 wwyy => new float4(w, w, y, y);
        public readonly float4 wwyz => new float4(w, w, y, z);
        public readonly float4 wwyw => new float4(w, w, y, w);
        
        public readonly float4 wwzx => new float4(w, w, z, x);
        public readonly float4 wwzy => new float4(w, w, z, y);
        public readonly float4 wwzz => new float4(w, w, z, z);
        public readonly float4 wwzw => new float4(w, w, z, w);

        public readonly float4 wwwx => new float4(w, w, w, x);
        public readonly float4 wwwy => new float4(w, w, w, y);
        public readonly float4 wwwz => new float4(w, w, w, z);
        public readonly float4 wwww => new float4(w, w, w, w);

        #endregion Swizzles_float4
        #region Swizzles_float4_RGBA

        // RGBA - Swizzles - float4

        // r
        // rr
        public readonly float4 rrrr => new float4(r, r, r, r);
        public readonly float4 rrrg => new float4(r, r, r, g);
        public readonly float4 rrrb => new float4(r, r, r, b);
        public readonly float4 rrra => new float4(r, r, r, a);

        public readonly float4 rrgr => new float4(r, r, g, r);
        public readonly float4 rrgg => new float4(r, r, g, g);
        public readonly float4 rrgb => new float4(r, r, g, b);
        public readonly float4 rrga => new float4(r, r, g, a);

        public readonly float4 rrbr => new float4(r, r, b, r);
        public readonly float4 rrbg => new float4(r, r, b, g);
        public readonly float4 rrbb => new float4(r, r, b, b);
        public readonly float4 rrba => new float4(r, r, b, a);

        public readonly float4 rrar => new float4(r, r, a, r);
        public readonly float4 rrag => new float4(r, r, a, g);
        public readonly float4 rrab => new float4(r, r, a, b);
        public readonly float4 rraa => new float4(r, r, a, a);

        // rg
        public readonly float4 rgrr => new float4(r, g, r, r);
        public readonly float4 rgrg => new float4(r, g, r, g);
        public readonly float4 rgrb => new float4(r, g, r, b);
        public readonly float4 rgra => new float4(r, g, r, a);

        public readonly float4 rggr => new float4(r, g, g, r);
        public readonly float4 rggg => new float4(r, g, g, g);
        public readonly float4 rggb => new float4(r, g, g, b);
        public readonly float4 rgga => new float4(r, g, g, a);

        public readonly float4 rgbr => new float4(r, g, b, r);
        public readonly float4 rgbg => new float4(r, g, b, g);
        public readonly float4 rgbb => new float4(r, g, b, b);
        public readonly float4 rgba => new float4(r, g, b, a);

        public readonly float4 rgar => new float4(r, g, a, r);
        public readonly float4 rgag => new float4(r, g, a, g);
        public readonly float4 rgab => new float4(r, g, a, b);
        public readonly float4 rgaa => new float4(r, g, a, a);

        // rb
        public readonly float4 rbrr => new float4(r, b, r, r);
        public readonly float4 rbrg => new float4(r, b, r, g);
        public readonly float4 rbrb => new float4(r, b, r, b);
        public readonly float4 rbra => new float4(r, b, r, a);

        public readonly float4 rbgr => new float4(r, b, g, r);
        public readonly float4 rbgg => new float4(r, b, g, g);
        public readonly float4 rbgb => new float4(r, b, g, b);
        public readonly float4 rbga => new float4(r, b, g, a);

        public readonly float4 rbbr => new float4(r, b, b, r);
        public readonly float4 rbbg => new float4(r, b, b, g);
        public readonly float4 rbbb => new float4(r, b, b, b);
        public readonly float4 rbba => new float4(r, b, b, a);

        public readonly float4 rbar => new float4(r, b, a, r);
        public readonly float4 rbag => new float4(r, b, a, g);
        public readonly float4 rbab => new float4(r, b, a, b);
        public readonly float4 rbaa => new float4(r, b, a, a);

        // ra
        public readonly float4 rarr => new float4(r, a, r, r);
        public readonly float4 rarg => new float4(r, a, r, g);
        public readonly float4 rarb => new float4(r, a, r, b);
        public readonly float4 rara => new float4(r, a, r, a);

        public readonly float4 ragr => new float4(r, a, g, r);
        public readonly float4 ragg => new float4(r, a, g, g);
        public readonly float4 ragb => new float4(r, a, g, b);
        public readonly float4 raga => new float4(r, a, g, a);

        public readonly float4 rabr => new float4(r, a, b, r);
        public readonly float4 rabg => new float4(r, a, b, g);
        public readonly float4 rabb => new float4(r, a, b, b);
        public readonly float4 raba => new float4(r, a, b, a);

        public readonly float4 raar => new float4(r, a, a, r);
        public readonly float4 raag => new float4(r, a, a, g);
        public readonly float4 raab => new float4(r, a, a, b);
        public readonly float4 raaa => new float4(r, a, a, a);


        // g
        // gr
        public readonly float4 grrr => new float4(g, r, r, r);
        public readonly float4 grrg => new float4(g, r, r, g);
        public readonly float4 grrb => new float4(g, r, r, b);
        public readonly float4 grra => new float4(g, r, r, a);

        public readonly float4 grgr => new float4(g, r, g, r);
        public readonly float4 grgg => new float4(g, r, g, g);
        public readonly float4 grgb => new float4(g, r, g, b);
        public readonly float4 grga => new float4(g, r, g, a);

        public readonly float4 grbr => new float4(g, r, b, r);
        public readonly float4 grbg => new float4(g, r, b, g);
        public readonly float4 grbb => new float4(g, r, b, b);
        public readonly float4 grba => new float4(g, r, b, a);

        public readonly float4 grar => new float4(g, r, a, r);
        public readonly float4 grag => new float4(g, r, a, g);
        public readonly float4 grab => new float4(g, r, a, b);
        public readonly float4 graa => new float4(g, r, a, a);

        // gg
        public readonly float4 ggrr => new float4(g, g, r, r);
        public readonly float4 ggrg => new float4(g, g, r, g);
        public readonly float4 ggrb => new float4(g, g, r, b);
        public readonly float4 ggra => new float4(g, g, r, a);

        public readonly float4 gggr => new float4(g, g, g, r);
        public readonly float4 gggg => new float4(g, g, g, g);
        public readonly float4 gggb => new float4(g, g, g, b);
        public readonly float4 ggga => new float4(g, g, g, a);

        public readonly float4 ggbr => new float4(g, g, b, r);
        public readonly float4 ggbg => new float4(g, g, b, g);
        public readonly float4 ggbb => new float4(g, g, b, b);
        public readonly float4 ggba => new float4(g, g, b, a);

        public readonly float4 ggar => new float4(g, g, a, r);
        public readonly float4 ggag => new float4(g, g, a, g);
        public readonly float4 ggab => new float4(g, g, a, b);
        public readonly float4 ggaa => new float4(g, g, a, a);

        // gb
        public readonly float4 gbrr => new float4(g, b, r, r);
        public readonly float4 gbrg => new float4(g, b, r, g);
        public readonly float4 gbrb => new float4(g, b, r, b);
        public readonly float4 gbra => new float4(g, b, r, a);

        public readonly float4 gbgr => new float4(g, b, g, r);
        public readonly float4 gbgg => new float4(g, b, g, g);
        public readonly float4 gbgb => new float4(g, b, g, b);
        public readonly float4 gbga => new float4(g, b, g, a);

        public readonly float4 gbbr => new float4(g, b, b, r);
        public readonly float4 gbbg => new float4(g, b, b, g);
        public readonly float4 gbbb => new float4(g, b, b, b);
        public readonly float4 gbba => new float4(g, b, b, a);

        public readonly float4 gbar => new float4(g, b, a, r);
        public readonly float4 gbag => new float4(g, b, a, g);
        public readonly float4 gbab => new float4(g, b, a, b);
        public readonly float4 gbaa => new float4(g, b, a, a);

        // ga
        public readonly float4 garr => new float4(g, a, r, r);
        public readonly float4 garg => new float4(g, a, r, g);
        public readonly float4 garb => new float4(g, a, r, b);
        public readonly float4 gara => new float4(g, a, r, a);

        public readonly float4 gagr => new float4(g, a, g, r);
        public readonly float4 gagg => new float4(g, a, g, g);
        public readonly float4 gagb => new float4(g, a, g, b);
        public readonly float4 gaga => new float4(g, a, g, a);

        public readonly float4 gabr => new float4(g, a, b, r);
        public readonly float4 gabg => new float4(g, a, b, g);
        public readonly float4 gabb => new float4(g, a, b, b);
        public readonly float4 gaba => new float4(g, a, b, a);

        public readonly float4 gaar => new float4(g, a, a, r);
        public readonly float4 gaag => new float4(g, a, a, g);
        public readonly float4 gaab => new float4(g, a, a, b);
        public readonly float4 gaaa => new float4(g, a, a, a);


        // b
        // br
        public readonly float4 brrr => new float4(b, r, r, r);
        public readonly float4 brrg => new float4(b, r, r, g);
        public readonly float4 brrb => new float4(b, r, r, b);
        public readonly float4 brra => new float4(b, r, r, a);

        public readonly float4 brgr => new float4(b, r, g, r);
        public readonly float4 brgg => new float4(b, r, g, g);
        public readonly float4 brgb => new float4(b, r, g, b);
        public readonly float4 brga => new float4(b, r, g, a);

        public readonly float4 brbr => new float4(b, r, b, r);
        public readonly float4 brbg => new float4(b, r, b, g);
        public readonly float4 brbb => new float4(b, r, b, b);
        public readonly float4 brba => new float4(b, r, b, a);

        public readonly float4 brar => new float4(b, r, a, r);
        public readonly float4 brag => new float4(b, r, a, g);
        public readonly float4 brab => new float4(b, r, a, b);
        public readonly float4 braa => new float4(b, r, a, a);

        // bg
        public readonly float4 bgrr => new float4(b, g, r, r);
        public readonly float4 bgrg => new float4(b, g, r, g);
        public readonly float4 bgrb => new float4(b, g, r, b);
        public readonly float4 bgra => new float4(b, g, r, a);

        public readonly float4 bggr => new float4(b, g, g, r);
        public readonly float4 bggg => new float4(b, g, g, g);
        public readonly float4 bggb => new float4(b, g, g, b);
        public readonly float4 bgga => new float4(b, g, g, a);

        public readonly float4 bgbr => new float4(b, g, b, r);
        public readonly float4 bgbg => new float4(b, g, b, g);
        public readonly float4 bgbb => new float4(b, g, b, b);
        public readonly float4 bgba => new float4(b, g, b, a);

        public readonly float4 bgar => new float4(b, g, a, r);
        public readonly float4 bgag => new float4(b, g, a, g);
        public readonly float4 bgab => new float4(b, g, a, b);
        public readonly float4 bgaa => new float4(b, g, a, a);

        // bb
        public readonly float4 bbrr => new float4(b, b, r, r);
        public readonly float4 bbrg => new float4(b, b, r, g);
        public readonly float4 bbrb => new float4(b, b, r, b);
        public readonly float4 bbra => new float4(b, b, r, a);

        public readonly float4 bbgr => new float4(b, b, g, r);
        public readonly float4 bbgg => new float4(b, b, g, g);
        public readonly float4 bbgb => new float4(b, b, g, b);
        public readonly float4 bbga => new float4(b, b, g, a);

        public readonly float4 bbbr => new float4(b, b, b, r);
        public readonly float4 bbbg => new float4(b, b, b, g);
        public readonly float4 bbbb => new float4(b, b, b, b);
        public readonly float4 bbba => new float4(b, b, b, a);

        public readonly float4 bbar => new float4(b, b, a, r);
        public readonly float4 bbag => new float4(b, b, a, g);
        public readonly float4 bbab => new float4(b, b, a, b);
        public readonly float4 bbaa => new float4(b, b, a, a);

        // ba
        public readonly float4 barr => new float4(b, a, r, r);
        public readonly float4 barg => new float4(b, a, r, g);
        public readonly float4 barb => new float4(b, a, r, b);
        public readonly float4 bara => new float4(b, a, r, a);

        public readonly float4 bagr => new float4(b, a, g, r);
        public readonly float4 bagg => new float4(b, a, g, g);
        public readonly float4 bagb => new float4(b, a, g, b);
        public readonly float4 baga => new float4(b, a, g, a);

        public readonly float4 babr => new float4(b, a, b, r);
        public readonly float4 babg => new float4(b, a, b, g);
        public readonly float4 babb => new float4(b, a, b, b);
        public readonly float4 baba => new float4(b, a, b, a);

        public readonly float4 baar => new float4(b, a, a, r);
        public readonly float4 baag => new float4(b, a, a, g);
        public readonly float4 baab => new float4(b, a, a, b);
        public readonly float4 baaa => new float4(b, a, a, a);


        // a
        // ar
        public readonly float4 arrr => new float4(a, r, r, r);
        public readonly float4 arrg => new float4(a, r, r, g);
        public readonly float4 arrb => new float4(a, r, r, b);
        public readonly float4 arra => new float4(a, r, r, a);

        public readonly float4 argr => new float4(a, r, g, r);
        public readonly float4 argg => new float4(a, r, g, g);
        public readonly float4 argb => new float4(a, r, g, b);
        public readonly float4 arga => new float4(a, r, g, a);

        public readonly float4 arbr => new float4(a, r, b, r);
        public readonly float4 arbg => new float4(a, r, b, g);
        public readonly float4 arbb => new float4(a, r, b, b);
        public readonly float4 arba => new float4(a, r, b, a);

        public readonly float4 arar => new float4(a, r, a, r);
        public readonly float4 arag => new float4(a, r, a, g);
        public readonly float4 arab => new float4(a, r, a, b);
        public readonly float4 araa => new float4(a, r, a, a);

        // ag
        public readonly float4 agrr => new float4(a, g, r, r);
        public readonly float4 agrg => new float4(a, g, r, g);
        public readonly float4 agrb => new float4(a, g, r, b);
        public readonly float4 agra => new float4(a, g, r, a);

        public readonly float4 aggr => new float4(a, g, g, r);
        public readonly float4 aggg => new float4(a, g, g, g);
        public readonly float4 aggb => new float4(a, g, g, b);
        public readonly float4 agga => new float4(a, g, g, a);

        public readonly float4 agbr => new float4(a, g, b, r);
        public readonly float4 agbg => new float4(a, g, b, g);
        public readonly float4 agbb => new float4(a, g, b, b);
        public readonly float4 agba => new float4(a, g, b, a);

        public readonly float4 agar => new float4(a, g, a, r);
        public readonly float4 agag => new float4(a, g, a, g);
        public readonly float4 agab => new float4(a, g, a, b);
        public readonly float4 agaa => new float4(a, g, a, a);

        // ab
        public readonly float4 abrr => new float4(a, b, r, r);
        public readonly float4 abrg => new float4(a, b, r, g);
        public readonly float4 abrb => new float4(a, b, r, b);
        public readonly float4 abra => new float4(a, b, r, a);

        public readonly float4 abgr => new float4(a, b, g, r);
        public readonly float4 abgg => new float4(a, b, g, g);
        public readonly float4 abgb => new float4(a, b, g, b);
        public readonly float4 abga => new float4(a, b, g, a);

        public readonly float4 abbr => new float4(a, b, b, r);
        public readonly float4 abbg => new float4(a, b, b, g);
        public readonly float4 abbb => new float4(a, b, b, b);
        public readonly float4 abba => new float4(a, b, b, a);

        public readonly float4 abar => new float4(a, b, a, r);
        public readonly float4 abag => new float4(a, b, a, g);
        public readonly float4 abab => new float4(a, b, a, b);
        public readonly float4 abaa => new float4(a, b, a, a);

        // aa
        public readonly float4 aarr => new float4(a, a, r, r);
        public readonly float4 aarg => new float4(a, a, r, g);
        public readonly float4 aarb => new float4(a, a, r, b);
        public readonly float4 aara => new float4(a, a, r, a);

        public readonly float4 aagr => new float4(a, a, g, r);
        public readonly float4 aagg => new float4(a, a, g, g);
        public readonly float4 aagb => new float4(a, a, g, b);
        public readonly float4 aaga => new float4(a, a, g, a);

        public readonly float4 aabr => new float4(a, a, b, r);
        public readonly float4 aabg => new float4(a, a, b, g);
        public readonly float4 aabb => new float4(a, a, b, b);
        public readonly float4 aaba => new float4(a, a, b, a);

        public readonly float4 aaar => new float4(a, a, a, r);
        public readonly float4 aaag => new float4(a, a, a, g);
        public readonly float4 aaab => new float4(a, a, a, b);
        public readonly float4 aaaa => new float4(a, a, a, a);

        #endregion Swizzles_float4_RGBA
        #region Swizzles_Extra

        // Swizzles - float3

        // x
        public readonly float3 xxx => new float3(x, x, x);
        public readonly float3 xxy => new float3(x, x, y);
        public readonly float3 xxz => new float3(x, x, z);
        public readonly float3 xxw => new float3(x, x, w);

        public readonly float3 xyx => new float3(x, y, x);
        public readonly float3 xyy => new float3(x, y, y);
        public readonly float3 xyz => new float3(x, y, z);
        public readonly float3 xyw => new float3(x, y, w);

        public readonly float3 xzx => new float3(x, z, x);
        public readonly float3 xzy => new float3(x, z, y);
        public readonly float3 xzz => new float3(x, z, z);
        public readonly float3 xzw => new float3(x, z, w);

        public readonly float3 xwx => new float3(x, w, x);
        public readonly float3 xwy => new float3(x, w, y);
        public readonly float3 xwz => new float3(x, w, z);
        public readonly float3 xww => new float3(x, w, w);

        // y
        public readonly float3 yxx => new float3(y, x, x);
        public readonly float3 yxy => new float3(y, x, y);
        public readonly float3 yxz => new float3(y, x, z);
        public readonly float3 yxw => new float3(y, x, w);

        public readonly float3 yyx => new float3(y, y, x);
        public readonly float3 yyy => new float3(y, y, y);
        public readonly float3 yyz => new float3(y, y, z);
        public readonly float3 yyw => new float3(y, y, w);

        public readonly float3 yzx => new float3(y, z, x);
        public readonly float3 yzy => new float3(y, z, y);
        public readonly float3 yzz => new float3(y, z, z);
        public readonly float3 yzw => new float3(y, z, w);

        public readonly float3 ywx => new float3(y, w, x);
        public readonly float3 ywy => new float3(y, w, y);
        public readonly float3 ywz => new float3(y, w, z);
        public readonly float3 yww => new float3(y, w, w);

        // z
        public readonly float3 zxx => new float3(z, x, x);
        public readonly float3 zxy => new float3(z, x, y);
        public readonly float3 zxz => new float3(z, x, z);
        public readonly float3 zxw => new float3(z, x, w);

        public readonly float3 zyx => new float3(z, y, x);
        public readonly float3 zyy => new float3(z, y, y);
        public readonly float3 zyz => new float3(z, y, z);
        public readonly float3 zyw => new float3(z, y, w);

        public readonly float3 zzx => new float3(z, z, x);
        public readonly float3 zzy => new float3(z, z, y);
        public readonly float3 zzz => new float3(z, z, z);
        public readonly float3 zzw => new float3(z, z, w);

        public readonly float3 zwx => new float3(z, w, x);
        public readonly float3 zwy => new float3(z, w, y);
        public readonly float3 zwz => new float3(z, w, z);
        public readonly float3 zww => new float3(z, w, w);

        // w
        public readonly float3 wxx => new float3(w, x, x);
        public readonly float3 wxy => new float3(w, x, y);
        public readonly float3 wxz => new float3(w, x, z);
        public readonly float3 wxw => new float3(w, x, w);
        
        public readonly float3 wyx => new float3(w, y, x);
        public readonly float3 wyy => new float3(w, y, y);
        public readonly float3 wyz => new float3(w, y, z);
        public readonly float3 wyw => new float3(w, y, w);

        public readonly float3 wzx => new float3(w, z, x);
        public readonly float3 wzy => new float3(w, z, y);
        public readonly float3 wzz => new float3(w, z, z);
        public readonly float3 wzw => new float3(w, z, w);

        public readonly float3 wwx => new float3(w, w, x);
        public readonly float3 wwy => new float3(w, w, y);
        public readonly float3 wwz => new float3(w, w, z);
        public readonly float3 www => new float3(w, w, w);

        // Swizzles - float2

        public readonly float2 xx => new float2(x, x);
        public readonly float2 xy => new float2(x, y);
        public readonly float2 xz => new float2(x, z);
        public readonly float2 xw => new float2(x, w);

        public readonly float2 yx => new float2(y, x);
        public readonly float2 yy => new float2(y, y);
        public readonly float2 yz => new float2(y, z);
        public readonly float2 yw => new float2(y, w);

        public readonly float2 zx => new float2(z, x);
        public readonly float2 zy => new float2(z, y);
        public readonly float2 zz => new float2(z, z);
        public readonly float2 zw => new float2(z, w);

        public readonly float2 wx => new float2(w, x);
        public readonly float2 wy => new float2(w, y);
        public readonly float2 wz => new float2(w, z);
        public readonly float2 ww => new float2(w, w);

        #endregion Swizzles_Extra
        #region Swizzles_Extra_RGBA

        // RGBA - Swizzles - float3

        // r
        public readonly float3 rrr => new float3(r, r, r);
        public readonly float3 rrg => new float3(r, r, g);
        public readonly float3 rrb => new float3(r, r, b);
        public readonly float3 rra => new float3(r, r, a);

        public readonly float3 rgr => new float3(r, g, r);
        public readonly float3 rgg => new float3(r, g, g);
        public readonly float3 rgb => new float3(r, g, b);
        public readonly float3 rga => new float3(r, g, a);

        public readonly float3 rbr => new float3(r, b, r);
        public readonly float3 rbg => new float3(r, b, g);
        public readonly float3 rbb => new float3(r, b, b);
        public readonly float3 rba => new float3(r, b, a);

        public readonly float3 rar => new float3(r, a, r);
        public readonly float3 rag => new float3(r, a, g);
        public readonly float3 rab => new float3(r, a, b);
        public readonly float3 raa => new float3(r, a, a);

        // g
        public readonly float3 grr => new float3(g, r, r);
        public readonly float3 grg => new float3(g, r, g);
        public readonly float3 grb => new float3(g, r, b);
        public readonly float3 gra => new float3(g, r, a);

        public readonly float3 ggr => new float3(g, g, r);
        public readonly float3 ggg => new float3(g, g, g);
        public readonly float3 ggb => new float3(g, g, b);
        public readonly float3 gga => new float3(g, g, a);

        public readonly float3 gbr => new float3(g, b, r);
        public readonly float3 gbg => new float3(g, b, g);
        public readonly float3 gbb => new float3(g, b, b);
        public readonly float3 gba => new float3(g, b, a);

        public readonly float3 gar => new float3(g, a, r);
        public readonly float3 gag => new float3(g, a, g);
        public readonly float3 gab => new float3(g, a, b);
        public readonly float3 gaa => new float3(g, a, a);

        // b
        public readonly float3 brr => new float3(b, r, r);
        public readonly float3 brg => new float3(b, r, g);
        public readonly float3 brb => new float3(b, r, b);
        public readonly float3 bra => new float3(b, r, a);

        public readonly float3 bgr => new float3(b, g, r);
        public readonly float3 bgg => new float3(b, g, g);
        public readonly float3 bgb => new float3(b, g, b);
        public readonly float3 bga => new float3(b, g, a);

        public readonly float3 bbr => new float3(b, b, r);
        public readonly float3 bbg => new float3(b, b, g);
        public readonly float3 bbb => new float3(b, b, b);
        public readonly float3 bba => new float3(b, b, a);

        public readonly float3 bar => new float3(b, a, r);
        public readonly float3 bag => new float3(b, a, g);
        public readonly float3 bab => new float3(b, a, b);
        public readonly float3 baa => new float3(b, a, a);

        // a
        public readonly float3 arr => new float3(a, r, r);
        public readonly float3 arg => new float3(a, r, g);
        public readonly float3 arb => new float3(a, r, b);
        public readonly float3 ara => new float3(a, r, a);

        public readonly float3 agr => new float3(a, g, r);
        public readonly float3 agg => new float3(a, g, g);
        public readonly float3 agb => new float3(a, g, b);
        public readonly float3 aga => new float3(a, g, a);

        public readonly float3 abr => new float3(a, b, r);
        public readonly float3 abg => new float3(a, b, g);
        public readonly float3 abb => new float3(a, b, b);
        public readonly float3 aba => new float3(a, b, a);

        public readonly float3 aar => new float3(a, a, r);
        public readonly float3 aag => new float3(a, a, g);
        public readonly float3 aab => new float3(a, a, b);
        public readonly float3 aaa => new float3(a, a, a);

        // RGBA - Swizzles - float2

        public readonly float2 rr => new float2(r, r);
        public readonly float2 rg => new float2(r, g);
        public readonly float2 rb => new float2(r, b);
        public readonly float2 ra => new float2(r, a);

        public readonly float2 gr => new float2(g, r);
        public readonly float2 gg => new float2(g, g);
        public readonly float2 gb => new float2(g, b);
        public readonly float2 ga => new float2(g, a);

        public readonly float2 br => new float2(b, r);
        public readonly float2 bg => new float2(b, g);
        public readonly float2 bb => new float2(b, b);
        public readonly float2 ba => new float2(b, a);

        public readonly float2 ar => new float2(a, r);
        public readonly float2 ag => new float2(a, g);
        public readonly float2 ab => new float2(a, b);
        public readonly float2 aa => new float2(a, a);

        #endregion Swizzles_Extra_RGBA
    }
}
