
using System.Drawing;


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
        Img = Image.FromFile(@"images\soccer_ball.png");

        moveX = 5;
        moveY = 5;
    }

   

    //移動
    public void Move()
    {
        Xpos += moveX;
        Ypos += moveY;
    }





}