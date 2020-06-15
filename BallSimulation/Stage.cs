using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

class Stage : Form
{
    //ボールオブジェクト表示用
    private PictureBox pictureBoxBall = new PictureBox();
    private Ball ball;

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
        timer.Interval = 50; //ms
        timer.Tick += Timer_Tick; //時間経過で呼ぶメソッド
        this.MouseClick += Stage_MouseClick;　//マウスクリックのデリケート登録

    }

    private void Stage_MouseClick(object sendder, MouseEventArgs e)
    {
        ball = new Ball(e.X-50, e.Y-50);
        
        pictureBoxBall.Width = 100;
        pictureBoxBall.Height = 100;
        pictureBoxBall.Left = (int)ball.Xpos;
        pictureBoxBall.Top = (int)ball.Ypos;
        pictureBoxBall.Image = ball.Img;
        pictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxBall.Parent = this;

        
        timer.Start(); //タイマースタート
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        ball.Move();

        pictureBoxBall.Left = (int)ball.Xpos;
        pictureBoxBall.Top = (int)ball.Ypos;
    }
}

