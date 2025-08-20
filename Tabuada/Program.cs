//Projeto  de tabuaba usando a estrutura While
var i = 0;
Console.Write("Digite o número para fazer a tabuada: ");
var valor01 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite até qual número: ");
var valor02 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite até qual operação: ");
var operacao = Console.ReadLine();
operacao?.ToLower();

while (valor02 > i)
{
    switch (operacao)
    {
        case "+":
        case "adição":
            operacao = "+";
            Console.WriteLine($"{valor01} + {i} = {valor01 + i}");
            i += 1;
            break;

        case "-":
        case "subtração":
            operacao = "-";
            Console.WriteLine($"{valor01 * i} - {valor01} = {valor01 * i - valor01}");
            i += 1;
            break;

        case "*":
        case "multiplicação":
            operacao = "*";
            i += 1;
            Console.WriteLine($"{valor01} * {i} = {valor01 * i}");
            break;
        case "/":
        case "divisão":
            operacao = "/";
            Console.WriteLine($"{valor01 * (i+1)} / {valor01} = {i+1}");
            i += 1;
            break;

        default:
            Console.WriteLine("ERROR");
            break;
    }
    if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
        break;
}

