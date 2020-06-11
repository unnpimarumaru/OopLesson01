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
        Width = 1200;//幅
        Height = 800;//高さ
        Text = "ボールシミュレーション";



    }


}