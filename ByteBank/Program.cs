﻿using ByteBank.Contas;
using ByteBank.Titular;

//ContaCorrente contaAlvaro = new ContaCorrente();

//contaAlvaro.titular = "Álvaro Teixeira";
//contaAlvaro.numeroAgencia = 15;
//contaAlvaro.conta = "1010-x";
//contaAlvaro.saldo = 100;

//Console.WriteLine("Saldo do Álvaro " + contaAlvaro.saldo);

//contaAlvaro.Depositar(50);

//Console.WriteLine("Saldo do Álvaro pós-deposito " + contaAlvaro.saldo);

//if(contaAlvaro.Sacar(50)==true)
//    Console.WriteLine("Saldo do Álvaro pós-saque " + contaAlvaro.saldo);
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque");
//}

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numeroAgencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

//contaAlvaro.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do Alvaro = " + contaAlvaro.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//ContaCorrente contaPedro = new ContaCorrente();
//contaPedro.titular = "Pedro Silva";
//Console.WriteLine(contaPedro.titular);
//Console.WriteLine(contaPedro.saldo);
//Console.WriteLine(contaPedro.numeroAgencia);
//Console.WriteLine(contaPedro.conta);

//Cliente cliente = new Cliente();
//cliente.nome = "Álvaro Teixeira";
//cliente.cpf = "85696574178";
//cliente.profissao = "Desenvolvedor";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular);

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "78945613274";
//conta2.conta = "9999-x";
//conta2.numeroAgencia = 18;
//conta2.saldo = 250;

//ContaCorrente conta3 = new ContaCorrente();
//conta3.SetSaldo(200);
//conta3.NumeroAgencia = 18;
//conta3.Conta = "1011-h";
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.NumeroAgencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18,"1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.NumeroAgencia);


ContaCorrente conta5 = new ContaCorrente(283,"1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas); // é preciso referenciar a classe e não o objeto 


