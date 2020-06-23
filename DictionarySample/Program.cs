using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> color = new Dictionary<string, string>
            {
                {"黒","black" },
                {"白","white" },
                {"黄","Yellow"}
            };

            //配列のように値を追加
            color["赤"] = "Red";
            //Addメソッドでの値の追加
            color.Add("青", "Blue");

            foreach (var key in color.Keys)
            {
                Console.WriteLine($"{key}は{color[key]}です。");
            }

            //キーの存在チェック
            if (color.ContainsKey("赤"))
            {
                Console.WriteLine("赤は存在しています。");
            }
            else
            {
                Console.WriteLine("赤は存在しません。");
            }

            //値の存在チェック
            if (color.ContainsKey("Red"))
            {
                Console.WriteLine("Redは値に存在しています。");
            }
            else
            {
                Console.WriteLine("Redは値に存在しません。");
            }

        }
    }
}
