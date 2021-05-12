using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_5_Lista
{
    class CadastroGenerico
    {
        private static List<Elemento> _elementos = new List<Elemento>();
        public static List<Elemento> Elementos { get => _elementos; set => _elementos = value; }
       
        private static int _acessosAlunos = 0;
        public static int AcessosAlunos { get => _acessosAlunos; private set => _acessosAlunos = value; }
        
   
        public static void Incluir(Elemento e)
        {
            AcessosAlunos++;
            Elementos.Add(e);
        }
        public static void Excluir(int id)
        {
            for (int i = 0; i < Elementos.Count; i++)
            {
                Elemento e = Elementos[i];
                if (((Aluno)e).Id == id)
                {
                    Elementos.Remove(e);
                }
            }
           
           
        }
        public static Elemento Busca(int id)
        {
            foreach(Elemento e in Elementos)
            {
                if (((Aluno)e).Id.Equals(id))
                {
                    Console.WriteLine($"{((Aluno)e).Nome} selecionado");
                 
                }
                else
                {
                    Console.WriteLine("Aluno não cadastrado no sistema!");
                }
            }
            return null;
        }
        public static List<Elemento> BuscarTodos()
        {
            return Elementos;
        }

        public static void QtdAcessosAlunos()
        {
            Console.WriteLine($"Númeor de Acessos: {AcessosAlunos}");
        }
    }
}
