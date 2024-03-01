namespace Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());

            int coins = 0;

            int stotinki = (int)(value * 100);
            int currStotinkiCoin = 200;

            while (currStotinkiCoin != 0)
            {
                coins += stotinki / currStotinkiCoin;
                stotinki= stotinki % currStotinkiCoin;

                switch (currStotinkiCoin)
                {
                    case 200: currStotinkiCoin = 100;
                        break;
                    case 100:
                        currStotinkiCoin = 50;
                        break;
                    case 50:
                        currStotinkiCoin = 20;
                        break;
                    case 20:
                        currStotinkiCoin = 10;
                        break;
                    case 10:
                        currStotinkiCoin = 5;
                        break;
                    case 5:
                        currStotinkiCoin = 2;
                        break;
                    case 2:
                        currStotinkiCoin = 1;
                        break;
                    case 1:
                        currStotinkiCoin = 0;
                        break;
                }
            }
            Console.WriteLine(coins);
        }
    }
}