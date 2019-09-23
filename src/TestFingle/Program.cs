using System;

namespace TestFingle
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Figgle.FiggleFonts.Standard.Render("Hello, Chen!");
            Console.WriteLine(message);
            Console.WriteLine(" Press any key to exit...");
            Console.ReadLine();
        }
    }
}
