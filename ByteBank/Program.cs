using ByteBank;

ContaCorrente contaAlvaro = new ContaCorrente();

contaAlvaro.titular = "Álvaro Teixeira";
contaAlvaro.numeroAgencia = 15;
contaAlvaro.conta = "1010-x";
contaAlvaro.saldo = 100;

Console.WriteLine("Saldo do Álvaro " + contaAlvaro.saldo);

contaAlvaro.Depositar(50);

Console.WriteLine("Saldo do Álvaro pós-deposito " + contaAlvaro.saldo);

if(contaAlvaro.Sacar(50)==true)
    Console.WriteLine("Saldo do Álvaro pós-saque " + contaAlvaro.saldo);
else
{
    Console.WriteLine("Saldo insuficiente para saque");
}

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numeroAgencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);

contaAlvaro.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo do Alvaro = " + contaAlvaro.saldo);
Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

ContaCorrente contaPedro = new ContaCorrente();
contaPedro.titular = "Pedro Silva";
Console.WriteLine(contaPedro.titular);
Console.WriteLine(contaPedro.saldo);
Console.WriteLine(contaPedro.numeroAgencia);
Console.WriteLine(contaPedro.conta);