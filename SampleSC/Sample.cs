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
        int[] scores = new int [5];
        int sum = 0;
        //scores[0] = 10;
        //scores[1] = 20;
        //scores[2] = 30;
        //scores[3] = 40;
        //scores[4] = 50;

        //整数値の取り込み


        //値の入力
        for (int i = 0; i < scores.Length; i++)
        {

            Console.Write("scores[" + i + "] = "); //画面に文字を出力

            scores[i] = int.Parse(Console.ReadLine());//入力値を読み込み

        }

        Console.WriteLine();

        //アスタリスク出力
        for (int j = 0; j < scores.Length; j++)
        {
            for (int i = 0; i < scores[j]; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        
    }



}

