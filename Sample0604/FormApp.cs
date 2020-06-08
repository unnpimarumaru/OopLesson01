using System;
using System.Drawing;
using System.Windows.Forms;

class FormApp
{

    static Form form;
    static Label RedlabelClor;
    static Label YellowlabelClor;
    static Label BluelabelClor;
    //列挙型（信号の状態）
    //状態　０：赤　１：青　２：黄色
    //static int Status = 0; //初期状態は赤

    enum Signals
    {
        RED,
        BLUE,
        YELLOW
    }

    static Signals Status = Signals.RED;
       
    public static void Main()
    {
        form = new Form();
        form.Text = "フォームアプリケーション";
        form.Width = 800;
        form.Height = 600;
        


        Button buttonclorcheange = new Button();
        buttonclorcheange.Text = "色チェンジ";
        buttonclorcheange.Top = 150;
        buttonclorcheange.Left = 50;
        buttonclorcheange.Height= 60;
        buttonclorcheange.Width = 60;
        buttonclorcheange.Click += Buttonclorcheange_Click;
        buttonclorcheange.Parent = form;


        BluelabelClor = new Label();
        BluelabelClor.Left = 30;
        BluelabelClor.Top = 20;
        BluelabelClor.BorderStyle = BorderStyle.FixedSingle;
        BluelabelClor.Height = 60;
        BluelabelClor.Width = 60;
        BluelabelClor.BackColor = Color.Blue;
        BluelabelClor.Parent = form;

        YellowlabelClor = new Label();
        YellowlabelClor.Left = 130;
        YellowlabelClor.Top = 20;
        YellowlabelClor.BorderStyle = BorderStyle.FixedSingle;
        YellowlabelClor.Height = 60;
        YellowlabelClor.Width = 60;
        YellowlabelClor.BackColor = Color.Yellow;
        YellowlabelClor.BackColor = Color.Transparent;
        YellowlabelClor.Parent = form;

        RedlabelClor = new Label();
        RedlabelClor.Left = 230;
        RedlabelClor.Top = 20;
        RedlabelClor.BorderStyle = BorderStyle.FixedSingle;
        RedlabelClor.Height = 60;
        RedlabelClor.Width = 60;
        RedlabelClor.BackColor = Color.Red;
        RedlabelClor.BackColor = Color.Transparent;
        RedlabelClor.Parent = form;


        Application.Run(form);
    }

    private static void Buttonclorcheange_Click(object sender, EventArgs e)
    {

        BluelabelClor.BackColor = Color.Transparent;
        YellowlabelClor.BackColor = Color.Transparent;
        RedlabelClor.BackColor = Color.Transparent;


        if (Status == Signals.RED)
        {
            //赤が点灯
            BluelabelClor.BackColor = Color.Blue;
            Status = Signals.BLUE;//青へ遷移
        }
        else if(Status == Signals.BLUE)
        {
            YellowlabelClor.BackColor = Color.Yellow;
            Status = Signals.YELLOW;//黄へ遷移
        }
        else
        {
            RedlabelClor.BackColor = Color.Red;
            Status = Signals.RED;//赤へ遷移
        }


        //if (RedlabelClor.BackColor == Color.Red)
        //{
          //  RedlabelClor.BackColor = Color.Blue;
        //}
        //else if (RedlabelClor.BackColor == Color.Yellow) 
        //{
          //  RedlabelClor.BackColor = Color.Red;
        //}
       // else
        //{
         //   RedlabelClor.BackColor = Color.Yellow;

        //}
    }
}