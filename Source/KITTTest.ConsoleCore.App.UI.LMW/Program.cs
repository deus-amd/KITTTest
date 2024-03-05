namespace KITTTest.ConsoleCore.App.UI.LMW;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Программа запущена!");

        var a = GetNumber();
        var b = GetNumber();

        try
        {
            var sum = (long)a + (long)b;

            Console.WriteLine($"[{a}] + [{b}] = [{sum}]");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка сложения двух чисел!");
        }
        finally
        {
            Console.WriteLine("Программа завершена. Для выхода нажмите любую кнопку!");
            Console.ReadKey();
        }
    }

    private static int GetNumber()
    {
        Console.WriteLine("Введите число");

        var result = ReadNumber(out var value);

        while (!result)
        {
            Console.WriteLine("Ошибка ввода числа. Повторите ввод");

            result = ReadNumber(out value);
        }

        return value;
    }

    private static bool ReadNumber(out int value)
    {
        var valueRaw = Console.ReadLine();

        Console.WriteLine(valueRaw);

        return int.TryParse(valueRaw, out value);
    }
}