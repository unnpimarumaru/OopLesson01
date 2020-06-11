
using System.Drawing;


//ボールクラス
class Ball
{
    //プロパティ
    public double Xpos { get; set; } //X座標
    public double Ypos { get; set; } //Y座標
    public Image Img { get; set; }//画像データ

    //コンストラクタ
    public Ball()
    {

        Xpos = 0;
        Ypos = 0;
        Img = Image.FromFile(@"images\soccer_ball.png");


    }

    //移動
    public void Move()
    {
        Xpos += 10;
        Ypos += 10;
    }





}