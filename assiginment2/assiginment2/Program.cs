using System;

namespace Assignment2
{
    public class User
    {
        public int ID;
        public string Name;
    }

    internal class Program
    {
        private static User[] users = new User[100];
        private static int userCount = 0;

        private static void Main()
        {
            int menu;
            do
            {
                menu = menuOption();
                Console.WriteLine();

                switch (menu)
                {
                    case 1:
                        AddUser();
                        break;
                    case 2:
                        ShowUserByID();
                        break;
                    case 3:
                        ShowUserByName();
                        break;
                    case 4:
                        DeleteUserByID();
                        break;
                    case 5:
                        DeleteUserByName();
                        break;
                    case 6:
                        ListAllUserNames();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            } while (menu != 0);

            Console.ReadLine();
        }

        private static int menuOption()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1 - Add user");
            Console.WriteLine("2 - Show user by ID");
            Console.WriteLine("3 - Show user by Name");
            Console.WriteLine("4 - Delete user by ID");
            Console.WriteLine("5 - Delete user by Name");
            Console.WriteLine("6 - List all users");

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int menu))
            {
                return menu;
            }
            return -1; // Invalid choice
        }

        private static void AddUser()
        {
            if (userCount >= users.Length)
            {
                Console.WriteLine("User array is full. Cannot add more users.");
                return;
            }

            User user = new User();

            Console.Write("Enter user ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                user.ID = id;
            }
            else
            {
                Console.WriteLine("Invalid ID. User creation failed.");
                return;
            }

            Console.Write("Enter user name: ");
            user.Name = Console.ReadLine();

            users[userCount] = user;
            userCount++;

            Console.WriteLine("User added successfully.");
        }

        private static void ShowUserByID()
        {
            Console.Write("Enter user ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                User user = null;
                foreach (User u in users)
                {
                    if (u != null && u.ID == id)
                    {
                        user = u;
                        break;
                    }
                }

                if (user != null)
                {
                    Console.WriteLine($"User ID: {user.ID}, Name: {user.Name}");
                }
                else
                {
                    Console.WriteLine("User not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }


        private static void ShowUserByName()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            User user = null;
            foreach (User u in users)
            {
                if (u != null && u.Name == name)
                {
                    user = u;
                    break;
                }
            }

            if (user != null)
            {
                Console.WriteLine($"User ID: {user.ID}, Name: {user.Name}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }


        private static void DeleteUserByID()
        {
            Console.Write("Enter user ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                bool userFound = false;

                for (int i = 0; i < userCount; i++)
                {
                    if (users[i]?.ID == id)
                    {
                        User deletedUser = users[i];
                        users[i] = null;
                        userCount--;

                        Console.WriteLine($"User ID: {deletedUser.ID}, Name: {deletedUser.Name} deleted successfully.");
                        userFound = true;

                        // Shift the remaining users in the array to fill the gap
                        for (int j = i; j < userCount; j++)
                        {
                            users[j] = users[j + 1];
                            users[j + 1] = null;
                        }

                        break; // Exit the loop once user is found and deleted
                    }
                }

                if (!userFound)
                {
                    Console.WriteLine("User not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        private static void DeleteUserByName()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            int deletedCount = 0;
            for (int i = 0; i < userCount; i++)
            {
                if (users[i]?.Name == name)
                {
                    Console.WriteLine($"User ID: {users[i].ID}, Name: {users[i].Name} deleted successfully.");
                    users[i] = null;
                    deletedCount++;
                }
            }

            if (deletedCount == 0)
            {
                Console.WriteLine("User not found.");
            }
        }

        private static void ListAllUserNames()
        {
            Console.WriteLine("User Names:");
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine(users[i].Name);
            }
        }
    }
}

