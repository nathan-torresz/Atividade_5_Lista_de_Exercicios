﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5_Lista
{
    class CadastroGenerico
    {
        private List<Elemento> _elementos;
        public List<Elemento> Elementos { get => _elementos; set => _elementos = value; }

        public CadastroGenerico()
        {
            Elementos = new List<Elemento>();
        }
        public void Incluir(Elemento e)
        {
            if(Elementos.IndexOf(e) == -1)
            Elementos.Add(e);
        }
        public void Excluir(int id)
        {
            Console.WriteLine("Digite o id do aluno que deseja excluir:");
            id = int.Parse(Console.ReadLine());
            
        }
        public Elemento Busca(int id)
        {
            Console.WriteLine("Digite o id do aluno que procura: ");
            id = int.Parse(Console.ReadLine());
            foreach(Elemento e in Elementos)
            {
                if (((Aluno)e).Id.Equals(id)) return e;
            }
            return null;
        }
    }
}
