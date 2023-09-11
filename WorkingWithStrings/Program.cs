using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will be on one line");
            Console.WriteLine("I love C# \n because it is different \n but difficult");// "\n" is a line break
            Console.WriteLine("Hi, my name is \"Karabo\"");

            //declaration of strings
            string name = "Karabo Phineas";
            string surname = "Mabala";
            int age = 22;
            double weight = 87.4;

            // string concatination
            Console.WriteLine("My Name is " + name + " " + surname);

            // string funtions
            Console.WriteLine("The length of the name is "+ name.Length);
            Console.WriteLine("Name in upper case is " + name.ToUpper());//changing name to upper case
            Console.WriteLine("Surname in lower case is "+surname.ToLower());// to lower function changing surname to lower case
            Console.WriteLine(age.ToString());
            Console.WriteLine("Data type of age is " + age.GetType());
            Console.WriteLine("Does name contain \"Ka\"? " + name.Contains("Ka"));
            Console.WriteLine("What is the initial(s) of this user's name is or are " + name[0]);
            Console.WriteLine("The index of k in name is " + name.IndexOf("K"));
            Console.WriteLine("Substring of surname is " + surname.Substring(1));
            Console.WriteLine("Substring of surname from 0 to 3 is " + surname.Substring(0,3));
            //freeze console
            Console.ReadLine();
        }
    }
}
