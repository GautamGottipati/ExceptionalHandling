using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandling
{
    class Program
    {
        /// <summary>
        /// This program contains the basic implementations of Exception handling for calculator app
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double Operand1, Operand2;
            double Result = 0.00;
            char Operator;
            Console.WriteLine("This program allows you to perform an operation on two numbers");
            #region TRY BLOCK
            try
            {
                Console.Write("Enter a number: ");
                Operand1 = double.Parse(Console.ReadLine());
                Console.Write("Enter an operator: ");
                Operator = char.Parse(Console.ReadLine());
                Console.Write("Enter a number: ");
                Operand2 = double.Parse(Console.ReadLine());
                if (Operator != '+' &&
                    Operator != '-' &&
                    Operator != '*' &&
                    Operator != '/')
                    throw new Exception(Operator.ToString());
                if (Operator == '/') if (Operand2 == 0)
                        throw new DivideByZeroException("Division by zero is not allowed");

                switch (Operator)
                {
                    case '+':
                        Result = Operand1 + Operand2;
                        break;
                    case '-':
                        Result = Operand1 - Operand2;
                        break;
                    case '*':
                        Result = Operand1 * Operand2;
                        break;
                    case '/':
                        Result = Operand1 / Operand2;
                        break;
                    default:
                        Console.WriteLine("Bad Operation");
                        break;
                }
                Console.WriteLine("\n{0} {1} {2} = {3}", Operand1, Operator, Operand2, Result);
            }
            #endregion
            #region CATCH BLOCK
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nOperation Error: {0} is not a valid operator", ex.StackTrace);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
