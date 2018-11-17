using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.ConsoleApp
{
    class Program {
        static void Main(string[] args)
        {
            UserOptions.Intro(); //call Intro method from UserOptions class
        }

        public static void MathMachine(string operation) { //contains the main math for the MathMachine -- receives the operation as a result of user query
            var floatOperandsGetter = new FloatOperandsGetter();

            #region Adder ------------------------------------------------------------------------------------------------------------------------------------------------
            if (string.Equals(operation, "add", StringComparison.InvariantCultureIgnoreCase)) //if user query results in "Add" or "add"
            {
                var floatOperands = floatOperandsGetter.Get();
                var adder = new Adder(); //create new instance of adder method
                var answer = adder.Add(floatOperands[0], floatOperands[1]); //push operand1 and operand2 variables to adder.Add method to add them together                    
                Console.WriteLine($"{floatOperands[0]} + {floatOperands[1]} = {answer}"); //provide user with equation and answer
                Console.WriteLine(Environment.NewLine); //create a new line
                #endregion

                #region Subtracter ------------------------------------------------------------------------------------------------------------------------------------------------
            }
            else if (string.Equals(operation, "subtract", StringComparison.InvariantCultureIgnoreCase)) //if user query results in "Subtract" or "subtract"
            {
                var floatOperands = floatOperandsGetter.Get();
                var adder = new Subtracter(); //create new instance of subtracter method
                var answer = adder.Subtract(floatOperands[0], floatOperands[1]); //push operand1 and operand2 variables to subtracter.Subtract method to find difference
                Console.WriteLine($"{floatOperands[0]} - {floatOperands[1]} = {answer}"); //provide user with equation and answer
                Console.WriteLine(Environment.NewLine); //create a new line
                #endregion

                #region Multiplier ------------------------------------------------------------------------------------------------------------------------------------------------
            }
            else if (string.Equals(operation, "multiply", StringComparison.InvariantCultureIgnoreCase)) { //if user query results in "Multiply" or "multiply"
                var floatOperands = floatOperandsGetter.Get();
                var adder = new Multiplier(); //create new instance of multiplier method
                var answer = adder.Multiply(floatOperands[0], floatOperands[1]); //push operand1 and operand2 variables to multiplier.Multiply
                Console.WriteLine($"{floatOperands[0]} x {floatOperands[1]} = {answer}"); //provide user with equation and answer
                Console.WriteLine(Environment.NewLine); //create a new line
                #endregion

                #region Divider ------------------------------------------------------------------------------------------------------------------------------------------------
            }
            else if (string.Equals(operation, "divide")) { //if user query results in "Divide" or "divide"
                var floatOperands = floatOperandsGetter.Get();
                var adder = new Divider(); //create new instance of the multiplier method
                var answer = adder.Divide(floatOperands[0], floatOperands[1]); //push operand1 and operand2 variables to divider.Divide
                Console.WriteLine($"{floatOperands[0]} / {floatOperands[1]} = {answer}"); //provide user with equation and answer
                Console.WriteLine(Environment.NewLine); //create a new line
            }

            if (!string.Equals(operation, "exit", StringComparison.InvariantCultureIgnoreCase)) {
                UserOptions.NewQuery(); //call NewQuery method in UserOptions class
            }

                #endregion
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

        public static void Query()
        {
            Console.WriteLine($"What do you want to do [{OptionsList}]?"); 
            string operation = Console.ReadLine();
            Program.MathMachine(operation);
        }

        public static void NewQuery()
        {
            Console.WriteLine($"What do you want to do now [{OptionsList}]?"); 
            string operation = Console.ReadLine();
            Program.MathMachine(operation);
        }
    }
    
    public class Adder
    {
        public float Add(float operand1, float operand2)
        {
            return operand1 + operand2;
        }        
    }

    public class Subtracter
    {
        public float Subtract(float operand1, float operand2)
        {
            return operand1 - operand2;
        }
    }

    public class Multiplier
    {
        public float Multiply(float operand1, float operand2)
        {
            return operand1 * operand2;
        }
    }

    public class Divider
    {
        public float Divide(float operand1, float operand2)
        {
            return operand1 / operand2;
        }
    }
}