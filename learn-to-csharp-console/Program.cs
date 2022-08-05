using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace learn_to_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Фукція main буде використовуватися лише для вибору уроку
            // The main function will only be used to select a lessons

            Lessons_list();


            for (; ; )
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("         Select a number of lessons . . .");
                Console.WriteLine("");
                Console.WriteLine("");

                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Lessons_ziro_one();
                        break;

                    case 2:
                        Lessons_ziro_two();
                        break;

                    case 3:
                        Lessons_ziro_three();
                        break;

                    case 4:
                        Lessons_ziro_four();
                        break;

                    case 5:
                        Lessons_ziro_five();
                        break;

                    case 6:
                        Lessons_ziro_six();
                        break;

                    case 7:
                        Lessons_ziro_seven();
                        break;

                    case 8:
                        Lessons_ziro_eight();
                        break;

                    case 9:
                        Lessons_ziro_nine();
                        break;

                    case 10:
                        Lessons_one_ziro();
                        break;

                    case 11:
                        Lessons_one_one();
                        break;

                    case 12:
                        Lessons_one_two();
                        break;

                    case 13:
                        Lessons_one_three();
                        break;

                    case 14:
                        Lessons_one_four();
                        break;

                    case 15:
                        Lessons_one_five();
                        break;

                    case 16:
                        Lessons_one_six();
                        break;

                    case 17:
                        Lessons_one_seven();
                        break;

                    case 18:
                        Lessons_one_eight();
                        break;

                    case 19:
                        Lessons_one_nine();
                        break;

                    case 20:
                        Lessons_two_ziro();
                        break;

                    case 21:
                        Lessons_two_one();
                        break;

                    case 22:
                        Lessons_two_two();
                        break;

                    case 23:
                        Lessons_two_three();
                        break;

                    case 24:
                        Lessons_two_four();
                        break;

                    case 25:
                        Lessons_two_five();
                        break;

                    case 26:
                        Lessons_two_six();
                        break;

                    case 27:
                        Lessons_two_seven();
                        break;

                    case 29:
                        Lessons_two_nine();
                        break;

                    case 30:
                        Lessons_three_ziro();
                        break;

                    case 31:
                        Lessons_three_one();
                        break;

                    case 32:
                        Lessons_three_two();
                        break;

                    case 33:
                        Lessons_three_three();
                        break;

                    case 34:
                        Lessons_three_four();
                        break;

                    case 35:
                        Lessons_three_five();
                        break;

                    case 36:
                        Lessons_three_six();
                        break;

                    case 37:
                        Lessons_three_seven();
                        break;

                    case 38:
                        Lessons_three_eight();
                        break;

                    default:
                        Console.WriteLine(" This number of lessoons is undefanded");
                        break;
                }
            }
        }

        static void Lessons_list()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("     Now to the learning . . .");
            Console.WriteLine("");

            string data = "     {0} |\t {1}";

            Console.WriteLine(string.Format(data, "01", "First program"));
            Console.WriteLine(string.Format(data, "02", "Structure of project. Structure and order of program execution"));
            Console.WriteLine(string.Format(data, "03", "Types of data"));
            Console.WriteLine(string.Format(data, "04", "Declaration and initialization of variables. Variable assigment"));
            Console.WriteLine(string.Format(data, "05", "Input data to coonsole"));
            Console.WriteLine(string.Format(data, "06", "Convert string to number"));
            Console.WriteLine(string.Format(data, "07", "Parse string. Tryparse string"));
            Console.WriteLine(string.Format(data, "08", "Arifmetic operation with numbers"));
            Console.WriteLine(string.Format(data, "09", "Prioritae of arifmetic operation"));
            Console.WriteLine(string.Format(data, "10", "Few project in one solution"));
            Console.WriteLine(string.Format(data, "11", "Increase and decrement. Fostfixes and prefixed"));
            Console.WriteLine(string.Format(data, "12", "Comparison operationsn"));
            Console.WriteLine(string.Format(data, "13", "If else"));
            Console.WriteLine(string.Format(data, "14", "Logic operator"));
            Console.WriteLine(string.Format(data, "15", "Switch case"));
            Console.WriteLine(string.Format(data, "16", "While"));
            Console.WriteLine(string.Format(data, "17", "Do while"));
            Console.WriteLine(string.Format(data, "18", "For"));
            Console.WriteLine(string.Format(data, "19", "For"));
            Console.WriteLine(string.Format(data, "20", "Break"));
            Console.WriteLine(string.Format(data, "21", "Continue"));
            Console.WriteLine(string.Format(data, "22", "For in for"));
            Console.WriteLine(string.Format(data, "23", "Ternar operaator"));
            Console.WriteLine(string.Format(data, "24", "Standart array"));
            Console.WriteLine(string.Format(data, "25", "Inicial to array"));
            Console.WriteLine(string.Format(data, "26", "Outpoot to array"));
            Console.WriteLine(string.Format(data, "27", "Few metods for array"));
            Console.WriteLine(string.Format(data, "29", "Matrix"));
            Console.WriteLine(string.Format(data, "30", "Matrix random"));
            Console.WriteLine(string.Format(data, "31", "Outpoot matrix"));
            Console.WriteLine(string.Format(data, "32", "Entering matrix"));
            Console.WriteLine(string.Format(data, "33", "Step (gear) array"));
            Console.WriteLine(string.Format(data, "34", "Multydimensions array"));
            Console.WriteLine(string.Format(data, "35", "Metods, functions"));
            Console.WriteLine(string.Format(data, "36", "Method overload"));
            Console.WriteLine(string.Format(data, "37", "Area of ​​visibility / Context"));
            Console.WriteLine(string.Format(data, "38", "Link and value types"));
        }

        static void Lessons_ziro_one()
        {
            Console.WriteLine(" Did select lessons 01: First program");
            Console.WriteLine("");
            // Звичайний "Привіт, Світ!"
            // The standart @Hello, World!"

            Console.WriteLine("Hello, World!");
        }

        static void Lessons_ziro_two()
        {
            Console.WriteLine(" Did select lessons 02: Structure of project. Structure and order of program execution");
            Console.WriteLine("");
            // Тут коду нема
            // No code
        }

        static void Lessons_ziro_three()
        {
            Console.WriteLine(" Did select lessons 03: Types of data");
            Console.WriteLine("");
            // Розрисані детально усі базові типи даних мови
            // Base list a types of data

            string data = "Type {0,8} |\t.NET {1,8} |\tSize = {2} \t| MIN = {3,30}\t| MAX = {4}";

            Console.WriteLine("     Types of data to C#:");
            Console.WriteLine("");
            Console.WriteLine("             Integer");
            Console.WriteLine("");
            Console.WriteLine(string.Format(data, "byte", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue));
            Console.WriteLine(string.Format(data, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(string.Format(data, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(string.Format(data, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(string.Format(data, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(string.Format(data, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(string.Format(data, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(string.Format(data, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));
            Console.WriteLine("");
            Console.WriteLine("             Float point");
            Console.WriteLine("");
            Console.WriteLine(string.Format(data, "float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));
            Console.WriteLine(string.Format(data, "double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));
            Console.WriteLine(string.Format(data, "decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));
            Console.WriteLine("");
            Console.WriteLine("             Symbol");
            Console.WriteLine("");
            Console.WriteLine(string.Format(data, "char", typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue));
            Console.WriteLine(string.Format(data, "string", typeof(string).Name, "N/A", "N/A", "N/A"));
            Console.WriteLine("");
            Console.WriteLine("             Logic");
            Console.WriteLine("");
            Console.WriteLine(string.Format(data, "bool", typeof(bool).Name, sizeof(bool), "False", "True"));
            Console.WriteLine("");
            Console.WriteLine("             Special");
            Console.WriteLine("");
            Console.WriteLine(string.Format(data, "object", typeof(object).Name, "N/A", "N/A", "N/A"));
            Console.WriteLine(string.Format(data, "dynamic", "N/A", "N/A", "N/A", "N/A"));
        }

        static void Lessons_ziro_four()
        {
            Console.WriteLine(" Did select lessons 04:  Declaration and initialization of variables. Variable assigment");
            Console.WriteLine("");
            // Створення та робота зі змінними
            // Create and work about variables

            string var;

            Console.WriteLine("Press first variable to value var");
            var = Console.ReadLine();
            Console.WriteLine("Value var = " + var);

            Console.WriteLine("Press second variable to value var");
            var = Console.ReadLine();
            Console.WriteLine("Value var = " + var);
        }

        static void Lessons_ziro_five()
        {
            Console.WriteLine(" Did select lessons 05:  Input data to coonsole");
            Console.WriteLine("");
            // Console.ReadLine()

            string name;

            Console.WriteLine("Press to Your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }

        static void Lessons_ziro_six()
        {
            Console.WriteLine(" Did select lessons 06:  Convert string to number");
            Console.WriteLine("");
            //  When entering data into the console, we have a string. What to do?
            //  При введенні даних у консоль маємо рядок. Що робити?

            Console.WriteLine("Press first variable");
            string val1 = Console.ReadLine();

            Console.WriteLine("Press second variable");
            string val2 = Console.ReadLine();

            string result = val1 + val2;

            Console.WriteLine("Result of !concatination string! val1 and val2 ("
                + val1 + " + " + val2 + ") = " + result);

            int summ = Convert.ToInt32(val1) + Convert.ToInt32(val2);

            Console.WriteLine("Result of summ !convert string to int! val1 and val2 ("
                + val1 + " + " + val2 + ") = " + summ);


            // Convert float point number with " , " ot " . "

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            string float_string = "1.52";
            double float_number = Convert.ToDouble(float_string, numberFormatInfo);
            Console.WriteLine(float_number);
        }

        static void Lessons_ziro_seven()
        {
            Console.WriteLine(" Did select lessons 07:  Parse string. Tryparse string");
            Console.WriteLine("");
            //  A few more methods for convert type to type
            //  Ще декілька методів конвертування типу в тип

            string val = "5";
            int num = int.Parse(val); // only for string val



            val = "1jhghfg";
            try
            {
                num = int.Parse(val);
                Console.WriteLine("Convert completed");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }

            bool result = int.TryParse(val, out num);
            Console.WriteLine(num);
            if (result) Console.WriteLine("Convert completed"); else Console.WriteLine("Error");
        }

        static void Lessons_ziro_eight()
        {
            Console.WriteLine(" Did select lessons 08:  Arifmetic operation with numbers");
            Console.WriteLine("");

            //  Write a program that calculates the average of two numbers
            //  Напишіть програму, що обраховує середнє арифметичне двох чисел

            Console.WriteLine(" Entering first number");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Entering second number");
            double num2 = double.Parse(Console.ReadLine());

            double result = (num1 + num2) / 2;
            Console.WriteLine(" Avareg for num1 and num2 = " + result);
            Console.WriteLine("");

            //  Entering 3 numbers and outpoot result of summ and multiplying 
            //  Введіть 3 числа та виведіть на екран значення їх суми та множення.

            Console.WriteLine(" Entering second number");
            double num3 = double.Parse(Console.ReadLine());

            result = num1 + num2 + num3;
            Console.WriteLine(" Result to summ for num1 and num2 and num3 = " + result);

            result = num1 * num2 * num3;
            Console.WriteLine(" Result to multiplying for num1 and num2 and num3 = " + result);
            Console.WriteLine("");

            //  Convert dol by uah
            Console.WriteLine(" Entering your dollars");
            result = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine(" It is " + result + " Ukraine Hryvna . . .");
        }

        static void Lessons_ziro_nine()
        {
            Console.WriteLine(" Did select lessons 09:  Prioritae of arifmetic operation");
            Console.WriteLine("");

            //  No code
        }

        static void Lessons_one_ziro()
        {
            Console.WriteLine(" Did select lessons 10:  Few project in one solution");
            Console.WriteLine("");

            //  No code
        }

        static void Lessons_one_one()
        {
            Console.WriteLine(" Did select lessons 11:  Increase and decrement. Fostfixes and prefixed");
            Console.WriteLine("");

            int a = 0;

            Console.WriteLine(a++);

            a--;

            Console.WriteLine(++a);
        }

        static void Lessons_one_two()
        {
            Console.WriteLine(" Did select lessons 12:  Comparison operationsn");
            Console.WriteLine("");

            //  No code
        }

        static void Lessons_one_three()
        {
            Console.WriteLine(" Did select lessons 13:  If else");
            Console.WriteLine("");

            //  Multiplicity check

            for (; ; )
            {
                Console.WriteLine("Entering to integer for multiplicity check");
                int integer = int.Parse(Console.ReadLine());

                if ((integer % 2) == 0) Console.WriteLine("True");
                else Console.WriteLine("False");
            }
        }

        static void Lessons_one_four()
        {
            Console.WriteLine(" Did select lessons 14:  Logic operator");
            Console.WriteLine("");

            //  No code
        }

        static void Lessons_one_five()
        {
            Console.WriteLine(" Did select lessons 15:  Switch case");
            Console.WriteLine("");

            //  Calculator

            Console.WriteLine(" Select to variant of realisation:");
            Console.WriteLine("     1 - if");
            Console.WriteLine("     2 - switch");

            int realisation = int.Parse(Console.ReadLine());

            double num1;
            string oper;
            double num2;

            double result = 0;

            if (realisation == 1)
            {
                Console.WriteLine("Entering first number");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Entering operation");
                oper = Console.ReadLine();

                Console.WriteLine("Entering second number");
                num2 = double.Parse(Console.ReadLine());


                if (oper == "/")
                    result = num1 / num2;

                else if (oper == "*")
                    result = num1 * num2;

                else if (oper == "-")
                    result = num1 - num2;

                else if (oper == "+")
                    result = num1 + num2;

                else Lessons_one_five();
            }

            else if (realisation == 2)
            {
                Console.WriteLine("Entering first number");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Entering operation");
                oper = Console.ReadLine();

                Console.WriteLine("Entering second number");
                num2 = double.Parse(Console.ReadLine());

                switch (oper)
                {
                    case "/":
                        result = num1 / num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "+":
                        result = num1 + num2;
                        break;

                    default:
                        Lessons_one_five();
                        break;
                }
            }

            else Lessons_one_five();

            Console.WriteLine("Result of Your operation = " + result);
        }

        static void Lessons_one_six()
        {
            Console.WriteLine(" Did select lessons 16:  While");
            Console.WriteLine("");

            // Number of even / odd
            // Кількість парних / непарних

            Console.WriteLine("Entering integer > 0");
            int integer = int.Parse(Console.ReadLine());

            int count = 0;
            int even = 0;
            int odd = 0;


            while (count <= integer)
            {
                if (count % 2 == 0)
                    even++;
                else odd++;
                count++;
            }

            Console.WriteLine("even - " + even);
            Console.WriteLine("odd - " + odd);
        }

        static void Lessons_one_seven()
        {
            Console.WriteLine(" Did select lessons 17:  Do while");
            Console.WriteLine("");

            int count = 0;

            do
            {
                count++;
                Console.WriteLine(count);
            } while (count < 5);
        }

        static void Lessons_one_eight()
        {
            Console.WriteLine(" Did select lessons 18:  For");
            Console.WriteLine("");

            //  No code
        }

        static void Lessons_one_nine()
        {
            Console.WriteLine(" Did select lessons 19:  For");
            Console.WriteLine("");

            //  No code
        }

        static void Lessons_two_ziro()
        {
            Console.WriteLine(" Did select lessons 20:  Break");
            Console.WriteLine("");

            Console.WriteLine("For exit entering exit");

            for (int i = 0; ; i++)
            {
                string val = Console.ReadLine();
                if (val == "exit") break;
                Console.WriteLine("Eteration " + i);
            }
        }

        static void Lessons_two_one()
        {
            Console.WriteLine(" Did select lessons 21:  Continue");
            Console.WriteLine("");

            Console.WriteLine("For continue entering continue");

            for (int i = 0; ; i++)
            {
                string val = Console.ReadLine();
                if (val == "continue") continue;
                Console.WriteLine("Eteration " + i);
            }
        }

        static void Lessons_two_two()
        {
            Console.WriteLine(" Did select lessons 22:  For in for");
            Console.WriteLine("");

            Console.WriteLine("Entering size");
            int count = int.Parse(Console.ReadLine());

            string val = "#";
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(val);
                }
            }

            Console.WriteLine("");

            for (int i = count; i >= 0; i--)
            {
                Console.WriteLine("");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(val);
                }
            }

            for (int i = count; i >= 0; i--)
            {
                Console.WriteLine("");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < count - i; k++)
                {
                    Console.Write(val);
                }
            }

            Console.WriteLine("");

            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < count - i; k++)
                {
                    Console.Write(val);
                }
            }
        }

        static void Lessons_two_three()
        {
            Console.WriteLine(" Did select lessons 23:  Ternar operaator");
            Console.WriteLine("");

            Console.WriteLine("Entering password");
            string pass = Console.ReadLine();
            string true_pass = "password";

            bool key = true_pass == pass ? true : false;

            Console.WriteLine(key);
        }

        static void Lessons_two_four()
        {
            Console.WriteLine(" Did select lessons 24:  Standart array");
            Console.WriteLine("");

            // No code
        }

        static void Lessons_two_five()
        {
            Console.WriteLine(" Did select lessons 25:  Inicial to array");
            Console.WriteLine("");

            // No code
        }

        static void Lessons_two_six()
        {
            Console.WriteLine(" Did select lessons 26:  Outpoot to array");
            Console.WriteLine("");

            // Input by user to data for array 

            Console.WriteLine("Entering size for array");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("");
            Console.WriteLine("Entering elements for array");
            for (int i = 0; i < size; i++)
                array[i] = int.Parse(Console.ReadLine());

            // Outpooot revers arrray

            Console.WriteLine("");
            for (int i = 0; i < size; i++)
                Console.Write(" " + array[size - i - 1]);

            // Summ ever

            Console.WriteLine("");
            int summ_ever = 0;
            for (int i = 0; i < size; i++)
                summ_ever = (array[i] % 2 == 0) ? summ_ever += array[i] : summ_ever;
            Console.WriteLine(summ_ever);

            // min val to array

            Console.WriteLine("");
            int min = array[0];
            for (int i = 1; i < size; i++)
                min = (array[i] < min) ? array[i] : min;
            Console.WriteLine(min);
        }

        static void Lessons_two_seven()
        {
            Console.WriteLine(" Did select lessons 27:  Few metods for array");
            Console.WriteLine("");

            Console.WriteLine("Entering size for array");
            int size = int.Parse(Console.ReadLine());

            int[] array = new int[size];

            Console.WriteLine("");
            Console.WriteLine("Entering elements for array");
            for (int i = 0; i < size; i++)
                array[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Where(i => i % 2 == 0).Sum());
            Console.WriteLine(array.Where(i => i % 2 == 1).Max());
            int[] arr_incl = array.Distinct().ToArray();
            int[] arr_sort = array.OrderBy(i => i).ToArray();
            Console.WriteLine(Array.Find(array, i => i < 10));
            Console.WriteLine(array.Where(i => i < 0).FirstOrDefault());
            Console.WriteLine(Array.FindIndex(array, i => i == 10));
        }

        static void Lessons_two_nine()
        {
            Console.WriteLine(" Did select lessons 29:  Matrix");
            Console.WriteLine("");

            Console.WriteLine("Entering hight for matrix");
            int hight = int.Parse(Console.ReadLine());

            Console.WriteLine("Entering length for matrix");
            int length = int.Parse(Console.ReadLine());

            // hight = matrix.GetLength(0);
            // length = matrix.GetLength(1);

            int[,] matrix = new int[hight, length];

            Console.WriteLine("");
            Console.WriteLine("Entering elements for matrix");
            for (int i = 0; i < hight; i++)
                for (int j = 0; j < length; j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < hight; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < length; j++)
                    Console.Write(" " + matrix[i, j]);
            }
        }

        static void Lessons_three_ziro()
        {
            Console.WriteLine(" Did select lessons 30:  Matrix random");
            Console.WriteLine("");

        }

        static void Lessons_three_one()
        {
            Console.WriteLine(" Did select lessons 31:  Outpoot matrix");
            Console.WriteLine("");

            Console.WriteLine("Entering hight for matrix");
            int hight = int.Parse(Console.ReadLine());

            Console.WriteLine("Entering length for matrix");
            int length = int.Parse(Console.ReadLine());

            // hight = matrix.GetLength(0);
            // length = matrix.GetLength(1);

            int[,] matrix = new int[hight, length];

            Console.WriteLine("");
            Console.WriteLine("Entering elements for matrix");
            for (int i = 0; i < hight; i++)
                for (int j = 0; j < length; j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < hight; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < length; j++)
                    Console.Write(" " + matrix[i, j]);
            }
        }

        static void Lessons_three_two()
        {
            Console.WriteLine(" Did select lessons 32:  Entering matrix");
            Console.WriteLine("");

            Console.WriteLine("Entering hight for matrix");
            int hight = int.Parse(Console.ReadLine());

            Console.WriteLine("Entering length for matrix");
            int length = int.Parse(Console.ReadLine());

            // int hight = matrix.GetLength(0);
            // int length = matrix.GetLength(1);

            int[,] matrix = new int[hight, length];

            Console.WriteLine("");
            Console.WriteLine("Entering elements for matrix");
            for (int i = 0; i < hight; i++)
                for (int j = 0; j < length; j++)
                    matrix[i, j] = int.Parse(Console.ReadLine());

            for (int i = 0; i < hight; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < length; j++)
                    Console.Write(" " + matrix[i, j]);
            }
        }

        static void Lessons_three_three()
        {
            Console.WriteLine(" Did select lessons 33:  Step (gear) array");
            Console.WriteLine("");

            Random rand = new Random();
            int[][] GArray = new int[3][];
            int[,] matrix = new int[3, 5];

            int ArrayRank = GArray.Rank;
            int matrixRank = matrix.Rank;
            Console.WriteLine(ArrayRank);
            Console.WriteLine(matrixRank);

            int ArrayLength = GArray.Length;
            int matrixLength = matrix.Length;
            Console.WriteLine(ArrayLength);
            Console.WriteLine(matrixLength);
            Console.WriteLine();


            for (int i = 0; i < GArray.Length; i++)
                GArray[i] = new int[rand.Next(10)];

            for (int i = 0; i < GArray.Length; i++)
                for (int j = 0; j < GArray[i].Length; j++)
                    GArray[i][j] = rand.Next(10);

            for (int i = 0; i < GArray.Length; i++)
            {
                for (int j = 0; j < GArray[i].Length; j++)
                    Console.Write(GArray[i][j] + "\t");
                Console.WriteLine();
            }

        }

        static void Lessons_three_four()
        {
            Console.WriteLine(" Did select lessons 34:  Multydimensions array");
            Console.WriteLine("");


            Random rand = new Random();

            int matrixDepth = rand.Next(2, 10);
            int matrixLength = rand.Next(2, 10);
            int matrixHight = rand.Next(2, 10);

            Console.WriteLine(matrixDepth);
            Console.WriteLine(matrixLength);
            Console.WriteLine(matrixHight);

            int[,,] matrix = new int[matrixDepth, matrixLength, matrixHight];

            for (int i = 0; i < matrixDepth; i++)
                for (int j = 0; j < matrixLength; j++)
                    for (int k = 0; k < matrixHight; k++)
                        matrix[i, j, k] = rand.Next(10);

            for (int i = 0; i < matrixDepth; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int j = 0; j < matrixLength; j++)
                {
                    for (int k = 0; k < matrixHight; k++)
                        Console.Write(matrix[i, j, k] + "  ");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            int arrayDepth = rand.Next(2, 10);
            Console.WriteLine(arrayDepth);
            int[][][] array = new int[arrayDepth][][];

            for (int i = 0; i < arrayDepth; i++)
            {
                array[i] = new int[rand.Next(2, 10)][];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = new int[rand.Next(2, 10)];
                    for (int k = 0; k < array[i][j].Length; k++)
                        array[i][j][k] = rand.Next(10);
                }
            }

            for (int i = 0; i < arrayDepth; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int j = 0; j < array[i].Length; j++)
                {
                    for (int k = 0; k < array[i][j].Length; k++)
                        Console.Write(array[i][j][k] + "  ");
                    Console.WriteLine();
                }
            }
        }

        static void Lessons_three_five()
        {
            Console.WriteLine(" Did select lessons 35:  Metods, functions");
            Console.WriteLine("");
            Console.WriteLine("1. Created metod for visualisation simbols (simb) specified number of times (N)");
            Console.WriteLine("2. Created metod for first finded index element (simbols) to masive");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Entering to simb");
            char simb = char.Parse(Console.ReadLine());
            Console.WriteLine("Entering to N");
            int N = int.Parse(Console.ReadLine());

            repeat_simbol(simb, N);

            Console.WriteLine("");
            Console.WriteLine("");

            string str = "";
            string val = "";
            Console.WriteLine("Entering to new ONE simbol");
            while (val.Length < 2)
            {
                val = Console.ReadLine();
                if (val.Length > 1) break;
                str += val;
                Console.WriteLine("For exit to inpoot entering 2+ simbols");
            }
            char[] simbols = str.ToCharArray();

            int index = finded_first(simbols);
            if (index != -1) Console.WriteLine("Index first finded simblos - " + index);
            else Console.WriteLine("Error");

        }
        static void repeat_simbol(char simb, int N)
        {
            char[] array = new char[N];
            for (int i = 0; i < N; i++)
                array[i] = simb;
            for (int i = 0; i < N; i++)
                Console.Write(simb + " ");
        }
        static int finded_first(char[] simbols)
        {
            Console.WriteLine("Entering simbol for find");
            char val = char.Parse(Console.ReadLine());
            for (int i = 0; i < simbols.Length; i++)
                if (simbols[i] == val)
                    return i;

            return -1;
        }

        static void Lessons_three_six()
        {
            Console.WriteLine(" Did select lessons 36:  Method overload");
            Console.WriteLine("");
            int a = 1;
            int b = 2;
            int c = 3;
            double d = 1.2;
            double e = 1.3;
            int ab = Sum(a, b);
            int abc = Sum(a, b, c);
            double de = Sum(d, e);
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return (a + b) + c;
        }
        static double Sum(double a, double b)
        {
            return a + b;
        }

        static void Lessons_three_seven()
        {
            Console.WriteLine(" Did select lessons 37:  Area of ​​visibility / Context");
            Console.WriteLine("");
        }

        static void Lessons_three_eight()
        {
            Console.WriteLine(" Did select lessons 38:  Link and value types");
            Console.WriteLine("");
        }
    }
}