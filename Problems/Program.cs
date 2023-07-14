using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ArrayList a1 = new ArrayList();
            //Product p1 = new Product { name = "Wings of Fire", id = 8, price = 200 };
            //Product p2 = new Product { name = "harry potter", id = 8, price = 200 };  
            //a1.Add(p1);
            //a1.Add(p2);
            //Console.WriteLine(a1.Count);

            ////other method
            //ArrayList a2 = new ArrayList()
            //{
            //    new Product { name = "abc",id =7,price=900},
            //   new Product { name = "Name", id = 7, price = 900 }
            //};

            ////other method
            //ArrayList a3 = new ArrayList();
            //a3.Add(new Product { name = "om", id = 4, price = 400 });
            //a3.Add(new Product { name = "ram", id = 4, price = 400 });

            //foreach (Product p in a1)
            //{
            //    Console.WriteLine($"{p.name},{p.id},{p.price}");
            //}


            ArrayList a1 = new ArrayList();
            Book b1 = new Book {authorName = "D", Name = "Wings of Fire", id = 8, price = 200 };
            Book b2 = new Book {authorName = "D", Name = "harry potter", id = 8, price = 200 };
            a1.Add(b1);
            a1.Add(b2);
            
                ArrayList a3 = new ArrayList();

            foreach (Book b in a1)
            {
                Console.WriteLine($"{b.authorName},{b.Name},{b.id},{b.price}");
            }
        }
    }
}
