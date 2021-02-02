
using CardData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            

            DatabaseData.Database d1 = new DatabaseData.Database();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" \n Enter your name: ");
            string name1 = Console.ReadLine();
            Console.Write($" \n Enter your surname: ");
            string surname1 = Console.ReadLine();

            UserData.User u1 = new UserData.User(name1,surname1);

            CardData.Card c1 = new CardData.Card();

            d1.AddUser(ref  u1);
            u1.UserShow1();




            try
            {

            u1.AddCard(ref c1);
                c1.CardShow1();
                
               

            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n {ex.Message} is incorrect ");
            }
            finally 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Operarion Completed ");
            }




            DatabaseData.Database d2 = new DatabaseData.Database();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" \n Enter your name: ");
            string name2 = Console.ReadLine();
            Console.Write($" \n Enter your surname: ");
            string surname2 = Console.ReadLine();

            UserData.User u2 = new UserData.User(name2, surname2);

            CardData.Card c2 = new CardData.Card();

            d2.AddUser(ref u2);
            u2.UserShow1();


            try
            {

                u2.AddCard(ref c2);
                c2.CardShow2();

            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n {ex.Message} is incorrect ");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Operarion Completed ");
            }

   



            DatabaseData.Database d3 = new DatabaseData.Database();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" \n Enter your name: ");
            string name3 = Console.ReadLine();
            Console.Write($" \n Enter your surname: ");
            string surname3 = Console.ReadLine();

            UserData.User u3 = new UserData.User(name3, surname3);

            CardData.Card c3 = new CardData.Card();

            d3.AddUser(ref u3);
            u3.UserShow3();


            try
            {

                u3.AddCard(ref c3);
                c3.CardShow3();

            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n {ex.Message} is incorrect ");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Operarion Completed ");
            }









            DatabaseData.Database d4 = new DatabaseData.Database();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" \n Enter your name: ");
            string name4 = Console.ReadLine();
            Console.Write($" \n Enter your surname: ");
            string surname4 = Console.ReadLine();

            UserData.User u4 = new UserData.User(name4, surname4);

            CardData.Card c4 = new CardData.Card();

            d4.AddUser(ref u4);
            u4.UserShow4();


            try
            {

                u4.AddCard(ref c4);
                c4.CardShow4();

            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n {ex.Message} is incorrect ");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Operarion Completed ");
            }











            DatabaseData.Database d5 = new DatabaseData.Database();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" \n Enter your name: ");
            string name5 = Console.ReadLine();
            Console.Write($" \n Enter your surname: ");
            string surname5 = Console.ReadLine();

            UserData.User u5 = new UserData.User(name5, surname5);

            CardData.Card c5 = new CardData.Card();

            d5.AddUser(ref u5);
            u5.UserShow5();


            try
            {

                u5.AddCard(ref c5);
                c5.CardShow5();

            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n {ex.Message} is incorrect ");
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" Operarion Completed ");
            }



            CardData.Card cardForcharitablefoundation = new CardData.Card()
            {
                PAN = 1234412312344123,
                PIN = 1234,
                CVC = 123,
                ExpireDate = "12 /2025",
                Balance = 1234M + c1.Balance*1/100+ c2.Balance * 1 / 100 + c2.Balance * 1 / 100 + c3.Balance * 1 / 100 + c4.Balance * 1 / 100 + c5.Balance * 1 / 100

            };

            cardForcharitablefoundation.CardShowforTransver();


            Console.ReadKey();
        }
    }
}
