
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserData
{
    class User
    {
        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public User()
        {

        }

        public string Name { get; set; } = "User's name is not ready ";
        public string Surname { get; set; } = "User's surname  is not ready ";

        public CardData.Card[] Cards { get; set; }

        public int CardCount { get; set; } = default;

        public void AddCard(ref CardData.Card cats)
        {
            CardData.Card[] temp = new CardData.Card[++CardCount];
            if (Cards != null)
            {
                Cards.CopyTo(temp, 0);

            }
            temp[temp.Length - 1] = cats;
            Cards = temp;
        }

        public bool RemoveCard()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter PIN for delete: ");
            long pin = Convert.ToInt64 (Console.ReadLine());


            bool found = false;
            for (int i = 0; i < Cards.Length; ++i)
            {
                if (found)
                {
                    Cards[i - 1] = Cards[i];
                }
                else if (Cards[i].PIN == pin)
                {
                    found = true;
                }
            }
            return found;



        }


        public void UserShow1()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ==== User Data ================================================= ");
            Console.WriteLine($" User name: \t\t {Name} ");
            Console.WriteLine($" User surname: \t\t { Surname} ");
            Console.WriteLine(" ================================================================ \n");
        }

        public void UserShow2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ==== User Data ================================================= ");
            Console.WriteLine($" User name: \t\t {Name} ");
            Console.WriteLine($" User surname: \t\t { Surname} ");
            Console.WriteLine(" ================================================================ \n");
        }

        public void UserShow3()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ==== User Data ================================================= ");
            Console.WriteLine($" User name: \t\t {Name} ");
            Console.WriteLine($" User surname: \t\t { Surname} ");
            Console.WriteLine(" ================================================================ \n");
        }

        public void UserShow4()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ==== User Data ================================================= ");
            Console.WriteLine($" User name: \t\t {Name} ");
            Console.WriteLine($" User surname: \t\t { Surname} ");
            Console.WriteLine(" ================================================================ \n");
        }

        public void UserShow5()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ==== User Data ================================================= ");
            Console.WriteLine($" User name: \t\t {Name} ");
            Console.WriteLine($" User surname: \t\t { Surname} ");
            Console.WriteLine(" ================================================================ \n");
        }

    }
}
