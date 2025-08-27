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
        Console.WriteLine("Digite o tamanho, o tipo(tênis...), a cor, a marca, o preço e se vai ter cadarço ou não(true e false)\n(Nessa ordem e com espaço entre as informações)");
        var entradaSapato = Console.ReadLine();
        string[] infos = entradaSapato.Split();
        var tamanhoEntrada = Convert.ToInt32(infos[0]);
        var tipoEntrada = infos[1];
        var corEntrada = infos[2];
        var marcaEntrada = infos[3];
        var precoEntrada = Convert.ToDecimal(infos[4]);
        var cadarcoEntrada = Convert.ToBoolean(infos[5]);

        Sapato sapato_01 = new(tamanhoEntrada, precoEntrada, tipoEntrada,corEntrada, marcaEntrada, cadarcoEntrada);
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
    public string tipo;
    public decimal preco;
    public string cor;
    public int tamanho;
    public string[] marca = ["Adidas","Nike","Puma","New Balance"];
    public bool cadarco;
    public Sapato(){}

    public Sapato(int Tamanho, decimal Preco, string Tipo, string Cor, string Marca, bool Cadarco)
    {
        tamanho = Tamanho;
        preco = Preco;
        tipo = Tipo;
        cor = Cor;
        cadarco = Cadarco;

    }
    public void sobre() => Console.WriteLine($"Seu sapato é do tamanho {tamanho}, da cor {cor}, da marca {marca}, custa {preco} e ele" + (cadarco ? "tem cadarço" : "Não tem cadarço"));

}

public class Loja:Sapato
{
    
}