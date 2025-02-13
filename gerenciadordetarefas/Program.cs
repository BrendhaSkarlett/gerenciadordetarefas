using System;
using Layout;
using GerenciarTarefa;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciarTarefa.Gerenciar gerenciar = new GerenciarTarefa.Gerenciar();
            
            // Exibe o cabeçalho do sistema
            Layout.Formatacao.ImprimirCabecalho();

            // Exemplo de adição de tarefas
            gerenciar.AdicionarTarefa("Estudar C#");
            gerenciar.AdicionarTarefa("Comprar mantimentos");

            // Exibe a lista de tarefas
            gerenciar.ListarTarefa();

            // Concluir uma tarefa
            gerenciar.ConcluirTarefa(1);

            // Exibe a lista de tarefas novamente
            gerenciar.ListarTarefa();

            // Remover uma tarefa
            gerenciar.RemoverTarefa(2);

            // Exibe a lista de tarefas após a remoção
            gerenciar.ListarTarefa();

            // Exemplo de exibição de mensagem colorida
            Layout.Formatacao.Cor("Esta é uma mensagem de alerta!", "vermelho");

            Console.ReadKey();
        }
    }
}
