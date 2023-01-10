using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Product
{
    class Product
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        double _unitprice;

        public double Unitprice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }

        double _taxprecent;

        public double Taxprecent
        {
            get { return _taxprecent; }
            set { _taxprecent = value; }
        }

        string _Status;

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

    }
}
