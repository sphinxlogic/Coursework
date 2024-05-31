using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoice = {
                new Invoice (83,"Electric Sander",7,57.98M),
                new Invoice (24,"Power Saw",18,99.99M),
                new Invoice (7,"Sledge Hammer",11,21.50M),
                new Invoice (77,"Hammer",76,11.99M),
                new Invoice (39,"Lawn Mower",3,79.50M),
                new Invoice (68,"Screwdriver",106,6.99M),
                new Invoice (56,"Jig Saw",21,11.00M),
                new Invoice (3, "Wrench",34,7.50M)};


            var PartDes =
                from i in invoice
                orderby i.PartDescription
                select i;

            Display(PartDes, "By Part Description");

            var ByPrice =
                from p in invoice
                orderby p.Price
                select p;

            Display(ByPrice, "By Price");

            var PartDes2 =
                from i in invoice
                orderby i.Quantity
                select new {PartDescription = i.PartDescription, Quantity = i.Quantity };

            Display(PartDes2, "By Quantity");

            var PartDes3 =
                from a in invoice
                let total = a.Quantity * a.Price
                select new {InvoiceTotal = a.PartDescription, total };
                

            Display(PartDes3, "Invoice Total");

            var PartDes4 =
                from b in invoice
                let total = b.Quantity * b.Price
                where total >= 200M && total <= 500M
                select b;

            Display(PartDes4, "Invoice Range");
            


                 
        }

        public static void Display<T>(IEnumerable<T> results, string header)
        {
            Console.WriteLine("{0}:", header);

            foreach (T element in results)
                Console.WriteLine(element);

            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
