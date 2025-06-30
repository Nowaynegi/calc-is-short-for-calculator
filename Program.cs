namespace programming_recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            if (Console.ReadKey().ToString() == "a")
            {
                Console.Beep();
                Console.WriteLine("awa meow purr");
            }
        }
    }
}
