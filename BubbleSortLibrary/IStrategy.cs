// <copyright file="IStrategy.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary
{
    /// <summary>
    /// Интерфейс  для паттерна "Strategy".
    /// </summary>
    public interface IStrategy
    {
        /// <summary>
        /// Этот метод реализует определенный алгоритм.
        /// </summary>
        /// <param name="array">Массив.</param>
        /// <returns>Число для сравнении.</returns>
        int? Algorithm(int[] array);
    }
}
