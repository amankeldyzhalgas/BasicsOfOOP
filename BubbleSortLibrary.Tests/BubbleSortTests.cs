// <copyright file="BubbleSortTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BubbleSortLibrary.Tests
{
    using System.Collections;
    using NUnit.Framework;

    /// <summary>
    /// Тестовый класс для BubbleSort.
    /// </summary>
    public class BubbleSortTests
    {
        /// <summary>
        /// Метод тестирует сортировку в порядке возрастания сумм элементов строк матрицы.
        /// </summary>
        [TestCase]
        public void SortAscBySumOfNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer comparer = new BubbleSortLibrary.Comparer(new SortBySumOfNumbers(), true);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// Метод тестирует сортировку в порядке убывания сумм элементов строк матрицы.
        /// </summary>
        [TestCase]
        public void SortDescBySumOfNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 } };
            IComparer comparer = new BubbleSortLibrary.Comparer(new SortBySumOfNumbers(), false);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// Метод тестирует сортировку в порядке возрастания максимальных элементов строк матрицы.
        /// </summary>
        [TestCase]
        public void SortAscByMaxNumbersTestsTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 } };
            IComparer comparer = new BubbleSortLibrary.Comparer(new SortByMaxOfNumbers(), true);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// Метод тестирует сортировку в порядке убывания максимальных элементов строк матрицы.
        /// </summary>
        [TestCase]
        public void SortDescByMaxNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 7, 9, 2, 3 }, new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer comparer = new BubbleSortLibrary.Comparer(new SortByMaxOfNumbers(), false);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// Метод тестирует сортировку в порядке возрастания минимальных элементов строк матрицы.
        /// </summary>
        [TestCase]
        public void SortAscByMinNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 }, new int[] { 8, 3, 3, 7 } };
            IComparer comparer = new BubbleSortLibrary.Comparer(new SortByMinOfNumbers(), true);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }

        /// <summary>
        /// Метод тестирует сортировку в порядке убывания минимальных элементов строк матрицы.
        /// </summary>
        [TestCase]
        public void SortDescByMinNumbersTests()
        {
            int[][] arr = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 2, 6, 3, 7, 5, 1 }, new int[] { 7, 9, 2, 3 } };
            int[][] excepted = new int[][] { new int[] { 8, 3, 3, 7 }, new int[] { 7, 9, 2, 3 }, new int[] { 2, 6, 3, 7, 5, 1 } };
            IComparer comparer = new BubbleSortLibrary.Comparer(new SortByMinOfNumbers(), false);
            BubbleSort.Sort(arr, comparer);
            Assert.AreEqual(arr, excepted);
        }
    }
}