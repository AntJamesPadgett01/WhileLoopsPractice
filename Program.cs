using System;

namespace WhileLoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //int index = 1;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;// have to increment or decrement or you get infinite loop
            //}

            int index1 = 6;
            do
            {
                Console.WriteLine(index1);
                index1++;
            } while (index1 <= 5);



        }
    }
}
