using Sistema_de_Gerenciamento_de_Estudantes.Aluno;

Console.WriteLine("--------------------------");
Console.WriteLine("GERENCIADOR DE ESTUDANTES");
Console.WriteLine("--------------------------");
int opcao = -1;
do
{
    Console.WriteLine("[1]Adicionar aluno\n[2]Exibir lista de alunos\n[0]Encerrar programa");
    Console.Write("--------------------------\nEscolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            AdicionarAluno();
            break;
        case 2:
            ExibirListaDeAlunos();
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

}
static void ExibirListaDeAlunos()
{

}