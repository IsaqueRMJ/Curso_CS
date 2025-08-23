var aluno_01 = new aluno();
aluno_01.nome = "Isaque";
aluno_01.idade = 17;
aluno_01.nota = 5.0m;

aluno_01.aprovacaoao(aluno_01.nota, aluno_01.nome);
public class aluno//Classe é o conjunto de objetos, ojeto é um instancia da classe
{
    public string nome;
    public int idade;
    public decimal nota;
    public void aprovacaoao(decimal nota, string nomeAluno)
    {
        if (nota >= 6)
        {
            Console.WriteLine($"O aluno  {nomeAluno} passou de ano");
        }
        else
        {
            Console.WriteLine($"O aluno {nomeAluno} não passou de ano");
        }

    }

}