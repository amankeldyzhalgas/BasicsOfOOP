// <copyright file="SortByMaxOfNumbers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary
{
    /// <summary>
    /// Реализация алгоритма поиска максимального значения.
    /// </summary>
    public class SortByMaxOfNumbers : IStrategy
    {
        /// <summary>
        /// Метод возвращает максимальное значение в одномерном массиве.
        /// </summary>
        /// <param name="array">Массив.</param>0
        /// <returns>Число.</returns>
        public int? Algorithm(int[] array)
        {
            if (array is null)
            {
                return null;
            }

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }
    }
}
