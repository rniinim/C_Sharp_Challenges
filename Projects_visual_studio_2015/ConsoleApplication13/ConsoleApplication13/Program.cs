using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            string noDivideByZero = "Enter an a value that isn't 0";
            txtSolution1.Text = noDivideByZero;
            txtSolution2.Text = noDivideByZero;

            decimal aValue = nmcA.Value;
            decimal bValue = nmcB.Value;
            decimal cValue = nmcC.Value;

            decimal solution1, solution2;
            string solution1String, solution2String;

            //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

            //Calculate discriminant
            decimal insideSquareRoot = (bValue * bValue) - 4 * aValue * cValue;

            if (insideSquareRoot < 0)
            {
                //No real solution
                solution1String = "No real solutions!";
                solution2String = "No real solutions!";

                txtSolution1.Text = solution1String;
                txtSolution2.Text = solution2String;
            }
            else if (insideSquareRoot == 0)
            {
                //One real solution
                decimal sqrtOneSolution = (decimal)Math.Sqrt((double)insideSquareRoot);
                solution1 = (-bValue + sqrtOneSolution) / (2 * aValue);
                solution2String = "No real solution!";

                txtSolution1.Text = solution1.ToString();
                txtSolution2.Text = solution2String;
            }
            else if (insideSquareRoot > 0)
            {
                //Two real solutions
                decimal sqrtTwoSolutions = (decimal)Math.Sqrt((double)insideSquareRoot);
                solution1 = (-bValue + sqrtTwoSolutions) / (2 * aValue);
                solution2 = (-bValue - sqrtTwoSolutions) / (2 * aValue);

                txtSolution1.Text = solution1.ToString();
                txtSolution2.Text = solution2.ToString();
            }
        }
    }
}
