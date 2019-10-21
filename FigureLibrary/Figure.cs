// <copyright file="Figure.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FigureLibrary
{
    /// <summary>
    /// Класс фигур.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Метод возвращает площадь фигуры.
        /// </summary>
        /// <returns>Площадь.</returns>
        public abstract double GetArea();

        /// <summary>
        /// Метод возвращает периметр фигуры.
        /// </summary>
        /// <returns>Периметр.</returns>
        public abstract double GetPerimeter();
    }
}
