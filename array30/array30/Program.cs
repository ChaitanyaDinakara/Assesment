namespace array30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i, max, min, n;
            Console.WriteLine("enter the number of elements to be stored");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the number of elements is:", n);

            for (i = 0; i < arr.Length-1; i++)
            {
                Console.WriteLine("elements", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            min = arr[0];

            for (i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }

            Console.WriteLine("max element in the array is:{0}\n", max);
            Console.WriteLine("minimum element in the array is:{0}\n",min);
        }
    }
}