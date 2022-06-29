using System;

namespace calc {
    public static class TwoArgsCalc
    {
        public static double x, y;

        public static double TwoArgsEngine(string name)
        {
            switch (name)
            {
                case "additional":
                    Additionalcalc add = new Additionalcalc();
                    return add.Calculate(x, y);
                case "subtraction":
                    Subtractioncalc sub = new Subtractioncalc();
                    return sub.Calculate(x, y);
                case "multiplication":
                    Multiplicationcalc mul = new Multiplicationcalc();
                    return mul.Calculate(x, y);
                case "division":
                    Divisioncalc div = new Divisioncalc();
                    return div.Calculate(x, y);
                case "exponentation":
                    Exponentationcalc exp = new Exponentationcalc();
                    return exp.Calculate(x, y);
                case "logxy":
                    Logxycalc logxy = new Logxycalc();
                    return logxy.Calculate(x, y);
                default:
                    throw new Exception("Ошибка! Неизвестное действие");
            }
        }
    }
}