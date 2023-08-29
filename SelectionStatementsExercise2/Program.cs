namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your favorite school subject?");

            var userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "science":
                    Console.WriteLine("Math like a programming, It's all about solving problems.");
                    break;

                case "math":
                    Console.WriteLine("Science is amazing! Exploring the mysteries of the world.");
                    break;

                case "history":
                    Console.WriteLine("History is intriguing! Learning from the past.");
                    break;

                case "English":
                    Console.WriteLine("English is wonderful! Expressing yourself through words.");
                    break;

                case "art":
                    Console.WriteLine("Art is beautiful! Creating and interpreting visual expressions.");
                    break;

                default:
                    Console.WriteLine($"Your subject: {userInput}");
                    break;
            }

        }
    }
}