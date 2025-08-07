Console.WriteLine("Valores nulls\n");

// Aqui é a forma mais antiga de dcelaros um valor nullable
Nullable<int> a = null;
Nullable<char> b = null;
Nullable<double> c = null;
Nullable<bool> d = null;

Console.WriteLine(a);//vai só pular uma linha
Console.WriteLine(b);//vai só pular uma linha
Console.WriteLine(c);//vai só pular uma linha
Console.WriteLine(d);//vai só pular uma linha

//Forma simples de declarar o valor nullable
int? w = null;
double? x = null;
char? y = null;
string? frase = null;
object? objeto = null;

int i = w ?? 10;
Console.WriteLine(i);
Console.WriteLine("{0},{1},{2}", w, y, x);
Console.WriteLine(frase);
Console.WriteLine(objeto);

// int e = i * w; //Da error pois não é possivel a operação
int? e = i * w; //Aqui vai dar null pq o null serve como um zero aqui tornando o valor anulado
Console.WriteLine(e);

Console.WriteLine("Agora as referencias dos valores Nullable\n");
int? valor = 100;
Console.WriteLine("{0} {1}", valor.HasValue, valor.Value);//Aqui o diz q tem um valor e que seu valor é 100

int? valor_2 = 100;//Aqui sai na primeira
// int? valor_2 = null; aqui sai na segunda

if (valor_2.HasValue)
{
    Console.WriteLine($"Sua variavél tem valor e seu valor é {valor_2.Value}\n"); // Aqui é uma forma de imprimir uma variavel dentro da saida com o $
}
else
{
    System.Console.WriteLine("Sua variável não tem valor\n");
} 

// Sobre identificadores

const string NOME = "Samuel"; //Constantes tem que ser tudo maiusculo
int idadeAluno = 7;//Variáveis se usa camel case
Console.WriteLine($"{NOME}\n");
Console.WriteLine($"{idadeAluno}\n");

class ImprimirTexto//Para classes é pascal case
{
    public void ImprimirNome()//Para metodos é pascal case
    {
        Console.WriteLine("Nome");
    }
}
 
//Eu não vi classes nem metedos apenas eu reṕliquei o codigo para explicar as boas praticas
