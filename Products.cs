using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Products
{
    public class Product
    {
        private int code;

        public int Code
        {
            get => code;
            set
            {
                if (code < 0)
                {
                    Console.WriteLine("Code must be positive");
                }
                code=value;
            }
        }

        //private string name;

        //public string Name 
        //{
        //    get { return name; }
        //    set
        //    {
        //        if (name.Length < 3 ||name.Length > 30  )
        //        {
        //            Console.WriteLine("Name must be greater than 3 character and less than 30 characters");
        //        }
        //        name = value;
        //    }
        //}

        public float CostPrice
        {
            get
            {
                return costPrice;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cost price must be positive");
                    return;
                }
                costPrice = value;
            }
        }

        private float gstRate;

        public float GstRate
        {
            get => gstRate;
            set => gstRate = value;
        }

        private float GstAmount
        {
            get => CostPrice + gstRate / 100;
        }

        private float costPrice;

        public float SalePrice
        {
            get => costPrice + costPrice * 0.25f + GstAmount;
        }

        public void Add(int code, string name, float costPrice, float gstrate, float gstamount, float salesprice)
        {
            code = Code;
            //name = Name;
            costPrice = CostPrice;
            gstrate = GstRate;
            gstamount = GstAmount;
            salesprice = SalePrice;

        }

    } 


}



