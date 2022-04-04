using System;

namespace dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            
        ListaAluno lista = new ListaAluno();
        String resposta = "s";

        do{
            Aluno aluno = new Aluno();
            
            Console.WriteLine("Informe o nome do aluno");
            aluno.nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do aluno");
            aluno.idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota do aluno");
            aluno.nota = Double.Parse(Console.ReadLine());

            Console.WriteLine("Deseja inserir outro aluno");
            resposta = Console.ReadLine();

            lista.adicionar(aluno);

            if(resposta == "n")
            {   
                foreach(var item in lista.lista){
                    Console.WriteLine("O aluno: " + item.nome + " teve nota: " + lista.totalizar());
                }
            }
        } while (resposta == "s");

        }
    }
}
