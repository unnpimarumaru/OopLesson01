using System.Windows.Forms;

class Stage : Form
{
    //ボールオブジェクト表示用
    private PictureBox soccreBall = new PictureBox();



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
        PictureBox pictureBox = new PictureBox();
        pictureBox.Width = 100;
        pictureBox.Height = 100;
        pictureBox.Top = (int)ball.Ypos;
        pictureBox.Left = (int)ball.Xpos;
        pictureBox.Image = ball.Img;
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Parent = this;

    }


}