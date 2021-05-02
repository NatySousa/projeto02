using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projeto02.Repositories
{
    public class FuncinarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            var path = $"c:\\temp\\funcionario_{funcionario.Id}.txt";

            var streamWriter = new StreamWriter(path);

            streamWriter.WriteLine("\nDADOS DO FUNCIONÁRIO");
            streamWriter.WriteLine("Id........: " + funcionario.Id);
            streamWriter.WriteLine("Nome........: " + funcionario.Nome);
            streamWriter.WriteLine("Cpf........: " + funcionario.Cpf);
            streamWriter.WriteLine("Matricula........: " + funcionario.Matricula);
            streamWriter.WriteLine("Data Adm........: " + funcionario.DataAdmissao);
            streamWriter.WriteLine("Data Nasc........: " + funcionario.DataNascimento);


            streamWriter.WriteLine("\nDADOS DO SETOR");
            streamWriter.WriteLine("Id........: " + funcionario.Setor.Id);
            streamWriter.WriteLine("Sigla........: " + funcionario.Setor.Sigla);
            streamWriter.WriteLine("Nome........: " + funcionario.Setor.Nome);

            streamWriter.Close();

        }
    }
}
