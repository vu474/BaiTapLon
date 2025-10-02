using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class GoodExample
    {
        public interface IPrintable
        {
            void Print(string document);
        }

        public interface IScannable
        {
            void Scan(string file);
        }

        public interface IFaxable
        {
            void Fax(string number);
        }

        public class SimplePrinter : IPrintable
        {
            public void Print(string document)
            {
                Console.WriteLine($"In tài liệu: {document}");
            }
        }

        public class MultiFunctionPrinter : IPrintable, IScannable, IFaxable
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
