namespace ConsoleApp1
{
    internal class Program
    {
        static bool CustomTryParse(string input, out int res)
        {
            res = 0;

            try
            {
                res = int.Parse(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a string:");

            string input = Console.ReadLine();

            if (CustomTryParse(input, out int res))
            {
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine(res);
            }
        }
    }
}