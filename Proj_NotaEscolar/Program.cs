decimal notaAv1 = 0m, notaAv2 = 0m, notaFinal = 0m, diferencaNota = 0m;
string? nomeEntrada, nomeUsado, nomeAluno, resposta_1, resposta_2, materiaEscolar;
var divisorFinal = 0;
var notaMinima = 0;



//Entrada nome professor
Console.WriteLine("OLÁ BEM VINDO AO PROJETO DE NOTAS ESCOLARES DENTRO DO C#");
Console.Write("Digite seu nome como professor(a): ");
nomeEntrada = Console.ReadLine();
nomeUsado = nomeEntrada == "" ? "USUARIO" : nomeEntrada; //Instanciando a variavél
Console.WriteLine($"\nBem vindo(a) {nomeUsado}\nAqui você poderá adicionar a nota do aluno e ver se ele tem nota para passar ou não\n");

//Informações alunos
Console.Write("Digite o nome de seu aluno(a): ");
nomeAluno = Console.ReadLine();

Console.Write("Digite a AV1 do aluno(a): ");
notaAv1 = Convert.ToDecimal(Console.ReadLine()); 

Console.Write("Digite a AV2 do aluno(a): ");
notaAv2 = Convert.ToDecimal(Console.ReadLine());

//Manipulação da nota
//Peso duplo
Console.Write("Agora algumas perguntas sobre a nota do aluno \nA AV2 e peso duplo? (s/n) ");
resposta_1 = Console.ReadLine();
if (resposta_1 == "S" || resposta_1 == "s")
{
    notaAv2 *= 2m;
    divisorFinal = 3;

}
else
{
    divisorFinal = 2;
}


//Ponto extra
Console.Write("Ele vai ter ponto extra? (s/n) ");
resposta_2 = Console.ReadLine();
if (resposta_2 == "S" || resposta_1 == "s")
{
    notaFinal += 1;

}
else
{

}

Console.Write("A nota escolar é de qual matéria: ");
materiaEscolar = Console.ReadLine();
materiaEscolar = materiaEscolar == null || materiaEscolar == "" ? "INDEFINIDA": materiaEscolar;

//Operação final e verificação se o aluno passou ou não
notaFinal = (notaAv1 + notaAv2) / divisorFinal;

Console.Write("Qual a nota média para passar: ");
notaMinima = Convert.ToInt32(Console.ReadLine());


diferencaNota = notaFinal - notaMinima;
diferencaNota= -diferencaNota;
if (notaFinal >= notaMinima)
{
    Console.WriteLine($"\nSr.(a) {nomeUsado} o aluno(a) {nomeAluno} passou de ano\nCom a nota: {notaFinal.ToString("N2")}\nNa matéria de: {materiaEscolar}");
}
else
{
    Console.WriteLine($"\nSr.(a) {nomeUsado} o aluno(a) {nomeAluno} não passou de ano\nA nota final dele foi: {notaFinal.ToString("N2")}\nNa matéria de: {materiaEscolar}\nFaltou {diferencaNota.ToString("N2")} pontos para ele(a) passar");
}

Console.WriteLine("Clique ENTER para sair da sistema: ");
Console.ReadKey();
Console.WriteLine("SISTEMA ENCERRADA");