float n1 = 0, n2 = 0;

Console.Write("Digite o primeiro numero:");
n1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo numero:");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Soma: " + (n1 + n2));
Console.WriteLine("Subtracao: " + (n1 - n2));
Console.WriteLine("Multiplicacao: " + (n1 * n2));
if (n2 == 0)
{
    Console.WriteLine("Impossível dividir por 0");
}
else
{
    if (n2 < 0)
    {
        Console.WriteLine("Número negativo");
    }
    else
    {
        Console.WriteLine("Divisao: " + (n1 / n2));
    }
}