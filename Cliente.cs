﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGustavoPoo
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public List<Cartao> Cartoes { get; set; }
        public Conta Conta { get; set; }

        public void Depositar(double valor)
        {
            Conta.Depositar(valor);
        }
        public void Sacar(double valor)
        {
            Conta.Sacar(valor);
        }
        public void Transferir(double valor, Conta destino)
        {
            Conta.Transferir(valor, destino);
        }
        public void ImprimirExtrato()
        {
            Console.WriteLine("Nome do Cliente: {0}", Nome);
            Console.WriteLine("Documnto do Cliente: {0}", Documento);
            Conta.ImprimirExtrato();
        }
    }
}
