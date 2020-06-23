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
            Dictionary<string, int> stores = new Dictionary<string, int>();

            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));

            foreach (var item in sales._sales)
            {
            
                if (stores.ContainsKey(item.ShopName))
                {
                    stores[item.ShopName] += item.Amount;
                }
                else
                {
                    stores[item.ShopName] = item.Amount;
                }

            }
            foreach (var item in stores)
            {
                Console.WriteLine($"{item.Key}は{item.Value}です。");
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
