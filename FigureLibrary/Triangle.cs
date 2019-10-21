// <copyright file="Triangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FigureLibrary
{
    using System;

    /// <summary>
    /// Класс треугольник.
    /// </summary>
    public class Triangle : Figure
    {
        private double A { get; set; }

        private double B { get; set; }

        private double C { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Triangle"/>.
        /// </summary>
        /// <param name="a">Сторона а.</param>
        /// <param name="b">Сторона b.</param>
        /// <param name="c">Сторона c.</param>
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <inheritdoc/>
        public override double GetArea()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - this.A) * (p - this.B) * (p * this.C));
        }

        /// <inheritdoc/>
        public override double GetPerimeter()
        {
            return this.A + this.B + this.C;
        }
    }
}
