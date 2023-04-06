internal class Program
{
    private static void Main(string[] args)
    {
        // выводим имя пользователя с предложением записать имя в строку
        Console.WriteLine("Введите Ваше имя");

        static string? GetUsername() => Console.ReadLine();

        string username = GetUsername();
        Console.Write("Привет, ");
        Console.Write(username);
    }
}