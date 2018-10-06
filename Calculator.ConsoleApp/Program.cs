using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApp
{
    class Program
    {     
        static void Main(string[] args)
        {
            var adder = new Adder();
            var answer = adder.Add(2, 2);
            Console.WriteLine(answer);
            Console.ReadKey(); //vs hack for pause
        }
    }

    public class Adder
    {
        public int Add(int operand1, int operand2)
        {
            return operand1 + operand2;
        }
    }
}