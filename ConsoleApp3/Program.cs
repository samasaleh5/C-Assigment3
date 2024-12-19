namespace ConsoleApp3
{
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

        static void Main(string[] args)
        {
            #region Question1
            int number = 5;
            Console.WriteLine($"Original value ={number}");
            /*1-Passing Value type by value
             when passing a value type by value a copy of data is passed to funcction any
             change made to parameter inside function not affect original value
             */
            PassByValue(number);
            Console.WriteLine($"After PassByValue ={number}");

            /*2-passing value type by ref
              when passing value type by ref the function directly works in orginal variable
              so any change made to paraameter inside functiom will affect orginal varaible
             */
            PassByReference(ref number);
            Console.WriteLine($"After PassByReference ={number}");
            #endregion

        }
    }
}