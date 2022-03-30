using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day28UC14ABS
{
    class Address
    {
        private static List<Contact> contacts = new List<Contact>();

        private static Dictionary<string, List<Contact>> addressBook = new Dictionary<string, List<Contact>>();

        public static Dictionary<string, List<Contact>> cityBook = new Dictionary<string, List<Contact>>();
        public static Dictionary<string, List<Contact>> stateBook = new Dictionary<string, List<Contact>>();

        public static void AddTo(string name)
        {
            addressBook.Add(name, contacts);
        }
        public static void AddContact()
        {
            Contact person = new Contact();

            Console.Write(" Enter your First name : ");
            person.FirstName = Console.ReadLine();
            Console.Write(" Enter your Last name : ");
            person.LastName = Console.ReadLine();
            Console.Write(" Enter your Address : ");
            person.Address = Console.ReadLine();
            Console.Write(" Enter your City : ");
            person.City = Console.ReadLine();
            Console.Write(" Enter your State : ");
            person.State = Console.ReadLine();
            Console.Write(" Enter your Zip Code : ");
            person.ZipCode = Console.ReadLine();
            Console.Write(" Enter your Phone Number : ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write(" Enter your Email-ID : ");
            person.Email = Console.ReadLine();

            contacts.Add(person);
            Console.WriteLine("\n {0}'s contact succesfully added", person.FirstName);
        }

        public static void Details()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine(" no people added ");
            }
            else
            {
                Console.WriteLine("details of contacts ");

                foreach (var a in contacts)
                {
                    Console.WriteLine("First name : " + a.FirstName);
                    Console.WriteLine("Last name : " + a.LastName);
                    Console.WriteLine("Address : " + a.Address);
                    Console.WriteLine("State : " + a.State);
                    Console.WriteLine("City : " + a.City);
                    Console.WriteLine("Zip Code : " + a.ZipCode);
                    Console.WriteLine("Phone number = " + a.PhoneNumber);
                }
            }
        }

        public static void Demo1SerialiseMethod()
        {
            try
            {
                string csvPath = @"C:\Users\HP\Desktop\Class\Day28AddressBookSystem\Day28UC14\demo1.csv";
                var writer = File.AppendText(csvPath);


                foreach (KeyValuePair<string, List<Contact>> item in addressBook)
                {
                    foreach (var items in item.Value)
                    {
                        writer.WriteLine(items.FirstName + ", " + items.LastName + ", " + items.PhoneNumber + ", " + items.Email + ", " + items.City + ", " + items.State + ", " + items.ZipCode + ".");

                    }
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public static void Demo1DeserialiseMethod()
        {
            string csvPath = @"C:\Users\HP\Desktop\Class\Day28AddressBookSystem\Day28UC14\demo1.csv";
            using (var reader = new StreamReader(csvPath))

            {
                string s = " ";
                while ((s = reader.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
