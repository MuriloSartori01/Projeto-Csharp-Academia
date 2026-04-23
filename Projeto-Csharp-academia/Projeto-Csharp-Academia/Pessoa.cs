using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Csharp_Academia
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string email;


    }
    public void cadastrar() 
        { 
            Console.WriteLine("Digite o Nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua Idade");
            idade = Console.ReadLine();
            Console.WriteLine("Digite seu email");
            email = Console.ReadLine();



        }
        public void exibir()
        {
            Console.WriteLine("Seu Nome é" + nome);
            Console.WriteLine("Sua idade" + idade);
            Console.WriteLine("Seu email" + email);
        }
    }
