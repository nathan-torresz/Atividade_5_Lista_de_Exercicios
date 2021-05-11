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
            Aluno a2 = new Aluno("Igor", "TI", 28, new DateTime(2002, 09, 08));
            CadastroAluno.Incluir(a1);
            CadastroAluno.Incluir(a2);
            ListarAlunos();
            CadastroGenerico.Excluir(28);
            ListarAlunos();




        }

        public static void ListarAlunos()
        {
            Console.WriteLine($"=====Lista de Alunos Cadastrados=====");
           foreach(Aluno a in Alunos)
            {
                Console.WriteLine($"ID: {a.Id} Nome: {a.Nome} Curso: {a.Curso} Data Nasc.:{a.DataNasc.Day}/{a.DataNasc.Month}/{a.DataNasc.Year}");
            }
        }
    }
}
