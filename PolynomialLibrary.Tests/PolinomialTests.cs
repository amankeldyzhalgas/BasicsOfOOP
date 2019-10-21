// <copyright file="PolinomialTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PolynomialLibrary.Tests
{
    using NUnit.Framework;

    /// <summary>
    /// Тестовый класс для Polinomial.
    /// </summary>
    public class PolinomialTests
    {
        /// <summary>
        /// Метод тестирует оператор +.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <param name="expected">Ожидаемы результат.</param>
        [TestCase(new double[] { 4, 4.2, 4, 4 }, new double[] { 3, 3, 3, 3.3 }, new double[] { 7, 7.2, 7, 7.3 })]
        [TestCase(new double[] { 1, 2, -1.5, -8.5, 3, 4 }, new double[] { 1, 2, 3, 4 }, new double[] { 2, 4, 1.5, -4.5, 3, 4 })]
        [TestCase(new double[] { 4, 4.2, 4, 4, 7.8, 7, 9 }, new double[] { 3, 3, 3, 3.3 }, new double[] { 7, 7.2, 7, 7.3, 7.8, 7, 9 })]
        public void PlusOperatorTests(double[] first, double[] second, double[] expected)
        {
            Polynomial p1 = new Polynomial(first);
            Polynomial p2 = new Polynomial(second);
            Polynomial exp = new Polynomial(expected);
            Assert.AreEqual(p1 + p2, exp);
        }

        /// <summary>
        /// Метод тестирует оператор -.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <param name="expected">Ожидаемы результат.</param>
        [TestCase(new double[] { 4, 4.2, 4, 4 }, new double[] { 3, 3, 3, 3.3 }, new double[] { 1, 1.2, 1, 0.7 })]
        [TestCase(new double[] { 4, 4.2, 4, 4 }, new double[] { 3, 3, 3, 3.3, 7.8, 7, 9 }, new double[] { 1, 1.2, 1, 0.7, -7.8, -7, -9 })]
        [TestCase(new double[] { 1, 2, 3, 4, 5, 9 }, new double[] { 1, 2, 3, 4 }, new double[] { 0, 0, 0, 0, 5, 9 })]
        [TestCase(new double[] { 1.204, -2.569, 3.987, 4.879, -0.896, 9 }, new double[] { 1, -2, -3, 4 }, new double[] { 0.204, -0.569, 6.987, 0.879, -0.896, 9 })]
        public static void MinusOperatorTests(double[] first, double[] second, double[] expected)
        {
            Polynomial p1 = new Polynomial(first);
            Polynomial p2 = new Polynomial(second);
            Polynomial exp = new Polynomial(expected);
            Assert.AreEqual(p1 - p2, exp);
        }

        /// <summary>
        /// Метод тестирует оператор *.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <param name="expected">Ожидаемы результат.</param>
        [TestCase(new double[] { 1, 2, 3, 4 }, new double[] { 1, 2, 3, 4 }, new double[] { 1, 4, 10, 20, 25, 24, 16 })]
        [TestCase(new double[] { 4, 4.2, 4, 4 }, new double[] { 3, 3, 3, 3.3 }, new double[] { 12, 24.6, 36.6, 49.8, 37.86, 25.2, 13.2 })]
        [TestCase(new double[] { 4, 4.2, 4, 4 }, new double[] { 3, 3, 3, 3.3, 7.8, 7, 9 }, new double[] { 12, 24.6, 36.6, 49.8, 69.06, 85.96, 109.8, 97, 64, 36 })]
        [TestCase(new double[] { 1, 2, 3, 4 }, new double[] { 1, 2 }, new double[] { 1, 4, 7, 10, 8 })]
        [TestCase(new double[] { -0.251, 0.652, -0.983, 4.11 }, new double[] { -89.23, 0.1278, 0.9873 }, new double[] { 22.396700, -58.2100, 87.548600, -366.21700, -0.4452002, 4.0578 })]
        public static void MultiplyOperatorTests(double[] first, double[] second, double[] expected)
        {
            Polynomial p1 = new Polynomial(first);
            Polynomial p2 = new Polynomial(second);
            Polynomial p3 = new Polynomial(expected);
            Assert.AreEqual(p1 * p2, p3);
        }

        /// <summary>
        /// Метод тестирует оператор ==.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <param name="expected">Ожидаемы результат.</param>
        [TestCase(new double[] { 5.023, 3.08, 3.09, 2.1 }, new double[] { 5.023, 3.08, 3.09, 2.1 }, true)]
        [TestCase(new double[] { 4, 4, 4, 2 }, new double[] { 2, 4, 2, 4 }, false)]
        [TestCase(new double[] { 2, 4, 0, -1, 1.56, -0.00020 }, new double[] { 2, 4, 0, -1, 1.56, -0.00019 }, true)]
        [TestCase(new double[] { 2, 4, 0, -1, 1.56, -0.20 }, new double[] { 2, 4, 0, -1, 1.56, -0.19 }, false)]
        public void EqualsOperatorTests(double[] first, double[] second, bool expected)
        {
            Polynomial p1 = new Polynomial(first);
            Polynomial p2 = new Polynomial(second);
            Assert.AreEqual(expected, p1 == p2);
        }

        /// <summary>
        /// Метод тестирует оператор !=.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <param name="expected">Ожидаемы результат.</param>
        [TestCase(new double[] { 1, 2, 3, 4, 0, -1, 1.56, -0.001 }, new double[] { 1, 2, 3, 4, 0, -1, 1.56, -0.001 }, false)]
        [TestCase(new double[] { 5.023, 3.08, 3.09, 2.1 }, new double[] { 5.023, 3.08, 3.09, 2.1 }, false)]
        [TestCase(new double[] { 4, 4, 4, 2 }, new double[] { 2, 4, 2, 4 }, true)]
        public void NotEqualsOperatorTests(double[] first, double[] second, bool expected)
        {
            Polynomial p1 = new Polynomial(first);
            Polynomial p2 = new Polynomial(second);
            Assert.AreEqual(expected, p1 != p2);
        }

        /// <summary>
        /// Метод тестирует идентичность полиномов.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <returns>Возвращает true, если они идентичны, и false, если нет.</returns>
        [TestCase(new double[] { 2, 4, 0, -1, 1.56, -0.001 }, new double[] { 2, 4, 0, -1, 1.56, -0.001 }, ExpectedResult = true)]
        [TestCase(new double[] { 2, 4, 0, -1, 1.56, -0.00020 }, new double[] { 2, 4, 0, -1, 1.56, -0.00019 }, ExpectedResult = true)]
        [TestCase(new double[] { 2, 4, 0, -1, 1.56, -0.20 }, new double[] { 2, 4, 0, -1, 1.56, -0.19 }, ExpectedResult = false)]
        [TestCase(new double[] { 2, 4, 0, -1, 1.56, -0.001 }, new double[] { 2, 4, 0, -1, 1.56, -0.001 }, ExpectedResult = true)]
        public static bool EqualsTests(double[] first, double[] second)
        {
            Polynomial p1 = new Polynomial(first);
            object p2 = second;
            return p1.Equals(p2);
        }

        /// <summary>
        /// Метод тестирует ToString().
        /// </summary>
        /// <param name="array">Полином.</param>
        /// <returns>Строковое представление.</returns>
        [TestCase(new double[] { 2, 4, 0, -1, 1.56, -0.001 }, ExpectedResult = "2+4x-1x^3+1,56x^4-0,001x^5")]
        public static string ToStringTests(double[] array)
        {
            Polynomial p1 = new Polynomial(array);
            return p1.ToString();
        }
    }
}