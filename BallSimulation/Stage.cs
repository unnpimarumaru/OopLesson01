using System.Windows.Forms;

class Stage : Form
{
    public static void Main()
    {
        Application.Run(new Stage());
    }


    public Stage()
    {
        //フォームクラスの設定
        Width = 800;//幅
        Height = 600;//高さ
        Text = "ボールシミュレーション";



    }


}