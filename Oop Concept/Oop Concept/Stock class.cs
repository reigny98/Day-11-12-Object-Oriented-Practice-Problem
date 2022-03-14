using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace _2_Inventory_Management
{
    public class Stock
    {

        public String StockName;
        public long NumberOfShare;
        public long SharePrice;
        public long TotalStockPrice;
        public override string ToString()
        {
            string st = $"StockName: {StockName}\nNumberOfShare: {NumberOfShare}\nSharePrice: {SharePrice}\nTotalStockPrice: {TotalStockPrice}";
            return st;
        }
    }
}
