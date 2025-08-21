var C1 = new Cachorro();

C1.nome = "Sheik";
C1.raca = "viralata";
C1.cor = "Preto";
C1.idade = 1.5m;
C1.peso = 5.5m;
C1.tamanho = 0.5m;
Console.WriteLine(C1.Late(1==2));
class Cachorro()
{
    public string? nome;
    public string? raca;
    public decimal? idade;
    public string? cor;
    public decimal? peso;
    public decimal? tamanho;

    public string Late(bool barulho)
    {
        string? latido;
        if (barulho == true)
        {
            latido = "AU AU AU AU";
        }
        else
        {
            latido = "(O cachorro está em silêncio)";

        }
        return latido;
    }
}
