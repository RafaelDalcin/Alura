using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        // -----------------> Atributos <--------------------- //
        public static int TotalDeContasCriadas { get; private set; }

        private static int numeroAgencia;
        public int NumeroAgencia
        {
            get { return numeroAgencia; }
            private set
            {
                if (value > 0)
                {
                    numeroAgencia = value;
                }
            }
        }

        // -----------------> Métodos <--------------------- //
        public string Conta { get; set; }
        private double saldo = 100;
        public Cliente Titular { get; set; }

        public ContaCorrente(Cliente titular, int numeroAgencia, string conta) {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            Titular = titular;
        }
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;

            }
            else { return false; }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                destino.Depositar(valor);
                return true;
            }
            else { return false; }
        }
        public void setSaldo (double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        public double getSaldo()
        {
            return this.saldo;
        }
    }
}
