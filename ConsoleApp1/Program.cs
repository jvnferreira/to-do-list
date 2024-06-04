namespace ListaDeTarefas
{
    class Program
    {
        static List<string> listaDeTarefas = new List<string>();

        static void Main(string[] args)
        {
            bool start = true;

            while(start)
            {
                Console.Clear();
                Console.WriteLine("Lista de tarefas\n");
                Console.WriteLine("1. Adicionar tarefa");
                Console.WriteLine("2. Mostrar tarefas");
                Console.WriteLine("3. Remover tarefa");
                Console.WriteLine("4. Sair\n");
                Console.Write("Escolha uma opção: ");

                string escolha = Console.ReadLine();

                if(int.Parse(escolha) == 1)
                {
                    AddTarefa();
                }else if(int.Parse(escolha) == 2)
                {
                    MostrarTarefas();
                }else if(int.Parse(escolha) == 3)
                {
                    RemoverTarefa();
                }else if(int.Parse(escolha) == 4)
                {
                    start = false;
                } else
                {
                    Console.WriteLine("Opção inválida, pressione alguma tecla para continuar.");
                    Console.ReadKey();
                }
            }
        }

        static void AddTarefa()
        {
            Console.Clear();
            Console.Write("Insira uma nova tarefa: ");
            string tarefa = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(tarefa))
            {
                listaDeTarefas.Add(tarefa);
                Console.WriteLine("Tarefa adicionada!");
            } else
            {
                Console.WriteLine("Tarefa inválida!");
            }
            Console.WriteLine("Pressione alguma tecla para continuar.");
            Console.ReadKey();
        }

        static void MostrarTarefas()
        {
            Console.Clear();
            Console.WriteLine("Lista de tarefas:\n");
            if(listaDeTarefas.Count == 0)
            {
                Console.WriteLine("Não há tarefas registradas.");
            } else
            {
                for(int i = 0; i < listaDeTarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaDeTarefas[i]}");
                }
            }
            Console.WriteLine("Pressione alguma tecla para continuar.");
            Console.ReadKey();
        }

        static void RemoverTarefa()
        {
            Console.Clear();
            Console.WriteLine("Lista de tarefas:\n");
            if(listaDeTarefas.Count == 0)
            {
                Console.WriteLine("Não há tarefas registradas.");
            } else
            {
                for(int i = 0; i < listaDeTarefas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaDeTarefas[i]}");
                }
                Console.Write("Insira o número da tarefa que deseja remover: ");
                if(int.TryParse(Console.ReadLine(), out int numTarefa) && numTarefa > 0 && numTarefa <= listaDeTarefas.Count)
                {
                    listaDeTarefas.RemoveAt(numTarefa - 1);
                    Console.WriteLine("Tarefa removida!");
                } else
                {
                    Console.WriteLine("Tarefa inválida.");
                }
            }
            Console.WriteLine("Pressione alguma tecla para continuar.");
            Console.ReadKey();
        }
    }
}
