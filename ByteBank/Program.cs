using ByteBank;
Console.WriteLine("Bem Vindo ao Seu Banco, ByteBank");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Johnatan Paixão";
conta1.conta = "";
conta1.numero_agencia = 134678;
conta1.nome_agencia = "Banco Central";
conta1.saldo = 134.6;

Console.WriteLine("Titular: " + conta1.titular); ;
Console.WriteLine("Conta: " + conta1.conta); ;
Console.WriteLine("numero_agencia: " + conta1.numero_agencia);
Console.WriteLine("nome_agencia" + conta1.nome_agencia);
Console.WriteLine("saldo: " + conta1.saldo);
Console.ReadKey();