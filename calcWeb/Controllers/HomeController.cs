using calcWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using calc;

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
               new SelectListItem() {  Value = "multiplication", Text = "Деление" },
               new SelectListItem() {  Value = "division", Text = "Умножение" },
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
        public ActionResult Index(double x, double y, string operation)
        {
            double res;
            switch (operation)
            {
                case "sin":
                    Sincalc sin = new Sincalc();
                    res = sin.Calculate(x);
                    break;
                case "cos":
                    Coscalc cos = new Coscalc();
                    res = cos.Calculate(x);
                    break;
                case "tg":
                    Tgcalc tg = new Tgcalc();
                    res = tg.Calculate(x);
                    break;
                case "ctg":
                    Tgcalc ctg = new Tgcalc();
                    res = 1 / ctg.Calculate(x);
                    break;
                case "ln":
                    Lncalc ln = new Lncalc();
                    res = ln.Calculate(x);
                    break;
                case "lg":
                    Lgcalc lg = new Lgcalc();
                    res = lg.Calculate(x);
                    break;
                case "additional":
                    Additionalcalc add = new Additionalcalc();
                    res = add.Calculate(x, y);
                    break;
                case "subtraction":
                    Subtractioncalc sub = new Subtractioncalc();
                    res = sub.Calculate(x, y);
                    break;
                case "multiplication":
                    Multiplicationcalc mul = new Multiplicationcalc();
                    res =  mul.Calculate(x, y);
                    break;
                case "division":
                    Divisioncalc div = new Divisioncalc();
                    res = div.Calculate(x, y);
                    break;
                case "exponentation":
                    Exponentationcalc exp = new Exponentationcalc();
                    res = exp.Calculate(x, y);
                    break;
                case "logxy":
                    Logxycalc logxy = new Logxycalc();
                    res = logxy.Calculate(x, y);
                    break;
                default:
                    throw new NotImplementedException("Ошибка! Неизвестное действие");
            }
            ViewBag.Result = res;
            ViewBag.Operation = new SelectListItem[]
           {
               new SelectListItem() {  Value = "additional", Text = "Сложение" },
               new SelectListItem() {  Value = "subtraction", Text = "Вычитание" },
               new SelectListItem() {  Value = "multiplication", Text = "Деление" },
               new SelectListItem() {  Value = "division", Text = "Умножение" },
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