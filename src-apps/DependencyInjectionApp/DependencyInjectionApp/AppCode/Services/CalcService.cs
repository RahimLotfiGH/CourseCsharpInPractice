using DependencyInjectionApp.AppCode.Contract;

namespace DependencyInjectionApp.AppCode.Services
{
    public class CalcService : ICalcService
    {
        public int Sum(int a, int b) => a + b;

        public int Min(int a, int b) => a - b;

        public int Mul(int a, int b) => a * b;
        
        public int Div(int a, int b) => a / b;

    }
}
