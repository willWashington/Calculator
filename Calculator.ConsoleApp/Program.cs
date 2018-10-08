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
            UserOptions.Intro(); //call floatro method from UserOptions class
        }

        public static void MathMachine(string operation) { //contains the main math for the MathMachine -- receives the operation as a result of user query

            #region Adder ------------------------------------------------------------------------------------------------------------------------------------------------
            if (operation == "Add" || operation == "add") //if user query results in "Add" or "add"
            {
                Console.WriteLine("Operand1: "); //ask for first number
                var o1 = Console.ReadLine(); //record first number as o1
                Console.WriteLine("Operand2: "); //ask for second number
                var o2 = Console.ReadLine(); //record second number as o2
                if (float.TryParse(o1, out float operand1) && (float.TryParse(o2, out float operand2))) //try to convert the number to a string
                {
                    var adder = new Adder(); //create new instance of adder method
                    var answer = adder.Add(operand1, operand2); //push operand1 and operand2 variables to adder.Add method to add them together                    
                    Console.WriteLine($"{operand1} + {operand2} = {answer}"); //provide user with equation and answer
                    Console.WriteLine(Environment.NewLine); //create a new line
                    UserOptions.NewQuery(); //call NewQuery method in UserOptions class
                }
                else //if cannot parse float to string
                {
                    Console.WriteLine("Bad Input"); //tell user bad input
                    UserOptions.NewQuery(); //call NewQuery method in UserOptions class
                }
                //Console.ReadKey(); //vs hack for pause ::NOTE::
                //test
                #endregion

                #region Subtracter ------------------------------------------------------------------------------------------------------------------------------------------------
            }
            else if (operation == "Subtract" || operation == "subtract") //if user query results in "Subtract" or "subtract"
            {
                Console.WriteLine("Operand1: "); //line 21
                var o1 = Console.ReadLine(); //line 22
                Console.WriteLine("Operand2: "); //line 23
                var o2 = Console.ReadLine(); //line 24
                if (float.TryParse(o1, out float operand1) && (float.TryParse(o2, out float operand2))) //line 25
                {
                    var adder = new Subtracter(); //create new instance of subtracter method
                    var answer = adder.Subtract(operand1, operand2); //push operand1 and operand2 variables to subtracter.Subtract method to find difference
                    Console.WriteLine($"{operand1} - {operand2} = {answer}"); //provide user with equation and answer
                    Console.WriteLine(Environment.NewLine); //create a new line
                    UserOptions.NewQuery(); //call NewQUery method in UserOptions class
                }
                else //if acnnot parse float to string
                {
                    Console.WriteLine("Bad Input"); //tell user bad input
                    UserOptions.NewQuery(); //call NewQuery method in UserOptions class
                }
                #endregion

                #region Multiplier ------------------------------------------------------------------------------------------------------------------------------------------------
            }
            else if (operation == "Multiply" || operation == "multiply") { //if user query results in "Multiply" or "multiply"
                Console.WriteLine("Operand1: "); //line 21
                var o1 = Console.ReadLine(); //line 22
                Console.WriteLine("Operand2: "); //line 23
                var o2 = Console.ReadLine(); //line 24
                if (float.TryParse(o1, out float operand1) && (float.TryParse(o2, out float operand2))) //line25
                {
                    var adder = new Multiplier(); //create new instance of multiplier method
                    var answer = adder.Multiply(operand1, operand2); //push operand1 and operand2 variables to multiplier.Multiply
                    Console.WriteLine($"{operand1} x {operand2} = {answer}"); //provide user with equation and answer
                    Console.WriteLine(Environment.NewLine); //create a new line
                    UserOptions.NewQuery(); //call NewQuery method in UserOptions class
                }
                else //if cannot parse float to string
                {
                    Console.WriteLine("Bad Input"); //tell user bad input
                    UserOptions.NewQuery(); //call NewQuery method in UserOptions class
                }
                #endregion

                #region Divider ------------------------------------------------------------------------------------------------------------------------------------------------
            }
            else if (operation == "Divide" || operation == "divide") { //if user query results in "Divide" or "divide"
                Console.WriteLine("Operand1: "); //line 21
                var o1 = Console.ReadLine(); //line 22
                Console.WriteLine("Operand2: "); //line 23
                var o2 = Console.ReadLine(); //line 24
                if (float.TryParse(o1, out float operand1) && (float.TryParse(o2, out float operand2))) //line 25
                {
                    var adder = new Divider(); //create new instance of the multiplier method
                    var answer = adder.Divide(operand1, operand2); //push operand1 and operand2 variables to divider.Divide
                    Console.WriteLine($"{operand1} / {operand2} = {answer}"); //provide user with equation and answer
                    Console.WriteLine(Environment.NewLine); //create a new line
                    UserOptions.NewQuery(); //call NewQuery method in UserOptions class
                }
                else //if cannot parse float to string
                {
                    Console.WriteLine("Bad Input"); //tell user bad input
                    UserOptions.NewQuery(); //call NewQuery method in UserOptions class
                }
            }

                #endregion
        }
    }

    public class UserOptions
    {
        public static void Intro()
        {       //write UI
            Console.WriteLine("*************************************************");
            Console.WriteLine("            Hello. I am a Calculator.            ");
            Console.WriteLine("*************************************************");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Please tell me what operation you would like to perform.");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("--> Options are:");
            Console.WriteLine("Add, Subtract, Multiply, Divide, Exit");
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
            Console.WriteLine("What do you want to do?"); 
            string operation = Console.ReadLine();
            Program.MathMachine(operation);
        }

        public static void NewQuery()
        {
            Console.WriteLine("What do you want to do now?");
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