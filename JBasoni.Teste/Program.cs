using JBasoni.Seed.Componente.ReturnObject;
using JBasoni.Seed.Comuns.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JBasoni.Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = Criar();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pessoa criada com êxito.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Salvar().Mensagens.ForEach(x=> Console.WriteLine($"{x.Texto}"));
            Console.ReadLine();
        }

        public static Response<Pessoa> Criar()
        {
            var p = new Pessoa();
            return p.Criar("Jean", 25);
        }

        public static VoidResponse Salvar()
        {
            var p = new Pessoa();
            return p.Salvar();
        }
    }

    public class Pessoa: PropertyCrudBasico
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa Criar(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;

            return this;
        }

        public VoidResponse Salvar()
        {
            var response = new VoidResponse();
            response.AddMensagem(TipoDeMensagem.Erro, "Erro ao tentar incluir Pessoa.");

            return response;
        }

    }
}
