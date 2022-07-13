using System;
using System.Globalization;
using System.Collections.Generic;

namespace Curso
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Quantos funcionários deseja cadastrar? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite a id do funcionário que terá aumento salarial: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario func = lista.Find(x => x.Id == idAumento);
            if (func != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentaSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários: ");
            foreach (Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
