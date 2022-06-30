namespace CSharpDemo_Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                var assist = new Ast();
                int action = assist.getActionValue();
                int value = assist.promptValue(0, 50, "\n Enter the Value to be evaluated here: ");
                var operate = new Operations(action, value);
                do
                {
                    int choice = assist.promptValue(0, 1, "\n Do you want to clear the screen and continue (Y=1/N=0) : ");
                    if (choice == 1)
                    {
                        again = true;
                        Console.Clear();
                    }
                    else
                        again = false;
                    break;
                } while (again);
            }
        }
    }

    class Ast
    {
        private const string name = "Ast1234";
        private int actionValue;

        public Ast()
        {
            promptInput();
            actionValue = identify(acceptAndVerify(1, 2, "\n Input action choice Here: "));
        }

        public void promptInput ()
        {
            Console.WriteLine("\n This is your C# Math Assistant " + name + ", How can I help you?");
            Console.WriteLine("\n \t 1. Find the factorial of a number (max 50)");
            Console.WriteLine("\n \t 2. List Prime numbers up to the limit specified (max 50)");
        }

        private int identify(int input)
        {
            int number = -1;
            switch (input)
            {
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
            return number;
        }

        public int promptValue(int min, int max, string text)
        {
            Console.WriteLine();
            int value = acceptAndVerify(min, max, text);
            return value;
        }

        public int acceptAndVerify(int min, int max, string text)
        {
            int res;
            do
            {
                Console.Write(text);
                res = Convert.ToInt32(Console.ReadLine());
                if (res >= min && res <= max)
                {
                    return res;
                }
                else
                {
                    Console.WriteLine("\n Wrong Input, Try again");
                }
            } while (res < min || res > max);
            return res;
        }

        public int getActionValue()
        {
            return actionValue;
        }

    }

    class Operations
    {
        private int? ID;
        private int operand;

        public Operations(int choice, int operand)
        {
            switch (choice)
            {
                case 1:
                    {
                        ID = 2285;
                        break;
                    }
                case 2:
                    {
                        ID = 0085;
                        break;
                    }
            }
            this.operand = operand;
            manage((int)ID);
        }

        private void manage(int functionID)
        {
            if (functionID == 2285)
            {
                factorialFinder(this.operand);
            }
            else
            {
                primeLister(this.operand);
            }
        }

        private void factorialFinder(int operand)
        {
            int fact = 1;
            for (int i = 1; i <= operand; i++){         
                fact = fact * i;
            }
            Console.WriteLine("\n The factorial of " + operand + " is : " + fact);
        }

        private void primeLister(int operand)
        {
            int counter = 0;
            while(counter <= operand)
            {
                if(counter % 2 == 0)
                {
                    Console.Write(counter + " | ");
                    counter++;
                }
                else
                {
                    counter++;
                    continue;
                }
            }
        }
    }
}