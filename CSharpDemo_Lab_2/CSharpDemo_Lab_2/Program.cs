namespace CSharpDemo_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assist = new Ast();
            int x = assist.getActionValue();
            Console.WriteLine("The number entered is: " + x);

        }
    }

    class Ast
    {
        private const string name = "Alpha 12";
        private const int identifier = 1288435;
        private int actionValue;

        public Ast()
        {
            promptInput();
            actionValue = acceptAndVerify();
        }

        public void promptInput ()
        {
            Console.WriteLine("This is your C# Math Assistant " + name + ", How can I help you?");
            Console.WriteLine("1. Find the factorial of a number");
            Console.WriteLine("2. List Prime numbers up to the limit specified");
        }

        public int acceptAndVerify()
        {
            int number = -1, res;
            do
            {
                Console.Write("Input here: ");
                res = Convert.ToInt32(Console.ReadLine());
                if (res > 0 && res <= 2)
                {
                    switch (res) {
                        case 1:
                            {
                                number = 1;
                                break;
                            }
                        case 2:
                            {
                                number = 2;
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Input, Try again");
                }
            } while (number < 0 || number > 2);
            return number;
        }

        public int getActionValue()
        {
            return actionValue;
        }

    }

    class Operations
    {
        private string? name;
        private int? ID;

        public Operations()
        {
            
        }
    }
}