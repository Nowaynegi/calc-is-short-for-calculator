namespace programming_recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input; 
            Console.WriteLine("Hello, World!");

            input = Console.ReadKey().KeyChar.ToString();
            if (input == "a")
            {
                Console.WriteLine("awa meow puhrr");
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
