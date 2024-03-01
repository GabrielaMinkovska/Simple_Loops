namespace Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int counter = 0;
            bool isBookfound = false;

            string nextBook = Console.ReadLine();

            while (nextBook != "No More Books")
            {
                if (nextBook == favouriteBook)
                {
                    isBookfound = true;
                    break;
                }
                counter++;
                
                nextBook = Console.ReadLine();
            }
            if (isBookfound)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }

        }
    }
}