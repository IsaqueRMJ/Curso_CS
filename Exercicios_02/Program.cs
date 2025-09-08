//Exercicio 02

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
// (V) long resultado = 1.32;
// (V) var nome = “Maria”;
// (V) string resultado = 100.ToString();
// (V) A sequência de escape \n inclui uma nova linha
// (F) float f = 5.45;
// (V) decimal valor = (decimal) 10.99f;
// (F) var status = null;
// (V) object o = 12.45m;
// (V) string titulo = true.ToString();
// (V) A sequencia \t inclui uma tabulação vertical


// 7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:
double numero1, numero2;
Console.Write("Digite o 1° numero: ");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o 2° numero: ");
numero2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Soma:{numero1+numero2}, Subtração:{numero1-numero2}\nMultiplição:{numero1*numero2}, Exponenciação:{Math.Pow(numero1, numero2)}\nDivisão:{numero1/numero2} e Módulo:{numero1%numero2}");

// // 8-Faça um programa para calcular o resultado da fórmula de baskara dados os valores de
// // a,b e c

int a = 1, b = 12, c = -13;
var delta = (b * b) + (-4 * a * c);
var X_1 = (-b + Math.Sqrt(delta)) / 2 * a;
var X_2 = (-b - Math.Sqrt(delta)) / 2 * a;

Console.WriteLine($"O valor do X1 é {X_1} e o valor de X2 {X_2}");

// 9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)
string Nome;
int senha;

Console.Write("Digite seu nome: ");
Nome = Console.ReadLine();
Console.Write("Digite sua senha: ");
senha = Convert.ToInt32(Console.ReadLine());

var mensagem = ((Nome == "admin" || Nome == "maria") && senha == 123) ? "Login feito com sucesso" : "Login inválido";
Console.WriteLine(mensagem);

// 10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando
// a nomenclatura usada:

// (V) string? nome; é um exemplo de nullable reference type;
// (V) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
// (F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND) 
// (F) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
// (F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
// (F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
// (V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
// (F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
// (F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
// (V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
// (F) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

// 11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
Console.WriteLine("Digite o 1° numero");
var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o 2° numero");
var y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(x % 2 == 0 ? $"O numero {x} é par" : $"O numero {x} é impar");
Console.WriteLine(x % 2 == 0 ? $"O numero {y} é par" : $"O numero {y} é impar");

// 12- Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no
// console o resultado das seguintes operações : (x^2 -> x ao quadrado) (pi = 3.1415)
// -6 + x * 5
// (13-2) * x
// (x + -2) * (20 / x)
// (12 + x) / (x - 4)
// 3 x^2 + x + 10
// pi * x^2
var pi = 3.1415 ;
Console.WriteLine("Digite o numero: ");
var numeroX = Convert.ToInt32(Console.ReadLine());
var operacao01 = -6 + numeroX * 5;
var operacao02 = (13-2) * numeroX;
var operacao03 = (numeroX + -2) * (20 / numeroX);
var operacao04 = (12 + numeroX) / (numeroX - 4);
var operacao05 = 3 * (numeroX*numeroX) + numeroX + 10;
var operacao06 = pi * (numeroX * numeroX);


// 13- Considere o seguinte trecho de código:
int numY = 5 ;
numY = (numY++)+numY+(++numY);
Console.WriteLine(numY);

// 14- Escreva um programa que solicite a temperatura em graus Celsius e converta para
// Kelvin e Farhenheit usando as fórmulas a seguir:
// - Converter para Kelvin => K = C + 273 ;
// - Converter para Farhenheit => F = (C * 9) / 5 + 32 ;

Console.Write("Digite um valor em Celsius: ");
var valor = Convert.ToDecimal(Console.ReadLine());
var Far = (valor * 9) / 5 + 32 ;
var Kel = valor + 273;
Console.WriteLine($"O valor de {valor}°C em Kelvin é {Kel}K e em Farhenheit é {Far}°F");



// 15 - Escolha a opção que representa a exibição do resultado para o código usando os
// operadores de decremento e incremento (pré e pós) :

// var numero = 5;
// Console.WriteLine(numero++);
// numero = 1;
// Console.WriteLine(++numero);
// numero = 2;
// Console.WriteLine(numero--);
// numero = 3;
// Console.WriteLine(--numero);
// Console.ReadKey();

// ()5222
// ()6322
// ()5212
// (X)6213