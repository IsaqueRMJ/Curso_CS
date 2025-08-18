Console.WriteLine("\nBEM VNDO A CALCULADORA SIMPLES DE DOIS VALORES");
var numero01 = 0m;
var numero02 = 0m;

Console.Write("Digite o valor do 1° numero: ");
numero01 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o valor do 2° numero: ");
numero02 = Convert.ToDecimal(Console.ReadLine());

var soma = numero01 + numero02;
var subtracao = numero01 - numero02;
var multiplicacao = numero01 * numero02;
var divisao = numero01 / numero02;

Console.WriteLine("Você pode escolher entre\n1-Fazer todas as operações\n2-Fazer um operação especifica");
Console.Write("Qual opção vc deseja (1/2): ");
var escolha = Console.ReadLine();
if (escolha == "1")
{
    Console.WriteLine($"As operações com o numero {numero01} e o numero {numero02} é:");
    Console.Write($"Soma:{soma}\nSubtração:{subtracao}\nMultiplicação:{multiplicacao}\nDivisão:{divisao.ToString("N2")}\n");
}
else if (escolha == "2")
{
    Console.WriteLine("Qual operação você deseja fazer:\n1-Adição\n2-Subtração\n3-Multiplicação\n4-Divisão");
    Console.Write("Qual opção desja fazer: ");
    var escolhaOperacao = Console.ReadLine();
    switch (escolhaOperacao)
    {
        case "1":
            Console.WriteLine($"A soma dos números {numero01} e {numero02} é igual: {soma}");
            break;
        case "2":
            Console.WriteLine($"A subtração dos números {numero01} e {numero02} é igual: {subtracao}");
            break;
        case "3":
            Console.WriteLine($"A multiplicação dos números {numero01} e {numero02} é igual: {multiplicacao}");
            break;
        case "4":
            Console.WriteLine($"A divisão dos números {numero01} e {numero02} é igual: {divisao.ToString("N2")}");
            break;

        default:
            Console.WriteLine("Valor inválido");
            break;
    } 
}
else
{
    Console.WriteLine("ERROR VALOR INVÁLIDO REFAÇA A EXECUÇÃO DO CÓDIGO");
    return;
}

Console.WriteLine("Clique ENTER para encerrar a calculadora ");
Console.ReadKey();
Console.WriteLine("CALCULADORA SIMPLES ENCERRADA");