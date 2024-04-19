float n1 = 0, n2 = 0;
int operacao = 0;

Console.Write("Digite o primeiro numero:");
n1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo numero:");
n2 = float.Parse(Console.ReadLine());

do
{
    Console.WriteLine($"Qual operação você quer realizar com os números {n1} e {n2}?");
    Console.WriteLine("1 - SOMA");
    Console.WriteLine("2 - SUBTRAIR");
    Console.WriteLine("3 - MULTIPLICAR");
    Console.WriteLine("4 - DIVIDIR");
    operacao = int.Parse(Console.ReadLine());
    
    Console.Clear();

    if (operacao < 1 || operacao > 4)
    {
        Console.WriteLine("!--------------------------------------------!");
        Console.WriteLine("ERRO: Operação inválida!");
        Console.WriteLine("!--------------------------------------------!");
    }
} while (operacao < 1 || operacao > 4);


Console.WriteLine();

if (operacao == 1)
{
    Console.WriteLine($"Soma: {n1} + {n2} = {n1 + n2}");
}
else if (operacao == 2)
{
    Console.WriteLine($"Subtracao: {n1} - {n2} = {n1 - n2}");
}
else if (operacao == 3)
{
    Console.WriteLine($"Multiplicacao: {n1} x {n2} = {n1 * n2}");
}
else
{
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
            Console.WriteLine($"Divisao: {n1} / {n2} = {n1 / n2}");
        }
    }
}

Console.WriteLine();

Console.WriteLine("Pressione qualquer tecla para terminar o programa.");
Console.ReadKey();