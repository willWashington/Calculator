using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Calculator.ConsoleApp {
    public class FloatOperandsGetter {
        public float[] Get() { //declare a float array method named Get
            var o1 = Get("Operand1"); // get first operand
            var o2 = Get("Operand2"); // get second operand
            return new[] {o1, o2}; //return the two operands from the method
        }



        //Things I don't understand
            //it doesn't need to be public because only the Get() float array reaches out to it, right? it's only accessed from within this class
            //what is default(float?);
            //what does result.Value do?
            

        float Get(string prompt) { //declare a private method that takes in a string
            var result = default(float?); //result equals who the fuck knows
            while (!result.HasValue) { // check to see if the result has any value - read while the result has no value
                Console.Write($"{prompt}: "); //ask the user to enter operand 1 and operand 2
                var value = Console.ReadLine(); //value equals the response of the user
                if (float.TryParse(value, out var foo)) { //try to convert the user's response to a float and declare it as variable foo
                    result = foo; //if parse is successful, result = user response
                }
                else { 
                    Console.WriteLine("Invalid input."); //otherwise, tell user they are a scrub
                }
            }
            return result.Value; 
        }
    }
}