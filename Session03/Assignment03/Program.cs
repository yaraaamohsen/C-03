using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Transactions;
using System.Threading.Channels;

namespace Assignment03
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n <= 1) { return false; }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) { return false; }

            }
            return true;
        }
        static bool ArePointsCollinear(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = (x1 * (y2 - y3)) + (x2 * (y3 - y1)) + (x3 * (y1 - y2));
            return area == 0;
        }
        static void Main(string[] args)
        {
            #region 1. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.WriteLine("Enter An Integer Number: ");
            //string UserInput = Console.ReadLine();
            //int Input;
            //bool IsInteger = int.TryParse(UserInput, out Input);
            //string result = ((Input % 3 == 0) && (Input % 4 == 0) && IsInteger) ? "Yes" : "No";
            //Console.WriteLine(result);
            #endregion

            #region 2. Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.WriteLine("Enter An Integer Number: ");
            //string UserInput = Console.ReadLine();
            //int Input;
            //bool IsInteger = int.TryParse(UserInput, out Input);
            //if (IsInteger && Input < 0) 
            //{
            //    Console.WriteLine("Negative");            
            //}
            //else if(IsInteger)
            //{
            //    Console.WriteLine("Postive");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region 3. Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("Enter 1st digit: ");
            //string UserInput1 = Console.ReadLine();
            //bool IsInteger1 = int.TryParse(UserInput1, out int Input1);

            //Console.WriteLine("Enter 2nd digit: ");
            //string UserInput2 = Console.ReadLine();
            //bool IsInteger2 = int.TryParse(UserInput2, out int Input2);

            //Console.WriteLine("Enter 3rd digit: ");
            //string UserInput3 = Console.ReadLine();
            //bool IsInteger3 = int.TryParse(UserInput3, out int Input3);

            //int Max = Math.Max(Input1, Math.Max(Input2, Input3));
            //int Min = Math.Min(Input1, Math.Min(Input2, Input3));

            //Console.WriteLine("Max Value Is: " + Max);
            //Console.WriteLine("Min Value Is: " + Min);
            #endregion

            #region 4. Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.WriteLine("Enter An Integer Number: ");
            //string UserInput = Console.ReadLine();
            //int Input;
            //bool IsInteger = int.TryParse(UserInput, out Input);
            //if (IsInteger)
            //{
            //    string result = (Input % 2 == 0) ? "Even" : "Odd";
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region 5. Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Console.WriteLine("Enter One Char: ");
            //string UserInput = (Console.ReadLine()).ToLower();
            //if(UserInput.Length == 1)
            //{
            //    string result = (UserInput == "a" || UserInput == "e" || UserInput == "i" || UserInput == "o" || UserInput == "u") ? "Vowel": "Constant";
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region 6. Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter An Integer Number To Count: ");
            //string UserInput = Console.ReadLine();
            //bool IsInteger = int.TryParse(UserInput, out int Input);
            //if (IsInteger)
            //{
            //    for (int i = 0; i <= Input; i++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region 7. Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.WriteLine("Enter An Integer Number To get It Multiply By 12: ");
            //string UserInput = Console.ReadLine();
            //bool IsInteger = int.TryParse(UserInput, out int Input);
            //if (IsInteger)
            //{
            //    for (int i = 0; i <= 12; i++)
            //    {
            //        Console.WriteLine($"{Input} X {i} = {Input*i}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region 8. Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.WriteLine("Enter An Integer Number To Count Even Number: ");
            //string UserInput = Console.ReadLine();
            //bool IsInteger = int.TryParse(UserInput, out int Input);
            //if (IsInteger)
            //{
            //    for (int i = 0; i <= Input; i++)
            //    {
            //        if(i % 2 == 0)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}
            #endregion

            #region 9. Write a program that takes two integers then prints the power.
            //Console.WriteLine("Enter The Digit: ");
            //string Digit = Console.ReadLine();
            //bool IsInteger1 = int.TryParse(Digit, out int InputDigit);

            //Console.WriteLine("Enter The Power: ");
            //string Power = Console.ReadLine();
            //bool IsInteger2 = int.TryParse(Power, out int InputPower);

            //if (IsInteger1 && IsInteger2)
            //{
            //    double result = Math.Pow(InputDigit, InputPower);
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region 10. Write a program to enter marks of five subjects and calculate total, average and percentage.
            ////for (int i = 1; i <= 5; i++)
            ////{
            ////    Console.WriteLine($"Enter {i}st Subject: ");
            ////    string FirstSubject = Console.ReadLine();
            ////    bool IsInteger1 = int.TryParse(FirstSubject, out int Subject1);
            ////}
            //--> ASK HEREEEE

            //Console.WriteLine("Enter 1st Subject: ");
            //string FirstSubject = Console.ReadLine();
            //bool IsInteger1 = int.TryParse(FirstSubject, out int Subject1);

            //Console.WriteLine("Enter 2nd Subject: ");
            //string SecondSubject = Console.ReadLine();
            //bool IsInteger2 = int.TryParse(SecondSubject, out int Subject2);

            //Console.WriteLine("Enter 3rd Subject: ");
            //string ThirdSubject = Console.ReadLine();
            //bool IsInteger3 = int.TryParse(ThirdSubject, out int Subject3);

            //Console.WriteLine("Enter 4rd Subject: ");
            //string FourthSubject = Console.ReadLine();
            //bool IsInteger4 = int.TryParse(FourthSubject, out int Subject4);

            //Console.WriteLine("Enter 5rd Subject: ");
            //string FifthSubject = Console.ReadLine();
            //bool IsInteger5 = int.TryParse(FifthSubject, out int Subject5);

            //if (IsInteger1 && IsInteger2 && IsInteger3 && IsInteger4 && IsInteger5) 
            //{ 
            //    double Total = Subject1 + Subject2 + Subject3 + Subject4 + Subject5;
            //    Console.WriteLine("Total: " + Total);
            //    double Avg = (Subject1 + Subject2 + Subject3 + Subject4 + Subject5) / 5;
            //    Console.WriteLine("Average: " + Avg);
            //    double Percentaage = (Total / 500) * 100;
            //    Console.WriteLine("percentage: " + Percentaage);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Marks");
            //}


            #endregion

            #region 11. Write a program to input the month number and print the number of days in that month.
            //Console.WriteLine("Enter Month Number: ");
            //string UserInput = Console.ReadLine();
            //bool IsInteger = int.TryParse(UserInput, out int MonthNumber);
            //if (IsInteger && MonthNumber >= 1 && MonthNumber <= 12)
            //{
            //    int CountOfDays = DateTime.DaysInMonth(2024, MonthNumber);
            //    Console.WriteLine("Counts Of Days: " + CountOfDays);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region 12. Write a program to create a Simple Calculator.
            //Console.WriteLine("Enter 1st digit: ");
            //string UserInput1 = Console.ReadLine();
            //bool IsInteger1 = int.TryParse(UserInput1, out int Input1);

            //Console.WriteLine("Enter Operator Sign (+, -, *, /): ");
            //string UserInputSign = Console.ReadLine();

            //Console.WriteLine("Enter 2nd digit: ");
            //string UserInput2 = Console.ReadLine();
            //bool IsInteger2 = int.TryParse(UserInput2, out int Input2);

            //if (IsInteger1 && IsInteger2)
            //{
            //    if(UserInputSign == "+")
            //    {
            //        string Result = $"{UserInput1} + {UserInput2} = {Input1 + Input2}";
            //        Console.WriteLine(Result);
            //    }
            //    else if(UserInputSign == "-")
            //    {
            //        string Result = $"{UserInput1} - {UserInput2} = {Input1 - Input2}";
            //        Console.WriteLine(Result);
            //    }
            //    else if( UserInputSign == "*")
            //    {
            //        string Result = $"{UserInput1} X {UserInput2} = {Input1 * Input2}";
            //        Console.WriteLine(Result);
            //    }
            //    else if(UserInputSign == "/")
            //    {
            //        string Result = $"{UserInput1} / {UserInput2} = {Input1 / Input2}";
            //        Console.WriteLine(Result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Sign");
            //    }
            //}
            #endregion

            #region 13. Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.WriteLine("Enter Any Word: ");
            //string UserInput = Console.ReadLine();
            //char[] Result = UserInput.ToCharArray(0, UserInput.Length);
            //Console.Write("Reversed Word: ");
            //for (int i = UserInput.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(Result[i] + " ");
            //} 
            #endregion

            #region 14. Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.WriteLine("Enter An Integer Number: ");
            //string UserInput = Console.ReadLine();
            //bool IsInteger = nint.TryParse(UserInput, out nint Input);
            //if(IsInteger && Input < 0)
            //{
            //    nint Result = Math.Abs(Input);
            //    Console.WriteLine(Result);
            //}
            //else if(IsInteger && Input > 0)
            //{
            //    nint Result = -Input;
            //    Console.WriteLine(Result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}
            #endregion

            #region 15. Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.WriteLine("Enter Start digit: ");
            //string StartInput = Console.ReadLine();
            //bool IsInteger1 = int.TryParse(StartInput, out int StartDigit);

            //Console.WriteLine("Enter End digit: ");
            //string EndInput = Console.ReadLine();
            //bool IsInteger2 = int.TryParse(EndInput, out int EndDigit);

            //for(int i = StartDigit; i<= EndDigit; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.Write(i + " ");
            //    }    
            //}


            #endregion

            #region 16. Write a program in C# Sharp to convert a decimal number into binary without using an array.

            #endregion

            #region 17. Create a program that asks the user to input three points(x1, y1), (x2, y2), and(x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter The Coordinates Of The 1st Point (x1, y1): ");
            //Console.Write("x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Coordinates Of The 2nd Point (x2, y2): ");
            //Console.Write("x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter The Coordinates Of The 3rd Point (x3, y3):");
            //Console.Write("x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("y3: ");
            //double y3 = double.Parse(Console.ReadLine());

            //bool areCollinear = ArePointsCollinear(x1, y1, x2, y2, x3, y3);

            //string Result = areCollinear ? "The points lie on a single straight line" : "The points don't lie on a single straight line";
            //Console.WriteLine(Result);
            #endregion

            #region 18. based on the duration required to complete a specific task.A worker's efficiency level is determined as follows: 
            //-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //- If the worker takes more than 5 hours, they are required to leave the company.
            // To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            
            //Console.WriteLine("Enter Worker Hours: ");
            //string UserInput = Console.ReadLine();
            //bool IsInteger = int.TryParse(UserInput, out int workHours);
            //if (workHours >= 2 || workHours <= 3)
            //{
            //    Console.WriteLine("Highly Effiecient Level");
            //}
            //else if (workHours >= 3 || workHours <= 4)
            //{
            //    Console.WriteLine("Need To Increase Your Speed");
            //}
            //else if (workHours >= 4 || workHours <= 5)
            //{
            //    Console.WriteLine("provided with training to enhance their speed");
            //}
            //else if (workHours >= 5)
            //{
            //    Console.WriteLine("Sorry:(, Need To Leave The Company");
            //}
            #endregion
        }
    }
}

