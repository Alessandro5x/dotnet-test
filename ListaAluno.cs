using System.Collections.Generic;

namespace dotNet
{
    public class ListaAluno
    {
        public List<Aluno> lista = new List<Aluno>();
        public void adicionar(Aluno aluno)
        {
            lista.Add(aluno);
        }

        public double totalizar(){

            double total = 0;
            for (int i=0; i < lista.Count; i++)
            {
                total += lista[i].nota;
            }
            
            return total;
        }
    }
}