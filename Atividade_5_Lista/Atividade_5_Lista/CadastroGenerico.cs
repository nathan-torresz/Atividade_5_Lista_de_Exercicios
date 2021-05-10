using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5_Lista
{
    class CadastroGenerico
    {
        private List<Elemento> _elementos;
        public List<Elemento> Elementos { get => _elementos; private set => _elementos = value; }


        public void Incluir(Elemento e)
        {
            Elementos.Add(e);
        }

        public void Excluir(int id)
        {
            
        }

        public Elemento busca(int id)
        {
            
        }

        public List<Elemento> BuscarTodos()
        {

        }
    }
}
