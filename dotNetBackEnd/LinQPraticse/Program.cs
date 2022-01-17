using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace LinQPraticse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdullah",
                       "Imran", "Siva", "Naresh",
                       "Suresh", "Suman" };

            //UsingLinq(names);
            //UsingExtensionLinq(names);
            //UsingLinQFunc(names);
            //UsingAnanomousMethod(names);
            LinQReadXml();
            //LinQAddXml();
        }
        public static void UsingLinq(String[] names)
        {
            IEnumerable<string> query = from s in names
                                        where s.Length == 5
                                        orderby s
                                        select s.ToUpper();
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        public static void UsingExtensionLinq(String[] names)
        {
            Console.WriteLine("\nUsing LinQ Extension");
            IEnumerable<string> query = names
                                        .Where(s => s.Length == 5)
                                        .OrderBy(s => s)
                                        .Select(s => s.ToUpper());
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        public static void UsingLinQFunc(string[] names)
        {
            Console.WriteLine("\nUsing LinQ Function");

            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper();

            IEnumerable<string> query = names.Where(filter).OrderBy(extract).Select(project);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
        public static void UsingAnanomousMethod(string[] names)
        {
            Console.WriteLine("\nUsing Ananomous Method");
            Func<string, bool> filter = delegate (string s)
            {
                return s.Length == 5;
            };

            Func<string, string> extract = delegate (string s) {
                return s;
            };

            Func<string, string> project = delegate (string s) {
                return s.ToUpper();
            };

            IEnumerable<string> query = names.Where(filter).OrderBy(extract).Select(project);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
        public static void LinQReadXml()
        {
            Console.WriteLine("\nRead from Xml");
            string myxml = @"<Departments>
                <Department>Account</Department>
                <Department> Sales </Department>
                <Department> Pre-Sales </Department>
                <Department> Delivery </Department>
                </Departments>";
            XDocument obj = new XDocument();
            obj = XDocument.Parse(myxml);

            var result = obj.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department --> " + item.Value);
            }
        }
        public static void LinQAddXml()
        {
            Console.WriteLine("\nRead from Xml");
            string myxml = @"<Departments>
                <Department>Account</Department>
                <Department> Sales </Department>
                <Department> Pre-Sales </Department>
                <Department> Delivery </Department>
                </Departments>";
            XDocument obj = new XDocument();
            obj = XDocument.Parse(myxml);

            obj.Element("Departments").Add(new XElement("Department", "Finance"));
            obj.Element("Departments").AddFirst(new XElement("Department", "Safety"));

            var result = obj.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department --> " + item.Value);
            }
        } 
    }
}
