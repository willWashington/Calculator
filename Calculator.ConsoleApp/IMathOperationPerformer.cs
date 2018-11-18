namespace Calculator.ConsoleApp {
    public interface IMathOperationPerformer {
        float Perform(float operand1, float operand2);
        string OperatorDisplay { get; }
    }
}