namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower()) // makes input case-insensitive
            {
                case "math":
                    Console.WriteLine("Math is cool because it's all about solving problems!");
                    break;

                case "science":
                    Console.WriteLine("Science helps us understand how the world works!");
                    break;

                case "history":
                    Console.WriteLine("History teaches us about the past and helps us shape the future!");
                    break;

                case "english":
                    Console.WriteLine("English is great for expressing yourself and understanding stories!");
                    break;

                case "art":
                    Console.WriteLine("Art is awesome because it lets your creativity shine!");
                    break;

                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}