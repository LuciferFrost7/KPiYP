namespace KPiYP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose your Variant: ");
            String variant = Console.ReadLine();
            Console.Write("Choose your task: ");
            String taskNumber = Console.ReadLine();

            switch (variant)
            {
                case "1":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("1.1. Whether the given integer is even");

                                    Console.Write("Enter your Number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    Console.WriteLine("number is" + ((number % 2).Equals(0) ? " even" : "n't even") );
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "2":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("1.1. Whether the given integer isn't even");

                                    Console.Write("Enter your number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Number {number} is" + (number % 2 == 1 ? " not even" : "n't not even" ));
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "3":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("if an integer M is divisible by an integer N, then the quotient of the division is displayed on the screen, otherwise the message “M is not divisible by N” is displayed");

                                    Console.Write("Enter number M: ");
                                    int numberM = int.Parse(Console.ReadLine());
                                    Console.Write("Enter number N: ");
                                    int numberN = int.Parse(Console.ReadLine());

                                    Console.WriteLine(numberM % numberN == 0 ? numberM / numberN : "M isn't divisible by N");
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "4":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("4.1. does this integer end in 7?");

                                    Console.Write("Enter your number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    Console.WriteLine("this integer " + (number % 10 == 7 ? "end on 7" : "don't end on 7"));
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "5":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("5.1 does the equation ax2+bx+c=0 have a solution, where a, b, c are these real numbers;");

                                    Console.Write("Enter your A number: ");
                                    double numberA = double.Parse(Console.ReadLine());
                                    Console.Write("Enter your B number: ");
                                    double numberB = double.Parse(Console.ReadLine());
                                    Console.Write("Enter your C number: ");
                                    double numberC = double.Parse(Console.ReadLine());
                                    Console.WriteLine(Math.Pow(numberB, 2) - 4 * numberA * numberC >= 0 ? "yes" : "no");
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "6":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("6.1. which of the digits of a two-digit number is greater: the first or the second");

                                    Console.Write("Enter your number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    if(number < 100 && number > 9)
                                    {
                                        Console.WriteLine("first number " + (number / 10 > number % 10 ? "more" : "less") + " than second number");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Valid Number!!!");
                                    }
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "7":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("7.1. whether the digits of a given two-digit number are the same");

                                    Console.Write("Enter your Number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    if (9 < number && number < 100)
                                    {
                                        Console.WriteLine(number / 10 == number % 10 ? "numbers are same" : "numbers aren't the same");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Valid Number!!!");
                                    }
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "8":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("8.1. is the sum of the digits of a two-digit number even?");

                                    Console.Write("Enter your Number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    if (9 < number && number < 100)
                                    {
                                        Console.WriteLine("the sum are" + (((number / 10) + (number % 10)) % 2 == 0 ? " even" : "n't even"));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Valid Number!!!");
                                    }
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "9":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("9.1. is the sum of the digits of a two-digit number not even?");

                                    Console.Write("Enter your Number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    if (9 < number && number < 100)
                                    {
                                        Console.WriteLine("the sum are" + (((number / 10) + (number % 10)) % 2 == 1 ? " not even" : "n't not even"));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Valid Number!!!");
                                    }
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "10":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("10.1. Is the sum of the digits of a two-digit number a multiple of three?");

                                    Console.Write("Enter your number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    if (9 < number && number < 100) 
                                    {
                                        Console.WriteLine(((number / 10) + (number % 10)) % 3 == 0 ? "sum multiply by 3" : "sum not multiply by 3");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid number!!!");
                                    }
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "11":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("11.1. Is the sum of the digits of a two-digit number a multiple of 5");

                                    Console.Write("Enter your number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    if (9 < number && number < 100)
                                    {
                                        Console.WriteLine(((number / 10) + (number % 10)) % 5 == 0 ? "sum multiply by 5" : "sum not multiply by 5");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not valid number!!!");
                                    }
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "12":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    {
                                        Console.WriteLine("12.1. which of the digits of a three-digit number is greater: the first or the last");

                                        Console.Write("Enter your number: ");
                                        int number = int.Parse(Console.ReadLine());
                                        if(99 < number && number < 1000)
                                        {
                                            Console.WriteLine("first number " + (number / 100 > number % 10 ? "more" : "less") + " than last number");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Number isn't valid!!!");
                                        }
                                    }
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "13":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {
                                    Console.WriteLine("13.1. which of the digits of a three-digit number is greater: the first or second");

                                    Console.Write("Enter your number: ");
                                    int number = int.Parse(Console.ReadLine());
                                    if (99 < number && number < 1000)
                                    {
                                        Console.WriteLine("first number " + (number / 100 > (number / 10) % 10 ? "more" : "less") + " than second number");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Number isn't valid!!!");
                                    }
                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "14":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {

                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "15":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {

                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "16":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {

                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "17":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {

                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "18":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {

                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "19":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {

                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                case "20":
                    {
                        switch (taskNumber)
                        {
                            case "1":
                                {

                                }
                                break;
                            case "2":
                                {

                                }
                                break;
                            case "3":
                                {

                                }
                                break;
                            case "4":
                                {

                                }
                                break;
                            case "5":
                                {

                                }
                                break;
                            default:
                                {
                                    Console.WriteLine("Choosen task number isn't correct!");
                                }
                                break;
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Choosen variant isn't correct!");
                    }
                    break;
            }
        }
    }
}