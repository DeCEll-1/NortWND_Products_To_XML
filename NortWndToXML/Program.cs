using DataAccessLayer;
using DataAccessLayer.sqlmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortWndToXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataModel dm = new DataModel();
            //foreach (Urun item in dm.UrunlerListesi(0))
            //{
            //    Console.WriteLine(item.ProductID);
            //    Console.WriteLine(item.ProductName);
            //    Console.WriteLine(item.CategoryName);
            //    Console.WriteLine(item.QuantityPerUnit);
            //    Console.WriteLine(item.UnitPrice);
            //    Console.WriteLine(item.UnitsInStock);
            //    Console.WriteLine(item.UnitsOnOrder);
            //    Console.WriteLine(item.ReorderLevel);
            //    Console.WriteLine(item.Discontinued);
            //    Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");
            //}

            Depo d = new Depo();
            d.UrunlerListesiDepo = dm.UrunlerListesi(0);
            d.Isim = "amogus";
            string a = dm.UrulerListesiToXMLString(d);
            Console.WriteLine(a);
        }
    }
}
