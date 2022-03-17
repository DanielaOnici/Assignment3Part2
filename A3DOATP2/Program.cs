using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3DOATP2
{
    class Program
    {



        static void Main(string[] args)
        {
            string a1, b1, c1, d1, Answer1;
            decimal a, b, c, d, Result;

            while (true)
            {

                Console.WriteLine("Select one of the numbers:\n1 - Add;\n2 - Subtract;\n3 - Divide;\n4 - Multiply;\n5 - End the program");
                Answer1 = Console.ReadLine();


                if (Answer1 == "1")
                {
                    while (true)
                    {
                        try 
                        {
                            Console.WriteLine("Input a number:");
                            a1 = Console.ReadLine();
                            a = decimal.Parse(a1);
                            Console.WriteLine("Input a number:");
                            b1 = Console.ReadLine();
                            b = decimal.Parse(b1);
                            Console.WriteLine("Input a number:");
                            c1 = Console.ReadLine();
                            c = decimal.Parse(c1);
                            Console.WriteLine("Input a number:");
                            d1 = Console.ReadLine();
                            d = decimal.Parse(d1);
                            Result = (a + b + c + d);
                            Console.WriteLine("The sum of the numbers is {0}", Result);
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Please, insert a number");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong");
                        }
                    }
                  
                }
                else if (Answer1 == "2")
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Input a number:");
                            a1 = Console.ReadLine();
                            a = decimal.Parse(a1);
                            Console.WriteLine("Input a number:");
                            b1 = Console.ReadLine();
                            b = decimal.Parse(b1);
                            Console.WriteLine("Input a number:");
                            c1 = Console.ReadLine();
                            c = decimal.Parse(c1);
                            Console.WriteLine("Input a number:");
                            d1 = Console.ReadLine();
                            d = decimal.Parse(d1);
                            Result = (a - c);
                            Console.WriteLine("The difference between the first and third number is {0}", Result);
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Please, insert a number");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong");
                        }
                    }

                }

                else if (Answer1 == "3")
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Input a number:");
                            a1 = Console.ReadLine();
                            a = decimal.Parse(a1);
                            Console.WriteLine("Input a number:");
                            b1 = Console.ReadLine();
                            b = decimal.Parse(b1);
                            Console.WriteLine("Input a number:");
                            c1 = Console.ReadLine();
                            c = decimal.Parse(c1);
                            Console.WriteLine("Input a number:");
                            d1 = Console.ReadLine();
                            d = decimal.Parse(d1);
                            Result = (d / (a + b));
                            Console.WriteLine("The quotient of the forth number by the sum of the first and second number is {0}", Result);
                            break;
                        }
                        catch (DivideByZeroException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Please, insert a number");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong");
                        }
                    }
                }

                else if (Answer1 == "4")
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Input a number:");
                            a1 = Console.ReadLine();
                            a = decimal.Parse(a1);
                            Console.WriteLine("Input a number:");
                            b1 = Console.ReadLine();
                            b = decimal.Parse(b1);
                            Console.WriteLine("Input a number:");
                            c1 = Console.ReadLine();
                            c = decimal.Parse(c1);
                            Console.WriteLine("Input a number:");
                            d1 = Console.ReadLine();
                            d = decimal.Parse(d1);
                            Result = a * c;
                            Console.WriteLine("The product of the first and third number is {0}", Result);
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.WriteLine("Please, insert a number");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong");
                        }
                    }

                }

                else if (Answer1 == "5")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Please select one of the options");
                }

            }
            } 
    }
}
