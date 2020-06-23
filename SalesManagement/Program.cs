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
            SalesCounter sales = new SalesCounter(("Sales.csv"));

            Dictionary<string, int>  amountPerStore = sales.GetPerStoreSales();

            foreach (var item in amountPerStore)
            {
                Console.WriteLine($"{item.Key}は{item.Value}です。");
            }


        }


    }
}
