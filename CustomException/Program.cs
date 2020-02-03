using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    /// <summary>
    /// Custom Exception handling
    /// The denomination should not be zero exception
    /// </summary>
    class MyException : ApplicationException
    {
        public void MyExceptiona()
        {
            Console.WriteLine("An exception occured");
        }
        public void MyDivideException()
        {
            Console.WriteLine("Exception occured, divisor should not be zero");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int d, div, res;
            div = Int32.Parse(Console.ReadLine());
            d = Int32.Parse(Console.ReadLine());
            #region TRY BLOCK
            try
            {
                if (div == 0)
                {
                    #region THROW
                    throw new MyException();
                    #endregion
                }
                else
                {
                    res = d / div;
                    Console.WriteLine("Result : {0}", res);
                }
            }
            #endregion
            #region CATCH BLOCK
            catch (MyException e)
            {
                e.MyDivideException();
            }
            #endregion
            Console.ReadKey();
        }
    }
}
