using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will write the same line");
            Console.WriteLine("This will \n wrap to next line");
            Console.WriteLine("This will \" print out the qoutation mark");

            string Firstname = "Matimba";
            string Lastname = "Mabasa";

            // concatination 
            Console.WriteLine(Firstname +" "+ Lastname );
            // functions with string
            Console.WriteLine(Firstname.Length);
            //Methods of strings
            Console.WriteLine(Firstname.ToUpper());
            //methods with a parameter eg the conains, its case sensitive
            Console.WriteLine(Lastname.Contains("fu"));
            // Access characters using index
            Console.WriteLine(Firstname[0]);
            //index of will tell you if the index is there and at which position
            Console.WriteLine("index of a is");
            Console.WriteLine(Lastname.IndexOf(" a ")); // can use double qoutes too
            // substring , to grab from index to onwards
            Console.WriteLine(Firstname.Substring(1));
            // you can also give an index and length ie how many char you want to grab
            Console.WriteLine(Firstname.Substring(1,2));
            Console.Read();

        }
    }
}
