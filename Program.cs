using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Stationary_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            #region INT Call
            //string path = "E:\\Stationaryshop\\items.txt";
            //string[] file = File.ReadAllLines(path);
            //Product[] pr = new Product[file.Length];

            //Dictionary<int, Product> dick = new Dictionary<int, Product>();

            //for (int i = 0; i < file.Length; i++)
            //{
            //    string[] split = file[i].Split('|');
            //    pr[i] = new Product();
            //    pr[i].Id = int.Parse(split[0]);
            //    pr[i].Product1 = split[1];
            //    pr[i].Category = split[2];
            //    pr[i].Price = float.Parse(split[3]);
            //    pr[i].Taxtype = split[4];
            //    pr[i].Status = split[5];
            //    dick.Add(int.Parse(split[0]), pr[i]);
            //}
            //Console.WriteLine("Enter the Key : ");
            //int key_ = int.Parse(Console.ReadLine());
            //Product dummy = dick[key_];
            //Console.WriteLine(dummy);
            #endregion

            #region Name Call 
            //string path = "E:\\Stationaryshop\\items.txt";
            //string[] file = File.ReadAllLines(path);
            //Product[] pr = new Product[file.Length];

            //Dictionary<string, Product> dick = new Dictionary<string, Product>();

            //for (int i = 0; i < file.Length; i++)
            //{
            //    string[] split = file[i].Split('|');
            //    pr[i] = new Product();
            //    pr[i].Id = int.Parse(split[0]);
            //    pr[i].Product1 = split[1];
            //    pr[i].Category = split[2];
            //    pr[i].Price = float.Parse(split[3]);
            //    pr[i].Taxtype = split[4];
            //    pr[i].Status = split[5];
            //    dick.Add(split[1], pr[i]);
            //}
            //Console.WriteLine("Enter the Product_Name : ");
            //string name_ = Console.ReadLine();
            //Product dummy_name = dick[name_];
            //Console.WriteLine(dummy_name);
            #endregion

            string path = "E:\\Stationaryshop\\items.txt";
            string[] file = File.ReadAllLines(path);
            Product[] pr = new Product[file.Length];

            //Dictionary<string, Product> dick = new Dictionary<string, Product>();

            List<Product> list_name = new List<Product>();



            for (int i = 0; i < file.Length; i++)
            {
                string[] split = file[i].Split('|');
                list_name.Add(new Product(int.Parse(split[0]),split[1], split[2], float.Parse(split[3]), split[4], split[5]));
                //pr[i] = new Product();
                //pr[i].Id = int.Parse(split[0]);
                //pr[i].Product1 = split[1];
                //pr[i].Category = split[2];
                //pr[i].Price = float.Parse(split[3]);
                //pr[i].Taxtype = split[4];
                //pr[i].Status = split[5];
                //dick.Add(split[1], pr[i]);
            }
            //Console.WriteLine("Enter the Product_Name : ");
            //string name_ = Console.ReadLine();
            //Product dummy_name = dick[name_];
            //Console.WriteLine(dummy_name);

            Console.WriteLine(list_name[0]);
        }
    }
}
