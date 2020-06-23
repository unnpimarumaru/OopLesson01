using System;
using System.Collections.Generic;
using System.ComponentModel;
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

            int[] totals = new int[4] { 0, 0, 0, 0};
            string[] shops = { "新宿店", "浅草店", "丸の内店", "横浜店", };

            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));
            
            
            foreach (var item in sales._sales)
            {
                for (int i = 0; i < shops.Length; i++)
                {
                    if (item.ShopName.Equals(shops[i]))
                    {
                        totals[i] += item.Amount;
                        break;
                    }
               
                }
            }
            for (int i = 0; i < shops.Length; i++)
            {
                Console.WriteLine($"{shops[i]}の売上合計：{totals[i]}");
            }
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
                sales.Add(sale); //saleオブジェクトをリストに追加
            }
            return sales;
        }

    }
}
