
namespace Arrays
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //var res = numbers.CountBy(n => n % 2 == 0);
            //Console.WriteLine("Count of even numbers: " + string.Join(", ", res));
            //var min = numbers.Min();
            ////numbers.ForEach(n =>
            ////{
            ////    Console.WriteLine(n);
            ////    return;
            ////});

            ////numbers.Sum();

            ////long maxi = long.MaxValue;
            ////int maximum = numbers[0];

            ////numbers.Sort((a,b) => b-a);
            ////Console.WriteLine("Sorted numbers in descending order: " + string.Join(", ", numbers));

            ////for (int i = 0; i < numbers.Count; i++)
            ////{
            ////    maximum = Math.Max(maximum, numbers[i]);
            ////    Console.WriteLine(numbers[i]);
            ////}


            int[] arr = new int[] { 1, 2, 2, 3, 3, 4, 5 };
            arr.IndexOf(3);
            //int mini = arr.Min();
            //arr.Contains(3);
            //////var sum = arr.Sum();
            //////Console.WriteLine("Sum of array elements: " + sum);

            //////HashSet<int> ints = [.. arr];
            //////Console.WriteLine("Unique elements in the array: " + string.Join(", ", ints));
            //////var val = arr.FirstOrDefault(x => x == 3);
            //////Console.WriteLine("First occurrence of 3 in the array: " + val);

            //////int[] array = new int[5];

            ////arr = [.. arr.Skip(1)];

            ////Console.WriteLine("Modfied Arr details " + string.Join(", ", arr));

            ////MyStack stack = new MyStack(5);
            ////stack.push(1);
            ////stack.push(2);
            ////stack.push(3);

            ////Console.WriteLine("Top element is: " + stack.peek());
            //TestStatic.TestMethod();
            //TestStatic.TestMethod();

            //var test = new TestBothConstructors();


            //HashSet<int> set = [];
            //set.Add(2);

            //set.Contains(2);

            //arr.Sort((a, b) => a-b);
            //Console.WriteLine("Binary search: " + Array.BinarySearch(arr, 2));

            //var p1 = new PartialClass.PartialClass();
            var p2 = new PartialClass.PartialClass("Hello");
            p2.Method1();
            //p2.Method2();
            p2.Method2();

            Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();

            int x = (int)Math.Ceiling(4/3*1.0);
        }
    }

    internal class TestBothConstructors
    {
        public TestBothConstructors()
        {
            Console.WriteLine("Instance Constructor");
        }
        static TestBothConstructors()
        {
            Console.WriteLine("Static Constructor");
        }
    }

    internal static class TestStatic
    {
        static TestStatic()
        {
            Console.WriteLine("Static Constructor");
        }
        public static void TestMethod()
        {
            Console.WriteLine("Test Method");
        }
    }

    class MyStack
    {

        private int[] StackArr;
        private int ArrLength;
        // Constructor
        public MyStack(int n)
        {
            // Define Data Structures
            StackArr = new int[n];
            ArrLength = n;
        }

        public bool isEmpty()
        {
            return StackArr.Length == 0;
        }

        public bool isFull()
        {
            return StackArr.Length == ArrLength;
        }

        public void push(int x)
        {
            if (isFull()) return;
            StackArr = [.. StackArr.Prepend(x)];
        }

        public void pop()
        {
            if (isEmpty()) return;
            StackArr = [.. StackArr.Skip(1)];

        }

        public int peek()
        {
            if (isEmpty()) return -1;
            return StackArr[0];
        }
    }
}