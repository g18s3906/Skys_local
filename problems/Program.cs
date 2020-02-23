using System;

namespace problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "what      ... did you say??";
            Console.WriteLine(prefix(input));
        }
        public static string prefix(string input1){
            int n = input1.Length;
            int number = input1.Split(new char[] {' ',}, StringSplitOptions.RemoveEmptyEntries).Length;
            return Convert.ToString( n +"," + number+ ":" + input1);
             
        }
    }
}
