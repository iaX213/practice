using NUnit.Framework;
using System;

namespace calc.tests
{
    public class Tests
    {
        const double EXP = 2.7182818284590452353602874713527;
        const double PI = Math.PI;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        // Тесты функций двух аргументов

        [TestCase(2, 2, 4)]
        [TestCase(5, 3, 8)]
        [TestCase(15, -20, -5)]
        public void AdditionalTest(double x, double y, double res)
        {
            double testres;

            Additionalcalc add = new Additionalcalc();
            testres = add.Calculate(x, y);
            Assert.AreEqual(testres, res);
        }

        [TestCase(2, 2, 0)]
        [TestCase(5, 3, 2)]
        [TestCase(15, 20, -5)]
        public void SubtractionTest(double x, double y, double res)
        {
            double testres;

            Subtractioncalc sub = new Subtractioncalc();
            testres = sub.Calculate(x, y);
            Assert.AreEqual(testres, res);
        }

        [TestCase(2, 2, 4)]
        [TestCase(5, 3, 15)]
        [TestCase(0, 2, 0)]
        public void MultiplicationTest(double x, double y, double res)
        {
            double testres;

            Multiplicationcalc mul = new Multiplicationcalc();
            testres = mul.Calculate(x, y);
            Assert.AreEqual(testres, res);
        }

        [TestCase(2, 2, 1)]
        [TestCase(15, 3, 5)]
        [TestCase(5, 2, 2.5)]
        public void DivisionTest(double x, double y, double res)
        {
            double testres;

            Divisioncalc div = new Divisioncalc();
            testres = div.Calculate(x, y);
            Assert.AreEqual(testres, res);
        }

        [TestCase(2, 2, 4)]
        [TestCase(5, 3, 125)]
        [TestCase(2, 0, 1)]
        public void ExponentationTest(double x, double y, double res)
        {
            double testres;

            Exponentationcalc exp = new Exponentationcalc();
            testres = exp.Calculate(x, y);
            Assert.AreEqual(testres, res);
        }

        [TestCase(2, 8, 3)]
        [TestCase(2, 1, 0)]
        [TestCase(10, 100, 2)]
        public void Logxytest(double x, double y, double res)
        {
            double testres;

            Logxycalc log = new Logxycalc();
            testres = log.Calculate(x, y);
            Assert.AreEqual(testres, res);
        }



        // Тесты функций одгого аргумента

        [TestCase(100, 2)]
        [TestCase(1000, 3)]
        [TestCase(1, 0)]
        public void LgTest(double x, double res)
        {
            double testres;

            Lgcalc lg = new Lgcalc();
            testres = lg.Calculate(x);
            Assert.AreEqual(testres, res);     
        }

        [TestCase(EXP * EXP * EXP, 3)]
        [TestCase(EXP, 1)]
        [TestCase(1, 0)]
        public void LnTest(double x, double res)
        {
            double testres;

            Lncalc ln = new Lncalc();
            testres = ln.Calculate(x);
            Assert.AreEqual(testres, res);
        }

        [TestCase(PI/2, 0)]
        [TestCase(PI/4, 1)]
        [TestCase(3 * PI / 2, 0)]
        public void CtgTest(double x, double res)
        {
            double testres;

            Tgcalc ctg = new Tgcalc();
            testres = Math.Round(1 / ctg.Calculate(x), 4);
            Assert.AreEqual(testres, res);
        }

        [TestCase(PI , 0)]
        [TestCase(PI / 4, 1)]
        [TestCase(2 * PI , 0)]
        public void TgTest(double x, double res)
        {
            double testres;

            Tgcalc tg = new Tgcalc();
            testres = Math.Round(tg.Calculate(x), 4);
            Assert.AreEqual(testres, res);
        }

        [TestCase(PI / 2, 0)]
        [TestCase(PI, -1)]
        [TestCase(0, 1)]
        public void CosTest(double x, double res)
        {
            double testres;

            Coscalc cos = new Coscalc();
            testres = Math.Round(cos.Calculate(x), 4);
            Assert.AreEqual(testres, res);
        }

        [TestCase(PI / 2, 1)]
        [TestCase(PI, 0)]
        [TestCase(PI / 6, 0.5)]
        public void SinTest(double x, double res)
        {
            double testres;

            Sincalc sin = new Sincalc();
            testres = Math.Round(sin.Calculate(x), 4);
            Assert.AreEqual(testres, res);
        }
    }
}