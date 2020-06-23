using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    //売上集計クラス
    class SalesCounter
    {
        private List<Sale> _sales;
        //コンストラクタ
        public SalesCounter(string path)
        {
            _sales = ReadSales(path);
        }

        //店舗別売り上げを求める
        public Dictionary<string,int> GetPerStoreSales()
        {
            Dictionary<string, int> stores = new Dictionary<string, int>();



            foreach (var item in _sales)
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
            
            return stores;



        }


        //売上データを読み込み、Saleオブジェクトのリストを返す
        private static List<Sale> ReadSales(string filePath)
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
