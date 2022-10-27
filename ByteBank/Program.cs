using ByteBank;

ContaCorrente contaAlvaro = new ContaCorrente();

contaAlvaro.titular = "Álvaro Teixeira";
contaAlvaro.numeroAgencia = 15;
contaAlvaro.conta = "1010-x";
contaAlvaro.saldo = 100;

Console.WriteLine("Saldo do Álvaro " + contaAlvaro.saldo);

