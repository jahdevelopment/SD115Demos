using Microsoft.AspNetCore.Mvc;

namespace SD115Demos.Controllers
{
    public class CalculatorController : Controller
    {
        private int _numberOne = 20;

        public int NumberOne { get { return _numberOne;} }

        private int _numberTwo = 10;

        public int NumberTwo { get { return _numberTwo;} }

        public int AddNumbers(int NumberOne, int NumberTwo)
        {
            int add = NumberOne + NumberTwo;

            return add;
        }

        public int SustractNumbers(int NumberOne, int NumberTwo)
        {
            int sustract = NumberOne - NumberTwo;

            return sustract;
        }

        public int MultiplyNumbers(int NumberOne, int NumberTwo)
        {
            int multiply = NumberOne * NumberTwo;

            return multiply;
        }

        public int DivideNumbers(int NumberOne, int NumberTwo)
        {
            int divide = NumberOne / NumberTwo;

            return divide;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Calc(int NumberOne,int NumberTwo)
        {
            //ViewBag.NumberOne = NumberOne;

            //ViewBag.NumberTwo = NumberTwo;

            ViewBag.Result1 = AddNumbers(NumberOne, NumberTwo);

            ViewBag.Result2 = SustractNumbers(NumberOne, NumberTwo);

            ViewBag.Result3 = MultiplyNumbers(NumberOne, NumberTwo);

            ViewBag.Result4 = DivideNumbers(NumberOne, NumberTwo);

            return View();
        }
    }
}
