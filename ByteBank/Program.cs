using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Bem Vindo ao Seu Banco, ByteBank");

//ContaCorrente conta1 = new ContaCorrente();
//ContaCorrente conta2 = new ContaCorrente();

//conta1.conta = "654321";
//conta1.numero_agencia = 134678;
//conta1.nome_agencia = "Banco Central";
//conta1.saldo = 500.12;

//conta2.conta = "321654";
//conta2.numero_agencia = 134678;
//conta2.nome_agencia = "Banco Central";
//conta2.saldo = 134.6;

//Console.WriteLine("Saldo Do Johnatan: " + conta1.saldo);
//conta1.Sacar(33);
//Console.WriteLine("Saldo Do Johnatan: " + conta1.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "johnatan";
//cliente.cpf = "56489732187";
//cliente.profissao = "vigia";

ContaCorrente conta3 = new ContaCorrente();
conta3.titular = new Cliente();
conta3.titular.nome = "johnatan";
conta3.titular.cpf = "56489732187";
conta3.titular.profissao = "vigia";
conta3.conta = "654231987-xx";
conta3.numero_agencia = 33;
conta3.nome_agencia = "Banco Central";




Console.ReadKey();