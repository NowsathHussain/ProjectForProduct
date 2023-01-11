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
        static Dictionary<int,Product> Prodicts=new Dictionary<int,Product>();
    
        static List<Product> m2 = new List<Product>();
        static string inputFilePath = "C:\\MySampleIO\\Product.txt";
        static void Main(string[] args)
        {
            Loaddata(inputFilePath);
            Product p1=Prodicts[1];

            //2ndQues 
            Console.WriteLine(p1.Name);
            //3rdQues 
            Console.WriteLine(p1.Id);
            //4thQues
            AddList(inputFilePath);
            

        }
        private static void CreateDirectory(string path)
        {
            Directory.CreateDirectory(path);
        }
        public static void Loaddata(string inputFilePath)
        {
            string[] Products = File.ReadAllLines(inputFilePath);
            foreach(string Prod in Products)
            {
                string[] myprod =Prod.Split('|');
                Product p = new Product(Convert.ToInt32(myprod[0]), myprod[1], myprod[2], double.Parse(myprod[3]), (Taxprecent)Enum.Parse(typeof(Taxprecent), myprod[4]), (Status)Enum.Parse(typeof(Status), myprod[5]));
                Prodicts.Add(Convert.ToInt32(myprod[0]), p);
            }
            

        }
        public static void AddList(string inputFilePath)
        {
            string[] ml = File.ReadAllLines(inputFilePath);
            foreach (string Prod in ml)
            {
                string[] myprod = Prod.Split('|');
                Product p = new Product(Convert.ToInt32(myprod[0]), myprod[1], myprod[2], double.Parse(myprod[3]), (Taxprecent)Enum.Parse(typeof(Taxprecent), myprod[4]), (Status)Enum.Parse(typeof(Status), myprod[5]));
                m2.Add(p);
            }
            foreach (Product l in m2)
            {
                Console.WriteLine(l);
            }
        }
        
    }
}
