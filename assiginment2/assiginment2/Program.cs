namespace assiginment2
{
    public class User
    {
        public int ID;
        public string Name;
    }
    internal class Program
    {
        static User[] users = new User[100];
        static int userCount = 0;

        static void Main()
        {
            int choice;
            do
            {
                choice = DisplayMenuAndGetChoice();
                Console.WriteLine();

                switch (choice)
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
            } while (choice != 0);

            Console.ReadLine();
        }

        static int DisplayMenuAndGetChoice()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1 - Add user");
            Console.WriteLine("2 - Show user by ID");
            Console.WriteLine("3 - Show user by Name");
            Console.WriteLine("4 - Delete user by ID");
            Console.WriteLine("5 - Delete user by Name");
            Console.WriteLine("6 - List all users Name (enter empty input to list all users)");
            

            Console.Write("Enter your choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }
            return -1; // Invalid choice
        }

        static void AddUser()
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

        static void ShowUserByID()
        {
            Console.Write("Enter user ID: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                User user = Array.Find(users, u => u?.ID == id);
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

        static void ShowUserByName()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            User user = Array.Find(users, u => u?.Name == name);
            if (user != null)
            {
                Console.WriteLine($"User ID: {user.ID}, Name: {user.Name}");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        static void DeleteUserByID()
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

        static void DeleteUserByName()
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

        static void ListAllUserNames()
        {
            Console.WriteLine("User Names:");
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine(users[i].Name);
            }
        }
    }


}