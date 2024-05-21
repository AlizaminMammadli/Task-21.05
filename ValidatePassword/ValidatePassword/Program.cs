namespace ValidatePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            bool result = ValidatePassword(password);
            Console.WriteLine(result);
        }

        static bool ValidatePassword(string password)
        {
           if (password.Length < 8) 
            {
                return false;
            }
           if (!char.IsUpper(password[0]))
            {
                return false;
            }
           if (!password.Any(char.IsDigit))
            {
                return false;
            }
           if (!password.Any(char.IsLetterOrDigit))
            {
                return false;
            }
           return true;
        }
    }
}
