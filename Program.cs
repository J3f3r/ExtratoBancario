using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGustavoPoo
{
    class Program
    {
        static void Main (string[] args)
        {
            Agencia agenciaAraraquara = new Agencia();
            agenciaAraraquara.Numero = 34;

            //criar o primeiro cliente com sua respectiva conta (e Agencia)
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Cliente 1";
            cliente1.Documento = "111.111.111-11";

            //exemplo de criação de variavel auxiliar para relacionar a conta
            Conta contaCliente1 = new Conta();
            contaCliente1.Numero = "00001-0";
            contaCliente1.Agencia = "agenciaAraraquara";
            cliente1.Conta = contaCliente1;

            //criar o segundo cliente com sua respectiva conta {e agencia]
            Cliente Cliente2 = new Cliente();
            Cliente2.Nome = "Cliente 2";
            Cliente2.Documento = "222.222.222-22";

            //exemplo sem a criação de variavel auxiliar para relacionar a conta
            Cliente2.Conta = new Conta();
            Cliente2.Conta.Numero = "000002-0";
            Cliente2.Conta.Agencia = "agenciaAraraquara";

            //executar metodos de deposito de saque para ambos clientes
            cliente1.Depositar(1000);
            contaCliente1.Sacar(100);
            //900 de saldo

            Cliente2.Depositar(500);
            Cliente2.Sacar(100);
            Cliente2.Sacar(100);
            Cliente2.Sacar(100);
            Cliente2.Sacar(100);
            //100 de saldo

            //executar metodos de transferencia entre ambos Clientes
            cliente1.Transferir(900, Cliente2.Conta);
            //cliente 1 fica com 0 de slado
            //cliente 2 fica com 1000 de saldo

            //imprimir o extrato de ambos Clientes
            cliente1.ImprimirExtrato();
            Cliente2.ImprimirExtrato();
        }

    }
}
