
namespace Console
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var TestWord = GetWord().First();

            do
            {


                Console.Write("copy this: ");
                WYellow();
                Console.WriteLine(TestWord);

                var b = System.Console.ReadLine().Trim();
                if (TestWord.ToLowerInvariant() == b.ToLowerInvariant())
                {
                    System.Console.WriteLine("Well done!!");
                }
                else
                {
                    WRed();
                    Console.WriteLine("Wrong");
                    WWhite();
                }



            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

           
        }
        public static void WRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void WWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static string[] GetWord()
        {
            return new[] { "Zofia" };
        }


    }
}
