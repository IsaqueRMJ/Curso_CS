using System.Text.Json;

string caminhoArquivoTarefa = "tarefas.json";
string caminhoArquivoDatas = "datas.json";
List<DateTime> datas = new();
List<string> tarefas = new();

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
                Console.WriteLine("Você tem tarefas na sua lista: ");
                int i = 0;
                foreach (var Tarefa in tarefas)//Para cada item na lista ele repete
                {
                    Console.Write($"{i + 1}-{tarefas[i]}, registrada ");
                    Console.WriteLine(datas[i]);
                    i++;
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

async Task SalvarTarefasAsync()//Tranforma a lista em json
{
    string json1 = JsonSerializer.Serialize(tarefas);
    string json2 = JsonSerializer.Serialize(datas);
    await File.WriteAllTextAsync(caminhoArquivoTarefa, json1);
    await File.WriteAllTextAsync(caminhoArquivoDatas, json2);

}

async Task CarregarTarefasAsync()//Transforma o json em lista
{
    if (File.Exists(caminhoArquivoTarefa) && File.Exists(caminhoArquivoDatas))
    {
        string json1 = await File.ReadAllTextAsync(caminhoArquivoTarefa);
        tarefas = JsonSerializer.Deserialize<List<string>>(json1);

        string json2 = await File.ReadAllTextAsync(caminhoArquivoDatas);
        datas = JsonSerializer.Deserialize<List<DateTime>>(json2);
    }
}
