using System;

namespace HomeWork_
{
    class Program
    {
           //1
            /*Console.WriteLine("1  2  3");*/

            //2
            /*Console.WriteLine("5");
            Console.WriteLine("10");
            Console.WriteLine("21");*/

            //3
            /*Console.WriteLine("Введите расстояние в сантиметрах: ");
            double centimeter = Convert.ToInt32(Console.ReadLine());
            double meter = centimeter / 100;
            Console.WriteLine("В метрах: ");
            Console.WriteLine(meter);*/

            //4
            /*int day = 234;
            Console.WriteLine(day / 7);*/

            //5
            /*int twoDigitNumber = 66;
            Console.WriteLine("Число десятков: {0}",twoDigitNumber / 10);
            Console.WriteLine("Число единиц: {0}", twoDigitNumber % 10);
            Console.WriteLine("Сумма его цифр: {0}", twoDigitNumber / 10 + twoDigitNumber % 10);
            Console.WriteLine("Произведение его цифр: {0}", (twoDigitNumber / 10) * (twoDigitNumber % 10));*/
            //6
		
	    /*bool A = true;
            bool B = false;
            bool C = false;

            bool result1 = A || B;
            bool result2 = A && B;
            bool result3 = B || C;

            Console.WriteLine("A || B = " + result1);
            Console.WriteLine("A && B = " + result2);
            Console.WriteLine("B || C = " + result3);*/

            //7
            /*Console.WriteLine("Введите радиус круга: ");
            double radiusCircle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны квадраты: ");
            double sideOfSquare = Convert.ToInt32(Console.ReadLine());
            double Pi = 3.1415;
            double squareArea = sideOfSquare * sideOfSquare;    
            double areaOfCircle = Pi * (radiusCircle * radiusCircle);

            if(squareArea > areaOfCircle)
            {
                Console.WriteLine("Площадь квадрата больше");
            }else if(squareArea < areaOfCircle)
            {
                Console.WriteLine("Площадь круга больше");
            }else
            {
                Console.WriteLine("Площадь равны");
            }*/
            //8
            static double Density(double mass, double volume)
        {
            return mass / volume;
        }

        static void Main(string[] args)
        {
            double volume1, mass1, volume2, mass2;

            Console.WriteLine("У какого материала бОльшая плотность?\n");

            Console.WriteLine("Материал 1");
            Console.Write("Объем: ");
            volume1 = Double.Parse(Console.ReadLine());
            Console.Write("Масса: ");
            mass1 = Double.Parse(Console.ReadLine());

            double density1 = Density(mass1, volume1);
            Console.WriteLine("Плотность: " + density1);

            Console.WriteLine("\nМатериал 2");
            Console.Write("Объем: ");
            volume2 = Double.Parse(Console.ReadLine());
            Console.Write("Масса: ");
            mass2 = Double.Parse(Console.ReadLine());

            double density2 = Density(mass2, volume2);
            Console.WriteLine("Плотность: " + density2);

            string answer = density1 > density2 ? "первого" : "второго";
            Console.WriteLine("\nНаибольшая плотность у {0} материала", answer);
        }
        //9
        static double Current(double resistance, double voltage)
        {
            return voltage / resistance;
        }

        static void Main(string[] args)
        {
            double resistance1, voltage1, resistance2, voltage2;

            Console.WriteLine("По какому участку цепи проходит меньший ток?\n");

            Console.WriteLine("Участок 1");
            Console.Write("Сопротивление: ");
            resistance1 = Double.Parse(Console.ReadLine());
            Console.Write("Напряжение: ");
            voltage1 = Double.Parse(Console.ReadLine());

            double elCurrent1 = Current(resistance1, voltage1);
            Console.WriteLine("Ток: " + elCurrent1);

            Console.WriteLine("\nУчасток 2");
            Console.Write("Сопротивление: ");
            resistance2 = Double.Parse(Console.ReadLine());
            Console.Write("Напряжение: ");
            voltage2 = Double.Parse(Console.ReadLine());

            double elCurrent2 = Current(resistance2, voltage2);
            Console.WriteLine("Ток: " + elCurrent2);

            string answer = elCurrent1 < elCurrent2 ? "первому" : "второму";
            Console.WriteLine("\nМеньший ток проходит по {0} участку цепи", answer);
        }
        //10
        /*
            static void Menu()
                {
                    Console.Clear();
                    Console.WriteLine("1 целые числа от 20 до 25");
                    Console.WriteLine("2 квадраты всех целых чисел от 10 до b");
                    Console.WriteLine("3 третьи степени всех целых чисел от a до 50");
                    Console.WriteLine("4 все целые числа от a до b");
                    Console.WriteLine("\n0 выход");
                }

                static void Main(string[] args)
                {
                    string menu = "#";

                    while(menu != "0")
                    {
                        Menu();
                        Console.Write("Выберите действие: ");
                        menu = Console.ReadLine();

                    Console.Clear();
                    if(menu == "1")
                    {
                        for(int i = 20; i < 25; i++)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadLine();
                    }
                    else if(menu == "2")
                    {
                        Console.Write("Верхняя граница(b>10): ");
                        int number = Int32.Parse(Console.ReadLine());

                        number = number < 10 ? 20 : number;

                        for(int i = 10; i < number; i++)
                        {
                            Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
                        }
                        Console.ReadLine();
                    }
                    else if(menu == "3")
                    {
                        Console.Write("Нижняя граница(a<50): ");
                        int number = Int32.Parse(Console.ReadLine());

                        number = number > 50 ? 40 : number;

                        for (int i = number; i < 50; i++)
                        {
                            Console.WriteLine(i + "^3 = " + Math.Pow(i, 2));
                        }
                        Console.ReadLine();
                    }
                    else if(menu == "4")
                    {
                        Console.Write("Нижняя граница: ");
                        int numberA = Int32.Parse(Console.ReadLine());
                        Console.Write("Верхняя граница: ");
                        int numberB = Int32.Parse(Console.ReadLine());

                        if (numberA > numberB)
                        {
                            int tmp = numberB;
                            numberB = numberA;
                            numberA = tmp;
                        }

                        for(;numberA < numberB; numberA++)
                        {
                            Console.WriteLine(numberA);
                        }
                        Console.ReadLine();
                    }
                }
            */
    }
}
