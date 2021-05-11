using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5_Lista
{
    class Elemento
    {
        private int _id;
        public int Id { get => _id; set => _id = value; }

        public Elemento(int id)
        {
            Id = id;
        }
    }
}
