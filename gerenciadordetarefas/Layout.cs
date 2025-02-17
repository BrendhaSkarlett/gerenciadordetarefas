namespace Layout
{
    public class Formatacao
    {
        public static void Cor(string mensagem, string cor)
        {
            // Aqui, podemos configurar a cor do texto com base no parâmetro 'cor'
            // Para simplificação, vamos apenas usar o ConsoleColor
            switch (cor.ToLower())
            {
                case "vermelho":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "verde":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "azul":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.WriteLine(mensagem);
            Console.ResetColor(); // Reseta a cor após exibir a mensagem
        }

        public static string? ImprimirCabecalho()
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

        
            string opção = Console.ReadLine();
            return opção;

            
             
            

        }
    }
}
