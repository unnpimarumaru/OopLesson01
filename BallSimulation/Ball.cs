
using System;
using System.Drawing;
using System.Windows.Forms;


//ボールクラス
class Ball
{

    //静的プロパティ
    public static int Count; //オブジェクトの個数をカウント

    //乱数
    Random rnd = new Random();


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

    //引数付きコンストラクタ(座標指定）
    public Ball (double xp,double yp,String path)
    {
        Xpos = xp;
        Ypos = yp;
        Img = Image.FromFile(path);

        Random rand = new Random();

        moveX = rand.Next(-10, 100);
        moveY = rand.Next(-10, 100);

        Count++;

    }

 

    //移動
    public void Move()
    {
        

        Xpos += moveX;
        Ypos += moveY++;

        if (Xpos >= 1000|| Xpos <=0)
        {
            moveX = -moveX;

        }
        if(Ypos >= 650 || Ypos <=0)
        {
            moveY = -moveY;
        }

        Console.WriteLine("XPos = {0},YPos = {1}",(int)Xpos, (int)Ypos);


    }





}