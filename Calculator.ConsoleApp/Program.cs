using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApp
{
    class Program {
        static readonly IFloatOperandsGetter FloatOperandsGetter = new FloatOperandsGetter();
        static readonly MathDoer AdditionDoer = new MathDoer(new Adder(), FloatOperandsGetter);
        static readonly MathDoer SubtractionDoer = new MathDoer(new Subtracter(), FloatOperandsGetter);
        static readonly MathDoer MultiplicationDoer = new MathDoer(new Multiplier(), FloatOperandsGetter);
        static readonly MathDoer DivisionDoer = new MathDoer(new Divider(), FloatOperandsGetter);
        static void Main(string[] args)
        {
            UserOptions.Intro(); //call Intro method from UserOptions class
        }

        public static void MathMachine(string operation) { //contains the main math for the MathMachine -- receives the operation as a result of user query

                if (string.Equals(operation, "add", StringComparison.InvariantCultureIgnoreCase)) //if user query results in "Add" or "add"
                {
                    AdditionDoer.Do();
                }
                else if (string.Equals(operation, "subtract", StringComparison.InvariantCultureIgnoreCase)) //if user query results in "Subtract" or "subtract"
                {
                    SubtractionDoer.Do();
            }
            else if (string.Equals(operation, "multiply", StringComparison.InvariantCultureIgnoreCase)) { //if user query results in "Multiply" or "multiply"
                MultiplicationDoer.Do();
            }
            else if (string.Equals(operation, "divide")) { //if user query results in "Divide" or "divide"
                DivisionDoer.Do();
            }

            if (!string.Equals(operation, "exit", StringComparison.InvariantCultureIgnoreCase)) {
                UserOptions.NewQuery(); //call NewQuery method in UserOptions class
            }
        }
    }

    public class UserOptions
    {
        private static string OptionsList = "Add, Subtract, Multiply, Divide, Exit";
        public static void Intro()
        {       //write UI
            Console.WriteLine("*************************************************");
            Console.WriteLine("            Hello. I am a Calculator.            ");
            Console.WriteLine("*************************************************");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please tell me what operation you would like to perform.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--> Options are:");
            Console.WriteLine(OptionsList);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--> Rules are:");
            Console.WriteLine("I am only capable of reading two numbers currently.");
            Console.WriteLine("Do not try to feed me more than two numbers");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("*************************************************");
            Query(); //call Query method
        }

        public static void Query(string prompt = "What do you want to do")
        {
            Console.WriteLine($"{prompt} [{OptionsList}]?");
            string operation = Console.ReadLine();
            Program.MathMachine(operation);
        }

        public static void NewQuery()
        {
            Query("What do you want to do now");
        }
    }

    public class Adder : IMathOperationPerformer
    {
        public float Perform(float operand1, float operand2)
        {
            return operand1 + operand2;
        }

        public string OperatorDisplay => "+";
    }

    public class Subtracter : IMathOperationPerformer
    {
        public float Perform(float operand1, float operand2)
        {
            return operand1 - operand2;
        }

        public string OperatorDisplay => "-";
    }

    public class Multiplier : IMathOperationPerformer
    {
        public float Perform(float operand1, float operand2)
        {
            return operand1 * operand2;
        }

        public string OperatorDisplay => "*";
    }

    public class Divider : IMathOperationPerformer
    {
        public float Perform(float operand1, float operand2)
        {
            return operand1 / operand2;
        }

        public string OperatorDisplay => "/";
    }
}