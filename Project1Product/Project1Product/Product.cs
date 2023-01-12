using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Product
{
    public class Product
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

        double _unitprice;

        Taxprecent _taxprecent;

        Status _Status;

        public Product(int id, string name, string category, double unitprice, Taxprecent Taxprecent, Status status)
        {
            this._id = id;
            this._name = name;
            this._unitprice = unitprice;
            this._taxprecent = Taxprecent;
            this._category = category;
            this._Status = status;  

        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}",this._id,this._name,this._unitprice,this._taxprecent,this._category,this._Status);
        }
    }
    public enum Taxprecent
    {
        No = 0,
        Low = 5,
        Mid = 12,
        High = 18,
        lux = 22,
    }
    public enum Status
    {
        Active = 0,
        Disconnected = 1,
    }
    

}
