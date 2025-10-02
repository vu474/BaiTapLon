using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("ví dụ XẤU (Fat Interface) :");
            try
            {
                var simplePrinter = new BadExample.SimplePrinter();
                simplePrinter.Print("Test Doc");               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            Console.WriteLine("\nví dụ TỐT (Skinny Interfaces) :");
            var goodSimplePrinter = new GoodExample.SimplePrinter();
            goodSimplePrinter.Print("Test Doc");

            var multiPrinter = new GoodExample.MultiFunctionPrinter();
            multiPrinter.Print("Test Doc");
            multiPrinter.Scan("test.jpg");
            multiPrinter.Fax("123456");
        }
    }
}
