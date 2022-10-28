using ByteBank.Contas;
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

Cliente cliente = new Cliente();
cliente.nome = "Álvaro Teixeira";
cliente.cpf = "85696574178";
cliente.profissao = "Desenvolvedor";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numeroAgencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = " + conta.titular);

ContaCorrente conta2 = new ContaCorrente();

conta2.titular = new Cliente();
conta2.titular.nome = "José Souza";
conta2.titular.profissao = "Tester";
conta2.titular.cpf = "78945613274";
conta2.conta = "9999-x";
conta2.numeroAgencia = 18;
conta2.saldo = 250;

