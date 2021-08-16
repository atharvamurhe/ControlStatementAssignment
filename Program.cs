using System;

namespace ControlStatementAssignment
{
    public class Assignment
    {
        //1. Write a C# Sharp program to accept two integers and check whether they are equal or not.
        public static void EqualOrNot()
        {
            Console.WriteLine("Enter First number: ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int second = int.Parse(Console.ReadLine());

            if(first == second)
            {
                Console.WriteLine("{0} and {1} are Equal.", first, second);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not Equal.", first, second);
            }
        }

        //2. Write a C# Sharp program to check whether a given number is even or odd.
        public static void EvenOrOdd()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if(num%2 == 0)
            {
                Console.WriteLine("{0} is an even integer.");
            }
            else
            {
                Console.WriteLine("{0} is an odd integer.");
            }
        }

        //3. Write a C# Sharp program to check whether a given number is positive or negative.
        public static void PositiveOrNegetive()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if(num > 0)
            {
                Console.WriteLine("{0} is a positive integer.", num);
            }
            else if(num == 0)
            {
                Console.WriteLine("{0} is neutral.", num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number.", num);
            }
        }

        //4. Write a C# Sharp program to find whether a given year is a leap year or not.
        public static void LeapYear()
        {
            Console.WriteLine("Enter the number: ");
            int year = int.Parse(Console.ReadLine());
            if(year%100 == 0 && year%400 == 0)
            {
                Console.WriteLine("{0} is a leap year.");
            }else if(year%4 == 0)
            {
                Console.WriteLine("{0} is a leap year.");
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.");
            }
        }

        //5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
        public static void IsEligible()
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if(age >= 21)
            {
                Console.WriteLine("You are eligible to cast vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to cast vote.");
            }
        }

        //6. Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0,
        //0 when m is 0 and -1 when m is less than 0.
        public static void IntValue()
        {
            Console.WriteLine("Enter a value: ");
            int value = int.Parse(Console.ReadLine());
            if(value > 0)
            {
                Console.WriteLine("1");
            }else if(value == 0)
            {
                Console.WriteLine("0");
            }else
            {
                Console.WriteLine("-1");
            }
        }

        //7. Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
        public static void HeightDetector()
        {
            Console.WriteLine("Enter your height: ");
            int height = int.Parse(Console.ReadLine());
            if (height > 0 && height <= 135)
            {
                Console.WriteLine("The person is a dwarf.");
            }else if(height > 135)
            {
                Console.WriteLine("The person is not a dwarf.");
            }
            else
            {
                Console.WriteLine("Invalid Height. Try again.");
            }
        }

        //8. Write a C# Sharp program to find the largest of three numbers.
        public static void LargestNumber()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            if(firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The 1st number is the greatest among three.");
            }else if(secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The 2nd number is the greatest among three.");
            }
            else
            {
                Console.WriteLine("The 3rd number is the greatest among three.");
            }
        }

        //9. Write a program in C# Sharp to accept a grade and declare the equivalent description:
        public static void GardeDescription()
        {
            Console.WriteLine("Enter Your Grade: ");
            char grade = char.Parse(Console.ReadLine());
            grade = char.ToUpper(grade);

            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Excelent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default: Console.WriteLine("Invalid Input. Please enter a valid grade.");
                    break;
            }
        }

        //10. Write a program in C# Sharp to read any digit, display in the word.
        public static void DigitToWord()
        {
            Console.WriteLine("Enter a digit: ");
            int digit = int.Parse(Console.ReadLine());
            switch (digit)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 0:
                    Console.WriteLine("Zero");
                    break;
                default:
                    Console.WriteLine("Enter a valid digit");
                    break;
            }
        }

        //12. Write a program in c# to make such a pattern like right angled triangle with number increased by 1
        public static void NumberTriangle()
        {
            int num = 1;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0;j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.Write("\n");
            }
        }

        //13. Write a program in c# to make such a pattern like a pyramid with numbers increased by 1
        public static void NumberPyramid()
        {
            int height = 4;
            int num = 1;
            for(int i = 1; i <= height; i++)
            {
                for(int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ",num++);
                }
                Console.Write("\n");
            }
        }

        //14. Write a program in c# to make such a pattern like a pyramid with an asterisk.
        public static void AsteriskPyramid()
        {
            int height = 4;
            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
        }
    }
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Assignment.AsteriskPyramid();
        }
    }
}
