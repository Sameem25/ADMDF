using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTest
{
    [TestFixture]
    public class Class1
    {

        [Test]
        [TestCase(20,10,10)]
        [TestCase(50, 20, 30)]
        public void Subtraction(double a,double b,double er)
        {
            SimpleCalculator sc = new SimpleCalculator();
           double subResult =sc.Subtraction(a,b);
            
            Assert.AreEqual(subResult,er);

        }


        [Test]
        [TestCase(8,5, 40)]
        [TestCase(10, 10, 100)]
        public void Multiplication(double a, double b, double er)
        {
            SimpleCalculator sc = new SimpleCalculator();
            double multiplicationResult = sc.Multiplication(a, b);

            Assert.AreEqual(multiplicationResult, er);

        }

        [Test]
        [TestCase(10, 2, 5)]
        [TestCase(25, 5, 5)]
        [TestCase(36, 9, 4)]
        public void Division(double a, double b, double er)
        {
            SimpleCalculator sc = new SimpleCalculator();
            try
            {
                double DivisionResult = sc.Division(a, b);

                Assert.AreEqual(DivisionResult, er);
            }
            catch(Exception e)
            {
                Assert.Fail("Division by zero");

            }

        }

        [Test]
        [TestCase(80,20,100)]
        public void AddAndClear(double a, double b, double er)
        {
            SimpleCalculator sc = new SimpleCalculator();
            sc.Addition(a, b);

            Assert.AreEqual(sc.GetResult, er);

            sc.AllClear();


            Assert.AreEqual(sc.GetResult, 0);
        }
    }
}
