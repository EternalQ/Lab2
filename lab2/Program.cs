using System;
using System.Linq;
using System.Text;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.types
            //a Примитивы
            byte byte1 = 255;
            sbyte byte2 = -128;
            short short1 = -100;
            ushort short2 = 100;
            int intg = -123;
            uint uintg = 123;
            long long1 = -150;
            ulong long2 = 150;
            float float1 = 2.45f;
            double double1 = 4.675431;
            decimal decimal1 = 3.4324m;
            char char1 = 'A';
            object obj = 33;
            bool bool1 = true;
            Console.WriteLine($"bool: {bool1}" +
                $"\nbyte and sbyte: {byte1},{byte2} " +
                $"\nshort and ushort: {short1},{short2} " +
                $"\nint and uint: {intg},{uintg} " +
                $"\nlong and ulong: {long1},{long2} " +
                $"\nfloat:{float1} " +
                $"\ndouble: {double1} " +
                $"\ndecimal: {decimal1}" +
                $"\nchar: {char1} " +
                $"\nobject: {obj}\n");

            //b Неявные преобразования
            byte mininum = 123;
            int num = mininum;
            long bigNum = num;
            float floatNum = num;
            object obNum = num;
            double UDouble = num;
            // Явные преобразования 
            byte a = (byte)long1;
            sbyte b = (sbyte)long1;
            int c = (int)long1;
            uint d = (uint)long1;
            float e = (float)double1;

            //c Упаковка, Распаковка
            int ii = 123;
            object box = ii; //упаковка
            uint unbox = (uint)(int)box; //распаковка

            //d неявно типизирвоанные переменные
            var aa = 10;
            var bb = "hello";
            
            //e Nullable
            int? x = null;
            if (x.HasValue) Console.WriteLine(x.Value);
            else Console.WriteLine("x is null\n");

            //f var other type
            var jaba = 12;
            //jaba = "jabascript";

            //2.Strings
            //a литералы
            Console.WriteLine("jaba");
            Console.WriteLine("klava\n");

            //b
            string str1 = "hello";
            string str2 = "world";
            string str3 = "new";
            // сцепление
            string hwStr = str1 + " " + str2;
            Console.WriteLine(hwStr);

            // Копирование
            string copyStr = String.Copy(str3);
            Console.WriteLine(copyStr);

            //Подстрока
            string text = "substring text";
            string subStr = text.Substring(3, 8);
            Console.WriteLine(subStr);

            // Разделение строки на слова 
            string forSplit = "that string will be splited";
            Console.WriteLine(forSplit);
            foreach (string k in forSplit.Split(" "))
                Console.WriteLine(k);

            //вставка
            string isert = forSplit.Insert(5, subStr);
            Console.WriteLine(isert);

            //удаление
            string del = isert.Remove(4, 7);
            Console.WriteLine(del);

            ////Интерполяция 
            int xx = 10;
            int y = 20;
            string result = $"{xx} + {y} = {xx + y}";
            Console.WriteLine(result);

            //c IsNullorEmpry 
            string s1 = "";
            string s2 = null;
            Console.WriteLine(string.IsNullOrEmpty(s1));
            Console.WriteLine(string.IsNullOrEmpty(s2));

            //d StringBuilder

            StringBuilder sb = new StringBuilder("Привет");
            sb.Remove(0, 3);
            sb.Insert(0, "Best ");
            sb.Append(" клиника\n");
            Console.WriteLine(sb);


            //3 Массивы

            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }
            
            //b массив строк
            string[] strarr = { "Сентябрь","Октябрь","Ноябрь","Декабрь","Январь","Февраль"};
            Console.WriteLine($"Length of strarr:{strarr.Length}");
            for (int i = 0; i < strarr.Length; i++)
                Console.Write($"{strarr[i]}\t");
            strarr[3] = "No data";
            Console.WriteLine();
            for (int i = 0; i < strarr.Length; i++)
                Console.Write($"{strarr[i]}\t");

            //c ступенчатый массив
            Console.WriteLine();
            int[][] jar = new int[3][];
            jar[0] = new int[2];
            jar[1] = new int[3];
            jar[2] = new int[4];

            //for (int i = 0; i < jar.GetLength(0); i++)
            //    for (int k = 0; k < jar.GetLength(1); k++) jar[i][k] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < jar.GetLength(0); i++)
            //{
            //    for (int k = 0; k < jar.GetLength(1); k++)
            //        Console.Write($"{jar[i][k]}\t");
            //}

            //Console.WriteLine("Enter values:");
            //for (int i = 0; i < 2; i++)
            //    jar[0][i] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 3; i++)
            //    jar[1][i] = int.Parse(Console.ReadLine());
            //for (int i = 0; i < 4; i++)
            //    jar[2][i] = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 2; i++)
            //    Console.Write($"{jar[0][i]}\t");
            //Console.WriteLine();
            //for (int i = 0; i < 3; i++)
            //    Console.Write($"{jar[1][i]}\t");
            //Console.WriteLine();
            //for (int i = 0; i < 4; i++)
            //    Console.Write($"{jar[2][i]}\t");
            //Console.WriteLine();


            //d var-values массив/строка
            var Exemp1 = new int[10];
            var Exemp2 = new[] { 1, 2, 3 };
            var Exempstr = "";


            //4 Кортежи
            (int, string, char, string, ulong) tuple = (55,"str1",'A',"str2",555);

            //b вывод
            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item5);

            //с void value
            int[] vArr = new int[5];
            for (int _ = 0; _ < 5; _++)
            {
                vArr[_] = _;
                Console.Write($"{vArr[_]}\t");
            }
            Console.WriteLine();


            //5 Function

            Tuple<int, int, int, char> task5(int[] numbers, string word)
            {
                Array.Sort(numbers);
                return Tuple.Create(numbers[0], numbers[numbers.Length - 1], numbers.Sum(), word[0]);

            }
            var task5val = task5(new int[] { 5, 6, 7, 5, 6, 3, 6, 1, -5, 7, 1 }, "hello");

            int function1()
            {
                int maxVal = 2147483647;
                int z = 0;
                try
                {
                    z = checked(maxVal + 11);
                }
                catch (OverflowException e)  
                {
                    Console.WriteLine(e.ToString());
                }
                return z;
            }
            int function2()
            {
                int maxVal = 2147483647;
                int z = 0;
                try
                {
                    z = unchecked(maxVal + 11);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.ToString());
                }
                return z;
            }

            Console.WriteLine("fisrt : {0}", function1());
            Console.WriteLine("fisrt : {0}", function2());
        }
    }
}
