namespace Moving_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            //each box is 1m x 1m * 1m

            int boxes = width * height * length;

            while (boxes >= 0)
            {
                String input = Console.ReadLine();
                if (input == "Done")
                    break;
                boxes -= int.Parse(input);
            }
            if (boxes >= 0)
            {
                Console.WriteLine($"{boxes} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {-boxes} Cubic meters more.");
            }
        }
    }
}