using System;
using DependencyInjectionApp.AppCode.Contract;

namespace DependencyInjectionApp.AppCode.Services
{
    public class SalaryService: ISalaryService
    {
        private readonly ICalcService _calcService;

        public SalaryService(ICalcService calcService)
        {
            _calcService= calcService;
        }

        public int Calc()
        {
            return _calcService.Sum(10, 20);
        }
    }
}
