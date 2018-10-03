using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Costumer
    {
        public Guid CostumerId { set; get;}
        public string Name{set;get;}
        public string SurName { set; get; }
        public string FatherName { set; get; }
        public string Mobile { set; get; }

        public Costumer()
        {
            CostumerId = new Guid();
        }

        public Costumer(string name, string surName, string fatherName, string mobile)
        {
            Name = name;
            SurName = surName;
            FatherName = fatherName;
            Mobile = mobile;
        }

        public void SetUser()
        {
            Console.WriteLine("Введите имя покупателя: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию покупателя: ");
            SurName = Console.ReadLine();
            Console.WriteLine("Введите отчество покупателя: ");
            FatherName = Console.ReadLine();
            Console.WriteLine("Введите мобильный телефон: ");
            Mobile = Console.ReadLine();

        }

    }
}
