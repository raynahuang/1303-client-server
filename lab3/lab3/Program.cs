using System;

namespace lab3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            User[] users = new User[10];

            for (int i = 0; i < users.Length; i++)
            {
                users[i] = new User
                {
                    ID = i + 1,
                    Name = "placeholder" + (i + 1)
                };
            }

            PrintUserArray(users);

            Console.ReadLine();
        }


        public class User
        {
            public int ID;
            public string Name;
        }



        static void PrintUserArray(User[] users)
        {
            foreach (User user in users)
            {
                Console.WriteLine($"ID: {user.ID}, Name: {user.Name}");
            }
        }



    }
}