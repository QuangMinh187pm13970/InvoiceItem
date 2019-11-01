using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceItem i = new InvoiceItem("300", "200", 2, 500);
            Console.WriteLine(i.toString());
            i.setUnitPrice(300);
            Console.WriteLine(i.toString());
            Console.WriteLine(i.getTotal());

        }
    }
}
