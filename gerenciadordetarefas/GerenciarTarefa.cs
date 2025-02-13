using System;
using System.Collections.Generic;
using Tarefas;

namespace GerenciarTarefa
{
    public class Gerenciar
    {
        private List<Tarefa> tarefas = new List<Tarefa>();

        public void AdicionarTarefa(string descricao)
        {
            int id = tarefas.Count + 1; // ID simples baseado na quantidade de tarefas
            Tarefa novaTarefa = new Tarefa(id, descricao);
            tarefas.Add(novaTarefa);
            Console.WriteLine($"Tarefa '{descricao}' adicionada com sucesso!");
        }

        public void ConcluirTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Console.WriteLine($"Tarefa ID {id} concluída!");
            }
            else
            {
                Console.WriteLine($"Tarefa ID {id} não encontrada.");
            }
        }

        public void ListarTarefa()
        {
            Console.WriteLine("Lista de Tarefas:");
            foreach (var tarefa in tarefas)
            {
                string status = tarefa.Concluida ? "Concluída" : "Pendente";
                Console.WriteLine($"ID: {tarefa.Id}, Descrição: {tarefa.Descricao}, Status: {status}");
            }
        }

        public void RemoverTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine($"Tarefa ID {id} removida com sucesso!");
            }
            else
            {
                Console.WriteLine($"Tarefa ID {id} não encontrada.");
            }
        }
    }
}
