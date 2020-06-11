using System;
using System.Windows.Forms;

class Stage : Form
{
    //ボールオブジェクト表示用
    private PictureBox pictureBoxBall = new PictureBox();
    private Ball ball;

    //タイマー
    private Timer timer = new Timer();


    public static void Main()
    {
        Application.Run(new Stage());
    }


    public Stage()
    {
        //フォームクラスの設定
        Width = 1200;//幅
        Height = 800;//高さ
        base.Text = "ボールシミュレーション";

        ball = new Ball();//ボールオブジェクトの作成
        pictureBoxBall.Width = 100;
        pictureBoxBall.Height = 100;
        pictureBoxBall.Top = (int)ball.Ypos;
        pictureBoxBall.Left = (int)ball.Xpos;
        pictureBoxBall.Image = ball.Img;
        pictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxBall.Parent = this;
        ball.Move();
       pictureBoxBall.Left = (int)ball.Xpos;
       pictureBoxBall.Top = (int)ball.Ypos;

        timer.Interval = 100; 　//ms
        timer.Tick += Timer_Tick;//時間経過で呼ぶメソッド
        timer.Start();//タイマースタート

        }

    private void Timer_Tick(object sender, EventArgs e)
    {
        ball.Move();
        pictureBoxBall.Left = (int)ball.Xpos;
        pictureBoxBall.Top = (int)ball.Ypos;
    }
}

