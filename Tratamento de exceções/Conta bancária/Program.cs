using System;
using Conta_bancária__exceções_.Entities.Exceptions;
using Conta_bancária__exceções_.Entities;

namespace Conta_bancária__exceções_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta:");
                Console.Write("Número: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Titular: ");
                string titular = Console.ReadLine();

                Console.Write("Saldo: ");
                double saldo = double.Parse(Console.ReadLine());

                Console.Write("Limite de saldo: ");
                double limiteDeSaldo = double.Parse(Console.ReadLine());

                Account account = new Account(numero, titular, saldo, limiteDeSaldo);

                Console.Write("Digite o valor de saque: ");
                double saque = double.Parse(Console.ReadLine());
                account.Saque(saque);

                Console.WriteLine(account);

            }

            catch (FormatException e)
            {
                Console.WriteLine("Erro de formato: " + e.Message);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

        }   
    }
}
