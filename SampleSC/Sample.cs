using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

//Formクラスを継承したSampleクラス
class Sample:Form
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
        var str = "abcdefg";
        var length = str.Length;
        Console.WriteLine("文字数:" + str);
        Console.WriteLine("文字数:" + length);


    }

    


}




