﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class OneArgCalc
    {
        public static double ox;

        public static double OneArgEngine(string name)
        {
            switch (name)
            {
                case "sin":
                    Sincalc sin = new Sincalc();
                    return sin.Calculate(ox);
                case "cos":
                    Coscalc cos = new Coscalc();
                    return cos.Calculate(ox);
                case "tg":
                   Tgcalc tg = new Tgcalc();
                    return tg.Calculate(ox);
                case "ctg":
                    Tgcalc ctg = new Tgcalc();
                    return 1 / ctg.Calculate(ox);
                case "ln":
                    Lncalc ln = new Lncalc();
                    return ln.Calculate(ox);
                case "lg":
                    Lgcalc lg = new Lgcalc();
                    return lg.Calculate(ox);
                default:
                    throw new NotImplementedException("Ошибка! Неизвестное действие");
            }
        }
    }
}
