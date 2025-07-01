namespace programming_recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hihi welcome to papicalc pwease typesies in ur equation!!");
            Console.Write("oh! and ");

            while (true)
            {
                Console.WriteLine("you can always type 'exit' to exit!! <333");
                string? input = Console.ReadLine();

                if (input.ToLower() == "exit")
                { 
                    Console.WriteLine("okie see you later cutie!!!! >~< ^^"); break;
                }

                try
                {
                    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string part in parts) 
                    {
                        Console.WriteLine(part);
                    }

                    if (parts.Length != 3) 
                    { 
                        Console.WriteLine("oh! sorry could you enter an expression in the format of 'number operator number'? ty!!");
                        continue;
                    }
                }
                catch { }

            }
        }
    }
}