using System;
using System.Collections.Generic;

namespace Atividade_5_Lista
{
    class Program
    {
        public static List<Elemento> Alunos = CadastroAluno.BuscarTodos();
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Nathan", "TI", 001,new DateTime(2002, 02, 21));
            Aluno a2 = new Aluno("Igor", "TI", 028, new DateTime(2002, 09, 08));
            Aluno a3 = new Aluno("Kawany", "Medicina", 053, new DateTime(2004, 11, 15));
            CadastroAluno.Incluir(a1);
            CadastroAluno.Incluir(a2);
            CadastroAluno.Incluir(a3);
            ListarAlunos();
            CadastroGenerico.Excluir(028);
            ListarAlunos();
            CadastroGenerico.QtdAcessosAlunos();
            ListarAlunos();
            CadastroGenerico.Excluir(053);
            ListarAlunos();
            CadastroGenerico.Busca(001);

            Console.ReadKey();
        }

        public static void ListarAlunos()
        {
            Console.WriteLine($"=====Lista de Alunos Cadastrados=====");
           foreach(Aluno a in Alunos)
            {
                Console.WriteLine($"ID: {a.Id} Nome: {a.Nome} Curso: {a.Curso} Data Nasc.:{a.DataNasc.Day}/{a.DataNasc.Month}/{a.DataNasc.Year}");
            }
            Console.WriteLine();
        }
    }
}
