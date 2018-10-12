using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex3
{
    /*
     * инкапсулировать поля класса в независимом классе и в нем реализовать методы Init(), Display(), toString(); 
     * в основном классе должно быть одно поле данных, представленное объектом-структурой.
     
     Комплексное число представляется парой действительных чисел (a, b), где а – действительная часть, b – мнимая часть. Реализовать класс Complex для работы с комплексными числами. Обязательно должны присутствовать операции:
    - сложения add, (a, b) + (c, d) = (a + с, b + d);
    - вычитания sub, (a, b) – (c, d) = (a – c, b - d);
    - умножения mul, (a, b) * (c, d) = (ac – bd, ad + bc);
    - деления div, (a, b) / (c, d) = (ac + bd, bc - ad) / (c2 + d2);
    - сравнение equ, (a, b) = (c, d), если (a = c) и (b = d);
    - сопряженное число conj, conj(a, b) = (a, -b)
     */
    class Complex
    {
        private double a, b;
        public double NumA
        {
            get { return a; }
        }
        public double NumB
        {
            get { return b; }
        }

        public void Init()
        {
            Console.Write("Put in a real part : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Put in an imaginary part : ");
            b = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Your complex number is {0}+{1}i", a, b);
        }
        public string ToString(double realPart, double imaginaryPart)
        {
            string rslt = Convert.ToString(realPart) + "+" + Convert.ToString(imaginaryPart) + "i";
            return rslt;
        }
    }
    class ComplexOperations
    {

        Complex num = new Complex();
        public Complex Num
        {
            set { num = value; }
         }
        
        public string Sum()
        {
            Complex num2 = new Complex();
            num2.Init();
            double realPart = num.NumA + num2.NumA;
            double imaginaryPart = num.NumB + num2.NumB;
            string rslt = "Sum is = " + num.ToString(realPart, imaginaryPart);
            return rslt;
        }
        public string Mul()
        {
            Complex num2 = new Complex();
            num2.Init();
            double realPart = (num.NumA * num2.NumA) - (num.NumB * num2.NumB);
            double imaginaryPart = num.NumA * num2.NumB + num.NumB * num2.NumA;
            string rslt = "Mul is = " + num.ToString(realPart, imaginaryPart);
            return rslt;
        }
        public string Sub()
        {
            Complex num2 = new Complex();
            num2.Init();
            double realPart = num.NumA -  num2.NumA;
            double imaginaryPart = num.NumB - num2.NumB;
            string rslt = "Sub is = " + num.ToString(realPart, imaginaryPart);
            return rslt;
        }
        public string Div()
        {
            Complex num2 = new Complex();
            num2.Init();
            double realPart = (num.NumA * num2.NumA + num.NumB * num2.NumB) / (num2.NumA * num2.NumA + num2.NumA * num2.NumA);
            double imaginaryPart = (num.NumB * num2.NumA - num.NumA * num2.NumB) / (num2.NumA * num2.NumA + num2.NumB * num2.NumA);
            string rslt = "Div is = " + num.ToString(realPart, imaginaryPart);
            return rslt;
        }
        public string Equ()
        {
            Complex num2 = new Complex();
            num2.Init();
            return (num.NumA == num2.NumA && num.NumB == num2.NumB) ? "They are equal" : "They are not equal";
        }
        public string Conj()
        {
            Complex num2 = new Complex();
            num2.Init();
            return (num.NumA == num2.NumA && num.NumB == -num2.NumB) ? "They are conjugate" : "They are not conjugate";
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Complex complexNum = new Complex();
            complexNum.Init();
            ComplexOperations n = new ComplexOperations();
            n.Num = complexNum;
            while (true)
            {
                Console.Write("What do you want to do next? You have a variables options: sum, sub, mul, div, equ, conj, exit. ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "sum":
                        Console.WriteLine(n.Sum());
                        break;
                    case "sub":
                        Console.WriteLine(n.Sub());
                        break;
                    case "div":
                        Console.WriteLine(n.Div());
                        break;
                    case "mul":
                        Console.WriteLine(n.Mul());
                        break;
                    case "equ":
                        Console.WriteLine(n.Equ());
                        break;
                    case "conj":
                        Console.WriteLine(n.Conj());
                        break;
                }
                if (answer == "exit")
                    break;
            }

        } 
    }
}

