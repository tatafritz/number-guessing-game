public class NumberGuessingGame 
{
    public static void Main(string[] args)
    {
        bool isCorrect;

        Random random = new Random();
        var randomNumber = random.NextInt64(0, 101);

        Console.WriteLine($"Number generated: {randomNumber}");

        do
        {
            Console.Write("Inform a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());            

            if (userInput != randomNumber)
            {
                Console.WriteLine("Wrong!\nTry again...");
                isCorrect = false;
            }
            else
            {
                Console.WriteLine("Correct!");
                isCorrect = true;
            }
        } while (!isCorrect);        
    }
}