using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp3
{
    class MyClass
    {
        public int num;
    }
    internal class Program
    {
        #region Passing By Value [Value Type]
        static void PassByValue(int x)
        {
            x *= 2;
        }
        #endregion

        #region Passing By Ref [Value Type]
        static void PassByReference(ref int x)
        {
            x *= 2;
        }
        #endregion

        #region Passing By value [Ref Type]
        static void PassbyValue(MyClass x)
        {
            x.num = 10;
            x=new MyClass();
            x.num = 21;
        }
        #endregion
        #region Passing By Reference [Ref Type]
        static void PassByReference(ref MyClass x)
        {
            x.num = 14;
            x = new MyClass();
            x.num = 3;
        }
        #endregion



        static void Main(string[] args)
        {
            #region Question1
            //int number = 5;
            //Console.WriteLine($"Original value ={number}");
            ///*1-Passing Value type by value
            // when passing a value type by value a copy of data is passed to funcction any
            // change made to parameter inside function not affect original value
            // */
            //PassByValue(number);
            //Console.WriteLine($"After PassByValue ={number}");

            ///*2-passing value type by ref
            //  when passing value type by ref the function directly works in orginal variable
            //  so any change made to paraameter inside functiom will affect orginal varaible
            // */
            //PassByReference(ref number);
            //Console.WriteLine($"After PassByReference ={number}");
            #endregion
            #region Question2
            MyClass c1 = new MyClass();
            c1.num = 100;
            Console.WriteLine($"Original value ={c1.num}");
            //1-function can modify content of object but can not change reference itself
            PassbyValue(c1);
            Console.WriteLine($"After PassByValue ={c1.num}");

            //2-function can change both object contant and the reference
            PassByReference(ref c1);
            Console.WriteLine($"After PassByReference ={c1.num}");


            #endregion
        }
    }
}