using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinQPractiseEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] person = {"Venkatesh", "Mark", "Mugesh", "AjayKumar", "Aravind", "Selish",
                "Aathisivan","SivaKumar" };

            FindNames(person);
        }
        public static void FindNames(string[] person)
        {
            IEnumerable<string> query = from s in person
                                        where s.Length > 5 & s.Contains("a")
                                        orderby s
                                        select s.ToUpper();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
