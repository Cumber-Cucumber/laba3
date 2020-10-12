using System;
using System.Collections.Generic;

namespace Laba3
{
    public class Program
    {
        partial class Class_Partial // Вторая часть объединения классов
        {
            uint second;
        }

        public static void Main()
        {

            Osnova.Check_Constr();
            Osnova.Chek_Ref_Out();
            Osnova.Gaymer.Check_Private_Constr();
            Osnova.Chek_ToString_Override();
            Osnova.Chek_Equals_Override();
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");



            Airline air1 = new Airline("Дубаи", 248, "Boing400", "01.02.2010", "Понедельник");
            Airline air2 = new Airline("Минск", 444, "Dragon", "29.12.2020", "Понедельник");
            Airline air3 = new Airline("Минск", 432, "Okula", "29.12.1999", "Пятница");
            Airline air4 = new Airline("Мордор", 253, "Kobachek", "29.12.2003", "Суббота");
            Airline air5 = new Airline("Кельталас", 888, "ViktorSilin", "29.12.2020", "Суббота");
            Airline[] air = { air1, air2, air3, air4, air5 };

            For_Point(air, "Минск");
            For_Day(air, "Понедельник");

        }

        static void For_Point(Airline[] air, string punkt) // Функция вывода рейсов по пункту назначения
        {
            if (string.IsNullOrEmpty(punkt))
            {
                Console.WriteLine("\nНекорректно введены данные");
                return;
            }
            Console.WriteLine("\nВывод рейсов по пункту назначения: ");
            for (int i = 0; i < air.Length; i++)
            {
                if (air[i].Destination_S == punkt)
                {
                    Console.WriteLine(air[i].Info());
                }
            }
        }
        static void For_Day(Airline[] air, string day) // Функция вывода рейсов по дню недели
        {
            if (string.IsNullOrEmpty(day))
            {
                Console.WriteLine("\nНекорректно введены данные");
                return;
            }
            Console.WriteLine("\nВывод рейсов по дню недели: ");
            for (int i = 0; i < air.Length; i++)
            {
                if (air[i].Day_of_week_S == day)
                {
                    Console.WriteLine(air[i].Info());
                }
            }
        }
    }
}
