class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, welcome to my Calculator Console app ");
        Console.WriteLine("Please enter any number or decimal number");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        //double result = 0;

        while (true)
        {
            Console.WriteLine("Would you like to add, subtract, multiply or divide?");

            switch (Console.ReadLine())
            {
                case "add":
                    //result = num1 + num2;
                    Console.WriteLine("{0}+{1} ="+(num1+num2), num1, num2);
                    break;

                case "subtract":
                    //result = num1 - num2;
                    Console.WriteLine("{0}-{1} ="+(num1-num2), num1, num2);
                    break;

                case "multiply":
                    //result = num1 * num2;
                    Console.WriteLine("{0}*{1} ="+(num1*num2), num1, num2);
                    break;

                case "divide":
                    //result = num1 / num2;
                    Console.WriteLine("{0}/{1} ="+(num1/num2), num1, num2);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            Console.WriteLine("Would you like to continue or exit? (Type 'continue' or 'exit')");
            string choice = Console.ReadLine();

            if (choice == "exit")
            {
                break;
            }
            else if (choice == "continue")
            {
                Console.WriteLine("Please enter any number or decimal number");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid input");
                break;
            }
        }
    }
}