using calcWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using static calc.TwoArgsCalc;
using static calc.OneArgCalc;

namespace calcWeb.Controllers
{
    public class HomeController : Controller
    {
        private double formX = 0, formY = 0;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            ViewBag.Operation = new SelectListItem[]
            {
               new SelectListItem() {  Value = "additional", Text = "Сложение" },
               new SelectListItem() {  Value = "subtraction", Text = "Вычитание" },
               new SelectListItem() {  Value = "multiplication", Text = "Умножение" },
               new SelectListItem() {  Value = "division", Text = "Деление" },
               new SelectListItem() {  Value = "exponentation", Text = "Степень" },
               new SelectListItem() {  Value = "logxy", Text = "Логарфим" },
               new SelectListItem() {  Value = "lg", Text = "Десятичный логарифм" },
               new SelectListItem() {  Value = "ln", Text = "Натуральный логарифм" },
               new SelectListItem() {  Value = "ctg", Text = "Котангнегс" },
               new SelectListItem() {  Value = "tg", Text = "Тангенс" },
               new SelectListItem() {  Value = "cos", Text = "Косинус" },
               new SelectListItem() {  Value = "sin", Text = "Синус" }
            };
            ViewBag.X = "";
            ViewBag.Y = "";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string sx, string sy, string operation)
        {
            try
            {
                formX = Convert.ToDouble(sx);
                formY = Convert.ToDouble(sy);
            }
            catch (FormatException)
            {
                ViewBag.Result = "Ошибка!";
            }

            ViewBag.Result = CalcEngine(operation);
            ViewBag.X = formX.ToString();
            ViewBag.Y = formY.ToString();
            ViewBag.Operation = new SelectListItem[]
            {
               new SelectListItem() {  Value = "additional", Text = "Сложение" },
               new SelectListItem() {  Value = "subtraction", Text = "Вычитание" },
               new SelectListItem() {  Value = "multiplication", Text = "Умножение" },
               new SelectListItem() {  Value = "division", Text = "Деление" },
               new SelectListItem() {  Value = "exponentation", Text = "Степень" },
               new SelectListItem() {  Value = "logxy", Text = "Логарфим" },
               new SelectListItem() {  Value = "lg", Text = "Десятичный логарифм" },
               new SelectListItem() {  Value = "ln", Text = "Натуральный логарифм" },
               new SelectListItem() {  Value = "ctg", Text = "Котангнегс" },
               new SelectListItem() {  Value = "tg", Text = "Тангенс" },
               new SelectListItem() {  Value = "cos", Text = "Косинус" },
               new SelectListItem() {  Value = "sin", Text = "Синус" }
            };
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string CalcEngine(string name)
        {
            double result = double.PositiveInfinity;

            if (Checkerror(name)) return "Ошибка!";
            else
            {
                x = formX;
                y = formY;
                result = Math.Round(TwoArgsEngine(name), 4);
                if (result == double.NegativeInfinity)
                {
                    ox = x;
                    result = Math.Round(OneArgEngine(name), 4);
                    if (result == double.NegativeInfinity)
                    {
                        return "Ошибка!";
                    }
                }
            }
            return Convert.ToString(result);
        }

        private bool Checkerror(string name)
        {
            if ((name == "division" && formY == 0) || (name == "logxy" && (formX <= 0 || formY <= 0 || formX == 1)) || ((name == "ln" || name == "lg") && formX <= 0))
            {
                return true;
            }
            else if (name == "ctg" && OneArgEngine("sin") == 0) return true;
            else if (name == "tg" && OneArgEngine("cos") == 0) return true;
            else if (x == double.PositiveInfinity) return true;
            else return false;
        }
    }
}