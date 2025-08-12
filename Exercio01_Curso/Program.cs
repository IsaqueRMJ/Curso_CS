// Desafio 01
int idade = 35;
Console.WriteLine($"Resposta 1:{idade}");

//Desafio 02
string nome = "Maria";
Console.WriteLine($"Resposta 2:{nome}");

//Desafio 03
float altura = 3.5f;
Console.WriteLine($"Resposta 3:{altura}");

//Desafio 04
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine($"Resposta 4:{data.ToShortDateString()}");

//Desafio 05 
const int ANO = 12;
Console.WriteLine($"Respota 5:{ANO}");

//Desafio 06
double? nota = 7.8d;
Console.WriteLine($"Resposta 6:{nota}");

//Desafio 07
Console.WriteLine("Resposta 7:Os tipos de valores além de se alocarem na memória sratk, ddirecionada a dados exatos e definidos e usam um sistema de saida LIFO (O ultimo a entrar é o primeiro a sair )Já a referencial ele é como se fosse um ponteiro na memória direcionada a objetos não exatos ainda, sendo necessaio um Garbet Colector para se gerneciar a memória");

// Desafio 08
int x = 10;
double numero = 7.99;
char letra = 'C';
float temperatura = 27.4f;
bool ativo = true;
string nome_02 = "Manoel";
decimal salario = 950.55m;
DateTime hoje = DateTime.Now;

Console.WriteLine("Resposta 8: Olhe o código");

// Desafio 09
int n = 1; //Valor
string titulo = "A vida"; //Referencial
float f = 12.45f; //Valor
double d = 5.45; //Valor
decimal valor = 10.99m; //Valor
char sexo = 'M'; //Valor
object o = null; //Referencial
Console.WriteLine("Resposta 9: Olhe o código");

// Desafio 10
// Um valor nullable é um valor que pode ser nulo 
int? identificador = null;
if (identificador.HasValue)
{
    Console.WriteLine($"Você tem um numero de identificador com valor {identificador.Value}");
}
else
{
    Console.WriteLine($"Você não possui um identificador não é possilvel acessar a plataforma");
}

Console.WriteLine("Resposta 10: Olhe o código");

// Desafio 11
// Camel case é um forma de nomenclatura de identificadores na progamção, usada para padronizar e é uma boa pratica, 
// nela a primeira letra usada na primeira palavra é minuscula e nas d+ palavras maiuscula
float distanciaCasa = 8.8f; //Usamos  em variáveis
Console.WriteLine($"Sua casa fica a {distanciaCasa} metros");
Console.WriteLine("Resposta 11: Olhe o código");

// Desafio 12
//O pascal case é mais um forma de nomenclatura de identificadores, para padronizar
//Agora no pascal case, a primeira letra da primeira palavra é maiuscula tbm

DateTime dataValor = new DateTime(2023,08,16);
Console.WriteLine($"Resposra 12: {dataValor.DayOfYear}");

// Desafio 13
int numero_1 = 77, numero_2 = 66;
int soma = numero_1 + numero_2;
System.Console.WriteLine($"Resposra 13: a soma de {numero_1}+{numero_2}={soma}");

// Desafio 14
bool var_1 = default;
char var_2 = default;
int var_3 = default;
double var_4 = default;
float var_5 = default;
decimal var_6 = default;
string var_7 = default;//Valores de referência geralment nulos 

Console.WriteLine($"{var_1}, null{var_2},{var_3},{var_4},{var_5},{var_6}, null{var_7}");

//Desafio 15
/* Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis
considerando a nomenclatura usada

(F) double 1valor = 12.45; Não se pode começar com numero
(F) string #nome = "Pedro"; não se pode começar com caracteres
(V) float _temperatura = 12.45f; Pode começar sublinhado
(F) double int = 5; Não se pode usar palavras com funções dentro da linguagem na declaração de variáveis
(F) decimal renda extra = 91.45m; Não pode haver espaço entre duas palvras ou são juntas ou sepradas por sublinhado
(F) bool status$conta = false;Sem caracteres no meio 
(V) string titulo3 = “Tópico 1”; Pode terminar em numero
(V) float salario_mensal = 1999.55f; Olha até q a variavel vai ser declarada dboa, só não segue a convenção Camel Case, por isso coloquei como falso
(V) int percentualValorDesconto = 5; Tudo certo por aqui de acordo com o Camel Case
(V) const bool MENSALIDADE_EM_DIA = true; Tudo certo tbm, constantes realmente todos os caractesres são maiusculo */