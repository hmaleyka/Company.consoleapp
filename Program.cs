using System.Runtime.Intrinsics.X86;

namespace Company.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User1 user = new User1();
            Company company = new Company();

            bool check = true;
            while (check)
            {
                Console.WriteLine("------CHOICES-------");
                Console.WriteLine("1. Register a user");
                Console.WriteLine("2. Login a user");
                Console.WriteLine("3. See all users in a company");
                Console.WriteLine("4. Get one user by username");
                Console.WriteLine("5. Update user's data");
                Console.WriteLine(" a. Update Name");
                Console.WriteLine(" b. Update surname");
                Console.WriteLine(" c. Update username");
                Console.WriteLine(" d. Update email");
                Console.WriteLine("6. Delete user from company");
                Console.WriteLine("7. Exit");


                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        company.Register();
                        break;
                    case 2:
                        company.Login();
                        break;
                    case 3:
                        company.GetAll();
                        break;
                    case 4:
                        company.GetByUserName();
                        break;
                    case 5:
                        company.UpdateByUsername();
                        break;
                    case 6:
                        company.DeleteByUserName();
                        break;
                    case 7:
                        check = false;
                        Console.WriteLine("thanks for visiting our operation ");
                        break;

                    default:
                        Console.WriteLine("please enter the correct number ");
                        break;
                }
        }  }
    }
}