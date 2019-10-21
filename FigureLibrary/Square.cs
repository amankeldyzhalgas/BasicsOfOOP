// <copyright file="Square.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FigureLibrary
{
    using System;

    /// <summary>
    /// Класс квадрат.
    /// </summary>
    public class Square : Figure
    {
        private double Side { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Square"/>.
        /// </summary>
        /// <param name="side">Стороны.</param>
        public Square(double side)
        {
            this.Side = side;
        }

        /// <inheritdoc/>
        public override double GetArea()
        {
            return Math.Pow(this.Side, 2);
        }

        /// <inheritdoc/>
        public override double GetPerimeter()
        {
            return 4 * this.Side;
        }
    }
}
