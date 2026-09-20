public class NumberGuessingGame 
{
    public static void Main(string[] args)
    {
        bool isCorrect;
        int rangeLimit = 0;
        int maxAttempts = 0;
        int attempts = 0;

        Console.WriteLine("\nChoose your difficulty level:");
        Console.WriteLine("[1] Easy - 0 to 10 | 5 attempts\n[2] Medium - 0 to 50 | 7 attempts\n[3] Hard - 0 to 100 | 10 attempts");
        Console.Write("\nEnter your choice: ");
        int gameLevel = Convert.ToInt16(Console.ReadLine());

        switch (gameLevel)
        {
            case 1: 
                rangeLimit = 11;
                maxAttempts = 5;
                break;
            case 2:
                rangeLimit = 51;
                maxAttempts = 7;
                break;
            case 3:
                rangeLimit = 101;
                maxAttempts = 10;
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;  
        }

        Random random = new Random();
        var randomNumber = random.NextInt64(0, rangeLimit);

        Thread.Sleep(3000);
        Console.WriteLine($"\nThe number has been generated!");

        do
        {
            Console.Write("\nInform a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (attempts == maxAttempts)
            {
                Console.WriteLine($"\nYou used all attempts available.");
                Thread.Sleep(2000);
                Console.WriteLine($"\nThe correct number was: {randomNumber}.");
                break;
            } 
            else if (userInput != randomNumber && attempts < maxAttempts)
            {
                Console.WriteLine("\nWrong!\nTry again...");
                attempts++;
                isCorrect = false;
            }
            else
            {
                Console.WriteLine("\nCorrect!");
                isCorrect = true;
            }
        } while (!isCorrect);
    }
}