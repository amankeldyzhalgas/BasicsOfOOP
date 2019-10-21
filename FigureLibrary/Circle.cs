// <copyright file="Circle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FigureLibrary
{
    using System;

    /// <summary>
    ///  Класс круг.
    /// </summary>
    public class Circle : Figure
    {
        private double Radius { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Circle"/>.
        /// </summary>
        /// <param name="radius">Радиус.</param>
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        /// <inheritdoc/>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        /// <inheritdoc/>
        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }
    }
}
