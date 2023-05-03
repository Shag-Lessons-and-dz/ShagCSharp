using System;

namespace dz8_26._04._2023
{
    enum Countries
    {
        USA = 1,
        Ukraine = 380,
        Australia = 61,
        Mexico = 52
    }

    struct Subscribe
    {
        private string name;
        private string phoneNumber;
        private string address;
        private Countries code;

        public Subscribe(string name, string phoneNumber, string address, Countries code)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.code = code;
        }

        public void Input()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();
    
            Console.Write("Phone number: ");
            phoneNumber = Console.ReadLine();
    
            Console.Write("Address: ");
            address = Console.ReadLine();
    
            Console.Write("Country code: ");
            string codeStr = Console.ReadLine();
            if (Enum.TryParse(codeStr, out Countries countryCode))
            {
                code = countryCode;
            }
            else
            {
                Console.WriteLine("Invalid country code. Setting to USA by default.");
                code = Countries.USA;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Phone number: {phoneNumber}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Country code: {code}");
        }
    
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
    
        public Countries Code
        {
            get { return code; }
            set
            {
                if (Enum.IsDefined(typeof(Countries), value))
                {
                    code = value;
                }
                else
                {
                    Console.WriteLine("Invalid country code. Setting to USA by default.");
                    code = Countries.USA;
                }
            }
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Subscribe subscriber = new Subscribe("", "", "", Countries.USA);
            subscriber.Input();
            subscriber.Print();
            Console.ReadKey();
        }
    }

}