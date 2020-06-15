
using System;
using System.Drawing;
using System.Windows.Forms;


//ボールクラス
class Ball
{
    //プロパティ
    public double Xpos { get; set; } //X座標
    public double Ypos { get; set; } //Y座標
    public Image Img { get; set; }//画像データ

    private double moveX; //　加速度（X)
    private double moveY; //加速度（Y)
    
    //コンストラクタ
    public Ball()
    {
    
        Xpos = 0;
        Ypos = 0;
        Img = Image.FromFile(@"images\socer_ball.png");
       
       moveX = 5;
       moveY = 5;
    }

    //引数付きコンストラクタ(座標指定）
    public Ball (double xp,double yp)
    {
        Xpos = xp;
        Ypos = yp;
        Img = Image.FromFile(@"images\soccer_ball.png");

        Random rand = new Random();

        moveX = rand.Next(-10, 10);
        moveY = rand.Next(-10, 10);

    }

 

    //移動
    public void Move()
    {
        
        Xpos += moveX;
        Ypos += moveY;

    }





}