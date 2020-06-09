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
        string moji = "";

        //stringの別名（エイリアス）がString

        var str = "";

        str = Console.ReadLine();
        var city = str.Split(',');

        for (int i = 0; i < city.Length; i++)
        {
            Console.Write("群馬県");
            Console.WriteLine(city[i] + "市");


        }
    }
}

    







