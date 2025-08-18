// 1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :
// Aluno <nome> tem <idade> anos e nota <nota> usando a concatenação e a interpolação de strings.
var nome = "Paulo";
var idade = 17;
var nota = 7.5;

Console.WriteLine("Aluno" + nome + "tem" + idade + "anos e a nota" + nota);//Concatenação
Console.WriteLine($"Aluno{nome} tem {idade} anos e a nota {nota}");//Interpolação

// 2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de
// escapes.

Console.WriteLine($"\nAluno {nome}\ntem {idade} anos\ne a nota {nota}");

// 3- Para qual tipo de dados você pode converter um float implicitamente ?
// (Pode) int
// (Pode) double
// (Não pode) long
// (Não pode) decimal

// 4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// (Não usa cast) int para long
// (Não usa cast) double para long
// (Usa cast) double para float
// (Usa cast) decimal para float
// (Usa cast) long para int
// (Não usa cast) double para decimal

// 5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings
Console.Write("Digite 3 letras: ");
var letras = Console.ReadLine();
Console.WriteLine(letras?.Reverse().ToArray());

// 6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (F) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (V) A sequencia \t inclui uma tabulação vertical

double teste = 1921389;
Console.WriteLine(teste);