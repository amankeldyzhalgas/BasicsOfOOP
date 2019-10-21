// <copyright file="Rectangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FigureLibrary
{
    /// <summary>
    /// Класс прямоугольник.
    /// </summary>
    public class Rectangle : Figure
    {
        private double Width { get; set; }

        private double Height { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="width">Ширина.</param>
        /// <param name="height">Высота.</param>
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <inheritdoc/>
        public override double GetArea()
        {
            return this.Width * this.Height;
        }

        /// <inheritdoc/>
        public override double GetPerimeter()
        {
            return 2 * (this.Width + this.Height);
        }
    }
}
