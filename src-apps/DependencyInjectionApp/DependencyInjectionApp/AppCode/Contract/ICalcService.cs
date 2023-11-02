namespace DependencyInjectionApp.AppCode.Contract
{
    public interface ICalcService
    {
        int Sum(int a, int b);

        int Min(int a, int b);

        int Mul(int a, int b);

        int Div(int a, int b);

    }
}
