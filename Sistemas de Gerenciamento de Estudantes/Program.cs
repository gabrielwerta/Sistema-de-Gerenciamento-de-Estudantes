using Sistema_de_Gerenciamento_de_Estudantes.Aluno;
namespace Sistemas_de_Gerenciamento_de_Estudantes;

public class Program
{
    static List<Aluno> alunos = new List<Aluno>();
    public static void Main(string[] args)
    {
        string opcao;
        do
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("GERENCIADOR DE ESTUDANTES");
            Console.WriteLine("--------------------------");
            Console.WriteLine("[1]Adicionar aluno\n[2]Exibir lista de alunos\n[0]Encerrar programa");
            Console.Write("--------------------------\nEscolha uma opção: ");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    AdicionarAluno();
                    break;
                case "2":
                    ExibirListaDeAlunosEInfos();
                    break;  
                case "0":
                    Console.WriteLine("Consulta finalizada");
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
            
        } while (opcao != "0");

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
            
            Console.WriteLine("Matrícula gerada: "+novoAluno.Matricula);
            alunos.Add(novoAluno);
            Console.WriteLine("Aluno adicionado com sucesso!");
            Thread.Sleep(2000); //aguarda um 2 segs para executar o próximo comando
            Console.Clear();
        }
        static void ExibirListaDeAlunosEInfos()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Lista de alunos e matrículas: ");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno.Nome+" | "+aluno.Matricula);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.Write("Digite a matrícula do aluno para mostrar suas informações: ");
            String alunoEscolhido = Console.ReadLine();
            MostrarInfosDoAluno(alunoEscolhido);
        }
        
        static void MostrarInfosDoAluno(string matriculaAlunoEscolhido)
        {
            Console.WriteLine("---------------------------");
            foreach (var aluno in alunos)
            {
                if (matriculaAlunoEscolhido == aluno.Matricula)
                {
                    Console.WriteLine("Nome: " + aluno.Nome);
                    Console.WriteLine("Idade: " + aluno.Idade);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Nota "+(i+1)+": " + aluno.Notas[i]);  
                    }

                    Console.WriteLine("Média: "+aluno.Media());
                    Console.WriteLine("Matrícula: "+aluno.Matricula);
                    
                }
                else
                {
                    Console.WriteLine("Nome de aluno inválido, tente nomes que estão na lista!");
                }
            }
        }
    }
}