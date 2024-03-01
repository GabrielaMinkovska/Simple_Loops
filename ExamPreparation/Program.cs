namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedTresholds = int.Parse(Console.ReadLine());

            int failedTimes = 0;
            int solvedRoblemsCount = 0;
            double gradesSum = 0;
            string lastProblems = "";
            bool isFailed = true;

            while (failedTimes < failedTresholds)
            {
                string problemNames = Console.ReadLine();

                if (problemNames == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedTimes++;
                }
                gradesSum += grade;
                solvedRoblemsCount++;   
                lastProblems = problemNames;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTresholds} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum / solvedRoblemsCount:F2}");
                Console.WriteLine($"Number of problems: {solvedRoblemsCount}");
                Console.WriteLine($"Last problem: {lastProblems}");
            }


        }
    }
}