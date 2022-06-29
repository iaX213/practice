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
            return View();
        }

        [HttpPost]
        public ActionResult Index(string sx, string sy, string operation)
        {
            double res, x, y;
            try
            {
                x = Convert.ToDouble(sx);
                y = Convert.ToDouble(sy);
            }
            catch (FormatException)
            {
                ViewBag.Result = "Ошибка!";
                x = double.PositiveInfinity;
                y = double.PositiveInfinity; 
            }

            ox = x;
            if (
            (operation == "division" && y == 0) ||
            (operation == "logxy" && (x <= 0 || y <= 0 || x == 1)) ||
            ((operation == "ln" || operation == "lg") && x <= 0)
            ) ViewBag.Result = "Ошибка! Недопустимое значение";
            else if (operation == "ctg" && OneArgEngine("sin") == 0) ViewBag.Result = "Ошибка! Недопустимое значение";
            else if (operation == "tg" && OneArgEngine("cos") == 0) ViewBag.Result = "Ошибка! Недопустимое значение";
            else if (x == double.PositiveInfinity) ViewBag.Result = "Ошибка! Введены неверные данные";
            else
            {
                try
                {
                    calc.TwoArgsCalc.x = x;
                    calc.TwoArgsCalc.y = y;
                    res = Math.Round(TwoArgsEngine(operation), 4);
                }
                catch (Exception)
                {
                    ox = x;
                    res = Math.Round(OneArgEngine(operation), 4);
                }
                ViewBag.Result = res;
            }

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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}