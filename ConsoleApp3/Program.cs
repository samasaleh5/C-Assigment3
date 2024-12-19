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

        #region SumSubFunction
        static void CalculateSumAndSub(double[] nums) 
        { 
            double sum = nums[0]+ nums[1];
            double subtract = nums[2]-nums[3];
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Sub is {subtract}");
        }
        #endregion

        #region SumOfDigits
        static int CalculateSumOfDigits(int num) 
        {
            int sum = 0;
            while (num != 0) 
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
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
            //MyClass c1 = new MyClass();
            //c1.num = 100;
            //Console.WriteLine($"Original value ={c1.num}");
            ////1-function can modify content of object but can not change reference itself
            //PassbyValue(c1);
            //Console.WriteLine($"After PassByValue ={c1.num}");

            ////2-function can change both object contant and the reference
            //PassByReference(ref c1);
            //Console.WriteLine($"After PassByReference ={c1.num}");


            #endregion
            #region Question3
            //double[] numbers=new double[4];
            //for (int i = 0; i < numbers.Length; i++)
            //{ 
            //    Console.WriteLine($"Enter Number {i+1}");
            //    numbers[i] =Convert.ToDouble(Console.ReadLine());
            //}
            //CalculateSumAndSub(numbers);
            #endregion
            #region Question4
            Console.WriteLine("Please Enter A Number");
            int num=int.Parse(Console.ReadLine());

            int sum=CalculateSumOfDigits(num);
            Console.WriteLine($"Sum of digits of the number {num} is : {sum}");

            #endregion
        }
    }
}