List<string> tarefas = new List<string>() { };
var running = true;
while (running)
{
    Console.WriteLine("\nBem vindo(a) a sua lisa de tarefas");
    Console.Write("1-Adicionar tarefa\n2-Listar terefas\n3-Remover tarefa\n4-Sair\n\n");
    var escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1":
            Console.WriteLine($"Digite a tarefa que você deseja adcionar: ");
            var tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
            Console.Write("Sua tarefa foi adicionada...");
            Console.Read();
            continue;
        case "2":
            if (tarefas.Count() == 0)
            {
                Console.Write("Atualmente sua lista de tarefas está vazia... ");
                Console.Read();
            }
            else if (tarefas.Count() > 0)
            {
                Console.WriteLine("Você tem tarefas na sua lista: ");
                int i = 0;
                foreach (var Tarefa in tarefas)
                {
                    Console.WriteLine($"{i+1}-{tarefas[i]}");
                    i++;
                }
                Console.Read();
            }
            continue;
        case "3":
            Console.WriteLine("Você deseja remover a tarefa por nome ou por indice? ");
            var escolha_01 = Console.ReadLine();
            if (escolha.ToLower() == "nome")
            {
                
            }if (escolha.ToLower() == "indice")
            {
                
            }
            continue;
        case "4":
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