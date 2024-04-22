double n1 = 0, n2 = 0, n3 = 0, n4 = 0;
int operacao = 0;

Console.WriteLine("BEM VINDO AO APP CALCULATOR");

Console.Write("Digite o primeiro numero:");
n1 = double.Parse(Console.ReadLine());

do
{
    Console.Write("Digite o segundo numero:");
    n2 = double.Parse(Console.ReadLine());

    if (n2 == 0)
    {
        Console.WriteLine("Informe um número diferente de 0.");
    }
} while (n2 == 0);

do
{
    Console.Write("Digite o terceiro numero:");
    n3 = double.Parse(Console.ReadLine());

    if (n3 == 0)
    {
        Console.WriteLine("Informe um número diferente de 0.");
    }
} while (n3 == 0);

do
{
    Console.Write("Digite o quarto numero:");
    n4 = double.Parse(Console.ReadLine());

    if (n4 == 0)
    {
        Console.WriteLine("Informe um número diferente de 0.");
    }
} while (n4 == 0);

do
{
    Console.WriteLine($"Qual operação você quer realizar com os números {n1} e {n2}?");
    Console.WriteLine("1 - SOMA");
    Console.WriteLine("2 - SUBTRAIR");
    Console.WriteLine("3 - MULTIPLICAR");
    Console.WriteLine("4 - DIVIDIR");
    operacao = int.Parse(Console.ReadLine());

    Console.Clear();
    Console.WriteLine();

    switch (operacao)
    {
        case 1:
            Console.WriteLine($"Soma: {n1} + {n2} + {n3} + {n4} = {n1 + n2 + n3 + n4}");
            break;
        case 2:
            Console.WriteLine($"Subtracao: {n1} - {n2} - {n3} - {n4} = {n1 - n2 - n3 - n4}");
            break;
        case 3:
            Console.WriteLine($"Multiplicacao: {n1} x {n2} x {n3} x {n4} = {n1 * n2 * n3 * n4}");
            break;
        case 4:
            Console.WriteLine($"Divisao: {n1} / {n2} / {n3} / {n4} = {n1 / n2 / n3 / n4}");
            break;
        default:
            Console.WriteLine("!--------------------------------------------!");
            Console.WriteLine("ERRO: Operação inválida!");
            Console.WriteLine("!--------------------------------------------!");
            break;
    }
} while (operacao < 1 || operacao > 4);

Console.WriteLine("\nPressione qualquer tecla para terminar o programa.");
Console.ReadKey();