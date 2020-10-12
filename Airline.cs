using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Laba3
{
    public class Osnova
    {
        public class Gaymer
        {
            private string nickname;
            private string game;
            public static uint number_of_gaymers = 0; // Статическое поле, хранящее количество созданных экземпляров

            public Gaymer() { nickname = "Неизвестная личностб"; game = "Неизвестная гейм"; } // Первый конструктор
            public Gaymer(string b) { nickname = "Неизвестная личностб"; game = b; } // Второй конструктор
            public Gaymer(string a, string b) { nickname = a; game = b; number_of_gaymers++; } // Третий конструктор (с инкрементом)
            static Gaymer() { Console.WriteLine("Создано при поддержке статического конструктора"); } // Статический конструктор
            private Gaymer(byte a) { Console.WriteLine("Создано при поддержке закрытого конструктора\n"); } // Закрытый конструктор

            public void ReadGaymers()
            {
                Console.WriteLine($"Ник: {nickname}\nДисциплина: {game}\n");
            }

            public static void Check_Private_Constr()
            {
                Gaymer priv = new Gaymer(1);
            }
        }
        public static void Check_Constr() // Проверка работы конструкторов
        {
            Gaymer odin = new Gaymer();
            Gaymer dva = new Gaymer("League of Legends");
            Gaymer treee = new Gaymer("Sponyara", "Killmyself");
            Gaymer treeee = new Gaymer("Nahagliivv", "Celebrate");
            Gaymer treeeee = new Gaymer("Nahagliivv", "Stack some Thicc");


            odin.ReadGaymers();
            dva.ReadGaymers();
            treee.ReadGaymers();
            Console.WriteLine($"Создано полностью известных атлетов: {Gaymer.number_of_gaymers}\n");
        }



        private string read_string = "Я только для чтения";

        private string Primer
        {
            get
            {
                return read_string;  // Только для чтения
            }
        }

        private const string constanta = "Меня не поменяешь";  // Константа

        private static uint a;

        private static void Func_Ref_Out(ref uint a, out uint b) // ref и out
        {
            b = a * a;
            a += b;
        }
        public static void Chek_Ref_Out()
        {
            Func_Ref_Out(ref a, out uint b);
            Console.WriteLine("Переменная а изменилась: " + a);
            Console.WriteLine("Переменная b была возвращена: " + b + "\n");
        }

        partial class Class_Partial // Первая часть объединения классов
        {
            uint first;
        }

        private class ToString_Class
        {
            public string tostring_class_parameter;
            public override string ToString() // Переопределение
            {
                if (String.IsNullOrEmpty(tostring_class_parameter))
                    return base.ToString();
                return tostring_class_parameter;
            }
        }
        public static void Chek_ToString_Override()
        {
            ToString_Class example = new ToString_Class { tostring_class_parameter = "" };
            Console.WriteLine("Если tostring_class_parameter пуст, то сработает стандартный метод ToString(), если tostring_class_parameter не пуст, то он выведется:\n" + example.ToString());
        }

        private class GetHashCode_Class
        {
            public int gethashcode_class_parameter;
            public override int GetHashCode() // Переопределение
            {
                return gethashcode_class_parameter * gethashcode_class_parameter / 8;
            }
        }

        public class Equals_Class
        {
            public override bool Equals(object obj) // Переопределение
            {
                if (obj.GetType() == this.GetType()) // Преколы с получением типа объекта и сравнения его с типом проверяемого объекта (текущего)
                    return true;
                else
                    return false;
            }
        }
        public static void Chek_Equals_Override()
        {
            Equals_Class example1 = new Equals_Class { }; // example1.GetType() вернёт Equals_Class
            Equals_Class example2 = new Equals_Class { }; // example2.GetType() вернёт Equals_Class
            Console.WriteLine("Результат сравнения объектов example1 и example2: " + example1.Equals(example2));
        }
    }

    public class Airline
    {
        private string destination; // Пункт назначения
        private uint flight_number; // Номер рейса
        private string aircraft_type; // Тип самолёта
        private string departure_time; // Время вылета
        private string day_of_week; // День недели

        public string Destination_S
        {
            get
            {
                if (string.IsNullOrEmpty(destination))
                {
                    throw new ArgumentNullException("В пункте назначения ничего не записано");
                }
                return destination;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("В пункте назначения ничего не записано");
                }
                destination = value;
            }
        }
        public uint Flight_number_S
        {
            get
            {
                if (flight_number <= 0)
                {
                    throw new ArgumentNullException("В номере рейса ничего не записано");
                }
                return flight_number;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("В номере рейса ничего не записано");
                }
                flight_number = value;
            }
        }
        public string Aircraft_type_S
        {
            get
            {
                if (string.IsNullOrEmpty(aircraft_type))
                {
                    throw new ArgumentNullException("В типе самолёта ничего не записано");
                }
                return aircraft_type;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("В типе самолёта ничего не записано");
                }
                aircraft_type = value;
            }
        }
        public string Departure_time_S
        {
            get
            {
                if (string.IsNullOrEmpty(departure_time))
                {
                    throw new ArgumentNullException("Во времени отправки ничего не записано");
                }
                return departure_time;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Во времени отправки ничего не записано");
                }
                departure_time = value;
            }
        }
        public string Day_of_week_S
        {
            get
            {
                if (string.IsNullOrEmpty(day_of_week))
                {
                    throw new ArgumentNullException("В дне недели ничего не записано");
                }
                return day_of_week;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("В дне недели ничего не записано");
                }
                day_of_week = value;
            }
        }

        public Airline(string dest, uint number, string type, string time, string day) // Конструктор по умолчанию
        {
            destination = dest;
            flight_number = number;
            aircraft_type = type;
            departure_time = time;
            day_of_week = day;
        }

        public string Info()
        {
            return "Пункт назначения: " + destination.ToString() + "\n" +
                "Номер рейса: " + flight_number.ToString() + "\n" +
                "Тип самолёта: " + aircraft_type.ToString() + "\n" +
                "Время вылета: " + departure_time.ToString() + "\n" +
                "День недели: " + day_of_week.ToString() + "\n";
        }
    }
}

