using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerenciamento_de_Estudantes.Aluno
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Matricula { get; private set; }
        public static int TotalAlunos { get; private set; }
        public double[] notas = new double[3];
        public double[] Notas
        {
            get { return notas; }
            set
            {
                if (value.Length != 3)
                {
                    throw new ArgumentException("O número máximo de notas é 3.");
                }
                notas = value;
            }
        }
        public double Media()
        {
            double soma = 0;
            for (int i = 0; i < 3; i++)
            {
                soma += Notas[i];
            }
            return soma / 3;
        }
        public Aluno()
        {
            TotalAlunos++;
            Random random = new Random();
            Matricula = TotalAlunos+random.Next(3000, 3999).ToString();
        }
    }
}
