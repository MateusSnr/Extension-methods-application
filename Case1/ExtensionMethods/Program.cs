using System;

namespace ExtensionMethods
{
    class Program
    {
        public static void Main()
        {
            DateTime dt = new DateTime(2023, 1, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
