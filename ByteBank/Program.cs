using ByteBank;


Console.WriteLine("Bem Vindo ao Seu Banco, ByteBank");

ContaCorrente conta1 = new ContaCorrente(321, "321564-x", "johnatan", "321654987-65");
ContaCorrente conta2 = new ContaCorrente(653, "326569-x", "paulo", "568459326-65");
ContaCorrente conta3 = new ContaCorrente(985,"654987-x","hugo","654987326-65");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


Console.ReadKey();