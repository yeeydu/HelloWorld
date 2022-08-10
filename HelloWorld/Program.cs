namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            string value = $"{"\n"}Hello, {name}, on {currentDate:d} at {currentDate:t}!";
            Console.WriteLine(value);
            Console.Write($" \n Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}