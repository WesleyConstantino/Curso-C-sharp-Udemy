using System;
using System.Collections.Generic;
using Conta_bancária__exceções_.Entities.Exceptions;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Conta_bancária__exceções_.Entities
{
    class Account
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaldo { get; set; }

        public Account()
        {
        }

        public Account(int numero, string titular, double saldo, double limiteDeSaldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteDeSaldo = limiteDeSaldo;
        }

        public void Deposito(double saldo)
        {
            saldo = Saldo;
        }

        public void Saque(double saque)
        {
            if(saque > Saldo)
            {
                throw new System.Exception("O saque não pode ser maior que o saldo!");
            }
            else if(saque > LimiteDeSaldo)
            {
                throw new System.Exception("O saque não pode ser maior que o limite de saldo!");
            }

            Saldo -= saque;
        }

        public override string ToString()
        {
            return "Novo saldo: "
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
