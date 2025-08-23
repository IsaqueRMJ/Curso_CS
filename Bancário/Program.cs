// Projeto simples de Sistema de caixa eletronico

// Fluxo Esperado
// 1-O sistema pergunta o nome do titular e o saldo inicial.
// 2-Mostra o menu de opções.
// 3-Usuário escolhe a operação.
// 4-Sistema executa a operação e retorna ao menu.
// 5-Quando escolher "Sair", o sistema encerra.
ContaBancaria usuarioNovo = new();
usuarioNovo.nomeUsuario= "";
usuarioNovo.senha = 0;
usuarioNovo.numeroConta = 0;
usuarioNovo.saldoUsuario = 0;
while (true)
{
    //cadastro usuário

    Console.WriteLine("Bem vindo(a) ao sistema bancario simples");
    Console.WriteLine("Digite o que deseja fazer:\n1-Cadastrar\n2-Login\n3-Sair");
    var entradaDashboard = Console.ReadLine();
    switch (entradaDashboard)
    {
        case "1":
            Console.Write("Digite um número para ser sua conta: ");
            usuarioNovo.numeroConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite seu nome: ");
            usuarioNovo.nomeUsuario = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            usuarioNovo.senha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Usuário Cadastrado");
            Console.Read();
            continue;
        case "2":
            Console.WriteLine("Bem vindo(a) ao login");
            Console.Write("Digite o nome e a senha(Click SPACE entre eles):");
            var entradaUsuario = Console.ReadLine();
            string[] infoUsuario = entradaUsuario.Split();
            var nomeEntrada = infoUsuario[0];
            var senhaEntrada = Convert.ToInt32(infoUsuario[1]);
            if (nomeEntrada == usuarioNovo.nomeUsuario && senhaEntrada == usuarioNovo.senha)
            {
                while (true)
                {
                    Console.WriteLine($"Bem vindo(a) {usuarioNovo.nomeUsuario} o que deseja fazer?\n1-Depositar\n2-Sacar\n3-Consultar saldo\n4-Sair");
                    var acaoUsuario = Console.ReadLine();
                    if (acaoUsuario == "4")
                        break;
                    else
                    {
                        switch (acaoUsuario)
                        {
                            case "1":
                                usuarioNovo.deposito();
                                break;
                            case "2":
                                usuarioNovo.sacar();
                                break;
                            case "3":
                                Console.WriteLine($"Seu saldo é {usuarioNovo.GetSaldo()} reais");
                                Console.Read();
                                break;

                            default:
                                Console.WriteLine("Valor inválido, tente novamente");
                                Console.Read();
                                break;
                        }
                    }

                }


            }
            else
            {
                Console.WriteLine("Seu Usuário ou sua Senha está incorreta, ou NÃO CADASTRADO!!");
                Console.Read();
                continue;
            }

            continue;
        case "3":
            break;
        default:
            continue;
    }
    Console.WriteLine("Serviço Encerrado!!");
    break;

}


public class ContaBancaria//Classe
{
    public string nomeUsuario;//Atributos
    public int numeroConta;//Atributos
    public decimal? saldoUsuario;//Atributos
    public int senha;

    public void deposito()
    {
        decimal valorDeposito;
        int numerodaConta;
        Console.Write("Digite o valor a ser depositado e a conta(Click SPACE entre os parâmetros)");
        var entradaUsuario = Console.ReadLine();
        string[] depositoEntrada = entradaUsuario.Split();
        valorDeposito = Convert.ToDecimal(depositoEntrada[0]);
        numerodaConta = Convert.ToInt32(depositoEntrada[1]);
        if (numerodaConta != numeroConta)
        {
            Console.WriteLine("\nNumero de conta invalido!!");
        }
        else if (valorDeposito == 0m)
            Console.WriteLine($"\nNão é  possivel depositar nenhum valor!!");
        else
        {
            saldoUsuario += valorDeposito;
            Console.WriteLine($"\nSeu depósito de {valorDeposito} na conta: {numerodaConta}, foi feito com sucesso ");
        }
        return;
    }
    public void sacar()
    {
        decimal valorSaque;
        int numerodaConta;
        Console.Write("Qual o valor deseja sacar e de qual conta(Click SPACE entre os parâmetros): ");
        var entradaUsuario = Console.ReadLine();
        string[] saqueEntrada = entradaUsuario.Split();
        valorSaque = Convert.ToDecimal(saqueEntrada[0]);
        numerodaConta = Convert.ToInt32(saqueEntrada[1]);
        if (numerodaConta == numeroConta)
        {
            if (saldoUsuario <= 0)
            {
                Console.WriteLine("A sua conta está zerada, deposite algo para poder sacar");
            }
            else
            {
                saldoUsuario -= valorSaque;
                Console.WriteLine($"Seu saque de {valorSaque} foi feito com sucesso na conta:{numerodaConta}");

            }

        }
        else
            Console.WriteLine("\nNumero de conta invalido!!");
        return;
    }

    public decimal? GetSaldo()
    {
        return saldoUsuario;
    }
}