// <copyright file="SortByMinOfNumbers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary
{
    /// <summary>
    /// Реализация алгоритма поиска минимального значения.
    /// </summary>
    public class SortByMinOfNumbers : IStrategy
    {
        /// <summary>
        /// Метод возвращает минимальное значение в одномерном массиве.
        /// </summary>
        /// <param name="array">Массив.</param>0
        /// <returns>Число.</returns>
        public int? Algorithm(int[] array)
        {
            if (array is null)
            {
                return null;
            }

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
    }
}
