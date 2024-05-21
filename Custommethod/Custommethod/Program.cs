namespace Custommethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static string MyReplace (string currentValue, string oldValue,  string newValue) 
        {
            if (newValue != currentValue)
            {
                Console.WriteLine(currentValue);
            }
            if (oldValue != currentValue)
            {
                Console.WriteLine(currentValue);
            }
            return currentValue;
        }

        static string MySubstring (string myString, int startIndex, int endIndex, int lengthString) 
        {
            if (myString != null)
            {
                myString = myString.Substring (startIndex, endIndex);
                return myString;
            }
            
        }
        static string MyTrim (string myTrimString) 
        { 
            
            
        }

    }
}
