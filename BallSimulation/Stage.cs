using System.Windows.Forms;

class Stage : Form
{
    //ボールオブジェクト表示用
    private PictureBox pictureBoxBall = new PictureBox();
    private Ball ball;

   


    public static void Main()
    {
        Application.Run(new Stage());
    }


    public Stage()
    {
        //フォームクラスの設定
        Width = 1200;//幅
        Height = 800;//高さ
        Text = "ボールシミュレーション";

        Ball ball = new Ball();//ボールオブジェクトの作成
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
    }


}