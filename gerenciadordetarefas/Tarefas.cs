
using System;

namespace ProjetoTarefas
{
    public class Tarefa
    {
        // Propriedades da classe Tarefa
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }

        // Construtor da classe Tarefa
        public Tarefa(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            DataConclusao = null;
        }

        // Construtor vazio (Método Tarefa)
        public Tarefa()
        {
            // Inicializando com valores padrão
            Titulo = "Sem Título";
            Descricao = "Sem Descrição";
            DataCriacao = DateTime.Now;
            DataConclusao = null;
        }

        // Método para concluir a tarefa
        public void ConcluirTarefa()
        {
            DataConclusao = DateTime.Now;
            Console.WriteLine($"Tarefa '{Titulo}' concluída em {DataConclusao}");
        }

        // Método para exibir as informações da tarefa
        public void ExibirTarefa()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Data de Criação: {DataCriacao}");
            if (DataConclusao.HasValue)
            {
                Console.WriteLine($"Data de Conclusão: {DataConclusao.Value}");
            }
            else
            {
                Console.WriteLine("Tarefa não concluída.");
            }
        }
    }
}
