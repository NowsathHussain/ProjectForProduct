using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project1Product
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "C:\\Users\\Nowsath\\eclipse-workspace\\ProjectFirst\\src\\resource\\Product.txt";

            //to Create folder
            //string path = "C:\\MySampleInput";
            //CreateDirectory(path);

            Console.WriteLine("Read all lines as an array and access array elements");
            string[] myFile = File.ReadAllLines(inputFilePath);
            string hir = myFile[0];
            string[] array_1 = null;

            char[] split_character = { '|' };

            array_1 = hir.Split(split_character);

            Console.WriteLine(array_1[2]);

            Product det = new Product();
            det.Id = Convert.ToInt32(array_1[0]);
            det.Name = array_1[1];
            det.Category = array_1[2];
            det.Unitprice = Convert.ToDouble(array_1[3]);
            det.Taxprecent = Convert.ToDouble(array_1[4]);
            det.Status = array_1[5];
            // Create dictonary 
            Dictionary<int, Product> md = new Dictionary<int, Product>();
            md.Add(104, det);

            foreach (KeyValuePair<int,Product>  x in md)
            {
                //Console.WriteLine(x.Key);
                Product p1 = x.Value;
                Console.WriteLine(p1.Id);
                Console.WriteLine(p1.Name);
                Console.WriteLine(p1.Category);
                Console.WriteLine(p1.Unitprice);
                Console.WriteLine(p1.Taxprecent);
                Console.WriteLine(p1.Status);
            }
            



        }
        private static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
        
    }
}
