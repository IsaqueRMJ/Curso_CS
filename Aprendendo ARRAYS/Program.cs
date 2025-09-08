string[] nomes = new string[6];//Aqui estou declarando uma arrayas do tipo nome onde posso limitar ou não a quantidade de itens 
nomes[0] = "Isaque";
nomes[1] = "Miguel";
nomes[2] = "Chico";
nomes[3] = "André";
nomes[4] = "Nicolas";
nomes[5] = "Riky";
// nomes[6] = "Leo";//Aqui da error pq na array pode ter no maximo 6 itens e não de 0 a 6
void exiberarray(string[] array){
    var i = 0;
    foreach (var item in array)
    {
        Console.WriteLine($"{array[i]}");
        i++;
    }

}
var i = 0;
foreach (var nom in nomes)//Estrutura para mostrar os nomes 
{
    Console.WriteLine($"O nome agora é {nomes[i]}");
    i++;
}
int[] idade = new int[5] { 20, 17, 18, 15, 16 };

string[] nomes_02 = { "Isaque", "Miguel", "Chico", "André", "Nicolas" };//Outra forma de declarar uma array

//Propiedades
var nome = "Chico";
Array.Sort(nomes);//Ordem alfabetica
exiberarray(nomes);

Array.Reverse(nomes);
exiberarray(nomes);

Console.WriteLine(Array.BinarySearch(nomes, nome));//Se não encontrar nada retorna -1

Console.WriteLine(nomes.Length);//Tamanho da array
Array.Clear(nomes, 0, 1);//Limpar do elemento 0 ao 1
exiberarray(nomes);

string[] exemplo = new string[3];
Array.Copy(nomes, exemplo, 3);//Copiar os 3 primeiros elementos do nome em exemplo
exiberarray(exemplo);