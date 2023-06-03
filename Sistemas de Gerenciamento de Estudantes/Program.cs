using Sistema_de_Gerenciamento_de_Estudantes.Aluno;

public class Program
{
    static List<Aluno> alunos = new List<Aluno>();
    public static void Main(string[] args)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("GERENCIADOR DE ESTUDANTES");
        
        int opcao = -1;
        do
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("[1]Adicionar aluno\n[2]Exibir lista de alunos\n[0]Encerrar programa");
            Console.Write("--------------------------\nEscolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    AdicionarAluno();
                    break;
                case 2:
                    ExibirListaDeAlunosEInfos();
                    break;  
                case 0:
                    Console.WriteLine("Consulta finalizada");
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }

        } while (opcao != 0);

        static void AdicionarAluno()
        {
            Aluno novoAluno = new Aluno();
            Console.Write("Nome do aluno: ");
            novoAluno.Nome = Console.ReadLine();
            Console.Write("Idade do aluno: ");
            novoAluno.Idade = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite a "+(i+1)+"a nota: ");
                novoAluno.Notas[i] = double.Parse(Console.ReadLine());
            }
            alunos.Add(novoAluno);
        }
        static void ExibirListaDeAlunosEInfos()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Lista de alunos: ");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno.Nome);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Digite o nome do aluno para mostrar suas informações: ");
            String alunoEscolhido = Console.ReadLine();
            
            Console.WriteLine("---------------------------");
            MostrarInfosDoAluno(alunoEscolhido);
        }
        
        static void MostrarInfosDoAluno(string nomeAlunoEscolhido)
        {
            foreach (var aluno in alunos)
            {
                if (nomeAlunoEscolhido == aluno.Nome)
                {
                    Console.WriteLine("Nome: " + aluno.Nome);
                    Console.WriteLine("Idade: " + aluno.Idade);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Nota "+(i+1)+": " + aluno.Notas[i]);  
                    }
                    
                }
                else
                {
                    Console.WriteLine("Nome de aluno inválido, tente nomes que estão na lista!");
                }
            }
        }
    }
}
