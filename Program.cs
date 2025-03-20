Console.Clear();
string phrase;

do
{
    Console.Write("Digite uma frase: ");
    phrase = Console.ReadLine()!;
    if (string.IsNullOrEmpty(phrase))
    {
        Console.Write("Por favor digite uma frase!");
        Thread.Sleep(1000);
        Console.Clear();
    }
    else if (!phrase.Any(char.IsLetter))
    {
        Console.Write("Por favor insira apenas letras!");
        Thread.Sleep(1000);
        Console.Clear();
    }
} while (string.IsNullOrEmpty(phrase) || !phrase.Any(char.IsLetter));

Console.WriteLine($"Cebolinha: {phrase.Replace('r', 'l')}");