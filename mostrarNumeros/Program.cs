// Projeto para a pessoa ecolher um numero e mostrar todos os numeros até ele de uma forma especifica
Console.WriteLine($"##DIGITE UM NUMERO QUE MOSTRAREMOS A SEQUENCIA ESPECIFICA QUE FOR SELECIONADA##");

Console.WriteLine("Digite um numero inicial:");
var numeroInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite um numero final:");
var numeroFinal = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"##QUAL DESSES VOCÊ DESEJA##\n1-Numeros Pares de {numeroInicial} até {numeroFinal}\n2-Numeros Impares de {numeroInicial} até {numeroFinal}");
var decisao = Console.ReadLine();
while (true)
{
    switch (decisao)
    {
        case "1":
            for (var i = 0; numeroInicial <= numeroFinal; i++)
            {
                if (numeroInicial % 2 == 0)
                    Console.WriteLine($"O numero {numeroInicial} é par");
                numeroInicial++;
            }
            break;
        case "2":
            for (var i = 0; numeroInicial <= numeroFinal; i++)
            {
                if (numeroInicial % 2 == 1)
                    Console.WriteLine($"O numero {numeroInicial} é impar");
                numeroInicial++;
            }
            break;
        // case "3":
        //     for (var i = 0; numeroInicial <= numeroFinal; i++)
        //     {
        //         var primo = false;
        //         for (var j = 2; numeroFinal > j; j++)
        //         {
        //             if (numeroFinal % j == 0)
        //             {
        //                 Console.WriteLine($"O numero {numeroInicial} não é primo");
        //             }
        //             else
        //             {
        //                 Console.WriteLine($"O numero {numeroInicial} é primo");
        //             }
        //         }
                
        //         numeroInicial++;
        //     }
        //     break;
        default:
            break;
    }

    break;
 } 
