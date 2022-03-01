using System;

namespace P225Delegate
{
    delegate bool Check(int item);

    class Program
    {
        delegate void WriteDel<T>(T item);
        delegate void WriteDel<T, U>(T item, U item2);

        static void Main(string[] args)
        {
            //int[] arr = { 2, 3, 5, 7, 10, 12, 15, 18, 17, 25, 23 };

            //Console.WriteLine(Sum(arr, IsEven));
            //Console.WriteLine(Sum(arr, IsOdd));
            //Console.WriteLine(Sum(arr, IsDevideByFive));

            //Write<string>("Test", WriteStr);
            //Write<bool>(true, WriteBool);
            //Write<double>(2.5, WriteDouble);

            //WriteDel<string> writeDelStr = new WriteDel<string>(WriteStr);
            //writeDelStr += Test2;
            //writeDelStr += Test;
            //writeDelStr -= Test2;
            //writeDelStr -= WriteStr;
            ////Anonym Method;
            //writeDelStr += delegate (string str1, string str2)
            //{
            //    Console.WriteLine($"Anonim Method {str1} {str2}");
            //};
            ////Lambda Expression
            //writeDelStr += (str1, str2) => Console.WriteLine($"Lambda Expression {str1} {str2}");


            //writeDelStr -= (str1, str2) =>
            //{
            //    Console.WriteLine($"Lambda Expression {str1} {str2}");
            //};
            //writeDelStr -= delegate (string str1, string str2)
            //{
            //    Console.WriteLine($"Anonim Method {str1} {str2}");
            //};

            //writeDelStr.Invoke("Hello World", "P225");
        }

        //static void Write<T>(T item, WriteDel<T> write)
        //{
        //    write(item);
        //}

        //static void WriteStr(string str, string str2)
        //{
        //    Console.WriteLine(str+" "+str2);
        //}

        //static void Test(string str, string str2)
        //{
        //    Console.WriteLine(str + " " + str2+"Code Academy");
        //}

        //static void Test2(string str, string str2)
        //{
        //    Console.WriteLine(str + " " + str2 + "Code Academy"+"Test 2");
        //}

        //static void WriteBool(bool str)
        //{
        //    Console.WriteLine(str);
        //}

        //static void WriteDouble(double item)
        //{
        //    Console.WriteLine(item);
        //}

        //static int Sum(int[] arr, Check check)
        //{
        //    int result = 0;

        //    foreach (int item in arr)
        //    {
        //        if (check(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //static int SumEven(int[] arr )
        //{
        //    int result = 0;

        //    foreach (int item in arr)
        //    {
        //        if (IsEven(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //static int SumOdd(int[] arr)
        //{
        //    int result = 0;

        //    foreach (int item in arr)
        //    {
        //        if (IsOdd(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //static int SumDevideByFive(int[] arr)
        //{
        //    int result = 0;

        //    foreach (int item in arr)
        //    {
        //        if (IsDevideByFive(item))
        //        {
        //            result += item;
        //        }
        //    }

        //    return result;
        //}

        //static bool IsOdd(int num)
        //{
        //    return num % 2 == 1;
        //}

        //static bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //}

        //static bool IsDevideByFive(int num)
        //{
        //    return num % 5 == 0;
        //}
    }

    //delegate bool Check(int item);
}
