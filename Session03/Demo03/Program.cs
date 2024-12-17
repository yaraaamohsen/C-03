using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;

namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int X = 4, Y = 5;

            #region String Formatting
            //// String Formatting
            //// Equation: X + Y = 12

            //// 1. String Concatnation
            //String Message = "Equation: " + X + " + " + Y + " = " + (X + Y);
            //Console.WriteLine(Message);
            //// +                    --> Every Time It Create New Object, In THe Quation Above It Created 6 Objects 
            ////                      --> Not Good For Performance
            //// String: Immutable    --> Can't Change Its Value After Creation

            // 2. String Format
            //string Message = string.Format("Equation : {0} + {1} = {2}", X, Y, (X + Y));
            //Console.WriteLine(Message);
            //// --> Better Than String Format In Performance
            //// --> Create The String As One Object

            //string Message = ($"Equation : {X} + {Y} = {X + Y}");
            //Console.WriteLine(Message);
            //// Best One
            //// Consdered As Syntax Sugar For String Format
            #endregion

            #region Control Statement: 1. Conditional Control Statement
            // Control Statement
            // Control Statement : 1. Conditional Control Statements (if, swich Case)
            // Control Statement : 2. Loop Control Statements (for, foreach, while, do-while)

            //Console.WriteLine("Enter Number Of Month In The 1st Quarter");
            //int MonthNumber = int.Parse(Console.ReadLine());
            ////////// IF
            //if (/*Expression*/)
            //{
            //    // Code
            //    // This Code WillBe Excuted When The Condition Is True
            //}

            ////////// SWITCH ---> Used With Equality

            // switch (Expression)
            // {
            //  case
            // }

            /*
            - Better In Performance Than If
            - Create Jump Table In Memory According to hash.(ump To The Result)
            - Works With Int Only
            - Used For Equality Comparsion
            - doens't Work With Logical Operators
             */
            #region Ex01
            //if(MonthNumber == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Jan");
            //}
            //if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Jan");
            //}

            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //switch(MonthNumber) 
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default: Console.WriteLine("Invalid");
            //        break;
            //}

            #endregion

            #region Ex02
            //Console.WriteLine("Enter Your Name: ");
            //string Name = Console.ReadLine();

            //switch(Name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("Hi Ahmed");
            //        break;
            //    case "omar":
            //    case "Omar":
            //        Console.WriteLine("Hi Omar");
            //        break;
            //    case "Ali":
            //    case "ali":
            //        Console.WriteLine("Hi Ali");
            //        break;
            //}
            #endregion

            #region Ex03
            //Console.WriteLine("Enter Your Age");
            //int Age = int.Parse(Console.ReadLine());
            ////if(Age > 18)
            ////{
            ////    Console.WriteLine("Welcome Older Than 18");
            ////}
            ////else if(Age < 18)
            ////{
            ////    Console.WriteLine("Sorry Babies :(");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Equal");
            ////}

            //switch (Age)
            //{
            //    case > 18:
            //        Console.WriteLine("> 18");
            //        break;
            //    case < 18:
            //        Console.WriteLine("< 18");
            //        break;
            //    default:
            //        Console.WriteLine("= 18");
            //        break;

            //}
            #endregion
            #endregion

            #region C# 7.0
            //object Object = new object();
            //Object = "Ahmed";
            //Object = 1;

            //switch (Object)
            //{
            //    case int X when X > -12:
            //        Console.WriteLine("hello From Int switch");
            //        break;
            //    case string Y when Y.Length > 3:
            //        Console.WriteLine("Hello From String Switch");
            //        break;
            //}
            #endregion

            #region C# 8.0
            //string Input = Console.ReadLine();

            //Input switch
            //{
            //    "1" => /*goose to*/ "Option 1",
            //    "2" => "Option 2",
            //    "3" => "Option 3"و
            //    _ => "unsupported Option"
            //};
            //Console.WriteLine(Input);
            #endregion

            #region Control Statement: 2. Loop Control Statement(for, foreach)
            // Control Statement : 2. Loop Control Statements (for, foreach, while, do-while)

            // 1. for Loop
            //for (/*Statement*/ ; /*Expression*/ ; /*Statement*/) {
            //    // Code
            //    // The Code Will Repeated
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);

            //}

            //int i = 1;
            //for (Console.WriteLine("Hello"); i <= 10; Console.WriteLine("Hello"))
            //{
            //    Console.WriteLine(i);
            //    i++;

            //}

            //int i = 1;
            //for (; i <= 10;)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            // 2. For Each
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };

            //for(int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach(int N in Numbers)
            //{
            //    Console.WriteLine(N);
            //}

            #endregion

            #region Control Statement: 2. Loop Control Statement(while, while do)
            // while

            //while (/*Expression*/)
            //{
            //    // Code
            //    // That Code Will Repeated While The Expression Is true
            //}

            //while (true)
            //{
            //    Console.WriteLine("Hello Wolrd!!"); // infinity loop
            //}

            //int i = 10;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++; // Increment
            //}

            //do { 
            //    // Code
            //    // This Code Will Excuted First
            //} while (/*Expression*/);

            //do
            //{
            //    Console.WriteLine("Hello World");                
            //    i ++;
            //} while (i<10);



            //do
            //{
            //    Console.WriteLine("Even Number");
            //    int Number = int.Parse(Console.ReadLine());
            //}
            //while (Number % 2 != 0);

            #endregion

            #region String
            // string: Reference Type : HEAP (class)
            // Imutable Type: Can not Change Its Value After Intialized

            //string S01;
            //// Declare For Refrence (Pointer) From Type 'String'
            //// Can Refer TO Object From 'String'
            //// 8 Bytes Allocated At Stack For References 'S01'
            //// 0 Byte Will Be Allocated At Heap 
            //// Refer To Null

            //S01 = new string("Hello");
            //S01 = "Ahmed"; // Syntax Sugar
            //               // new 
            //               // 1. Allocated The Number Of Required Bytes For THe Object In Heap
            //               // 2. Intialized The Allocated Bytes With The Default Value
            //               // 3. Call User-Defined Constructor If Exist
            //               // 4. Assign The Object To The Refrences
            #endregion

            #region String Builder
            //// StringBuilder: Class (Reference Type) : HEAP
            //// Mutable DataType
            //StringBuilder S01;
            //// Declare For Refrence (Pointer) From Type 'StringBuilder'
            //// Can Refer TO Object From 'StringBuilder'
            //// Refer To Null

            //S01 = new StringBuilder("Ahmed");
            //// New
            //// 1. Allocated The Number Of Required Bytes For THe Object In Heap
            //// 2. Intialized The Allocated Bytes With The Default Value
            //// 3. Call User-Defined Constructor If Exist
            //// 4. Assign The Object To The Refrences

            //Console.WriteLine("S01 : " + S01);
            //Console.WriteLine("S01HashCode : " + S01.GetHashCode());
            //Console.WriteLine();

            //S01.Append("Hassan");
            //Console.WriteLine("S01 : " + S01);
            //Console.WriteLine("S01HashCode : " + S01.GetHashCode());
            //// Refer To Same Reference

            #endregion

            #region String Methods
            //String S01 = "Hello World";
            //object result = new object();
            ////result = S01.ToCharArray();
            ////result = S01.ToUpper();
            ////result = S01.StartsWith('H');
            ////result = S01.ToLower();
            //Console.WriteLine(result);
            #endregion

        }
    }
}
