namespace Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num; // accumulate the total sum of all the numbers

                if (num > max)
                {
                    max = num; // remember the biggest number from all the input
                }
            }
            sum -= max; // take out the biggest number, so that we can compare

            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                int diff = Math.Abs(sum - max); // the absolute difference between sum and max
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }

        }
    }
}