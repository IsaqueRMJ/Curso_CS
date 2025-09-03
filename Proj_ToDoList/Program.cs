List<string> tarefas = new List<string>() { };
while (true)
{
    Console.WriteLine("\nBem vindo(a) a sua lista de tarefas");
    Console.Write("1-Adicionar tarefa\n2-Listar terefas\n3-Remover tarefa\n4-Sair\n\n");
    var escolha = Console.ReadLine();
    switch (escolha)
    {
        case "1"://Adicionar itens
            while (true)
            {
                Console.WriteLine($"Digite a tarefa que você deseja adcionar: ");
                var tarefa = Console.ReadLine();
                tarefas.Add(tarefa);
                Console.Write("Sua tarefa foi adicionada...\n");

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
        case "2"://Listar itens
            if (tarefas.Count() == 0)//Confere se tem algo na lista
            {
                Console.Write("Atualmente sua lista de tarefas está vazia... ");
                Console.Read();
            }
            else if (tarefas.Count() > 0)//Se tiver algo ele mostra os itens
            {
                Console.WriteLine("Você tem tarefas na sua lista: ");
                int i = 0;
                foreach (var Tarefa in tarefas)//Para cada item na lista ele repete
                {
                    Console.WriteLine($"{i + 1}-{tarefas[i]}");
                    i++;
                }
                Console.Read();
            }
            continue;
        case "3"://Remover tarefa
            if (tarefas.Count() == 0)//Verificar se tem algo na lista
            {
                Console.Write("Atualmente sua lista de tarefas está vazia... ");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Você deseja remover a tarefa por nome ou por indice? ");//Remover de acordo com a listagem ou pelo a escrita da tarefa
                escolha = Console.ReadLine();
                if (escolha.ToLower() == "nome")//Por escrito
                {
                    Console.WriteLine("Digite a tarefa (escreva por extenso)");
                    var tarefaRemove = Console.ReadLine();
                    if (tarefas.IndexOf(tarefaRemove) == -1)//Se não tiver ele avisa que não existe essa tarefa
                    {
                        Console.WriteLine("Esse item não está na lista...");
                        Console.Read();
                    }
                    else
                    {
                        tarefas.Remove(tarefaRemove);
                        Console.Write("Removido com sucesso...");
                        Console.Read();
                    }
                        

                    
                }
                else if (escolha.ToLower() == "indice")//Por numero
                {
                    Console.WriteLine("Digite o indice da tarefa(valor numérico)");
                    var tarefaRemove = Convert.ToInt32(Console.ReadLine());
                    if (tarefaRemove > tarefas.Count() || tarefaRemove <= 0)
                    {
                        Console.WriteLine("Esse item não está na lista...");
                        Console.Read();
                    }
                    else
                    {
                        tarefas.RemoveAt(tarefaRemove - 1);
                        Console.Write("Removido com sucesso...");
                        Console.Read();
                    }
                    
                }
                else
                {
                    Console.WriteLine("ERROR, opção inexistente, retornando ao menu...");
                    Console.Read(); 
                }
                    
                
            }

            continue;
        case "4"://Sair
            Console.WriteLine("Saindo...");
            Console.Read();
            break;
            
        default://Digitar um valor não existente
            Console.WriteLine("Valor inválido, tente novamente...");
            Console.Read();
            continue;

    }
    break;
}