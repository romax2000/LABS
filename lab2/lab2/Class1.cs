using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Class1
    {
        static void Main()
        {
            //1.1 задание
            sbyte sb = 8;
            short sh = 16;
            int i = 32;
            long l = 64;
            byte b = 8;
            ushort ush = 16;
            uint u = 32;
            ulong ul = 64;
            char c = 'q'; //16
            bool bo = false; //8
            float f = 32;
            double d = 64;
            decimal de = 128;
            string st = "Hello";
            object ob = 1;
            //1.2 задание
            Int16 i16 = 16;
            Int32 i32 = i16;
            float f32 = i16;
            Single S = i16;
            double d64 = i16;
            decimal de128 = i16;
            
            Byte b8 = (Byte)i16;
            Int64 i64 = (Int64)S;
            float f64 = (float)d64;
            double d128 = (double)de;
            decimal de64 = (decimal)d;
            //1.3 задание
            int x = 8;
            Object o = x;
            int xx = (int)o;
            byte bb = (byte)(int)o;
            //1.4 задание
            var mas = new[] { 1, 4.56, 64 };
            Console.Write("Неявно типизированные переменные : ");
            Console.Write(mas.GetType()); Console.WriteLine();
            //1.5 задание
            int? x1 = null;
            int y1 = x1 ?? 8;
            Console.Write("Пример работы Nullable : ");
            Console.WriteLine(y1);

            //2.1 задание
            string myName = "Romax";
            string myFamily = "Zavadski";
            Console.Write("Сравнение строк по первенству : ");
            Console.WriteLine(String.Compare(myName, myFamily));// если отриц, то первая строка предшедствует второй
            Console.Write("Сравнение строк по размеру : ");
            Console.WriteLine(String.CompareOrdinal(myName, myFamily));// если отриц, то значение первой строки меньше второй
            //2.2 задание
            string myDadyname = "Vitalur";
            Console.Write("Сцепление строк : ");
            Console.WriteLine(String.Concat(myName, myFamily, myDadyname));
            Console.Write("Копирование строк : ");
            string str1 = myName;
            str1 = String.Copy(myFamily);
            Console.WriteLine(str1);
            Console.Write("Выделение подстроки : ");
            Console.WriteLine(myFamily.Substring(3));
            Console.WriteLine("Разделение строки на слова : ");
            string str2 = "Zavadski_Roman_Vital`evich";
            char del = '_';
            String[] newString = str2.Split(del);
            foreach (var newStrings in newString)
                Console.WriteLine(newStrings);
            Console.Write("Вставка подстроки в заданную позицию : ");
            Console.WriteLine(myName.Insert(3, myFamily));
            Console.Write("Удаление подстроки из заданной позиции : ");
            Console.WriteLine(myFamily.Remove(4));
            //задание 2.3
            string nothing = "";
            string NULL = null;
            string str3 = NULL ?? myName;
            Console.Write("NULL строка и Nullable : ");
            Console.WriteLine(str3);
            Console.Write("Пустая строка и Nullable : ");
            string str4 = nothing ?? myName;
            Console.WriteLine(str4);
            //задание 2.4
            StringBuilder SB = new StringBuilder("Сочинение : моё лето", 100);
            SB.Remove(12, 8);
            SB.Append("моя машина ");
            SB.Insert(0, "Автор: Завадский Роман. ");
            Console.WriteLine("Работа со String Builder:");
            Console.WriteLine(SB);
            //задание 3.1
            int[,] mass = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("Вывод матрицы: ");
            foreach (int j in Enumerable.Range(0, mass.GetLength(0)))
            {
                foreach (int k in Enumerable.Range(0, mass.GetLength(1)))
                {
                    Console.Write("\t");
                    Console.Write(mass[j, k]);
                }
                Console.WriteLine();

                //int[][] mass = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } };
                //Console.WriteLine("Вывод матрицы: ");
                //foreach (int[] j in mass)
                //{
                //    foreach (int k in j)
                //    {
                //        Console.Write("\t");
                //        Console.Write("  " + k);
                //    }
                //    Console.WriteLine();
                //}

            }
            //задание 3.2
            string[] stringMass = new string[] { "Я ", "сегодня ", "проснулся ", "рано" };
            Console.Write("Одномерный массив строк : ");
            foreach (string stringsMass in stringMass)
                Console.Write(stringsMass);
            Console.WriteLine();
            Console.Write("Его длина: ");
            Console.WriteLine(stringMass.GetLength(0));
            Console.Write("Введите позицию : ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение : ");
            string position = Convert.ToString(Console.ReadLine());
            string forMe = ("123456789");
            Console.WriteLine(forMe.Insert(r, position));
            //задание 3.3
            int[][] jagged = new int[3][];
            jagged[0] = new int[2];
            jagged[1] = new int[3];
            jagged[2] = new int[4];
            int I;
            int P = 0;
            Console.WriteLine("Введите значения в зубчатый массив : ");
            for (int J = 0; J <= 2; J++)
            {
                for (I = 0; I <= (jagged[P].GetLength(0) - 1); I++)
                {
                    jagged[J][I] = Convert.ToInt32(Console.ReadLine());
                }
                I = 0;
                P = P + 1;
            }
            Console.WriteLine("Вывод зубчатого массива : ");
            foreach (int[] Y in jagged)
            {
                foreach (int K in Y)
                {
                    Console.Write("\t");
                    Console.Write("  " + K);
                }
                Console.WriteLine();
            }
            //задание 3.4
            var noTipMass = new[] { "12", "Месяцев ", "В году" };
            var noTipSting = "12354";

            //задание 4.1-4.2
            (int year, string mark, char version, string model, ulong number) AutoSale = (1970, "Dodge", 'R', "Charger", 5467);
            (int year, string name, string family) My = (18,"Роман","Завадский");
            //задание 4.3
            Console.WriteLine("Вывод кортежа полностью: ");
            Console.WriteLine(AutoSale);
            Console.WriteLine("И выборочно : ");
            Console.WriteLine(AutoSale.mark + AutoSale.model + AutoSale.year);
            //задание 4.4
            var (one, two, three, four, five) =AutoSale;
            Console.WriteLine(two);
            //задание 4.5
            Console.WriteLine("Сравнение кортежей : ");
            if (My.Equals(AutoSale))
            {
                Console.WriteLine("кортежи равны");
            }
            else { Console.WriteLine("кортежи не равны");
            }
            //задание 5
            int[] massiv = new int[] { 1, 3, 4, 54, 7,6,4 };
            func(massiv, myName);
            

        }
        static public (int, int, int, string) func(int[] arr, string str)
        {
            return Local(arr, str);
                (int, int, int, string) Local(int[] arrr, string strr) {
                
                int min = arrr[0]; int max = arrr[0]; int sum = 0;
                for (int p = 0; p < arrr.Length; p++)
                {
                    if (min >= arrr[p])
                        min = arrr[p];
                }
                for (int p = 0; p < arrr.Length; p++)
                {
                    if (max <= arrr[p])
                        max = arrr[p];
                }

                for (int p = 0; p < arrr.Length; p++)
                {
                    sum = sum + arrr[p];
                }
                strr= strr.Substring(0, 1);
                Console.WriteLine($"min= {min} max= {max} sum= {sum} strr= {strr}");
                return (min, max, sum, strr);
            }
        }
    }
}
