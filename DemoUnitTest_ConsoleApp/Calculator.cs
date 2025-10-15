namespace DemoUnitTest_ConsoleApp {
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public int Mul(int a, int b) => a * b;
        public double Div(int a, int b) => b != 0 ? (double)a / b : double.NaN;
    }
}

