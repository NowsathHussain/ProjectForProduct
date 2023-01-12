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
            //1stQues
            //Loaddata(inputFilePath);
            //Product p1=Prodicts[1];

            //2ndQues complete 
            //Console.WriteLine(p1.Name);

            //3rdQues complete
            //Console.WriteLine(p1.Id);

            //4thQues complete
            AddList(inputFilePath);

            //5thQues 
            //string name = Getstring("Enter your name : ");
            //int Unitprice = Getinterger("Enter the product unitprice : ");
            //int taxprecentage = Getinterger("Enter the Tax precentage : ");
            //string Category = Getstring("What category ? ");
            //CreateProduct(inputFilePath, Unitprice, name, Category, taxprecentage);

            //6thQues

            //7thQues

            //8thQues
            //Console.WriteLine("Name ,Status ");
            //string Input = Getstring("Which items you want to see? ");
            //ShowProduct(Input);

            //9thQues
            Console.WriteLine("Name ,Status ");
            string Input = Getstring("Which items you want to see? ");
            ShowProduct(Input);

            //10thQues



        }
        #region Functions
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
            //File.AppendAllLines
            foreach (string Prod in ml)
            {
                string[] myprod = Prod.Split('|');
                Product p = new Product(Convert.ToInt32(myprod[0]), myprod[1], myprod[2], double.Parse(myprod[3]), (Taxprecent)Enum.Parse(typeof(Taxprecent), myprod[4]), (Status)Enum.Parse(typeof(Status), myprod[5]));
                m2.Add(p);
            }
        }
        public static void CreateProduct(string inputFilePath, int Unitprice, string name, string Category, int taxprecentage)
        {      
            AddList(inputFilePath);
            int temp = 0;
            foreach (Product l in m2)
            {
                temp = l.Id;
            }
            //Console.WriteLine(temp + 1);           
            StreamWriter writter = new StreamWriter(inputFilePath,true);
            writter.WriteLine( temp+1+"|"+name+"|"+Category+"|"+Unitprice+"|"+taxprecentage+"|"+"Active");
            Console.WriteLine("Product added successfully");
            writter.Close();
        }
        public static void ShowProduct(string input)
        {
            if (input=="Name")
            {
                Console.WriteLine("Product name : ");
               foreach (Product l in m2)
                   {
                     Console.WriteLine(l.Name);
                   }
            }
            if (input == "Status")
            {
                
                Console.WriteLine("Status name : ");
                string status = Status.Active.ToString();
                Status MyStatus = (Status)Enum.Parse(typeof(Status), "Disconnected");
                Console.WriteLine(MyStatus);
               
                    foreach (Product l in m2)
                    {
                        if(l.Status==MyStatus)
                        {
                            Console.WriteLine(l.ToString());
                        }
                    }
                
                
                
            }

            
        }



        #endregion
        #region methods
        public static int Getinterger(string message)
        {
            Console.WriteLine(message);
            int temp = int.Parse(Console.ReadLine());
            return temp;
        }
        public static string Getstring(string message)
        {
            Console.WriteLine(message);
            string temp = Console.ReadLine();
            return temp;
        }
        #endregion


    }
}
