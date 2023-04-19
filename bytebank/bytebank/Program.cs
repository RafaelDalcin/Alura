using bytebank.Contas;
using bytebank.Titular;
using System.Runtime.CompilerServices;

Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";
sarah.Profissao = "Professora";
sarah.CPF = "11111111-12";

Cliente ester = new Cliente();
ester.Nome = "Ester Almeida";
ester.Profissao = "Advogada";
ester.CPF = "868524125-32";


ContaCorrente conta5 = new ContaCorrente(sarah, 283, "2999-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(ester, 283, "1329-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.WriteLine(conta5);



//}

