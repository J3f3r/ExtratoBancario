﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGustavoPoo
{
    class Conta
    {
        public string Numero { get; set; }
        public double Limite { get; set; }
        public double Saldo { get; set; }
        public string Agencia { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            bool saqueRealizado = false;
                if (Saldo >= valor)
                {
                    Saldo -= valor;
                    saqueRealizado = true;
                }
                else 
                {
                Console.WriteLine("Saldo Insufuciente na Conta {0}", Numero);
                }

                return saqueRealizado;
        }
        public void Transferir(double valor, Conta destino)
        {
            if (this.Sacar(valor))
            {
                destino.Depositar(valor);
            }
        }
        public void ImprimirExtrato()
        {
            Console.WriteLine("Numero: {0}", Numero);
            Console.WriteLine("Agencia: {0}", Agencia);
            Console.WriteLine("Saldo: {0}", Saldo);
        }
    }
}
