using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercFixacacao
{
    class ContaBancaria
    {
        public int NumConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numConta, string nomeTitular, double saldo)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public ContaBancaria(int numConta, string nomeTitular)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
        }

        public void AdicionarSaldo(double saldo)
        {
            Saldo += saldo;
        }
        public void RemoverSaldo(double saque)
        {
            Saldo -= (saque + 5.00) ;
        }

        public override string ToString()
        {
            return "Conta: " + NumConta + ", " +
                "Titular: " + NomeTitular + ", " + "Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
