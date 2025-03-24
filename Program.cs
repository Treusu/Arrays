namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Classmates = { "Aaron", "Jethro", "Noah", "Jimuel", "JM", "Mark Jason" };

            Console.WriteLine("Classmate Names:");
            foreach (string name in Classmates)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            char[,] alphabetArray = new char[2, 3]
            {
            { 'A', 'B', 'C' },
            { 'D', 'E', 'F' }
            };

            Console.WriteLine("Alphabet Array:");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(alphabetArray[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nWrite a greeting!");

            string message = Console.ReadLine();
            string searchTerm = "hello";

            Console.WriteLine($"\nMessage: {message}");
            Console.WriteLine($"Contains '{searchTerm}' (case-insensitive): {message.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)}");
        }
    }
}
