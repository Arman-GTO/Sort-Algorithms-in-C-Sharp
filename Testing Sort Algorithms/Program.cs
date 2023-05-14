using Sort_Algorithms;

namespace Testing_Sort_Algorithms
{
    class Program
    {
        static void Main()
        {
            var watch = new System.Diagnostics.Stopwatch();
            var Sort = new Sorts();

            #region Initial Array
            Sort.NumArray = new int[] { 73, 57, 49, 99, 133, 20, 1 };   // expected: { 1, 20, 49, 57, 73, 99, 133 }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("  Unsoerted Array: { ");
            Console.Write(String.Join(", ", Sort.NumArray));
            Console.Write(" }\n\n");
            Console.CursorVisible = false;
            Console.ResetColor();
            #endregion

            #region Bubble Sort
            watch.Start();
            Console.Write("  Bubble Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.BubbleSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Selection Sort
            watch.Start();
            Console.Write("  Selection Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.SelectionSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Insertion Sort
            watch.Start();
            Console.Write("  Insertion Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.InsertionSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Merge Sort
            watch.Start();
            Console.Write("  Merge Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.MergeSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Quick Sort
            watch.Start();
            Console.Write("  Quick Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.QuickSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Shell Sort
            watch.Start();
            Console.Write("  Shell Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.ShellSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Counting Sort
            watch.Start();
            Console.Write("  Counting Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.CountingSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Radix Sort
            watch.Start();
            Console.Write("  Radix Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.RadixSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Bucket Sort
            watch.Start();
            Console.Write("  Bucket Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.BucketSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion

            #region Heap Sort
            watch.Start();
            Console.Write("  Heap Sorted Array: { ");
            Console.Write(String.Join(", ", Sort.HeapSort()));
            Console.Write(" }\n");
            watch.Stop();
            Console.WriteLine($"  Time: {watch.ElapsedTicks} ticks");
            watch.Reset();
            Console.ReadKey();
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(" ");
            Console.WriteLine("___________________________\n");
            #endregion
        }
    }
}