using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5_Lista
{
    class Aluno: Elemento
    {
        private string _nome;
        private string _curso;
        private DateTime _dataNasc;

        public string Nome { get => _nome;  set => _nome = value; }
        public string Curso { get => _curso; private set => _curso = value; }
        public DateTime DataNasc { get => _dataNasc; set => _dataNasc = value; }

        public Aluno(string nome, string curso, int id, DateTime data):base(id)
        {
            Nome = nome;
            Curso = curso;
            DataNasc = data;
        }
    }
}
