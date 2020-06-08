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
       int[]  scores = new int[5];

        //scores[0] = 10;
        //scores[1] = 20;
        //scores[2] = 30;
        //scores[3] = 40;
        //scores[4] = 50;


        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = (i * 20) + 20;

        }



        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine(scores[i]);
        }
    
    
    
    
    }


}