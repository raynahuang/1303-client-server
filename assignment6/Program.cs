namespace assignment6
{
    internal class Program
    {

        // Define the Display function that accepts a list of users and a delegate
        public static void Display(List<User> users, Action<User> displayAction)
        {
            // Iterate over the list of users
            foreach (var user in users)
            {
                // Invoke the display action for each user
                displayAction(user);

            }
        }

        static void Main(string[] args)
        {
            // Create a list of users with 5 RegularUsers and 5 EliteUsers
            var users = new List<User>
        {
            new EliteUser { Name = "Mia", Username = "mia3123", Email = "mia@icloud.com" },
            new EliteUser { Name = "Henry", Username = "henry19555", Email = "henry@gmail.com" },
            new EliteUser { Name = "Noah", Username = "hinoah444", Email = "noah@gmail.com" },
            new EliteUser { Name = "Ava", Username = "heloava777", Email = "ava@gmail.com" },
            new EliteUser { Name = "Oliver", Username = "olieever999", Email = "oliver@gmail.com" },
            new RegularUser { Name = "Isabella", Username = "isisisabella227", Email = "isabella@gmail.com" },
            new RegularUser { Name = "Lucas", Username = "lucassss171", Email = "lucas@gmail.com" },
            new RegularUser { Name = "Emma", Username = "emmaaaa173", Email = "emma@outlook.com" },
            new RegularUser { Name = "Liam", Username = "liam44756", Email = "liam@outlook.com" },
            new RegularUser { Name = "Sophia", Username = "sophiacute779", Email = "sophia@outlook.com" },
        };
        

            // Define the display action using a lambda expression
            Action<User> displayAction = user =>
            {
                // Display the properties of the user
                Console.WriteLine($"Name: {user.Name}\nUsername: {user.Username}\nEmail: {user.Email}");
                Console.WriteLine();
            };

            // Call the Display function and pass the list of users and display action
            Display(users, displayAction);
        }
    }
}