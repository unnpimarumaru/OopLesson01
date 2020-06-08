using System;
using System.Drawing;
using System.Windows.Forms;
class FormApp 
{

    static Form form;
    public static void Main()
    {
        Timer timer = new Timer(); //タイマー

        timer.Tick += Timer_Tick;   
        timer.Interval = 500;
        timer.Start();
        form = new Form(); // フォームの生成

        form.Text = "フォームアプリケーション";
        form.Width = 800; //幅
        form.Height = 600; // 高さ
        form.BackColor = Color.DeepSkyBlue;
        //ラベル
        Label labelAppName = new Label();//ラベルの生成
        labelAppName.Text = "サンプルアプリ";
        labelAppName.Parent = form;//ラベルの親を設定

        //ボタン
        Button bottonPush = new Button();
        bottonPush.Text = "ボタン";
        bottonPush.Left =100; //y座標
        bottonPush.Top = 100;　//x座標
        // bottonPush.Location = new Point(100,100);
        bottonPush.Height =30;
        bottonPush.Width = 60;
        bottonPush.Click += BottonPush_Click;// デリケート登録
        bottonPush.Parent = form;




        Application.Run(form); //フォーム指定して起動

    }
    #region タイマー処理
    private static void Timer_Tick(object sender, EventArgs e)
    {
        if (form.BackColor == Color.Red)
        {
            form.BackColor = Color.Blue;
        }
        else
        {
            form.BackColor = Color.Red;
        }
    }
    #endregion 
   
    private static void BottonPush_Click(object sender, System.EventArgs e)
    {
        Button bt = (Button)sender;
        #region ボタンの色
        if (bt.BackColor == Color.Red)
        {
            bt.BackColor = Color.Blue;
        }
        else
        {
            bt.BackColor = Color.Red;
        }
        #endregion

        #region　背景の色

        if (form.BackColor == Color.Red)
        {
            form.BackColor = Color.Blue;
        }
        else
        {
            form.BackColor = Color.Red;
        }
　　　　#endregion
    }
}