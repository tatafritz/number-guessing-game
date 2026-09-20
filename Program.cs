public class NumberGuessingGame 
{
    public static void Main(string[] args)
    {
        int gameLevel;
        bool isCorrect = false;
        int rangeLimit = 0;
        int maxAttempts = 0;
        int attempts = 0;

        Console.WriteLine("\nChoose your difficulty level:");
        Console.WriteLine("[1] Easy - 0 to 10 | 5 attempts\n[2] Medium - 0 to 50 | 7 attempts\n[3] Hard - 0 to 100 | 10 attempts");
        
        while (true)
        {
            Console.Write("\nEnter your choice: ");
            string menuInput = Console.ReadLine();

            if (int.TryParse(menuInput, out gameLevel) && gameLevel > 0 && gameLevel <= 3)
            {
                break;
            }

            Console.WriteLine("Please enter a valid number.");
        }

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

        int remainingAttempts;

        while (!isCorrect)
        {
            Console.Write("\nInform a number: ");
            string numberInput = Console.ReadLine();
            
            if (!int.TryParse(numberInput, out int userInput))
            {
                Console.WriteLine("\nInvalid input. Please enter a number.");
            }
            else
            {
                if (attempts == maxAttempts)
                {
                    Console.WriteLine($"\nYou used all attempts available.");
                    Thread.Sleep(2000);
                    Console.WriteLine($"\nThe correct number was: {randomNumber}.");
                    break;
                } 
                else if (userInput != randomNumber && attempts < maxAttempts)
                {
                    remainingAttempts = maxAttempts - attempts;
                    Console.WriteLine($"\nWrong!\nTry again... You have {remainingAttempts} attempts remaining.");                    attempts++;
                    isCorrect = false;
                }
                else
                {
                    Console.WriteLine("\nCorrect!");
                    isCorrect = true;
                }
            }
        }
    }
}