using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer tempCostumer = new Costumer();
            Store store = new Store();
            store.AddToProduct(new Product("Продукты питания", "Хлеб", 200));
            store.AddToProduct(new Product("Продукты питания", "Молоко", 300));
            store.AddToProduct(new Product("Продукты питания", "Кефир", 400));
            store.AddToProduct(new Product("Мыломойка", "Мыло", 1200));
            store.AddToProduct(new Product("Мыломойка", "Шампунь", 2200));

            while (true)
            {
                Console.WriteLine("1 - Вход/Регистрация");
                Console.WriteLine("2 - Выбор товаров");
                Console.WriteLine("3 - Корзина");
                Console.WriteLine("4 - Оплата");
                Console.WriteLine("5 - Категории");

                int key = 0;
                string strKey = Console.ReadLine();
                int.TryParse(strKey, out key);

                switch (key)
                {
                    case 1:
                        tempCostumer.SetUser();
                        Console.WriteLine("На ваш номер телефона отправлен код!!! Введите код:");
                        const string accountSid = "AC0fe81a4e2cfeff9c8d35f729f1c4806b";
                        const string authToken = "f447600882be8bcc34b9dce1d349d5f9";

                        TwilioClient.Init(accountSid, authToken);

                        Random random = new Random();
                        int randomAsInt = random.Next(1000, 9999);
                        string guidAsString = randomAsInt.ToString();

                       var message = MessageResource.Create(
                                body: guidAsString,
                                from: new PhoneNumber("+14784012018"),
                                to: new PhoneNumber("+77073757857")
                            );
                            Console.WriteLine(message.Body);
                        string str = Console.ReadLine();
                        if(str == message.Body.ToString())
                        {
                            store.SetCostumer(tempCostumer);
                            Console.WriteLine("Вы успешно зарегистрировались!!!");
                        }
                        else Console.WriteLine("Не верный код!!!");
                        break;
                    case 2:
                        store.ShowProduct();
                        Console.WriteLine("Введите ID товара");
                        string strId = Console.ReadLine();
                        Product tempProduct = store.SearchProduct(strId);
                        store.AddToCart(tempProduct);
                        Console.WriteLine("--------------------Товар добавлен в корзину!!!");
                        break;
                    case 3:
                        store.ShowCart();
                        break;
                    case 4: break;
                    case 5: break;
                }
            }

        }

    }
}
