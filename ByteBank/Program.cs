using ByteBank;
Console.WriteLine("Bem Vindo ao Seu Banco, ByteBank");

ContaCorrente conta1 = new ContaCorrente();
ContaCorrente conta2 = new ContaCorrente();

conta1.titular = "Johnatan Paixão";
conta1.conta = "654321";
conta1.numero_agencia = 134678;
conta1.nome_agencia = "Banco Central";
conta1.saldo = 500.12;

conta2.titular = "Narjara Paixão";
conta2.conta = "321654";
conta2.numero_agencia = 134678;
conta2.nome_agencia = "Banco Central";
conta2.saldo = 134.6;

Console.WriteLine("Saldo Do Johnatan: " + conta1.saldo);
conta1.Sacar(33);
Console.WriteLine("Saldo Do Johnatan: " + conta1.saldo);

Console.ReadKey();