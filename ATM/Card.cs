using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CardData
{
    class Card
    {
        public long PAN { get; set; } = 0;
        public long PIN { get; set; } = 0;
        public long CVC { get; set; } = 0;
        public string ExpireDate { get; set; } = " ";
        public decimal Balance { get; set; } = 0.0M;

        public Card(long pAN, long pIN, long cVC, string expireDate, decimal balanse)
        {
            PAN = pAN;
            PIN = pIN;
            CVC = cVC;
            ExpireDate = expireDate;
            Balance = balanse;
        }
        public Card()
        {

        }


        public void CardShowforTransver()
        {


            Console.OutputEncoding = System.Text.Encoding.Unicode;
         

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card for charitable foundation ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ====================================================================================== \n");
           


            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@" Choose Cashe : 

 1 <- 10 manat      2 <- 20 manat
 3 <- 50 manat      4 <- 100 manat 
 5 <- 150 manat     6 <- 200 manat 
 7 <- 250 manat     8 <- Custom Cashe ");

            Console.Write($" \n Enter your Choose: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Balance -= 10;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }

                    break;
                case 2:
                    Balance -= 20;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 3:
                    Balance -= 50;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 4:
                    Balance -= 100;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 5:
                    Balance -= 150;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 6:
                    Balance -= 200;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 7:
                    Balance -= 250;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 8:
                    Console.Write($" \n Enter your amount  : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Balance -= amount;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                default:
                    Console.WriteLine("Unknown Choose");
                    break;

            }




            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card for charitable foundation ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ====================================================================================== \n");




        }

        public long panCode1()
        {
            string[] numberforRandom = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r1 = new Random();
            int n = numberforRandom.Length;
            StringBuilder panPart = new StringBuilder();



            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = numberforRandom[k];
                numberforRandom[k] = numberforRandom[n];
                numberforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                panPart.Append(numberforRandom[0]);
                panPart.Append(numberforRandom[1]);
                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[3]);

                panPart.Append(numberforRandom[4]);
                panPart.Append(numberforRandom[5]);
                panPart.Append(numberforRandom[6]);
                panPart.Append(numberforRandom[7]);

                panPart.Append(numberforRandom[8]);
                panPart.Append(numberforRandom[9]);

                panPart.Append(numberforRandom[0]);
                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[5]);
                panPart.Append(numberforRandom[7]);

                panPart.Append(numberforRandom[9]);
                panPart.Append(numberforRandom[1]);

                break;
            }

            string str = panPart.ToString();

            long Pan = long.Parse(str);



            return Pan;
        }

        public long pinCode1()
        {
            string[] numberforRandom2 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r2 = new Random();
            int n2 = numberforRandom2.Length;
            StringBuilder pinPart = new StringBuilder();



            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value = numberforRandom2[k2];
                numberforRandom2[k2] = numberforRandom2[n2];
                numberforRandom2[n2] = value;
            }

            for (int i = 0; i < n2; i++)
            {
                pinPart.Append(numberforRandom2[0]);
                pinPart.Append(numberforRandom2[1]);
                pinPart.Append(numberforRandom2[2]);
                pinPart.Append(numberforRandom2[3]);


            }

            string str = pinPart.ToString();

            long Pin = long.Parse(str);



            return Pin;

        }

        public long cvcCode1()
        {
            string[] numberforRandom3 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r3 = new Random();
            int n3 = numberforRandom3.Length;
            StringBuilder cvcPart = new StringBuilder();



            while (n3 > 1)
            {
                n3--;
                int k = r3.Next(n3 + 1);
                string value = numberforRandom3[k];
                numberforRandom3[k] = numberforRandom3[n3];
                numberforRandom3[n3] = value;
            }

            for (int i = 0; i < n3; i++)
            {
                cvcPart.Append(numberforRandom3[0]);
                cvcPart.Append(numberforRandom3[5]);
                cvcPart.Append(numberforRandom3[2]);
            }

            string str = cvcPart.ToString();

            long Cvc = long.Parse(str);



            return Cvc;
        }

        public string Date1()
        {
            string[] yearforRandom = new string[] { "2022", "2023", "2024", "2025","2026" };
            Random r1 = new Random();
            int n = yearforRandom.Length;
            StringBuilder datePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = yearforRandom[k];
                yearforRandom[k] = yearforRandom[n];
                yearforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                datePart.Append(yearforRandom[0]);
            }

            string str = datePart.ToString();
            int year = int.Parse(str);



            string[] monthforRandom = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            Random r2 = new Random();
            int n2 = monthforRandom.Length;
            StringBuilder monthPart = new StringBuilder();

            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value2 = monthforRandom[k2];
                monthforRandom[k2] = monthforRandom[n2];
                monthforRandom[n2] = value2;
            }

            for (int i = 0; i < n2; i++)
            {
                monthPart.Append(monthforRandom[0]);
            }

            string str2 = monthPart.ToString();
            int month = int.Parse(str2);



            DateTime cardDate = new DateTime(year, month, 1);

            string month_ = cardDate.Month.ToString();
            string year_ = cardDate.Year.ToString();


            string time = $"{month_} / {year_}";

            return time;

        }

        public int BalancePrice1()
        {
            string[] BalanceforRandom = new string[] { "50", "100", "200", "250", "500", "600", "700", "800", "900", "1000" };
            Random r = new Random();
            int n = BalanceforRandom.Length;
            StringBuilder BalancePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                string value2 = BalanceforRandom[k];
                BalanceforRandom[k] = BalanceforRandom[n];
                BalanceforRandom[n] = value2;
            }

            for (int i = 0; i < n; i++)
            {
                BalancePart.Append(BalanceforRandom[0]);
            }

            string str2 = BalancePart.ToString();
            int Balance = int.Parse(str2);


            if (Balance < 0)
            {
                throw new ArgumentException(nameof(Balance));

            }
            return Balance;
        }

        public void CardShow1()
        {


            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Balance = BalancePrice1();
            PAN = panCode1();
            ExpireDate = Date1();
            PIN = pinCode1();
            CVC = cvcCode1();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" 1 % transver to  charitable foundation \n");


            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@" Choose Cashe : 

 1 <- 10 manat      2 <- 20 manat
 3 <- 50 manat      4 <- 100 manat 
 5 <- 150 manat     6 <- 200 manat 
 7 <- 250 manat     8 <- Custom Cashe ");

            Console.Write($" \n Enter your Choose: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Balance -= 10;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }

                    break;
                case 2:
                    Balance -= 20;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 3:
                    Balance -= 50;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 4:
                    Balance -= 100;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 5:
                    Balance -= 150;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 6:
                    Balance -= 200;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 7:
                    Balance -= 250;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 8:
                    Console.Write($" \n Enter your amount  : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Balance -= amount;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                default:
                    Console.WriteLine("Unknown Choose");
                    break;

            }




            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t { Balance - (Balance * 1/100)} ");
            Console.WriteLine(" ================================================================ \n");




        }







        public long panCode2()
        {
            string[] numberforRandom = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r1 = new Random();
            int n = numberforRandom.Length;
            StringBuilder panPart = new StringBuilder();



            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = numberforRandom[k];
                numberforRandom[k] = numberforRandom[n];
                numberforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                panPart.Append(numberforRandom[1]);
                panPart.Append(numberforRandom[0]);
                panPart.Append(numberforRandom[4]);
                panPart.Append(numberforRandom[5]);

                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[3]);
                panPart.Append(numberforRandom[6]);
                panPart.Append(numberforRandom[7]);

                panPart.Append(numberforRandom[0]);
                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[8]);
                panPart.Append(numberforRandom[9]);


                panPart.Append(numberforRandom[9]);
                panPart.Append(numberforRandom[5]);
                panPart.Append(numberforRandom[7]);
                panPart.Append(numberforRandom[1]);

                break;
            }

            string str = panPart.ToString();

            long Pan = long.Parse(str);



            return Pan;
        }

        public long pinCode2()
        {
            string[] numberforRandom2 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r2 = new Random();
            int n2 = numberforRandom2.Length;
            StringBuilder pinPart = new StringBuilder();



            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value = numberforRandom2[k2];
                numberforRandom2[k2] = numberforRandom2[n2];
                numberforRandom2[n2] = value;
            }

            for (int i = 0; i < n2; i++)
            {
                pinPart.Append(numberforRandom2[0]);
                pinPart.Append(numberforRandom2[6]);
                pinPart.Append(numberforRandom2[4]);
                pinPart.Append(numberforRandom2[1]);


            }

            string str = pinPart.ToString();

            long Pin = long.Parse(str);



            return Pin;

        }

        public long cvcCode2()
        {
            string[] numberforRandom3 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r3 = new Random();
            int n3 = numberforRandom3.Length;
            StringBuilder cvcPart = new StringBuilder();



            while (n3 > 1)
            {
                n3--;
                int k = r3.Next(n3 + 1);
                string value = numberforRandom3[k];
                numberforRandom3[k] = numberforRandom3[n3];
                numberforRandom3[n3] = value;
            }

            for (int i = 0; i < n3; i++)
            {
                cvcPart.Append(numberforRandom3[1]);
                cvcPart.Append(numberforRandom3[7]);
                cvcPart.Append(numberforRandom3[2]);
            }

            string str = cvcPart.ToString();

            long Cvc = long.Parse(str);



            return Cvc;
        }

        public string Date2()
        {
            string[] yearforRandom = new string[] { "2022", "2023", "2024", "2025", "2026" };
            Random r1 = new Random();
            int n = yearforRandom.Length;
            StringBuilder datePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = yearforRandom[k];
                yearforRandom[k] = yearforRandom[n];
                yearforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                datePart.Append(yearforRandom[0]);
            }

            string str = datePart.ToString();
            int year = int.Parse(str);



            string[] monthforRandom = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            Random r2 = new Random();
            int n2 = monthforRandom.Length;
            StringBuilder monthPart = new StringBuilder();

            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value2 = monthforRandom[k2];
                monthforRandom[k2] = monthforRandom[n2];
                monthforRandom[n2] = value2;
            }

            for (int i = 0; i < n2; i++)
            {
                monthPart.Append(monthforRandom[0]);
            }

            string str2 = monthPart.ToString();
            int month = int.Parse(str2);



            DateTime cardDate = new DateTime(year, month, 1);

            string month_ = cardDate.Month.ToString();
            string year_ = cardDate.Year.ToString();


            string time = $"{month_} / {year_}";

            return time;

        }

        public int BalancePrice2()
        {
            string[] BalanceforRandom = new string[] { "50", "100", "200", "250", "500", "600", "700", "800", "900", "1000" };
            Random r = new Random();
            int n = BalanceforRandom.Length;
            StringBuilder BalancePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                string value2 = BalanceforRandom[k];
                BalanceforRandom[k] = BalanceforRandom[n];
                BalanceforRandom[n] = value2;
            }

            for (int i = 0; i < n; i++)
            {
                BalancePart.Append(BalanceforRandom[0]);
            }

            string str2 = BalancePart.ToString();
            int Balance = int.Parse(str2);


            if (Balance < 0)
            {
                throw new ArgumentException(nameof(Balance));

            }
            return Balance;
        }

        public void CardShow2()
        {


            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Balance = BalancePrice1();
            PAN = panCode1();
            ExpireDate = Date1();
            PIN = pinCode1();
            CVC = cvcCode1();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" 1 % transver to  charitable foundation \n");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@" Choose Cashe : 

 1 <- 10 manat      2 <- 20 manat
 3 <- 50 manat      4 <- 100 manat 
 5 <- 150 manat     6 <- 200 manat 
 7 <- 250 manat     8 <- Custom Cashe ");

            Console.Write($" \n Enter your Choose: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Balance -= 10;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }

                    break;
                case 2:
                    Balance -= 20;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 3:
                    Balance -= 50;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 4:
                    Balance -= 100;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 5:
                    Balance -= 150;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 6:
                    Balance -= 200;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 7:
                    Balance -= 250;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 8:
                    Console.Write($" \n Enter your amount  : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Balance -= amount;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                default:
                    Console.WriteLine("Unknown Choose");
                    break;

            }




            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" Balans: \t\t { Balance - (Balance * 1 / 100)} ");



        }

    







        public long panCode3()
        {
            string[] numberforRandom = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r1 = new Random();
            int n = numberforRandom.Length;
            StringBuilder panPart = new StringBuilder();



            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = numberforRandom[k];
                numberforRandom[k] = numberforRandom[n];
                numberforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                panPart.Append(numberforRandom[1]);
                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[3]);
                panPart.Append(numberforRandom[7]);

                panPart.Append(numberforRandom[4]);
                panPart.Append(numberforRandom[5]);
                panPart.Append(numberforRandom[6]);
                panPart.Append(numberforRandom[7]);

                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[9]);
                panPart.Append(numberforRandom[6]);
                panPart.Append(numberforRandom[8]);


                panPart.Append(numberforRandom[9]);
                panPart.Append(numberforRandom[5]);
                panPart.Append(numberforRandom[7]);
                panPart.Append(numberforRandom[1]);

                break;
            }

            string str = panPart.ToString();

            long Pan = long.Parse(str);



            return Pan;
        }

        public long pinCode3()
        {
            string[] numberforRandom2 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r2 = new Random();
            int n2 = numberforRandom2.Length;
            StringBuilder pinPart = new StringBuilder();



            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value = numberforRandom2[k2];
                numberforRandom2[k2] = numberforRandom2[n2];
                numberforRandom2[n2] = value;
            }

            for (int i = 0; i < n2; i++)
            {
                pinPart.Append(numberforRandom2[7]);
                pinPart.Append(numberforRandom2[1]);
                pinPart.Append(numberforRandom2[4]);
                pinPart.Append(numberforRandom2[6]);


            }

            string str = pinPart.ToString();

            long Pin = long.Parse(str);



            return Pin;

        }

        public long cvcCode3()
        {
            string[] numberforRandom3 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r3 = new Random();
            int n3 = numberforRandom3.Length;
            StringBuilder cvcPart = new StringBuilder();



            while (n3 > 1)
            {
                n3--;
                int k = r3.Next(n3 + 1);
                string value = numberforRandom3[k];
                numberforRandom3[k] = numberforRandom3[n3];
                numberforRandom3[n3] = value;
            }

            for (int i = 0; i < n3; i++)
            {
                cvcPart.Append(numberforRandom3[8]);
                cvcPart.Append(numberforRandom3[5]);
                cvcPart.Append(numberforRandom3[0]);
            }

            string str = cvcPart.ToString();

            long Cvc = long.Parse(str);



            return Cvc;
        }

        public string Date3()
        {
            string[] yearforRandom = new string[] { "2022", "2023", "2024", "2025", "2026" };
            Random r1 = new Random();
            int n = yearforRandom.Length;
            StringBuilder datePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = yearforRandom[k];
                yearforRandom[k] = yearforRandom[n];
                yearforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                datePart.Append(yearforRandom[0]);
            }

            string str = datePart.ToString();
            int year = int.Parse(str);



            string[] monthforRandom = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            Random r2 = new Random();
            int n2 = monthforRandom.Length;
            StringBuilder monthPart = new StringBuilder();

            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value2 = monthforRandom[k2];
                monthforRandom[k2] = monthforRandom[n2];
                monthforRandom[n2] = value2;
            }

            for (int i = 0; i < n2; i++)
            {
                monthPart.Append(monthforRandom[0]);
            }

            string str2 = monthPart.ToString();
            int month = int.Parse(str2);



            DateTime cardDate = new DateTime(year, month, 1);

            string month_ = cardDate.Month.ToString();
            string year_ = cardDate.Year.ToString();


            string time = $"{month_} / {year_}";

            return time;

        }

        public int BalancePrice3()
        {
            string[] BalanceforRandom = new string[] { "50", "100", "200", "250", "500", "600", "700", "800", "900", "1000" };
            Random r = new Random();
            int n = BalanceforRandom.Length;
            StringBuilder BalancePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                string value2 = BalanceforRandom[k];
                BalanceforRandom[k] = BalanceforRandom[n];
                BalanceforRandom[n] = value2;
            }

            for (int i = 0; i < n; i++)
            {
                BalancePart.Append(BalanceforRandom[0]);
            }

            string str2 = BalancePart.ToString();
            int Balance = int.Parse(str2);


            if (Balance < 0)
            {
                throw new ArgumentException(nameof(Balance));

            }
            return Balance;
        }

        public void CardShow3()
        {


            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Balance = BalancePrice1();
            PAN = panCode1();
            ExpireDate = Date1();
            PIN = pinCode1();
            CVC = cvcCode1();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" 1 % transver to  charitable foundation \n");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@" Choose Cashe : 

 1 <- 10 manat      2 <- 20 manat
 3 <- 50 manat      4 <- 100 manat 
 5 <- 150 manat     6 <- 200 manat 
 7 <- 250 manat     8 <- Custom Cashe ");

            Console.Write($" \n Enter your Choose: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Balance -= 10;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }

                    break;
                case 2:
                    Balance -= 20;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 3:
                    Balance -= 50;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 4:
                    Balance -= 100;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 5:
                    Balance -= 150;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 6:
                    Balance -= 200;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 7:
                    Balance -= 250;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 8:
                    Console.Write($" \n Enter your amount  : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Balance -= amount;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                default:
                    Console.WriteLine("Unknown Choose");
                    break;

            }

           



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" Balans: \t\t { Balance - (Balance * 1 / 100)} ");



        }








        public long panCode4()
        {
            string[] numberforRandom = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r1 = new Random();
            int n = numberforRandom.Length;
            StringBuilder panPart = new StringBuilder();



            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = numberforRandom[k];
                numberforRandom[k] = numberforRandom[n];
                numberforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                panPart.Append(numberforRandom[8]);
                panPart.Append(numberforRandom[6]);
                panPart.Append(numberforRandom[7]);
                panPart.Append(numberforRandom[5]);

                panPart.Append(numberforRandom[8]);
                panPart.Append(numberforRandom[3]);
                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[7]);

                panPart.Append(numberforRandom[1]);
                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[4]);
                panPart.Append(numberforRandom[9]);


                panPart.Append(numberforRandom[9]);
                panPart.Append(numberforRandom[5]);
                panPart.Append(numberforRandom[7]);
                panPart.Append(numberforRandom[4]);

                break;
            }

            string str = panPart.ToString();

            long Pan = long.Parse(str);



            return Pan;
        }

        public long pinCode4()
        {
            string[] numberforRandom2 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r2 = new Random();
            int n2 = numberforRandom2.Length;
            StringBuilder pinPart = new StringBuilder();



            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value = numberforRandom2[k2];
                numberforRandom2[k2] = numberforRandom2[n2];
                numberforRandom2[n2] = value;
            }

            for (int i = 0; i < n2; i++)
            {
                pinPart.Append(numberforRandom2[7]);
                pinPart.Append(numberforRandom2[8]);
                pinPart.Append(numberforRandom2[1]);
                pinPart.Append(numberforRandom2[9]);


            }

            string str = pinPart.ToString();

            long Pin = long.Parse(str);



            return Pin;

        }

        public long cvcCode4()
        {
            string[] numberforRandom3 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r3 = new Random();
            int n3 = numberforRandom3.Length;
            StringBuilder cvcPart = new StringBuilder();



            while (n3 > 1)
            {
                n3--;
                int k = r3.Next(n3 + 1);
                string value = numberforRandom3[k];
                numberforRandom3[k] = numberforRandom3[n3];
                numberforRandom3[n3] = value;
            }

            for (int i = 0; i < n3; i++)
            {
                cvcPart.Append(numberforRandom3[8]);
                cvcPart.Append(numberforRandom3[1]);
                cvcPart.Append(numberforRandom3[5]);
            }

            string str = cvcPart.ToString();

            long Cvc = long.Parse(str);



            return Cvc;
        }

        public string Date4()
        {
            string[] yearforRandom = new string[] { "2022", "2023", "2024", "2025", "2026" };
            Random r1 = new Random();
            int n = yearforRandom.Length;
            StringBuilder datePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = yearforRandom[k];
                yearforRandom[k] = yearforRandom[n];
                yearforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                datePart.Append(yearforRandom[0]);
            }

            string str = datePart.ToString();
            int year = int.Parse(str);



            string[] monthforRandom = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            Random r2 = new Random();
            int n2 = monthforRandom.Length;
            StringBuilder monthPart = new StringBuilder();

            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value2 = monthforRandom[k2];
                monthforRandom[k2] = monthforRandom[n2];
                monthforRandom[n2] = value2;
            }

            for (int i = 0; i < n2; i++)
            {
                monthPart.Append(monthforRandom[0]);
            }

            string str2 = monthPart.ToString();
            int month = int.Parse(str2);



            DateTime cardDate = new DateTime(year, month, 1);

            string month_ = cardDate.Month.ToString();
            string year_ = cardDate.Year.ToString();


            string time = $"{month_} / {year_}";

            return time;

        }

        public int BalancePrice4()
        {
            string[] BalanceforRandom = new string[] { "50", "100", "200", "250", "500", "600", "700", "800", "900", "1000" };
            Random r = new Random();
            int n = BalanceforRandom.Length;
            StringBuilder BalancePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                string value2 = BalanceforRandom[k];
                BalanceforRandom[k] = BalanceforRandom[n];
                BalanceforRandom[n] = value2;
            }

            for (int i = 0; i < n; i++)
            {
                BalancePart.Append(BalanceforRandom[0]);
            }

            string str2 = BalancePart.ToString();
            int Balance = int.Parse(str2);


            if (Balance < 0)
            {
                throw new ArgumentException(nameof(Balance));

            }
            return Balance;
        }

        public void CardShow4()
        {


            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Balance = BalancePrice1();
            PAN = panCode1();
            ExpireDate = Date1();
            PIN = pinCode1();
            CVC = cvcCode1();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" 1 % transver to  charitable foundation \n");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@" Choose Cashe : 

 1 <- 10 manat      2 <- 20 manat
 3 <- 50 manat      4 <- 100 manat 
 5 <- 150 manat     6 <- 200 manat 
 7 <- 250 manat     8 <- Custom Cashe ");

            Console.Write($" \n Enter your Choose: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Balance -= 10;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }

                    break;
                case 2:
                    Balance -= 20;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 3:
                    Balance -= 50;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 4:
                    Balance -= 100;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 5:
                    Balance -= 150;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 6:
                    Balance -= 200;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 7:
                    Balance -= 250;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 8:
                    Console.Write($" \n Enter your amount  : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Balance -= amount;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                default:
                    Console.WriteLine("Unknown Choose");
                    break;

            }

            



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" Balans: \t\t { Balance - (Balance * 1 / 100)} ");



        }










        public long panCode5()
        {
            string[] numberforRandom = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r1 = new Random();
            int n = numberforRandom.Length;
            StringBuilder panPart = new StringBuilder();



            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = numberforRandom[k];
                numberforRandom[k] = numberforRandom[n];
                numberforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                panPart.Append(numberforRandom[1]);
                panPart.Append(numberforRandom[6]);
                panPart.Append(numberforRandom[0]);
                panPart.Append(numberforRandom[5]);

                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[3]);
                panPart.Append(numberforRandom[4]);
                panPart.Append(numberforRandom[5]);

                panPart.Append(numberforRandom[1]);
                panPart.Append(numberforRandom[9]);
                panPart.Append(numberforRandom[4]);
                panPart.Append(numberforRandom[3]);


                panPart.Append(numberforRandom[7]);
                panPart.Append(numberforRandom[2]);
                panPart.Append(numberforRandom[0]);
                panPart.Append(numberforRandom[4]);

                break;
            }

            string str = panPart.ToString();

            long Pan = long.Parse(str);



            return Pan;
        }

        public long pinCode5()
        {
            string[] numberforRandom2 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r2 = new Random();
            int n2 = numberforRandom2.Length;
            StringBuilder pinPart = new StringBuilder();



            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value = numberforRandom2[k2];
                numberforRandom2[k2] = numberforRandom2[n2];
                numberforRandom2[n2] = value;
            }

            for (int i = 0; i < n2; i++)
            {
                pinPart.Append(numberforRandom2[8]);
                pinPart.Append(numberforRandom2[1]);
                pinPart.Append(numberforRandom2[3]);
                pinPart.Append(numberforRandom2[7]);


            }

            string str = pinPart.ToString();

            long Pin = long.Parse(str);



            return Pin;

        }

        public long cvcCode5()
        {
            string[] numberforRandom3 = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random r3 = new Random();
            int n3 = numberforRandom3.Length;
            StringBuilder cvcPart = new StringBuilder();



            while (n3 > 1)
            {
                n3--;
                int k = r3.Next(n3 + 1);
                string value = numberforRandom3[k];
                numberforRandom3[k] = numberforRandom3[n3];
                numberforRandom3[n3] = value;
            }

            for (int i = 0; i < n3; i++)
            {
                cvcPart.Append(numberforRandom3[6]);
                cvcPart.Append(numberforRandom3[5]);
                cvcPart.Append(numberforRandom3[2]);
            }

            string str = cvcPart.ToString();

            long Cvc = long.Parse(str);



            return Cvc;
        }

        public string Date5()
        {
            string[] yearforRandom = new string[] { "2022", "2023", "2024", "2025", "2026" };
            Random r1 = new Random();
            int n = yearforRandom.Length;
            StringBuilder datePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r1.Next(n + 1);
                string value = yearforRandom[k];
                yearforRandom[k] = yearforRandom[n];
                yearforRandom[n] = value;
            }

            for (int i = 0; i < n; i++)
            {
                datePart.Append(yearforRandom[0]);
            }

            string str = datePart.ToString();
            int year = int.Parse(str);



            string[] monthforRandom = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            Random r2 = new Random();
            int n2 = monthforRandom.Length;
            StringBuilder monthPart = new StringBuilder();

            while (n2 > 1)
            {
                n2--;
                int k2 = r2.Next(n2 + 1);
                string value2 = monthforRandom[k2];
                monthforRandom[k2] = monthforRandom[n2];
                monthforRandom[n2] = value2;
            }

            for (int i = 0; i < n2; i++)
            {
                monthPart.Append(monthforRandom[0]);
            }

            string str2 = monthPart.ToString();
            int month = int.Parse(str2);



            DateTime cardDate = new DateTime(year, month, 1);

            string month_ = cardDate.Month.ToString();
            string year_ = cardDate.Year.ToString();


            string time = $"{month_} / {year_}";

            return time;

        }

        public int BalancePrice5()
        {
            string[] BalanceforRandom = new string[] { "50", "100", "200", "250", "500", "600", "700", "800", "900", "1000" };
            Random r = new Random();
            int n = BalanceforRandom.Length;
            StringBuilder BalancePart = new StringBuilder();

            while (n > 1)
            {
                n--;
                int k = r.Next(n + 1);
                string value2 = BalanceforRandom[k];
                BalanceforRandom[k] = BalanceforRandom[n];
                BalanceforRandom[n] = value2;
            }

            for (int i = 0; i < n; i++)
            {
                BalancePart.Append(BalanceforRandom[0]);
            }

            string str2 = BalancePart.ToString();
            int Balance = int.Parse(str2);


            if (Balance < 0)
            {
                throw new ArgumentException(nameof(Balance));

            }
            return Balance;
        }

        public void CardShow5()
        {


            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Balance = BalancePrice1();
            PAN = panCode1();
            ExpireDate = Date1();
            PIN = pinCode1();
            CVC = cvcCode1();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" 1 % transver to  charitable foundation \n");

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@" Choose Cashe : 

 1 <- 10 manat      2 <- 20 manat
 3 <- 50 manat      4 <- 100 manat 
 5 <- 150 manat     6 <- 200 manat 
 7 <- 250 manat     8 <- Custom Cashe ");

            Console.Write($" \n Enter your Choose: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Balance -= 10;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }

                    break;
                case 2:
                    Balance -= 20;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 3:
                    Balance -= 50;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 4:
                    Balance -= 100;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 5:
                    Balance -= 150;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 6:
                    Balance -= 200;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 7:
                    Balance -= 250;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                case 8:
                    Console.Write($" \n Enter your amount  : ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Balance -= amount;
                    if (Balance < 0)
                    {
                        throw new ArgumentException(nameof(Balance));

                    }
                    break;
                default:
                    Console.WriteLine("Unknown Choose");
                    break;

            }

           



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Card Data ================================================= ");
            Console.WriteLine($" PAN code: \t\t {PAN} ");
            Console.WriteLine($" PIN code: \t\t {PIN} ");
            Console.WriteLine($" CVC code: \t\t {CVC} ");
            Console.WriteLine($" Expire Date: \t\t {ExpireDate} ");
            Console.WriteLine($" Balans: \t\t {Balance} ");
            Console.WriteLine(" ================================================================ \n");
            Console.WriteLine($" Balans: \t\t { Balance - (Balance * 1 / 100)} ");



        }








    }
}
