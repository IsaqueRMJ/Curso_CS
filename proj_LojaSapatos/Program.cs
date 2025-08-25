while (true)
{
    Console.WriteLine("Bem vindo ao sistema de cadastro");
    Console.Write("Deseja cadastrar? ");
    var entradaCompra = Console.ReadLine();
    if (entradaCompra == "n")
    {
        Console.WriteLine("Adeus...");
        break;
    }
    else if (entradaCompra == "s")
    {
        Console.WriteLine("Digite o tamanho, a cor, a marca, o preço e se vai ter cadarço ou não(true e false)\n(Nessa ordem e com espaço entre as informações)");
        var entradaSapato = Console.ReadLine();
        string[] infos = entradaSapato.Split();
        var tamanhoEntrada = Convert.ToInt32(infos[0]);
        var corEntrada = infos[1];
        var marcaEntrada = infos[2];
        var precoEntrada = Convert.ToDecimal(infos[3]);
        var cadarcoEntrada = Convert.ToBoolean(infos[4]);

        Sapato sapato_01 = new(tamanhoEntrada, precoEntrada, corEntrada, marcaEntrada, cadarcoEntrada);
        sapato_01.sobre();
        Console.Read();
    }
    else
    {
        Console.Write("Opção inexistente, tente novamente...");
        Console.Read();
        continue;
    }

}
public class Sapato
{
    public decimal preco;
    public string cor;
    public int tamanho;
    public string marca;
    public bool cadarco;
    public Sapato(int Tamanho) => tamanho = Tamanho;

    public Sapato(int Tamanho, decimal Preco, string Cor, string Marca, bool Cadarco) : this(Tamanho)
    {
        preco = Preco;
        cor = Cor;
        marca = Marca;
        cadarco = Cadarco;

    }
    public void sobre() => Console.WriteLine($"Seu sapato é do tamanho {tamanho}, da cor {cor}, da marca {marca}, custa {preco} e ele" +(cadarco ? "tem cadarço":"Não tem cadarço"));
    public void amarrar(Sapato sapato)
    {
        var amarrado = false;
        while (true)
        {
            if (cadarco == false)
            {
                Console.WriteLine("Seu sapato nem tem cadarço, não da para amarrar");
                Console.Read();
                break;
            }
            else if (amarrado == true)
            {
                Console.WriteLine("O cadarço está amarrado");
                Console.Read();
                break;
            }
            else
            {
                Console.WriteLine("Opa seu cadarço está dessamarrado, melhor amarrar");
                Console.Read();
                amarrado = true;
                continue;
            }
        }
    }

}