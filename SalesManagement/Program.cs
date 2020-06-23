using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0; //全体の利上げ金額集計
            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));
            foreach(var item in sales._sales)
            {
                total+= item.Amount;


            }

            


            Console.WriteLine("全体の売り上げ：{0}円", total);
        }


        //売上データを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath)
        {
            //売上データを入れるオブジェクトを生成
            var sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            //読み込んだ数の行だけ繰り返す
            foreach (string line in lines)
            {
                string[] items = line.Split(',');

                //オブジェクト初期化子
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);　//saleオブジェクトをリストに追加
            }
            return sales;


        }






    }
}
