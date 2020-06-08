using System;
using System.Drawing;
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
       int[] scores = {64, 71, 31, 97, 54};

        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine(scores[i]);
        }
    
    
    
    
    }


}