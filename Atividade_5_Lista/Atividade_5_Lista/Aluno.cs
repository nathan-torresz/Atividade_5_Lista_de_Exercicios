using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5_Lista
{
    class Aluno: Elemento
    {
        private string _nome;
        private string _curso;
        private DateTime _data;
        public string Nome { get => _nome; private set => _nome = value; }
        public string Curso { get => _curso; private set => _curso = value; }
        public DateTime Data { get => _data; private set => _data = value; }


    }
}
