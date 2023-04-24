using System;

namespace dz5
{

    class Enterprise
    {
        private int codeEnterprise;
        private int codeProduct;
        private string nameProduct;
        private decimal price;
        private int count;

        public Enterprise(int _codeEnterprise, int _codeProduct, string _nameProduct, decimal _price, int _count)
        {
            codeEnterprise = _codeEnterprise;
            codeProduct = _codeProduct;
            nameProduct = _nameProduct;
            price = _price;
            count = _count;
        }
        
        public Enterprise(){}

        public void SetcodeEnterprise(int codeEnterprise)
        {
            this.codeEnterprise = codeEnterprise;
        }
        
        public int GetcodeEnterprise()
        {
            return codeEnterprise;
        }
        
        public void SetcodeProduct(int codeProduct)
        {
            this.codeProduct = codeProduct;
        }
        
        public int GetcodeProduct()
        {
            return codeProduct;
        }          
        
        public void Setcount(int count)
        {
            this.count = count;
        }
        
        public int Getcount()
        {
            return count;
        }        
        
        public void Setcprice(decimal price)
        {
            this.price = price;
        }
        
        public decimal Getprice()
        {
            return price;
        }
        
        public void SetnameProduct(string nameProduct)
        {
            this.nameProduct = nameProduct;
        }
        
        public string GetnameProduct()
        {
            return nameProduct;
        }

        public decimal GetCost()
        {
            return this.price * this.count;
        }

        public void Input()
        {
            Console.Write("Code Enterprise: ");
            codeEnterprise = Convert.ToInt32(Console.ReadLine());
            Console.Write("Code Product: ");
            codeProduct = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name Product: ");
            nameProduct = Console.ReadLine();
            Console.Write("Price: ");
            price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Count: ");
            count = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Code Enterprise: "+ codeEnterprise);
            Console.WriteLine("Code Product: "+ codeProduct);
            Console.WriteLine("Name Product: "+ nameProduct);
            Console.WriteLine("Price: "+ price);
            Console.WriteLine("Count: "+ count);
        }
        
        public static decimal GetCostGlobal(Enterprise enterprise)
        {
            return enterprise.Getprice() * enterprise.Getcount();
        }
        
    }
    
    internal class Program
    {
        public static void Main()
        {
            Enterprise enterprise = new Enterprise(1, 1, "Product", 10.5m, 5);
            Console.WriteLine("Cost Global: " + Enterprise.GetCostGlobal(enterprise));
        }
    }
}
