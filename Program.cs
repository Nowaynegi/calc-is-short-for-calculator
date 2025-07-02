namespace programming_recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hihi welcome to papicalc pwease typesies in ur equation!!");
            Console.Write("oh! and ");
            Console.WriteLine("you can always type 'exit' to exit!! <333");

            while (true)
            {
                
                string? input = Console.ReadLine();

                if (input.ToLower() == "exit")  // starting with the possible errors greatly helps simplify and shrink things! not to mention performance <3
                {
                    Console.WriteLine("okie see you later cutie!!!! >~< ^^"); break;
                }

                try
                {
                    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries); // first para is where to seperate!
                    /*  foreach (string part in parts)
                        {
                        Console.WriteLine(part);
                        } */

                    if (parts.Length != 3)
                    {
                        Console.WriteLine("oh! sorry, could you enter an expression in the format of 'number operator number'? ty!!");
                        continue;
                    }

                    string operand1Str = parts[0];
                    string operatorStr = parts[1];
                    string operand2Str = parts[2];

                    double operand1 = double.Parse(operand1Str); // explicitly takes strings! rather than the general Convert.ToDouble()
                    double operand2 = double.Parse(operand2Str);

                    double result = Calculate(operand1, operatorStr, operand2);

                    Console.WriteLine($"okie here's the answer!: {result}");

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                     Console.WriteLine("invalid format nya~ make sure your numbers are correct!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"unexpected exception: {ex.Message}!");
                }
            }
        }
        public static double Calculate(double operand1, string operatorStr, double operand2)
        {
            switch (operatorStr)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    if (operand2 == 0)
                    {
                        throw new DivideByZeroException("hey silly >~< don't divide by zeroo~ i dont know that one.."); // a message??!
                    }
                    return operand1 / operand2;
                default:
                    throw new Exception("unsupported operator! please enter + , - , * , or /");
            }
        }
    }
}