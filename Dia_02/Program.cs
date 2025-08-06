Console.WriteLine("Atribuindo valores não numéricos e comparação");

bool ativo = true, passivo = false;
int num_1 = 10, num_2 = 9;
Console.WriteLine("Boeleanos");
Console.ReadLine();

Console.WriteLine(ativo == false); // É para sair false
Console.WriteLine(passivo == false); //É para sair true
Console.WriteLine(ativo != passivo); //É para sair true
Console.WriteLine(num_1 == num_2);// É para sair false
Console.WriteLine(num_1 > num_2); //É para sair true

char letra_1 = 'A'; //Sempre usar aspas simples quando for um char
char letra_2 = '\u0052'; //R no formato unicode
char letra_3 = 'I';
char letra_4 = '\u0045'; //E no formatounicode
char letra_5 = 'L';

Console.WriteLine("Valores unicode (char)");
Console.ReadLine();

Console.WriteLine("{0}{1}{2}{3}{4}{5}", letra_1, letra_2, letra_3, letra_4, letra_5, letra_4);

Console.WriteLine("Agora vamos para os tipos referenciais");

string frase = "Isto é uma string e ela é imutavel";  //String é um conjunto de caracteres e no C# é imuyavel
object frase_2 = "O obeject é o pai de todas a variaveis então ele pode receber qualquer valor";
object numero = 10;
object nota = 9.8;
dynamic letra = 'A'; //O dynamic se comporta da msm forma q o object então ele tbm recebe qualquer tipo de valor
dynamic verdade = true;

Console.WriteLine(frase);
Console.WriteLine(frase_2);
Console.WriteLine("{0} {1} {2}", numero, nota, letra);
Console.WriteLine(verdade);

DateTime data_atual = DateTime.Now; //Data e hora atual de acordo com o formato defeinido do meu computadador 
DateTime data_dif = new DateTime(2007, 11, 15, 16, 10, 30); // Data especifca no formato aaaa/mm/dd hora:min:sec

Console.WriteLine("Esta é a  data atual {0}, e esta a especifica {1}", data_atual, data_dif);
// para estrais informação da data podemos pegar a variavel e usar

Console.WriteLine(data_atual.AddDays(50)); //Aumente 50 dias
//Tudo aqui é só usar inglês basico pós ponto
Console.WriteLine(data_atual.Year); //Pega só o ano
Console.WriteLine(data_atual.DayOfWeek);//Dia da semena
Console.WriteLine(data_atual.DayOfYear);//Formato 365 dias
Console.WriteLine(data_atual.ToLongDateString()); //Por extenso
Console.WriteLine(data_atual.ToShortDateString()); //Curinho com dia/mes/ano
Console.WriteLine(data_atual.ToLongTimeString()); //Hora com segundos
Console.WriteLine(data_atual.ToShortTimeString()); //Hora só minutos e hora

