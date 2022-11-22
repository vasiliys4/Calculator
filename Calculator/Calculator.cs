using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        Data Data = new();
        public double Validation1()
        {
            double result1 = -1;
            var number1 = "";

            while (result1 <= 0)
            {
                if (double.TryParse(number1, out result1) )
                {
                    return result1;
                }
                else
                {
                    number1 = Read1();
                }
            }
            return result1;
        }

        public double Validation2()
        {
            double result2 = -1;
            var number2 = "";

            while (result2 <= 0)
            {
                if (double.TryParse(number2, out result2) )
                {
                    return result2;
                }
                else
                {
                    number2 = Read2();
                }
            }
            return result2;
        }

        string Read1()
        {            
            Console.WriteLine("Введите первое число: ");
            var Number1 = Console.ReadLine();
            return Number1;
        }
        string Read2()
        {
            Console.WriteLine("Введите второе число");
            var Number2 = Console.ReadLine();
            return Number2;
        }

        string ReadKey()
        {
            Console.WriteLine("Введите арифмитический знак который хотите применить:\nпосчитать сумму: '+'\nпосчитать разность: '-'\nпосчитать умножение: '*'\nпосчитать деление: '/'\nпосчитать степень: '^'\n закрыть калькулятор: 'exit'");
            Data.Key = Console.ReadLine();
            return Data.Key;
        }

        string validator()
        {
            var tmp = true;
            while (tmp) 
            {
                ReadKey();
                if (Data.Key == "+")
                {
                    tmp = false;                   
                }
                else if (Data.Key == "-")
                {
                    tmp = false;

                }
                else if (Data.Key == "*")
                {
                    tmp = false;
                }
                else if (Data.Key == "/")
                {
                    tmp = false;
                }
                else if (Data.Key == "^")
                {
                    tmp = false;
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильно");
                }
            }
            return Data.Key;
        }

        private void Plus(double Number1, double Number2)
        {
            Data.Result = Number1 + Number2;
            Console.WriteLine($"Результат:\n{Number1} + {Number2} = {Data.Result}");
        }

        private void Minus(double Number1, double Number2)
        {
            Data.Result = Number1 - Number2;
            Console.WriteLine($"Результат:\n{Number1} + {Number2} = {Data.Result}");
        }

        private void Multiplication(double Number1, double Number2)
        {
            Data.Result = Number1 * Number2;
            Console.WriteLine($"Результат:\n {Number1}  +  {Number2}  = {Data.Result}");
        }

        private void Division(double Number1, double Number2)
        {
            var tmp = true;
            while (tmp) {
                if (Number2 != 0)
                {
                    Data.Result = Number1 / Number2;
                    Console.WriteLine($"Результат:\n {Number1}  +  {Number2}  = {Data.Result}");
                    tmp = false;
                }
                else
                {
                    tmp = true;
                    calculate();
                }
            }
        }

        private void Degree(double Number1, double Number2)
        {
            double peremen = 1.0;
            for (int i = 0; i < Number2; i++)
            {
                peremen = peremen * Number1;
                Data.Result = peremen;
            }
            Console.WriteLine($"Результат:\n {Number1}  ^  {Number2}  = {Data.Result}");
        }

        public void calculate()
        {
            var tmp = true;
            while (tmp)
            {
                //var w = Validation1();
                validator();
                var w = Validation1();
                var e = Validation2();
                switch (Data.Key)
                {
                    case "+":
                        Plus(w, e);
                        Console.WriteLine("");
                        break;
                    case "-":
                        Minus(w ,e);
                        Console.WriteLine("");
                        break;
                    case "*":
                        Multiplication(w, e);
                        Console.WriteLine("");
                        break;
                    case "/":
                        Division(w, e);
                        Console.WriteLine("");
                        break;
                    case "^":
                        Degree(w, e);
                        Console.WriteLine("");
                        break;
                    case "exit":
                        tmp = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
