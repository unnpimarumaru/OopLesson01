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
        Console.Write("文字列：");
        var str = Console.ReadLine();
        Console.Write("置換前：");
        string beformoji = Console.ReadLine();
        Console.Write("置換後：");
        string aftermoji = Console.ReadLine();

        var str2 = str.Replace(beformoji, aftermoji);
        Console.WriteLine(str2);



    }

    


}




