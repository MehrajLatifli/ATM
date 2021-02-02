using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseData
{
    class Database
    {
        public Database(UserData.User[] users)
        {

            Users = users;
        }

        public Database()
        {

        }

        public UserData.User[] Users { get; set; }

        public int UserCount { get; set; } = default;

        public void AddUser(ref UserData.User users)
        {
            UserData.User[] temp = new UserData.User[++UserCount];
            if (Users != null)
            {
                Users.CopyTo(temp, 0);

            }
            temp[temp.Length - 1] = users;
            Users = temp;
        }

        public bool RemoveUser()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter name for delete: ");
            string name = Console.ReadLine();


            bool found = false;
            for (int i = 0; i < Users.Length; ++i)
            {
                if (found)
                {
                    Users[i - 1] = Users[i];
                }
                else if (Users[i].Name == name)
                {
                    found = true;
                }
            }
            return found;



        }
    }
}
