using NUnit.Framework;
using Kursovaya25;

namespace Kursovaya25.Tests
{
    /// <summary>
    /// Тесты для алгоритмов сортировки QuickSort и MergeSort.
    /// Оба сортируют массив WordEntry[] по убыванию Count.
    /// </summary>
    [TestFixture]
    public class SortAlgorithmsTests
    {
        //Вспомогательный метод
        private static WordEntry[] MakeEntries(params int[] counts)
        {
            var arr = new WordEntry[counts.Length];
            for (int i = 0; i < counts.Length; i++)
                arr[i] = new WordEntry { Word = "w" + i, Count = counts[i] };
            return arr;
        }

        private static bool IsDescending(WordEntry[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].Count > arr[i - 1].Count) return false;
            return true;
        }
        //  QUICKSORT
        //1. Корректность на типичных данных
        [Test]
        public void QuickSort_TypicalArray_SortedDescending()
        {
            var arr = MakeEntries(3, 1, 4, 1, 5, 9, 2, 6);
            SortAlgorithms.QuickSort(arr, 0, arr.Length - 1);
            Assert.That(IsDescending(arr), Is.True);
            Assert.That(arr[0].Count, Is.EqualTo(9));
        }

        //2. Граничный случай: один элемент
        [Test]
        public void QuickSort_SingleElement_NoException()
        {
            var arr = MakeEntries(42);
            Assert.DoesNotThrow(() => SortAlgorithms.QuickSort(arr, 0, arr.Length - 1));
            Assert.That(arr[0].Count, Is.EqualTo(42));
        }

        //3. Граничный случай: уже отсортированный массив
        [Test]
        public void QuickSort_AlreadySortedDescending_RemainsCorrect()
        {
            var arr = MakeEntries(10, 8, 6, 4, 2);
            SortAlgorithms.QuickSort(arr, 0, arr.Length - 1);
            Assert.That(IsDescending(arr), Is.True);
        }

        //4. Граничный случай: все элементы одинаковы
        [Test]
        public void QuickSort_AllEqualCounts_StaysValid()
        {
            var arr = MakeEntries(5, 5, 5, 5, 5);
            SortAlgorithms.QuickSort(arr, 0, arr.Length - 1);
            Assert.That(IsDescending(arr), Is.True);
        }

        //5. Большой объём данных
        [Test]
        [Timeout(3000)]
        public void QuickSort_LargeArray_CompletesAndSorted()
        {
            var rng = new System.Random(0);
            var arr = new WordEntry[10_000];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new WordEntry { Word = "w" + i, Count = rng.Next(1, 100_000) };

            SortAlgorithms.QuickSort(arr, 0, arr.Length - 1);
            Assert.That(IsDescending(arr), Is.True);
        }

        //6. Обратно отсортированный (худший случай для наивного pivot)
        [Test]
        public void QuickSort_ReverseSorted_CorrectResult()
        {
            var arr = MakeEntries(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            SortAlgorithms.QuickSort(arr, 0, arr.Length - 1);
            Assert.That(arr[0].Count, Is.EqualTo(10));
            Assert.That(IsDescending(arr), Is.True);
        }
        //  MERGESORT
        //1. Корректность на типичных данных
        [Test]
        public void MergeSort_TypicalArray_SortedDescending()
        {
            var arr = MakeEntries(3, 1, 4, 1, 5, 9, 2, 6);
            var result = SortAlgorithms.MergeSort(arr);
            Assert.That(IsDescending(result), Is.True);
            Assert.That(result[0].Count, Is.EqualTo(9));
        }

        //2. Граничный случай: пустой массив
        [Test]
        public void MergeSort_EmptyArray_ReturnsEmpty()
        {
            var arr = System.Array.Empty<WordEntry>();
            var result = SortAlgorithms.MergeSort(arr);
            Assert.That(result, Is.Empty);
        }

        //3. Граничный случай: один элемент
        [Test]
        public void MergeSort_SingleElement_ReturnsSameElement()
        {
            var arr = MakeEntries(7);
            var result = SortAlgorithms.MergeSort(arr);
            Assert.That(result.Length, Is.EqualTo(1));
            Assert.That(result[0].Count, Is.EqualTo(7));
        }

        //4. Все элементы одинаковы
        [Test]
        public void MergeSort_AllEqualCounts_AllPresent()
        {
            var arr = MakeEntries(3, 3, 3, 3);
            var result = SortAlgorithms.MergeSort(arr);
            Assert.That(result.Length, Is.EqualTo(4));
            Assert.That(IsDescending(result), Is.True);
        }

        //5. Большой объём данных
        [Test]
        [Timeout(3000)]
        public void MergeSort_LargeArray_CompletesAndSorted()
        {
            var rng = new System.Random(1);
            var arr = new WordEntry[10_000];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new WordEntry { Word = "w" + i, Count = rng.Next(1, 100_000) };

            var result = SortAlgorithms.MergeSort(arr);
            Assert.That(IsDescending(result), Is.True);
        }

        //6. Исходный массив не изменяется (MergeSort возвращает новый)
        [Test]
        public void MergeSort_DoesNotMutateOriginal()
        {
            var arr = MakeEntries(5, 3, 8, 1);
            int[] original = { 5, 3, 8, 1 };
            SortAlgorithms.MergeSort(arr);

            for (int i = 0; i < arr.Length; i++)
                Assert.That(arr[i].Count, Is.EqualTo(original[i]),
                    "MergeSort не должен изменять исходный массив");
        }

        //7. QuickSort и MergeSort дают одинаковый результат
        [Test]
        public void QuickSort_And_MergeSort_ProduceSameOrder()
        {
            int[] counts = { 7, 2, 9, 4, 1, 8, 3, 6, 5 };
            var arrQ = MakeEntries(counts);
            var arrM = MakeEntries(counts);

            SortAlgorithms.QuickSort(arrQ, 0, arrQ.Length - 1);
            var resultM = SortAlgorithms.MergeSort(arrM);

            for (int i = 0; i < arrQ.Length; i++)
                Assert.That(arrQ[i].Count, Is.EqualTo(resultM[i].Count),
                    $"Позиция {i}: QuickSort={arrQ[i].Count}, MergeSort={resultM[i].Count}");
        }
    }
}
