using System;
using System.Collections.Generic;
using System.Text;

namespace P225BuiltInTypeDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Func Delegate
            //Func Delegate Return Type Void-den Ferqli Olan Methodlar Ucun 17 dene Overloadi Var
            //Generic bir type bu avtomatik methodun return type olur
            //Generic Typada Bir Nece dene Type Qeyd Sonun Methodun Return Type Olur
            //Func<int, byte, int, bool> func1 = new Func<int, byte, int, bool>(test);
            //func1 += test1;

            ////func1.Invoke(1, 1, 1);
            //func1(int.Parse(Console.ReadLine()),1,1);

            //Func<int> func2 = new Func<int>(test2);
            #endregion

            #region Action
            //Action Delegate Return Type Void Olan Methodlar Ucundu 16 dene Overloadi
            //16 paramethr qebul eden methodlar ucundu
            //Generic Ve Non Generic
            //Action action = new Action(delegate () { return; });
            //action += TestVoid;

            //action();

            //Action<int, byte> action1 = new Action<int, byte>((a, b) => Console.WriteLine(""));
            //action1 += TestVoid;

            //action1(1, 1);
            #endregion

            #region Predicate
            //Predicate Delegate Yalniz Return Type Bool Olan Ve Bir parametr Qebul Methodlar Ucundu
            //Predicate<int> predicate = new Predicate<int>(delegate (int a) { return a % 2 == 0; });
            //predicate += a => a % 5 == 0;
            //predicate += (a) => 
            //{
            //    a *= 5;
            //    return a % 3 == 0; 
            //};

            //predicate += IsOdd;



            //Predicate<int[]> predicate1 = new Predicate<int[]>
            //    (
            //        a => 
            //        {
            //            int result = 0;

            //            foreach (var item in a)
            //            {
            //                result += item;
            //            }

            //            return true;
            //        }
            //    );
            #endregion

            List<string> names = new List<string>();
            names.Add("Hamid");
            names.Add("Ismayil");
            names.Add("Onur");
            names.Add("Vuska");
            names.Add("Murad");
            names.Add("Togrul");
            names.Add("Vusal");
            names.Add("Maqsud");
            names.Add("Yamil");
            names.Add("Eltac");
            names.Add("Abdulla");
            names.Add("Ishaq");


            //names.Exists(CheckName);

            //Console.WriteLine(names.Exists(CheckName));
            //Console.WriteLine(names.Exists(name => name == "Test"));
            //Console.WriteLine(names.Exists(delegate (string name) { return name == "Vuska"; }));

            Console.WriteLine(names.Exists(s => s.Contains("Vus")));

            foreach (var item in names.FindAll(s=>s.Contains("Vus")))
            {
                Console.WriteLine(item);
            }

            foreach (var item in names.FindAll(s => s.Length > 5))
            {
                Console.WriteLine(item);
            }

            //names.ForEach(str => 
            //{
            //    str = str + " " + "P225";
            //    Console.WriteLine(str);
            //});

            //names.ForEach(name => Console.WriteLine(name));
        }

        //static bool CheckName(string str)
        //{
        //    return str == "Ishaq";
        //}


        static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }

        static void TestVoid(int a, byte b)
        {
            return;
        }

        static void TestVoid()
        {
            return;
        }

        static bool test(int a, byte b, int c)
        {
            return true;
        }

        static bool test1(int a, byte b, int c)
        {
            return true;
        }

        static int test2()
        {
            return 0;
        }
    }
}
