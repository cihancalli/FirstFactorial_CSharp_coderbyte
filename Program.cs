using System;

namespace FirstFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(FirstFactorial(Convert.ToInt32(Console.ReadLine())));
        }

        public static int FirstFactorial(int num) {

            // code goes here
            if(num != 1){
            return num * FirstFactorial(num-1);
            }
            return 1;
        }
    }
}
