using System;
using Projeto02.Entities;
using Projeto02.Repositories;


namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n--- CONTROLE DE FUNCIONÁRIO --- \n");

            var funcionario = new Funcionario();
            funcionario.Setor = new Setor();

            funcionario.Id = Guid.NewGuid();

            Console.Write("Informe o nome do funcionário....:");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe oCpf do funcionário....:");
            funcionario.Cpf = Console.ReadLine();


            Console.Write("Matrícula  do funcionário....:");
            funcionario.Matricula= Console.ReadLine();

            Console.Write("Data de Nascimento  do funcionário....:");
            funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Data de Admissão do funcionário....:");
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe a Sigla do Setor.Length....:");
            funcionario.Setor.Sigla = Console.ReadLine();

            Console.Write("Informe o nome do Setor....:");
            funcionario.Setor.Nome = Console.ReadLine();

              Console.WriteLine("\nDADOS DO FUNCIONÁRIO");
            Console.WriteLine("ID..............:" + funcionario.Id);
            Console.WriteLine("Nome..............:" + funcionario.Nome);
            Console.WriteLine("Cpf..............:" + funcionario.Cpf);
            Console.WriteLine("Matricula..............:" + funcionario.Matricula);
            Console.WriteLine("Data de Admissão..............:" + funcionario.DataAdmissao);
            Console.WriteLine("Data de Nasc.............:" + funcionario.DataNascimento);

            Console.WriteLine("\nDADOS DO SETOR");
            Console.WriteLine("Id Setor..........:" + funcionario.Setor.Id);
            Console.WriteLine("Sigla.............:" + funcionario.Setor.Sigla);
            Console.WriteLine("Nome do Setor.....:" + funcionario.Setor.Nome);

            var funcionarioRepository = new FuncinarioRepository();
            

            try
            {
                funcionarioRepository.ExportarDados(funcionario);

                Console.WriteLine("\nDados gravados com sucesso!");

            }
            catch(Exception e)
            {

                Console.WriteLine("\nErro: " + e.Message);

            }

            Console.ReadKey();







        }
    }
}
