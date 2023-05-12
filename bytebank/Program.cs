using bytebank.Conta;
using bytebank.Titular;

ContaCorrente conta = new ContaCorrente(14, "1234-v");

conta.SetSaldo(280);

conta.Titular = new Cliente();
conta.Titular.Nome = "Thiago Santos d Sousa";
conta.Titular.Cpf = "43546789-90";
conta.Titular.Profissao = "Estoquista";

Console.WriteLine(conta.GetSaldo());
Console.WriteLine(conta.Titular.Cpf);

//-------------------------------------------------------//

ContaCorrente conta2 = new ContaCorrente(13, "1678-o");
conta2.Titular = new Cliente();

conta2.Titular.Cpf = "455590573-98";


ContaCorrente conta3 = new ContaCorrente(16, "1699-e");
conta3.Titular = new Cliente();

conta3.Titular.Cpf = "455532443-00";

Console.WriteLine(conta2.Titular.Cpf);
Console.WriteLine(conta3.Titular.Cpf);

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//-------------------------------------------------------//

Console.WriteLine(Cliente.TotalClientesCadastrados);

Console.ReadLine();