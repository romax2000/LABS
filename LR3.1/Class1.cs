using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//вариант 5

namespace LR3
{
    class SuperString //класс
    {
        public int length;
        static int count = 0;
        private string super = "";



        //public SuperString(int length) //конструктор с параметрами
        //{
        //    this.length = length;
        //}

        //public SuperString(int length = 8) //конструктор с параметрами по умолчанию
        //{
        //    this.length = length;
        //}

        //public SuperString() //конструктор без параметров
        //{
        //    length = 8;
        //}

        static SuperString() //статический конструктор
        {
        }

        private SuperString() //закрытый конструктор
        {
            length = super.Length;
        }

        public SuperString(string super) : this() //вызов конструктора
        {
            this.super = super;
            length = super.Length;
            count++;
            ID = count;
        }

        public readonly int ID = 0; // поле только для чтения
        public override int GetHashCode()
        {
            return ID;
        }
        public const int y = 8; // поле-константа
        private string Super //get/set
        {
            get
            {
                return super;
            }
            set
            {
                super = value;
            }
        }
        private int Count
        {
            get
            {
                return count;
            }
            set
            {
                if (count == 0)
                {
                    Console.WriteLine("Экземпляров нет");
                }
                else
                {
                    count = value;
                }
            }
        }
        public override bool Equals(object obj) //Equals
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;

            SuperString sp = (SuperString)obj;
            return (this.Count == sp.Count);
        }
        public override string ToString() //ToString
        {
            return Super;
        }
        public int GetLength() //метод длины строки
        {
            return super.Length;
        }

        public bool GetValue(char first) // метод наличия элемента в строке
        {
            char[] enemy = super.ToCharArray();
            bool ind=false;
            for (int k = 0; k < enemy.GetLength(0); k++)
                
            {
                if (first == enemy[k])
                {
                    ind=true;
                    break;
                }
                else
                {
                    ind=false;
                }
                
            }
            return ind;
        }

        public string GetMyValue(char last, char first)// замена элемента на новый
        {
            char[] enemy = super.ToCharArray();
            int ind = 0;
            for (int k = 0; k < enemy.GetLength(0); k++)
            {
                if (last == enemy[k])
                {
                    enemy[k] = first;
                    ind++;
                }
            }
            if (ind == 0) Console.WriteLine("Введённое значение не найдено");
            string little = new string(enemy);
            return little;
        }
    }




    public partial class BiClass //класс partail
    {
        private string OOP;
    }
    public partial class BiClass
    {
        public BiClass(){
            this.OOP = "Мой любимый предмет";
        }

    }



    class MyProgram
    {
        static void Main()
        {
            string MY = "BUS";
            SuperString myString = new SuperString("Hello World");
            SuperString myLASTstring = new SuperString("Charger");
            Console.WriteLine(myString.GetType());// тип
            Console.WriteLine(myString.length);
            Console.WriteLine(myString.GetHashCode());
            SuperString myNEWstring = new SuperString("My name is Roman");
            SuperString[] MASS = new SuperString[] { myString, myNEWstring, myLASTstring };// массив объектов
            Console.WriteLine(myString.Equals(MY));// сравнение строк
            Console.WriteLine(myString.Equals(myNEWstring));
            int param/*=10*/;
            testMethod(out /*ref*/ param); //Выйдет значение = 11
            Console.WriteLine("Значение переменной param в методе Main = {0}", param); //Выйдет значение = 11
            Console.WriteLine(myString.GetLength()); //длина строки
            Console.WriteLine(myLASTstring.GetValue('y')); //наличие элемента в строке
            Console.WriteLine(myLASTstring.GetValue('a'));
            Console.WriteLine(myLASTstring.GetMyValue('r', 'j')); // замена символа в строкe
            Console.WriteLine("Введите длину строки, которую хотите вывести (имеется 11, 7, 16) : "); //список строк определённой длины
            int length = Convert.ToInt32(Console.ReadLine());
            int cur = 0;
            for (int k = 0; k < MASS.Length; k++)
            {
                if (length == MASS[k].GetLength())
                {
                    Console.WriteLine(MASS[k]);
                    cur++;
                }
            }
            if (cur == 0) Console.WriteLine("Строки с заданной длиной отсутствуют");
            Console.WriteLine("Введите слово, по которому хотите найти строку");// список строк содержащих слово
            string VALUE = Convert.ToString(Console.ReadLine());
            char del = ' ';
            cur = 0;
            for (int k = 0; k < MASS.Length; k++)
            {
                string podMASS = MASS[k].ToString();
                String[] Words = podMASS.Split(del);
                for (int b = 0; b < Words.Length; b++)
                {
                    if (VALUE == Words[b])
                    {
                        Console.WriteLine(podMASS);
                        cur++;
                    }
                }
            }
            if (cur == 0) Console.WriteLine("Строки с заданным словом отсутствуют");
            var someType = new { Car="Dodge" };//анонимный тип
            Console.WriteLine(someType);
            Console.ReadLine();
        }
        static void testMethod(out /*ref*/ int param)
        {
            param = 10;
            param++;
            Console.WriteLine("Значение переменной param в методе testMethod = {0}", param);
        }
    }
}
