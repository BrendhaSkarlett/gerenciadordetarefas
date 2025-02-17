using System;
using System.Collections.Generic;
using Layout;

namespace ProjetoGerenciarTarefa
{
    // Representação da tarefa
    public class Tarefa
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }

        // Construtor
        public Tarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            Concluida = false;
        }

        // Exibir tarefa
        public void ExibirTarefa()
        {
            string status = Concluida ? "Concluída" : "Pendente";
            Console.WriteLine($"Título: {Titulo}\nDescrição: {Descricao}\nStatus: {status}\n");
        }
    }

    // Classe para gerenciar tarefas
    public class GerenciarTarefa
    {
        private List<Tarefa> tarefas;

        // Construtor da classe GerenciarTarefa
        public GerenciarTarefa()
        {
            tarefas = new List<Tarefa>();
        }

        // Adicionar nova tarefa
        public void AdicionarTarefa(string titulo, string descricao)
        {
            Tarefa novaTarefa = new Tarefa(titulo, descricao);
            tarefas.Add(novaTarefa);
            Console.WriteLine($"Tarefa '{titulo}' adicionada com sucesso.");
        }

        // Listar todas as tarefas
        public void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                tarefa.ExibirTarefa();
                Console.WriteLine("----------------------------");
            }
        }

        // Editar tarefa existente
        public void EditarTarefa(string titulo, string novoTitulo, string novaDescricao)
        {
            Tarefa tarefa = tarefas.Find(t => t.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (tarefa != null)
            {
                tarefa.Titulo = novoTitulo;
                tarefa.Descricao = novaDescricao;
                Console.WriteLine($"Tarefa '{titulo}' foi atualizada para '{novoTitulo}'.");
            }
            else
            {
                Console.WriteLine($"Tarefa com o título '{titulo}' não encontrada.");
            }
        }

        // Concluir tarefa
        public void ConcluirTarefa(string titulo)
        {
            Tarefa tarefa = tarefas.Find(t => t.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Console.WriteLine($"Tarefa '{titulo}' concluída com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa com o título '{titulo}' não encontrada.");
            }
        }

        // Remover tarefa
        public void RemoverTarefa(string titulo)
        {
            Tarefa tarefa = tarefas.Find(t => t.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));

            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine($"Tarefa '{titulo}' removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Tarefa com o título '{titulo}' não encontrada.");
            }
        }
    }

    // Classe Formatacao que lida com a exibição e cores no console
    public class Formatacao
    {
        // Método para imprimir uma mensagem com uma cor personalizada
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }

        // Método para imprimir o cabeçalho e retornar a opção escolhida pelo usuário
        public static string ImprimirCabecalho()
        {
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("                           GERENCIADOR DE TAREFAS                                                   ");
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção:");

            string opcao = Console.ReadLine();
            return opcao;
        }
    }

    // Classe Program com o ponto de entrada
    class Program
    {
        static void Main(string[] args)
        {
            // Criando a instância de GerenciarTarefa
            GerenciarTarefa gerenciar = new GerenciarTarefa();
            
            bool sair = false;
            while (!sair)
            {
                // Exibe o cabeçalho e captura a opção do usuário
                string opcao = Formatacao.ImprimirCabecalho();

                switch (opcao)
                {
                    case "1":
                        // Adicionar tarefa
                        Console.WriteLine("Digite o título da tarefa:");
                        string titulo = Console.ReadLine();
                        Console.WriteLine("Digite a descrição da tarefa:");
                        string descricao = Console.ReadLine();
                        gerenciar.AdicionarTarefa(titulo, descricao);
                        break;

                    case "2":
                        // Listar tarefas
                        gerenciar.ListarTarefas();
                        break;

                    case "3":
                        // Concluir tarefa
                        Console.WriteLine("Digite o título da tarefa a ser concluída:");
                        string tarefaConcluir = Console.ReadLine();
                        gerenciar.ConcluirTarefa(tarefaConcluir);
                        break;

                    case "4":
                        // Remover tarefa
                        Console.WriteLine("Digite o título da tarefa a ser removida:");   
                        string tarefaRemover = Console.ReadLine();
                        gerenciar.RemoverTarefa(tarefaRemover);
                        break;

                    case "0":
                        // Sair
                        sair = true;
                        Formatacao.Cor("Saindo do Gerenciador de Tarefas...\n", ConsoleColor.Red);
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                // Pausa para que o usuário veja a saída antes de limpar a tela
                if (!sair)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
