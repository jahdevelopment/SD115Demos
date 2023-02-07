using Microsoft.AspNetCore.Mvc;
using System.Reflection.Emit;

namespace SD115Demos.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Add(int operandOne, int operandTwo)
        {
            ViewBag.Outcome = operandOne + operandTwo;
            return View("Result");
        }

        public IActionResult Substract(int operandOne, int operandTwo)
        {
            ViewBag.Outcome = operandOne - operandTwo;
            return View("Result");  
        }

        public IActionResult Product(int operandOne, int operandTwo)
        {
            ViewBag.Outcome = operandOne * operandTwo;
            return View("Result");
        }

        public IActionResult Divide(int operandOne, int operandTwo) 
        {
            ViewBag.Outcome = operandOne / operandTwo;
            return View("Result");
        }
        
    }
}
