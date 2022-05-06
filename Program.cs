using System;

namespace notas_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[10];
            int numeroAluno=0;
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper()!="X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome");
                        var aluno = new Aluno();
                        aluno.Nome=Console.ReadLine();
                        Console.WriteLine("Informe a nota");
                        aluno.Nota= double.Parse(Console.ReadLine());
                        alunos[numeroAluno]= aluno;
                        numeroAluno++;
                        
                        break;

                    case "2":
                        foreach (var a in alunos)
                        {
                            if (a!=null)
                            {
                            Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                            }
                        }
                        break;

                    case "3":
                    double notaTotal=0;
                    var nrAlunos=0;

                        for (int i=0; i < alunos.Length; i++)
                        {
                            if (alunos[i]!=null)
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        Console.WriteLine($"Media Geral:{notaTotal/nrAlunos}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();

                 
                }
                   opcaoUsuario = ObterOpcaoUsuario();
            }      
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Selecione a opcao Desejada");
            Console.WriteLine("1- Adicionar novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular media geral");
            Console.WriteLine("X- Para sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }

    }
}
