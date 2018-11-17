using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Calculator.ConsoleApp {
    public class FloatOperandsGetter {
        public float[] Get() {
            var o1 = Get("Operand1"); // get first operand
            var o2 = Get("Operand2"); // get second operand
            return new[] {o1, o2};
        }

        float Get(string prompt) {
            var result = default(float?);
            while (!result.HasValue) { // check to see if the 
                Console.Write($"{prompt}: ");
                var value = Console.ReadLine();
                if (float.TryParse(value, out var foo)) {
                    result = foo;
                }
                else {
                    Console.WriteLine("Invalid input.");
                }
            }
            return result.Value;
        }
    }
}