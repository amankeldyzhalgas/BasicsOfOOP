// <copyright file="SortBySumOfNumbers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary
{
    /// <summary>
    /// Реализация алгоритма поиска минимального значения.
    /// </summary>
    public class SortBySumOfNumbers : IStrategy
    {
        /// <summary>
        /// Метод возвращает сумму элементов в одномерном массиве.
        /// </summary>
        /// <param name="array">Массив.</param>0
        /// <returns>Сумма.</returns>
        public int? Algorithm(int[] array)
        {
            if (array is null)
            {
                return null;
            }

            int sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}
