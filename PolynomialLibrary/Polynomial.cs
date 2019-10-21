// <copyright file="Polynomial.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace PolynomialLibrary
{
    using System;
    using System.Text;

    /// <summary>
    /// Класс содержит различные операции для полиномов.
    /// </summary>
    public class Polynomial : ICloneable, IEquatable<Polynomial>
    {
        private const double Epsilon = 0.001;
        private double[] polynomial = { };

        private int Degree { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        /// <param name="polynomial">
        /// Полином.
        /// </param>
        public Polynomial(params double[] polynomial)
        {
            if (polynomial == null)
            {
                throw new ArgumentNullException(nameof(polynomial));
            }

            this.Degree = polynomial.Length - 1;
            this.polynomial = new double[polynomial.Length];
            Array.Copy(polynomial, this.polynomial, polynomial.Length);
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        /// <param name="degree">
        /// Степень.
        /// </param>
        private Polynomial(int degree)
        {
            this.Degree = degree;
            this.polynomial = new double[this.Degree + 1];
        }

        /// <summary>
        /// Реализует возвращает элемент по указанному индексу.
        /// </summary>
        /// <param name="index"> Индекс.</param>
        public double this[int index]
        {
            get
            {
                if (this.Degree > this.polynomial.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.polynomial[index];
            }

            private set
            {
                if (index < 0 && index >= this.polynomial.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.polynomial[index] = value;
            }
        }

        /// <summary>
        /// Метод возвращает сумму полиномов.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <returns>Сумма полиномов.</returns>
        /// <exception cref="ArgumentNullException">Если один или оба аргумента имеют значение null.</exception>
        public static Polynomial operator +(Polynomial first, Polynomial second)
        {
            if (first is null || second is null)
            {
                throw new ArgumentNullException("Многочлен не может быть null");
            }

            int size = Math.Max(first.polynomial.Length, second.polynomial.Length);
            double[] resultPolynomial = new double[size];

            for (int i = 0; i < first.polynomial.Length; i++)
            {
                resultPolynomial[i] = first.polynomial[i];
            }

            for (int i = 0; i < second.polynomial.Length; i++)
            {
                resultPolynomial[i] += second.polynomial[i];
            }

            Polynomial result = new Polynomial(resultPolynomial);
            return result;
        }

        /// <summary>
        /// Метод возвращает разность полиномов.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <returns>Разность полиномов.</returns>
        /// <exception cref="ArgumentNullException">Если один или оба аргумента имеют значение null.</exception>
        public static Polynomial operator -(Polynomial first, Polynomial second)
        {
            if (!(first is null) && !(second is null))
            {
                return first + (-second);
            }

            throw new ArgumentNullException("Многочлен не может быть null");
        }

        /// <summary>Метод реализует унарный оператор минус.</summary>
        /// <param name="operand">Операнд.</param>
        /// <returns>Числовое отрицание полинома.</returns>
        public static Polynomial operator -(Polynomial operand)
        {
            if (operand is null)
            {
                throw new ArgumentNullException("Многочлен не может быть null!");
            }

            double[] array = new double[operand.polynomial.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = operand.polynomial[i] * -1;
            }

            return new Polynomial(array);
        }

        /// <summary>
        /// Метод возвращает результат умножения полиномов.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <returns>Результат умножение многочленов.</returns>
        /// <exception cref="ArgumentNullException">Если один или оба аргумента имеют значение null.</exception>
        public static Polynomial operator *(Polynomial first, Polynomial second)
        {
            if (first is null || second is null)
            {
                throw new ArgumentNullException("Многочлен не может быть null");
            }

            Polynomial result = new Polynomial(first.Degree + second.Degree);
            for (int i = 0; i <= first.Degree; i++)
            {
                for (int j = 0; j <= second.Degree; j++)
                {
                    result.polynomial[i + j] += first[i] * second[j];
                }
            }

            return result;
        }

        /// <summary>
        /// Метод позволяет сравнить два полинома на равенство.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <returns>Возвращает true, если они равны, и false, если нет.</returns>
        public static bool operator ==(Polynomial first, Polynomial second)
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            if (first is null || second is null)
            {
                return false;
            }

            if (first.Degree != second.Degree)
            {
                return false;
            }
            else
            {
                for (int i = 0; i <= first.Degree; i++)
                {
                    if (Math.Abs(first[i] - second[i]) >= Epsilon)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Метод позволяет сравнить два полинома на равенство.
        /// </summary>
        /// <param name="first">Первый полином.</param>
        /// <param name="second">Второй полином.</param>
        /// <returns>Возвращает false, если они равны, и true, если нет.</returns>
        public static bool operator !=(Polynomial first, Polynomial second) => !(first == second);

        /// <summary>
        /// Метод проверяет идентичность полиномов.
        /// </summary>
        /// <param name="obj">Полином.</param>
        /// <returns>Возвращает true, если они идентичны, и false, если нет.</returns>
        public bool Equals(Polynomial obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (this.polynomial.Length != obj.polynomial.Length)
            {
                return false;
            }

            return this == obj;
        }

        /// <summary>
        /// Метод возвращает строковое представление объекта.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i <= this.Degree; i++)
            {
                if (this[i] == 0 && i != 0)
                {
                    continue;
                }

                if (i == 0)
                {
                    sb.Append(this[i]);
                    continue;
                }

                if (this[i] > 0)
                {
                    sb.Append('+');
                }

                if (i == 1)
                {
                    sb.Append(this[i] + "x");
                    continue;
                }

                sb.Append(this[i] + "x^" + i);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Метод проверяет идентичность полиномов.
        /// </summary>
        /// <param name="obj">Полином.</param>
        /// <returns>Возвращает true, если они идентичны, и false, если нет.</returns>
        public override bool Equals(object obj) => this.Equals(new Polynomial((double[])obj));

        /// <summary>
        /// Метод вычисляет хэш-код для текущего объекта.
        /// </summary>
        /// <returns>Хэш-код.</returns>
        public override int GetHashCode()
        {
            int hashCode = 0;
            for (int i = 0; i <= this.Degree; i++)
            {
                hashCode += this[i].GetHashCode() * i.GetHashCode();
            }

            return hashCode;
        }

        /// <inheritdoc/>
        object ICloneable.Clone()
        {
            return this.Clone();
        }

        private Polynomial Clone()
        {
            return new Polynomial
            {
                polynomial = this.polynomial,
                Degree = this.Degree,
            };
        }
    }
}
