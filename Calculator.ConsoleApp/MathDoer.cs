using System;

namespace Calculator.ConsoleApp {
    public class MathDoer {
        private readonly IMathOperationPerformer _mathOperationPerformer;
        private readonly IFloatOperandsGetter _floatOperandsGetter;
        public MathDoer(IMathOperationPerformer mathOperationPerformer, IFloatOperandsGetter floatOperandsGetter) {
            _mathOperationPerformer = mathOperationPerformer;
            _floatOperandsGetter = floatOperandsGetter;
        }

        public void Do() {
            var floatOperands = _floatOperandsGetter.Get();
            var answer = _mathOperationPerformer.Perform(floatOperands[0], floatOperands[1]); //push operand1 and operand2 variables to math performer
            Console.WriteLine($"{floatOperands[0]} {_mathOperationPerformer.OperatorDisplay} {floatOperands[1]} = {answer}"); //provide user with equation and answer
            Console.WriteLine(Environment.NewLine); //create a new line
        }
    }
}