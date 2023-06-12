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
                    if (Aluno.TotalAlunos > 0) // valida se há alunos para ser mostrado
                    {
                        ExibirListaDeAlunosEInfos();
                    }
                    else
                    {
                        Console.WriteLine("Não há alunos cadastrados! Adione um aluno...");
                        Thread.Sleep(2500); //aguarda um 2 segs para executar o próximo comando
                        Console.Clear();
                    }
                    
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
            bool idadeValida = false;
            while (idadeValida == false)
            {
                try
                {
                    int idade = int.Parse(Console.ReadLine());

                    if (idade >= 1 && idade <= 100)
                    {
                        novoAluno.Idade = idade;
                        idadeValida = true;
                    }
                    else
                    {
                        Console.Write("Idade inválida. Digite uma idade entre 1 e 100 anos: ");
                        // Solicite que o usuário insira novamente a idade ou tome uma ação apropriada.
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Idade inválida. Digite um número inteiro válido: ");
                    // Solicite que o usuário insira novamente a idade ou tome uma ação apropriada.
                }
            }
            
            

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Digite a "+(i+1)+"a nota: ");
                novoAluno.Notas[i] = double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Matrícula gerada: "+novoAluno.Matricula);
            alunos.Add(novoAluno);
            Console.WriteLine("Aluno adicionado com sucesso!");
            Thread.Sleep(2500); //aguarda um 3 segs para executar o próximo comando
            Console.Clear();
        }
        static void ExibirListaDeAlunosEInfos()
        {
            Thread.Sleep(1000); //aguarda um 1 segs para executar o próximo comando
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Lista de alunos e matrículas: ");
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno.Nome+" | "+aluno.Matricula);
            }
            Console.WriteLine("----------------------");
            bool matriculaValida = false;
            while (matriculaValida == false)
            {
                Console.Write("Digite a matrícula do aluno para mostrar suas informações: ");
                String matriculaEscolhida = Console.ReadLine();
            
                //foreach que verifica se há algum aluno com o número de matricula digitado
                foreach (var aluno in alunos)
                {
                    if (matriculaEscolhida == aluno.Matricula)
                    {
                        Thread.Sleep(1000); //aguarda um 1 segs para executar o próximo comando
                        Console.Clear();
                        MostrarInfosDoAluno(matriculaEscolhida);
                        matriculaValida = true;
                    }    
                }
            
            } 
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

            }
        }
    }
}