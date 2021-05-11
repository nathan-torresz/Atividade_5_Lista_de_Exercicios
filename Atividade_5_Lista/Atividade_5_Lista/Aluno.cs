using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5_Lista
{
    class Aluno: Elemento
    {
        private static int _acessosAlunos = 0;
        public static int AcessosAlunos { get => _acessosAlunos; private set => _acessosAlunos = value; }
        private string _nome;
        private string _curso;
        private DateTime _dataNasc;

        public string Nome { get => _nome;  set => _nome = value; }
        public string Curso { get => _curso; private set => _curso = value; }
        public DateTime DataNasc { get => _dataNasc; private set => _dataNasc = value; }

        public Aluno(string nome, string curso, int id):base(id)
        {
            Nome = nome;
            Curso = curso;

            AcessosAlunos++;
        }
    }
}
