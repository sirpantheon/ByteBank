using ByteBank;


Console.WriteLine("Bem Vindo ao Seu Banco, ByteBank");

ContaCorrente conta1 = new ContaCorrente(321, "321564-x");
ContaCorrente conta2 = new ContaCorrente(653, "326569-x");
ContaCorrente conta3 = new ContaCorrente(985,"654987-x");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


Console.ReadKey();