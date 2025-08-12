Console.WriteLine("Da a saída de dados e pula uma linha");
Console.WriteLine("Como você pode ver");

Console.Write("Aqui ele não pula ");
Console.Write("como pode ver\n");//O \n pula uma linha é muito util

var nome = "isaque";
var idade = 17;

// Formas de ter na saida as variaveis 
//Usando a conctecação
Console.WriteLine("meu nome é " + nome + " e tenho "  + idade  + " anos"); //1° forma, concatenação
Console.WriteLine("meu nome é {0} e tenho {1} anos", nome, idade); //2° forma, place holder com inicio 0
Console.WriteLine($"meu nome é {nome} e tenho {idade} anos \a");//3° forma, interpolação com $

// Sequencia de espaces
Console.WriteLine("Bolde\nde\npote");
Console.WriteLine("Bole\tde\tpote");
Console.WriteLine("Bole\vde\vtpote");

// Conervsão de dados, implicita e explicita
// byte, 1 byte
// short, 2 byte
// float e int, 4 byte
// double e long, 8 byte
// decimal, 16 byte

var num_1 = 10;
var num_3 = 20f;
int num_4 = num_3;

Console.WriteLine(num_2);