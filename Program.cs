using System;

namespace Day28UC15ABS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program of  Address Book");

            Console.Write("Enter Number of Address : ");
            int numBook = Convert.ToInt32(Console.ReadLine());
            int numberBook = 0;
            int key = 1;
            while (numberBook < numBook)
            {
                Console.Write(" Enter name of Address Book : ");
                string book = Console.ReadLine();
                Console.WriteLine(" choice the below number");
                Console.WriteLine("1.Add Contact \n2.View Contant  \n3.Count By City Or State Name");
                Console.Write("Enter Your option : ");
                int num = Convert.ToInt32(Console.ReadLine());

                while (key != 0)
                {
                    switch (num)
                    {
                        case 1:
                            Address.AddContact();
                            break;
                        case 2:
                            Address.Details();
                            break;
                        default:
                            Console.Write("Choice correct number : ");
                            num = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                    Console.Write(" continue press 1 : ");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                Address.AddTo(book);
                Address.JsonSerializeAddressBook();
                numberBook++;
            }
        }
    }
}
