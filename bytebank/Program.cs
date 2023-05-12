
using bytebank;

//ContaCorrente contaDoAndre = new ContaCorrente();

//contaDoAndre.titular = "André Silva Soares";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo atual: " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();

//contaDaMaria.titular = "Maria Sousa de Jesus";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "2020-x";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo atual: " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine("Saldo atual após transferência: " + contaDaMaria.saldo);
//Console.WriteLine("Saldo atual após transferência: " + contaDoAndre.saldo);

//contaDoAndre.Depositar(100);

//Console.WriteLine("Saldo atual após deposito: " + contaDoAndre.saldo);

// if(contaDoAndre.Sacar(250) == true)
// {
//    Console.WriteLine("Saldo atual após saque: " + contaDoAndre.saldo);
// }
// else
// {
//    Console.WriteLine("Saldo insuficiente.");
// }

//ContaCorrente contaDoPedro = new ContaCorrente();

//contaDoPedro.titular = "Pedro ALves de Morais";
//contaDoPedro.numero_agencia = 21211545;
//contaDoPedro.conta = "1015-x";
//contaDoPedro.saldo = 100;

//ContaCorrente contaDoPedro2 = new ContaCorrente();

//contaDoPedro2.titular = "Pedro ALves de Morais";
//contaDoPedro2.numero_agencia = 21211545;
//contaDoPedro2.conta = "1015-x";
//contaDoPedro2.saldo = 100;

//Console.WriteLine(contaDoPedro == contaDoPedro2);

//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);

Cliente cliente = new Cliente();

cliente.nome = "Thiago Santos de Sousa";
cliente.cpf = "095748477-38";
cliente.profissao = "programador web";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.numero_agencia = 18;
conta.conta = "1010-y";
conta.saldo = 1500.00;

Console.WriteLine("titlar: " + conta.titular.nome);
Console.WriteLine("CPF: " + conta.titular.cpf);
Console.WriteLine("Profissão: " + conta.titular.profissao);
Console.WriteLine("Nº Agência: " + conta.numero_agencia);
Console.WriteLine("Nº Conta: " + conta.conta);
Console.WriteLine("Saldo: " + conta.saldo);

Console.ReadLine();