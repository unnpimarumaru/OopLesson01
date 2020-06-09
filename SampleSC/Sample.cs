using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//Formクラスを継承したSampleクラス
class Sample : Form
{

    public static void Main()
    {

        Application.Run(new Sample());
    }
    //デフォルトコンストラクタ
    public Sample()
    {
        var rand = new Random();


        int r = rand.Next(0, 100);//0から100

        for (int j = 0; j < 20; j++)
        {
            Console.Write("{0} ", rand.Next(1, 20));

        }
    }
}

    







