Console.WriteLine("Declarando variaveis numéricas ");
//Variaveis e Contantes
//numeros inteiros 
Console.WriteLine("numeros inteiros");
byte valor1 = 255, valor2 = 3;
int valor3 = 999999;
long valor4 = 9999999999;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);

Console.WriteLine("Agora numeros flutuantes");
Console.ReadLine();


//numeros flutuantes
float vlr1 = 1.25f;//f no final
double vlr2 = 1.273276, vlr3 = 1.74637842d; // pode não ter nada no final ou o d
decimal vlr4 = 1.89138163627368m; //m no final

Console.WriteLine(vlr1);
Console.WriteLine(vlr2);
Console.WriteLine(vlr3);
Console.WriteLine(vlr4);

//teste de preciso de numeros flutuantes
Console.WriteLine("Comparação de numeros flutuantes e sua precisão");
Console.ReadLine();
float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
