using System;
namespace project_7_7

{
    abstract class Delivery
    {
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public virtual void DatIAdress()
        {
            Console.WriteLine($"Адрес доставки {Adress}");
            Console.WriteLine($"Время доставки {Date}");
        }





        public string Name;
        public string LastName;
        public virtual double Age
        {

            get;
            set;

        }




        public virtual void DisplayName() // ввод имени и фамилии для заказа и возраст
        {
            Console.WriteLine("Введите имя для того, чтобы сделать заказ");
            Name = Console.ReadLine();
            Console.WriteLine(Name);
            Console.WriteLine("Введите возраст");
            Age = double.Parse(Console.ReadLine());
            Console.WriteLine($"Ваш возраст:{Age}");
        }
    }

     class HomeDelivery : Delivery
    {

    }

    class PickPointDelivery : PickPointInfo
    {
        public static void WaitingTime(ref int day,ref int dayshavepassed)
        {
            day = 5;
            dayshavepassed = 0;
            
            

            for (; dayshavepassed <= day; dayshavepassed++)
            {
                
                if (dayshavepassed == day)
                {
                    Console.WriteLine("Время ожидания в колличестве:{0} дней, кончилось",day);
                }
            }
        }
    }

    class ShopDelivery : Delivery
    {
        string ShopName { get; set; }
        public override void DatIAdress()
        {
            base.DatIAdress();
            Console.WriteLine($"Название магазина:{ShopName}");
        }

    }

    class Order<TDelivery,
    TStruct> : Delivery where TDelivery : Delivery
    {
        public TDelivery Delivery;
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст заказщика должен быть больше 18 лет");
                }
                else
                {
                    age = value;
                }

            }
        }
        public int DataTime;

        public override void DisplayName()
        {
            base.DisplayName();
            Console.WriteLine("Введите фамилию,чтобы перейти к оформлению заказа");
            LastName = Console.ReadLine();

        }



        public int Number;

        public string Description;





    }
    abstract class PickPointInfo
    {
        string NameCompany { get; set; }
        string AdressCompany { get; set; }
        string TimeWork { get; set; }
        public override string ToString()
        {
            return $"Название компании доставки:{NameCompany}\n адрес компании:{AdressCompany}\n время работы компании:{TimeWork}";
                
        }


    }
}

