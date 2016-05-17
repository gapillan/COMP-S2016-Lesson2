using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author Name: Pamela Apillanes 
 * Date: May 17th, 2016
 * Date Modified: May 17th, 2016
 * Description: Advance Methods Demo for Lesson 2 
 * Version: 0.0.4 - Added addYtoX method and associated test 
 */


namespace COMP_S2016_Lesson2
{
    /**
    * Main driver class for Lesson 2 
    * 
    * @class Program 
    */
    public class Program
    {
        /**
         * Main method for our drive class 
         * 
         * @constructor Main 
         * @param {string[]} args 
         * 
         */

        static void Main(string[] args)
        {
            int x = 50;
            int y = 40;
            int result = 0;

            result = addXandY(x, y);
            Console.WriteLine(result);
            Console.WriteLine();

            addYtoX(ref x, ref y);

            Console.WriteLine(x);
        }

        /**
         * simple method to add two values 
         * 
         * @method addXandY
         * @param {int} firstNumber 
         * @param {int} secondNumber
         */

        public static int addXandY(int firstNumber, int secondNumber) 
        {
            int result = 0;
            result = firstNumber + secondNumber;
            return result;
        }

        /**
         * simple method to demonstrate pass by reference  with ref keyword 
         * 
         * @method addYtoX
         * @param {ref int} X 
         * @param {ref int} Y
         */
        public static int addYtoX(ref int X, ref int Y) 
        {
            X += Y;
            return X;
        }

    }
}
