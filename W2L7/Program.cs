using System;

namespace W2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("5 i 5 są równe");
            }

            Console.ReadKey();

            int c = 15;
            int result = c % 2;

            if (result != 0)
            {
                Console.WriteLine($"{c} jest liczbą nieparzystą");
            }

            Console.ReadKey();

            int d = 14;

            if (d > 0)
            {
                Console.WriteLine($"{d} jest liczbą dodatnią");
            }
            else
            {
                Console.WriteLine($"{d} jest liczbą ujemną");
            }

            Console.ReadKey();

            int year = 2016;

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine($"{year} jest rokiem przestępnym");
            else
                Console.WriteLine($"{year} nie jest rokiem przestępnym");

            Console.ReadKey();

            int wiek = 21;

            if (wiek >= 21)
                Console.WriteLine("Możesz zostać Posłem do Sejmu lub Parlamentu UE");
            else if (wiek >= 30)
                Console.WriteLine("Możesz zostać Senatorem");
            else if (wiek >= 35)
                Console.WriteLine("Możesz zostać Prezydentem");

            Console.ReadKey();

            Console.WriteLine("Podaj swój wzrost w cm:");
            string wzrost = Console.ReadLine();
            int wzrostInt = int.Parse(wzrost);

            if (wzrostInt < 140)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if (wzrostInt >= 140 && wzrostInt < 160)
            {
                Console.WriteLine("Jesteś trochę niski");
            }
            else if (wzrostInt >= 160 && wzrostInt < 170)
            {
                Console.WriteLine("Jesteś niski");
            }
            else if (wzrostInt >= 170 && wzrostInt < 180)
            {
                Console.WriteLine("Jesteś normalnego wzrostu");
            }
            else if (wzrostInt >= 180)
            {
                Console.WriteLine("Jesteś wysoki");
            }

            Console.ReadKey();

            int one = 25;
            int two = 63;
            int three = 79;
            
            if (one > two && one > three)
            {
                Console.WriteLine($"{one} jest najwiekszą z podanych");
            }
            else if (two > one && two > three)
            {
                Console.WriteLine($"{two} jest najwiekszą z podanych");
            }
            else
            {
                Console.WriteLine($"{three} jest najwiekszą z podanych");
            }

            Console.ReadKey();

            int math = 80;
            int fiz = 71;
            int chem = 0;
            int total = math + fiz + chem;
            bool wynik = math + fiz > 150 || math + chem > 150;

            if (math > 70 && fiz > 55 && chem > 45)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (total > 180)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else if (wynik)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }

            Console.ReadKey();

            Console.WriteLine("Podaj aktualną temperaturę:");
            string userValue = Console.ReadLine();

            bool validInteger = int.TryParse(userValue, out int validTemp);

            if (validInteger)
            {
                if (validTemp < 0)
                {
                    Console.WriteLine("cholernie piździ");
                }
                else if (validTemp >= 0 && validTemp < 10)
                {
                    Console.WriteLine("zimno");
                }
                else if (validTemp >= 10 && validTemp < 20)
                {
                    Console.WriteLine("chłodno");
                }
                else if (validTemp >= 20 && validTemp < 30)
                {
                    Console.WriteLine("w sam raz");
                }
                else if (validTemp >= 30 && validTemp < 40)
                {
                    Console.WriteLine("zaczyna być słabo, bo gorąco");
                }
                else if (validTemp >= 40)
                {
                    Console.WriteLine("a weź, wyprowadzam się na Alaskę");
                }
            }
            else
            {
                Console.WriteLine("Niepoprawna temperatura. Zrestartuj program");
            }

        }
    }
}
