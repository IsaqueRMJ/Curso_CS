//using System.IO;
using System.Text.Json;

string caminhoArquivoTarefa = "tarefas.json";
string caminhoArquivoDatas = "datas.json";
string caminhoArquivoConcluidas = "Concluidas.json";
string caminhoArquivoConcluidasDatas = "datasConcluidas.json";

var token = "crescente";

List<DateTime> datas = new();
List<DateTime> datasConsluidas = new();
List<string> tarefas = new();
List<string> tarefasConcluidas = new();

await CarregarTarefasAsync();
while (true)
{
    Console.WriteLine("\nBem-vindo(a) à sua lista de tarefas");
    Console.Write("1 - Adicionar tarefa\n2 - Listar tarefas\n3 - Remover tarefa\n4 - Sair\n\n");
    var escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1": //Adicionar itens
            while (true)
            {
                Console.WriteLine("Digite a tarefa que você deseja adicionar: ");
                var tarefa = Console.ReadLine();
                DateTime data = DateTime.Now;
                tarefas.Add(tarefa);
                datas.Add(data);
                await SalvarTarefasAsync();
                Console.WriteLine("Sua tarefa foi adicionada...");

                Console.Write("Você deseja continuar a adicionar (s/n)? ");
                escolha = Console.ReadLine();
                if (escolha == "s")
                {
                    continue;
                }
                else if (escolha == "n")
                {
                    Console.Write("Click qualquer tecla para volar ao menu...");
                    Console.Read();
                    break;
                }
                else
                {
                    Console.Write("ERROR, Saindo automanticamente...");
                    Console.Read();
                    break;
                }
            }
            continue;

        case "2": // Listar itens
            if (tarefas.Count() == 0)
            {
                Console.WriteLine("Atualmente sua lista de tarefas está vazia...");
                Console.Read();
            }
            else
            {

                Console.Write("Quer ver as terafas a \"fazer\" ou as \"feitas\": ");
                escolha = Console.ReadLine();

                if (escolha == "fazer")
                {
                    GetTask(tarefas, datas,escolha, ref token);
                }
                else if (escolha == "feitas")
                {
                    if (tarefasConcluidas.Count() == 0)
                    {
                        Console.WriteLine("Atualmente sua lista de tarefas está vazia...");
                        Console.Read();
                        continue;
                    }
                    else
                    {
                        GetTask(tarefasConcluidas, datasConsluidas, escolha, ref token);
                    }
                }
                else
                {
                    Console.WriteLine("ERROR 404");
                }

                Console.Read();
            }
            continue;

        case "3": // Remover tarefa
            if (tarefas.Count() == 0)
            {
                Console.WriteLine("Atualmente sua lista de tarefas está vazia...");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Sua terafa já foi concluida? (s/n)"); //Verifica se foi feito
                escolha = Console.ReadLine();
                bool feito = false; //Por padrão não foi concluida
                if (escolha == "s") {feito = true;}//Se feita a chave ganaha um valor true
                Console.WriteLine("Você deseja remover a tarefa por nome ou por índice? ");
                escolha = Console.ReadLine();

                if (escolha.ToLower() == "nome")
                {
                    Console.WriteLine("Digite a tarefa (escreva por extenso)");
                    var tarefaRemove = Console.ReadLine();
                    if (tarefas.IndexOf(tarefaRemove) == -1 || tarefas.IndexOf(tarefaRemove) > tarefas.Count)
                    {
                        Console.WriteLine("Esse item não está na lista...");
                    }
                    else
                    {
                        TaskDone(feito,tarefas.IndexOf(tarefaRemove)); //Adicionando as tarefas feita
                        datas.RemoveAt(tarefas.IndexOf(tarefaRemove));
                        tarefas.Remove(tarefaRemove);
                        await SalvarTarefasAsync();
                        Console.WriteLine("Removido com sucesso...");
                    }
                    Console.Read();
                }
                else if (escolha.ToLower() == "indice")
                {
                    Console.WriteLine("Digite o índice da tarefa (valor numérico)");
                    var tarefaRemove = Convert.ToInt32(Console.ReadLine());
                    if (tarefaRemove > tarefas.Count() || tarefaRemove <= 0)
                    {
                        Console.WriteLine("Esse item não está na lista...");
                    }
                    else
                    {
                        TaskDone(feito, tarefaRemove - 1);
                        tarefas.RemoveAt(tarefaRemove - 1);
                        datas.RemoveAt(tarefaRemove - 1);
                        await SalvarTarefasAsync();
                        Console.WriteLine("Removido com sucesso...");
                    }
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("ERROR, opção inexistente, retornando ao menu...");
                    Console.Read();
                }
            }
            continue;

        case "4": // Sair
            Console.WriteLine("Saindo...");
            Console.Read();
            break;

        default:
            Console.WriteLine("Valor inválido, tente novamente...");
            Console.Read();
            continue;
    }
    break;
}

void TaskDone(bool done,int num)//Função para a task ser feita ou não
{
    
    if (done)
    {
        tarefasConcluidas.Add(tarefas[num]);
        datasConsluidas.Add(datas[num]);
    }
    else { }
}


void GetTask(List<string> Tasks,List<DateTime> Dates, string Tipo, ref string token)
{
    Console.Write("Quer ver as terafas em ordem crescente ou decrescente na data: ");
    var escolha = Console.ReadLine();
    if ((escolha == "decrescente" && token != escolha) || (escolha == "crescente" && token != escolha))
    {
        token = escolha;
        Tasks.Reverse();
        Dates.Reverse();

    }
    else if (escolha == token){ }
    else { Console.WriteLine("ERROR 404"); }
    int i = 0;
    Console.WriteLine($"Você tem na sua lista de tarefas a {Tipo.ToUpper()}: ");
    foreach (var Tarefa in Tasks)
    {//Para cada item na lista ele repete

        Console.Write($"{i + 1}-{Tasks[i]}, registrada ");
        Console.WriteLine(Dates[i]);
        i++;
    }
}


async Task SalvarTarefasAsync()//Tranforma a lista em json
{
    string json1 = JsonSerializer.Serialize(tarefas);
    string json2 = JsonSerializer.Serialize(datas);
    string json3 = JsonSerializer.Serialize(tarefasConcluidas);
    string json4 = JsonSerializer.Serialize(datasConsluidas);

    await File.WriteAllTextAsync(caminhoArquivoTarefa, json1);
    await File.WriteAllTextAsync(caminhoArquivoDatas, json2);
    await File.WriteAllTextAsync(caminhoArquivoConcluidas, json3);
    await File.WriteAllTextAsync(caminhoArquivoConcluidasDatas, json4);


}

async Task CarregarTarefasAsync()//Transforma o json em lista
{
    if (File.Exists(caminhoArquivoTarefa) && File.Exists(caminhoArquivoDatas))
    {
        string json1 = await File.ReadAllTextAsync(caminhoArquivoTarefa);
        tarefas = JsonSerializer.Deserialize<List<string>>(json1);

        string json2 = await File.ReadAllTextAsync(caminhoArquivoDatas);
        datas = JsonSerializer.Deserialize<List<DateTime>>(json2);

        string json3 = await File.ReadAllTextAsync(caminhoArquivoConcluidas);
        tarefasConcluidas = JsonSerializer.Deserialize<List<string>>(json3);

        string json4 = await File.ReadAllTextAsync(caminhoArquivoConcluidasDatas);
        datasConsluidas = JsonSerializer.Deserialize<List<DateTime>>(json4);
    }
}
