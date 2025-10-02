using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class BadExample
    {
        public interface IPrinter
        {
            void Print(string document);
            void Scan(string file);
            void Fax(string number);
        }

        public class SimplePrinter : IPrinter
        {
            public void Print(string document)
            {
                Console.WriteLine($"In tài liệu: {document}");
            }

            public void Scan(string file)
            {
                throw new NotSupportedException("SimplePrinter không hỗ trợ scan!");
            }

            public void Fax(string number)
            {
                throw new NotSupportedException("SimplePrinter không hỗ trợ fax!");
            }
        }

        public class MultiFunctionPrinter : IPrinter
        {
            public void Print(string document)
            {
                Console.WriteLine($"In tài liệu: {document}");
            }

            public void Scan(string file)
            {
                Console.WriteLine($"Scan file: {file}");
            }

            public void Fax(string number)
            {
                Console.WriteLine($"Fax đến: {number}");
            }
        }
    }
}
